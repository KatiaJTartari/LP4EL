using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HospedagemOnline.Models
{
    [MetadataType(typeof(CategoriaMetadado))]
    public partial class Categoria { }

    public class CategoriaMetadado
    {
        [Required(ErrorMessage = "Este campo é obrigatório.", AllowEmptyStrings = false)]
        [StringLength(60, MinimumLength = 4, ErrorMessage = "Este campo deve ter entre 4 e 60 caracteres.")]
        public string Descricao { get; set; }
    }
}
