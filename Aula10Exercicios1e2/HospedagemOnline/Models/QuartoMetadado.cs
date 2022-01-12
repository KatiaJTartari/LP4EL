using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HospedagemOnline.Models
{
    [MetadataType(typeof(QuartoMetadado))]
    public partial class Quarto { }

    public class QuartoMetadado
    {
        public int IdEstabelecimento { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório.", AllowEmptyStrings = false)]
        [Range(1, 1000, ErrorMessage = "Este campo aceita somente valores entre 1 e 1000 caracteres.")]
        [System.Web.Mvc.Remote("VerificaSeNumeroQuartoNaoExiste", "Quarto", AdditionalFields = "IdEstabelecimento",
         ErrorMessage = "Este número de quarto já existe no banco de dados.")]
        public int NumeroQuarto { get; set; }

        public int IdTipoQuarto { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório.", AllowEmptyStrings = false)]
        [StringLength(3, MinimumLength = 5, ErrorMessage = "Este campo deve ser sim(true) ou não(false).")]
        public bool Disponivel { get; set; }
    }
}