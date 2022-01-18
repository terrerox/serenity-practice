using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace practice1.Local
{
    [ConnectionKey("Default"), Module("Local"), TableName("[dbo].[Products]")]
    [DisplayName("Products"), InstanceName("Products")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript("practice1.Products")]
    public sealed class ProductsRow : Row<ProductsRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public Int32? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Title"), Size(50), NotNull, QuickSearch, NameProperty]
        public String Title
        {
            get => fields.Title[this];
            set => fields.Title[this] = value;
        }

        [DisplayName("Category")]
        public ProductCategory? Category
        {
            get => (ProductCategory?)fields.Category[this];
            set => fields.Category[this] = (Int32?)value;
        }

        [DisplayName("Price")]
        public Int32? Price
        {
            get => fields.Price[this];
            set => fields.Price[this] = value;
        }

        [DisplayName("Primary Image"), Size(100),
         ImageUploadEditor(FilenameFormat = "Product/PrimaryImage/~")]
        public String PrimaryImage
        {
            get => fields.PrimaryImage[this];
            set => fields.PrimaryImage[this] = value;
        }

        public ProductsRow()
            : base()
        {
        }

        public ProductsRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField Title;
            public Int32Field Category;
            public Int32Field Price;
            public StringField PrimaryImage;
        }
    }
}
