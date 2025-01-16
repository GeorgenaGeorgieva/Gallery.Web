using Gallery.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Newtonsoft.Json;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;


namespace Gallery.Data
{
    public class GalleryDbContext : IdentityDbContext<User>
    {
        public GalleryDbContext(DbContextOptions<GalleryDbContext> options)
            : base(options)
        {
        }

        public DbSet<Image> Images { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<ArtType> ArtTypes { get; set; }
        public override DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder modelBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasMany(u => u.Picturies)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId)
                .HasPrincipalKey(e => e.Id)
                .IsRequired();

            builder.Entity<Picture>()
                .HasOne(p => p.ArtType)
                .WithMany(a => a.Pictures)
                .HasForeignKey(p => p.ArtTypeId)
                .HasPrincipalKey(a => a.Id)
                .IsRequired();

            builder.Entity<User>()
                .HasOne(e => e.Image)
                .WithOne(e => e.User)
                .HasForeignKey<Image>(e => e.Id)
                .IsRequired();

            builder.Entity<User>()
                .HasMany(u => u.Picturies)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId)
                .IsRequired();

            var converter = new ValueConverter<decimal, double>(
                v => (double)v,
                v => (decimal)v
            );

            builder.Entity<Picture>()
                .Property(e => e.Rating)
                .HasConversion(converter);

            base.OnModelCreating(builder);
        }
    }
}
