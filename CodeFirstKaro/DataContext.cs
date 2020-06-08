using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace CodeFirstKaro
{
    class DataContext : DbContext
    {
        public DataContext()
            : base("DbConnectionKaro")
        { }
        public DbSet<store> stores { get; set; }
        public DbSet<product> products { get; set; }
        public DbSet<productInStore> productsInStore { get; set; }
    }

}
