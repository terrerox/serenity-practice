using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<practice1.Customer.OrderDetailsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = practice1.Customer.OrderDetailsRow;

namespace practice1.Customer
{
    public interface IOrderDetailsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class OrderDetailsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IOrderDetailsSaveHandler
    {
        public OrderDetailsSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}