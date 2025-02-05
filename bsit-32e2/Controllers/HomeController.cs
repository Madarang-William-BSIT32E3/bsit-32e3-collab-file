using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using bsit_32e2.Models;

namespace bsit_32e2.Controllers;

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

    public string HelloWorld() => "Hello World!";
    public string HelloWorldFromBsitBranch() => "Hello World from BSIT 32E3 Branch!";
    

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
