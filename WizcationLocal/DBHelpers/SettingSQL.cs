using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Wizcation.DBHelpers;

namespace WizcationLocal.DBHelpers
{
    public interface ISettingSQL
    {
        DataTable ListAgentType();
        DataTable ListAgentDepartment(int agentypeID);

        string InsertAgentType(string AgentName);

    }
    public class SettingSQL: ISettingSQL
    {

        string errMsg = "";

        private int GetMaxID(string tableName,string ColumnName) {


            SqlConnection ObjConn = DBHelper.ConnectDb(ref errMsg);
            string StrSQL = "\r\n  select Case when Max("+ ColumnName + ") IS NULL then 0 else Max(" + ColumnName + ")+1 end As MaxID From " + tableName ;
            DataTable dt = DBHelper.List(StrSQL, ObjConn);
            int MaxID = Convert.ToInt32(dt.Rows[0]["MaxID"].ToString());
            ObjConn.Close();
            return MaxID;
        }
        #region Agent Type
        // Show agent type
        public DataTable ListAgentType()
        {

            SqlConnection ObjConn = DBHelper.ConnectDb(ref errMsg);
            string StrSQL = "\r\n  select * From agent_type where Deleted = 0";
            DataTable dt = DBHelper.List(StrSQL, ObjConn);
            ObjConn.Close();
            return dt;
        }
        public string InsertAgentType(string AgentName)
        {

            SqlConnection ObjConn = DBHelper.ConnectDb(ref errMsg);
            string result = "";
            try
            {
                string StrSQL = "\r\n  insert into agent_type(AgentTypeID,AgentTypeName)values({0},'{1}'); ";
                int id = GetMaxID("agent_type", "AgentTypeID");
                string strFmt = String.Format(StrSQL, id, AgentName);
                DBHelper.Execute(strFmt, ObjConn);

            }
            catch (Exception e)
            {
                result = e.Message;

            }
            ObjConn.Close();
            return result;
        }

        #endregion
        // agentypeID= 0:ShowAll  || agentypeID >0  : Show where AgentTypeID
        public DataTable ListAgentDepartment(int agentypeID)
        {

            SqlConnection ObjConn = DBHelper.ConnectDb(ref errMsg);
            string StrSQL = "\r\n  select * From agent_department where Deleted=0";
            if (agentypeID > 0) {

                StrSQL += " and AgentTypeID="+ agentypeID;
            }
            DataTable dt = DBHelper.List(StrSQL, ObjConn);
            ObjConn.Close();
            return dt;
        }

        }
    }