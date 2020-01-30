using OCB.Dapper.Querys.LinQ.Extencions.Main;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace OCB.Dapper.Querys.LinQ.Extencions.Dispenser
{
    public class GetsDispenserMain
    {
        private string _con;
        public GetsDispenserMain(IDbConnection _dbConnection)
        {
            _con = _dbConnection.ConnectionString;
        }
    }
}
