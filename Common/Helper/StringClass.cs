using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Web2mmanga.Common.Helper
{
    public class StringClass
    {
        public static string NameToSign(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(System.Text.NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }

        public static string NameToTag(string strName)
        {
            string strReturn = "";
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            strReturn = Regex.Replace(strName, "[^\\w\\s]", string.Empty).Replace(" ", "-").ToLower();
            string strFormD = strReturn.Normalize(System.Text.NormalizationForm.FormD);
            return regex.Replace(strFormD, string.Empty).Replace("đ", "d");
        }

        public static string GetLinkImages(string link, int size)
        {
            string str = string.Empty;
            //str = "https://img.nhalinhdam.com/" + "Image.ashx?src=" + link.Replace("https://img.nhalinhdam.com", string.Empty) + "&width=" + size + "";
            return str;
        }

        public static string Viewurl(string page,string name, int pageindex)
        {
            return "/"+ page + "?name=" + name + "&pageindex=" + pageindex + "";
        }

        public static string FullTwoChar(int number)
        {
            return number.ToString().Length > 1 ? number.ToString() : "0" + number.ToString();
        }
    }
}