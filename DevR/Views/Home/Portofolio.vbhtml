@ModelType List(Of ListPortofolio)
@Code
    ViewData("Title") = "Portofolio"
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
            <h2>List Portofolio</h2>
        </div>
        <table class="table table-hover">
            <thead>
                <tr>
                    <th scope="col">@Html.DisplayNameFor(Function(model) model(0).No)</th>
                    <th scope="col">@Html.DisplayNameFor(Function(model) model(0).NameProject)</th>
                    <th scope="col">@Html.DisplayNameFor(Function(model) model(0).Program)</th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
                @For Each item In Model
                    @<tr>
                        <td>@Html.DisplayFor(Function(x) item.No)</td>
                        <td>@Html.DisplayFor(Function(x) item.NameProject)</td>
                        <td>@Html.DisplayFor(Function(x) item.Program)</td>
                        <td>
                            <button onclick="window.location.href='@Url.Action(item.View)'" type="button" class="btn btn-primary">View</button>
                        </td>
                    </tr>
                Next
            </tbody>
        </table>
    </div>
</section>
<!--================End Feature Area =================-->
