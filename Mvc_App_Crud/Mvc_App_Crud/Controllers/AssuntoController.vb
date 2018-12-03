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
    Public Class AssuntoController
        Inherits System.Web.Mvc.Controller

        Private db As New EscolaEntities

        ' GET: Assunto
        Function Index() As ActionResult
            Return View(db.Assuntoes.ToList())
        End Function

        ' GET: Assunto/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim assunto As Assunto = db.Assuntoes.Find(id)
            If IsNothing(assunto) Then
                Return HttpNotFound()
            End If
            Return View(assunto)
        End Function

        ' GET: Assunto/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Assunto/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="AssuntoID,AssuntoInfo")> ByVal assunto As Assunto) As ActionResult
            If ModelState.IsValid Then
                db.Assuntoes.Add(assunto)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(assunto)
        End Function

        ' GET: Assunto/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim assunto As Assunto = db.Assuntoes.Find(id)
            If IsNothing(assunto) Then
                Return HttpNotFound()
            End If
            Return View(assunto)
        End Function

        ' POST: Assunto/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="AssuntoID,AssuntoInfo")> ByVal assunto As Assunto) As ActionResult
            If ModelState.IsValid Then
                db.Entry(assunto).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(assunto)
        End Function

        ' GET: Assunto/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim assunto As Assunto = db.Assuntoes.Find(id)
            If IsNothing(assunto) Then
                Return HttpNotFound()
            End If
            Return View(assunto)
        End Function

        ' POST: Assunto/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim assunto As Assunto = db.Assuntoes.Find(id)
            db.Assuntoes.Remove(assunto)
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
