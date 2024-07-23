using efTest.Models;
using Microsoft.EntityFrameworkCore;

namespace efTest.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<GeneralModel> GenTable {  get; set; }
    }
}
