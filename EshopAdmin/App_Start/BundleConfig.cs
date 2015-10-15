using System.Web;
using System.Web.Optimization;

namespace Eshop
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/angularjs")
                .Include("~/Scripts/angular.js")
                .Include("~/Scripts/angular-ui-router.js")
                .Include("~/Scripts/jquery-2.1.3.js"));

            bundles.Add(new ScriptBundle("~/bundles/eshop")
                 .Include("~/ScriptsApp/EshopAdmin.js")
                 .Include("~/ScriptsApp/configAdminas.js")
                 .Include("~/ScriptsApp/Controllers/AdminController.js")
                 .Include("~/ScriptsApp/Controllers/UzsakymaiController.js"));
            BundleTable.EnableOptimizations = true;
        }
    }
}
