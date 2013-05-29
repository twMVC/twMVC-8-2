using System.Web;
using System.Web.Optimization;

namespace DEV309_BundlingAndMinification
{
    public class BundleConfig
    {
        // 如需 Bundling 的詳細資訊，請造訪 http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //           "~/Scripts/test.min.js"));//利用 {version}可以不限定版本
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));//利用 {version}可以不限定版本但只要符合的都會載入

            //為了避免這情況可考慮改用萬用字元
            #region 萬用字元

            //            bundles.Add(new ScriptBundle("~/bundles/TEST").Include(
            //                        "~/Scripts/fakejs-1*"));//使用萬用字元設定只要 1.*
            //
            //            bundles.Add(new ScriptBundle("~/bundles/TEST").Include(
            //                        "~/Scripts/fakejs-2*"));//使用萬用字元設定只要 2.*
            #endregion

            #region 載入目錄
//            bundles.Add(new ScriptBundle("~/bundles/TEST").IncludeDirectory(
//                        "~/Scripts/", "test*", true));//載入 Scripts 目錄下所有前置為test的 js
            #endregion

            #region CDN支援
            //bundles.UseCdn = true;

            //var jqueryCdnPath = "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.7.1.min.js";

            //bundles.Add(new ScriptBundle("~/bundles/jquery",
            //            jqueryCdnPath).Include(
            //            "~/Scripts/jquery-{version}.js"));
            #endregion

            #region 自定忽略清單
            //bundles.Add(new ScriptBundle("~/bundles/jquery").IncludeDirectory(
            //            "~/Scripts/", "test*", true));//載入 Scripts 目錄下所有前置為test的 js

            //bundles.IgnoreList.Clear();
            //bundles.IgnoreList.Ignore("*.min.js", OptimizationMode.WhenEnabled);
            //bundles.IgnoreList.Ignore("*-vsdoc.js");
            //bundles.IgnoreList.Ignore("*.debug.js", OptimizationMode.WhenEnabled);

            #endregion
            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            // 使用開發版本的 Modernizr 進行開發並學習。然後，當您
            // 準備好實際執行時，請使用 http://modernizr.com 上的建置工具，只選擇您需要的測試。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));
        }
    }
}