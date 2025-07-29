using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class RegisterController : Controller
{
    private readonly ILogger<RegisterController> _logger;
    private readonly AppDbContext _context;

    public RegisterController(ILogger<RegisterController> logger, AppDbContext  context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet("/register")]
    public IActionResult Register()
    {
        return View("~/Views/Home/Register.cshtml");
    }

    [HttpPost("/register")]
    public IActionResult Register(string username, string password)
    {
        var user = new User
        {
            Username = username,
            Password = password
        };
        
        _context.Users.Add(user);
        _context.SaveChanges();
        
        return RedirectToAction("Index", "Home");

    }
    
    
}