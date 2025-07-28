
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class LoginController : Controller
{
    private readonly ILogger<LoginController> _logger;
    
    public LoginController(ILogger<LoginController> logger)
        {
        _logger = logger;
        }
    
    
    [HttpGet("/login")]
    public IActionResult Index()
    {
        return View("~/Views/Home/Login.cshtml");
    }
    
    [HttpPost]
    public IActionResult Index(string username, string password)
    {
        return RedirectToAction("Index", "Home");
    }
}