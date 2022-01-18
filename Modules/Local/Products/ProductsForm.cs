using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace practice1.Local.Forms
{
    [FormScript("Local.Products")]
    [BasedOnRow(typeof(ProductsRow), CheckNames = true)]
    public class ProductsForm
    {
        public String Title { get; set; }
        public ProductCategory Category { get; set; }
        public Int32 Price { get; set; }
        public String PrimaryImage { get; set; }
    }
}