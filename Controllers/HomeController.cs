using System.Web.Mvc;

namespace MvcDeserializationTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetOrder(Order o)
        {
            return Json(o.OrderId);
        }
    }

    public class Order
    {
        public string OrderId { get; set; }
    }
}