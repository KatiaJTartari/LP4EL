using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HospedagemOnline.Models
{
    [MetadataType(typeof(EstabelecimentoMetadado))]
    public partial class Estabelecimento { }

    public class EstabelecimentoMetadado
    {
        public int IdCidade { get; set; }
        public int IdCategoria { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório.", AllowEmptyStrings = false)]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "Este campo deve ter entre 4 e 50 caracteres.")]
        public string NomeComercial { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório.", AllowEmptyStrings = false)]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "Este campo deve ter entre 4 e 50 caracteres.")]
        public string RazaoSocial { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório.", AllowEmptyStrings = false)]
        [RegularExpression(@"^\d{2}.\d{3}.\d{3}/\d{4}-\d{2}$", 
        ErrorMessage = "Este CNPJ não é válido. Inclua todos os caracteres do CNPJ.")]
        public string CNPJ { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório.", AllowEmptyStrings = false)]
        [StringLength(80, MinimumLength = 5, ErrorMessage = "Este campo deve ter entre 5 e 80 caracteres.")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório.", AllowEmptyStrings = false)]
        [RegularExpression(@"^\d({2})\d{5}-\d{4}$", ErrorMessage = "Este telefone não é válido. Inclua todos os dígitos do telefone.")]
        [DataType(DataType.PhoneNumber)]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório.", AllowEmptyStrings = false)]
        [StringLength(60, MinimumLength = 6, ErrorMessage = "Este campo deve ter entre 6 e 60 caracteres.")]
        [Url(ErrorMessage = "O formato deste site é inválido.")]
        public string Site { get; set; }
    }
}