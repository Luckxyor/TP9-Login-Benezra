using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP9_Login_Benezra.Models;

namespace TP9_Login_Benezra.Controllers;

public class AccountController : Controller
{
    private readonly ILogger<AccountController> _logger;

    public AccountController(ILogger<AccountController> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    public IActionResult AgregarUsuario(string UserName, string Email, string Contraseña){
        BD.AgregarUsuario(UserName,Email,Contraseña);
        return RedirectToAction ("Index", "Home");
    }

    [HttpPost]
    public IActionResult InicioSesion(string UserOEmail, string Contraseña){
        bool existe=BD.InicioSesion(UserOEmail,Contraseña);
        if(existe){
            return RedirectToAction ("Index", "Home");
        }
        else{
            ViewBag.mensaje="Usuario y/o contraseña no válidos";
            return View("~/Views/Home/Login.cshtml");
        }
    }

    [HttpPost]
    public IActionResult ActualizarContra(string UserOEmail, string Contraseña){
        BD.ActualizarContraseña(UserOEmail, Contraseña);
    }
}