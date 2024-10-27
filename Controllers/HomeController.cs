using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP9_Login_Benezra.Models;

namespace TP9_Login_Benezra.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View("Registro");
    }

    [HttpPost]
    public IActionResult AgregarUsuario(string UserName, string Email, string Contraseña){
        BD.AgregarUsuario(UserName,Email,Contraseña);
        return View("Index");
    }
}
