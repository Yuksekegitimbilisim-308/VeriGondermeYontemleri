using Microsoft.AspNetCore.Mvc;

namespace VeriGondermeYontemleri.Controllers
{
    public class FirstController : Controller 
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
