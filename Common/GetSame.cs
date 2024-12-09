using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Web2mmanga.Common
{
    public class GetSame
    {
        //public static string GetPage(int totalPage, int pageindex)
        //{
        //    var pathAndQuery = HttpContext.Current.Request.Url.PathAndQuery;

        //    var strpageindex = Regex.Match(pathAndQuery, @"pageindex=.*").Groups[0].Value;
        //    pathAndQuery = pathAndQuery.Replace(strpageindex, string.Empty);
        //    pathAndQuery = pathAndQuery + "pageindex=";

        //    string strpage = string.Empty;
        //    strpage += "<ul class='pagination pagination-sm m-0 float-right'>";

        //    var startPage = pageindex - 2;
        //    var endPage = pageindex + 2;

        //    if (startPage <= 0)
        //    {
        //        endPage -= (startPage - 1);
        //        startPage = 1;
        //    }

        //    if (endPage > totalPage)
        //        endPage = (int)totalPage;

        //    var link = string.Empty;

        //    if (startPage > 1)
        //    {
        //        //echo " First ... ";
        //        link = pathAndQuery + (startPage - 1);
        //        strpage += "<li class='page-item'><a class='page-link' href='" + link + "'>Trước</a></li>";


        //    }

        //    for (int i = startPage; i <= endPage; i++)
        //    {
        //        //echo " {$i} ";
        //        link = pathAndQuery + i;
        //        if (i == pageindex)
        //        {
        //            strpage += "<li class='page-item active'><a class='page-link' href='" + link + "'>" + i + "</a></li>";
        //        }
        //        else
        //        {
        //            strpage += "<li class='page-item'><a class='page-link' href='" + link + "'>" + i + "</a></li>";
        //        }
        //    }

        //    if (endPage < totalPage)
        //    {
        //        //echo " ... Last ";
        //        link = pathAndQuery + (endPage + 1);
        //        strpage += "<li class='page-item'><a class='page-link' href='" + link + "'>Sau</a></li>";
        //    }

        //    strpage += "</ul>";
        //    return strpage;
        //}
    }


}