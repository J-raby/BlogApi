using Microsoft.AspNetCore.Mvc;
namespace blogapi.Controllers;

[Controller]
[Route("/")]
public class HomeController : Controller{

    public IActionResult Index(){
        return View();
    }

}