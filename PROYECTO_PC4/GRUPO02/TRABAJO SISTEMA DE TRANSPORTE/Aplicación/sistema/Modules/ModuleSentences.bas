Attribute VB_Name = "ModuleSentences"
Sub main()
    With Base
        .CursorLocation = adUseClient
        .Open "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & App.Path & "\usuario.mdb;Persist Security Info=False"
        LoginForm.Show
        'MDIFormPrincipal.Show
        'AsientosForm.Show
    End With
End Sub
''tabal usuarios
Sub usuarios()

    With RsUsuarios
        
        If .State = 1 Then .Close
        .Open "select * from Usuarios", Base, adOpenStatic, adLockOptimistic
        
    End With
    
End Sub
'' tabla de buses
Sub Buses()
With RsBuses
    If .State = 1 Then .Close
    .Open "select * from Buses", Base, adOpenStatic, adLockOptimistic
End With
End Sub
''tabla tipo de bus
Sub TipoBus()
    With RsTipobus
        If .State = 1 Then .Close
        .Open "select * from Tipobus", Base, adOpenStatic, adLockOptimistic
    End With
End Sub
''tabla de terminales
Sub Terminales()
    With RsTerminales
        If .State = 1 Then .Close
        .Open "select * from Terminales", Base, adOpenStatic, adLockOptimistic
    End With
End Sub
Sub Salidas()
    With RsSalidas
        If .State = 1 Then .Close
        .Open "select *from Salidas", Base, adOpenStatic, adLockOptimistic
    End With
End Sub
Sub Clientes()
With RsClientes
    If .State = 1 Then .Close
        .Open "select *from Clientes", Base, adOpenStatic, adLockOptimistic
End With
End Sub
Sub Codigo()
With RsCodigo
    If .State = 1 Then .Close
        .Open "select *from Codigo", Base, adOpenStatic, adLockOptimistic
End With
End Sub
Sub Boleto()
With RsBoleto
    If .State = 1 Then .Close
        .Open "select *from Boleto", Base, adOpenStatic, adLockOptimistic
End With
End Sub
