using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace billing_withEntity.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<snack> snacks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<snack>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<snack>()
                .Property(e => e.Company)
                .IsUnicode(false);
        }
    }
}
