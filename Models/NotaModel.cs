using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace ProjetoCadastro.Models
{
    public class NotaModel
    {
        [Key] public int Id { get; set; }

        public int nota { get; set; }

        public DateTime data { get; set; }

        [ForeignKey("Aluno")] public virtual AlunoModel AlunoModel { get; set; }


        [ForeignKey("Aluno")] public virtual MatériaModel MatériaModel { get; set; }
    }
}
