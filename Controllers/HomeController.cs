using Microsoft.AspNetCore.Mvc;
namespace blogapi.Controllers;
public class HomeController : Controller{

    public IActionResult Index(){
        return View();
    }

}