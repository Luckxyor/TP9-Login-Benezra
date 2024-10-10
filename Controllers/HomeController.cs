using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP9_Login_Benezra_Sasson.Models;

namespace TP9_Login_Benezra_Sasson.Controllers;

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
}
