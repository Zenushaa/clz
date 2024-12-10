using Microsoft.EntityFrameworkCore;

namespace test01.Data;

public class ApplicationDbContext :DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }
    public DbSet<student> students { get; set; }
}
