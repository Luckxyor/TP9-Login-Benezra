using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP9_Login_Benezra.Models;

namespace TP9_Login_Benezra.Controllers;

public class Account : Controller
{
    private readonly ILogger<Account> _logger;

    public Account(ILogger<Account> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
}