using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HospedagemOnline.Models
{
    [MetadataType(typeof(CidadeMetadado))]
    public partial class Cidade { }

    public class CidadeMetadado
    {
        [Required(ErrorMessage = "Este campo é obrigatório.", AllowEmptyStrings = false)]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Este campo deve ter entre 3 e 30 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório.", AllowEmptyStrings = false)]
        [StringLength(2, MinimumLength = 2, ErrorMessage = "Este campo deve ter 2 caracteres.")]
        public string UF { get; set; }
    }
}