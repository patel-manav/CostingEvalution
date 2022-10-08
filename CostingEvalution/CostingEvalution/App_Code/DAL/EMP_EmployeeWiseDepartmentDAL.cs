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
/// Summary description for EMP_EmployeeWiseDepartmentDAL
/// </summary>
/// 
namespace CostingEvalution.App_Code.DAL
{
    public class EMP_EmployeeWiseDepartmentDAL : DatabaseConfig
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
        public EMP_EmployeeWiseDepartmentDAL()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        #endregion Constructor
    
        #region Insert Operation

        public Boolean Insert(EMP_EmployeeWiseDepartmentENT entEMP_EmployeeWiseDepartment)
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
                        objCmd.CommandText = "SP_EMP_EmployeeWiseDepartment_Insert";
                        
                        objCmd.Parameters.Add("@EmployeeWiseDepartmentID", SqlDbType.Int, 4).Direction = ParameterDirection.Output;
                        objCmd.Parameters.AddWithValue("@EmployeeID", entEMP_EmployeeWiseDepartment.EmployeeID);
                        objCmd.Parameters.AddWithValue("@DepartmentID", entEMP_EmployeeWiseDepartment.DepartmentID);
                        objCmd.Parameters.AddWithValue("@CreateDateTime", entEMP_EmployeeWiseDepartment.CreateDateTime);
                        objCmd.Parameters.AddWithValue("@CreateBy", entEMP_EmployeeWiseDepartment.CreateBy);
                        objCmd.Parameters.AddWithValue("@CreateIP", entEMP_EmployeeWiseDepartment.CreateIP);
                        objCmd.Parameters.AddWithValue("@UpdateDateTime", entEMP_EmployeeWiseDepartment.UpdateDateTime);
                        objCmd.Parameters.AddWithValue("@UpdateBy", entEMP_EmployeeWiseDepartment.UpdateBy);
                        objCmd.Parameters.AddWithValue("@UpdateIP", entEMP_EmployeeWiseDepartment.UpdateIP);
                        #endregion Prepare Command

                        objCmd.ExecuteNonQuery();
                        entEMP_EmployeeWiseDepartment.EmployeeWiseDepartmentID = Convert.ToInt32(objCmd.Parameters["@EmployeeWiseDepartmentID"].Value);

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

        public Boolean Update(EMP_EmployeeWiseDepartmentENT entEMP_EmployeeWiseDepartment)
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
                        objCmd.CommandText = "SP_EMP_EmployeeWiseDepartment_Update";

                        objCmd.Parameters.AddWithValue("@EmployeeWiseDepartmentID", entEMP_EmployeeWiseDepartment.EmployeeWiseDepartmentID);
                        objCmd.Parameters.AddWithValue("@EmployeeID", entEMP_EmployeeWiseDepartment.EmployeeID);
                        objCmd.Parameters.AddWithValue("@DepartmentID", entEMP_EmployeeWiseDepartment.DepartmentID);
                        objCmd.Parameters.AddWithValue("@CreateDateTime", entEMP_EmployeeWiseDepartment.CreateDateTime);
                        objCmd.Parameters.AddWithValue("@CreateBy", entEMP_EmployeeWiseDepartment.CreateBy);
                        objCmd.Parameters.AddWithValue("@CreateIP", entEMP_EmployeeWiseDepartment.CreateIP);
                        objCmd.Parameters.AddWithValue("@UpdateDateTime", entEMP_EmployeeWiseDepartment.UpdateDateTime);
                        objCmd.Parameters.AddWithValue("@UpdateBy", entEMP_EmployeeWiseDepartment.UpdateBy);
                        objCmd.Parameters.AddWithValue("@UpdateIP", entEMP_EmployeeWiseDepartment.UpdateIP);

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

        public Boolean Delete(SqlInt32 EmployeeID)
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
                        objCmd.CommandText = "SP_EMP_EmployeeWiseDepartment_Delete";
                        
                        objCmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);            
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
                        objCmd.CommandText = "SP_EMP_EmployeeWiseDepartment_Select";

                        
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
        public EMP_EmployeeWiseDepartmentENT SelectPK(SqlInt32 EmployeeWiseDepartmentID)
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
                        EMP_EmployeeWiseDepartmentENT entEMP_EmployeeWiseDepartment = new EMP_EmployeeWiseDepartmentENT();
                        #endregion Variables

                        #region Prepare Command
                        objCmd.CommandType = CommandType.StoredProcedure;
                        objCmd.CommandText = "SP_EMP_EmployeeWiseDepartment_SelectPK";
                        objCmd.Parameters.AddWithValue("@EmployeeWiseDepartmentID", EmployeeWiseDepartmentID);
                        #endregion Prepare Command

                        #region Set Controls
                        using (SqlDataReader objSDR = objCmd.ExecuteReader())
                        {
							dt.Load(objSDR);
                        }
						foreach (DataRow dr in dt.Rows)
						{
							if (!dr["EmployeeWiseDepartmentID"].Equals(DBNull.Value))
                            {
                                entEMP_EmployeeWiseDepartment.EmployeeWiseDepartmentID = Convert.ToInt32(dr["EmployeeWiseDepartmentID"]);
                            }

                            if (!dr["EmployeeID"].Equals(DBNull.Value))
                            {
                                entEMP_EmployeeWiseDepartment.EmployeeID = Convert.ToInt32(dr["EmployeeID"]);
                            }

                            if (!dr["DepartmentID"].Equals(DBNull.Value))
                            {
                                entEMP_EmployeeWiseDepartment.DepartmentID = Convert.ToInt32(dr["DepartmentID"]);
                            }

                            if (!dr["CreateDateTime"].Equals(DBNull.Value))
                            {
                                entEMP_EmployeeWiseDepartment.CreateDateTime = Convert.ToDateTime(dr["CreateDateTime"]);
                            }

                            if (!dr["CreateBy"].Equals(DBNull.Value))
                            {
                                entEMP_EmployeeWiseDepartment.CreateBy = Convert.ToInt32(dr["CreateBy"]);
                            }

                            if (!dr["CreateIP"].Equals(DBNull.Value))
                            {
                                entEMP_EmployeeWiseDepartment.CreateIP = Convert.ToString(dr["CreateIP"]);
                            }

                            if (!dr["UpdateDateTime"].Equals(DBNull.Value))
                            {
                                entEMP_EmployeeWiseDepartment.UpdateDateTime = Convert.ToDateTime(dr["UpdateDateTime"]);
                            }

                            if (!dr["UpdateBy"].Equals(DBNull.Value))
                            {
                                entEMP_EmployeeWiseDepartment.UpdateBy = Convert.ToInt32(dr["UpdateBy"]);
                            }

                            if (!dr["UpdateIP"].Equals(DBNull.Value))
                            {
                                entEMP_EmployeeWiseDepartment.UpdateIP = Convert.ToString(dr["UpdateIP"]);
                            }
						}
						return entEMP_EmployeeWiseDepartment;

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
                        objCmd.CommandText = "SP_EMP_EmployeeWiseDepartment_SelectForDropDown";
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

        #region Select By Employee
        public DataTable SelectByEmployeeId(SqlInt32 EmployeeID)
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
                        objCmd.CommandText = "SP_EMP_EmployeeWiseDepartment_SelectByEmployeeId";
                        objCmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);

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
        #endregion Select By Employee

        #endregion Select Operation
    }
}
