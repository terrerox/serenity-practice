using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<practice1.Customer.OrderDetailsRow>;
using MyRow = practice1.Customer.OrderDetailsRow;

namespace practice1.Customer
{
    public interface IOrderDetailsListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class OrderDetailsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IOrderDetailsListHandler
    {
        public OrderDetailsListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}