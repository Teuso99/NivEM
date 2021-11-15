using Microsoft.EntityFrameworkCore;

namespace NivEm.Infra.Data.Context
{
    public class NivEmContext : DbContext
    {
        public NivEmContext(DbContextOptions<NivEmContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
