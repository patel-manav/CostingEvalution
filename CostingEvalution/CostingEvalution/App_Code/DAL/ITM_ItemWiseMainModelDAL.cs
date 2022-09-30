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
/// Summary description for ITM_ItemWiseMainModelDAL
/// </summary>
/// 
namespace CostingEvalution.App_Code.DAL
{
    public class ITM_ItemWiseMainModelDAL : DatabaseConfig
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
        public ITM_ItemWiseMainModelDAL()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        #endregion Constructor
    
        #region Insert Operation

        public Boolean Insert(ITM_ItemWiseMainModelENT entITM_ItemWiseMainModel)
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
                        objCmd.CommandText = "SP_ITM_ItemWiseMainModel_Insert";
                        
                        objCmd.Parameters.Add("@ItemWiseMainModelID", SqlDbType.Int, 4).Direction = ParameterDirection.Output;
                        objCmd.Parameters.AddWithValue("@ItemID", entITM_ItemWiseMainModel.ItemID);
                        objCmd.Parameters.AddWithValue("@MainModelID", entITM_ItemWiseMainModel.MainModelID);
                        objCmd.Parameters.AddWithValue("@CreateDateTime", entITM_ItemWiseMainModel.CreateDateTime);
                        objCmd.Parameters.AddWithValue("@CreateBy", entITM_ItemWiseMainModel.CreateBy);
                        objCmd.Parameters.AddWithValue("@CreateIP", entITM_ItemWiseMainModel.CreateIP);
                        objCmd.Parameters.AddWithValue("@UpdateDateTime", entITM_ItemWiseMainModel.UpdateDateTime);
                        objCmd.Parameters.AddWithValue("@UpdateBy", entITM_ItemWiseMainModel.UpdateBy);
                        objCmd.Parameters.AddWithValue("@UpdateIP", entITM_ItemWiseMainModel.UpdateIP);
                        #endregion Prepare Command

                        objCmd.ExecuteNonQuery();
                        entITM_ItemWiseMainModel.ItemWiseMainModelID = Convert.ToInt32(objCmd.Parameters["@ItemWiseMainModelID"].Value);

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

        public Boolean Update(ITM_ItemWiseMainModelENT entITM_ItemWiseMainModel)
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
                        objCmd.CommandText = "SP_ITM_ItemWiseMainModel_Update";

                        objCmd.Parameters.AddWithValue("@ItemWiseMainModelID", entITM_ItemWiseMainModel.ItemWiseMainModelID);
                        objCmd.Parameters.AddWithValue("@ItemID", entITM_ItemWiseMainModel.ItemID);
                        objCmd.Parameters.AddWithValue("@MainModelID", entITM_ItemWiseMainModel.MainModelID);
                        objCmd.Parameters.AddWithValue("@CreateDateTime", entITM_ItemWiseMainModel.CreateDateTime);
                        objCmd.Parameters.AddWithValue("@CreateBy", entITM_ItemWiseMainModel.CreateBy);
                        objCmd.Parameters.AddWithValue("@CreateIP", entITM_ItemWiseMainModel.CreateIP);
                        objCmd.Parameters.AddWithValue("@UpdateDateTime", entITM_ItemWiseMainModel.UpdateDateTime);
                        objCmd.Parameters.AddWithValue("@UpdateBy", entITM_ItemWiseMainModel.UpdateBy);
                        objCmd.Parameters.AddWithValue("@UpdateIP", entITM_ItemWiseMainModel.UpdateIP);

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

        public Boolean Delete(SqlInt32 ItemWiseMainModelID)
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
                        objCmd.CommandText = "SP_ITM_ItemWiseMainModel_Delete";
                        
                        objCmd.Parameters.AddWithValue("@ItemWiseMainModelID", ItemWiseMainModelID);            
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
                        objCmd.CommandText = "SP_ITM_ItemWiseMainModel_Select";

                        
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
        public ITM_ItemWiseMainModelENT SelectPK(SqlInt32 ItemWiseMainModelID)
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
                        ITM_ItemWiseMainModelENT entITM_ItemWiseMainModel = new ITM_ItemWiseMainModelENT();
                        #endregion Variables

                        #region Prepare Command
                        objCmd.CommandType = CommandType.StoredProcedure;
                        objCmd.CommandText = "SP_ITM_ItemWiseMainModel_SelectPK";
                        objCmd.Parameters.AddWithValue("@ItemWiseMainModelID", ItemWiseMainModelID);
                        #endregion Prepare Command

                        #region Set Controls
                        using (SqlDataReader objSDR = objCmd.ExecuteReader())
                        {
							dt.Load(objSDR);
                        }
						foreach (DataRow dr in dt.Rows)
						{
							if (!dr["ItemWiseMainModelID"].Equals(DBNull.Value))
                            {
                                entITM_ItemWiseMainModel.ItemWiseMainModelID = Convert.ToInt32(dr["ItemWiseMainModelID"]);
                            }

                            if (!dr["ItemID"].Equals(DBNull.Value))
                            {
                                entITM_ItemWiseMainModel.ItemID = Convert.ToInt32(dr["ItemID"]);
                            }

                            if (!dr["MainModelID"].Equals(DBNull.Value))
                            {
                                entITM_ItemWiseMainModel.MainModelID = Convert.ToInt32(dr["MainModelID"]);
                            }

                            if (!dr["CreateDateTime"].Equals(DBNull.Value))
                            {
                                entITM_ItemWiseMainModel.CreateDateTime = Convert.ToDateTime(dr["CreateDateTime"]);
                            }

                            if (!dr["CreateBy"].Equals(DBNull.Value))
                            {
                                entITM_ItemWiseMainModel.CreateBy = Convert.ToInt32(dr["CreateBy"]);
                            }

                            if (!dr["CreateIP"].Equals(DBNull.Value))
                            {
                                entITM_ItemWiseMainModel.CreateIP = Convert.ToString(dr["CreateIP"]);
                            }

                            if (!dr["UpdateDateTime"].Equals(DBNull.Value))
                            {
                                entITM_ItemWiseMainModel.UpdateDateTime = Convert.ToDateTime(dr["UpdateDateTime"]);
                            }

                            if (!dr["UpdateBy"].Equals(DBNull.Value))
                            {
                                entITM_ItemWiseMainModel.UpdateBy = Convert.ToInt32(dr["UpdateBy"]);
                            }

                            if (!dr["UpdateIP"].Equals(DBNull.Value))
                            {
                                entITM_ItemWiseMainModel.UpdateIP = Convert.ToString(dr["UpdateIP"]);
                            }
						}
						return entITM_ItemWiseMainModel;

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
                        objCmd.CommandText = "SP_ITM_ItemWiseMainModel_SelectForDropDown";
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
