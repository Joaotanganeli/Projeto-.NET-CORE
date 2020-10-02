using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Projeto.NET.Models;
using Projeto_.NET.Models;

namespace Projeto.NET.Controllers
{
    public class JogadorController : Controller
    {
        JogadorDALL jogadorDALL = new JogadorDALL();
        public IActionResult Index()
        {
            List<Jogador> JList = new List<Jogador>();
            JList = jogadorDALL.GetAllJogador().ToList();
            return View(JList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind] Jogador obj_jogador)
        {
            if (ModelState.IsValid)
            {
                jogadorDALL.AddJogador(obj_jogador);
                return RedirectToAction("Index");
            }
            return View(obj_jogador);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Jogador J1 = jogadorDALL.GetJogadoresById(id);
            if (J1 == null)
            {
                return NotFound();
            }
            return View(J1);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int? id, [Bind] Jogador Obj_Jogador)
        {
            if (id == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                jogadorDALL.UpdateJogador(Obj_Jogador);
                return RedirectToAction("Index");
            }
            return View(jogadorDALL);
        }
        [HttpGet]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Jogador J1 = jogadorDALL.GetJogadoresById(id);
            if (J1 == null)
            {
                return NotFound();
            }
            return View(J1);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Jogador J1 = jogadorDALL.GetJogadoresById(id);
            if (J1 == null)
            {
                return NotFound();
            }
            return View(J1);
        }


        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteJ1(int? id)
        {
            jogadorDALL.DeleteJogador(id);
            return RedirectToAction("Index");
        }
    }
}
