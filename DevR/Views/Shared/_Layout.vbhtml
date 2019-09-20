<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="icon" href="@Url.Action("icon", "img")/favicon.png" type="image/png">
    <title>@ViewBag.Title</title>
    @Styles.Render("~/Content/css")
</head>
<body>
    <header class="header_area">
        <div class="main_menu" id="mainNav">
            <nav class="navbar navbar-expand-lg navbar-light">
                <div class="container box_1620">
                    <!-- Brand and toggle get grouped for better mobile display -->
                    <a class="navbar-brand logo_h" href="@Url.Action("Index")"><h3>Dev R</h3></a>
                    <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <!-- Collect the nav links, forms, and other content for toggling -->
                    <div class="collapse navbar-collapse offset" id="navbarSupportedContent">
                        <ul class="nav navbar-nav menu_nav ml-auto">
                            <li class="nav-item"><a class="nav-link" href="@Url.Action("Index")">About Me</a></li>
                            <li class="nav-item submenu dropdown">
                                <a href="#" class="nav-link dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">Services</a>
                                <ul class="dropdown-menu">
                                    <li class="nav-item"><a class="nav-link" href="@Url.Action("CreateWebsite")">Create Website</a></li>
                                </ul>
                            </li>
                            <li class="nav-item"><a class="nav-link" href="@Url.Action("Portofolio")">Portofolio</a></li>
                            <li class="nav-item"><a class="nav-link" href="@Url.Action("Contact")">Contact</a></li>
                        </ul>
                    </div>
                </div>
            </nav>
        </div>
    </header>
    @RenderBody()
    <div class="col-lg-offset-1 col-md-offset-1 col-lg-4 col-md-4 col-sm-12 col-xs-12">
        <div class="row">
            <aside id="shortcodes-ultimate-2" class="widget shortcodes-ultimate col-lg-6 col-md-6 col-sm-12 col-xs-12">
                <div class="textwidget">
                    <div class="ccw_plugin sc_item" style=" position:fixed;right:10px;bottom:10px; ">
                        <div class="client-logo">
                            <a href="https://wa.me/6283822207153?text=Halo, saya ingin bertanya Jasa di DevR.Space">
                                <img src="@Url.Action("icon", "img")/whatsapp-button.png" width="142" class="img-fluid" alt="">
                            </a>
                        </div>
                    </div>
                </div>
            </aside>
        </div>
    </div>

    @Scripts.Render("~/bundles/jquery")
    @RenderSection("scripts", required:=False)
</body>
</html>
