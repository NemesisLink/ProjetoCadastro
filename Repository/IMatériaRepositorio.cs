using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoCadastro.Models;

namespace ProjetoCadastro.Repository
{
    public interface IMatériaRepositorio
    {

        MatériaModel ListbyId(int id);
        List<MatériaModel> BuscarTodos();
        MatériaModel add(MatériaModel matéria);
        MatériaModel Update(MatériaModel matéria);
        bool delete(int id);





    }
}
