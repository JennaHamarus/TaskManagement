using backend.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace backend.Core.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Activity> Activities { get; set; }
        public DbSet<Job> Jobs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Job>()
                .HasOne(Job => Job.Activity)
                .WithMany(activity => activity.Jobs)
                .HasForeignKey(job => job.ActivityId);

            modelBuilder.Entity<Activity>()
                .Property(activity => activity.Status)
                .HasConversion<string>();

            modelBuilder.Entity<Job>()
                .Property(job => job.Status)
                .HasConversion<string>();
        }
    }
}
