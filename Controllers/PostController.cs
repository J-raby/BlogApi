using blogapi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace blogapi.Controllers;

[Authorize]
[Route("[controller]")]
public class PostController(BlogApiContext dbContext) : Controller
{
    private BlogApiContext _dbContext = dbContext;

    public async Task<IActionResult> Index(){
        var posteos = await  _dbContext.posts.ToListAsync<Post>();
        return View(posteos);
    }

    public async Task<IActionResult> GetPost(int id){
        
            var postToDisplay = await _dbContext.posts.FindAsync(id);
            if(postToDisplay == null){
                return View();
            }
            return NotFound();
    }
}