using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

/// <summary>
/// Common 的摘要说明
/// </summary>
public class Common
{
    public Common()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }




    /// <summary>
    /// 返回页面的分页信息
    /// </summary>
    /// <param name="_RecordCount">记录总数</param>
    /// <param name="_PageSize">分页长度</param>
    /// <param name="_PageIndex">当前页</param>
    /// <returns></returns>
    public static string PageInfo(int _RecordCount, int _PageSize, int _PageIndex, string link)
    {

        int _ButtonCount = 6;
        string _NextPage = "<a href='{0}'><span class='page-index'>下一页</span></a>";
        string _LinkUrl = "&p={0}";
        string _LastPage = "<a href='{0}'><span class='page-index'>上一页</span></a>";


        link = link + _LinkUrl;
        string Firstpage = string.Format("<a href='" + link + "'><span class='page-index'>首页</span></a>", "1");
        //string pageinfo = "共有{0}页 / 当前第{1}页 " + Firstpage;
        string pageinfo = Firstpage;
        string pagenext = " <a href='" + link + "'><span class='page-index'>{0}</span></a> ";
        int PageCount = _RecordCount / _PageSize; // 页数合计
        PageCount = PageCount <= 0 ? 1 : PageCount;
        pageinfo = string.Format(pageinfo, PageCount.ToString(), _PageIndex.ToString());
        string LastPage = string.Format("<a href='" + link + "'><span class='page-index'>末页</span></a>", PageCount);

        int n = _ButtonCount / 2;  //左右显示个数
        int StartPage = _PageIndex - n;
        int EndPage = _PageIndex + n;



        _LastPage = string.Format(_LastPage, link);  //上一页
        _LastPage = _PageIndex - 1 > 1 ? string.Format(_LastPage, (_PageIndex - 1).ToString()) : string.Format(_LastPage, "1");

        _NextPage = string.Format(_NextPage, link); //下一页
        _NextPage = _PageIndex + 1 <= PageCount ? string.Format(_NextPage, (_PageIndex + 1).ToString()) : string.Format(_NextPage, PageCount.ToString());

        pageinfo += _LastPage;

        if (EndPage > PageCount)
        {
            StartPage = (_PageIndex - n) - (EndPage - PageCount);
            EndPage = PageCount;
        }
        if (StartPage < 1)
        {
            StartPage = 1;
        }

        for (int i = StartPage; i <= EndPage; i++)
        {
            if (i != _PageIndex)
                pageinfo += string.Format(pagenext, i);
            else
                pageinfo += string.Format(" <a href='" + link + "' class='on'> <span>{0}</span></a> ", i);
        }
        pageinfo += _NextPage;
        pageinfo += LastPage;
        return pageinfo;
    }

    /// <summary>
    /// 获取随机字符
    /// 字符从0-9，A-Z随机产生
    /// </summary>
    /// <returns></returns>
    public static string GetMix(SuiJiType type, int length)
    {
        string suijistr = @"0123456789abcdefghigklmnopqrstuvwxyzABCDEFGHIGKLMNOPQRSTUVWXYZ";
        int number;
        string strCode = string.Empty;
        //随机数种子  
        Random radom = new Random();

        int i1 = 0;
        int i2 = 0;
        switch (type)
        {
            case SuiJiType.Number:
                i1 = 0;
                i2 = 10;
                break;
            case SuiJiType.Lowercase_letters:
                i1 = 10; i2 = 26;
                break;
            case SuiJiType.Capital_letters:
                i1 = 36; i2 = 26;
                break;
            case SuiJiType.HunHe1:
                i1 = 10; i2 = 52;
                break;
            case SuiJiType.HunHe2:
                i1 = 0; i2 = 36;
                break;
            case SuiJiType.HunHe3:
                i1 = 0; i2 = 61;
                break;
        }
        for (int i = 0; i < length; i++)
        {
            //随机的整数  
            number = radom.Next();
            strCode += suijistr.Substring(i1 + new Random(number).Next(i2), 1);
        }
        if (type == SuiJiType.HunHe3) strCode = strCode.ToUpper();
        return strCode;
    }
}
public enum SuiJiType : int
{
    /// <summary>
    /// 数字
    /// </summary>
    Number = 1,
    /// <summary>
    /// 小写字母
    /// </summary>
    Lowercase_letters = 2,
    /// <summary>
    /// 大写字母
    /// </summary>
    Capital_letters = 3,
    /// <summary>
    /// 返回大小写字母混合
    /// </summary>
    HunHe1 = 4,
    /// <summary>
    /// 返回小写字母和数字混合
    /// </summary>
    HunHe2 = 5,
    /// <summary>
    /// 返回大写字母和数字混合
    /// </summary>
    HunHe3 = 6,
    /// <summary>
    /// 返回大小写字母和数字混合
    /// </summary>
    HunHe4 = 7,

}