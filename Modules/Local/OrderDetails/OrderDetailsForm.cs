using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace practice1.Local.Forms
{
    [FormScript("Local.OrderDetails")]
    [BasedOnRow(typeof(OrderDetailsRow), CheckNames = true)]
    public class OrderDetailsForm
    {
        public Int32 ProductId { get; set; }
        public Int32 Quantity { get; set; }
        [ReadOnly(true)]
        public Int32 ProductPrice { get; set; }
        [ReadOnly(true)]
        public Int32 ItemTax { get; set; }
        [ReadOnly(true)]
        public Int32 Total { get; set; }
    }
}