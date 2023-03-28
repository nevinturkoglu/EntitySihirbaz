using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EntitySihirbaz
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Kategoris> Kategoris { get; set; }
        public virtual DbSet<URUNLERs> URUNLERs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kategoris>()
                .HasMany(e => e.URUNLERs)
                .WithOptional(e => e.Kategoris)
                .HasForeignKey(e => e.Kategori_KategoriID);
        }
    }
}
