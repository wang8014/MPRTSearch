﻿using System.Web;
using System.Web.Mvc;
using MPRTSearch.Filters;

namespace MPRTSearch
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //filters.Add(new HandleErrorAttribute());
            filters.Add(new ExceptionFilter());
        }
    }
}
