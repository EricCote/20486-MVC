using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Seminaire.Filters
{
    public class FrancaisAttribute :ActionFilterAttribute
    {
        public bool Exception { get; set; }

        public FrancaisAttribute(bool exception)
        {
            this.Exception = exception;
        }
        public FrancaisAttribute()
        {
            this.Exception = false;
        }

      
     
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (!Exception)
            {
                System.Threading.Thread.CurrentThread.CurrentCulture =
                    new System.Globalization.CultureInfo("fr-CA");
            }
            base.OnActionExecuting(filterContext);
        }
    }
}