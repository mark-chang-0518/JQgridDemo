using System.Web;
using System.Web.Optimization;

namespace JQgridDemo
{
    public class BundleConfig
    {
        // 如需統合的詳細資訊，請瀏覽 https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryjqgrid").Include(
                 "~/Scripts/i18n/grid.locale-tw*",
                        "~/Scripts/jquery.jqgrid*",
                        "~/src/grid.common.js",
                        "~/src/grid.formedit.js",
                        "~/src/jqModal.js",
                        "~/src/jqDnR.js",
                        "~/Scripts/datepicker.js",
                        "~/Scripts/locales/datepicker.en.js",
                        "~/Scripts/locales/datepicker.zh-TW.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-1.12.1.js",
                        "~/Scripts/customerUtility.js",
                        "~/Scripts/customJqgrid.js"
                        ));

            // 使用開發版本的 Modernizr 進行開發並學習。然後，當您
            // 準備好可進行生產時，請使用 https://modernizr.com 的建置工具，只挑選您需要的測試。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/bootstrap.bundle.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/build.css",
                      "~/Content/font-awesome.css",
                      "~/Content/jquery.jqGrid/ui.jqgrid.css",
                      "~/Content/jquery.ui.theme.css",
                      "~/Content/jquery.ui.min.css",
                      "~/Content/site.css",
                      "~/Content/customJqgrid.css",
                      "~/Content/datepicker.css"
                      ));
        }
    }
}
