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
/// Summary description for MST_UnitDAL
/// </summary>
/// 
namespace CostingEvalution.App_Code.DAL
{
    public class MST_UnitDAL : DatabaseConfig
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
        public MST_UnitDAL()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        #endregion Constructor
    
        #region Insert Operation

        public Boolean Insert(MST_UnitENT entMST_Unit)
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
                        objCmd.CommandText = "SP_MST_Unit_Insert";
                        
                        objCmd.Parameters.AddWithValue("@UnitName", entMST_Unit.UnitName);
                        objCmd.Parameters.AddWithValue("@Description", entMST_Unit.Description);
                        objCmd.Parameters.AddWithValue("@CreateDateTime", entMST_Unit.CreateDateTime);
                        objCmd.Parameters.AddWithValue("@CreateBy", entMST_Unit.CreateBy);
                        objCmd.Parameters.AddWithValue("@CreateIP", entMST_Unit.CreateIP);
                        objCmd.Parameters.AddWithValue("@UpdateDateTime", entMST_Unit.UpdateDateTime);
                        objCmd.Parameters.AddWithValue("@UpdateBy", entMST_Unit.UpdateBy);
                        objCmd.Parameters.AddWithValue("@UpdateIP", entMST_Unit.UpdateIP);
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

        public Boolean Update(MST_UnitENT entMST_Unit)
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
                        objCmd.CommandText = "SP_MST_Unit_Update";

                        objCmd.Parameters.AddWithValue("@UnitID", entMST_Unit.UnitID);
                        objCmd.Parameters.AddWithValue("@UnitName", entMST_Unit.UnitName);
                        objCmd.Parameters.AddWithValue("@Description", entMST_Unit.Description);
                        objCmd.Parameters.AddWithValue("@CreateDateTime", entMST_Unit.CreateDateTime);
                        objCmd.Parameters.AddWithValue("@CreateBy", entMST_Unit.CreateBy);
                        objCmd.Parameters.AddWithValue("@CreateIP", entMST_Unit.CreateIP);
                        objCmd.Parameters.AddWithValue("@UpdateDateTime", entMST_Unit.UpdateDateTime);
                        objCmd.Parameters.AddWithValue("@UpdateBy", entMST_Unit.UpdateBy);
                        objCmd.Parameters.AddWithValue("@UpdateIP", entMST_Unit.UpdateIP);

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

        public Boolean Delete(SqlInt32 UnitID)
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
                        objCmd.CommandText = "SP_MST_Unit_Delete";
                        
                        objCmd.Parameters.AddWithValue("@UnitID", UnitID);            
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
                        objCmd.CommandText = "SP_MST_Unit_Select";

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
        public MST_UnitENT SelectPK(SqlInt32 UnitID)
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
                        MST_UnitENT entMST_Unit = new MST_UnitENT();
                        #endregion Variables

                        #region Prepare Command
                        objCmd.CommandType = CommandType.StoredProcedure;
                        objCmd.CommandText = "SP_MST_Unit_SelectPK";
                        objCmd.Parameters.AddWithValue("@UnitID", UnitID);
                        #endregion Prepare Command

                        #region Set Controls
                        using (SqlDataReader objSDR = objCmd.ExecuteReader())
                        {
							dt.Load(objSDR);
                        }
						foreach (DataRow dr in dt.Rows)
						{
							if (!dr["UnitID"].Equals(DBNull.Value))
                            {
                                entMST_Unit.UnitID = Convert.ToInt32(dr["UnitID"]);
                            }

                            if (!dr["UnitName"].Equals(DBNull.Value))
                            {
                                entMST_Unit.UnitName = Convert.ToString(dr["UnitName"]);
                            }

                            if (!dr["Description"].Equals(DBNull.Value))
                            {
                                entMST_Unit.Description = Convert.ToString(dr["Description"]);
                            }

                            if (!dr["CreateDateTime"].Equals(DBNull.Value))
                            {
                                entMST_Unit.CreateDateTime = Convert.ToDateTime(dr["CreateDateTime"]);
                            }

                            if (!dr["CreateBy"].Equals(DBNull.Value))
                            {
                                entMST_Unit.CreateBy = Convert.ToInt32(dr["CreateBy"]);
                            }

                            if (!dr["CreateIP"].Equals(DBNull.Value))
                            {
                                entMST_Unit.CreateIP = Convert.ToString(dr["CreateIP"]);
                            }

                            if (!dr["UpdateDateTime"].Equals(DBNull.Value))
                            {
                                entMST_Unit.UpdateDateTime = Convert.ToDateTime(dr["UpdateDateTime"]);
                            }

                            if (!dr["UpdateBy"].Equals(DBNull.Value))
                            {
                                entMST_Unit.UpdateBy = Convert.ToInt32(dr["UpdateBy"]);
                            }

                            if (!dr["UpdateIP"].Equals(DBNull.Value))
                            {
                                entMST_Unit.UpdateIP = Convert.ToString(dr["UpdateIP"]);
                            }
						}
						return entMST_Unit;

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
                        objCmd.CommandText = "SP_MST_Unit_SelectForDropDown";
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
