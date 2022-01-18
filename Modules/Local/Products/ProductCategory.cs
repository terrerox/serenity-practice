using Serenity.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace practice1.Local
{
    [EnumKey("Local.ProductCategory")]
    public enum ProductCategory
    {
        [Description("Seafood")]
        Seafood = 1,
        [Description("Bakery")]
        Bakery = 2,
        [Description("Meat")]
        Meat = 3
    }
}
