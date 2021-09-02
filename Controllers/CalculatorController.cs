using AspNetApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetApp.Controllers
{
    [Route("/")]
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult Index()
        {
            return View(new Calculator());
        }

        [HttpPost]

        public ActionResult Index(Calculator c, string calculate)
        {
            if (calculate == "Addition")
            {
                c.Result = c.Num1 + c.Num2;
            }
            else if (calculate == "Subtraction")
            {
                c.Result = c.Num1 - c.Num2;
            }
            else if (calculate == "Multiplication")
            {
                c.Result = c.Num1 * c.Num2;
            }
            else if (calculate == "Division")
            {
                if (c.Num2 != 0)
                    c.Result = c.Num1 / c.Num2;
                else
                    ViewBag.Error = "You can`t divide by zero";
            }
            else if (calculate == "Clear")
            {
                c.Num1 = 0;
                c.Num2 = 0;
                c.Result = 0;
            }

            return View(c);
        }
    }
}
