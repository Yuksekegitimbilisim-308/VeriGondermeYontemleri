using Microsoft.AspNetCore.Mvc;

namespace VeriGondermeYontemleri.Controllers
{
    public class SecondController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
