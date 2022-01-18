using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace practice1.Local.Pages
{

    [PageAuthorize(typeof(ProductsRow))]
    public class ProductsController : Controller
    {
        [Route("Local/Products")]
        public ActionResult Index()
        {
            return View("~/Modules/Local/Products/ProductsIndex.cshtml");
        }
    }
}