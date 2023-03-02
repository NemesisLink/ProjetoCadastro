using ProjetoCadastro.Models;
using ProjetoCadastro.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCadastro.Repository
{
    public class MatériaRepositorio : IMatériaRepositorio
    {
        private readonly BancoContext _bancoContext;
      
        public MatériaRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public MatériaModel add(MatériaModel matéria)
        {
            _bancoContext.Matérias.Add(matéria);
            _bancoContext.SaveChanges();
            return matéria;
        }

        public List<MatériaModel> BuscarTodos()
        {
            return _bancoContext.Matérias.ToList();
        }

        public bool delete(int id)
        {
            MatériaModel matériaDB = ListbyId(id);
            _bancoContext.Matérias.Remove(matériaDB);
            _bancoContext.SaveChanges(); ;
            return true;
        }

        public MatériaModel ListbyId(int id)
        {
            return _bancoContext.Matérias.FirstOrDefault(x => x.Id == id);
        }
         
        public MatériaModel Update(MatériaModel matéria)
        {
            MatériaModel matériaDB = ListbyId(matéria.Id);
            if (matériaDB == null) throw new SystemException("Houve um erro na atualização do contato");
            matériaDB.nome = matéria.nome;
            matériaDB.descricao = matéria.descricao;
            _bancoContext.Matérias.Update(matériaDB);
            _bancoContext.SaveChanges();
            return matériaDB;

        }
    }
}
