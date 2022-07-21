using Microsoft.AspNetCore.Mvc;

namespace universityAdmidAPP.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Signin()
        {
            return View();
        }
        public IActionResult forgetpwd()
        {
            return View();
        }
       


    }
}
