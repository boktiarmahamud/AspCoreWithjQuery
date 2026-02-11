using System.Diagnostics;
using AspCoreWithjQuery.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspCoreWithjQuery.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
		public int Add(int num1, int num2)
		{
            return num1 + num2;// This method will be called via AJAX to perform addition and return the result as JSON.
		}

		[HttpPost]
		public int Sub(int num1, int num2) { return num1 - num2; }
        [HttpPost]
        public int Mul(int num1, int num2) { return num1 * num2; }
        [HttpPost]
        public int Div(int num1, int num2) { return num1 / num2; }

		[HttpPost]
		public Calculation Calculate(int num1, int num2) 
        { 
            Calculation calc = new Calculation();
            calc.Add = num1 + num2;
            calc.Subtract = num1 - num2;
            calc.Multiply = num1 * num2;
            calc.Division = (decimal)num1 / num2;
            return calc;

		}


		public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
