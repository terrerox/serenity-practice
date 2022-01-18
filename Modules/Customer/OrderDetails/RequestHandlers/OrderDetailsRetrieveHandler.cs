using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<practice1.Customer.OrderDetailsRow>;
using MyRow = practice1.Customer.OrderDetailsRow;

namespace practice1.Customer
{
    public interface IOrderDetailsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class OrderDetailsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IOrderDetailsRetrieveHandler
    {
        public OrderDetailsRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}