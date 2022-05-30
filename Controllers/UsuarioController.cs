using BH_Automoveis.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace BH_Automoveis.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CadastrarUsuario()
        {
            return View();
        }

      /*  [HttpPost]
        public IActionResult CadastrarUsuario(Usuario novoUsuario)
        {
            try
            {
                 UsuarioService service = new UsuarioService();
                 service.CadastrarUsuario(novoUsuario);
            }

            catch(Exception e){
                    // _logger.LogError("Erro geral no cadastro de interesses" + e.Message);
                ViewBag.Mensagem = "Erro ao enviar os dados"+ e;
                return View("Index");
            }
            
          /*  int Id = service.CreateUsuario(novoUsuario);
            if (Id != 0)
            {
                ViewData["Mensagem"] = "Cadastro realizado com sucesso";
            }
            else
            {
                ViewData["Mensagem"] = "Falha de cadastro";
            }
             ViewBag.Mensagem = "Cadastro realizado com sucesso";
            return View("Index");
           // return View();
        }
        /*
          [HttpPost]
          public IActionResult CadastrarUsuario(Usuario novoUsuario)
        {
            try
            {
                 UsuarioService service = new UsuarioService();
                 service.CadastrarUsuario(novoUsuario);
            }

            catch(Exception e){
            
                ViewBag.Mensagem = "Erro ao enviar os dados"+ e;
                return View("Index");
            }
            
         
             ViewBag.Mensagem = "Cadastro realizado com sucesso";
            return View("Index");
        
        }
        ======================================================
         public IActionResult CadastrarUsuario()
          return View();
       }
       {
        */

        public IActionResult EditarUsuario()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EditarUsuario(Usuario novoUsuario)
        {
            return View();
        }

        public IActionResult ApagarConfirmacao()
        {
            return View();
        }
    }
}