using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<practice1.Customer.OrdersRow>;
using MyRow = practice1.Customer.OrdersRow;

namespace practice1.Customer
{
    public interface IOrdersRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class OrdersRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IOrdersRetrieveHandler
    {
        public OrdersRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}