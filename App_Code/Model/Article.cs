using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Model
{

    /// <summary>
	/// 文章
	/// </summary>
	[Serializable]
    public partial class Article
    {
        public Article()
        { }
        #region Model
        private int _id;
        private string _title;
        private string _detail;
        private string _summary;
        private string _author;
        private string _submittime;
        private string _updatetime;
        private string _type;
        private string _click;
        private int? _order;
        /// <summary>
        /// 序号
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 标题
        /// </summary>
        public string Title
        {
            set { _title = value; }
            get { return _title; }
        }
        /// <summary>
        /// 内容
        /// </summary>
        public string Detail
        {
            set { _detail = value; }
            get { return _detail; }
        }
        /// <summary>
        /// 摘要
        /// </summary>
        public string Summary
        {
            set { _summary = value; }
            get { return _summary; }
        }
        /// <summary>
        /// 作者
        /// </summary>
        public string Author
        {
            set { _author = value; }
            get { return _author; }
        }
        /// <summary>
        /// 提交时间
        /// </summary>
        public string SubmitTime
        {
            set { _submittime = value; }
            get { return _submittime; }
        }
        /// <summary>
        /// 更新时间
        /// </summary>
        public string UpdateTime
        {
            set { _updatetime = value; }
            get { return _updatetime; }
        }
        /// <summary>
        /// 类型
        /// </summary>
        public string Type
        {
            set { _type = value; }
            get { return _type; }
        }
        /// <summary>
        /// 点击数
        /// </summary>
        public string Click
        {
            set { _click = value; }
            get { return _click; }
        }
        /// <summary>
        /// 排序
        /// </summary>
        public int? Order
        {
            set { _order = value; }
            get { return _order; }
        }
        #endregion Model

    }

}