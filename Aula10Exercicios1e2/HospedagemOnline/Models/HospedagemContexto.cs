using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HospedagemOnline.Models
{
    public class HospedagemContexto : DbContext
    {
        public HospedagemContexto() : base("name=HospedagemContexto") { }
        public DbSet<Estabelecimento> Estabelecimento { get; set; }

        public DbSet<Categoria> Categoria { get; set; }

        public DbSet<Cidade> Cidade { get; set; }

        public DbSet<Quarto> Quarto { get; set; }

        public DbSet<TipoQuarto> TipoQuarto { get; set; }
    }
}