using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HospedagemOnline.Models
{
        public partial class Categoria
    {
        [Key]
        public int IdCategoria { get; set; }
        public string Descricao { get; set; }
    }
}