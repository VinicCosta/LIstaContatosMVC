using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LIstaContatosMVC.Controllers
{
    public class ContatoController : Controller 
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}