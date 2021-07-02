import { Account } from "../models/Account";



export interface TradeRoomInformation {
    roomId: string;
    ownerUsername: string;
    ownerEmail: string;
    isRoomPrivate: boolean;
    brokerName: string;
    users: Array<Account>;
    isOnline: boolean;
}