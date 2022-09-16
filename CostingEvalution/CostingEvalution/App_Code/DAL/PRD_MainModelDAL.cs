using CostingEvalution;
using CostingEvalution.App_Code.DAL;
using CostingEvalution.App_Code.BAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using CostingEvalution.App_Code.ENT;

/// <summary>
/// Summary description for PRD_MainModelDAL
/// </summary>
/// 
namespace CostingEvalution.App_Code.DAL
{
    public class PRD_MainModelDAL : DatabaseConfig
    {
        #region Local variables

        protected string _Message;

        public string Message
        {
            get
            {
                return _Message;
            }
            set
            {
                _Message = value;
            }
        }

        #endregion Local variables

        #region Constructor
        public PRD_MainModelDAL()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        #endregion Constructor
    
        #region Insert Operation

        public Boolean Insert(PRD_MainModelENT entPRD_MainModel)
        {
            using (SqlConnection objConn = new SqlConnection(ConnectionString))
            {
                if (objConn.State != ConnectionState.Open)
                    objConn.Open();

                using (SqlCommand objCmd = objConn.CreateCommand())
                {
                    try
                    {
                        #region Prepare Command
                        objCmd.CommandType = CommandType.StoredProcedure;
                        objCmd.CommandText = "PR_PRD_MainModel_Insert";
                        
                        objCmd.Parameters.Add("@MainModelID", SqlDbType.Int, 4).Direction = ParameterDirection.Output;
                        objCmd.Parameters.AddWithValue("@MainModelName", entPRD_MainModel.MainModelName);
                        objCmd.Parameters.AddWithValue("@Description", entPRD_MainModel.Description);
                        objCmd.Parameters.AddWithValue("@CreateDateTime", entPRD_MainModel.CreateDateTime);
                        objCmd.Parameters.AddWithValue("@CreateBy", entPRD_MainModel.CreateBy);
                        objCmd.Parameters.AddWithValue("@CreateIP", entPRD_MainModel.CreateIP);
                        objCmd.Parameters.AddWithValue("@UpdateDateTime", entPRD_MainModel.UpdateDateTime);
                        objCmd.Parameters.AddWithValue("@UpdateBy", entPRD_MainModel.UpdateBy);
                        objCmd.Parameters.AddWithValue("@UpdateIP", entPRD_MainModel.UpdateIP);
                        #endregion Prepare Command

                        objCmd.ExecuteNonQuery();
                        entPRD_MainModel.MainModelID = Convert.ToInt32(objCmd.Parameters["@MainModelID"].Value);

                        return true;
                    }
                    catch (SqlException sqlex)
                    {
                        Message = sqlex.Message.ToString();
                        return false;
                    }
                    catch (Exception ex)
                    {
                        Message = ex.Message.ToString();
                        return false;
                    }
                    finally
                    {
                        if (objConn.State == ConnectionState.Open)
                            objConn.Close();
                    }

                }
            }
        }

        #endregion Insert Operation

        #region Update Operation

