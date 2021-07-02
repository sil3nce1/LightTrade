import { getRepository } from "typeorm";
import WebSocket from "ws";
import { BrokerEnum } from "../enums/BrokerEnum";
import { brokerIdToStr } from "../helpers";
import { TradeRoomInformation } from "../interfaces/TradeRoomInformation";
import { Account } from "../models/Account";
import allowedClientProvider from "../providers/allowedClientProvider";


export default class TradeRoom {
    private id: string;
    private owner: WebSocket;
    private clients: Array<WebSocket>;
    private isRoomPrivate: boolean;
    private brokerId: BrokerEnum;
    private isOnline: boolean;

    constructor(id: string, owner: WebSocket, isPrivate: boolean, brokerId: BrokerEnum) {
        this.id = id;
        this.owner = owner;
        this.clients = new Array<WebSocket>();
        this.setIsPrivate(isPrivate);
        this.setBroker(brokerId);
        this.setIsOnline(false);
    }

    public getId(): string {
        return this.id;
    }

    public async getOwnerAccount(): Promise<Account> {
        const ownerAccountId = allowedClientProvider.getClientId(this.getOwner());
        const accountRepository = getRepository(Account);
        return await accountRepository.findOne({id: ownerAccountId});
    }

    public async getClientsAccount(): Promise<Array<Account>> {
        const accountRepository = getRepository(Account);
        const accounts = new Array<Account>();
        for (let i = 0; i < this.clients.length; i++) {
            const client = this.clients[i];
            const clientAccountId = allowedClientProvider.getClientId(client);
            const account = await accountRepository.findOne({id: clientAccountId});
            accounts.push(account);
        }
        return accounts;
    }

    public getIsOnline(): boolean {
        return this.isOnline;
    }

    public setIsOnline(online: boolean): void {
        this.isOnline = online;
    }

    public async getRoomInfo(): Promise<TradeRoomInformation> {
        return {
            roomId: this.getId(),
            ownerUsername: (await this.getOwnerAccount()).username,
            ownerEmail: (await this.getOwnerAccount()).email,
            isRoomPrivate: this.isPrivate(),
            brokerName: await brokerIdToStr(this.getBroker()),
            users: await this.getClientsAccount(),
            isOnline: this.getIsOnline(),
        }
    }

    public isClientInRoom(ws: WebSocket): boolean {
        return this.clients.filter(client => client == ws) != null;
    }

    public getBroker(): BrokerEnum {
        return this.brokerId;
    }

    public setBroker(broker: BrokerEnum) {
        this.brokerId = broker;
    }

    public getOwner(): WebSocket {
        return this.owner;
    }

    public getClientsConnected(): number {
        return this.clients.length;
    }

    public isOwner(client: WebSocket): boolean {
        return this.owner == client;
    }

    public setIsPrivate(isPrivate: boolean) {
        this.isRoomPrivate = isPrivate;
    }

    public isPrivate(): boolean {
        return this.isRoomPrivate;
    }

    public addClient(client: WebSocket): void {
        const clientFound = this.clients.find(clientx => clientx == client);
        if (clientFound)
            return;

        this.clients.push(client);
    }

    public removeClient(client: WebSocket): void {
        const index = this.clients.findIndex(clientx => clientx == client);
        this.clients.splice(index, 1);
    }

    public sendMessage(message: object, excludeOwner = true) {
        const msg = JSON.stringify(message);
        if (excludeOwner) {
            this.clients.forEach(client => { 
                client.send(msg);
            });
        }
        else {
            this.clients.forEach(client => { 
                client.send(msg);
            });
            this.owner.send(msg);
        }
    }

    public sendToOwner(message: object) {
        const msg = JSON.stringify(message);
        this.owner.send(msg);
    }
}