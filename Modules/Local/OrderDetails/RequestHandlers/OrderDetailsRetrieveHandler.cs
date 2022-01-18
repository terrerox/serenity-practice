using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<practice1.Local.OrderDetailsRow>;
using MyRow = practice1.Local.OrderDetailsRow;

namespace practice1.Local
{
    public interface IOrderDetailsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class OrderDetailsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IOrderDetailsRetrieveHandler
    {
        public OrderDetailsRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }

        protected override void OnReturn()
        {
            base.OnReturn();

            //var mc = OrderDetailsRow.Fields;
            //Row.CastList = Connection.List<MovieCastRow>(q => q
            //    .SelectTableFields()
            //    .Select(mc.PersonFullname)
            //    .Where(mc.MovieId == Row.MovieId.Value));
        }
    }
}