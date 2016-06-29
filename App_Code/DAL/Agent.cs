using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Web;

namespace DAL
{
    /// <summary>
    /// 数据访问类:Agent
    /// </summary>
    public partial class Agent
    {
        public Agent()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQLite.GetMaxID("ID", "Agent");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Agent");
            strSql.Append(" where ID=@ID ");
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@ID", DbType.Int32,8)          };
            parameters[0].Value = ID;

            return DbHelperSQLite.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Model.Agent model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Agent(");
            strSql.Append("ID,TrueName,Phone,Words,ComID,Account,PassWord,QQ,WeChat,Xiaoqu)");
            strSql.Append(" values (");
            strSql.Append("@ID,@TrueName,@Phone,@Words,@ComID,@Account,@PassWord,@QQ,@WeChat,@Xiaoqu)");
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@ID", DbType.Int32,8),
                    new SQLiteParameter("@TrueName", DbType.String),
                    new SQLiteParameter("@Phone", DbType.String),
                    new SQLiteParameter("@Words", DbType.String),
                    new SQLiteParameter("@ComID", DbType.Int32,8),
                    new SQLiteParameter("@Account", DbType.String),
                    new SQLiteParameter("@PassWord", DbType.String),
                    new SQLiteParameter("@QQ", DbType.String),
                    new SQLiteParameter("@WeChat", DbType.String),
                    new SQLiteParameter("@Xiaoqu", DbType.String)};
            parameters[0].Value = model.ID;
            parameters[1].Value = model.TrueName;
            parameters[2].Value = model.Phone;
            parameters[3].Value = model.Words;
            parameters[4].Value = model.ComID;
            parameters[5].Value = model.Account;
            parameters[6].Value = model.PassWord;
            parameters[7].Value = model.QQ;
            parameters[8].Value = model.WeChat;
            parameters[9].Value = model.Xiaoqu;

            int rows = DbHelperSQLite.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.Agent model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Agent set ");
            strSql.Append("TrueName=@TrueName,");
            strSql.Append("Phone=@Phone,");
            strSql.Append("Words=@Words,");
            strSql.Append("ComID=@ComID,");
            strSql.Append("Account=@Account,");
            strSql.Append("PassWord=@PassWord,");
            strSql.Append("QQ=@QQ,");
            strSql.Append("WeChat=@WeChat,");
            strSql.Append("Xiaoqu=@Xiaoqu");
            strSql.Append(" where ID=@ID ");
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@TrueName", DbType.String),
                    new SQLiteParameter("@Phone", DbType.String),
                    new SQLiteParameter("@Words", DbType.String),
                    new SQLiteParameter("@ComID", DbType.Int32,8),
                    new SQLiteParameter("@Account", DbType.String),
                    new SQLiteParameter("@PassWord", DbType.String),
                    new SQLiteParameter("@QQ", DbType.String),
                    new SQLiteParameter("@WeChat", DbType.String),
                    new SQLiteParameter("@Xiaoqu", DbType.String),
                    new SQLiteParameter("@ID", DbType.Int32,8)};
            parameters[0].Value = model.TrueName;
            parameters[1].Value = model.Phone;
            parameters[2].Value = model.Words;
            parameters[3].Value = model.ComID;
            parameters[4].Value = model.Account;
            parameters[5].Value = model.PassWord;
            parameters[6].Value = model.QQ;
            parameters[7].Value = model.WeChat;
            parameters[8].Value = model.Xiaoqu;
            parameters[9].Value = model.ID;

            int rows = DbHelperSQLite.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Agent ");
            strSql.Append(" where ID=@ID ");
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@ID", DbType.Int32,8)          };
            parameters[0].Value = ID;

            int rows = DbHelperSQLite.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Agent ");
            strSql.Append(" where ID in (" + IDlist + ")  ");
            int rows = DbHelperSQLite.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.Agent GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,TrueName,Phone,Words,ComID,Account,PassWord,QQ,WeChat,Xiaoqu from Agent ");
            strSql.Append(" where ID=@ID ");
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@ID", DbType.Int32,8)          };
            parameters[0].Value = ID;

            Model.Agent model = new Model.Agent();
            DataSet ds = DbHelperSQLite.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.Agent DataRowToModel(DataRow row)
        {
            Model.Agent model = new Model.Agent();
            if (row != null)
            {
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = int.Parse(row["ID"].ToString());
                }
                if (row["TrueName"] != null)
                {
                    model.TrueName = row["TrueName"].ToString();
                }
                if (row["Phone"] != null)
                {
                    model.Phone = row["Phone"].ToString();
                }
                if (row["Words"] != null)
                {
                    model.Words = row["Words"].ToString();
                }
                if (row["ComID"] != null && row["ComID"].ToString() != "")
                {
                    model.ComID = int.Parse(row["ComID"].ToString());
                }
                if (row["Account"] != null)
                {
                    model.Account = row["Account"].ToString();
                }
                if (row["PassWord"] != null)
                {
                    model.PassWord = row["PassWord"].ToString();
                }
                if (row["QQ"] != null)
                {
                    model.QQ = row["QQ"].ToString();
                }
                if (row["WeChat"] != null)
                {
                    model.WeChat = row["WeChat"].ToString();
                }
                if (row["Xiaoqu"] != null)
                {
                    model.Xiaoqu = row["Xiaoqu"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,TrueName,Phone,Words,ComID,Account,PassWord,QQ,WeChat,Xiaoqu ");
            strSql.Append(" FROM Agent ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQLite.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM Agent ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQLite.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.ID desc");
            }
            strSql.Append(")AS Row, T.*  from Agent T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQLite.Query(strSql.ToString());
        }

        #endregion  BasicMethod
        #region  ExtensionMethod
        /// <summary>
        /// 分页获取数据
        /// </summary>
        /// <param name="where">条件</param>
        /// <param name="orderby">排序</param>
        /// <param name="pageIndex">显示第几页</param>
        /// <param name="pageSize">页面条数</param>
        /// <param name="RowCount">返回条数</param>
        /// <param name="PageCount">返回页数</param>
        /// <returns></returns>
        public DataTable GetListByPage(string where, string orderby, int pageIndex, int pageSize, ref int RowCount, ref int PageCount)
        {
            int startIndex = (pageIndex - 1) * pageSize + 1;
            int endIndex = pageIndex * pageSize;
            RowCount = GetRecordCount(where);
            if (RowCount == 0)
            {
                PageCount = 1;
                return new DataTable();
            }
            PageCount = (RowCount - 1) / pageSize + 1;
            return GetListByPage(where, orderby, startIndex, endIndex).Tables[0];
        }
        #endregion  ExtensionMethod
    }
}
