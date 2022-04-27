using Microsoft.EntityFrameworkCore;

namespace BookApp.React.Models
{
    public class BookAppDBContext: DbContext
    {
        public BookAppDBContext()
        {
            
        }

        public BookAppDBContext(DbContextOptions<BookAppDBContext> options):base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=jdbc:sqlite:identifier.sqlite.db;Version=3");
        }
        
        // DefaultConnection": "DataSource=app.db;Cache=Shared"

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().Property(m => m.Created).HasDefaultValueSql("GetDate()");
        }
    } 
}