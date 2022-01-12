using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospedagemOnline.Models
{
    public class ResultadoPesquisa
    {
        public string NomeComercial { get; set; }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Site { get; set; }
    }
}