@Code
    ViewData("Title") = "Leasing Vehicle"
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
                    Applicaton for lease vehicle, contains the Calculation, Quotation, Application and Contract modules, below is an overview of appliaksi.
                </p>
            </div>
        </div>
        <div class="row">
            <dim class="col-md-12 form-group">
                <h2>Login</h2>
            </dim>
            <dim class="col-md-12 form-group">
                <img src="@Url.Action("LeasingVehicle", "img")/login.jpg" alt="Login" class="img-thumbnail">
            </dim>
            <br />
            <dim class="col-md-12 form-group">
                <h2>Dashboard</h2>
            </dim>
            <dim class="col-md-12 form-group">
                <img src="@Url.Action("LeasingVehicle", "img")/Dashboard.png" alt="Dashboard" class="img-thumbnail">
            </dim>
            <br />
            <dim class="col-md-12 form-group">
                <h2>Transaction Prospect Customer</h2>
            </dim>
            <dim class="col-md-12 form-group">
                <img src="@Url.Action("LeasingVehicle", "img")/ProsCust.png" alt="Transaction Prospect Customer" class="img-thumbnail">
            </dim>
            <br />
            <dim class="col-md-12 form-group">
                <h2>Transaction Calculation</h2>
            </dim>
            <dim class="col-md-12 form-group">
                <img src="@Url.Action("LeasingVehicle", "img")/Calculation.png" alt="Transaction Calculation" class="img-thumbnail">
            </dim>
            <dim class="col-md-12 form-group">
                <img src="@Url.Action("LeasingVehicle", "img")/Calculation2.png" alt="Transaction Calculation 2" class="img-thumbnail">
            </dim>
            <br />
            <dim class="col-md-12 form-group">
                <h2>Transaction Quotation</h2>
            </dim>
            <dim class="col-md-12 form-group">
                <img src="@Url.Action("LeasingVehicle", "img")/Quotation.png" alt="Transaction Quotation" class="img-thumbnail">
            </dim>
            <br />
            <dim class="col-md-12 form-group">
                <h2>Transaction Approval Quotation</h2>
            </dim>
            <dim class="col-md-12 form-group">
                <img src="@Url.Action("LeasingVehicle", "img")/Approval.png" alt="Transaction Approval Quotation" class="img-thumbnail">
            </dim>
            <br />
            <dim class="col-md-12 form-group">
                <h2>Printout Quotation</h2>
            </dim>
            <dim class="col-md-12 form-group">
                <img src="@Url.Action("LeasingVehicle", "img")/QuotationProntut.png" alt="Printout Quotation" class="img-thumbnail">
            </dim>
            <br />
            <dim class="col-md-12 form-group">
                <h2>Upload SPH and PO</h2>
            </dim>
            <dim class="col-md-12 form-group">
                <img src="@Url.Action("LeasingVehicle", "img")/UploadSPH.png" alt="Upload SPH and PO" class="img-thumbnail">
            </dim>
            <br />
            <dim class="col-md-12 form-group">
                <h2>Transaction Application PO</h2>
            </dim>
            <dim class="col-md-12 form-group">
                <img src="@Url.Action("LeasingVehicle", "img")/ApplicationPO.png" alt="Transaction Application PO" class="img-thumbnail">
            </dim>
            <br />
            <dim class="col-md-12 form-group">
                <h2>Transaction Approval Application PO</h2>
            </dim>
            <dim class="col-md-12 form-group">
                <img src="@Url.Action("LeasingVehicle", "img")/ApprovalPO.png" alt="Transaction Approval Application PO" class="img-thumbnail">
            </dim>
            <br />
            <dim class="col-md-12 form-group">
                <h2>Transaction Application</h2>
            </dim>
            <dim class="col-md-12 form-group">
                <img src="@Url.Action("LeasingVehicle", "img")/Application.png" alt="Transaction Application" class="img-thumbnail">
            </dim>            <br />
            <dim class="col-md-12 form-group">
                <img src="@Url.Action("LeasingVehicle", "img")/Applicaton2.png" alt="Transaction Application" class="img-thumbnail">
            </dim>            
        </div>

    </div>
</section>
<!--================End Feature Area =================-->
