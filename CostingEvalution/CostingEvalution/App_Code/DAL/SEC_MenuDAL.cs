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
/// Summary description for SEC_MenuDAL
/// </summary>
/// 
namespace CostingEvalution.App_Code.DAL
{
    public class SEC_MenuDAL : DatabaseConfig
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
        public SEC_MenuDAL()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        #endregion Constructor
    
        #region Insert Operation

        public Boolean Insert(SEC_MenuENT entSEC_Menu)
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
                        objCmd.CommandText = "SP_SEC_Menu_Insert";
                        
                        objCmd.Parameters.AddWithValue("@MenuName", entSEC_Menu.MenuName);
                        objCmd.Parameters.AddWithValue("@MenuImagePath", entSEC_Menu.MenuImagePath);
                        objCmd.Parameters.AddWithValue("@MenuURL", entSEC_Menu.MenuURL);
                        objCmd.Parameters.AddWithValue("@MenuSequence", entSEC_Menu.MenuSequence);
                        objCmd.Parameters.AddWithValue("@CreateDateTime", entSEC_Menu.CreateDateTime);
                        objCmd.Parameters.AddWithValue("@CreateBy", entSEC_Menu.CreateBy);
                        objCmd.Parameters.AddWithValue("@CreateIP", entSEC_Menu.CreateIP);
                        objCmd.Parameters.AddWithValue("@UpdateDateTime", entSEC_Menu.UpdateDateTime);
                        objCmd.Parameters.AddWithValue("@UpdateBy", entSEC_Menu.UpdateBy);
                        objCmd.Parameters.AddWithValue("@UpdateIP", entSEC_Menu.UpdateIP);
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

        #endregion Insert Operation

        #region Update Operation

        public Boolean Update(SEC_MenuENT entSEC_Menu)
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
                        objCmd.CommandText = "SP_SEC_Menu_Update";

                        objCmd.Parameters.AddWithValue("@MenuID", entSEC_Menu.MenuID);
                        objCmd.Parameters.AddWithValue("@MenuName", entSEC_Menu.MenuName);
                        objCmd.Parameters.AddWithValue("@MenuImagePath", entSEC_Menu.MenuImagePath);
                        objCmd.Parameters.AddWithValue("@MenuURL", entSEC_Menu.MenuURL);
                        objCmd.Parameters.AddWithValue("@MenuSequence", entSEC_Menu.MenuSequence);
                        objCmd.Parameters.AddWithValue("@CreateDateTime", entSEC_Menu.CreateDateTime);
                        objCmd.Parameters.AddWithValue("@CreateBy", entSEC_Menu.CreateBy);
                        objCmd.Parameters.AddWithValue("@CreateIP", entSEC_Menu.CreateIP);
                        objCmd.Parameters.AddWithValue("@UpdateDateTime", entSEC_Menu.UpdateDateTime);
                        objCmd.Parameters.AddWithValue("@UpdateBy", entSEC_Menu.UpdateBy);
                        objCmd.Parameters.AddWithValue("@UpdateIP", entSEC_Menu.UpdateIP);

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

        public Boolean Delete(SqlInt32 MenuID)
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
                        objCmd.CommandText = "SP_SEC_Menu_Delete";
                        
                        objCmd.Parameters.AddWithValue("@MenuID", MenuID);            
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
                        objCmd.CommandText = "SP_SEC_Menu_Select";

                        
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
        public SEC_MenuENT SelectPK(SqlInt32 MenuID)
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
                        SEC_MenuENT entSEC_Menu = new SEC_MenuENT();
                        #endregion Variables

                        #region Prepare Command
                        objCmd.CommandType = CommandType.StoredProcedure;
                        objCmd.CommandText = "SP_SEC_Menu_SelectPK";
                        objCmd.Parameters.AddWithValue("@MenuID", MenuID);
                        #endregion Prepare Command

                        #region Set Controls
                        using (SqlDataReader objSDR = objCmd.ExecuteReader())
                        {
							dt.Load(objSDR);
                        }
						foreach (DataRow dr in dt.Rows)
						{
							if (!dr["MenuID"].Equals(DBNull.Value))
                            {
                                entSEC_Menu.MenuID = Convert.ToInt32(dr["MenuID"]);
                            }

                            if (!dr["MenuName"].Equals(DBNull.Value))
                            {
                                entSEC_Menu.MenuName = Convert.ToString(dr["MenuName"]);
                            }

                            if (!dr["MenuImagePath"].Equals(DBNull.Value))
                            {
                                entSEC_Menu.MenuImagePath = Convert.ToString(dr["MenuImagePath"]);
                            }

                            if (!dr["MenuURL"].Equals(DBNull.Value))
                            {
                                entSEC_Menu.MenuURL = Convert.ToString(dr["MenuURL"]);
                            }

                            if (!dr["MenuSequence"].Equals(DBNull.Value))
                            {
                                entSEC_Menu.MenuSequence = Convert.ToDecimal(dr["MenuSequence"]);
                            }

                            if (!dr["CreateDateTime"].Equals(DBNull.Value))
                            {
                                entSEC_Menu.CreateDateTime = Convert.ToDateTime(dr["CreateDateTime"]);
                            }

                            if (!dr["CreateBy"].Equals(DBNull.Value))
                            {
                                entSEC_Menu.CreateBy = Convert.ToInt32(dr["CreateBy"]);
                            }

                            if (!dr["CreateIP"].Equals(DBNull.Value))
                            {
                                entSEC_Menu.CreateIP = Convert.ToString(dr["CreateIP"]);
                            }

                            if (!dr["UpdateDateTime"].Equals(DBNull.Value))
                            {
                                entSEC_Menu.UpdateDateTime = Convert.ToDateTime(dr["UpdateDateTime"]);
                            }

                            if (!dr["UpdateBy"].Equals(DBNull.Value))
                            {
                                entSEC_Menu.UpdateBy = Convert.ToInt32(dr["UpdateBy"]);
                            }

                            if (!dr["UpdateIP"].Equals(DBNull.Value))
                            {
                                entSEC_Menu.UpdateIP = Convert.ToString(dr["UpdateIP"]);
                            }
						}
						return entSEC_Menu;

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
                        objCmd.CommandText = "SP_SEC_Menu_SelectForDropDown";
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

        #region FillMenu
        public DataTable FillMenu(SqlInt32 UserID)
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
                        objCmd.CommandText = "SP_Menu_Fill";
                        objCmd.Parameters.AddWithValue("@UserID", UserID);


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
        #endregion FillMenu

        #endregion Select Operation
    }
}
