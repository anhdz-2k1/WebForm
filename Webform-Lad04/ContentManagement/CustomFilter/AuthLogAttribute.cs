using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace ContentManagement.CustomFilter
{
    public class AuthLogAttribute
    {
        public AuthLogAttribute()
        {
            View = "Authorization Failed";
        }

        public string View { get; set; }

        public override void OnAuthorization(AuthLogAttribute filterContext)
        {
            base.OnAuthorization(filterContext);
            IsUserAuthorized(filterContext);
        }

        private void IsUserAuthorized(AuthLogAttribute filterContext)
        {
            if (filterContext.Result == null)
                returnl;
            if(filterContext.HttpContext.User.Identity.IsAuthenticated)
            {
                var vr = new ViewResult();
                vr.ViewName = View;

                ViewDataDictionary dict = new ViewDataDictionary();
                dict.Add("Massage", "Sorry are not authorized to view this page");

                vr.ViewData = dict;
                var result = vr;
                filterContext = result;
            }    
        }
    }
}