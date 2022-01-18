using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<practice1.Local.ProductsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = practice1.Local.ProductsRow;

namespace practice1.Local
{
    public interface IProductsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class ProductsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IProductsSaveHandler
    {
        public ProductsSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}