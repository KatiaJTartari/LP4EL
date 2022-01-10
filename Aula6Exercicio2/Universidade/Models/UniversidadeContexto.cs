using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Universidade.Models;

namespace Universidade.Models
{
    public class UniversidadeContexto : DbContext {
        public UniversidadeContexto() : base("name=UniversidadeContexto") {  }

        public DbSet<Curso> Curso { get; set; }
        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Disciplina> Disciplina { get; set; }
        public DbSet<Professor> Professor { get; set; }

    }
}