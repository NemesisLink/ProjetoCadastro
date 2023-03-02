using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjetoCadastro.Models
{
    public class MatériaModel
    {
        [Key] public int Id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set;}

        
   

    }
}
