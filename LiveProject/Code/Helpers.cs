using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JPDash
{
    public static class LinkHelper
    {
        public static string ExternalLink(this HtmlHelper helper, string url)
        {
            return String.Format("{0}", url);
        }

    }


    public static class DateCalculateHelper
    {
        public static bool? CalculateIsObjectCreatedWithinOneWeekOfCurrentDate(DateTime? objectCreatedDate)
        {
            if (objectCreatedDate.HasValue)
            {
                DateTime hiredDate = Convert.ToDateTime(objectCreatedDate);
                var Today = DateTime.Today;
                TimeSpan span = Today.Subtract(hiredDate);
                if (span.Days > 7)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
            else
            {
                return null;
            }
        }

    }




}