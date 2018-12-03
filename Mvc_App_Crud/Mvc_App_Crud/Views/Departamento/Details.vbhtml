﻿@ModelType Mvc_App_Crud.Departamento
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Departamento</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.DepartamentoNome)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.DepartamentoNome)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.DepartamentoID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
