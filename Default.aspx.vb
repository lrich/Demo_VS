
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Response.Write("hiya World!")

    End Sub

    Public Sub ProcessStuff()
        While 1
            Response.Write("Loop")
        End While
    End Sub
End Class
