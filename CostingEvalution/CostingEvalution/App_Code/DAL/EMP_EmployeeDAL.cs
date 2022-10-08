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
/// Summary description for EMP_EmployeeDAL
/// </summary>
/// 
namespace CostingEvalution.App_Code.DAL
{
    public class EMP_EmployeeDAL : DatabaseConfig
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
        public EMP_EmployeeDAL()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        #endregion Constructor
    
        #region Insert Operation

        public Boolean Insert(EMP_EmployeeENT entEMP_Employee)
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
                        objCmd.CommandText = "SP_EMP_Employee_Insert";
                        
                        objCmd.Parameters.Add("@EmployeeID", SqlDbType.Int, 4).Direction = ParameterDirection.Output;
                        objCmd.Parameters.AddWithValue("@EmployeeName", entEMP_Employee.EmployeeName);
                        objCmd.Parameters.AddWithValue("@EmployeeTypeID", entEMP_Employee.EmployeeTypeID);
                        objCmd.Parameters.AddWithValue("@PricePerHour", entEMP_Employee.PricePerHour);
                        objCmd.Parameters.AddWithValue("@Description", entEMP_Employee.Description);
                        objCmd.Parameters.AddWithValue("@CreateDateTime", entEMP_Employee.CreateDateTime);
                        objCmd.Parameters.AddWithValue("@CreateBy", entEMP_Employee.CreateBy);
                        objCmd.Parameters.AddWithValue("@CreateIP", entEMP_Employee.CreateIP);
                        objCmd.Parameters.AddWithValue("@UpdateDateTime", entEMP_Employee.UpdateDateTime);
                        objCmd.Parameters.AddWithValue("@UpdateBy", entEMP_Employee.UpdateBy);
                        objCmd.Parameters.AddWithValue("@UpdateIP", entEMP_Employee.UpdateIP);
                        #endregion Prepare Command

                        objCmd.ExecuteNonQuery();
                        entEMP_Employee.EmployeeID = Convert.ToInt32(objCmd.Parameters["@EmployeeID"].Value);

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

        public Boolean Update(EMP_EmployeeENT entEMP_Employee)
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
                        objCmd.CommandText = "SP_EMP_Employee_Update";

                        objCmd.Parameters.AddWithValue("@EmployeeID", entEMP_Employee.EmployeeID);
                        objCmd.Parameters.AddWithValue("@EmployeeName", entEMP_Employee.EmployeeName);
                        objCmd.Parameters.AddWithValue("@EmployeeTypeID", entEMP_Employee.EmployeeTypeID);
                        objCmd.Parameters.AddWithValue("@PricePerHour", entEMP_Employee.PricePerHour);
                        objCmd.Parameters.AddWithValue("@Description", entEMP_Employee.Description);
                        objCmd.Parameters.AddWithValue("@CreateDateTime", entEMP_Employee.CreateDateTime);
                        objCmd.Parameters.AddWithValue("@CreateBy", entEMP_Employee.CreateBy);
                        objCmd.Parameters.AddWithValue("@CreateIP", entEMP_Employee.CreateIP);
                        objCmd.Parameters.AddWithValue("@UpdateDateTime", entEMP_Employee.UpdateDateTime);
                        objCmd.Parameters.AddWithValue("@UpdateBy", entEMP_Employee.UpdateBy);
                        objCmd.Parameters.AddWithValue("@UpdateIP", entEMP_Employee.UpdateIP);

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
                        objCmd.CommandText = "SP_EMP_Employee_Delete";
                        
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
                        objCmd.CommandText = "SP_EMP_Employee_Select";

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
        public EMP_EmployeeENT SelectPK(SqlInt32 EmployeeID)
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
                        EMP_EmployeeENT entEMP_Employee = new EMP_EmployeeENT();
                        #endregion Variables

                        #region Prepare Command
                        objCmd.CommandType = CommandType.StoredProcedure;
                        objCmd.CommandText = "SP_EMP_Employee_SelectPK";
                        objCmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                        #endregion Prepare Command

                        #region Set Controls
                        using (SqlDataReader objSDR = objCmd.ExecuteReader())
                        {
							dt.Load(objSDR);
                        }
						foreach (DataRow dr in dt.Rows)
						{
							if (!dr["EmployeeID"].Equals(DBNull.Value))
                            {
                                entEMP_Employee.EmployeeID = Convert.ToInt32(dr["EmployeeID"]);
                            }

                            if (!dr["EmployeeName"].Equals(DBNull.Value))
                            {
                                entEMP_Employee.EmployeeName = Convert.ToString(dr["EmployeeName"]);
                            }

                            if (!dr["EmployeeTypeID"].Equals(DBNull.Value))
                            {
                                entEMP_Employee.EmployeeTypeID = Convert.ToInt32(dr["EmployeeTypeID"]);
                            }

                            if (!dr["PricePerHour"].Equals(DBNull.Value))
                            {
                                entEMP_Employee.PricePerHour = Convert.ToInt32(dr["PricePerHour"]);
                            }

                            if (!dr["Description"].Equals(DBNull.Value))
                            {
                                entEMP_Employee.Description = Convert.ToString(dr["Description"]);
                            }

                            if (!dr["CreateDateTime"].Equals(DBNull.Value))
                            {
                                entEMP_Employee.CreateDateTime = Convert.ToDateTime(dr["CreateDateTime"]);
                            }

                            if (!dr["CreateBy"].Equals(DBNull.Value))
                            {
                                entEMP_Employee.CreateBy = Convert.ToInt32(dr["CreateBy"]);
                            }

                            if (!dr["CreateIP"].Equals(DBNull.Value))
                            {
                                entEMP_Employee.CreateIP = Convert.ToString(dr["CreateIP"]);
                            }

                            if (!dr["UpdateDateTime"].Equals(DBNull.Value))
                            {
                                entEMP_Employee.UpdateDateTime = Convert.ToDateTime(dr["UpdateDateTime"]);
                            }

                            if (!dr["UpdateBy"].Equals(DBNull.Value))
                            {
                                entEMP_Employee.UpdateBy = Convert.ToInt32(dr["UpdateBy"]);
                            }

                            if (!dr["UpdateIP"].Equals(DBNull.Value))
                            {
                                entEMP_Employee.UpdateIP = Convert.ToString(dr["UpdateIP"]);
                            }
						}
						return entEMP_Employee;

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
                        objCmd.CommandText = "SP_EMP_Employee_SelectForDropDown";
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
