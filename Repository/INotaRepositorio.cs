using ProjetoCadastro.Models;
using ProjetoCadastro.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCadastro.Repository
{
    interface INotaRepositorio
    {
        NotaModel ListbyId(int id);
        List<NotaModel> BuscarTodos();
        NotaModel add(NotaModel nota);
        NotaModel Update(NotaModel nota);
        bool delete(int id);

    }
}
