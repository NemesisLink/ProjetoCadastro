using ProjetoCadastro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCadastro.Repository
{
   public interface IAlunoRepositorio
    {
        AlunoModel ListbyId(int id);
        List<AlunoModel> BuscarTodos();
        AlunoModel add(AlunoModel aluno);
        AlunoModel Update(AlunoModel aluno);
        bool delete(int id);
       

    }
}
