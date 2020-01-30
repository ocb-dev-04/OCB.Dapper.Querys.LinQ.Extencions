using System;
using System.Data;

namespace OCB.Dapper.Querys.LinQ.Extencions.Main
{
    public class OCBDapperMain : IDisposable
    {
        #region Properties

        protected IDbConnection _dbConnection;

        #endregion

        #region Construct

        // start with conection string
        protected OCBDapperMain(string conStr)
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
