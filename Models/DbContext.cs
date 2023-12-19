using Microsoft.EntityFrameworkCore;

namespace blogapi.Models;

public class BlogApiContext: DbContext
{
    public DbSet<Author> authors {get; set;}
    public DbSet<Post> posts {get; set;}

    public BlogApiContext(DbContextOptions<BlogApiContext> options) : base(options){
    }
}