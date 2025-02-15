using System.ComponentModel.DataAnnotations;

public class User
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(20)]
    public string Username { get; set; }

    [Required]
    [StringLength(80)]
    public string Password { get; set; }

    //[Required]
    //[StringLength(120)]
    //public string Email { get; set; }


    // Navigation property for related posts
    public ICollection<Post> Posts { get; set; } = new List<Post>();
}
