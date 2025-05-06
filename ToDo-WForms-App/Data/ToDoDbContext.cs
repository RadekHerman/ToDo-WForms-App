using Microsoft.EntityFrameworkCore;
using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Configuration;
using System.Reflection;

public class ToDoDbContext : DbContext
{
    // Define DbSets for each table in your database
    public DbSet<User> Users { get; set; }
    public DbSet<Post> Posts { get; set; }


    public static IConfiguration LoadEmbeddedConfiguration()
    {
        var assembly = Assembly.GetExecutingAssembly();
        var resourceName = "ToDo_WForms_App.appsettings.json";

        using (var stream = assembly.GetManifestResourceStream(resourceName))
        using (var reader = new StreamReader(stream))
        {
            var json = reader.ReadToEnd();

            // Load the JSON into IConfiguration
            var configuration = new ConfigurationBuilder()
                .AddJsonStream(new MemoryStream(System.Text.Encoding.UTF8.GetBytes(json)))
                .Build();

            return configuration;
        }
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Load configuration
        //var configuration = new ConfigurationBuilder()
        //    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
        //    .Build();

        // Load configuration file AS Embedded Resource: 
        var configuration = LoadEmbeddedConfiguration();


        var rawPath = configuration["ConnectionStrings:Database"];
        var encryptionKey = configuration["DatabaseKey"];

        // Replace %AppData% with the actual AppData path
        var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        var databaseFilePath = rawPath.Replace("%AppData%", appDataPath);

        // Ensure the directory exists
        var databaseDirectory = System.IO.Path.GetDirectoryName(databaseFilePath);
        if (!string.IsNullOrEmpty(databaseDirectory) && !System.IO.Directory.Exists(databaseDirectory))
        {
            try
            {
                System.IO.Directory.CreateDirectory(databaseDirectory);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating directory: {ex.Message}");
                throw;
            }
        }

        // Build the SQLite connection string
        var connectionString = $"Data Source={databaseFilePath};";

        // Create and configure SQLite connection
        var connection = new SqliteConnection(connectionString);
        connection.Open();

        // Set the encryption key
        using (var command = connection.CreateCommand())
        {
            // uncomment for ENCRYPTION, for production no encryption <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
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