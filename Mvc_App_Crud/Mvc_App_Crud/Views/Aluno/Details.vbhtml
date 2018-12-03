@ModelType Mvc_App_Crud.Aluno
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Aluno</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.AlunoNome)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.AlunoNome)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Assunto.AssuntoInfo)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Assunto.AssuntoInfo)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Departamento.DepartamentoNome)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Departamento.DepartamentoNome)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.AlunoID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
