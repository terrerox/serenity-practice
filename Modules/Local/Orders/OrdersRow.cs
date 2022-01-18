using practice1.Administration.Entities;
using practice1.Common;
using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace practice1.Local
{
    [ConnectionKey("Default"), Module("Local"), TableName("[dbo].[Orders]")]
    [DisplayName("Orders"), InstanceName("Orders")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class OrdersRow : Row<OrdersRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public Int32? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("User"), NotNull, ForeignKey("[dbo].[Users]", "UserId"), LeftJoin("jUser"), TextualField("UserUsername")]
        [LookupEditor(typeof(UserRow))]
        public Int32? UserId
        {
            get => fields.UserId[this];
            set => fields.UserId[this] = value;
        }

        [DisplayName("Amount")]
        public Int32? Amount
        {
            get => fields.Amount[this];
            set => fields.Amount[this] = value;
        }

        [DisplayName("Tax")]
        public Int32? Tax
        {
            get => fields.Tax[this];
            set => fields.Tax[this] = value;
        }

        [DisplayName("Address"), Size(1000), QuickSearch, NameProperty]
        public String Address
        {
            get => fields.Address[this];
            set => fields.Address[this] = value;
        }

        [DisplayName("Status")]
        public OrderStatus? Status
        {
            get => (OrderStatus?)fields.Status[this];
            set => fields.Status[this] = (Int32?)value;
        }

        [MasterDetailRelation(foreignKey: "OrderId", IncludeColumns = "ProductPrice, ProductTitle")]
        [DisplayName("Item List"), NotMapped]
        public List<OrderDetailsRow> ItemList
        {
            get => fields.ItemList[this];
            set => fields.ItemList[this] = value;
        }
        [DisplayName("Customer"), Expression("jUser.[Username]")]
        public String UserUsername
        {
            get => fields.UserUsername[this];
            set => fields.UserUsername[this] = value;
        }

        [DisplayName("User Display Name"), Expression("jUser.[DisplayName]")]
        public String UserDisplayName
        {
            get => fields.UserDisplayName[this];
            set => fields.UserDisplayName[this] = value;
        }

        [DisplayName("User Email"), Expression("jUser.[Email]")]
        public String UserEmail
        {
            get => fields.UserEmail[this];
            set => fields.UserEmail[this] = value;
        }

        [DisplayName("User Source"), Expression("jUser.[Source]")]
        public String UserSource
        {
            get => fields.UserSource[this];
            set => fields.UserSource[this] = value;
        }

        [DisplayName("User Last Directory Update"), Expression("jUser.[LastDirectoryUpdate]")]
        public DateTime? UserLastDirectoryUpdate
        {
            get => fields.UserLastDirectoryUpdate[this];
            set => fields.UserLastDirectoryUpdate[this] = value;
        }

        [DisplayName("User User Image"), Expression("jUser.[UserImage]")]
        public String UserUserImage
        {
            get => fields.UserUserImage[this];
            set => fields.UserUserImage[this] = value;
        }

        [DisplayName("User Insert Date"), Expression("jUser.[InsertDate]")]
        public DateTime? UserInsertDate
        {
            get => fields.UserInsertDate[this];
            set => fields.UserInsertDate[this] = value;
        }

        [DisplayName("User Insert User Id"), Expression("jUser.[InsertUserId]")]
        public Int32? UserInsertUserId
        {
            get => fields.UserInsertUserId[this];
            set => fields.UserInsertUserId[this] = value;
        }

        [DisplayName("User Update Date"), Expression("jUser.[UpdateDate]")]
        public DateTime? UserUpdateDate
        {
            get => fields.UserUpdateDate[this];
            set => fields.UserUpdateDate[this] = value;
        }

        [DisplayName("User Update User Id"), Expression("jUser.[UpdateUserId]")]
        public Int32? UserUpdateUserId
        {
            get => fields.UserUpdateUserId[this];
            set => fields.UserUpdateUserId[this] = value;
        }

        [DisplayName("User Is Active"), Expression("jUser.[IsActive]")]
        public Int16? UserIsActive
        {
            get => fields.UserIsActive[this];
            set => fields.UserIsActive[this] = value;
        }

        public OrdersRow()
            : base()
        {
        }

        public OrdersRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public Int32Field UserId;
            public Int32Field Amount;
            public Int32Field Tax;
            public StringField Address;
            public Int32Field Status;
            public RowListField<OrderDetailsRow> ItemList;

            public StringField UserUsername;
            public StringField UserDisplayName;
            public StringField UserEmail;
            public StringField UserSource;
            public DateTimeField UserLastDirectoryUpdate;
            public StringField UserUserImage;
            public DateTimeField UserInsertDate;
            public Int32Field UserInsertUserId;
            public DateTimeField UserUpdateDate;
            public Int32Field UserUpdateUserId;
            public Int16Field UserIsActive;
        }
    }
}
