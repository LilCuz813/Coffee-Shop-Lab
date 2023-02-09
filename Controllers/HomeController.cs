using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Coffee_Shop_Lab.Models;

namespace Coffee_Shop_Lab.Controllers;

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

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Form()
    {
        return View();
    }

    public IActionResult Result(string firstName, string lastName, string email, string password)
    {
        string result = $"Thank you for signing up {firstName}! Now grind away!";
        return View("Result",result);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

