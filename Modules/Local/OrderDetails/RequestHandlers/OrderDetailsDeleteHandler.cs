using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = practice1.Local.OrderDetailsRow;

namespace practice1.Local
{
    public interface IOrderDetailsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class OrderDetailsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IOrderDetailsDeleteHandler
    {
        public OrderDetailsDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}