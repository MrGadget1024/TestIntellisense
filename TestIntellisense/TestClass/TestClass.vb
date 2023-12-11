Imports System.ComponentModel

Public Class TestClass

	Public Property VisibleProperty As String

	Public Sub VisibleMethod()
	End Sub

	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Property HiddenProperty As String

	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Sub HiddenMethod()
	End Sub

End Class
