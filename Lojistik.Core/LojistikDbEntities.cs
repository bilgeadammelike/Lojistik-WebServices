using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lojistik.Core
{
    public class LojistikDbEntities:DbContext
    {
        public LojistikDbEntities():base("name=LojistikDbEntities")
        {
           // Database.Connection.ConnectionString = "";

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public virtual DbSet<Gemi> Gemi { get; set; }

        public virtual DbSet<Liman> Liman { get; set; }

        public virtual DbSet<Firma> Firma { get; set; }

    }
}
