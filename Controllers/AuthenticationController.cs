using blogapi.Models;
using Microsoft.AspNetCore.Mvc;

namespace blogapi.Controllers;



[Controller]
[Route("[controller]")]
public class AuthenticationController(BlogApiContext dbContext) : Controller
{
    private BlogApiContext _dbContext = dbContext;

    //Si solo retorno una vista, no es necesario usar un metodo async
    [HttpGet("Login")]
    public ActionResult Login()
    {
        return View();
    }

    [HttpGet("Register")]
    public ActionResult Register()
    {
        return View();
    }

    [HttpPost("Login")]
    public async Task<IActionResult> Login(Author model)
    {
        return NotFound();
    }

    [HttpPost("Register")]
    public async Task<IActionResult> Register(Author model)
    {
        string mail = @model.Email;
        string password = @model.Password;


        return NotFound();
    }

    [HttpPost("Logout")]
    public async Task<IActionResult> Logout()
    {
        return Ok();
    }

}