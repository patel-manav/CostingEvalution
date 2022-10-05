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
/// Summary description for ITM_ItemWiseRawMaterialDAL
/// </summary>
/// 
namespace CostingEvalution.App_Code.DAL
{
    public class ITM_ItemWiseRawMaterialDAL : DatabaseConfig
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
        public ITM_ItemWiseRawMaterialDAL()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        #endregion Constructor
    
        #region Insert Operation

        public Boolean Insert(ITM_ItemWiseRawMaterialENT entITM_ItemWiseRawMaterial)
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
                        objCmd.CommandText = "SP_ITM_ItemWiseRawMaterial_Insert";
                        
                        objCmd.Parameters.Add("@ItemWiseRawMaterialID", SqlDbType.Int, 4).Direction = ParameterDirection.Output;
                        objCmd.Parameters.AddWithValue("@ItemID", entITM_ItemWiseRawMaterial.ItemID);
                        objCmd.Parameters.AddWithValue("@RawMaterialID", entITM_ItemWiseRawMaterial.RawMaterialID);
                        objCmd.Parameters.AddWithValue("@RawMaterialQuantity", entITM_ItemWiseRawMaterial.RawMaterialQuantity);
                        objCmd.Parameters.AddWithValue("@Description", entITM_ItemWiseRawMaterial.Description);
                        objCmd.Parameters.AddWithValue("@CreateDateTime", entITM_ItemWiseRawMaterial.CreateDateTime);
                        objCmd.Parameters.AddWithValue("@CreateBy", entITM_ItemWiseRawMaterial.CreateBy);
                        objCmd.Parameters.AddWithValue("@CreateIP", entITM_ItemWiseRawMaterial.CreateIP);
                        objCmd.Parameters.AddWithValue("@UpdateDateTime", entITM_ItemWiseRawMaterial.UpdateDateTime);
                        objCmd.Parameters.AddWithValue("@UpdateBy", entITM_ItemWiseRawMaterial.UpdateBy);
                        objCmd.Parameters.AddWithValue("@UpdateIP", entITM_ItemWiseRawMaterial.UpdateIP);
                        #endregion Prepare Command

                        objCmd.ExecuteNonQuery();
                        entITM_ItemWiseRawMaterial.ItemWiseRawMaterialID = Convert.ToInt32(objCmd.Parameters["@ItemWiseRawMaterialID"].Value);

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

        public Boolean Update(ITM_ItemWiseRawMaterialENT entITM_ItemWiseRawMaterial)
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
                        objCmd.CommandText = "SP_ITM_ItemWiseRawMaterial_Update";

                        objCmd.Parameters.AddWithValue("@ItemWiseRawMaterialID", entITM_ItemWiseRawMaterial.ItemWiseRawMaterialID);
                        objCmd.Parameters.AddWithValue("@ItemID", entITM_ItemWiseRawMaterial.ItemID);
                        objCmd.Parameters.AddWithValue("@RawMaterialID", entITM_ItemWiseRawMaterial.RawMaterialID);
                        objCmd.Parameters.AddWithValue("@RawMaterialQuantity", entITM_ItemWiseRawMaterial.RawMaterialQuantity);
                        objCmd.Parameters.AddWithValue("@Description", entITM_ItemWiseRawMaterial.Description);
                        objCmd.Parameters.AddWithValue("@CreateDateTime", entITM_ItemWiseRawMaterial.CreateDateTime);
                        objCmd.Parameters.AddWithValue("@CreateBy", entITM_ItemWiseRawMaterial.CreateBy);
                        objCmd.Parameters.AddWithValue("@CreateIP", entITM_ItemWiseRawMaterial.CreateIP);
                        objCmd.Parameters.AddWithValue("@UpdateDateTime", entITM_ItemWiseRawMaterial.UpdateDateTime);
                        objCmd.Parameters.AddWithValue("@UpdateBy", entITM_ItemWiseRawMaterial.UpdateBy);
                        objCmd.Parameters.AddWithValue("@UpdateIP", entITM_ItemWiseRawMaterial.UpdateIP);

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

