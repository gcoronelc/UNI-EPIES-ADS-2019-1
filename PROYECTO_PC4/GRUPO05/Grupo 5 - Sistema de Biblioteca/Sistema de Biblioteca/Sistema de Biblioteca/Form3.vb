Public Class Form3

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub USUARIOSBBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.USUARIOSBBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SISTBIBLIOTECADataSet)

    End Sub

    Private Sub USUARIOSBBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.USUARIOSBBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SISTBIBLIOTECADataSet)

    End Sub
End Class