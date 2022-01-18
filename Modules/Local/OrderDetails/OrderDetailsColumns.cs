using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace practice1.Local.Columns
{
    [ColumnsScript("Local.OrderDetails")]
    [BasedOnRow(typeof(OrderDetailsRow), CheckNames = true)]
    public class OrderDetailsColumns
    {
        [EditLink, AlignRight]
        public String ProductTitle { get; set; }
        public Int32 Quantity { get; set; }
        public Int32 ProductPrice { get; set; }
        public Int32 ItemTax { get; set; }
        public Int32 Total { get; set; }

    }
}