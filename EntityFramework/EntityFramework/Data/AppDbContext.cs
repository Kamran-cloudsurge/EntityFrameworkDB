using Microsoft.EntityFrameworkCore;

namespace Microsoft.EntityFramework.Data;

public class AppDbContext : DbContext

{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

}