        public Boolean Update(PRD_MainModelENT entPRD_MainModel)
        {
            using (SqlConnection objConn = new SqlConnection(ConnectionString))
            {
                if (objConn.State != ConnectionState.Open)
                    objConn.Open();

                using (SqlCommand objCmd = objConn.CreateCommand())
                {
                    try
                    {
                        #region Prepare Command
                        objCmd.CommandType = CommandType.StoredProcedure;
                        objCmd.CommandText = "PR_PRD_MainModel_Update";

                        objCmd.Parameters.AddWithValue("@MainModelID", entPRD_MainModel.MainModelID);
                        objCmd.Parameters.AddWithValue("@MainModelName", entPRD_MainModel.MainModelName);
                        objCmd.Parameters.AddWithValue("@Description", entPRD_MainModel.Description);
                        objCmd.Parameters.AddWithValue("@CreateDateTime", entPRD_MainModel.CreateDateTime);
                        objCmd.Parameters.AddWithValue("@CreateBy", entPRD_MainModel.CreateBy);
                        objCmd.Parameters.AddWithValue("@CreateIP", entPRD_MainModel.CreateIP);
                        objCmd.Parameters.AddWithValue("@UpdateDateTime", entPRD_MainModel.UpdateDateTime);
                        objCmd.Parameters.AddWithValue("@UpdateBy", entPRD_MainModel.UpdateBy);
                        objCmd.Parameters.AddWithValue("@UpdateIP", entPRD_MainModel.UpdateIP);

                        #endregion Prepare Command

                        objCmd.ExecuteNonQuery();

                        return true;
                    }
                    catch (SqlException sqlex)
                    {
                        Message = sqlex.Message.ToString();
                        return false;
                    }
                    catch (Exception ex)
                    {
                        Message = ex.Message.ToString();
                        return false;
                    }
                    finally
                    {
                        if (objConn.State == ConnectionState.Open)
                            objConn.Close();
                    }

                }
            }
        }

        #endregion Update Operation

        #region Delete Operation

        public Boolean Delete(SqlInt32 MainModelID)
        {
            using (SqlConnection objConn = new SqlConnection(ConnectionString))
            {
                if (objConn.State != ConnectionState.Open)
                    objConn.Open();

                using (SqlCommand objCmd = objConn.CreateCommand())
                {
                    try
                    {
                        #region Prepare Command
                        objCmd.CommandType = CommandType.StoredProcedure;
                        objCmd.CommandText = "PR_PRD_MainModel_Delete";
                        
                        objCmd.Parameters.AddWithValue("@MainModelID", MainModelID);            
                        #endregion Prepare Command

                        objCmd.ExecuteNonQuery();

                        return true;

                    }
                    catch (SqlException sqlex)
                    {
                        Message = sqlex.Message.ToString();
                        return false;
                    }
                    catch (Exception ex)
                    {
                        Message = ex.Message.ToString();
                        return false;
                    }
                    finally
                    {
                        if (objConn.State == ConnectionState.Open)
                            objConn.Close();
                    }
                }
            }
        }

        #endregion Delete Operation

        #region Select Operation
        
        #region Select
        public DataTable Select(SqlString MainModelName)
        {
            using (SqlConnection objConn = new SqlConnection(ConnectionString))
            {
                if (objConn.State != ConnectionState.Open)
                    objConn.Open();

                using (SqlCommand objCmd = objConn.CreateCommand())
                {
                    try
                    {
                        #region Prepare Command
                        objCmd.CommandType = CommandType.StoredProcedure;
                        objCmd.CommandText = "PR_PRD_MainModel_Select";

                        objCmd.Parameters.AddWithValue("@MainModelName", MainModelName);
                        #endregion Prepare Command

                        #region ReadData and Set Controls
                        DataTable dt = new DataTable();
                        using (SqlDataReader objSDR = objCmd.ExecuteReader())
                        {
                            dt.Load(objSDR);
                        }
                        return dt;

                        #endregion ReadData and Set Controls
                    }

                    catch (SqlException sqlex)
                    {
                        Message = sqlex.Message.ToString();
                        return null;
                    }

                    catch (Exception ex)
                    {
                        Message = ex.Message.ToString();
                        return null;
                    }

                    finally
                    {
                        if (objConn.State == ConnectionState.Open)
                            objConn.Close();
                    }
                }

            }
        }
        #endregion Select
        
