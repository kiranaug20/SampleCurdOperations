using SampleCurdOperations.Models;
using Microsoft.EntityFrameworkCore;

namespace SampleCurdOperations
{
    public class UserDetialsContext : DbContext
    {
        public UserDetialsContext(DbContextOptions<UserDetialsContext> options) : base(options) { }
        
            public DbSet<MUser> mUsers {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MUser>(entity =>
            {
                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MobileNumber)
                    .IsRequired()
                    .HasMaxLength(12);

                entity.Property(e => e.Address)
                   .IsRequired()
                   .HasMaxLength(150);


                entity.Property(e => e.DOB)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");
            });
        }
    }
    }

