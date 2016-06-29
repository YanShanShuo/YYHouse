using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Model
{
    /// <summary>
    /// Company:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Company
    {
        public Company()
        { }
        #region Model
        private int _id;
        private string _name;
        private string _address;
        private string _phone;
        private string _opentime;
        private string _summary;
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 公司名字
        /// </summary>
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }
        /// <summary>
        /// 地址
        /// </summary>
        public string Address
        {
            set { _address = value; }
            get { return _address; }
        }
        /// <summary>
        /// 电话
        /// </summary>
        public string Phone
        {
            set { _phone = value; }
            get { return _phone; }
        }
        /// <summary>
        /// 开业时间
        /// </summary>
        public string OpenTime
        {
            set { _opentime = value; }
            get { return _opentime; }
        }
        /// <summary>
        /// 简介
        /// </summary>
        public string Summary
        {
            set { _summary = value; }
            get { return _summary; }
        }
        #endregion Model

    }
}

