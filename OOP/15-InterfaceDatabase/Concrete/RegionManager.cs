﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace _15_InterfaceDatabase.Concrete
{
   public class RegionManager(IDbConnection db)
    {
        public Region GetById(int shipperId)
        {
            return db.Query<Region>("Select * from Shippers where ShipperID=" + shipperId).FirstOrDefault();
        }

        public IEnumerable<Region> GetAll()
        {
            return db.Query<Region>("Select * from Shippers");

        }
    }
}
