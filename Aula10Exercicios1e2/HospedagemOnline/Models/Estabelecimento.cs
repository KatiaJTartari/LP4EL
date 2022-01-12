using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HospedagemOnline.Models
{
    public partial class Estabelecimento
    {
        [Key]
        public int IdEstabelecimento { get; set; }
        public int IdCidade { get; set; }
        public int IdCategoria { get; set; }
        public string NomeComercial { get; set; }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Site { get; set; }
    }
}