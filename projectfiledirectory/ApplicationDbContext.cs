using Microsoft.EntityFrameworkCore;
using projectfiledirectory.Models;

public class ApplicationDbContext: DbContext
{

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
    {
    }
    public DbSet<FileOnDatabaseModel> FileOnDatabaseModel { get; set; }
    public DbSet<FileOnFileSystem> FileOnFileSystem { get; set; }
    public object FilesOnDatabase { get; internal set; }
    public object FilesOnFileSystem { get; internal set; }
}