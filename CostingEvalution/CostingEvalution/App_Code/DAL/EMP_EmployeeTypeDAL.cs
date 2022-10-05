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
/// Summary description for EMP_EmployeeTypeDAL
/// </summary>
/// 
namespace CostingEvalution.App_Code.DAL
{
    public class EMP_EmployeeTypeDAL : DatabaseConfig
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
        public EMP_EmployeeTypeDAL()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        #endregion Constructor
    
        #region Insert Operation

        public Boolean Insert(EMP_EmployeeTypeENT entEMP_EmployeeType)
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
                        objCmd.CommandText = "SP_EMP_EmployeeType_Insert";
                        
                        objCmd.Parameters.Add("@EmployeeTypeID", SqlDbType.Int, 4).Direction = ParameterDirection.Output;
                        objCmd.Parameters.AddWithValue("@EmployeeTypeName", entEMP_EmployeeType.EmployeeTypeName);
                        objCmd.Parameters.AddWithValue("@IsEmployeeTypeForHourAndNos", entEMP_EmployeeType.IsEmployeeTypeForHourAndNos);
                        objCmd.Parameters.AddWithValue("@Description", entEMP_EmployeeType.Description);
                        objCmd.Parameters.AddWithValue("@CreateDateTime", entEMP_EmployeeType.CreateDateTime);
                        objCmd.Parameters.AddWithValue("@CreateBy", entEMP_EmployeeType.CreateBy);
                        objCmd.Parameters.AddWithValue("@CreateIP", entEMP_EmployeeType.CreateIP);
                        objCmd.Parameters.AddWithValue("@UpdateDateTime", entEMP_EmployeeType.UpdateDateTime);
                        objCmd.Parameters.AddWithValue("@UpdateBy", entEMP_EmployeeType.UpdateBy);
                        objCmd.Parameters.AddWithValue("@UpdateIP", entEMP_EmployeeType.UpdateIP);
                        #endregion Prepare Command

                        objCmd.ExecuteNonQuery();
                        entEMP_EmployeeType.EmployeeTypeID = Convert.ToInt32(objCmd.Parameters["@EmployeeTypeID"].Value);

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

        public Boolean Update(EMP_EmployeeTypeENT entEMP_EmployeeType)
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
                        objCmd.CommandText = "SP_EMP_EmployeeType_Update";

                        objCmd.Parameters.AddWithValue("@EmployeeTypeID", entEMP_EmployeeType.EmployeeTypeID);
                        objCmd.Parameters.AddWithValue("@EmployeeTypeName", entEMP_EmployeeType.EmployeeTypeName);
                        objCmd.Parameters.AddWithValue("@IsEmployeeTypeForHourAndNos", entEMP_EmployeeType.IsEmployeeTypeForHourAndNos);
                        objCmd.Parameters.AddWithValue("@Description", entEMP_EmployeeType.Description);
                        objCmd.Parameters.AddWithValue("@CreateDateTime", entEMP_EmployeeType.CreateDateTime);
                        objCmd.Parameters.AddWithValue("@CreateBy", entEMP_EmployeeType.CreateBy);
                        objCmd.Parameters.AddWithValue("@CreateIP", entEMP_EmployeeType.CreateIP);
                        objCmd.Parameters.AddWithValue("@UpdateDateTime", entEMP_EmployeeType.UpdateDateTime);
                        objCmd.Parameters.AddWithValue("@UpdateBy", entEMP_EmployeeType.UpdateBy);
                        objCmd.Parameters.AddWithValue("@UpdateIP", entEMP_EmployeeType.UpdateIP);

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

        public Boolean Delete(SqlInt32 EmployeeTypeID)
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
                        objCmd.CommandText = "SP_EMP_EmployeeType_Delete";
                        
                        objCmd.Parameters.AddWithValue("@EmployeeTypeID", EmployeeTypeID);            
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
                        objCmd.CommandText = "SP_EMP_EmployeeType_Select";

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
        public EMP_EmployeeTypeENT SelectPK(SqlInt32 EmployeeTypeID)
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
                        EMP_EmployeeTypeENT entEMP_EmployeeType = new EMP_EmployeeTypeENT();
                        #endregion Variables

                        #region Prepare Command
                        objCmd.CommandType = CommandType.StoredProcedure;
                        objCmd.CommandText = "SP_EMP_EmployeeType_SelectPK";
                        objCmd.Parameters.AddWithValue("@EmployeeTypeID", EmployeeTypeID);
                        #endregion Prepare Command

                        #region Set Controls
                        using (SqlDataReader objSDR = objCmd.ExecuteReader())
                        {
							dt.Load(objSDR);
                        }
						foreach (DataRow dr in dt.Rows)
						{
							if (!dr["EmployeeTypeID"].Equals(DBNull.Value))
                            {
                                entEMP_EmployeeType.EmployeeTypeID = Convert.ToInt32(dr["EmployeeTypeID"]);
                            }

                            if (!dr["EmployeeTypeName"].Equals(DBNull.Value))
                            {
                                entEMP_EmployeeType.EmployeeTypeName = Convert.ToString(dr["EmployeeTypeName"]);
                            }

                            if (!dr["IsEmployeeTypeForHourAndNos"].Equals(DBNull.Value))
                            {
                                entEMP_EmployeeType.IsEmployeeTypeForHourAndNos = Convert.ToBoolean(dr["IsEmployeeTypeForHourAndNos"]);
                            }

                            if (!dr["Description"].Equals(DBNull.Value))
                            {
                                entEMP_EmployeeType.Description = Convert.ToString(dr["Description"]);
                            }

                            if (!dr["CreateDateTime"].Equals(DBNull.Value))
                            {
                                entEMP_EmployeeType.CreateDateTime = Convert.ToDateTime(dr["CreateDateTime"]);
                            }

                            if (!dr["CreateBy"].Equals(DBNull.Value))
                            {
                                entEMP_EmployeeType.CreateBy = Convert.ToInt32(dr["CreateBy"]);
                            }

                            if (!dr["CreateIP"].Equals(DBNull.Value))
                            {
                                entEMP_EmployeeType.CreateIP = Convert.ToString(dr["CreateIP"]);
                            }

                            if (!dr["UpdateDateTime"].Equals(DBNull.Value))
                            {
                                entEMP_EmployeeType.UpdateDateTime = Convert.ToDateTime(dr["UpdateDateTime"]);
                            }

                            if (!dr["UpdateBy"].Equals(DBNull.Value))
                            {
                                entEMP_EmployeeType.UpdateBy = Convert.ToInt32(dr["UpdateBy"]);
                            }

                            if (!dr["UpdateIP"].Equals(DBNull.Value))
                            {
                                entEMP_EmployeeType.UpdateIP = Convert.ToString(dr["UpdateIP"]);
                            }
						}
						return entEMP_EmployeeType;

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
                        objCmd.CommandText = "SP_EMP_EmployeeType_SelectForDropDown";
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
