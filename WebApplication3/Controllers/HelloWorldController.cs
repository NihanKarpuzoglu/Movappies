using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using System.Web;


namespace WebApplication3.Controllers
{
    public class HelloWorldController : Controller
    {
        //public string Index()
        //{
        //    return "This is my default action...";
        //}
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Welcome(string name, int numTimes=1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
            //return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
            //return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);
            //return "This is the Welcome action method...";
        }
       
    }
}
