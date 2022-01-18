using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace practice1.Customer
{
    [ConnectionKey("Default"), Module("Customer"), TableName("[dbo].[OrderDetails]")]
    [DisplayName("Order Details"), InstanceName("Order Details")]
    [ReadPermission("Customer")]
    [ModifyPermission("Customer")]
    public sealed class OrderDetailsRow : Row<OrderDetailsRow.RowFields>, IIdRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public Int32? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Order"), NotNull, ForeignKey("[dbo].[Orders]", "Id"), LeftJoin("jOrder"), TextualField("OrderAddress")]
        public Int32? OrderId
        {
            get => fields.OrderId[this];
            set => fields.OrderId[this] = value;
        }

        [DisplayName("Product"), NotNull, ForeignKey("[dbo].[Products]", "Id"), LeftJoin("jProduct"), TextualField("ProductTitle"), NameProperty]
        public Int32? ProductId
        {
            get => fields.ProductId[this];
            set => fields.ProductId[this] = value;
        }

        [DisplayName("Total")]
        public Int32? Total
        {
            get => fields.Total[this];
            set => fields.Total[this] = value;
        }

        [DisplayName("Quantity")]
        public Int32? Quantity
        {
            get => fields.Quantity[this];
            set => fields.Quantity[this] = value;
        }

        [DisplayName("Item Amount")]
        public Int32? ItemAmount
        {
            get => fields.ItemAmount[this];
            set => fields.ItemAmount[this] = value;
        }

        [DisplayName("Item Tax")]
        public Int32? ItemTax
        {
            get => fields.ItemTax[this];
            set => fields.ItemTax[this] = value;
        }

        [DisplayName("Order User Id"), Expression("jOrder.[UserId]")]
        public Int32? OrderUserId
        {
            get => fields.OrderUserId[this];
            set => fields.OrderUserId[this] = value;
        }

        [DisplayName("Order Amount"), Expression("jOrder.[Amount]")]
        public Int32? OrderAmount
        {
            get => fields.OrderAmount[this];
            set => fields.OrderAmount[this] = value;
        }

        [DisplayName("Order Tax"), Expression("jOrder.[Tax]")]
        public Int32? OrderTax
        {
            get => fields.OrderTax[this];
            set => fields.OrderTax[this] = value;
        }

        [DisplayName("Order Address"), Expression("jOrder.[Address]")]
        public String OrderAddress
        {
            get => fields.OrderAddress[this];
            set => fields.OrderAddress[this] = value;
        }

        [DisplayName("Order Status"), Expression("jOrder.[Status]")]
        public Int32? OrderStatus
        {
            get => fields.OrderStatus[this];
            set => fields.OrderStatus[this] = value;
        }

        [DisplayName("Product Title"), Expression("jProduct.[Title]")]
        public String ProductTitle
        {
            get => fields.ProductTitle[this];
            set => fields.ProductTitle[this] = value;
        }

        [DisplayName("Product Category"), Expression("jProduct.[Category]")]
        public Int32? ProductCategory
        {
            get => fields.ProductCategory[this];
            set => fields.ProductCategory[this] = value;
        }

        [DisplayName("Product Price"), Expression("jProduct.[Price]")]
        public Int32? ProductPrice
        {
            get => fields.ProductPrice[this];
            set => fields.ProductPrice[this] = value;
        }

        [DisplayName("Product Primary Image"), Expression("jProduct.[PrimaryImage]")]
        public String ProductPrimaryImage
        {
            get => fields.ProductPrimaryImage[this];
            set => fields.ProductPrimaryImage[this] = value;
        }

        public OrderDetailsRow()
            : base()
        {
        }

        public OrderDetailsRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public Int32Field OrderId;
            public Int32Field ProductId;
            public Int32Field Total;
            public Int32Field Quantity;
            public Int32Field ItemAmount;
            public Int32Field ItemTax;

            public Int32Field OrderUserId;
            public Int32Field OrderAmount;
            public Int32Field OrderTax;
            public StringField OrderAddress;
            public Int32Field OrderStatus;

            public StringField ProductTitle;
            public Int32Field ProductCategory;
            public Int32Field ProductPrice;
            public StringField ProductPrimaryImage;
        }
    }
}
