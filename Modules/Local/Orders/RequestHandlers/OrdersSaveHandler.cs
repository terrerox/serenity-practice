using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<practice1.Local.OrdersRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = practice1.Local.OrdersRow;

namespace practice1.Local
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