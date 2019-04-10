using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HangfireWebApi.Models
{
    public partial class HangfiretestdbContext : DbContext
    {
        public HangfiretestdbContext()
        {
        }

        public HangfiretestdbContext(DbContextOptions<HangfiretestdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Hangfiretbl> Hangfiretbl { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("server=.\\SQLEXPRESS;database=Hangfiretestdb;Integrated Security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Hangfiretbl>(entity =>
            {
                entity.ToTable("hangfiretbl");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DatePosted).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });
        }
    }
}
