using egovBroadcastingModel.Models;
using Microsoft.EntityFrameworkCore;

namespace egovBroadcastingModel.Data
{
   
        public class AppDbContext : DbContext
        {
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
            {
            }

            // DbSet for DisasterNotice entity
            public DbSet<DisasterNotice> DisasterNotices { get; set; }

            // DbSet for Comment entity
            public DbSet<Comment> Comments { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);

                // Configuring the relationship between DisasterNotice and Comment
                modelBuilder.Entity<DisasterNotice>()
                    .HasMany(d => d.Comments)
                    .WithOne(c => c.DisasterNotice)
                    .HasForeignKey(c => c.DisasterNoticeId);
            }
        }
    }

