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
    /// 数据访问类:Admin
    /// </summary>
    public partial class Admin
    {
        
        public Admin()
        {
            
        }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQLite.GetMaxID("ID", "Admin");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Admin");
            strSql.Append(" where ID=@ID ");
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@ID", DbType.Int32,8)          };
            parameters[0].Value = ID;

            return DbHelperSQLite.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Model.Admin model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Admin(");
            strSql.Append("ID,LoginName,Password,Power,NickName)");
            strSql.Append(" values (");
            strSql.Append("@ID,@LoginName,@Password,@Power,@NickName)");
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@ID", DbType.Int32,8),
                    new SQLiteParameter("@LoginName", DbType.String),
                    new SQLiteParameter("@Password", DbType.String),
                    new SQLiteParameter("@Power", DbType.String),
                    new SQLiteParameter("@NickName", DbType.String)};
            parameters[0].Value = model.ID;
            parameters[1].Value = model.LoginName;
            parameters[2].Value = model.Password;
            parameters[3].Value = model.Power;
            parameters[4].Value = model.NickName;

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
        public bool Update(Model.Admin model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Admin set ");
            strSql.Append("LoginName=@LoginName,");
            strSql.Append("Password=@Password,");
            strSql.Append("Power=@Power,");
            strSql.Append("NickName=@NickName");
            strSql.Append(" where ID=@ID ");
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@LoginName", DbType.String),
                    new SQLiteParameter("@Password", DbType.String),
                    new SQLiteParameter("@Power", DbType.String),
                    new SQLiteParameter("@NickName", DbType.String),
                    new SQLiteParameter("@ID", DbType.Int32,8)};
            parameters[0].Value = model.LoginName;
            parameters[1].Value = model.Password;
            parameters[2].Value = model.Power;
            parameters[3].Value = model.NickName;
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
            strSql.Append("delete from Admin ");
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
            strSql.Append("delete from Admin ");
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
        public Model.Admin GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,LoginName,Password,Power,NickName from Admin ");
            strSql.Append(" where ID=@ID ");
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@ID", DbType.Int32,8)          };
            parameters[0].Value = ID;

            Model.Admin model = new Model.Admin();
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
        public Model.Admin DataRowToModel(DataRow row)
        {
            Model.Admin model = new Model.Admin();
            if (row != null)
            {
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = int.Parse(row["ID"].ToString());
                }
                if (row["LoginName"] != null)
                {
                    model.LoginName = row["LoginName"].ToString();
                }
                if (row["Password"] != null)
                {
                    model.Password = row["Password"].ToString();
                }
                if (row["Power"] != null)
                {
                    model.Power = row["Power"].ToString();
                }
                if (row["NickName"] != null)
                {
                    model.NickName = row["NickName"].ToString();
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
            strSql.Append("select ID,LoginName,Password,Power,NickName ");
            strSql.Append(" FROM Admin ");
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
            strSql.Append("select count(1) FROM Admin ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DAL.DbHelperSQLite.GetSingle(strSql.ToString());
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
            strSql.Append("Select * from Admin");
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
            return DbHelperSQLite.Query(strSql.ToString(), parameters);
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
		public List<Model.Admin> GetModelList(string strWhere)
        {
            DataSet ds = GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Model.Admin> DataTableToList(DataTable dt)
        {
            List<Model.Admin> modelList = new List<Model.Admin>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Model.Admin model;
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
        public List<Model.Admin> GetModelListByPage(string where, string orderby, int pageIndex, int pageSize, ref int RowCount, ref int PageCount)
        {
            DataTable ds = GetListByPage(where, orderby, pageIndex, pageSize, ref RowCount, ref PageCount);
            return DataTableToList(ds);
        }

        /// <summary>
        /// 得到实体对象
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public Model.Admin GetModel(string where)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from Admin ");
            if (where != "") strSql.Append(" where " + where);
            Model.Admin model = new Model.Admin();
            DataSet ds = DbHelperSQLite.Query(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }
        #endregion  ExtensionMethod
    }
}
