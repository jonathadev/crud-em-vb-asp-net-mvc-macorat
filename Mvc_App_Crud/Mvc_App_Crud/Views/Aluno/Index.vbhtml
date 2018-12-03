@ModelType IEnumerable(Of Mvc_App_Crud.Aluno)
@Code
    ViewData("Title") = "Alunos"
End Code

<h2>Alunos</h2>

<p>
    @Html.ActionLink("Novo", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.AlunoNome)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Assunto.AssuntoInfo)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Departamento.DepartamentoNome)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.AlunoNome)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Assunto.AssuntoInfo)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Departamento.DepartamentoNome)
        </td>
        <td>
            @Html.ActionLink("Editar", "Edit", New With {.id = item.AlunoID}) |
            @Html.ActionLink("Detalhes", "Details", New With {.id = item.AlunoID}) |
            @Html.ActionLink("Deletar", "Delete", New With {.id = item.AlunoID})
        </td>
    </tr>
Next

</table>
