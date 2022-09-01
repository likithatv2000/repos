using Microsoft.AspNetCore.Mvc;

namespace DAY1.Pages
{
    public class accountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
