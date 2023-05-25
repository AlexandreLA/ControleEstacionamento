using ControleEstacionamento.Models;
using Microsoft.AspNetCore.Mvc;

namespace ControleEstacionamento.Controllers
{
    public class CarroController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Registro()
        {
            return View();
        }
    }
}
