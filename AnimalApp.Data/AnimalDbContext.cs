using AnimalApp.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace AnimalApp.Data
{
    public class AnimalDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public AnimalDbContext(DbContextOptions<AnimalDbContext> context) : base(context)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {

        }

        //protected internal override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //}
    }
}