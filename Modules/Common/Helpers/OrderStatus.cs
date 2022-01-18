using Serenity.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace practice1.Common
{
    [EnumKey("Common.OrderStatus")]
    public enum OrderStatus
    {
        [Description("Sent")]
        Sent = 1,
        [Description("Received")]
        Received = 2
    }
}
