

namespace Proyecto4.Models
{
    using System.Data.Entity;
    public class DataContext:DbContext
    {

        public DataContext():base("DefaultConnection")
        {


        }

        public System.Data.Entity.DbSet<Proyecto4.Models.Product> Products { get; set; }
    }
}