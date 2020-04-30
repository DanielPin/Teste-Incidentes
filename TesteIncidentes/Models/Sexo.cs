using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TesteIncidentes.Models
{
    public class Sexo
    {
        public Sexo()
        {

        }
        [Key]
        public int SexoId { get; set; }

        public string Descricao { get; set; }

       


    }
}
