using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OgrenciNotMvc.Controllers
{
    public class HesapTestController : Controller
    {
        // GET: HesapTest
        public ActionResult Index(double sayi1 = 0, double sayi2 = 0)
        {
            double ToplamaSonuc = sayi1 + sayi2;
            ViewBag.snc = ToplamaSonuc;

            return View();
        }
    }
}