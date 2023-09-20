using ApiTest.test.domain;
using Microsoft.EntityFrameworkCore;

namespace ApiTest;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    
    public DbSet<Student> Students { get; set; }
    
}