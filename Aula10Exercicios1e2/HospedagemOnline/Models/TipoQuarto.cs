using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HospedagemOnline.Models
{
    public partial class TipoQuarto
    {
        [Key]
        public int IdTipoQuarto { get; set; }
        public string Descricao { get; set; }
        public decimal ValorDiaria { get; set; }
        public bool CafeManha { get; set; }
    }
}