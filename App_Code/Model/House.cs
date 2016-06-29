using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model
{
    /// <summary>
    /// 房源信息
    /// </summary>
    [Serializable]
    public partial class House
    {
        public House()
        { }

        /// <summary>
        /// 获取默认房源
        /// </summary>
        /// <returns></returns>
        public House DefaultHouse() {
            this.ID = 0;
            this.Type = "";
            this.Qu = "";
            this.XiaoQu = "";
            this.Ceng = "";
            this.ZongCeng = "";
            this.Shi = "";
            this.Ting = "";
            this.Wei = "";
            this.MianJi = "";
            this.ZhuangXiu = "";
            this.Jianyu = "";
            this.JiaGe = "";
            this.JiaGeDanwei = "";
            this.Chaoxiang = "";
            this.Chanquan = "";
            this.JieGou = "";
            this.ZhuJiMa = "";
            this.FyHao = "";
            this.DengJiTime = "";
            this.JJR = "";
            this.JJRPhone = "";
            this.Detail = "暂无信息";
            this.JingPin = "";
            this.Title = "暂无信息";
            return this;
        }
        #region Model
        private int _id;
        private string _type;
        private string _qu;
        private string _xiaoqu;
        private string _ceng;
        private string _zongceng;
        private string _shi;
        private string _ting;
        private string _wei;
        private string _mianji;
        private string _zhuangxiu;
        private string _jianyu;
        private string _jiage;
        private string _jiagedanwei;
        private string _chaoxiang;
        private string _chanquan;
        private string _jiegou;
        private string _zhujima;
        private string _fyhao;
        private string _dengjitime;
        private string _jjr;
        private string _jjrphone;
        private string _Detail;
        private string _JingPin;
        private string _Title;
        /// <summary>
        /// 序号
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 类型Sale OR Rent
        /// </summary>
        public string Type
        {
            set { _type = value; }
            get { return _type; }
        }
        /// <summary>
        /// 区
        /// </summary>
        public string Qu
        {
            set { _qu = value; }
            get { return _qu; }
        }
        /// <summary>
        /// 小区
        /// </summary>
        public string XiaoQu
        {
            set { _xiaoqu = value; }
            get { return _xiaoqu; }
        }
        /// <summary>
        /// 楼层
        /// </summary>
        public string Ceng
        {
            set { _ceng = value; }
            get { return _ceng; }
        }
        /// <summary>
        /// 总楼层
        /// </summary>
        public string ZongCeng
        {
            set { _zongceng = value; }
            get { return _zongceng; }
        }
        /// <summary>
        /// 室
        /// </summary>
        public string Shi
        {
            set { _shi = value; }
            get { return _shi; }
        }
        /// <summary>
        /// 厅
        /// </summary>
        public string Ting
        {
            set { _ting = value; }
            get { return _ting; }
        }
        /// <summary>
        /// 卫
        /// </summary>
        public string Wei
        {
            set { _wei = value; }
            get { return _wei; }
        }
        /// <summary>
        /// 面积
        /// </summary>
        public string MianJi
        {
            set { _mianji = value; }
            get { return _mianji; }
        }
        /// <summary>
        /// 装修
        /// </summary>
        public string ZhuangXiu
        {
            set { _zhuangxiu = value; }
            get { return _zhuangxiu; }
        }
        /// <summary>
        /// 建于
        /// </summary>
        public string Jianyu
        {
            set { _jianyu = value; }
            get { return _jianyu; }
        }
        /// <summary>
        /// 价格
        /// </summary>
        public string JiaGe
        {
            set { _jiage = value; }
            get { return _jiage; }
        }
        /// <summary>
        /// 价格单位
        /// </summary>
        public string JiaGeDanwei
        {
            set { _jiagedanwei = value; }
            get { return _jiagedanwei; }
        }
        /// <summary>
        /// 朝向
        /// </summary>
        public string Chaoxiang
        {
            set { _chaoxiang = value; }
            get { return _chaoxiang; }
        }
        /// <summary>
        /// 产权
        /// </summary>
        public string Chanquan
        {
            set { _chanquan = value; }
            get { return _chanquan; }
        }
        /// <summary>
        /// 建筑结构
        /// </summary>
        public string JieGou
        {
            set { _jiegou = value; }
            get { return _jiegou; }
        }
        /// <summary>
        /// 助记码
        /// </summary>
        public string ZhuJiMa
        {
            set { _zhujima = value; }
            get { return _zhujima; }
        }
        /// <summary>
        /// 房源号
        /// </summary>
        public string FyHao
        {
            set { _fyhao = value; }
            get { return _fyhao; }
        }
        /// <summary>
        /// 登记时间
        /// </summary>
        public string DengJiTime
        {
            set { _dengjitime = value; }
            get { return _dengjitime; }
        }
        /// <summary>
        /// 经纪人
        /// </summary>
        public string JJR
        {
            set { _jjr = value; }
            get { return _jjr; }
        }
        /// <summary>
        /// 经纪人电话
        /// </summary>
        public string JJRPhone
        {
            set { _jjrphone = value; }
            get { return _jjrphone; }
        }
        /// <summary>
        /// 详细说明
        /// </summary>
        public string Detail
        {
            set { _Detail = value; }
            get { return _Detail; }
        }
        /// <summary>
        /// 精品房源
        /// </summary>
        public string JingPin
        {
            get
            {
                return _JingPin;
            }
            set
            {
                _JingPin = value;
            }
        }

        public string Title
        {
            get
            {
                return _Title;
            }

            set
            {
                _Title = value;
            }
        }
        #endregion Model

    }
}