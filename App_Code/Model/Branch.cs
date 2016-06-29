using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model
{
    /// <summary>
	/// 公司、分公司
	/// </summary>
	[Serializable]
    public partial class Branch
    {
        public Branch()
        { }
        #region Model
        private int _id;
        private string _branchname;
        private string _branchaddress;
        private string _branchphone;
        private string _branchdetail;
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 分公司名字
        /// </summary>
        public string BranchName
        {
            set { _branchname = value; }
            get { return _branchname; }
        }
        /// <summary>
        /// 地址
        /// </summary>
        public string BranchAddress
        {
            set { _branchaddress = value; }
            get { return _branchaddress; }
        }
        /// <summary>
        /// 电话
        /// </summary>
        public string BranchPhone
        {
            set { _branchphone = value; }
            get { return _branchphone; }
        }
        /// <summary>
        /// 详细说明
        /// </summary>
        public string BranchDetail
        {
            set { _branchdetail = value; }
            get { return _branchdetail; }
        }
        #endregion Model

    }
}