using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models;

public class User
{
    [Key]
    public string Username { get; set; } //Primary key
    public string Password { get; set; }
}