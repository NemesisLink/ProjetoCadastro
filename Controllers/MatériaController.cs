using Microsoft.AspNetCore.Mvc;
using ProjetoCadastro.Models;
using ProjetoCadastro.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCadastro.Controllers
{
    public class MatériaController : Controller
    {
        private readonly IMatériaRepositorio _matériaRepositorio;

        public MatériaController(IMatériaRepositorio matériaRepositorio)
        {

        }
        public IActionResult Index(int id)
        {
            return View();
        }
        [HttpPost]

        public IActionResult Criar(MatériaModel matéria)
        {
            _matériaRepositorio.add(matéria);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Apagar(int id)
        {
            _matériaRepositorio.delete(id);
            return RedirectToAction("Index");
        }
        public IActionResult Editar(int id)
        {
            MatériaModel matéria = _matériaRepositorio.ListbyId(id);
            return View(matéria);
        }
        [HttpPost]
        public IActionResult Alterar(MatériaModel matéria)
        {
            _matériaRepositorio.Update(matéria);
            return RedirectToAction("Index");



        }
    }
}
