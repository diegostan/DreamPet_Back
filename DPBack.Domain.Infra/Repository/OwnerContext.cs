using DPBack.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BPBack.Domain.Infra.Repository
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
            model.Entity<Owner>().Property(x => x.Name.FirstName);
            model.Entity<Owner>().Property(x => x.Name.LastName);
            model.Entity<Owner>().Property(x => x.Document.DocumentNumber).HasColumnType("varchar(50)");
            model.Entity<Owner>().Property(x => x.Document.DocumentType).HasColumnType("bit");
        }
    }
    
}