using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace practice1.Local.Pages
{

    [PageAuthorize(typeof(OrdersRow))]
    public class OrdersController : Controller
    {
        [Route("Local/Orders")]
        public ActionResult Index()
        {
            return View("~/Modules/Local/Orders/OrdersIndex.cshtml");
        }
    }
}