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

    public IActionResult Index()
    {
        return View();
    }
}