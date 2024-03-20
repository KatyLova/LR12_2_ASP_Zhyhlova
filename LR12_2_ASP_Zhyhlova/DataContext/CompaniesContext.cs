using LR12_2_ASP_Zhyhlova.Models;
using Microsoft.EntityFrameworkCore;

namespace LR12_2_ASP_Zhyhlova.DataContext
{
    public class CompaniesContext : DbContext
    {
        public DbSet<Company> Company { get; set; } = null!;
        public CompaniesContext(DbContextOptions<CompaniesContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
