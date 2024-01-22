using Microsoft.EntityFrameworkCore;
using Startup.Models;

namespace Startup.DAL
{
    public class NoteDbContext : DbContext
    {
        public NoteDbContext(DbContextOptions<NoteDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("your_connection_string_here",
                options => options.EnableRetryOnFailure());
        }

        public DbSet<Note> Notes { get; set; }
    }
}
