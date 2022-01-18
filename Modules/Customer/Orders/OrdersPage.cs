using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace practice1.Customer.Pages
{

    [PageAuthorize(typeof(OrdersRow))]
    public class OrdersController : Controller
    {
        [Route("Customer/Orders")]
        public ActionResult Index()
        {
            return View("~/Modules/Customer/Orders/OrdersIndex.cshtml");
        }
    }
}