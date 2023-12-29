using System.ComponentModel.DataAnnotations;

namespace blogapi.Models;

public class Author
{
    [Key]
    public int Id {get; set;}
    
    [Required]
    public string Name {get; set;}
    public string Email {get; set;}

    public string Password {get; set;}

    public List<Post> posts {get; set;}
}