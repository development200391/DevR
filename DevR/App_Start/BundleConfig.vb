Imports System.Web.Optimization

Public Module BundleConfig
    ' For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
    Public Sub RegisterBundles(ByVal bundles As BundleCollection)

        bundles.Add(New ScriptBundle("~/bundles/jquery").Include(
                    "~/Content/AboutMe/js/jquery-3.2.1.min.js",
                    "~/Content/AboutMe/js/popper.js",
                    "~/Content/AboutMe/js/bootstrap.min.js",
                    "~/Content/AboutMe/js/stellar.js",
                    "~/Content/AboutMe/vendors/lightbox/simpleLightbox.min.js",
                    "~/Content/AboutMe/vendors/nice-select/js/jquery.nice-select.min.js",
                    "~/Content/AboutMe/vendors/isotope/imagesloaded.pkgd.min.js",
                    "~/Content/AboutMe/vendors/isotope/isotope-min.js",
                    "~/Content/AboutMe/vendors/owl-carousel/owl.carousel.min.js",
                    "~/Content/AboutMe/js/jquery.ajaxchimp.min.js",
                    "~/Content/AboutMe/vendors/counter-up/jquery.waypoints.min.js",
                    "~/Content/AboutMe/vendors/counter-up/jquery.counterup.min.js",
                    "~/Content/AboutMe/js/mail-script.js",
                    "~/Content/AboutMe/js/gmaps.min.js",
                    "~/Content/AboutMe/js/theme.js"))

        bundles.Add(New StyleBundle("~/Content/css").Include(
                  "~/Content/AboutMe/css/bootstrap.css",
                  "~/Content/AboutMe/vendors/linericon/style.css",
                  "~/Content/AboutMe/css/font-awesome.min.css",
                  "~/Content/AboutMe/vendors/owl-carousel/owl.carousel.min.css",
                  "~/Content/AboutMe/vendors/lightbox/simpleLightbox.css",
                  "~/Content/AboutMe/vendors/nice-select/css/nice-select.css",
                  "~/Content/AboutMe/vendors/animate-css/animate.css",
                  "~/Content/AboutMe/vendors/flaticon/flaticon.css",
                  "~/Content/AboutMe/css/style.css",
                  "~/Content/AboutMe/css/responsive.css"))
    End Sub
End Module

