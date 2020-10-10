namespace Tracker.Web.Data
{
    using Microsoft.EntityFrameworkCore;

    public class TrackerDbContext : DbContext
    {
        public TrackerDbContext(DbContextOptions<TrackerDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured)
                return;

            const string connectionString = "Server=localhost; Database=taxys-local-db-devicelogger; User Id=sa; Password=12345(!)a;";
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<TrackPoint> TrackPoints { get; set; }
    }
}
