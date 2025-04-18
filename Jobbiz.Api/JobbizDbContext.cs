using Microsoft.EntityFrameworkCore;

namespace Jobbiz.Api
{
    public class JobbizDbContext : DbContext
    {
        public JobbizDbContext(DbContextOptions options): base(options)
        {
        }

        // Setting up tables. Each one is always a dbSet
        // Here we got the Vacancies table
        public DbSet<VacancyEntity> Vacancies { get; set; }
    }
}
