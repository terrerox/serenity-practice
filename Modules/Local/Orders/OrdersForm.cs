using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace practice1.Local.Forms
{
    [FormScript("Local.Orders")]
    [BasedOnRow(typeof(OrdersRow), CheckNames = true)]
    public class OrdersForm
    {
        public Int32 UserId { get; set; }

        [TextAreaEditor(Rows = 5)]
        public String Address { get; set; }
        [OrderDetailsEditor, IgnoreName]
        public List<OrderDetailsRow>ItemList { get; set; }
        public Int32 Status { get; set; }
    }
}