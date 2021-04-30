using DPBack.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure; // <<< ???  
using Microsoft.EntityFrameworkCore.Metadata;

namespace BPBack.Domain.Infra.Contexts
{
    public class OwnerContext : DbContext
    {
        public OwnerContext(DbContextOptions options) : base(options)
        {
        }

        DbSet<Owner> Owners{get;set;}

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<Owner>().Property(x => x.Id);
            model.Entity<Owner>().Property(x => x.Name.FirstName).HasColumnType("varchar(20)");
            model.Entity<Owner>().HasIndex(x => x.Name.FirstName);
            model.Entity<Owner>().Property(x => x.Name.LastName).HasColumnType("varchar(20)");;
            model.Entity<Owner>().Property(x => x.Document.DocumentNumber).HasColumnType("varchar(50)");
            model.Entity<Owner>().Property(x => x.Document.DocumentType).HasColumnType("bit"); 
            model.Entity<Owner>().Property(x => x.CreateDate); 
            model.Entity<Owner>().Property(x => x.Address);              
        }
    }

}