using blogapi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace blogapi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthorController(BlogApiContext dbContext) : Controller{
    private readonly BlogApiContext _dbcontext = dbContext;

    [HttpGet]
    public async IAsyncEnumerable<Author> GetAuthors(){ 
        var authors = await _dbcontext.authors.ToListAsync();
        foreach (var author in authors){
          yield return author;
        }        
      
    }

}