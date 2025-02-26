using System.ComponentModel.DataAnnotations;

public class Post
{
    [Key]
    public int Id { get; set; }

    [Required]
    public DateTime DateCreated { get; set; } = DateTime.UtcNow;

    [Required]
    [StringLength(100)]
    public string Subject { get; set; }

    public string Content { get; set; }

    public DateTime DateTodo { get; set; }

    public TimeSpan? HourTodo { get; set; }

    // Foreign key for User
    [Required]
    public int UserId { get; set; }

    // Navigation property to link back to the user
    public User User { get; set; }
}
