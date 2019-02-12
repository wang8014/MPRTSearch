using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MPRTSearch.Logger;

namespace MPRTSearch.Filters
{
    public class ExceptionFilter : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            FileLogger logger = new FileLogger();
            logger.LogException(filterContext.Exception);
            //filterContext .ExceptionHandled = true;
            //filterContext.Result = new ContentResult()
            //{
            //    Content = "Sorry for the Error"
            //};
            base.OnException(filterContext);
        }
    }
}