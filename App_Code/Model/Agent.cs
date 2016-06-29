using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model
{
    /// <summary>
    /// 经纪人
    /// </summary>
    public partial class Agent
    {
        public Agent()
        { }
        #region Model
        private int _id;
        private string _truename;
        private string _phone;
        private string _words;
        private int? _comid;
        private string _account;
        private string _password;
        private string _qq;
        private string _wechat;
        private string _xiaoqu;
        /// <summary>
        /// 序号
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 真实姓名
        /// </summary>
        public string TrueName
        {
            set { _truename = value; }
            get { return _truename; }
        }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string Phone
        {
            set { _phone = value; }
            get { return _phone; }
        }
        /// <summary>
        /// 宣言
        /// </summary>
        public string Words
        {
            set { _words = value; }
            get { return _words; }
        }
        /// <summary>
        /// 公司ID
        /// </summary>
        public int? ComID
        {
            set { _comid = value; }
            get { return _comid; }
        }
        /// <summary>
        /// 账号
        /// </summary>
        public string Account
        {
            set { _account = value; }
            get { return _account; }
        }
        /// <summary>
        /// 密码
        /// </summary>
        public string PassWord
        {
            set { _password = value; }
            get { return _password; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string QQ
        {
            set { _qq = value; }
            get { return _qq; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string WeChat
        {
            set { _wechat = value; }
            get { return _wechat; }
        }
        /// <summary>
        /// 经营小区
        /// </summary>
        public string Xiaoqu
        {
            set { _xiaoqu = value; }
            get { return _xiaoqu; }
        }
        #endregion Model

    }
}
