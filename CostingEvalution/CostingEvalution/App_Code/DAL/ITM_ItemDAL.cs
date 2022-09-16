using CostingEvalution;
using CostingEvalution.App_Code.BAL;
using CostingEvalution.App_Code.ENT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ITM_ItemDAL
/// </summary>
/// 
namespace CostingEvalution.App_Code.DAL
{
    public class ITM_ItemDAL : DatabaseConfig
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
        public ITM_ItemDAL()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        #endregion Constructor
    
        #region Insert Operation

        public Boolean Insert(ITM_ItemENT entITM_Item)
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
                        objCmd.CommandText = "PR_ITM_Item_Insert";
                        
                        objCmd.Parameters.Add("@ItemID", SqlDbType.Int, 4).Direction = ParameterDirection.Output;
                        objCmd.Parameters.AddWithValue("@ItemName", entITM_Item.ItemName);
                        objCmd.Parameters.AddWithValue("@ItemTypeID", entITM_Item.ItemTypeID);
                        objCmd.Parameters.AddWithValue("@CreateDateTime", entITM_Item.CreateDateTime);
                        objCmd.Parameters.AddWithValue("@CreateBy", entITM_Item.CreateBy);
                        objCmd.Parameters.AddWithValue("@CreateIP", entITM_Item.CreateIP);
                        objCmd.Parameters.AddWithValue("@UpdateDateTime", entITM_Item.UpdateDateTime);
                        objCmd.Parameters.AddWithValue("@UpdateBy", entITM_Item.UpdateBy);
                        objCmd.Parameters.AddWithValue("@UpdateIP", entITM_Item.UpdateIP);
                        #endregion Prepare Command

                        objCmd.ExecuteNonQuery();
                        entITM_Item.ItemID = Convert.ToInt32(objCmd.Parameters["@ItemID"].Value);

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

        public Boolean Update(ITM_ItemENT entITM_Item)
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
                        objCmd.CommandText = "PR_ITM_Item_Update";

                        objCmd.Parameters.AddWithValue("@ItemID", entITM_Item.ItemID);
                        objCmd.Parameters.AddWithValue("@ItemName", entITM_Item.ItemName);
                        objCmd.Parameters.AddWithValue("@ItemTypeID", entITM_Item.ItemTypeID);
                        objCmd.Parameters.AddWithValue("@CreateDateTime", entITM_Item.CreateDateTime);
                        objCmd.Parameters.AddWithValue("@CreateBy", entITM_Item.CreateBy);
                        objCmd.Parameters.AddWithValue("@CreateIP", entITM_Item.CreateIP);
                        objCmd.Parameters.AddWithValue("@UpdateDateTime", entITM_Item.UpdateDateTime);
                        objCmd.Parameters.AddWithValue("@UpdateBy", entITM_Item.UpdateBy);
                        objCmd.Parameters.AddWithValue("@UpdateIP", entITM_Item.UpdateIP);

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

        public Boolean Delete(SqlInt32 ItemID)
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
                        objCmd.CommandText = "PR_ITM_Item_Delete";
                        
                        objCmd.Parameters.AddWithValue("@ItemID", ItemID);            
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
        public DataTable Select(SqlString ItemName, SqlInt32 ItemTypeID)
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
                        objCmd.CommandText = "PR_ITM_Item_Select";

                        objCmd.Parameters.AddWithValue("@ItemName", ItemName);
                        objCmd.Parameters.AddWithValue("@ItemTypeID", ItemTypeID);
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
        public ITM_ItemENT SelectPK(SqlInt32 ItemID)
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
                        ITM_ItemENT entITM_Item = new ITM_ItemENT();
                        #endregion Variables

                        #region Prepare Command
                        objCmd.CommandType = CommandType.StoredProcedure;
                        objCmd.CommandText = "PR_ITM_Item_SelectPK";
                        objCmd.Parameters.AddWithValue("@ItemID", ItemID);
                        #endregion Prepare Command

                        #region Set Controls
                        using (SqlDataReader objSDR = objCmd.ExecuteReader())
                        {
							dt.Load(objSDR);
                        }
						foreach (DataRow dr in dt.Rows)
						{
							if (!dr["ItemID"].Equals(DBNull.Value))
                            {
                                entITM_Item.ItemID = Convert.ToInt32(dr["ItemID"]);
                            }

                            if (!dr["ItemName"].Equals(DBNull.Value))
                            {
                                entITM_Item.ItemName = Convert.ToString(dr["ItemName"]);
                            }

                            if (!dr["ItemTypeID"].Equals(DBNull.Value))
                            {
                                entITM_Item.ItemTypeID = Convert.ToInt32(dr["ItemTypeID"]);
                            }

                            if (!dr["CreateDateTime"].Equals(DBNull.Value))
                            {
                                entITM_Item.CreateDateTime = Convert.ToDateTime(dr["CreateDateTime"]);
                            }

                            if (!dr["CreateBy"].Equals(DBNull.Value))
                            {
                                entITM_Item.CreateBy = Convert.ToInt32(dr["CreateBy"]);
                            }

                            if (!dr["CreateIP"].Equals(DBNull.Value))
                            {
                                entITM_Item.CreateIP = Convert.ToString(dr["CreateIP"]);
                            }

                            if (!dr["UpdateDateTime"].Equals(DBNull.Value))
                            {
                                entITM_Item.UpdateDateTime = Convert.ToDateTime(dr["UpdateDateTime"]);
                            }

                            if (!dr["UpdateBy"].Equals(DBNull.Value))
                            {
                                entITM_Item.UpdateBy = Convert.ToInt32(dr["UpdateBy"]);
                            }

                            if (!dr["UpdateIP"].Equals(DBNull.Value))
                            {
                                entITM_Item.UpdateIP = Convert.ToString(dr["UpdateIP"]);
                            }
						}
						return entITM_Item;

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
                        objCmd.CommandText = "PR_ITM_Item_SelectForDropDown";
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
