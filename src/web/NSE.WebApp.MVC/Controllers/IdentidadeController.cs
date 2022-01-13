﻿using Microsoft.AspNetCore.Mvc;
using NSE.WebApp.MVC.Models;
using System.Threading.Tasks;

namespace NSE.WebApp.MVC.Controllers
{
    public class IdentidadeController : Controller
    {
        [HttpGet]
        [Route("nova-conta")]
        public IActionResult Registro()
        {
            return View();
        }

        [HttpPost]
        [Route("nova-conta")]
        public async Task<ActionResult> Registro(UsuarioRegistro usuarioRegistro)
        {
            if(!ModelState.IsValid) return View(usuarioRegistro);

            // API - Registro

            if(false) return View(usuarioRegistro);

            // Realizar login na APP 

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        [Route("login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [Route("login")]
        public async Task<ActionResult> Login(UsuarioLogin usuarioLogin)
        {
            if (!ModelState.IsValid) return View(usuarioLogin);

            // API - Login

            if (false) return View(usuarioLogin);

            // Realizar login na APP 

            return RedirectToAction("Index", "Home");
        }


        [HttpPost]
        [Route("sair")]
        public async Task<ActionResult> Sair()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
