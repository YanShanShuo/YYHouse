using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model
{
    /// <summary>
	/// 站点配置
	/// </summary>
	[Serializable]
    public partial class SiteConfig
    {
        public SiteConfig()
        { }
        #region Model
        private int _id;
        private string _key;
        private string _value;
        /// <summary>
        /// 序号
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Key
        {
            set { _key = value; }
            get { return _key; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Value
        {
            set { _value = value; }
            get { return _value; }
        }
        #endregion Model

    }
}