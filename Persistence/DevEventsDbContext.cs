using Api_Rest_1.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api_Rest_1.Persistence
{
    public class DevEventsDbContext : DbContext
    {

        public DevEventsDbContext
            (DbContextOptions<DevEventsDbContext> options) :base(options)

        {
            
        }



        public DbSet<DevEvent> DevEvents { get; set; }
        public DbSet<DevEventSpeaker> DevEventSpeakers { get; set;}




        protected override void OnModelCreating(ModelBuilder Builder)
        {
            Builder.Entity<DevEvent>(e =>
            {
                e.HasKey(de => de.Id);

                e.Property(de => de.Title).IsRequired(false);

                e.Property(de => de.Description)
                .HasMaxLength(200)
                .HasColumnType("varchar(200)");

                e.Property(de => de.StartDate)
                .HasColumnName("Start_Date");

                e.Property(de => de.EndDate)
                .HasColumnName("End_Data");

                e.HasMany(de => de.Speakers)
                .WithOne()
                .HasForeignKey(s => s.DevEventId);
            });


            Builder.Entity<DevEventSpeaker>(e =>
            {
                e.HasKey(de => de.Id);
            });

        }

        
    }
}
