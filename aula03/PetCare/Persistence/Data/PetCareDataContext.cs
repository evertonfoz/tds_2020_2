using Microsoft.EntityFrameworkCore;
using PetCare.Domain.Entities;
using PetCare.Persistence.Data.Maps;

namespace PetCare.Persistence.Data
{
    public class PetCareDataContext : DbContext
    {
        public DbSet<OwnerEntity> Owners { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS; Database=PetCare;Trusted_Connection=True;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
            => modelBuilder.ApplyConfiguration(new OwnerMap());
    }
}
