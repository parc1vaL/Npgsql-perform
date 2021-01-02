using Microsoft.EntityFrameworkCore;

namespace WebApplication1
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<WeatherForecast> WeatherForecasts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<WeatherForecast>(e =>
            {
                e.HasKey(p => p.Id);
                e.HasData(new WeatherForecast
                {
                    Id = -1,
                    Date = new System.DateTime(2020, 01, 01),
                    Summary = "Nice",
                    TemperatureC = 25,
                });
            });
        }
    }
}
