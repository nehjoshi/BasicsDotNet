using Microsoft.EntityFrameworkCore;
using BasicDotNetApp.Models;

namespace BasicDotNetApp.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Item> Items { get; set; }
    }
}
