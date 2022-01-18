using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<practice1.Local.ProductsRow>;
using MyRow = practice1.Local.ProductsRow;

namespace practice1.Local
{
    public interface IProductsListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class ProductsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IProductsListHandler
    {
        public ProductsListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}