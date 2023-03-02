using System;   
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoCadastro.Models;

namespace ProjetoCadastro.Data
{
    public class BancoContext : DbContext

    {
    public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }
       public DbSet<AlunoModel> Alunos { get; set; }
       public DbSet<MatériaModel> Matérias { get; set; }
       public DbSet<NotaModel> Notas { get; set; }
    
    }

}
