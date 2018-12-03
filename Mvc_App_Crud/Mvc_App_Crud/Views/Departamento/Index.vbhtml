@ModelType IEnumerable(Of Mvc_App_Crud.Departamento)
@Code
    ViewData("Title") = "Departamentos"
End Code

<h2>Departamentos</h2>

<p>
    @Html.ActionLink("Novo", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.DepartamentoNome)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.DepartamentoNome)
        </td>
        <td>
            @Html.ActionLink("Editar", "Edit", New With {.id = item.DepartamentoID}) |
            @Html.ActionLink("Detalhes", "Details", New With {.id = item.DepartamentoID}) |
            @Html.ActionLink("Deletar", "Delete", New With {.id = item.DepartamentoID})
        </td>
    </tr>
Next

</table>
