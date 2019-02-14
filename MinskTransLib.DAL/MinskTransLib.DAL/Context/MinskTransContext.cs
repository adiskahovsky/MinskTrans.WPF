using MinskTransLib.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinskTransLib.DAL.Context
{
    public class MinskTransContext: DbContext
    {


        public MinskTransContext():base(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=MinskTransDb;Integrated Security=True")
        {
                
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public ICollection<RouteInfo> RoutesInfoes { get; set; }
        public ICollection<RouteToStop> routesToStops { get; set; }

        public ICollection<StopInfo> StopsInfoes { get; set; }

        public ICollection<Transport> Transports { get; set; }


    }
}
