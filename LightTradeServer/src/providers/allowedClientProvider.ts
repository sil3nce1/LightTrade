import WebSocket from "ws";
import { getRepository } from "typeorm";
import { Account } from "../models/Account";
import { TokenPayload } from "../interfaces/TokenPayload";
import * as jwt from "jsonwebtoken"; 
import { NetworkMessageEnum } from "../enums/NetworkMessageEnum";


class AllowedClientProvider {
    private clients: Map<string, WebSocket>;
    
    constructor() {
        this.clients = new Map<string, WebSocket>();
    }

    public async addClient(client: WebSocket, authToken: string, ipAddress: string): Promise<string> {
        const accountRepository = getRepository(Account);
        
        const tokenPayload = jwt.verify(authToken, process.env.JWT_SECRET_KEY) as TokenPayload;
        const account = await accountRepository.findOne({email: tokenPayload.email, password: tokenPayload.password});
        if (!account)
            return null;
        
        if (tokenPayload.ipAddress != ipAddress)
            return null;

        //if (!account.hasPlan())
            //return null;

        this.clients.set(account.id, client);
        client.send(JSON.stringify({id: NetworkMessageEnum.CONNECT, success: true, clientId: account.id}));
        return account.id;
    }

    public removeClient(client: WebSocket): void {
        for (const [key, value] of this.clients.entries()) {
            if (value == client)
                this.clients.delete(key);
        }
    }

    public getClientId(client: WebSocket): string {
        for (const [key, value] of this.clients.entries()) {
            if (value == client)
                return key;
        }
    }

    public getClientById(id: string): WebSocket {
        return this.clients.get(id);
    }
}

export default new AllowedClientProvider();