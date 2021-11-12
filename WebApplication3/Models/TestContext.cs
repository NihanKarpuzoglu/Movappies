using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public partial class TestContext : DbContext
    {
        public TestContext()
        {
        }

        public TestContext(DbContextOptions<TestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Movies>(entity =>
            //{
            //    entity.HasKey(e => e.ProductId)
            //        .HasName("PK__Products__B40CC6CD73B27013");

            //    entity.Property(e => e.Category)
            //        .HasMaxLength(30)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Color)
            //        .HasMaxLength(15)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 0)");
            //});

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
