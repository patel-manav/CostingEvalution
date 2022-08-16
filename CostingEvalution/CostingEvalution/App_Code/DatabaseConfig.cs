using System;
using System.Collections.Generic;
using System.Configuration;
using System.Web;

namespace CostingEvalution.App_Code
{
    public class DatabaseConfig
    {
        #region Constructor
        public DatabaseConfig()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        #endregion Constructor

        #region ConnectionString
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["CostingEvalutionConnectionString"].ConnectionString.ToString();
        #endregion ConnectionString
    }
}