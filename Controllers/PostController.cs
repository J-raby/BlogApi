using blogapi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace blogapi.Controllers;

public class PostController(BlogApiContext dbContext) : Controller
{
    private BlogApiContext _dbContext = dbContext;

    public async Task<IActionResult> Index(){
        var posteos = await  _dbContext.posts.ToListAsync<Post>();
        return View(posteos);
    }
}