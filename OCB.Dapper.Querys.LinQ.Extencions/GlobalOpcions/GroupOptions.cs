using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace OCB.Dapper.Querys.LinQ.Extencions.GlobalOpcions
{
    public class GroupOptions : IDisposable
    {
        #region Properties

        protected IDbConnection _dbConnection;

        #endregion

        #region Construct

        // start with conection string
        public GroupOptions(string conStr)
        {
            if (string.IsNullOrEmpty(conStr))
                throw new Exception("ConectionString is null or empty. Please, give a valid conection string");

            _dbConnection.ConnectionString = conStr;
        }

        #endregion

        #region Disposable

        public void Dispose()
        {
            _dbConnection.ConnectionString = "";
        }

        #endregion
    }
}
