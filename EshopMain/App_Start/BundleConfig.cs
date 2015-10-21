using System.Web.Optimization;

namespace EshopMain
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css")
                .Include("~/Content/Site.css")
                .Include("~/Content/bootstrap.css")
                .Include("~/Content/bootstrap-theme.css")
                );

            bundles.Add(new ScriptBundle("~/bundles/bootstrap")
                .Include("~/Scripts/bootstrap.js")
                .Include("~/Scripts/respond.js")
                );

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                       "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/angularjs")
                .Include("~/Scripts/angular.min.js", "~/Scripts/angular-ui-router.min.js"));

            bundles.Add(new Bundle("~/bundles/eshopJs")
               .Include("~/ScriptsApp/Eshop.js")
               .Include("~/ScriptsApp/configAdminas.js")
               .Include("~/ScriptsApp/configVartotojas.js")
               .Include("~/ScriptsApp/Controllers/AdminController.js")
               .Include("~/ScriptsApp/Controllers/KrepselisController.js")
               .Include("~/ScriptsApp/Controllers/UzsakymaiController.js")
               );

            BundleTable.EnableOptimizations = true;
        }
    }
}
