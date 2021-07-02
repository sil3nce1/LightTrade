



export interface NetworkMessage {
    id: number;
    clientId?: string;
}

export interface NetworkMessageConnect extends NetworkMessage {
    id: number;
    authToken: string;
}

export interface NetworkMessageCreateRoom extends NetworkMessage {
    isPrivate: boolean;
    brokerId: number;
}

export interface NetworkMessageDigitalOperation extends NetworkMessage {
    brokerId: number;
    roomId: string;
    packet: string;
}

export interface NetworkMessageGetRooms extends NetworkMessage {
    brokerId: number;
}

export interface NetworkMessageBinaryOperation extends NetworkMessage {
    brokerId: number;
    packet: string;
    roomId: string;
}

export interface NetworkMessageJoinRoom extends NetworkMessage {
    roomId: string;
}

export interface NetworkMessageLeaveRoom extends NetworkMessage {
    roomId: string;
    
}

export interface NetworkMessageAuthRoom extends NetworkMessage {
    roomId: string;
}