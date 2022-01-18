using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace practice1.Customer.Forms
{
    [FormScript("Customer.Orders")]
    [BasedOnRow(typeof(OrdersRow), CheckNames = true)]
    public class OrdersForm
    {
        [ReadOnly(true)]
        public Int32 UserId { get; set; }

        [TextAreaEditor(Rows = 5), ReadOnly(true)]
        public String Address { get; set; }
        [OrderDetailsEditor, IgnoreName]
        public List<OrderDetailsRow> ItemList { get; set; }
        [ReadOnly(true)]
        public Int32 Status { get; set; }
    }
}