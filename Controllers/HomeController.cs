using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using empresaapp.Models;

namespace empresaapp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.eunaoacredito = "walter";
            ViewData["nome"] = "coan";

            //return View();
            //return Content("Eu nao acredito"); 
            //return Redirect("http://www.univille.br");
            //return RedirectToAction("Privacy");

            /* var item = new {
                Nome = "Zezinho",
                Endereco = "rua lallal 100"
            };

            return Json(item);*/
            
            byte[] fileBytes = System.IO.File.ReadAllBytes(@"wwwroot\favicon.ico");
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Image.Jpeg); 

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
