using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebPrimalNumbers.Models;

namespace WebPrimalNumbers.Controllers
{
    public class AddNumbersController : Controller
    {
        // GET: AddNumbers
        public ActionResult Index()
        {
            var addNumbers = new AddNumbers();
            return View(addNumbers);
        }

        //POST : AddNumbers
        [HttpPost]
        public ActionResult Index(AddNumbers addNumbers)
        {
            int wynik = addNumbers.GetSum();
            ViewBag.wynik = wynik;
            return View(addNumbers);
        }
    }
}