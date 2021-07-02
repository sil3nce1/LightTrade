import WebSocket from "ws";
import TradeRoom from "../classes/TradeRoom";
import { NetworkMessage, 
    NetworkMessageAuthRoom, 
    NetworkMessageBinaryOperation, 
    NetworkMessageCreateRoom, 
    NetworkMessageDigitalOperation, 
    NetworkMessageGetRooms, 
    NetworkMessageJoinRoom, 
    NetworkMessageLeaveRoom} from "../interfaces/NetworkMessage";
import { v4 as uuid } from "uuid";
import allowedClientProvider from "./allowedClientProvider";
import { Account } from "../models/Account";
import { getRepository } from "typeorm";
import { NetworkMessageEnum } from "../enums/NetworkMessageEnum";
import { TradeRoomInformation } from "../interfaces/TradeRoomInformation";


class TradeRoomProvider {
    private tradeRooms: Map<string, TradeRoom>;

    constructor() {
        this.tradeRooms = new Map<string, TradeRoom>();
        setInterval(() => this.loopSessions(), 900000);
    }

    private loopSessions(): void {
        for (const [key, value] of this.tradeRooms.entries()) {
            if ((value.getOwner().readyState != 0) && (value.getOwner().readyState != 1)) {
                this.tradeRooms.delete(key);
            }
        }
    }

    public async createRoom(data: string, ws: WebSocket): Promise<void> {
        const parsedMsg = JSON.parse(data) as NetworkMessageCreateRoom;
        const tradeRoomId = this.generateTradeRoomId();
        const clientSocket = allowedClientProvider.getClientById(parsedMsg.clientId);
        const accountRepository = getRepository(Account);
        const account = await accountRepository.findOne({id: parsedMsg.clientId});
        if (!account.isTrader) {
            this.sendMessage({ id: NetworkMessageEnum.MESSAGE, success: false, message: "You're not a trader" }, clientSocket);
            return;
        }

        this.tradeRooms.set(tradeRoomId, new TradeRoom(tradeRoomId, clientSocket, parsedMsg.isPrivate, parsedMsg.brokerId));
        this.sendMessage({ id: NetworkMessageEnum.CREATE_ROOM, success: true, roomId: tradeRoomId }, clientSocket);
    }

    public async addUserToRoom(data: string, ws: WebSocket): Promise<void> {
        const parsedMsg = JSON.parse(data) as NetworkMessageJoinRoom;
        const clientSocket = allowedClientProvider.getClientById(parsedMsg.clientId);

        if (!this.isValidRoom(parsedMsg.roomId)) {
            this.sendMessage({ id: NetworkMessageEnum.MESSAGE, success: false, message: "Invalid room" }, clientSocket);
            return;
        }
        const tradeRoom = this.tradeRooms.get(parsedMsg.roomId);
        if (tradeRoom.isClientInRoom(clientSocket)) {
            this.sendMessage({ id: NetworkMessageEnum.MESSAGE, success: false, message: "You're already in this room" }, clientSocket);
            return;
        }
        tradeRoom.addClient(clientSocket);
        const tradeRoomInfo = await tradeRoom.getRoomInfo();
        delete tradeRoomInfo.users;
        this.sendMessage({ id: NetworkMessageEnum.JOIN_ROOM, success: true, tradeRoom: tradeRoomInfo }, clientSocket);
        this.sendMessage({ id: NetworkMessageEnum.ROOM_INFORMATION, roomInfo: await tradeRoom.getRoomInfo() }, tradeRoom.getOwner());
    }

    public authRoom(data: string, ws: WebSocket): void {
        const parsedMsg = JSON.parse(data) as NetworkMessageAuthRoom;
        const clientSocket = allowedClientProvider.getClientById(parsedMsg.clientId);

        if (!this.isValidRoom(parsedMsg.roomId)) {
            this.sendMessage({ id: NetworkMessageEnum.MESSAGE, success: false, message: "Invalid room" }, clientSocket);
            return;
        }
        const tradeRoom = this.tradeRooms.get(parsedMsg.roomId);

        if (!tradeRoom.isOwner(clientSocket)) {
            this.sendMessage({ id: NetworkMessageEnum.AUTH_ROOM, success: false, message: "You're not the trader of this room" }, clientSocket);
            return;
        }
        tradeRoom.setIsOnline(true);
        this.sendMessage({id: NetworkMessageEnum.AUTH_ROOM, success: true, roomId: parsedMsg.roomId}, clientSocket);
    }

