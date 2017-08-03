namespace DataTables.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataTablesModel : DbContext
    {
        public DataTablesModel()
            : base("name=DataTablesModel")
        {
            Database.SetInitializer(new InitDatabase());
        }

        public virtual DbSet<Employees> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
