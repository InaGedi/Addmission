using Microsoft.AspNetCore.Mvc;

namespace universityAdmidAPP.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult register()
        {
            return View();
        }
    }
}
