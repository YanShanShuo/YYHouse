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
	/// 数据访问类:Company
	/// </summary>
	public partial class Company
    {
        public Company()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQLite.GetMaxID("ID", "Company");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Company");
            strSql.Append(" where ID=@ID ");
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@ID", DbType.Int32,8)          };
            parameters[0].Value = ID;

            return DbHelperSQLite.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Model.Company model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Company(");
            strSql.Append("ID,Name,Address,Phone,OpenTime,Summary)");
            strSql.Append(" values (");
            strSql.Append("@ID,@Name,@Address,@Phone,@OpenTime,@Summary)");
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@ID", DbType.Int32,8),
                    new SQLiteParameter("@Name", DbType.String),
                    new SQLiteParameter("@Address", DbType.String),
                    new SQLiteParameter("@Phone", DbType.String),
                    new SQLiteParameter("@OpenTime", DbType.String),
                    new SQLiteParameter("@Summary", DbType.String)};
            parameters[0].Value = model.ID;
            parameters[1].Value = model.Name;
            parameters[2].Value = model.Address;
            parameters[3].Value = model.Phone;
            parameters[4].Value = model.OpenTime;
            parameters[5].Value = model.Summary;

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
        public bool Update(Model.Company model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Company set ");
            strSql.Append("Name=@Name,");
            strSql.Append("Address=@Address,");
            strSql.Append("Phone=@Phone,");
            strSql.Append("OpenTime=@OpenTime,");
            strSql.Append("Summary=@Summary");
            strSql.Append(" where ID=@ID ");
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@Name", DbType.String),
                    new SQLiteParameter("@Address", DbType.String),
                    new SQLiteParameter("@Phone", DbType.String),
                    new SQLiteParameter("@OpenTime", DbType.String),
                    new SQLiteParameter("@Summary", DbType.String),
                    new SQLiteParameter("@ID", DbType.Int32,8)};
            parameters[0].Value = model.Name;
            parameters[1].Value = model.Address;
            parameters[2].Value = model.Phone;
            parameters[3].Value = model.OpenTime;
            parameters[4].Value = model.Summary;
            parameters[5].Value = model.ID;

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
            strSql.Append("delete from Company ");
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
            strSql.Append("delete from Company ");
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
        public Model.Company GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,Name,Address,Phone,OpenTime,Summary from Company ");
            strSql.Append(" where ID=@ID ");
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@ID", DbType.Int32,8)          };
            parameters[0].Value = ID;

            Model.Company model = new Model.Company();
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
        public Model.Company DataRowToModel(DataRow row)
        {
            Model.Company model = new Model.Company();
            if (row != null)
            {
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = int.Parse(row["ID"].ToString());
                }
                if (row["Name"] != null)
                {
                    model.Name = row["Name"].ToString();
                }
                if (row["Address"] != null)
                {
                    model.Address = row["Address"].ToString();
                }
                if (row["Phone"] != null)
                {
                    model.Phone = row["Phone"].ToString();
                }
                if (row["OpenTime"] != null)
                {
                    model.OpenTime = row["OpenTime"].ToString();
                }
                if (row["Summary"] != null)
                {
                    model.Summary = row["Summary"].ToString();
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
            strSql.Append("select ID,Name,Address,Phone,OpenTime,Summary ");
            strSql.Append(" FROM Company ");
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
            strSql.Append("select count(1) FROM Company ");
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
            strSql.Append(")AS Row, T.*  from Company T ");
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
