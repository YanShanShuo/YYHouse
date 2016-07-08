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
    /// 数据访问类:House
    /// </summary>
    public partial class House
    {
        public House()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQLite.GetMaxID("ID", "House");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from House");
            strSql.Append(" where ID=@ID ");
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@ID", DbType.Int32,8)          };
            parameters[0].Value = ID;

            return DbHelperSQLite.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Model.House model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into House(");
            strSql.Append("ID,Type,JingPin,Qu,XiaoQu,Ceng,ZongCeng,Shi,Ting,Wei,MianJi,ZhuangXiu,Jianyu,JiaGe,JiaGeDanwei,Chaoxiang,Chanquan,JieGou,ZhuJiMa,FyHao,DengJiTime,JJR,JJRPhone,Title,Detail)");
            strSql.Append(" values (");
            strSql.Append("@ID,@Type,@JingPin,@Qu,@XiaoQu,@Ceng,@ZongCeng,@Shi,@Ting,@Wei,@MianJi,@ZhuangXiu,@Jianyu,@JiaGe,@JiaGeDanwei,@Chaoxiang,@Chanquan,@JieGou,@ZhuJiMa,@FyHao,@DengJiTime,@JJR,@JJRPhone,@Title,@Detail)");
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@ID", DbType.Int32,8),
                    new SQLiteParameter("@Type", DbType.String),
                    new SQLiteParameter("@JingPin", DbType.String),
                    new SQLiteParameter("@Qu", DbType.String),
                    new SQLiteParameter("@XiaoQu", DbType.String),
                    new SQLiteParameter("@Ceng", DbType.String),
                    new SQLiteParameter("@ZongCeng", DbType.String),
                    new SQLiteParameter("@Shi", DbType.String),
                    new SQLiteParameter("@Ting", DbType.String),
                    new SQLiteParameter("@Wei", DbType.String),
                    new SQLiteParameter("@MianJi", DbType.String),
                    new SQLiteParameter("@ZhuangXiu", DbType.String),
                    new SQLiteParameter("@Jianyu", DbType.String),
                    new SQLiteParameter("@JiaGe", DbType.String),
                    new SQLiteParameter("@JiaGeDanwei", DbType.String),
                    new SQLiteParameter("@Chaoxiang", DbType.String),
                    new SQLiteParameter("@Chanquan", DbType.String),
                    new SQLiteParameter("@JieGou", DbType.String),
                    new SQLiteParameter("@ZhuJiMa", DbType.String),
                    new SQLiteParameter("@FyHao", DbType.String),
                    new SQLiteParameter("@DengJiTime", DbType.String),
                    new SQLiteParameter("@JJR", DbType.String),
                    new SQLiteParameter("@JJRPhone", DbType.String),
                    new SQLiteParameter("@Title", DbType.String),
                    new SQLiteParameter("@Detail", DbType.String)};
            parameters[0].Value = model.ID;
            parameters[1].Value = model.Type;
            parameters[2].Value = model.JingPin;
            parameters[3].Value = model.Qu;
            parameters[4].Value = model.XiaoQu;
            parameters[5].Value = model.Ceng;
            parameters[6].Value = model.ZongCeng;
            parameters[7].Value = model.Shi;
            parameters[8].Value = model.Ting;
            parameters[9].Value = model.Wei;
            parameters[10].Value = model.MianJi;
            parameters[11].Value = model.ZhuangXiu;
            parameters[12].Value = model.Jianyu;
            parameters[13].Value = model.JiaGe;
            parameters[14].Value = model.JiaGeDanwei;
            parameters[15].Value = model.Chaoxiang;
            parameters[16].Value = model.Chanquan;
            parameters[17].Value = model.JieGou;
            parameters[18].Value = model.ZhuJiMa;
            parameters[19].Value = model.FyHao;
            parameters[20].Value = model.DengJiTime;
            parameters[21].Value = model.JJR;
            parameters[22].Value = model.JJRPhone;
            parameters[23].Value = model.Title;
            parameters[24].Value = model.Detail;

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
        public bool Update(Model.House model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update House set ");
            strSql.Append("Type=@Type,");
            strSql.Append("JingPin=@JingPin,");
            strSql.Append("Qu=@Qu,");
            strSql.Append("XiaoQu=@XiaoQu,");
            strSql.Append("Ceng=@Ceng,");
            strSql.Append("ZongCeng=@ZongCeng,");
            strSql.Append("Shi=@Shi,");
            strSql.Append("Ting=@Ting,");
            strSql.Append("Wei=@Wei,");
            strSql.Append("MianJi=@MianJi,");
            strSql.Append("ZhuangXiu=@ZhuangXiu,");
            strSql.Append("Jianyu=@Jianyu,");
            strSql.Append("JiaGe=@JiaGe,");
            strSql.Append("JiaGeDanwei=@JiaGeDanwei,");
            strSql.Append("Chaoxiang=@Chaoxiang,");
            strSql.Append("Chanquan=@Chanquan,");
            strSql.Append("JieGou=@JieGou,");
            strSql.Append("ZhuJiMa=@ZhuJiMa,");
            strSql.Append("FyHao=@FyHao,");
            strSql.Append("DengJiTime=@DengJiTime,");
            strSql.Append("JJR=@JJR,");
            strSql.Append("JJRPhone=@JJRPhone,");
            strSql.Append("Title=@Title,");
            strSql.Append("Detail=@Detail");
            strSql.Append(" where ID=@ID ");
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@Type", DbType.String),
                    new SQLiteParameter("@JingPin", DbType.String),
                    new SQLiteParameter("@Qu", DbType.String),
                    new SQLiteParameter("@XiaoQu", DbType.String),
                    new SQLiteParameter("@Ceng", DbType.String),
                    new SQLiteParameter("@ZongCeng", DbType.String),
                    new SQLiteParameter("@Shi", DbType.String),
                    new SQLiteParameter("@Ting", DbType.String),
                    new SQLiteParameter("@Wei", DbType.String),
                    new SQLiteParameter("@MianJi", DbType.String),
                    new SQLiteParameter("@ZhuangXiu", DbType.String),
                    new SQLiteParameter("@Jianyu", DbType.String),
                    new SQLiteParameter("@JiaGe", DbType.String),
                    new SQLiteParameter("@JiaGeDanwei", DbType.String),
                    new SQLiteParameter("@Chaoxiang", DbType.String),
                    new SQLiteParameter("@Chanquan", DbType.String),
                    new SQLiteParameter("@JieGou", DbType.String),
                    new SQLiteParameter("@ZhuJiMa", DbType.String),
                    new SQLiteParameter("@FyHao", DbType.String),
                    new SQLiteParameter("@DengJiTime", DbType.String),
                    new SQLiteParameter("@JJR", DbType.String),
                    new SQLiteParameter("@JJRPhone", DbType.String),
                    new SQLiteParameter("@Title", DbType.String),
                    new SQLiteParameter("@Detail", DbType.String),
                    new SQLiteParameter("@ID", DbType.Int32,8)};
            parameters[0].Value = model.Type;
            parameters[1].Value = model.JingPin;
            parameters[2].Value = model.Qu;
            parameters[3].Value = model.XiaoQu;
            parameters[4].Value = model.Ceng;
            parameters[5].Value = model.ZongCeng;
            parameters[6].Value = model.Shi;
            parameters[7].Value = model.Ting;
            parameters[8].Value = model.Wei;
            parameters[9].Value = model.MianJi;
            parameters[10].Value = model.ZhuangXiu;
            parameters[11].Value = model.Jianyu;
            parameters[12].Value = model.JiaGe;
            parameters[13].Value = model.JiaGeDanwei;
            parameters[14].Value = model.Chaoxiang;
            parameters[15].Value = model.Chanquan;
            parameters[16].Value = model.JieGou;
            parameters[17].Value = model.ZhuJiMa;
            parameters[18].Value = model.FyHao;
            parameters[19].Value = model.DengJiTime;
            parameters[20].Value = model.JJR;
            parameters[21].Value = model.JJRPhone;
            parameters[22].Value = model.Title;
            parameters[23].Value = model.Detail;
            parameters[24].Value = model.ID;

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
            strSql.Append("delete from House ");
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
            strSql.Append("delete from House ");
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
        public Model.House GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,Type,JingPin,Qu,XiaoQu,Ceng,ZongCeng,Shi,Ting,Wei,MianJi,ZhuangXiu,Jianyu,JiaGe,JiaGeDanwei,Chaoxiang,Chanquan,JieGou,ZhuJiMa,FyHao,DengJiTime,JJR,JJRPhone,Title,Detail from House ");
            strSql.Append(" where ID=@ID ");
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@ID", DbType.Int32,8)          };
            parameters[0].Value = ID;

            Model.House model = new Model.House();
            DataSet ds = DbHelperSQLite.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return new Model.House().DefaultHouse();
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.House DataRowToModel(DataRow row)
        {
            Model.House model = new Model.House();
            if (row != null)
            {
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = int.Parse(row["ID"].ToString());
                }
                if (row["Type"] != null)
                {
                    model.Type = row["Type"].ToString();
                }
                if (row["JingPin"] != null)
                {
                    model.JingPin = row["JingPin"].ToString();
                }
                if (row["Qu"] != null)
                {
                    model.Qu = row["Qu"].ToString();
                }
                if (row["XiaoQu"] != null)
                {
                    model.XiaoQu = row["XiaoQu"].ToString();
                }
                if (row["Ceng"] != null)
                {
                    model.Ceng = row["Ceng"].ToString();
                }
                if (row["ZongCeng"] != null)
                {
                    model.ZongCeng = row["ZongCeng"].ToString();
                }
                if (row["Shi"] != null)
                {
                    model.Shi = row["Shi"].ToString();
                }
                if (row["Ting"] != null)
                {
                    model.Ting = row["Ting"].ToString();
                }
                if (row["Wei"] != null)
                {
                    model.Wei = row["Wei"].ToString();
                }
                if (row["MianJi"] != null)
                {
                    model.MianJi = row["MianJi"].ToString();
                }
                if (row["ZhuangXiu"] != null)
                {
                    model.ZhuangXiu = row["ZhuangXiu"].ToString();
                }
                if (row["Jianyu"] != null)
                {
                    model.Jianyu = row["Jianyu"].ToString();
                }
                if (row["JiaGe"] != null)
                {
                    model.JiaGe = row["JiaGe"].ToString();
                }
                if (row["JiaGeDanwei"] != null)
                {
                    model.JiaGeDanwei = row["JiaGeDanwei"].ToString();
                }
                if (row["Chaoxiang"] != null)
                {
                    model.Chaoxiang = row["Chaoxiang"].ToString();
                }
                if (row["Chanquan"] != null)
                {
                    model.Chanquan = row["Chanquan"].ToString();
                }
                if (row["JieGou"] != null)
                {
                    model.JieGou = row["JieGou"].ToString();
                }
                if (row["ZhuJiMa"] != null)
                {
                    model.ZhuJiMa = row["ZhuJiMa"].ToString();
                }
                if (row["FyHao"] != null)
                {
                    model.FyHao = row["FyHao"].ToString();
                }
                if (row["DengJiTime"] != null)
                {
                    model.DengJiTime = row["DengJiTime"].ToString();
                }
                if (row["JJR"] != null)
                {
                    model.JJR = row["JJR"].ToString();
                }
                if (row["JJRPhone"] != null)
                {
                    model.JJRPhone = row["JJRPhone"].ToString();
                }
                if (row["Title"] != null)
                {
                    model.Title = row["Title"].ToString();
                }
                if (row["Detail"] != null)
                {
                    model.Detail = row["Detail"].ToString();
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
            strSql.Append(" FROM House ");
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
            strSql.Append("select count(1) FROM House ");
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
            strSql.Append("Select * from House");
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
        /// 获取实体
        /// </summary>
        /// <param name="index">从第几个获取，从0开始</param>
        /// <param name="num">获取几个</param>
        /// <param name="where">条件</param>
        /// <returns></returns>
        public Model.House GetModel(int index, int num, string where)
        {
            //string sql = "select * from House where type='Sale' and JingPin='精品' LIMIT 0,1";

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from House");
            if (where != "")
                strSql.Append(" where " + where + " ORDER BY id desc ");
            else
                strSql.Append(" ORDER BY id desc ");
            strSql.Append(" LIMIT @index,@num");
            SQLiteParameter[] parameters = {
                new SQLiteParameter("@index",DbType.Int32),
                new SQLiteParameter("@num",DbType.Int32)
            };
            parameters[0].Value = index;
            parameters[1].Value = num;
            Model.House model = new Model.House();
            DataSet ds = DbHelperSQLite.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return new Model.House().DefaultHouse();
            }
        }

        /// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Model.House> GetModelList(string strWhere)
        {
            DataSet ds = GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Model.House> DataTableToList(DataTable dt)
        {
            List<Model.House> modelList = new List<Model.House>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Model.House model;
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
        public List<Model.House> GetModelListByPage(string where, string orderby, int pageIndex, int pageSize, ref int RowCount, ref int PageCount)
        {
            DataTable ds = GetListByPage(where, orderby, pageIndex, pageSize, ref RowCount, ref PageCount);
            return DataTableToList(ds);
        }
        #endregion  ExtensionMethod
    }
}