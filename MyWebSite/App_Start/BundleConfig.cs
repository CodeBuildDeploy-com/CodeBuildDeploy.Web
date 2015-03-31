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
                      "~/Content/bootstrap.css",
                      "~/Content/bootstrap-theme.css"));

            // Browser support
            bundles.Add(new ScriptBundle("~/bundles/respond").Include(
                      "~/Scripts/respond.js"));
            bundles.Add(new ScriptBundle("~/bundles/html5shiv").Include(
                      "~/Plugins/html5shiv.js"));            

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            // BackToTop
            bundles.Add(new StyleBundle("~/bundles/backtotop").Include(
                      "~/Plugins/back-to-top.js"));

            // SmoothScroll
            bundles.Add(new StyleBundle("~/bundles/smoothScroll").Include(
                      "~/Plugins/smoothScroll.js"));

            // Animate
            bundles.Add(new StyleBundle("~/Content/animate").Include(
                      "~/Plugins/animate.css"));

            // BoxShaddows
            bundles.Add(new StyleBundle("~/Content/boxShaddows").Include(
                      "~/Plugins/box-shaddows.css"));

            // Line Icons
            bundles.Add(new StyleBundle("~/Content/lineIcons").Include(
                      "~/Plugins/line-icons/line-icons.css"));

            // Font Awesome
            bundles.Add(new StyleBundle("~/Content/fontAwesome").Include(
                      "~/Plugins/font-awesome/css/font-awesome.css"));

            // ParallaxSlider bundles
            bundles.Add(new StyleBundle("~/bundles/parallaxslider").Include(
                      "~/Plugins/parallax-slider/js/jquery.cslider.js",
                      "~/Scripts/unify/plugins/parallax-slider/parallax-slider.js"));
            bundles.Add(new StyleBundle("~/Content/parallaxslider").Include(
                      "~/Plugins/parallax-slider/css/parallax-slider.css"));

            // OwlCarousel bundles
            bundles.Add(new StyleBundle("~/bundles/owlcarousel").Include(
                      "~/Plugins/owl-carousel/owl.carousel.js",
                      "~/Scripts/unify/plugins/owl-carousel/owl-carousel.js"));
            bundles.Add(new StyleBundle("~/Content/owlcarousel").Include(
                      "~/Plugins/owl-carousel/owl.carousel.css"));

            // Unify bundles
            bundles.Add(new StyleBundle("~/bundles/unify").Include(
                      "~/Scripts/unify/app.js"));
            bundles.Add(new StyleBundle("~/Content/unify").Include(
                      //"~/Content/unify/app.css", // This is provided by style.css
                      //"~/Content/unify/plugins.css", // This is provided by style.css
                      //"~/Content/unify/ie8.css", // This is provided by style.css
                      //"~/Content/unify/blocks.css", // This is provided by style.css
                      "~/Content/unify/style.css",
                      "~/Content/unify/headers/header-default.css",
                      "~/Content/unify/footers/footer-default.css"));
            bundles.Add(new StyleBundle("~/Content/unifythemes").Include(
                      "~/Content/unify/theme-colors/brown.css"));

            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = false;
        }
    }
}
