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
	/// 数据访问类:Article
	/// </summary>
	public partial class Article
    {
        public Article()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Article");
            strSql.Append(" where ID=@ID");
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@ID", DbType.Int32,4)
            };
            parameters[0].Value = ID;

            return DbHelperSQLite.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.Article model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Article(");
            strSql.Append("Title,Detail,Summary,Author,SubmitTime,UpdateTime,Type,Click,Order)");
            strSql.Append(" values (");
            strSql.Append("@Title,@Detail,@Summary,@Author,@SubmitTime,@UpdateTime,@Type,@Click,@Order)");
            strSql.Append(";select LAST_INSERT_ROWID()");
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@Title", DbType.String),
                    new SQLiteParameter("@Detail", DbType.String),
                    new SQLiteParameter("@Summary", DbType.String),
                    new SQLiteParameter("@Author", DbType.String),
                    new SQLiteParameter("@SubmitTime", DbType.String),
                    new SQLiteParameter("@UpdateTime", DbType.String),
                    new SQLiteParameter("@Type", DbType.String),
                    new SQLiteParameter("@Click", DbType.String),
                    new SQLiteParameter("@Order", DbType.Int32,8)};
            parameters[0].Value = model.Title;
            parameters[1].Value = model.Detail;
            parameters[2].Value = model.Summary;
            parameters[3].Value = model.Author;
            parameters[4].Value = model.SubmitTime;
            parameters[5].Value = model.UpdateTime;
            parameters[6].Value = model.Type;
            parameters[7].Value = model.Click;
            parameters[8].Value = model.Order;

            object obj = DbHelperSQLite.GetSingle(strSql.ToString(), parameters);
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
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.Article model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Article set ");
            strSql.Append("Title=@Title,");
            strSql.Append("Detail=@Detail,");
            strSql.Append("Summary=@Summary,");
            strSql.Append("Author=@Author,");
            strSql.Append("SubmitTime=@SubmitTime,");
            strSql.Append("UpdateTime=@UpdateTime,");
            strSql.Append("Type=@Type,");
            strSql.Append("Click=@Click,");
            strSql.Append("Order=@Order");
            strSql.Append(" where ID=@ID");
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@Title", DbType.String),
                    new SQLiteParameter("@Detail", DbType.String),
                    new SQLiteParameter("@Summary", DbType.String),
                    new SQLiteParameter("@Author", DbType.String),
                    new SQLiteParameter("@SubmitTime", DbType.String),
                    new SQLiteParameter("@UpdateTime", DbType.String),
                    new SQLiteParameter("@Type", DbType.String),
                    new SQLiteParameter("@Click", DbType.String),
                    new SQLiteParameter("@Order", DbType.Int32,8),
                    new SQLiteParameter("@ID", DbType.Int32,8)};
            parameters[0].Value = model.Title;
            parameters[1].Value = model.Detail;
            parameters[2].Value = model.Summary;
            parameters[3].Value = model.Author;
            parameters[4].Value = model.SubmitTime;
            parameters[5].Value = model.UpdateTime;
            parameters[6].Value = model.Type;
            parameters[7].Value = model.Click;
            parameters[8].Value = model.Order;
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
            strSql.Append("delete from Article ");
            strSql.Append(" where ID=@ID");
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@ID", DbType.Int32,4)
            };
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
            strSql.Append("delete from Article ");
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
        public Model.Article GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from Article ");
            strSql.Append(" where ID=@ID");
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@ID", DbType.Int32,4)
            };
            parameters[0].Value = ID;

            Model.Article model = new Model.Article();
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
        public Model.Article DataRowToModel(DataRow row)
        {
            Model.Article model = new Model.Article();
            if (row != null)
            {
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = int.Parse(row["ID"].ToString());
                }
                if (row["Title"] != null)
                {
                    model.Title = row["Title"].ToString();
                }
                if (row["Detail"] != null)
                {
                    model.Detail = row["Detail"].ToString();
                }
                if (row["Summary"] != null)
                {
                    model.Summary = row["Summary"].ToString();
                }
                if (row["Author"] != null)
                {
                    model.Author = row["Author"].ToString();
                }
                if (row["SubmitTime"] != null)
                {
                    model.SubmitTime = row["SubmitTime"].ToString();
                }
                if (row["UpdateTime"] != null)
                {
                    model.UpdateTime = row["UpdateTime"].ToString();
                }
                if (row["Type"] != null)
                {
                    model.Type = row["Type"].ToString();
                }
                if (row["Click"] != null)
                {
                    model.Click = row["Click"].ToString();
                }
                if (row["Order"] != null && row["Order"].ToString() != "")
                {
                    model.Order = int.Parse(row["Order"].ToString());
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
            strSql.Append("select * ");
            strSql.Append(" FROM Article ");
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
            strSql.Append("select count(1) FROM Article ");
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
            strSql.Append(")AS Row, T.*  from Article T ");
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

        /// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Model.Article> GetModelList(string strWhere)
        {
            DataSet ds = GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Model.Article> DataTableToList(DataTable dt)
        {
            List<Model.Article> modelList = new List<Model.Article>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Model.Article model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = DataRowToModel(dt.Rows[n]);
                    if (model != null)
                    {
                        modelList.Add(model);
                    }
                }
            }
            return modelList;
        }

        #endregion  ExtensionMethod
    }
}
