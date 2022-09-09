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
/// Summary description for PRD_QuestionDAL
/// </summary>
/// 
namespace CostingEvalution.App_Code.DAL
{
    public class PRD_QuestionDAL : DatabaseConfig
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
        public PRD_QuestionDAL()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        #endregion Constructor
    
        #region Insert Operation

        public Boolean Insert(PRD_QuestionENT entPRD_Question)
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
                        objCmd.CommandText = "SP_PRD_Question_Insert";
                        
                       
                        objCmd.Parameters.AddWithValue("@QuestionName", entPRD_Question.QuestionName);
                        objCmd.Parameters.AddWithValue("@ItemTypeID", entPRD_Question.ItemTypeID);
                        objCmd.Parameters.AddWithValue("@Description", entPRD_Question.Description);
                        objCmd.Parameters.AddWithValue("@CreateDateTime", entPRD_Question.CreateDateTime);
                        objCmd.Parameters.AddWithValue("@CreateBy", entPRD_Question.CreateBy);
                        objCmd.Parameters.AddWithValue("@CreateIP", entPRD_Question.CreateIP);
                        objCmd.Parameters.AddWithValue("@UpdateDateTime", entPRD_Question.UpdateDateTime);
                        objCmd.Parameters.AddWithValue("@UpdateBy", entPRD_Question.UpdateBy);
                        objCmd.Parameters.AddWithValue("@UpdateIP", entPRD_Question.UpdateIP);
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

        public Boolean Update(PRD_QuestionENT entPRD_Question)
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
                        objCmd.CommandText = "SP_PRD_Question_Update";

                        objCmd.Parameters.AddWithValue("@QuestionID", entPRD_Question.QuestionID);
                        objCmd.Parameters.AddWithValue("@QuestionName", entPRD_Question.QuestionName);
                        objCmd.Parameters.AddWithValue("@ItemTypeID", entPRD_Question.ItemTypeID);
                        objCmd.Parameters.AddWithValue("@Description", entPRD_Question.Description);
                        objCmd.Parameters.AddWithValue("@CreateDateTime", entPRD_Question.CreateDateTime);
                        objCmd.Parameters.AddWithValue("@CreateBy", entPRD_Question.CreateBy);
                        objCmd.Parameters.AddWithValue("@CreateIP", entPRD_Question.CreateIP);
                        objCmd.Parameters.AddWithValue("@UpdateDateTime", entPRD_Question.UpdateDateTime);
                        objCmd.Parameters.AddWithValue("@UpdateBy", entPRD_Question.UpdateBy);
                        objCmd.Parameters.AddWithValue("@UpdateIP", entPRD_Question.UpdateIP);

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

        public Boolean Delete(SqlInt32 QuestionID)
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
                        objCmd.CommandText = "SP_PRD_Question_Delete";
                        
                        objCmd.Parameters.AddWithValue("@QuestionID", QuestionID);            
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
                        objCmd.CommandText = "SP_PRD_Question_Select";

                       
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
        public PRD_QuestionENT SelectPK(SqlInt32 QuestionID)
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
                        PRD_QuestionENT entPRD_Question = new PRD_QuestionENT();
                        #endregion Variables

                        #region Prepare Command
                        objCmd.CommandType = CommandType.StoredProcedure;
                        objCmd.CommandText = "SP_PRD_Question_SelectPK";
                        objCmd.Parameters.AddWithValue("@QuestionID", QuestionID);
                        #endregion Prepare Command

                        #region Set Controls
                        using (SqlDataReader objSDR = objCmd.ExecuteReader())
                        {
							dt.Load(objSDR);
                        }
						foreach (DataRow dr in dt.Rows)
						{
							if (!dr["QuestionID"].Equals(DBNull.Value))
                            {
                                entPRD_Question.QuestionID = Convert.ToInt32(dr["QuestionID"]);
                            }

                            if (!dr["QuestionName"].Equals(DBNull.Value))
                            {
                                entPRD_Question.QuestionName = Convert.ToString(dr["QuestionName"]);
                            }

                            if (!dr["ItemTypeID"].Equals(DBNull.Value))
                            {
                                entPRD_Question.ItemTypeID = Convert.ToInt32(dr["ItemTypeID"]);
                            }

                            if (!dr["Description"].Equals(DBNull.Value))
                            {
                                entPRD_Question.Description = Convert.ToString(dr["Description"]);
                            }

                            if (!dr["CreateDateTime"].Equals(DBNull.Value))
                            {
                                entPRD_Question.CreateDateTime = Convert.ToDateTime(dr["CreateDateTime"]);
                            }

                            if (!dr["CreateBy"].Equals(DBNull.Value))
                            {
                                entPRD_Question.CreateBy = Convert.ToInt32(dr["CreateBy"]);
                            }

                            if (!dr["CreateIP"].Equals(DBNull.Value))
                            {
                                entPRD_Question.CreateIP = Convert.ToString(dr["CreateIP"]);
                            }

                            if (!dr["UpdateDateTime"].Equals(DBNull.Value))
                            {
                                entPRD_Question.UpdateDateTime = Convert.ToDateTime(dr["UpdateDateTime"]);
                            }

                            if (!dr["UpdateBy"].Equals(DBNull.Value))
                            {
                                entPRD_Question.UpdateBy = Convert.ToInt32(dr["UpdateBy"]);
                            }

                            if (!dr["UpdateIP"].Equals(DBNull.Value))
                            {
                                entPRD_Question.UpdateIP = Convert.ToString(dr["UpdateIP"]);
                            }
						}
						return entPRD_Question;

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
                        objCmd.CommandText = "SP_PRD_Question_SelectForDropDown";
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
