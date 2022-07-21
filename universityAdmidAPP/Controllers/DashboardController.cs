using Microsoft.AspNetCore.Mvc;

namespace universityAdmidAPP.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
