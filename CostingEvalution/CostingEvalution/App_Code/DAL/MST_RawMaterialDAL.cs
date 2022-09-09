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
/// Summary description for MST_RawMaterialDAL
/// </summary>
/// 
namespace CostingEvalution.App_Code.DAL
{
    public class MST_RawMaterialDAL : DatabaseConfig
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
        public MST_RawMaterialDAL()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        #endregion Constructor
    
        #region Insert Operation

        public Boolean Insert(MST_RawMaterialENT entMST_RawMaterial)
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
                        objCmd.CommandText = "SP_MST_RawMaterial_Insert";
                        
                        objCmd.Parameters.AddWithValue("@RawMaterialName", entMST_RawMaterial.RawMaterialName);
                        objCmd.Parameters.AddWithValue("@UnitID", entMST_RawMaterial.UnitID);
                        objCmd.Parameters.AddWithValue("@RawMaterialPrice",entMST_RawMaterial.RawMaterialPrice);
                        objCmd.Parameters.AddWithValue("@Description", entMST_RawMaterial.Description);
                        objCmd.Parameters.AddWithValue("@CreateDateTime", entMST_RawMaterial.CreateDateTime);
                        objCmd.Parameters.AddWithValue("@CreateBy", entMST_RawMaterial.CreateBy);
                        objCmd.Parameters.AddWithValue("@CreateIP", entMST_RawMaterial.CreateIP);
                        objCmd.Parameters.AddWithValue("@UpdateDateTime", entMST_RawMaterial.UpdateDateTime);
                        objCmd.Parameters.AddWithValue("@UpdateBy", entMST_RawMaterial.UpdateBy);
                        objCmd.Parameters.AddWithValue("@UpdateIP", entMST_RawMaterial.UpdateIP);
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

        public Boolean Update(MST_RawMaterialENT entMST_RawMaterial)
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
                        objCmd.CommandText = "SP_MST_RawMaterial_Update";

                        objCmd.Parameters.AddWithValue("@RawMaterialID", entMST_RawMaterial.RawMaterialID);
                        objCmd.Parameters.AddWithValue("@RawMaterialName", entMST_RawMaterial.RawMaterialName);
                        objCmd.Parameters.AddWithValue("@UnitID", entMST_RawMaterial.UnitID);
                        objCmd.Parameters.AddWithValue("@RawMaterialPrice", entMST_RawMaterial.RawMaterialPrice);
                        objCmd.Parameters.AddWithValue("@Description", entMST_RawMaterial.Description);
                        objCmd.Parameters.AddWithValue("@CreateDateTime", entMST_RawMaterial.CreateDateTime);
                        objCmd.Parameters.AddWithValue("@CreateBy", entMST_RawMaterial.CreateBy);
                        objCmd.Parameters.AddWithValue("@CreateIP", entMST_RawMaterial.CreateIP);
                        objCmd.Parameters.AddWithValue("@UpdateDateTime", entMST_RawMaterial.UpdateDateTime);
                        objCmd.Parameters.AddWithValue("@UpdateBy", entMST_RawMaterial.UpdateBy);
                        objCmd.Parameters.AddWithValue("@UpdateIP", entMST_RawMaterial.UpdateIP);

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

        public Boolean Delete(SqlInt32 RawMaterialID)
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
                        objCmd.CommandText = "SP_MST_RawMaterial_Delete";
                        
                        objCmd.Parameters.AddWithValue("@RawMaterialID", RawMaterialID);            
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
                        objCmd.CommandText = "SP_MST_RawMaterial_Select";

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
        public MST_RawMaterialENT SelectPK(SqlInt32 RawMaterialID)
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
                        MST_RawMaterialENT entMST_RawMaterial = new MST_RawMaterialENT();
                        #endregion Variables

                        #region Prepare Command
                        objCmd.CommandType = CommandType.StoredProcedure;
                        objCmd.CommandText = "SP_MST_RawMaterial_SelectPK";
                        objCmd.Parameters.AddWithValue("@RawMaterialID", RawMaterialID);
                        #endregion Prepare Command

                        #region Set Controls
                        using (SqlDataReader objSDR = objCmd.ExecuteReader())
                        {
							dt.Load(objSDR);
                        }
						foreach (DataRow dr in dt.Rows)
						{
							if (!dr["RawMaterialID"].Equals(DBNull.Value))
                            {
                                entMST_RawMaterial.RawMaterialID = Convert.ToInt32(dr["RawMaterialID"]);
                            }

                            if (!dr["RawMaterialName"].Equals(DBNull.Value))
                            {
                                entMST_RawMaterial.RawMaterialName = Convert.ToString(dr["RawMaterialName"]);
                            }

                            if (!dr["UnitID"].Equals(DBNull.Value))
                            {
                                entMST_RawMaterial.UnitID = Convert.ToInt32(dr["UnitID"]);
                            }

                            if (!dr["RawMaterialPrice"].Equals(DBNull.Value))
                            {
                                entMST_RawMaterial.RawMaterialPrice = Convert.ToDecimal(dr["RawMaterialPrice"]);
                            }

                            if (!dr["Description"].Equals(DBNull.Value))
                            {
                                entMST_RawMaterial.Description = Convert.ToString(dr["Description"]);
                            }

                            if (!dr["CreateDateTime"].Equals(DBNull.Value))
                            {
                                entMST_RawMaterial.CreateDateTime = Convert.ToDateTime(dr["CreateDateTime"]);
                            }

                            if (!dr["CreateBy"].Equals(DBNull.Value))
                            {
                                entMST_RawMaterial.CreateBy = Convert.ToInt32(dr["CreateBy"]);
                            }

                            if (!dr["CreateIP"].Equals(DBNull.Value))
                            {
                                entMST_RawMaterial.CreateIP = Convert.ToString(dr["CreateIP"]);
                            }

                            if (!dr["UpdateDateTime"].Equals(DBNull.Value))
                            {
                                entMST_RawMaterial.UpdateDateTime = Convert.ToDateTime(dr["UpdateDateTime"]);
                            }

                            if (!dr["UpdateBy"].Equals(DBNull.Value))
                            {
                                entMST_RawMaterial.UpdateBy = Convert.ToInt32(dr["UpdateBy"]);
                            }

                            if (!dr["UpdateIP"].Equals(DBNull.Value))
                            {
                                entMST_RawMaterial.UpdateIP = Convert.ToString(dr["UpdateIP"]);
                            }
						}
						return entMST_RawMaterial;

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
                        objCmd.CommandText = "SP_MST_RawMaterial_SelectForDropDown";
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
