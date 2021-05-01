using DPBack.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure; // <<< ???  
using Microsoft.EntityFrameworkCore.Metadata;

namespace DPBack.Domain.Infra.Contexts
{
    public class OwnerContext:DbContext
    {
        public OwnerContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Owner> Owners{get;set;}

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<Owner>().Property(s => s.Id);
            model.Entity<Owner>().Property(s => s.Name.FirstName).HasColumnType("varchar(20)");
            model.Entity<Owner>().HasIndex(s => s.Name.FirstName);
            model.Entity<Owner>().Property(s => s.Name.LastName).HasColumnType("varchar(20)");;
            model.Entity<Owner>().Property(s => s.Document.DocumentNumber).HasColumnType("varchar(50)");
            model.Entity<Owner>().Property(s => s.Document.DocumentType).HasColumnType("bit"); 
            model.Entity<Owner>().Property(s => s.CreateDate); 
            model.Entity<Owner>().Property(s => s.Address);              
        }
    }

}