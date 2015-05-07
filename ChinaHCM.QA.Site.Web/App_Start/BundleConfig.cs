using System.Web;
using System.Web.Optimization;

namespace ChinaHCM.QA.Site.Web
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                    "~/Scripts/bootstrap.js",
                    "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/site.css",
                "~/Content/list.css",
                "~/Content/msgbox.css"));

            bundles.Add(new StyleBundle("~/Content/ManageCss").Include(
                "~/Content/bootstrap.css",
                "~/Content/Manager.css",
                "~/Content/list.css",
                "~/Content/msgbox.css",
                "~/Content/powerFloat.css"));

            bundles.Add(new StyleBundle("~/Content/MLoginCss").Include(
               "~/Content/login.css",
               "~/Content/msgbox.css",
               "~/Content/powerFloat.css"));
        }
    }
}