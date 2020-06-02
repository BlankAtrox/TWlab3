using System.Web.Optimization;

namespace eUseControl.Web
{
     public static class BundleConfig
     {
          public static void RegisterBundles(BundleCollection bundles)
          {
               // Personal styles
               bundles.Add(new StyleBundle("~/bundles/style/css").Include(
               "~/Content/mstyle.css", new CssRewriteUrlTransform()));

               // Personal styles
               bundles.Add(new StyleBundle("~/bundles/fontawesome/css").Include(
               "~/Content/font-awesome.css", new CssRewriteUrlTransform()));

               bundles.Add(new StyleBundle("~/bundles/metisMenu/css").Include(
               "~/Content/metisMenu.css", new CssRewriteUrlTransform()));

               bundles.Add(new StyleBundle("~/bundles/animate/css").Include(
               "~/Content/animate.css", new CssRewriteUrlTransform()));

               // Bootstrap style
               bundles.Add(new StyleBundle("~/bundles/bootstrap/css").Include(
               "~/Content/bootstrap.min.css", new CssRewriteUrlTransform()));



               bundles.Add(new StyleBundle("~/bundles/sweetalert/css").Include(
               "~/Content/sweet-alert.css", new CssRewriteUrlTransform()));

               bundles.Add(new StyleBundle("~/bundles/toastr/css").Include(
               "~/Content/toastr.min.css", new CssRewriteUrlTransform()));

               bundles.Add(new StyleBundle("~/bundles/peicon/css").Include(
               "~/Content/pe-icon-7-stroke.css", new CssRewriteUrlTransform()));

               bundles.Add(new StyleBundle("~/bundles/static/css").Include(
               "~/Content/static_custom.css", new CssRewriteUrlTransform()));
               bundles.Add(new StyleBundle("~/bundles/helper/css").Include(
               "~/Content/helper.css", new CssRewriteUrlTransform()));


               //Js
               bundles.Add(new ScriptBundle("~/bundles/jquerymin/js").Include(
                      "~/Scripts/jquery.min.js"));
               bundles.Add(new ScriptBundle("~/bundles/bootstrap/js").Include(
                    "~/Scripts/bootstrap.min.js"));
               bundles.Add(new ScriptBundle("~/bundles/jqueryui/js").Include(
                      "~/Scripts/jquery-ui.min.js"));
               bundles.Add(new ScriptBundle("~/bundles/jqueryslim/js").Include(
                      "~/Scripts/jquery.slimscroll.min.js"));
               bundles.Add(new ScriptBundle("~/bundles/metisMenu/js").Include(
                      "~/Scripts/metisMenu.min.js"));
               bundles.Add(new ScriptBundle("~/bundles/icheck/js").Include(
                      "~/Scripts/icheck.min.js"));
               bundles.Add(new ScriptBundle("~/bundles/index/js").Include(
                      "~/Scripts/index.js"));
               bundles.Add(new ScriptBundle("~/bundles/sweet/js").Include(
                      "~/Scripts/sweet-alert.min.js"));
               bundles.Add(new ScriptBundle("~/bundles/toastr/js").Include(
                      "~/Scripts/toastr.min.js"));
               bundles.Add(new ScriptBundle("~/bundles/homer/js").Include(
                      "~/Scripts/homer.js"));

          }
     }
}