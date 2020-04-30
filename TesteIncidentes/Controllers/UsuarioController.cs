using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteIncidentes.Models;

namespace TesteIncidentes.Controllers
{
    public class UsuarioController : Controller
    {
        private ApplicationContext context;

        public UsuarioController(ApplicationContext context)
        {
            this.context = context;
        }

       

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Usuario usuario)
        {

            usuario.Ativo = true;
            context.Add(usuario);
            context.SaveChanges();
            TempData["mensagem"] = "Mensagem de sucesso";
            return RedirectToAction("Cadastrar", "Usuario");
        }


    }
}
