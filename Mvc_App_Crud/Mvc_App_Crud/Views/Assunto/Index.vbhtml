@ModelType IEnumerable(Of Mvc_App_Crud.Assunto)
@Code
    ViewData("Title") = "Assuntos"
End Code

<h2>Assuntos</h2>

<p>
    @Html.ActionLink("Novo", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.AssuntoInfo)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.AssuntoInfo)
        </td>
        <td>
            @Html.ActionLink("Edita", "Edit", New With {.id = item.AssuntoID}) |
            @Html.ActionLink("Detalhes", "Details", New With {.id = item.AssuntoID}) |
            @Html.ActionLink("Deletar", "Delete", New With {.id = item.AssuntoID})
        </td>
    </tr>
Next

</table>
