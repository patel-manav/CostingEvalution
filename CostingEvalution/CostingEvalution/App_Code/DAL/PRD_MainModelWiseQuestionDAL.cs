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
/// Summary description for PRD_MainModelWiseQuestionDAL
/// </summary>
/// 
namespace CostingEvalution.App_Code.DAL
{
    public class PRD_MainModelWiseQuestionDAL : DatabaseConfig
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
        public PRD_MainModelWiseQuestionDAL()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        #endregion Constructor
    
        #region Insert Operation

        public Boolean Insert(PRD_MainModelWiseQuestionENT entPRD_MainModelWiseQuestion)
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
                        objCmd.CommandText = "SP_PRD_MainModelWiseQuestion_Insert";
                        
                        objCmd.Parameters.Add("@MainModelWiseQuestionID", SqlDbType.Int, 4).Direction = ParameterDirection.Output;
                        objCmd.Parameters.AddWithValue("@MainModelID", entPRD_MainModelWiseQuestion.MainModelID);
                        objCmd.Parameters.AddWithValue("@QuestionID", entPRD_MainModelWiseQuestion.QuestionID);
                        objCmd.Parameters.AddWithValue("@CreateDateTime", entPRD_MainModelWiseQuestion.CreateDateTime);
                        objCmd.Parameters.AddWithValue("@CreateBy", entPRD_MainModelWiseQuestion.CreateBy);
                        objCmd.Parameters.AddWithValue("@CreateIP", entPRD_MainModelWiseQuestion.CreateIP);
                        objCmd.Parameters.AddWithValue("@UpdateDateTime", entPRD_MainModelWiseQuestion.UpdateDateTime);
                        objCmd.Parameters.AddWithValue("@UpdateBy", entPRD_MainModelWiseQuestion.UpdateBy);
                        objCmd.Parameters.AddWithValue("@UpdateIP", entPRD_MainModelWiseQuestion.UpdateIP);
                        #endregion Prepare Command

                        objCmd.ExecuteNonQuery();
                        entPRD_MainModelWiseQuestion.MainModelWiseQuestionID = Convert.ToInt32(objCmd.Parameters["@MainModelWiseQuestionID"].Value);

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

        public Boolean Update(PRD_MainModelWiseQuestionENT entPRD_MainModelWiseQuestion)
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
                        objCmd.CommandText = "SP_PRD_MainModelWiseQuestion_Update";

                        objCmd.Parameters.AddWithValue("@MainModelWiseQuestionID", entPRD_MainModelWiseQuestion.MainModelWiseQuestionID);
                        objCmd.Parameters.AddWithValue("@MainModelID", entPRD_MainModelWiseQuestion.MainModelID);
                        objCmd.Parameters.AddWithValue("@QuestionID", entPRD_MainModelWiseQuestion.QuestionID);
                        objCmd.Parameters.AddWithValue("@CreateDateTime", entPRD_MainModelWiseQuestion.CreateDateTime);
                        objCmd.Parameters.AddWithValue("@CreateBy", entPRD_MainModelWiseQuestion.CreateBy);
                        objCmd.Parameters.AddWithValue("@CreateIP", entPRD_MainModelWiseQuestion.CreateIP);
                        objCmd.Parameters.AddWithValue("@UpdateDateTime", entPRD_MainModelWiseQuestion.UpdateDateTime);
                        objCmd.Parameters.AddWithValue("@UpdateBy", entPRD_MainModelWiseQuestion.UpdateBy);
                        objCmd.Parameters.AddWithValue("@UpdateIP", entPRD_MainModelWiseQuestion.UpdateIP);

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

        public Boolean Delete(SqlInt32 MainModelID)
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
                        objCmd.CommandText = "SP_PRD_MainModelWiseQuestion_Delete";
                        
                        objCmd.Parameters.AddWithValue("@MainModelID", MainModelID);            
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
                        objCmd.CommandText = "SP_PRD_MainModelWiseQuestion_Select";

                        
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
        public PRD_MainModelWiseQuestionENT SelectPK(SqlInt32 MainModelWiseQuestionID)
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
                        PRD_MainModelWiseQuestionENT entPRD_MainModelWiseQuestion = new PRD_MainModelWiseQuestionENT();
                        #endregion Variables

                        #region Prepare Command
                        objCmd.CommandType = CommandType.StoredProcedure;
                        objCmd.CommandText = "SP_PRD_MainModelWiseQuestion_SelectPK";
                        objCmd.Parameters.AddWithValue("@MainModelWiseQuestionID", MainModelWiseQuestionID);
                        #endregion Prepare Command

                        #region Set Controls
                        using (SqlDataReader objSDR = objCmd.ExecuteReader())
                        {
							dt.Load(objSDR);
                        }
						foreach (DataRow dr in dt.Rows)
						{
							if (!dr["MainModelWiseQuestionID"].Equals(DBNull.Value))
                            {
                                entPRD_MainModelWiseQuestion.MainModelWiseQuestionID = Convert.ToInt32(dr["MainModelWiseQuestionID"]);
                            }

                            if (!dr["MainModelID"].Equals(DBNull.Value))
                            {
                                entPRD_MainModelWiseQuestion.MainModelID = Convert.ToInt32(dr["MainModelID"]);
                            }

                            if (!dr["QuestionID"].Equals(DBNull.Value))
                            {
                                entPRD_MainModelWiseQuestion.QuestionID = Convert.ToInt32(dr["QuestionID"]);
                            }

                            if (!dr["CreateDateTime"].Equals(DBNull.Value))
                            {
                                entPRD_MainModelWiseQuestion.CreateDateTime = Convert.ToDateTime(dr["CreateDateTime"]);
                            }

                            if (!dr["CreateBy"].Equals(DBNull.Value))
                            {
                                entPRD_MainModelWiseQuestion.CreateBy = Convert.ToInt32(dr["CreateBy"]);
                            }

                            if (!dr["CreateIP"].Equals(DBNull.Value))
                            {
                                entPRD_MainModelWiseQuestion.CreateIP = Convert.ToString(dr["CreateIP"]);
                            }

                            if (!dr["UpdateDateTime"].Equals(DBNull.Value))
                            {
                                entPRD_MainModelWiseQuestion.UpdateDateTime = Convert.ToDateTime(dr["UpdateDateTime"]);
                            }

                            if (!dr["UpdateBy"].Equals(DBNull.Value))
                            {
                                entPRD_MainModelWiseQuestion.UpdateBy = Convert.ToInt32(dr["UpdateBy"]);
                            }

                            if (!dr["UpdateIP"].Equals(DBNull.Value))
                            {
                                entPRD_MainModelWiseQuestion.UpdateIP = Convert.ToString(dr["UpdateIP"]);
                            }
						}
						return entPRD_MainModelWiseQuestion;

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
                        objCmd.CommandText = "SP_PRD_MainModelWiseQuestion_SelectForDropDown";
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

        #region Select By Main Model
        public DataTable SelectByMainModelId(SqlInt32 MainModelID)
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
                        objCmd.CommandText = "SP_PRD_MainModelWiseQuestion_SelectByMainModelId";
                        objCmd.Parameters.AddWithValue("@MainModelID", MainModelID);

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
        #endregion Select By Main Model

        #endregion Select Operation
    }
}
