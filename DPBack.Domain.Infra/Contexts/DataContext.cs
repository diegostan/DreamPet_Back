using DPBack.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure; // <<< ???  
using Microsoft.EntityFrameworkCore.Metadata;

namespace DPBack.Domain.Infra.Contexts
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Owner> Owners{get;set;}
        public DbSet<Pet> Pets{get;set;}

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<Owner>().ToTable("Owners");
            model.Entity<Owner>().Property(s => s.Id);
            model.Entity<Owner>().OwnsOne(s => s.Name).Property(x => x.FirstName);
            model.Entity<Owner>().OwnsOne(s => s.Name).Property(x => x.LastName);                
            model.Entity<Owner>().OwnsOne(s => s.Name).HasIndex(s => s.FirstName);
            model.Entity<Owner>().OwnsOne(s =>s.Name).Property(s => s.LastName);
            model.Entity<Owner>().OwnsOne(s =>s.Document).Property(x => x.DocumentNumber);
            model.Entity<Owner>().OwnsOne(s => s.Document).Property(x => x.DocumentType); 
            model.Entity<Owner>().Property(s => s.CreateDate); 
            model.Entity<Owner>().Property(s => s.Address);             

            // model.Entity<Pet>().ToTable("Pets");
            // model.Entity<Pet>().Property(s => s.Id);
            // model.Entity<Pet>().Property(s => s.Name.FirstName);
            // model.Entity<Pet>().HasIndex(s => s.Name.FirstName);
            // model.Entity<Pet>().Property(s => s.Name.LastName);
            // model.Entity<Pet>().Property(s => s.Age);
            // model.Entity<Pet>().Property(s => s.NascimentDate);
            // model.Entity<Pet>().Property(s => s.Breed);
            // model.Entity<Pet>().Property(s => s.Coat);
            // model.Entity<Pet>().Property(s => s.Personality);
            // model.Entity<Pet>().Property(s => s.Size);
            // model.Entity<Pet>().Property(s => s.Specie);
            // model.Entity<Pet>().Property(s => s.IdentityNumber);    
        }
    }

}