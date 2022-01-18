using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<practice1.Customer.OrdersRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = practice1.Customer.OrdersRow;

namespace practice1.Customer
{
    public interface IOrdersSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class OrdersSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IOrdersSaveHandler
    {
        public OrdersSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}