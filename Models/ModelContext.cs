using Microsoft.EntityFrameworkCore;

namespace OracleCommentFail.Models;

public partial class ModelContext : DbContext
{
    public ModelContext() { }
    public ModelContext(DbContextOptions<ModelContext> options) : base(options) { }
    public virtual DbSet<Contact> Addresses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseOracle("ConnectionStrings:DefaultConnection");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("HRCMS");
        modelBuilder.Entity<Contact>(entity =>
        {
            entity.ToTable("CONTACT");
            entity.Property(e => e.FirstName)
                .IsUnicode(false)
                .HasColumnName("FIRST_NAME")
                .HasComment("This is a comment for the FirstName column");
            entity.Property(e => e.LastName)
                .IsUnicode(false)
                .HasColumnName("LAST_NAME")
                .HasComment("This is a comment for the LastName column");
        });
    }
}
