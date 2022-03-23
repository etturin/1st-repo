using Microsoft.AspNetCore.Mvc;

namespace SimchaFund.Web.Controllers
{
    public class SimchasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
