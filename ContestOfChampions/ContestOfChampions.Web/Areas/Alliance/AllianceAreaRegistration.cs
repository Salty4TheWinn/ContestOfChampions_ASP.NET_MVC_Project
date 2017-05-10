using System.Web.Mvc;

namespace ContestOfChampions.Web.Areas.Alliance
{
    public class AllianceAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Alliance";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.Routes.MapMvcAttributeRoutes();

            context.MapRoute(
                "Alliance_default",
                "Alliance/{controller}/{action}/{id}",
                new {controller="Alliance", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}