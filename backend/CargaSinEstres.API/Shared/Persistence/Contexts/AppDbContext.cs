using CargaSinEstres.API.CargaSinEstres.Domain.Models;
using CargaSinEstres.API.Security.Domain.Models;
using CargaSinEstres.API.Shared.Extensions;
using Microsoft.EntityFrameworkCore;
using Company = CargaSinEstres.API.Security.Domain.Models.Company;

namespace CargaSinEstres.API.Shared.Persistence.Contexts;

public class AppDbContext : DbContext
{
    public DbSet<Company> Companies { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<BookingHistory> BookingHistories { get; set; }
    
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        
        builder.Entity<Client>().ToTable("Clients");
        builder.Entity<Client>().HasKey(p => p.Id);
        builder.Entity<Client>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<Client>().Property(p => p.Nombre).IsRequired().HasMaxLength(50);
        builder.Entity<Client>().Property(p => p.Apellido_materno).IsRequired().HasMaxLength(50);
        builder.Entity<Client>().Property(p => p.Apellido_paterno).IsRequired().HasMaxLength(50);
        builder.Entity<Client>().Property(p => p.Celular).IsRequired().HasMaxLength(50);
        builder.Entity<Client>().Property(p => p.Correo).IsRequired().HasMaxLength(50);
        builder.Entity<Client>().Property(p => p.Contraseña).IsRequired().HasMaxLength(50);
        builder.Entity<Client>().Property(p => p.Direccion).HasMaxLength(120);
        
        builder.Entity<BookingHistory>().ToTable("BookingHistories");
        builder.Entity<BookingHistory>().HasKey(p => p.Id);
        builder.Entity<BookingHistory>().Property(p => p.IdCompany).IsRequired();
        builder.Entity<BookingHistory>().Property(p => p.idClient).IsRequired();
        builder.Entity<BookingHistory>().Property(p => p.bookingDate).IsRequired().HasMaxLength(50);
        builder.Entity<BookingHistory>().Property(p => p.pickupAdress).IsRequired().HasMaxLength(150);
        builder.Entity<BookingHistory>().Property(p => p.destinationAdress).IsRequired().HasMaxLength(150);
        builder.Entity<BookingHistory>().Property(p => p.movingDate).IsRequired().HasMaxLength(50);
        builder.Entity<BookingHistory>().Property(p => p.Status).IsRequired().HasMaxLength(50);
        
        // Constraints
        builder.Entity<Company>().ToTable("Companies");
        builder.Entity<Company>().HasKey(p => p.Id);
        builder.Entity<Company>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<Company>().Property(p => p.Name).IsRequired().HasMaxLength(30); 
        builder.Entity<Company>().Property(p => p.Photo).IsRequired().HasMaxLength(350); 
        builder.Entity<Company>().Property(p => p.Email).IsRequired().HasMaxLength(120); 
        builder.Entity<Company>().Property(p => p.Direccion).IsRequired().HasMaxLength(150); 
        builder.Entity<Company>().Property(p => p.NumeroContacto).IsRequired().HasMaxLength(30); 
        builder.Entity<Company>().Property(p => p.Password).IsRequired().HasMaxLength(30); 
        builder.Entity<Company>().Property(p => p.ConfirmarPassword).IsRequired().HasMaxLength(30);
        builder.Entity<Company>().Property(p => p.Transporte).IsRequired();
        builder.Entity<Company>().Property(p => p.Carga).IsRequired();
        builder.Entity<Company>().Property(p => p.Embalaje).IsRequired();
        builder.Entity<Company>().Property(p => p.Montaje).IsRequired();
        builder.Entity<Company>().Property(p => p.Desmontaje).IsRequired();
        builder.Entity<Company>().Property(p => p.Description).IsRequired().HasMaxLength(150); 
        builder.Entity<Company>().Property(p => p.UserType).IsRequired().HasMaxLength(50);
        builder.Entity<Company>().Property(p => p.AverageRating).IsRequired().HasMaxLength(50);
        
        // Relationships
        builder.Entity<Company>()
             .HasMany(p => p.Reviews)
             .WithOne(p => p.Company)
             .HasForeignKey(p => p.CompanyId);
        
        builder.Entity<Review>().ToTable("Reviews");
        builder.Entity<Review>().HasKey(p => p.Id);
        builder.Entity<Review>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<Review>().Property(p => p.Rating).IsRequired().HasMaxLength(50);
        builder.Entity<Review>().Property(p => p.Comment).HasMaxLength(120);

        
        builder.UseSnakeCaseNamingConvention();
        
    }
    
}