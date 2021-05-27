﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SaraiManagement.Models.Classes;
using SaraiManagement.Models;
using SaraiManagement.Models.ClassesEF;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SaraiManagement.Models.Enuns;
using SaraiManagement.Models.ViewModels;

namespace SaraiManagement.Controllers
{
    public class DoacaoController : Controller
    {
        private IDoacaoRepositorio repositorio;
        private ApplicationDbContext context;
        public DoacaoController(IDoacaoRepositorio repo, ApplicationDbContext ctx)
        {
            repositorio = repo;
            context = ctx;
        }

        public ViewResult List() =>
          View(new DoacaoListViewModel
          {
              Doacaos = repositorio.Doacoes
              .OrderBy(d => d.DoacaoID)
          });

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.DonatarioID = new SelectList(context.Donatarios.OrderBy(f
           => f.Nome), "DonatarioID", "Nome"); 
            ViewBag.UsuarioID = new SelectList(context.Usuarios.OrderBy(f
           => f.Nome), "UsuarioID", "Nome");
            ViewBag.CaixaID = new SelectList(context.Caixas.OrderBy(f
           => f.Descricao), "CaixaID", "Descricao");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Doacao doacao)
        {
            repositorio.Create(doacao);
            return View();
        }

        [HttpGet]
        public IActionResult Consultar(int id)
        {
            var doacao = repositorio.Consultar(id);
            return View(doacao);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var doacao = context.Doacaos.Find(id);
            return View(doacao);
        }
        [HttpPost]
        public IActionResult Edit(Doacao doacao)
        {
            repositorio.Edit(doacao);
            return RedirectToAction("HomeController");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var doacao = repositorio.Consultar(id);
            return View(doacao);
        }
        [HttpPost]
        public IActionResult Delete(Doacao doacao)
        {
            repositorio.Delete(doacao);
            return RedirectToAction("HomeController");
        }
    }
}