        #region Select PK
        public PRD_MainModelENT SelectPK(SqlInt32 MainModelID)
        {
            using (SqlConnection objConn = new SqlConnection(ConnectionString))
            {
                if (objConn.State != ConnectionState.Open)
                    objConn.Open();

                using (SqlCommand objCmd = objConn.CreateCommand())
                {
                    try
                    {
                        #region Variables
						DataTable dt = new DataTable();
                        PRD_MainModelENT entPRD_MainModel = new PRD_MainModelENT();
                        #endregion Variables

                        #region Prepare Command
                        objCmd.CommandType = CommandType.StoredProcedure;
                        objCmd.CommandText = "PR_PRD_MainModel_SelectPK";
                        objCmd.Parameters.AddWithValue("@MainModelID", MainModelID);
                        #endregion Prepare Command

                        #region Set Controls
                        using (SqlDataReader objSDR = objCmd.ExecuteReader())
                        {
							dt.Load(objSDR);
                        }
						foreach (DataRow dr in dt.Rows)
						{
							if (!dr["MainModelID"].Equals(DBNull.Value))
                            {
                                entPRD_MainModel.MainModelID = Convert.ToInt32(dr["MainModelID"]);
                            }

                            if (!dr["MainModelName"].Equals(DBNull.Value))
                            {
                                entPRD_MainModel.MainModelName = Convert.ToString(dr["MainModelName"]);
                            }

                            if (!dr["Description"].Equals(DBNull.Value))
                            {
                                entPRD_MainModel.Description = Convert.ToString(dr["Description"]);
                            }

                            if (!dr["CreateDateTime"].Equals(DBNull.Value))
                            {
                                entPRD_MainModel.CreateDateTime = Convert.ToDateTime(dr["CreateDateTime"]);
                            }

                            if (!dr["CreateBy"].Equals(DBNull.Value))
                            {
                                entPRD_MainModel.CreateBy = Convert.ToInt32(dr["CreateBy"]);
                            }

                            if (!dr["CreateIP"].Equals(DBNull.Value))
                            {
                                entPRD_MainModel.CreateIP = Convert.ToString(dr["CreateIP"]);
                            }

                            if (!dr["UpdateDateTime"].Equals(DBNull.Value))
                            {
                                entPRD_MainModel.UpdateDateTime = Convert.ToDateTime(dr["UpdateDateTime"]);
                            }

                            if (!dr["UpdateBy"].Equals(DBNull.Value))
                            {
                                entPRD_MainModel.UpdateBy = Convert.ToInt32(dr["UpdateBy"]);
                            }

                            if (!dr["UpdateIP"].Equals(DBNull.Value))
                            {
                                entPRD_MainModel.UpdateIP = Convert.ToString(dr["UpdateIP"]);
                            }
						}
						return entPRD_MainModel;

                        #endregion Set Controls
                    }

                    catch (SqlException sqlex)
                    {
                        Message = sqlex.Message.ToString();
                        return null;
                    }

                    catch (Exception ex)
                    {
                        Message = ex.Message.ToString();
                        return null;
                    }

                    finally
                    {
                        if (objConn.State == ConnectionState.Open)
                            objConn.Close();
                    }
                }

            }
        }
        #endregion Select PK
        
        #region Select For Dropdown
        public DataTable SelectForDropDown()
        {
            using (SqlConnection objConn = new SqlConnection(ConnectionString))
            {
                if (objConn.State != ConnectionState.Open)
                    objConn.Open();

                using (SqlCommand objCmd = objConn.CreateCommand())
                {
                    try
                    {
                        #region Prepare Command
                        objCmd.CommandType = CommandType.StoredProcedure;
                        objCmd.CommandText = "PR_PRD_MainModel_SelectForDropDown";
                        #endregion Prepare Command

                        #region ReadData and Set Controls
                        DataTable dt = new DataTable();
                        using (SqlDataReader objSDR = objCmd.ExecuteReader())
                        {
                            dt.Load(objSDR);
                        }
                        return dt;

                        #endregion ReadData and Set Controls
                    }

                    catch (SqlException sqlex)
                    {
                        Message = sqlex.Message.ToString();
                        return null;
                    }

                    catch (Exception ex)
                    {
                        Message = ex.Message.ToString();
                        return null;
                    }

                    finally
                    {
                        if (objConn.State == ConnectionState.Open)
                            objConn.Close();
                    }
                }

            }
        }

        #endregion Select For Dropdownlist

        #endregion Select Operation
    }
}
