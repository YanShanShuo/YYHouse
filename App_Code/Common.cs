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
}