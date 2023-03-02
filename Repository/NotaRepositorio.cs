using ProjetoCadastro.Data;
using ProjetoCadastro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCadastro.Repository
{
    public class NotaRepositorio : INotaRepositorio
    {
        private readonly BancoContext _bancoContext;

        public NotaRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public NotaModel add(NotaModel nota)
        {
            _bancoContext.Notas.Add(nota);
            _bancoContext.SaveChanges();
            return nota;
        }

        public List<NotaModel> BuscarTodos()
        {
            return _bancoContext.Notas.ToList();
        }

        public bool delete(int id)
        {
            NotaModel notaDB = ListbyId(id);
            _bancoContext.Notas.Remove(notaDB);
            _bancoContext.SaveChanges(); ;
            return true;
        }

        public NotaModel ListbyId(int id)
        {
            return _bancoContext.Notas.FirstOrDefault(x => x.Id == id);
        }

        public NotaModel Update(NotaModel nota)
        {
            NotaModel notaDB = ListbyId(nota.Id);
            if (notaDB == null) throw new SystemException("Houve um erro na atualização do contato");
            notaDB.nota = nota.nota;
            notaDB.data = nota.data;
            _bancoContext.Notas.Update(nota);
            _bancoContext.SaveChanges();
            return notaDB;
        }
    }

      
 }
