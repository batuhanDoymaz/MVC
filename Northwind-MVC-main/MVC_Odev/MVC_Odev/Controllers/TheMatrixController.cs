using Microsoft.AspNetCore.Mvc;

namespace MVC_Odev.Controllers
{
    public class TheMatrixController : Controller
    {
        public IActionResult RedPill()
        {
            return View();
        }
        public IActionResult BluePill() 
        {
            return View();
        }
    }
}
