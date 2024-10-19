using Microsoft.EntityFrameworkCore;

namespace ProjectCatan.Models
{
    public class FieldContext : DbContext
    {
        public DbSet<Field>? Fields { get; set; }

        public FieldContext(DbContextOptions<FieldContext> options)
            : base(options)
        { }
    }
}
