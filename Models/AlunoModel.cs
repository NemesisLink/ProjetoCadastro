using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace ProjetoCadastro.Models
{
    public class AlunoModel
    {
        [Key] public int Id { get; set; }
        public string nome { get; set; }
        [Required (ErrorMessage ="Digite o nome do Aluno")]
        public string email { get; set; }
        [Required(ErrorMessage = "Digite o email do Aluno")]
        [EmailAddress(ErrorMessage="O email informado não é valido")]
        [ForeignKey("Matéria")] public virtual List<MatériaModel> Matéria { get; set; }

        [ForeignKey("Nota")] public virtual NotaModel NotaModel { get; set; }


    }
}
