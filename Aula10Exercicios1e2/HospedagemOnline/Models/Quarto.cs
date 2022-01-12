using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HospedagemOnline.Models
{
    public partial class Quarto
    {
        [Key]
        public int IdQuarto { get; set; }
        public int IdEstabelecimento { get; set; }
        public int NumeroQuarto { get; set; }
        public int IdTipoQuarto { get; set; }
        public bool Disponivel { get; set; }
    }
}