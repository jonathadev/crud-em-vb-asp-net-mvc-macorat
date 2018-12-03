@ModelType Mvc_App_Crud.Assunto
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Assunto</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.AssuntoInfo)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.AssuntoInfo)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.AssuntoID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
