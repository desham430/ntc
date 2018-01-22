using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ntc.Models
{
    public static class html_helper
    {
        public static IHtmlString raj(string jj)
        {
            string htmlstring = string.Format("<label><mark>{0}</mark></label>", jj);
            return new HtmlString(htmlstring);
        }
    }
}