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
    /// 数据访问类:Branch
    /// </summary>
    public partial class Branch
    {
        public Branch()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Branch");
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
        public int Add(Model.Branch model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Branch(");
            strSql.Append("BranchName,BranchAddress,BranchPhone,BranchDetail)");
            strSql.Append(" values (");
            strSql.Append("@BranchName,@BranchAddress,@BranchPhone,@BranchDetail)");
            strSql.Append(";select LAST_INSERT_ROWID()");
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@BranchName", DbType.String),
                    new SQLiteParameter("@BranchAddress", DbType.String),
                    new SQLiteParameter("@BranchPhone", DbType.String),
                    new SQLiteParameter("@BranchDetail", DbType.String)};
            parameters[0].Value = model.BranchName;
            parameters[1].Value = model.BranchAddress;
            parameters[2].Value = model.BranchPhone;
            parameters[3].Value = model.BranchDetail;

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
        public bool Update(Model.Branch model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Branch set ");
            strSql.Append("BranchName=@BranchName,");
            strSql.Append("BranchAddress=@BranchAddress,");
            strSql.Append("BranchPhone=@BranchPhone,");
            strSql.Append("BranchDetail=@BranchDetail");
            strSql.Append(" where ID=@ID");
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@BranchName", DbType.String),
                    new SQLiteParameter("@BranchAddress", DbType.String),
                    new SQLiteParameter("@BranchPhone", DbType.String),
                    new SQLiteParameter("@BranchDetail", DbType.String),
                    new SQLiteParameter("@ID", DbType.Int32,8)};
            parameters[0].Value = model.BranchName;
            parameters[1].Value = model.BranchAddress;
            parameters[2].Value = model.BranchPhone;
            parameters[3].Value = model.BranchDetail;
            parameters[4].Value = model.ID;

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
            strSql.Append("delete from Branch ");
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
            strSql.Append("delete from Branch ");
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
        public Model.Branch GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,BranchName,BranchAddress,BranchPhone,BranchDetail from Branch ");
            strSql.Append(" where ID=@ID");
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@ID", DbType.Int32,4)
            };
            parameters[0].Value = ID;

            Model.Branch model = new Model.Branch();
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
        public Model.Branch DataRowToModel(DataRow row)
        {
            Model.Branch model = new Model.Branch();
            if (row != null)
            {
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = int.Parse(row["ID"].ToString());
                }
                if (row["BranchName"] != null)
                {
                    model.BranchName = row["BranchName"].ToString();
                }
                if (row["BranchAddress"] != null)
                {
                    model.BranchAddress = row["BranchAddress"].ToString();
                }
                if (row["BranchPhone"] != null)
                {
                    model.BranchPhone = row["BranchPhone"].ToString();
                }
                if (row["BranchDetail"] != null)
                {
                    model.BranchDetail = row["BranchDetail"].ToString();
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
            strSql.Append("select ID,BranchName,BranchAddress,BranchPhone,BranchDetail ");
            strSql.Append(" FROM Branch ");
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
            strSql.Append("select count(1) FROM Branch ");
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
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int count)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("Select * from Branch");
            if (strWhere != "")
                strSql.Append(" where " + strWhere);
            if (orderby != "")
                strSql.Append(" order by " + orderby);
            else
                strSql.Append(" order by id desc");
            strSql.Append(" Limit @index,@count");
            SQLiteParameter[] parameters = {
                new SQLiteParameter("@index",DbType.Int32),
                new SQLiteParameter("@count", DbType.Int32)
            };
            parameters[0].Value = startIndex;
            parameters[1].Value = count;
            return DbHelperSQLite.Query(strSql.ToString(),parameters);
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
            int startIndex = (pageIndex - 1) * pageSize;
            RowCount = GetRecordCount(where);
            if (RowCount == 0)
            {
                PageCount = 1;
                return new DataTable();
            }
            PageCount = (RowCount - 1) / pageSize + 1;
            return GetListByPage(where, orderby, startIndex, pageSize).Tables[0];
        }

        /// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Model.Branch> GetModelList(string strWhere)
        {
            DataSet ds = GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Model.Branch> DataTableToList(DataTable dt)
        {
            List<Model.Branch> modelList = new List<Model.Branch>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Model.Branch model;
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
        public List<Model.Branch> GetModelListByPage(string where, string orderby, int pageIndex, int pageSize, ref int RowCount, ref int PageCount)
        {
            DataTable ds = GetListByPage(where, orderby, pageIndex, pageSize, ref RowCount, ref PageCount);
            return DataTableToList(ds);
        }

        #endregion  ExtensionMethod
    }
}