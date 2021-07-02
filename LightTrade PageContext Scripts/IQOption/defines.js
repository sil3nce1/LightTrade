const BACKEND_WS_URL = "localhost";
const BACKEND_WS_PORT = 3000;

const TradeRoomNetworkMessageEnum = {
    CONNECT: 0,
    AUTH_ROOM: 1,
}

const LightTradeNetworkMessageEnum = {
        CONNECT: 1,
        CREATE_ROOM: 2,
        BINARY_OPERATION: 3,
        DIGITAL_OPERATION: 4,
        DISCONNECT_CLIENT: 5,
        JOIN_ROOM: 6,
        ROOM_INFORMATION: 7,
        MESSAGE: 8,
        ROOMS: 9,
        DISCONNECT: 10,
}

const BrokerEnum = {
    IQOPTION: 0,
    EBINEX: 1,
    XTB: 2,
}