    public sendPublicRooms(data: string, ws: WebSocket): void {
        const parsedMsg = JSON.parse(data) as NetworkMessageGetRooms;
        const clientSocket = allowedClientProvider.getClientById(parsedMsg.clientId);
        const rooms = this.getPublicRooms();
        const roomInfoArr = new Array<TradeRoomInformation>();
        rooms.forEach(async room => {
            if (room.getBroker() == parsedMsg.brokerId)
                roomInfoArr.push(await room.getRoomInfo());
        });
        this.sendMessage({ id: NetworkMessageEnum.ROOMS, rooms: roomInfoArr }, clientSocket);
    }

    public getPublicRooms(): Array<TradeRoom> {
        const buffer = [];
        for (const [key, value] of this.tradeRooms.entries()) {
            if ((!this.tradeRooms.get(key).isPrivate()) && (this.tradeRooms.get(key).getIsOnline())) {
                buffer.push(this.tradeRooms.get(key));
            }
        }
        return buffer;
    }

    private isValidRoom(roomId: string): boolean {
        return this.tradeRooms.get(roomId) != null;
    }

    public leaveRoom(data: string, ws: WebSocket): void {
        const parsedMsg = JSON.parse(data) as NetworkMessageLeaveRoom;
        const clientSocket = allowedClientProvider.getClientById(parsedMsg.clientId);

        if (!this.isValidRoom(parsedMsg.roomId)) {
            this.sendMessage({ id: NetworkMessageEnum.MESSAGE, success: false, message: "Invalid room" }, clientSocket);
            return;
        }
        const tradeRoom = this.tradeRooms.get(parsedMsg.roomId);
        if (tradeRoom.isOwner(clientSocket)) {
            tradeRoom.sendMessage({id: NetworkMessageEnum.DISCONNECT}, false);
            this.tradeRooms.delete(parsedMsg.roomId);
        } else {
            this.sendMessage({id: NetworkMessageEnum.DISCONNECT}, clientSocket);
            tradeRoom.removeClient(clientSocket);
        }
    }

    public sendBinaryOperation(data: string, ws: WebSocket): void {
        const parsedMsg = JSON.parse(data) as NetworkMessageBinaryOperation;
        const clientSocket = allowedClientProvider.getClientById(parsedMsg.clientId);

        if (!this.isValidRoom(parsedMsg.roomId)) {
            this.sendMessage({ id: NetworkMessageEnum.MESSAGE, success: false, message: "Invalid room" }, clientSocket);
            return;
        }
        const tradeRoom = this.tradeRooms.get(parsedMsg.roomId);

        if (!tradeRoom.isOwner(clientSocket)) {
            this.sendMessage({ id: NetworkMessageEnum.MESSAGE, success: false, message: "You're not the owner of this session" }, clientSocket);
            return;
        }
    
        tradeRoom.sendMessage({ id: NetworkMessageEnum.BINARY_OPERATION, packet: parsedMsg.packet, brokerId: parsedMsg.brokerId });
    }

    public sendDigitalOperation(data: string, ws: WebSocket): void {
        const parsedMsg = JSON.parse(data) as NetworkMessageDigitalOperation;
        const clientSocket = allowedClientProvider.getClientById(parsedMsg.clientId);

        if (!this.isValidRoom(parsedMsg.roomId)) {
            this.sendMessage({ id: NetworkMessageEnum.MESSAGE, success: false, message: "Invalid room" }, clientSocket);
            return;
        }
        const tradeRoom = this.tradeRooms.get(parsedMsg.roomId);

        if (!tradeRoom.isOwner(clientSocket)) {
            this.sendMessage({ id: NetworkMessageEnum.MESSAGE, success: false, message: "You're not the owner of this session" }, clientSocket);
            return;
        }

        tradeRoom.sendMessage({ id: NetworkMessageEnum.DIGITAL_OPERATION, packet: parsedMsg.packet, brokerId: parsedMsg.brokerId });
    }

    private sendMessage(data: object, ws: WebSocket) {
        ws.send(JSON.stringify(data));
    }

    private generateTradeRoomId(): string {
        let id = uuid();
        while (this.tradeRooms.get(id)) {
            id = uuid();
        }
        return id;
    }

}

export default new TradeRoomProvider();