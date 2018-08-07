@using (Html.BeginForm())
{
    <p>
        Find by name or location: @Html.TextBox("SearchString")
        <input type="submit" value="Search" />
    </p>
}