using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebAppMvcAlunos.Models;

namespace WebAppMvcAlunos
{
    public class AlunoContext : DbContext
    {
        public AlunoContext():base("name=strConexao")
        {

        }

        public DbSet<Aluno> Alunos { get; set; }

    }
}