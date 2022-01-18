using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace practice1.Customer.Columns
{
    [ColumnsScript("Customer.OrderDetails")]
    [BasedOnRow(typeof(OrderDetailsRow), CheckNames = true)]
    public class OrderDetailsColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 Id { get; set; }
        public String OrderAddress { get; set; }
        public String ProductTitle { get; set; }
        public Int32 Total { get; set; }
        public Int32 Quantity { get; set; }
        public Int32 ItemAmount { get; set; }
        public Int32 ItemTax { get; set; }
    }
}