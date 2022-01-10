using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Universidade.Models
{
    public class Departamento
    {
        [Key]
        public int IdDepartamento { get; set; }
        public string Descricao { get; set; }
        public ICollection<Curso> Curso { get; set; }
    }
}