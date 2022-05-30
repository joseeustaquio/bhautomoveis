using BH_Automoveis.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carrosnovos.Controllers
{
    public class CarrosnovosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Novos()
        {
            return View();
        }

          public IActionResult Usados()
        {
            return View();
        }

        public IActionResult CadastrarCarros()
        {
            return View();
        }

        
        public IActionResult PecasAcessorios()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastrarCarros(Carronovos novoCarro)
        {
            CarronovoService service = new CarronovoService();
            int Id = service.CreateCarronovo(novoCarro);
            if (Id != 0)
            {
                ViewData["Mensagem"] = "Cadastro realizado com sucesso";
            }
            else
            {
                ViewData["Mensagem"] = "Falha de cadastro";
            }
            return View();
        }

        public IActionResult EditarCarros()
        {
            return View();
        }

        public IActionResult ApagarCarroConfirmacao()
        {
            return View();
        }
    }
}