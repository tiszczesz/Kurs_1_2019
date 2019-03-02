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
                int ilwierszy = (liczba / 20) +1;

                PrimaryNumbers pn = new PrimaryNumbers(liczba);
                StringBuilder sb = new StringBuilder();
                foreach (var item in pn.GetNumbers())
                {
                    sb.Append(item + " ");
                }

                ViewBag.primary = pn.GetNumbers();
                ViewBag.liczby = sb.ToString();
                ViewBag.rows = ilwierszy;
                return View();
            }
            else
            {
                return View(primal);
            }
           
        }
    }
}