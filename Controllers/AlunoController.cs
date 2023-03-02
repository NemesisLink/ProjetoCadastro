using Microsoft.AspNetCore.Mvc;
using ProjetoCadastro.Models;
using ProjetoCadastro.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCadastro.Controllers
{
    public class AlunoController : Controller
    {
        private readonly IAlunoRepositorio _alunoRepositorio;
        public AlunoController(IAlunoRepositorio alunoRepositorio)
        {

        }
        public IActionResult Index(int id)
        {
            return View();
        }
       [HttpPost]
    
    public IActionResult Criar(AlunoModel aluno)
        {
            if(ModelState.IsValid)
                {
                _alunoRepositorio.add(aluno);
                return RedirectToAction("Index");
            }
            return View(aluno);    
        }
        public IActionResult Editar(int id)
        {
            AlunoModel aluno = _alunoRepositorio.ListbyId(id);
            return View(aluno);
        }
        [HttpGet]
        public IActionResult Apagar(int id)
        {
            _alunoRepositorio.delete(id);
            return RedirectToAction("Index");
        }
        public IActionResult ApagarConfirmacao(int id)
        {
            AlunoModel aluno = _alunoRepositorio.ListbyId(id);
            return View(aluno);
        }
        [HttpPost]
        public IActionResult Alterar(AlunoModel aluno)
        {
            _alunoRepositorio.Update(aluno);
            return RedirectToAction("Index");


        }
    }
}
