using Microsoft.EntityFrameworkCore;
using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Configuration;

public class ToDoDbContext : DbContext
{
    // Define DbSets for each table in your database
    public DbSet<User> Users { get; set; }
    public DbSet<Post> Posts { get; set; }

    // Configure your database connection, e.g., in OnConfiguring or via Dependency Injection
    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    optionsBuilder.UseSqlite("Data Source=todoDatabase.db");
    //}

    // encrypted version include the SQLCipher

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Load configuration
        var configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

        // Retrieve connection string and encryption key from configuration
        var connectionString = configuration["ConnectionStrings:Database"];
        var encryptionKey = configuration["DatabaseKey"];

        // Ensure both connection string and encryption key are not null or empty
        if (string.IsNullOrWhiteSpace(connectionString))
        {
            throw new InvalidOperationException("Connection string is missing or empty in appsettings.json.");
        }
        if (string.IsNullOrWhiteSpace(encryptionKey))
        {
            throw new InvalidOperationException("Database encryption key is missing or empty in appsettings.json.");
        }

        // Create and configure SQLite connection
        var connection = new SqliteConnection(connectionString);
        connection.Open();

        // Set the encryption key
        using (var command = connection.CreateCommand())
        {
            command.CommandText = $"PRAGMA key = '{encryptionKey}';";
            command.ExecuteNonQuery();
        }

        // Configure DbContext to use the SQLite connection
        optionsBuilder.UseSqlite(connection);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Example: Configure relationship between User and Post
        modelBuilder.Entity<Post>()
            .HasOne(p => p.User)
            .WithMany(u => u.Posts)
            .HasForeignKey(p => p.UserId);
    }
}