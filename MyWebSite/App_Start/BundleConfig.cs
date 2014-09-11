using System.Web.Optimization;

namespace MyWebSite
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            // JQuery bundles
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery-migrate-1.2.1.min.js",
                        "~/Scripts/jquery.validate*"));

            // Bootstrap bundles
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));
            bundles.Add(new StyleBundle("~/Content/bootstrap").Include(
                      "~/Content/bootstrap.css"));

            // Browser support
            bundles.Add(new ScriptBundle("~/bundles/respond").Include(
                      "~/Scripts/respond.js"));
            bundles.Add(new ScriptBundle("~/bundles/html5shiv").Include(
                      "~/Scripts/plugins/html5shiv.js"));            

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            // BackToTop bundles
            bundles.Add(new StyleBundle("~/bundles/backtotop").Include(
                      "~/Scripts/plugins/back-to-top.js"));

            // FlexSlider bundles
            bundles.Add(new StyleBundle("~/bundles/flexslider").Include(
                      "~/Scripts/plugins/flexslider/jquery.flexslider.js"));
            bundles.Add(new StyleBundle("~/Content/flexslider").Include(
                      "~/Content/plugins/flexslider/flexslider.css"));

            // FlexSlider bundles
            bundles.Add(new StyleBundle("~/bundles/parallaxslider").Include(
                      "~/Scripts/plugins/parallax-slider/jquery.cslider.js"));
            bundles.Add(new StyleBundle("~/Content/parallaxslider").Include(
                      "~/Content/plugins/parallax-slider/parallax-slider.css"));

            // Unify bundles
            bundles.Add(new StyleBundle("~/bundles/unify").Include(
                      "~/Scripts/unify/app.js"));
            bundles.Add(new StyleBundle("~/Content/unify").Include(
                      "~/Content/unify/app.css",
                      "~/Content/unify/plugins.css",
                      "~/Content/unify/ie8.css",
                      "~/Content/plugins/animate.css",
                      "~/Content/plugins/box-shadows.css",
                      "~/Content/unify/style.css"));
            bundles.Add(new StyleBundle("~/Content/unifythemes").Include(
                      "~/Content/unify/themes/default.css"));

            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = false;
        }
    }
}
