using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace practice1.Customer.Forms
{
    [FormScript("Customer.OrderDetails")]
    [BasedOnRow(typeof(OrderDetailsRow), CheckNames = true)]
    public class OrderDetailsForm
    {
        public Int32 OrderId { get; set; }
        public Int32 ProductId { get; set; }
        public Int32 Total { get; set; }
        public Int32 Quantity { get; set; }
        public Int32 ItemAmount { get; set; }
        public Int32 ItemTax { get; set; }
    }
}