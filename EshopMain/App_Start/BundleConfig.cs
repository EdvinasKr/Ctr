using System.Web.Optimization;

namespace EshopMain
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/cssStyle")
                .Include("~/Content/Site.css")
                .Include("~/Content/bootstrap.css")
                .Include("~/Content/bootstrap-theme.css")
                );

            bundles.Add(new ScriptBundle("~/bundles/eshopJs")
                .IncludeDirectory("~/ScriptsApp/", "*.js")
                .IncludeDirectory("~/ScriptsApp/Controllers", "*.js")
                );

            bundles.Add(new ScriptBundle("~/bundles/angularjs")
                .Include("~/Scripts/angular.js")
                .Include("~/Scripts/angular-ui-router.js")
                .Include("~/Scripts/jquery-1.10.2.js"));
            BundleTable.EnableOptimizations = true;
        }
    }
}
