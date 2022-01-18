using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = practice1.Local.OrdersRow;

namespace practice1.Local
{
    public interface IOrdersDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class OrdersDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IOrdersDeleteHandler
    {
        public OrdersDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}