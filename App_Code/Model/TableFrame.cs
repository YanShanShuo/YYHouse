using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model
{
    /// <summary>
    /// 表结构
    /// </summary>
    public class TableFrame
    {
        private string _TableName;
        //表名
        public string TableName
        {
            get { return _TableName; }
            set { _TableName = value; }
        }
        /// <summary>
        /// 列
        /// </summary>
        public List<ColumnFrame> column = new List<ColumnFrame>();

    }
    /// <summary>
    /// 列结构
    /// </summary>
    public class ColumnFrame
    {
        public ColumnFrame()
        {
        }

        public ColumnFrame(string columnName, DataType datetype)
        {
            this.ColumnName = columnName;
            this.DataType = datetype;
            this.Condition = "";
        }

        public ColumnFrame(string columnName, DataType dataType, string condition)
        {
            this.ColumnName = columnName;
            this.DataType = dataType;
            this.Condition = condition;
        }

        private string _ColumnName;
        /// <summary>
        /// 列名
        /// </summary>
        public string ColumnName
        {
            get { return _ColumnName; }
            set { _ColumnName = value; }
        }

        private DataType _DataType;
        /// <summary>
        /// 类型
        /// </summary>
        public DataType DataType
        {
            get { return _DataType; }
            set { _DataType = value; }
        }

        private string _Condition;
        /// <summary>
        /// 条件
        /// </summary>
        public string Condition
        {
            get { return _Condition; }
            set { _Condition = value; }
        }


    }
    /// <summary>
    /// 数据类型
    /// </summary>
    public enum DataType : int
    {
        /// <summary>
        /// 整数
        /// </summary>
        INTEGER = 2,
        /// <summary>
        /// 浮点
        /// </summary>
        REAL = 3,
        /// <summary>
        /// 文本
        /// </summary>
        TEXT = 4,
        /// <summary>
        /// 日期
        /// </summary>
        DATATIME = 5,
        /// <summary>
        /// 二进制
        /// </summary>
        BLOB = 6,
    }
}

