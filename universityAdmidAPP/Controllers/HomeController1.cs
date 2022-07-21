using Microsoft.AspNetCore.Mvc;

namespace universityAdmidAPP.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
