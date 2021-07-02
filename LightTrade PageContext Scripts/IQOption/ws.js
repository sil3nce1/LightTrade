const lightTradeApi = {
    ws: new WebSocket(`ws://${BACKEND_WS_URL}/${BACKEND_WS_PORT}`),
    roomId: null,
    clientId: null,
    brokerId: BrokerEnum.IQOPTION,

    setRoomId: function(roomId) {
        this.roomId = roomId;
    },
    setClientId: function(clientId) {
        this.clientId = clientId;
    },

    sendDigitalOperation: function(packet) {
        this.sendMessage({id: LightTradeNetworkMessageEnum.DIGITAL_OPERATION, packet});
    },

    sendBinaryOperation: function(packet) {
        this.sendMessage({id: LightTradeNetworkMessageEnum.BINARY_OPERATION, packet});
    },

    sendMessage: function(message) {
        if (this.roomId == null)
            return;

        message = {...message, roomId: this.roomId, clientId: this.clientId, brokerId: this.brokerId};
        this.ws.send(JSON.stringify(message));
    }
}


const tradeRoomApi = {
    ws: new WebSocket("ws://localhost:4842/tradeRoomWs"),


}

tradeRoomApi.ws.onopen = function(e) {
    tradeRoomApi.ws.send(JSON.stringify({id: TradeRoomNetworkMessageEnum.CONNECT}));
}

tradeRoomApi.ws.onmessage = function(e) {
    onTradeRoomMessageReceived(e.data);
}

tradeRoomApi.ws.onerror = function(e) {

}

tradeRoomApi.ws.onclose = function(e) {

}