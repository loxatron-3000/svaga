using Microsoft.EntityFrameworkCore;

namespace WpfApp2
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=users.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "John Zalypa", Email = "john@example.com", Age = 28, IsActive = true, RegistrationDate = new DateTime(2023, 1, 15) },
                new User { Id = 2, Name = "Alice Mogila", Email = "alice.johnson@test.org", Age = 32, IsActive = false, RegistrationDate = new DateTime(2022, 11, 3) },
                new User { Id = 3, Name = "Bob Facer", Email = "bob.wilson@company.com", Age = 25, IsActive = true, RegistrationDate = new DateTime(2024, 3, 10) },
                new User { Id = 4, Name = "Emma Gay", Email = "emma.davis@mail.net", Age = 29, IsActive = true, RegistrationDate = new DateTime(2023, 8, 22) }
            );
        }
    }
}