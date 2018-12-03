Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports Mvc_App_Crud

Namespace Controllers
    Public Class AlunoController
        Inherits System.Web.Mvc.Controller

        Private db As New EscolaEntities

        ' GET: Aluno
        Function Index() As ActionResult
            Dim alunoes = db.Alunoes.Include(Function(a) a.Assunto).Include(Function(a) a.Departamento)
            Return View(alunoes.ToList())
        End Function

        ' GET: Aluno/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim aluno As Aluno = db.Alunoes.Find(id)
            If IsNothing(aluno) Then
                Return HttpNotFound()
            End If
            Return View(aluno)
        End Function

        ' GET: Aluno/Create
        Function Create() As ActionResult
            ViewBag.AssuntoID = New SelectList(db.Assuntoes, "AssuntoID", "AssuntoInfo")
            ViewBag.DepartamentoID = New SelectList(db.Departamentoes, "DepartamentoID", "DepartamentoNome")
            Return View()
        End Function

        ' POST: Aluno/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="AlunoID,AlunoNome,DepartamentoID,AssuntoID")> ByVal aluno As Aluno) As ActionResult
            If ModelState.IsValid Then
                db.Alunoes.Add(aluno)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.AssuntoID = New SelectList(db.Assuntoes, "AssuntoID", "AssuntoInfo", aluno.AssuntoID)
            ViewBag.DepartamentoID = New SelectList(db.Departamentoes, "DepartamentoID", "DepartamentoNome", aluno.DepartamentoID)
            Return View(aluno)
        End Function

        ' GET: Aluno/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim aluno As Aluno = db.Alunoes.Find(id)
            If IsNothing(aluno) Then
                Return HttpNotFound()
            End If
            ViewBag.AssuntoID = New SelectList(db.Assuntoes, "AssuntoID", "AssuntoInfo", aluno.AssuntoID)
            ViewBag.DepartamentoID = New SelectList(db.Departamentoes, "DepartamentoID", "DepartamentoNome", aluno.DepartamentoID)
            Return View(aluno)
        End Function

        ' POST: Aluno/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="AlunoID,AlunoNome,DepartamentoID,AssuntoID")> ByVal aluno As Aluno) As ActionResult
            If ModelState.IsValid Then
                db.Entry(aluno).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.AssuntoID = New SelectList(db.Assuntoes, "AssuntoID", "AssuntoInfo", aluno.AssuntoID)
            ViewBag.DepartamentoID = New SelectList(db.Departamentoes, "DepartamentoID", "DepartamentoNome", aluno.DepartamentoID)
            Return View(aluno)
        End Function

        ' GET: Aluno/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim aluno As Aluno = db.Alunoes.Find(id)
            If IsNothing(aluno) Then
                Return HttpNotFound()
            End If
            Return View(aluno)
        End Function

        ' POST: Aluno/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim aluno As Aluno = db.Alunoes.Find(id)
            db.Alunoes.Remove(aluno)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
