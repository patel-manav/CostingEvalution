using CostingEvalution;
using CostingEvalution.App_Code.ENT;
using CostingEvalution.App_Code.BAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for SEC_UserDAL
/// </summary>
/// 
namespace CostingEvalution.App_Code.DAL
{
    public class SEC_UserDAL : DatabaseConfig
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
        public SEC_UserDAL()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        #endregion Constructor
    
        #region Insert Operation

        public Boolean Insert(SEC_UserENT entSEC_User)
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
                        objCmd.CommandText = "SP_SEC_User_Insert";
                        
                        objCmd.Parameters.Add("@UserID", SqlDbType.Int, 4).Direction = ParameterDirection.Output;
                        objCmd.Parameters.AddWithValue("@UserName", entSEC_User.UserName);
                        objCmd.Parameters.AddWithValue("@UserDisplayName", entSEC_User.UserDisplayName);
                        objCmd.Parameters.AddWithValue("@UserPassword", entSEC_User.UserPassword);
                        objCmd.Parameters.AddWithValue("@Description", entSEC_User.Description);
                        objCmd.Parameters.AddWithValue("@CreateDateTime", entSEC_User.CreateDateTime);
                        objCmd.Parameters.AddWithValue("@CreateIP", entSEC_User.CreateIP);
                        objCmd.Parameters.AddWithValue("@CreateBy", entSEC_User.CreateBy);
                        objCmd.Parameters.AddWithValue("@UpdateDateTime", entSEC_User.UpdateDateTime);
                        objCmd.Parameters.AddWithValue("@UpdateIP", entSEC_User.UpdateIP);
                        objCmd.Parameters.AddWithValue("@UpdateBy", entSEC_User.UpdateBy);
                        #endregion Prepare Command

                        objCmd.ExecuteNonQuery();
                        entSEC_User.UserID = Convert.ToInt32(objCmd.Parameters["@UserID"].Value);

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

        public Boolean Update(SEC_UserENT entSEC_User)
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
                        objCmd.CommandText = "SP_SEC_User_Update";

                        objCmd.Parameters.AddWithValue("@UserID", entSEC_User.UserID);
                        objCmd.Parameters.AddWithValue("@UserName", entSEC_User.UserName);
                        objCmd.Parameters.AddWithValue("@UserDisplayName", entSEC_User.UserDisplayName);
                        objCmd.Parameters.AddWithValue("@UserPassword", entSEC_User.UserPassword);
                        objCmd.Parameters.AddWithValue("@Description", entSEC_User.Description);
                        objCmd.Parameters.AddWithValue("@CreateDateTime", entSEC_User.CreateDateTime);
                        objCmd.Parameters.AddWithValue("@CreateIP", entSEC_User.CreateIP);
                        objCmd.Parameters.AddWithValue("@CreateBy", entSEC_User.CreateBy);
                        objCmd.Parameters.AddWithValue("@UpdateDateTime", entSEC_User.UpdateDateTime);
                        objCmd.Parameters.AddWithValue("@UpdateIP", entSEC_User.UpdateIP);
                        objCmd.Parameters.AddWithValue("@UpdateBy", entSEC_User.UpdateBy);

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

        public Boolean Delete(SqlInt32 UserID)
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
                        objCmd.CommandText = "SP_SEC_User_Delete";
                        
                        objCmd.Parameters.AddWithValue("@UserID", UserID);            
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
        public DataTable Select()
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
                        objCmd.CommandText = "SP_SEC_User_Select";

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
        public SEC_UserENT SelectPK(SqlInt32 UserID)
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
                        SEC_UserENT entSEC_User = new SEC_UserENT();
                        #endregion Variables

                        #region Prepare Command
                        objCmd.CommandType = CommandType.StoredProcedure;
                        objCmd.CommandText = "SP_SEC_User_SelectPK";
                        objCmd.Parameters.AddWithValue("@UserID", UserID);
                        #endregion Prepare Command

                        #region Set Controls
                        using (SqlDataReader objSDR = objCmd.ExecuteReader())
                        {
							dt.Load(objSDR);
                        }
						foreach (DataRow dr in dt.Rows)
						{
							if (!dr["UserID"].Equals(DBNull.Value))
                            {
                                entSEC_User.UserID = Convert.ToInt32(dr["UserID"]);
                            }

                            if (!dr["UserName"].Equals(DBNull.Value))
                            {
                                entSEC_User.UserName = Convert.ToString(dr["UserName"]);
                            }

                            if (!dr["UserDisplayName"].Equals(DBNull.Value))
                            {
                                entSEC_User.UserDisplayName = Convert.ToString(dr["UserDisplayName"]);
                            }

                            if (!dr["UserPassword"].Equals(DBNull.Value))
                            {
                                entSEC_User.UserPassword = Convert.ToString(dr["UserPassword"]);
                            }

                            if (!dr["Description"].Equals(DBNull.Value))
                            {
                                entSEC_User.Description = Convert.ToString(dr["Description"]);
                            }

                            if (!dr["CreateDateTime"].Equals(DBNull.Value))
                            {
                                entSEC_User.CreateDateTime = Convert.ToDateTime(dr["CreateDateTime"]);
                            }

                            if (!dr["CreateIP"].Equals(DBNull.Value))
                            {
                                entSEC_User.CreateIP = Convert.ToString(dr["CreateIP"]);
                            }

                            if (!dr["CreateBy"].Equals(DBNull.Value))
                            {
                                entSEC_User.CreateBy = Convert.ToInt32(dr["CreateBy"]);
                            }

                            if (!dr["UpdateDateTime"].Equals(DBNull.Value))
                            {
                                entSEC_User.UpdateDateTime = Convert.ToDateTime(dr["UpdateDateTime"]);
                            }

                            if (!dr["UpdateIP"].Equals(DBNull.Value))
                            {
                                entSEC_User.UpdateIP = Convert.ToString(dr["UpdateIP"]);
                            }

                            if (!dr["UpdateBy"].Equals(DBNull.Value))
                            {
                                entSEC_User.UpdateBy = Convert.ToInt32(dr["UpdateBy"]);
                            }
						}
						return entSEC_User;

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
                        objCmd.CommandText = "SP_SEC_User_SelectForDropDown";
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

        #region UserSignIn
        public DataTable UserSignIn(String UserName, String UserPassword)
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
                        objCmd.CommandText = "SEC_Login_Select";
                        objCmd.Parameters.AddWithValue("@UserName", UserName);
                        objCmd.Parameters.AddWithValue("@UserPassword", UserPassword);

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
        #endregion UserSignIn
    }
}
