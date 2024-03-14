using Microsoft.EntityFrameworkCore;

namespace RapidRetail.Api;

public class RapidRetailDbContext : DbContext
{
    public RapidRetailDbContext(DbContextOptions<RapidRetailDbContext> options) : base(options) { }

    // TODO: Add DbSet properties here
}
