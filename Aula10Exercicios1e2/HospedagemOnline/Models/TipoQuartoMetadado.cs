using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HospedagemOnline.Models
{
    [MetadataType(typeof(TipoQuartoMetadado))]
    public partial class TipoQuarto { }

    public class TipoQuartoMetadado
    {
        [Required(ErrorMessage = "Este campo é obrigatório.", AllowEmptyStrings = false)]
        [StringLength(80, MinimumLength = 5, ErrorMessage = "Este campo deve ter entre 5 e 80 caracteres.")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório.", AllowEmptyStrings = false)]
        [Range(80 , 1000, ErrorMessage = "Este campo aceita somente valores entre 80,00 e 1.000,00.")]
        public decimal ValorDiaria { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório.", AllowEmptyStrings = false)]
        [StringLength(3, MinimumLength = 5, ErrorMessage = "Este campo deve ser sim(true) ou não(false).")]
        public bool CafeManha { get; set; }
    }
}