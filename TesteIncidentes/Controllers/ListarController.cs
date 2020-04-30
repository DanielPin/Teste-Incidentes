using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace TesteIncidentes.Controllers
{
    public class ListarController : Controller
    {
        private ApplicationContext context;

        public ListarController(ApplicationContext context)
        {
            this.context = context;
        }

        public IActionResult Listar(string nome, bool ativo,int pagina = 1)
        {           

            ViewBag.pagina = pagina;
            ViewBag.ativo = ativo;
            ViewBag.nome = nome;

            if (nome != null )
            {
                var list = context.Usuario.Include(p => p.Sexo).Where(m => m.Nome.Contains(nome) && m.Ativo == ativo).ToPagedList(pagina, 5);                
                return View(list);
            }
            else
            {               

                var list = context.Usuario.Include(p => p.Sexo).ToPagedList(pagina, 5);
                return View(list);
            }





           
        }








    }
}
