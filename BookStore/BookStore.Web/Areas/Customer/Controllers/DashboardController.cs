using Microsoft.AspNetCore.Mvc;

namespace BookStore.Web.Areas.Customer.Controllers
{
    public class DashboardController : Controller
    {
        [Area("Customer")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
