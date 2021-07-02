using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightTrade.LightTradeAPI.Enums
{
    public enum NetworkMessageEnum
    {
        CONNECT = 1,
        CREATE_ROOM = 2,
        BINARY_OPERATION = 3,
        DIGITAL_OPERATION = 4,
        DISCONNECT_CLIENT = 5,
        JOIN_ROOM = 6,
        ROOM_INFORMATION = 7,
        MESSAGE = 8,
        ROOMS = 9,
        DISCONNECT = 10,
    }
}
