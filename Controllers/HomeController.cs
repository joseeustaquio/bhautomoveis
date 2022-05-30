using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BH_Automoveis.Models;
using System.Data;

namespace BH_Automoveis.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
      
          
        public IActionResult FaleConosco()
        {
            return View();
        }
         public IActionResult QuemSomos()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contato()
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
