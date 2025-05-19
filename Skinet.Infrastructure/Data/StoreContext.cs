using Microsoft.EntityFrameworkCore;
using Skinet.Core.Entities;

namespace Skinet.Infrastructure.Data;

public class StoreContext(DbContextOptions options): DbContext(options)
{
    public DbSet<Product> Products { get; set; }
    
}