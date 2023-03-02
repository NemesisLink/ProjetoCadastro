using ProjetoCadastro.Models;
using ProjetoCadastro.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoCadastro.Repository
{
    public class AlunoRepositorio : IAlunoRepositorio
    {
        private readonly BancoContext _bancoContext;
        public AlunoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public AlunoModel add(AlunoModel aluno)
        {
            _bancoContext.Alunos.Add(aluno);
            _bancoContext.SaveChanges();
            return aluno;
        }



        public List<AlunoModel> BuscarTodos()
        {
            return _bancoContext.Alunos.ToList();
        }

        public bool delete(int id)
        {
            AlunoModel alunoDB = ListbyId(id);
            _bancoContext.Alunos.Remove(alunoDB);
            _bancoContext.SaveChanges(); ;
            return true;
        }


        public AlunoModel ListbyId(int id)
        {
            return _bancoContext.Alunos.FirstOrDefault(x => x.Id == id);
        }

        public AlunoModel Update(AlunoModel aluno)
        {
            AlunoModel alunoDB = ListbyId(aluno.Id);
            if (alunoDB == null) throw new SystemException("Houve um erro na atualização do contato");
            alunoDB.nome = aluno.nome;
            alunoDB.email = aluno.email;
            alunoDB.Matéria = aluno.Matéria;
            _bancoContext.Alunos.Update(alunoDB);
            _bancoContext.SaveChanges();
            return alunoDB;

        }
       
    }
}