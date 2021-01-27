using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LibMan.Models.DB
{
    public partial class LibmanContext : DbContext
    {
        public LibmanContext()
        {
        }

        public LibmanContext(DbContextOptions<LibmanContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<User> User { get; set; }

      

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasKey(e => e.Bookid);

                entity.Property(e => e.Author).HasMaxLength(100);

                entity.Property(e => e.Categories).HasMaxLength(100);

                entity.Property(e => e.Cover).HasColumnType("image");

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.Publisher).HasMaxLength(100);

                entity.Property(e => e.Title).HasMaxLength(100);

                entity.Property(e => e.Translator).HasMaxLength(100);

                entity.Property(e => e.Bookid).HasColumnName("BookId");

                entity.Property(e => e.Userid).HasColumnName("UserId");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Userid);

                entity.Property(e => e.Birthdate).HasMaxLength(50);

                entity.Property(e => e.Username).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Firstname).HasMaxLength(50);

                entity.Property(e => e.Photo).HasColumnType("image");

                entity.Property(e => e.Lastname).HasMaxLength(50);

                entity.Property(e => e.Password);

                entity.Property(e => e.Userid).HasColumnName("UserId");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
