using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TesteIncidentes.Models
{
    public class Usuario
    {
        public Usuario()
        {

        }
        [Key]
        public int UsuarioId { get; set; }

        public string Nome { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataNascimento { get; set; }
        public string EMail { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }
        [ForeignKey("Sexo")]
        public int? SexoId { get; set; }
        public Sexo Sexo { get; set; }
       




    }
}
