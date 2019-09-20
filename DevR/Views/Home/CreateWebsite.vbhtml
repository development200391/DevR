
@Code
    ViewData("Title") = "Create Website"
End Code


<!--================Home Banner Area =================-->
<section class="banner_area">
    <div class="banner_inner d-flex align-items-center">
        <div class="overlay bg-parallax" data-stellar-ratio="0.9" data-stellar-vertical-offset="0" data-background=""></div>
        <div class="container">
            <div class="banner_content text-center">
                <h2>@ViewData("Title")</h2>
                <div class="page_link">
                    <a href="@Url.Action("Index")">Home</a>
                    <a>@ViewData("Title")</a>
                </div>

            </div>
        </div>
    </div>
</section>
<!--================End Home Banner Area =================-->
<!--================Feature Area =================-->
<section class="feature_area feature_tow p_120">
    <div class="container">
        <div class="main_title">
            <h2>Templates</h2>
            <p>Below are a few examples of websites, of course, can be adjusted to the request.</p>
        </div>
        <div class="row">
            <div class="col-lg-4">
                <Button onclick="location.href='https://w3layouts.com/admin-templates/'" Class="form-control btn-info">Admin Templates</Button>
                <br />
                <Button type="button" onclick="location.href='https://w3layouts.com/business/agriculture/'" Class="form-control btn-info">Agriculture</Button>
                <br />
                <Button type="button" onclick="location.href='https://w3layouts.com/animals-pets/'" Class="form-control btn-info">Animals & Pets</Button>
                <br />
                <Button type="button" onclick="location.href='https://w3layouts.com/autos-transportation/'" Class="form-control btn-info">Autos & Transportation</Button>
                <br />
                <Button type="button" onclick="location.href='https://w3layouts.com/basic-template-set/'" Class="form-control btn-info">Basic Templates</Button>
                <br />
                <Button type="button" onclick="location.href='https://w3layouts.com/beauty-and-spa/'" Class="form-control btn-info">Beauty and Spa</Button>
                <br />
                <Button type="button" onclick="location.href='https://w3layouts.com/blog/'" Class="form-control btn-info">Blog</Button>
                <br />
                <Button type="button" onclick="location.href='https://w3layouts.com/blogging-template/'" Class="form-control btn-info">Blogging Template</Button>
                <br />
                <Button type="button" onclick="location.href='https://w3layouts.com/business/'" Class="form-control btn-info">Business</Button>
                <br />
                <Button type="button" onclick="location.href='https://w3layouts.com/classifieds-ads-website-templates/'" Class="form-control btn-info">Classifieds Ads</Button>
                <br />
                <Button type="button" onclick="location.href='https://w3layouts.com/community/'" Class="form-control btn-info">Community</Button>
            </div>
            <div class="col-lg-4">
                <Button type="button" onclick="location.href='https://w3layouts.com/corporate-web-templates/'" Class="form-control btn-info">Corporate Business</Button>
                <br />
                <Button type="button" onclick="location.href='https://w3layouts.com/ecommerce-online-shopping-mobile-website-templates/'" Class="form-control btn-info">Ecommerce Online Shopping</Button>
                <br />
                <Button type="button" onclick="location.href='https://w3layouts.com/education/'" Class="form-control btn-info">Education School</Button>
                <br />
                <Button type="button" onclick="location.href='https://w3layouts.com/email-templates/'" Class="form-control btn-info">Email Template</Button>
                <br />
                <Button type="button" onclick="location.href='https://w3layouts.com/entertainment/'" Class="form-control btn-info">Entertaiment</Button>
                <br />
                <Button type="button" onclick="location.href='https://w3layouts.com/exterior-designs/'" Class="form-control btn-info">Exterior Designs</Button>
                <br />
                <Button type="button" onclick="location.href='https://w3layouts.com/fashion/'" Class="form-control btn-info">Fashion</Button>
                <br />
                <Button type="button" onclick="location.href='https://w3layouts.com/games/'" Class="form-control btn-info">Games</Button>
                <br />
                <Button type="button" onclick="location.href='https://w3layouts.com/home-maintenance-service/'" Class="form-control btn-info">Home Maintenance & Service</Button>
                <br />
                <Button type="button" onclick="location.href='https://w3layouts.com/hotels-and-restaurants/'" Class="form-control btn-info">Hotels and Restaurants</Button>
                <br />
                <Button type="button" onclick="location.href='https://w3layouts.com/human-resource-management/'" Class="form-control btn-info">Human Resource Management</Button>
                <br />
                <Button type="button" onclick="location.href='https://w3layouts.com/industrial-web-and-mobile-templates/'" Class="form-control btn-info">Industrial</Button>
            </div>
            <div class="col-lg-4">
                <Button type="button" onclick="location.href='https://w3layouts.com/interior-and-furniture/'" Class="form-control btn-info">Interior and Fureniture</Button>
                <br />
                <Button type="button" onclick="location.href='https://w3layouts.com/laundry/'" Class="form-control btn-info">Laundry</Button>
                <br />
                <Button type="button" onclick="location.href='https://w3layouts.com/medical/'" Class="form-control btn-info">Medical Hospital</Button>
                <br />
                <Button type="button" onclick="location.href='https://w3layouts.com/mobile-application-templates/'" Class="form-control btn-info">Mobile App Templates</Button>
                <br />
                <Button type="button" onclick="location.href='https://w3layouts.com/banking/'" Class="form-control btn-info">Net Banking</Button>
                <br />
                <Button type="button" onclick="location.href='https://w3layouts.com/personal/'" Class="form-control btn-info">Personal Websites</Button>
                <br />
                <Button type="button" onclick="location.href='https://w3layouts.com/gallery-templates/'" Class="form-control btn-info">Photo Galery Templates</Button>
                <br />
                <Button type="button" onclick="location.href='https://w3layouts.com/builders-and-real-estates/'" Class="form-control btn-info">Real Estates & Builders</Button>
                <br />
                <Button type="button" onclick="location.href='https://w3layouts.com/society-people/'" Class="form-control btn-info">Society & People</Button>
                <br />
                <Button type="button" onclick="location.href='https://w3layouts.com/sports/'" Class="form-control btn-info">Sports</Button>
                <br />
                <Button type="button" onclick="location.href='https://w3layouts.com/travel/'" Class="form-control btn-info">Travel Agency</Button>
                <br />
                <Button type="button" onclick="location.href='https://w3layouts.com/ui-kits/'" Class="form-control btn-info">Ui Kits</Button>
                <br />
                <Button type="button" onclick="location.href='https://w3layouts.com/uncategorized/'" Class="form-control btn-info">Uncategorized</Button>
                <br />
                <Button type="button" onclick="location.href='https://w3layouts.com/under-construction-template/'" Class="form-control btn-info">Under Construction Template</Button>
                <br />
                <Button type="button" onclick="location.href='https://w3layouts.com/video-background-templates/'" Class="form-control btn-info">Video Beckground Template</Button>
                <br />
                <Button type="button" onclick="location.href='https://w3layouts.com/video-content-portal/'" Class="form-control btn-info">Video Content Portal</Button>
                <br />
                <Button type="button" onclick="location.href='https://w3layouts.com/free-web-elements/'" Class="form-control btn-info">Web Elements</Button>
                <br />
                <Button type="button" onclick="location.href='https://w3layouts.com/web-hosting-and-domain-templates/'" Class="form-control btn-info">Web Hosting Templates</Button>
                <br />
                <Button type="button" onclick="location.href='https://w3layouts.com/wedding/'" Class="form-control btn-info">Wedding</Button>
                <br />
                <Button type="button" onclick="location.href='https://wpmthemes.com/'" Class="form-control btn-info">WordPress Mobile</Button>
                <br />
                <Button type="button" onclick="location.href='https://w3layouts.com/free-responsive-html5-css3-website-templates/'" Class="form-control btn-info">Responsive Templates</Button>
            </div>
        </div>


    </div>
</section>
<!--================End Feature Area =================-->
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
