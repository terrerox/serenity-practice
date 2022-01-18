using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<practice1.Local.OrderDetailsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = practice1.Local.OrderDetailsRow;

namespace practice1.Local
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