        public Boolean Delete(SqlInt32 ItemWiseRawMaterialID)
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
                        objCmd.CommandText = "SP_ITM_ItemWiseRawMaterial_Delete";
                        
                        objCmd.Parameters.AddWithValue("@ItemWiseRawMaterialID", ItemWiseRawMaterialID);            
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
                        objCmd.CommandText = "SP_ITM_ItemWiseRawMaterial_Select";

                        
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
        public ITM_ItemWiseRawMaterialENT SelectPK(SqlInt32 ItemWiseRawMaterialID)
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
                        ITM_ItemWiseRawMaterialENT entITM_ItemWiseRawMaterial = new ITM_ItemWiseRawMaterialENT();
                        #endregion Variables

                        #region Prepare Command
                        objCmd.CommandType = CommandType.StoredProcedure;
                        objCmd.CommandText = "SP_ITM_ItemWiseRawMaterial_SelectPK";
                        objCmd.Parameters.AddWithValue("@ItemWiseRawMaterialID", ItemWiseRawMaterialID);
                        #endregion Prepare Command

                        #region Set Controls
                        using (SqlDataReader objSDR = objCmd.ExecuteReader())
                        {
							dt.Load(objSDR);
                        }
						foreach (DataRow dr in dt.Rows)
						{
							if (!dr["ItemWiseRawMaterialID"].Equals(DBNull.Value))
                            {
                                entITM_ItemWiseRawMaterial.ItemWiseRawMaterialID = Convert.ToInt32(dr["ItemWiseRawMaterialID"]);
                            }

                            if (!dr["ItemID"].Equals(DBNull.Value))
                            {
                                entITM_ItemWiseRawMaterial.ItemID = Convert.ToInt32(dr["ItemID"]);
                            }

                            if (!dr["RawMaterialID"].Equals(DBNull.Value))
                            {
                                entITM_ItemWiseRawMaterial.RawMaterialID = Convert.ToInt32(dr["RawMaterialID"]);
                            }

                            if (!dr["RawMaterialQuantity"].Equals(DBNull.Value))
                            {
                                entITM_ItemWiseRawMaterial.RawMaterialQuantity = Convert.ToInt32(dr["RawMaterialQuantity"]);
                            }

                            if (!dr["Description"].Equals(DBNull.Value))
                            {
                                entITM_ItemWiseRawMaterial.Description = Convert.ToString(dr["Description"]);
                            }

                            if (!dr["CreateDateTime"].Equals(DBNull.Value))
                            {
                                entITM_ItemWiseRawMaterial.CreateDateTime = Convert.ToDateTime(dr["CreateDateTime"]);
                            }

                            if (!dr["CreateBy"].Equals(DBNull.Value))
                            {
                                entITM_ItemWiseRawMaterial.CreateBy = Convert.ToInt32(dr["CreateBy"]);
                            }

                            if (!dr["CreateIP"].Equals(DBNull.Value))
                            {
                                entITM_ItemWiseRawMaterial.CreateIP = Convert.ToString(dr["CreateIP"]);
                            }

                            if (!dr["UpdateDateTime"].Equals(DBNull.Value))
                            {
                                entITM_ItemWiseRawMaterial.UpdateDateTime = Convert.ToDateTime(dr["UpdateDateTime"]);
                            }

                            if (!dr["UpdateBy"].Equals(DBNull.Value))
                            {
                                entITM_ItemWiseRawMaterial.UpdateBy = Convert.ToInt32(dr["UpdateBy"]);
                            }

                            if (!dr["UpdateIP"].Equals(DBNull.Value))
                            {
                                entITM_ItemWiseRawMaterial.UpdateIP = Convert.ToString(dr["UpdateIP"]);
                            }
						}
						return entITM_ItemWiseRawMaterial;

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
                        objCmd.CommandText = "SP_ITM_ItemWiseRawMaterial_SelectForDropDown";
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
