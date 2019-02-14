using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinskTransLib.DAL.Entities
{
    public class RouteInfo
    {

        public int RouteInfoId { get; set; }

        public string RouteName { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RouteNumber { get; set; }


        public virtual  Transport Transport { get; set; }
    }
}
