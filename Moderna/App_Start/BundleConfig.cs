using System.Web;
using System.Web.Optimization;

namespace Moderna
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/appjs").Include(
                     "~/js/jquery-1.10.2.js",
                     "~/js/validate.js",
                     "~/js/jquery.easing.1.3.js",
                     "~/js/bootstrap.min.js",
                     "~/js/jquery.fancybox.pack.js",
                     "~/js/jquery.fancybox-media.js",
                     "~/js/google-code-prettify/prettify.js",
                     "~/js/portfolio/jquery.quicksand.js",
                     "~/js/portfolio/setting.js",
                     "~/js/jquery.flexslider.js",
                     "~/js/animate.js",
                     "~/js/custom.js",
                     "~/js/facebook.js"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                "~/js/vendor/angular/angular.min.js",
                "~/js/vendor/angular-route/angular-route.min.js",
                "~/js/app.js"
                ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/css/bootstrap.min.css",
                      "~/css/fancybox/jquery.fancybox.css",
                      "~/css/jcarousel.css",
                      "~/css/flexslider.css",
                      "~/css/style.css",
                      "~/skins/default.css"));
        }
    }
}
