﻿using System.Web;
using System.Web.Mvc;

namespace Authentication_and_Authurization
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
