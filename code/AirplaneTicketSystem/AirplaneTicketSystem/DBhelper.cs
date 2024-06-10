using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace AirplaneTicketSystem
{
    public class DBhelper
    {
        //新增 刪除 修改 查詢
        private static string connStr = "server=desktop-b6vuuvm\\sqlexpress;uid=Maple;pwd=0921823854;database=AirplaneTicketSystemDB";
        /// <summary>
        /// 新增 刪除 修改 通用腳本
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sql, params SqlParameter[] paras)//參數
        {
            SqlConnection conn = new SqlConnection(connStr);//如果使用using可以不用conn.close
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddRange(paras);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            cmd.Parameters.Clear();
            return result;
        }
        /// <summary>
        /// 查詢第一行第一列
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string sql, params SqlParameter[] paras)//參數
        {
            object obj = null;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddRange(paras);
                obj = cmd.ExecuteScalar();
                cmd.Parameters.Clear();
            }
            return obj;
        }
        /// <summary>
        /// 查詢多行多列
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(string sql, params SqlParameter[] paras)//參數
        {
            //SqlDataReader需要連接狀態下使用 所以無法使用using
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddRange(paras);
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return reader;
        }
        public static DataTable GetDataTable(string sql, params SqlParameter[] paras)
        {
            //不需要保持連接 所以不用open and close
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                cmd.Parameters.Clear();
            }
            return dt;
        }
    }
}
