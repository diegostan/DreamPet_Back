using DPBack.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure; // <<< ???  
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DPBack.Domain.Infra.Contexts
{
    public class DataContext:DbContext
    {
         public DataContext()
    {
    }
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Owner> Owners{get;set;}
        public DbSet<Pet> Pets{get;set;}

        protected override void OnModelCreating(ModelBuilder model)
        {            
            model.Entity<Owner>().HasKey(s => s.Id);
            model.Entity<Owner>().OwnsOne(s => s.Name, od=>
            {
                od.Property(d => d.FirstName);
                od.Property(d => d.FirstName).UsePropertyAccessMode(PropertyAccessMode.Property);
                od.Property(d => d.LastName);
                od.Property(f => f.LastName).UsePropertyAccessMode(PropertyAccessMode.Property);
            });

            model.Entity<Owner>().Property(s => s.Address);
            model.Entity<Owner>().Property(s => s.Fone);
            
            model.Entity<Owner>().OwnsOne(s => s.Document, od=>
            {
                od.Property(d => d.DocumentNumber);
                od.Property(d => d.DocumentNumber).UsePropertyAccessMode(PropertyAccessMode.Property);
                od.Property(d => d.DocumentType);
                od.Property(d => d.DocumentType).UsePropertyAccessMode(PropertyAccessMode.Property);
            });
            model.Entity<Owner>().Ignore(s=> s.Notifications);
                
            //Pets 
            //Corrigir os contextos no SQLSERVER<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
             model.Entity<Pet>().OwnsOne(s => s.Name, od=>
            {
                od.Property(d => d.FirstName);
                od.Property(d => d.FirstName).UsePropertyAccessMode(PropertyAccessMode.Property);
                od.Property(d => d.LastName);
                od.Property(d => d.LastName).UsePropertyAccessMode(PropertyAccessMode.Property);
            });
            model.Entity<Pet>().Ignore(s=> s.Notifications);
                            
        }
    }

}