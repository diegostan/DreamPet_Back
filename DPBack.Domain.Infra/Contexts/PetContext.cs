using DPBack.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure; // <<< ???  
using Microsoft.EntityFrameworkCore.Metadata;

namespace DPBack.Domain.Infra.Contexts
{    
    public class PetContext:DbContext
    {
        public PetContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Pet> Pets {get;set;}

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<Pet>().Property(s => s.Id);
            model.Entity<Pet>().Property(s => s.Name.FirstName);
            model.Entity<Pet>().HasIndex(s => s.Name.FirstName);
            model.Entity<Pet>().Property(s => s.Name.LastName);
            model.Entity<Pet>().Property(s => s.Age);
            model.Entity<Pet>().Property(s => s.NascimentDate);
            model.Entity<Pet>().Property(s => s.Breed);
            model.Entity<Pet>().Property(s => s.Coat);
            model.Entity<Pet>().Property(s => s.Personality);
            model.Entity<Pet>().Property(s => s.Size);
            model.Entity<Pet>().Property(s => s.Specie);
            model.Entity<Pet>().Property(s => s.IdentityNumber);           
        }
    }

}