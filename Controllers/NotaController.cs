using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCadastro.Controllers
{
    public class NotaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
