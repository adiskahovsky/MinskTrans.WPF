using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinskTransLib.DAL.Entities
{
    public class RouteToStop
    {
        public int Id { get; set; }

        public virtual RouteInfo Route { get; set; }

        public virtual StopInfo Stops { get; set; }

        public DateTime VisitTime { get; set; }



    }
}
