using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using viewBagData.Models;

namespace viewBagData.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.var1 = "im from Controller with using viewBag";
            ViewBag.var2 = DateTime.Now.ToLongDateString();
            string[] str = { "saif", "ali", "mahar" };
            ViewBag.var3 = str;

            ViewBag.var4 = new List<string>()
            {
                "cricket",
                "Football",
                "hockey",
            };

            Employee emp = new Employee();
            emp.name = "saifullah";
            emp.designation = "lectural";
            emp.city = "hyderabad";

            ViewBag.var5 = emp;
            return View();
        }
    }
}
