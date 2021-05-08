using DPBack.Domain.Entities;
using DPBack.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure; // <<< ???  
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DPBack.Domain.Infra.Contexts
{
    public class DataContext:DbContext
    {
 
        public DataContext(){}
        public DataContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Owner> Owners{get;set;}
        public DbSet<Pet> Pets{get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {         
            
            
            modelBuilder.Entity<Owner>().HasKey(s => s.Id);
            
            modelBuilder.Entity<Owner>().Property(s => s.Address).HasColumnName("Address").HasColumnType("varchar(32)");
            modelBuilder.Entity<Owner>().Property(s => s.Fone).HasColumnName("Fone").HasColumnType("varchar(16)");;
                        
            modelBuilder.Entity<Owner>().Ignore(s=> s.Notifications);
                
            //Pets 
            //Corrigir os contextos no SQLSERVER<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
            
             modelBuilder.Entity<Pet>().HasKey(s => s.Id);
             modelBuilder.Entity<Pet>().HasIndex(s => s.OwnerID);
            
           

            modelBuilder.Entity<Pet>().Property(s => s.Size).HasColumnName("Size").HasColumnType("int");
            modelBuilder.Entity<Pet>().Property(s => s.IdentityNumber).HasColumnName("IdentityNumber").HasColumnType("varchar(128)");
            modelBuilder.Entity<Pet>().Property(s => s.NascimentDate).HasColumnName("NascimentDate").HasColumnType("date");
            modelBuilder.Entity<Pet>().Property(s => s.Specie).HasColumnName("Specie").HasColumnType("int");
            modelBuilder.Entity<Pet>().Property(s => s.Personality).HasColumnName("Personality").HasColumnType("int");
            modelBuilder.Entity<Pet>().Property(s => s.Breed).HasColumnName("Breed").HasColumnType("varchar(20)");
                        
            modelBuilder.Entity<Pet>().Ignore(s=> s.Age);
            modelBuilder.Entity<Pet>().Ignore(s=> s.Notifications);
            base.OnModelCreating(modelBuilder);
        }
    }

}