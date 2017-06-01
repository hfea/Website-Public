using HFEA.Data.Contracts.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Data.Access
{
    public class DataContext : DbContext
    {
        public DataContext() : base("name=HfeaEntities")
        {
            this.Configuration.LazyLoadingEnabled = false;            
        }

        public DbSet<PageRating> PageRatings { get; set; }
        public DbSet<PageComment> PageComments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
