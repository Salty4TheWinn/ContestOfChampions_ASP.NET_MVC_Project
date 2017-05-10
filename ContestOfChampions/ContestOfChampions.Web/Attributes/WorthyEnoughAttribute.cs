using System.Linq;
using System.Web.Mvc;

namespace ContestOfChampions.Web.Attributes
{
    public class WorthyEnoughAttribute : AuthorizeAttribute
    {
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {

            var roles = this.Roles.Split(',');
            if ((filterContext.HttpContext.Request.IsAuthenticated && !roles.Any(role => filterContext.HttpContext.User.IsInRole(role)))
                || !filterContext.HttpContext.Request.IsAuthenticated)
            {
                filterContext.Result = new ViewResult()
                {
                    ViewName = "~/Views/Shared/NotWorthy.cshtml"
                };
            }
            else
            {
                base.HandleUnauthorizedRequest(filterContext);
            }
        }
    }
}