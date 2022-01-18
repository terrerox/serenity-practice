using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<practice1.Local.OrdersRow>;
using MyRow = practice1.Local.OrdersRow;

namespace practice1.Local
{
    public interface IOrdersListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class OrdersListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IOrdersListHandler
    {
        public OrdersListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}