Module Module1

	Sub Main()
		Dim test As New TestClass.TestClass

		' This property should be visible in the IDE
		test.VisibleProperty = "Visible"

		' This method should be visible in the IDE
		test.VisibleMethod()

		' This property should be hidden in the IDE
		test.HiddenProperty = "Hidden"

		' This method should be hidden in the IDE
		test.HiddenMethod()

	End Sub

End Module
