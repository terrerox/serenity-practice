using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<practice1.Local.ProductsRow>;
using MyRow = practice1.Local.ProductsRow;

namespace practice1.Local
{
    public interface IProductsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class ProductsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IProductsRetrieveHandler
    {
        public ProductsRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}