using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
namespace blogapi.Models;

public class Post
{
    [Key]
    public int Id {get; set;}

    [Required]
    [MaxLength(200)]
    public string Title {get; set;}

    [Required]
    public string Content {get; set;}
    public DateOnly PublicationDate {get; set;}
    public int AuthorId {get; set;}
    public virtual Author author {get; set;}
}