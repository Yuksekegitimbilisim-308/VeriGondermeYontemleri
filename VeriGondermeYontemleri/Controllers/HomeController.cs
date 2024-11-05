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
            //ViewData["adSoyad"] = "Melih Ömer KAMAR";
            //ViewBag.Meslek = "Yazýlým Uzmaný";
            //Personel personel = new Personel() { Id=1,Fullname="Abdullah ÇAVUÞ"};
            ViewBag.cardtitle = "Personel Bilgisi";
            Personel personel2 = new Personel()
            {
                   Id = 2,
                   Fullname="Batuhan GÖKKAYA",
                   ImagePath= "defaultPersonel.png"
            };
            List<Personel> personels = new()
            {
                new Personel() {Id = 1,Fullname = "Melih Ömer KAMAR",ImagePath = "melih.png" },
                new Personel() {Id = 2,Fullname = "Abdullah ÇAVUÞ",ImagePath = "abdullah.png" },
                new Personel() {Id = 3,Fullname = "Batuhan GÖKKAYA",ImagePath = "batuhan.png" },
                new Personel() {Id = 4,Fullname = "Ömer Faruk KARAYÝÐÝT",ImagePath = "omerfaruk.png" },
                new Personel() {Id = 5,Fullname = "Ömer Faruk KARAYÝÐÝT",ImagePath = "omerfaruk.png" },
            };
            Deparment department = new() { Id = 1,DepartmentName="Yazýlým Geliþtirme Birimi"};
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