import WebSocket from "ws";
import http from "http";
import { NetworkMessage, NetworkMessageConnect } from "./interfaces/NetworkMessage";
import { NetworkMessageEnum } from "./enums/NetworkMessageEnum";
import allowedClientProvider from "./providers/allowedClientProvider";
import tradeRoomProvider from "./providers/tradeRoomProvider";

class WebSocketServer {
    private wss: WebSocket.Server;
    private static instance: WebSocketServer;

    constructor() { 
        WebSocketServer.instance = this;
    }

    public listen(port: number): void {
        this.wss = new WebSocket.Server({ port });
        this.wss.on('connection', this.onConnectionReceived);
    }

    private onConnectionReceived(ws: WebSocket, req: http.IncomingMessage) {
        ws.on('message', function(data) {
            WebSocketServer.instance.onMessageReceived(ws, data.toString(), req);
        });
        ws.on('close', function(event) {

        })
    }

    private onMessageReceived(ws: WebSocket, data: string, req: http.IncomingMessage) {
        const jsonMsg: NetworkMessage = JSON.parse(data);
        console.log(data);
        let parsedMsg = null;
        switch (jsonMsg.id) {
            case NetworkMessageEnum.CONNECT:
                parsedMsg = JSON.parse(data) as NetworkMessageConnect;
                allowedClientProvider.addClient(ws, parsedMsg.authToken, req.connection.remoteAddress);
                break;
            case NetworkMessageEnum.CREATE_ROOM:
                tradeRoomProvider.createRoom(data, ws);
                break;
            case NetworkMessageEnum.BINARY_OPERATION:
                tradeRoomProvider.sendBinaryOperation(data, ws);
                break;
            case NetworkMessageEnum.DIGITAL_OPERATION:
                tradeRoomProvider.sendDigitalOperation(data, ws);
                break;
            case NetworkMessageEnum.JOIN_ROOM:
                tradeRoomProvider.addUserToRoom(data, ws);
                break;
            case NetworkMessageEnum.ROOMS:
                tradeRoomProvider.sendPublicRooms(data, ws);
                break;
        }
    }
}

export default new WebSocketServer();