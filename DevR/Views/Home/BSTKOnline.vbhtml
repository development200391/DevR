@Code
    ViewData("Title") = "BSTK Online"
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
                    <a href="@Url.Action("Portofolio")">Portofolio</a>
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
            <div class="form-group">
                <h2>Description</h2>
                <p>
                    BSTK(Bukti serah terima kendaraan), with the get picture from camera, signature, and save to Data Base feature.
                </p>
            </div>
        </div>
        <div class="row">
            <dim class="col-md-6 form-group">
                <h2>Login</h2>
                <img width="400" src="@Url.Action("BSTK", "img")/Login.png" alt="Login" class="img-thumbnail">
            </dim>
            <dim class="col-md-6 form-group">
                <h2>Menu</h2>
                <img width="400" src="@Url.Action("BSTK", "img")/Menu.png" alt="Menu" class="img-thumbnail">
            </dim>
            <br />
            <dim class="col-md-6 form-group">
                <h2>Input BSTK</h2>
                <img width="400" src="@Url.Action("BSTK", "img")/InputBSTK.png" alt="Input BSTK" class="img-thumbnail">
            </dim>
            <dim class="col-md-6 form-group">
                <h2>Input BSTK Checked</h2>
                <img width="400" src="@Url.Action("BSTK", "img")/InputBSTKChecked.png" alt="Input BSTK Checked" class="img-thumbnail">
            </dim>
            <br />
            <dim class="col-md-6 form-group">
                <h2>Input BSTK Fill Apear</h2>
                <img width="400" src="@Url.Action("BSTK", "img")/InputBSTKFillApear.png" alt="InputBSTKFillApear" class="img-thumbnail">
            </dim>
            <dim class="col-md-6 form-group">
                <h2>Get Picture</h2>
                <img width="400" src="@Url.Action("BSTK", "img")/GetPicture.png" alt="Get Picture" class="img-thumbnail">
            </dim>
            <br />
            <dim class="col-md-6 form-group">
                <h2>Signature</h2>
                <img width="400" src="@Url.Action("BSTK", "img")/Signature.png" alt="Signature" class="img-thumbnail">
            </dim>
            <dim class="col-md-6 form-group">
                <h2>List BSTK</h2>
                <img width="400" src="@Url.Action("BSTK", "img")/ListBSTK.png" alt="List BSTK" class="img-thumbnail">
            </dim>
        </div>

    </div>
</section>
<!--================End Feature Area =================-->
