using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Kurs.Primary;
using WebPrimalNumbers.Models;

namespace WebPrimalNumbers.Controllers
{
    public class PrimalController : Controller
    {
        // GET: Primal
        public ActionResult Index()
        {
            Primal primal = new Primal();
            return View();
        }

        // POST: Primal
        [HttpPost]
        public ActionResult Index(Primal primal)
        {
            if (ModelState.IsValid)
            {
                int liczba = primal.Liczba;
                PrimaryNumbers pn = new PrimaryNumbers(liczba);
                StringBuilder sb = new StringBuilder();
                foreach (var item in pn.GetNumbers())
                {
                    sb.Append(item + " ");
                }
                ViewBag.liczby = sb.ToString();
                return View();
            }
            else
            {
                return View(primal);
            }
           
        }
    }
}