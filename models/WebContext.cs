using Microsoft.EntityFrameworkCore;

namespace mojWEB_API.Models;

public class WebContext : DbContext {
    public WebContext(DbContextOptions options) : base(options) {}

    public DbSet<Grad> Grad {get; set;}
}