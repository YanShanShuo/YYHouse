
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model
{
    /// <summary>
    /// 图片
    /// </summary>
    [Serializable]
    public partial class Pic
    {
        public Pic()
        { }
        #region Model
        private int _id;
        private string _imageurl;
        private string _aid;
        private string _type;
        private string _number;
        private string _title;
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
        /// 序号
        /// </summary>
        public string ImageURL
        {
            set { _imageurl = value; }
            get { return _imageurl; }
        }
        /// <summary>
        /// 关联序号
        /// </summary>
        public string AID
        {
            set { _aid = value; }
            get { return _aid; }
        }
        /// <summary>
        /// 图片类型
        /// </summary>
        public string Type
        {
            set { _type = value; }
            get { return _type; }
        }
        /// <summary>
        /// 图片排序
        /// </summary>
        public string Number
        {
            set { _number = value; }
            get { return _number; }
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
        /// 摘要-
        /// </summary>
        public string Summary
        {
            set { _summary = value; }
            get { return _summary; }
        }

        #endregion Model

    }
}