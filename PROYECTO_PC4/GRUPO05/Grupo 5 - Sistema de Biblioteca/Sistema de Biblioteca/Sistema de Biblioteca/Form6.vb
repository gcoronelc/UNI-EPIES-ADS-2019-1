Public Class Form6

    Private Sub AUTORSBBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AUTORSBBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SISTBIBLIOTECADataSet)

    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SISTBIBLIOTECADataSet.LIBROSSB' Puede moverla o quitarla según sea necesario.
        Me.LIBROSSBTableAdapter.Fill(Me.SISTBIBLIOTECADataSet.LIBROSSB)
        'TODO: esta línea de código carga datos en la tabla 'SISTBIBLIOTECADataSet.AUTORSB' Puede moverla o quitarla según sea necesario.
        Me.AUTORSBTableAdapter.Fill(Me.SISTBIBLIOTECADataSet.AUTORSB)
        'TODO: esta línea de código carga datos en la tabla 'SISTBIBLIOTECADataSet.PRESTAMOSB' Puede moverla o quitarla según sea necesario.
        Me.PRESTAMOSBTableAdapter.Fill(Me.SISTBIBLIOTECADataSet.PRESTAMOSB)
        'TODO: esta línea de código carga datos en la tabla 'SISTBIBLIOTECADataSet.AUTORSB' Puede moverla o quitarla según sea necesario.
        Me.AUTORSBTableAdapter.Fill(Me.SISTBIBLIOTECADataSet.AUTORSB)

    End Sub

    Private Sub PRESTAMOSBBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PRESTAMOSBBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PRESTAMOSBBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SISTBIBLIOTECADataSet)

    End Sub
End Class