


function onTradeRoomMessageReceived(message) {
    const jsonMsg = JSON.parse(message);

    switch (jsonMsg.id) {
        case TradeRoomNetworkMessageEnum.AUTH_ROOM:
            lightTradeApi.setRoomId(jsonMsg.roomId);
            lightTradeApi.setClientId(jsonMsg.clientId);
            break;
    }
}

function onIqMessageSent(message) {
    const jsonMsg = JSON.parse(msg);

    if (jsonMsg.msg.name == "digital-options.place-digital-option") {
        lightTradeApi.sendDigitalOperation(message);
    }

    if (jsonMsg.msg.name == "binary-options.open-option") {
        lightTradeApi.sendBinaryOperation(message);
    }
}

function onIqMessageReceived(message) {

}
