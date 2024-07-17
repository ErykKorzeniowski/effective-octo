using EffectiveOcto.Domain;
using Microsoft.EntityFrameworkCore;

namespace EffectiveOcto.Data;

public class EffectiveOctoDbContext : DbContext
{
    public EffectiveOctoDbContext(DbContextOptions<EffectiveOctoDbContext> options) : base(options)
    {
    }
    public DbSet<IpAddressSubmission> IpAddressSubmissions { get; set; }
}
