using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Libary.Data;

public partial class DblibaryContext : DbContext
{
    public DblibaryContext()
    {
    }

    public DblibaryContext(DbContextOptions<DblibaryContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Autor> Autors { get; set; }

    public virtual DbSet<Delivery> Deliveries { get; set; }

    public virtual DbSet<Epoch> Epoches { get; set; }

    public virtual DbSet<Genre> Genres { get; set; }

    public virtual DbSet<LibaryCheck> LibaryChecks { get; set; }

    public virtual DbSet<Publication> Publications { get; set; }

    public virtual DbSet<PublicationAutor> PublicationAutors { get; set; }

    public virtual DbSet<Reader> Readers { get; set; }

    public virtual DbSet<Region> Regions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-ND89MD8\\SQLEXPRESS; Database=DBLibary; Trusted_Connection=True; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Autor>(entity =>
        {
            entity.Property(e => e.AutorName).HasMaxLength(50);
            entity.Property(e => e.Pseudonym).HasMaxLength(50);

            entity.HasOne(d => d.Region).WithMany(p => p.Autors)
                .HasForeignKey(d => d.RegionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Autors_Regions");
        });

        modelBuilder.Entity<Delivery>(entity =>
        {
            entity.Property(e => e.PostOfficeAdress).HasMaxLength(50);

            entity.HasOne(d => d.Reader).WithMany(p => p.Deliveries)
                .HasForeignKey(d => d.ReaderId)
                .HasConstraintName("FK_Deliveries_Readers");
        });

        modelBuilder.Entity<Epoch>(entity =>
        {
            entity.Property(e => e.EpochName).HasMaxLength(50);
        });

        modelBuilder.Entity<Genre>(entity =>
        {
            entity.Property(e => e.GenreName).HasMaxLength(50);
        });

        modelBuilder.Entity<LibaryCheck>(entity =>
        {
            entity.Property(e => e.DateTime).HasColumnType("datetime");

            entity.HasOne(d => d.Delivery).WithMany(p => p.LibaryChecks)
                .HasForeignKey(d => d.DeliveryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LibaryChecks_Deliveries");

            entity.HasOne(d => d.Publication).WithMany(p => p.LibaryChecks)
                .HasForeignKey(d => d.PublicationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LibaryChecks_Publications");
        });

        modelBuilder.Entity<Publication>(entity =>
        {
            entity.Property(e => e.Annotation).HasMaxLength(50);
            entity.Property(e => e.BookName).HasMaxLength(50);

            entity.HasOne(d => d.Epoch).WithMany(p => p.Publications)
                .HasForeignKey(d => d.EpochId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Publications_Epoches");

            entity.HasOne(d => d.Genre).WithMany(p => p.Publications)
                .HasForeignKey(d => d.GenreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Publications_Genres");
        });

        modelBuilder.Entity<PublicationAutor>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.PublicationAutor)
                .HasForeignKey<PublicationAutor>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PublicationAutors_Autors");

            entity.HasOne(d => d.Publication).WithMany(p => p.PublicationAutors)
                .HasForeignKey(d => d.PublicationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PublicationAutors_Publications");
        });

        modelBuilder.Entity<Reader>(entity =>
        {
            entity.Property(e => e.Address).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.NickName).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
        });

        modelBuilder.Entity<Region>(entity =>
        {
            entity.Property(e => e.RegionName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
