@ModelType DevR.SendEmail
@Code
    ViewData("Title") = "Contact"
End Code

<!--================Home Banner Area =================-->
<section class="banner_area">
    <div class="banner_inner d-flex align-items-center">
        <div class="overlay bg-parallax" data-stellar-ratio="0.9" data-stellar-vertical-offset="0" data-background=""></div>
        <div class="container">
            <div class="banner_content text-center">
                <h2>CONTACT US</h2>
                <div class="page_link">
                    <a href="@Url.Action("Index")">Home</a>
                    <a href="@Url.Action("Contact")">CONTACT</a>
                </div>

            </div>
        </div>
    </div>
</section>
<!--================End Home Banner Area =================-->
<!--================Contact Area =================-->
<section class="contact_area p_120">
    <div class="container">

        <div class="row">
            <div class="col-lg-3">
                <div class="contact_info">
                    <div class="info_item">
                        <i class="lnr lnr-home"></i>
                        <h6>Bekasi, Indonesia</h6>
                        <p>Kp. Rawa Bebek</p>
                    </div>
                    <div class="info_item">
                        <i class="lnr lnr-phone-handset"></i>
                        <h6><a href="#">(+62) 838-2220-7153</a></h6>
                        <p>Mon to Fri 9am to 6 pm</p>
                    </div>
                    <div class="info_item">
                        <i class="lnr lnr-envelope"></i>
                        <h6><a href="#">development200391@gmail.com</a></h6>
                        <p>Send us your query anytime!</p>
                    </div>
                </div>
            </div>
            <div class="col-lg-9">
                @Using (Html.BeginForm("Contact", "Home", FormMethod.Post, htmlAttributes:=New With {.enctype = "multipart/form-data"}))
                    @Html.AntiForgeryToken()
                    @<div Class="col-md-6">
                        <div Class="form-group">
                            @*<input type="text" class="form-control" id="name" name="name" placeholder="Enter your name">*@
                            @Html.EditorFor(Function(model) model.Name, New With {.htmlAttributes = New With {.class = "form-control", .placeholder = "Enter your name"}})
                            @Html.ValidationMessageFor(Function(model) model.Name, "", New With {.class = "text-danger"})
                        </div>
                        <div Class="form-group">
                            @*<input type="email" class="form-control" id="email" name="email" placeholder="Enter email address">*@
                            @Html.EditorFor(Function(model) model.Email, New With {.htmlAttributes = New With {.class = "form-control", .placeholder = "Enter email address"}})
                            @Html.ValidationMessageFor(Function(model) model.Email, "", New With {.class = "text-danger"})
                        </div>
                        <div Class="form-group">
                            @*<input type="text" class="form-control" id="subject" name="subject" placeholder="Enter Subject">*@
                            @Html.EditorFor(Function(model) model.Subject, New With {.htmlAttributes = New With {.class = "form-control", .placeholder = "Enter Subject"}})
                            @Html.ValidationMessageFor(Function(model) model.Subject, "", New With {.class = "text-danger"})
                        </div>
                    </div>
                    @<div Class="col-md-6">
                         <div Class="form-group">
                             @*<textarea Class="form-control" name="message" id="message" rows="1" placeholder="Enter Message"></textarea>*@
                             @Html.TextAreaFor(Function(model) model.Message, New With {.htmlAttributes = New With {.class = "form-control", .placeholder = "Enter Message", .rows = "2"}})
                             @Html.ValidationMessageFor(Function(model) model.Message, "", New With {.class = "text-danger"})
                         </div>
                    </div>
                    @<div Class="col-md-12 text-right">
                        <Button type="submit" value="submit" Class="btn submit_btn">Send Message</Button>
                    </div>
                End Using
                @*<form class="row contact_form" action="contact_process.php" method="post" id="contactForm" novalidate="novalidate">
        </form>*@
            </div>
        </div>
    </div>
</section>
<!--================Contact Area =================-->
<!--================Footer Area =================-->
<footer class="footer_area p_120">
    <div class="container">
        <div class="row footer_inner">
            <div class="col-lg-5 col-sm-6">
                <aside class="f_widget ab_widget">
                    <div class="f_title">
                        <h3>About Me</h3>
                    </div>
                    <p>Do you want to be even more successful? Learn to love learning and growth. The more effort you put into improving your skills.</p>
                </aside>
            </div>
            <div class="col-lg-5 col-sm-6">
            </div>
            @*<div class="col-lg-2">
                <aside class="f_widget social_widget">
                    <div class="f_title">
                        <h3>Follow Me</h3>
                    </div>
                    <p>Let us be social</p>
                    <ul class="list">
                        <li><a href="#"><i class="fa fa-facebook"></i></a></li>
                        <li><a href="#"><i class="fa fa-twitter"></i></a></li>
                        <li><a href="#"><i class="fa fa-dribbble"></i></a></li>
                        <li><a href="#"><i class="fa fa-behance"></i></a></li>
                    </ul>
                </aside>
            </div>*@
        </div>
    </div>
</footer>
<!--================End Footer Area =================-->
<!--================Contact Success and Error message Area =================-->
<div id="success" class="modal modal-message fade" role="dialog">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                    <i class="fa fa-close"></i>
                </button>
                <h2>Thank you</h2>
                <p>Your message is successfully sent...</p>
            </div>
        </div>
    </div>
</div>

<!-- Modals error -->

<div id="error" class="modal modal-message fade" role="dialog">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                    <i class="fa fa-close"></i>
                </button>
                <h2>Sorry !</h2>
                <p> Something went wrong </p>
            </div>
        </div>
    </div>
</div>
<!--================End Contact Success and Error message Area =================-->
