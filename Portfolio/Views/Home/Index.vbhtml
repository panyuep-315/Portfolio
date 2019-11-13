@Code
    ViewData("Title") = "Home Page"
End Code

<div class="jumbotron">
    <h1>Welcome!</h1>
    <p class="lead">You have found Will Pan's ePortfolio.</p>
    <p>Here you can learn everything about me.</p>
    <ul>
        Check out my
        <li>@Html.ActionLink("Work Experiences", "Work", "Home")</li>
        <li>@Html.ActionLink("Projects", "Project", "Home")</li>
    </ul>
    
</div>

