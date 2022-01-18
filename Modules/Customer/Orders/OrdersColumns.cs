using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace practice1.Customer.Columns
{
    [ColumnsScript("Customer.Orders")]
    [BasedOnRow(typeof(OrdersRow), CheckNames = true)]
    public class OrdersColumns
    {
        [EditLink]
        public String UserUsername { get; set; }
        public Int32 Amount { get; set; }
        public Int32 Tax { get; set; }
        public String Address { get; set; }
        public Int32 Status { get; set; }
    }
}