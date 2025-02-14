using Microsoft.EntityFrameworkCore;

public class ToDoDbContext : DbContext
{
    // Define DbSets for each table in your database
    public DbSet<User> Users { get; set; }
    public DbSet<Post> Posts { get; set; }

    // Configure your database connection, e.g., in OnConfiguring or via Dependency Injection
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=todoDatabase.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Example: Configure a primary key if not following EF conventions
        // modelBuilder.Entity<User>().HasKey(u => u.Id);
        // modelBuilder.Entity<Post>().HasKey(p => p.Id);

        // Example: Configure relationship between User and Post
        modelBuilder.Entity<Post>()
            .HasOne(p => p.User)
            .WithMany(u => u.Posts)
            .HasForeignKey(p => p.UserId);
    }
}