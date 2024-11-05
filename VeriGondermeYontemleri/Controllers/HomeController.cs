using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Xml.Linq;
using VeriGondermeYontemleri.Entities;
using VeriGondermeYontemleri.Models;

namespace VeriGondermeYontemleri.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            //ViewData["adSoyad"] = "Melih �mer KAMAR";
            //ViewBag.Meslek = "Yaz�l�m Uzman�";
            //Personel personel = new Personel() { Id=1,Fullname="Abdullah �AVU�"};
            ViewBag.cardtitle = "Personel Bilgisi";
            Personel personel2 = new Personel()
            {
                   Id = 2,
                   Fullname="Batuhan G�KKAYA",
                   ImagePath= "defaultPersonel.png"
            };
            List<Personel> personels = new()
            {
                new Personel() {Id = 1,Fullname = "Melih �mer KAMAR",ImagePath = "melih.png" },
                new Personel() {Id = 2,Fullname = "Abdullah �AVU�",ImagePath = "abdullah.png" },
                new Personel() {Id = 3,Fullname = "Batuhan G�KKAYA",ImagePath = "batuhan.png" },
                new Personel() {Id = 4,Fullname = "�mer Faruk KARAY���T",ImagePath = "omerfaruk.png" },
                new Personel() {Id = 5,Fullname = "�mer Faruk KARAY���T",ImagePath = "omerfaruk.png" },
            };
            Deparment department = new() { Id = 1,DepartmentName="Yaz�l�m Geli�tirme Birimi"};
            HomeIndexVM vm = new HomeIndexVM()
            {
                Personel = personel2,
                Department = department,
                Personels = personels
            };

            return View(vm);
        }
        [HttpGet]
        public IActionResult GetData(string name,string job)
        {
            ViewBag.name = name;
            ViewBag.job = job;
            return View();
        }
        [HttpPost]
        public IActionResult PostData(insan insan)
        {
            insan.Name += " post";
            insan.Job = insan.Job + " post";
            return View(insan);
        }
        [HttpGet]
        public IActionResult PostData()
        {
            insan ins = new();

            return View(ins);
        }
    }
}
//Viewbag
//Viewdata
//Model--