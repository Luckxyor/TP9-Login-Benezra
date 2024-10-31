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
        return View();
    }

    public IActionResult Registro(){
        return View();
    }

    public IActionResult Login(){
        return View();
    }

    public IActionResult OlvideContraseña(){
        return View();
    }
}
