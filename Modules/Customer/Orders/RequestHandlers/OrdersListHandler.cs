using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<practice1.Customer.OrdersRow>;
using MyRow = practice1.Customer.OrdersRow;

namespace practice1.Customer
{
    public interface IOrdersListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class OrdersListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IOrdersListHandler
    {
        public OrdersListHandler(IRequestContext context)
             : base(context)
        {
        }

        protected override void ApplyFilters(SqlQuery query)
        {
            base.ApplyFilters(query);
            // Ignore inactive records
            query.Where(new Criteria(OrdersRow.Fields.UserId) == Context.User.GetIdentifier());
        }
    }
}