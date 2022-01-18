using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace practice1.Local.Columns
{
    [ColumnsScript("Local.Products")]
    [BasedOnRow(typeof(ProductsRow), CheckNames = true)]
    public class ProductsColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 Id { get; set; }
        [EditLink]
        public String Title { get; set; }
        public Int32 Category { get; set; }
        public Int32 Price { get; set; }
    }
}