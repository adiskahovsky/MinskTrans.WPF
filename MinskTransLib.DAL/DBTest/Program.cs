using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinskTransLib.DAL.Context;
using MinskTransLib.DAL.Entities;

namespace DBTest
{
    class Program
    {
        static void Main(string[] args)
        {

            using (MinskTransContext db = new MinskTransContext())
            {
                db.Transports.Add(new Transport() { TypeName = "Автобус"} );
                db.SaveChanges();
            }

        }
    }
}
