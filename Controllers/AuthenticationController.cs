using blogapi.Models;
using Microsoft.AspNetCore.Mvc;

namespace blogapi.Controllers;



[Controller]
[Route("[controller]")]
public class AuthenticationController(BlogApiContext dbContext) : Controller
{
    private BlogApiContext _dbContext = dbContext;

//Si solo retorno una vista, no es necesario usar un metodo async
    [HttpGet]
    public ActionResult Index(){
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Login(){
        return NotFound();
    }

    [HttpPost]
    public async Task<IActionResult> Register(Author model){
        string mail = @model.Email;
        string password = @model.Password;
        

        return NotFound();        
    }

    public async Task<IActionResult> Logout(){
        return Ok();
    }

}