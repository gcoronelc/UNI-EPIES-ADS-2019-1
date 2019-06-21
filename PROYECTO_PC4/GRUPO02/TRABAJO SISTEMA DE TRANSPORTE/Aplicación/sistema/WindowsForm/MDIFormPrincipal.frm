VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.1#0"; "MSCOMCTL.OCX"
Begin VB.MDIForm MDIFormPrincipal 
   BackColor       =   &H80000014&
   Caption         =   "Sistema"
   ClientHeight    =   11520
   ClientLeft      =   225
   ClientTop       =   555
   ClientWidth     =   12615
   Icon            =   "MDIFormPrincipal.frx":0000
   LinkTopic       =   "MDIForm1"
   Picture         =   "MDIFormPrincipal.frx":058A
   StartUpPosition =   1  'CenterOwner
   WindowState     =   2  'Maximized
   Begin MSComctlLib.ImageList ImageList1 
      Left            =   0
      Top             =   1680
      _ExtentX        =   1005
      _ExtentY        =   1005
      BackColor       =   -2147483643
      ImageWidth      =   48
      ImageHeight     =   48
      MaskColor       =   12632256
      _Version        =   393216
      BeginProperty Images {2C247F25-8591-11D1-B16A-00C0F0283628} 
         NumListImages   =   10
         BeginProperty ListImage1 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "MDIFormPrincipal.frx":388F4
            Key             =   ""
         EndProperty
         BeginProperty ListImage2 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "MDIFormPrincipal.frx":3990B
            Key             =   ""
         EndProperty
         BeginProperty ListImage3 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "MDIFormPrincipal.frx":3AC44
            Key             =   ""
         EndProperty
         BeginProperty ListImage4 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "MDIFormPrincipal.frx":3C043
            Key             =   ""
         EndProperty
         BeginProperty ListImage5 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "MDIFormPrincipal.frx":3D192
            Key             =   ""
         EndProperty
         BeginProperty ListImage6 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "MDIFormPrincipal.frx":3E3F5
            Key             =   ""
         EndProperty
         BeginProperty ListImage7 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "MDIFormPrincipal.frx":3F4CB
            Key             =   ""
         EndProperty
         BeginProperty ListImage8 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "MDIFormPrincipal.frx":404A4
            Key             =   ""
         EndProperty
         BeginProperty ListImage9 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "MDIFormPrincipal.frx":413C0
            Key             =   ""
         EndProperty
         BeginProperty ListImage10 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "MDIFormPrincipal.frx":424F9
            Key             =   ""
         EndProperty
      EndProperty
   End
   Begin MSComctlLib.Toolbar Toolbar1 
      Align           =   1  'Align Top
      Height          =   900
      Left            =   0
      TabIndex        =   0
      Top             =   0
      Width           =   12615
      _ExtentX        =   22251
      _ExtentY        =   1588
      ButtonWidth     =   1455
      ButtonHeight    =   1429
      Appearance      =   1
      ImageList       =   "ImageList1"
      _Version        =   393216
      BeginProperty Buttons {66833FE8-8583-11D1-B16A-00C0F0283628} 
         NumButtons      =   11
         BeginProperty Button1 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Object.ToolTipText     =   "Nuevo Usuario"
            ImageIndex      =   1
         EndProperty
         BeginProperty Button2 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Object.ToolTipText     =   "Modificar Usuario"
            ImageIndex      =   9
         EndProperty
         BeginProperty Button3 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Style           =   3
         EndProperty
         BeginProperty Button4 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Object.ToolTipText     =   "Gestor de Buses"
            ImageIndex      =   3
         EndProperty
         BeginProperty Button5 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Style           =   3
         EndProperty
         BeginProperty Button6 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Object.ToolTipText     =   "Gestor de Terminales"
            ImageIndex      =   10
         EndProperty
         BeginProperty Button7 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Style           =   3
         EndProperty
         BeginProperty Button8 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Object.ToolTipText     =   "Consultas y/o Reportes"
            ImageIndex      =   4
         EndProperty
         BeginProperty Button9 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Style           =   3
         EndProperty
         BeginProperty Button10 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Object.ToolTipText     =   "Editor de Buses"
            ImageIndex      =   2
         EndProperty
         BeginProperty Button11 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Object.ToolTipText     =   "Venta de pasajes"
            ImageIndex      =   5
         EndProperty
      EndProperty
   End
   Begin VB.Menu MnuArchivo 
      Caption         =   "Archivo"
      Begin VB.Menu MnuSalir 
         Caption         =   "Salir del Sistema"
      End
   End
   Begin VB.Menu MnuUsuario 
      Caption         =   "Usuario"
      Begin VB.Menu MnuCrearUsuario 
         Caption         =   "Crear Nuevo Usuario"
      End
      Begin VB.Menu g2 
         Caption         =   "-"
      End
      Begin VB.Menu MnuModificar 
         Caption         =   "Modificar Usuario"
      End
      Begin VB.Menu MnuEliminarUsuario 
         Caption         =   "Eliminar Usuario"
      End
      Begin VB.Menu g3 
         Caption         =   "-"
      End
      Begin VB.Menu MnuBuscar 
         Caption         =   "Buscar Usuario"
      End
      Begin VB.Menu g1 
         Caption         =   "-"
      End
   End
   Begin VB.Menu MnuBuses 
      Caption         =   "Buses"
      Begin VB.Menu MnuMantenimientodeBUses 
         Caption         =   "Mantenimiento de Buses"
      End
   End
   Begin VB.Menu Mnuterminales 
      Caption         =   "Terminales"
      Begin VB.Menu MnuGestordeterminales 
         Caption         =   "Gestor de Terminales"
      End
   End
   Begin VB.Menu MnuGestordeboletos 
      Caption         =   "Gestor de Boletos"
      Begin VB.Menu Mnuventadeboletos 
         Caption         =   "Editor de Buses"
      End
      Begin VB.Menu MnuVevtadePasaje 
         Caption         =   "Vender Pasaje"
      End
   End
   Begin VB.Menu MnuConsultas 
      Caption         =   "Consultas"
   End
End
Attribute VB_Name = "MDIFormPrincipal"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Private Sub MDIForm_Load()
usuarios
End Sub

Private Sub MnuBuscar_Click()
Buscar = InputBox("Ingrese el ID de Usuario que desea buscar", "Buscar", "Ingrese el ID de Usuario")
If Buscar = "" Then
    MsgBox "No se ingreso ningun ID de Usuario", vbInformation, "Aviso"
    Exit Sub
    
        Else
            
            With RsUsuarios
            
                .Requery
                .Find "Login='" & Trim(Buscar) & "'"
                If .EOF Then
                MsgBox "No se encontro ningun usuario con el ID: " & Buscar
                
                Exit Sub
                
                Else
                
                MsgBox "¡Usuario Encontrado!" & vbNewLine & " " & vbNewLine & "Id de Usuario: " & Trim(!Login) & vbNewLine & "Propietario: " & Trim(!Nombres) & " " & Trim(!Apellidos) & vbNewLine & "Direccion: " & Trim(!Direccion) & vbNewLine & "Telefono: " & Trim(!Telefono) & vbNewLine & "Fecha de registro: " & Trim(!fecha), vbInformation, "Usuario Encontrado"
                
                
                
                End If
            
            End With
        
        End If
    
End Sub

Private Sub MnuConsultas_Click()
ClientesForm.Show
End Sub

Private Sub MnuCrearUsuario_Click()
CrearUsuariosForm.Show
End Sub

Private Sub MnuEliminarUsuario_Click()

nombreUsuario = InputBox("Ingrese el Nombre de Usuario que Desee Eliminar", "Eliminar", "Ingrese Usuario")

    If nombreUsuario = "" Then
    MsgBox ("Debe ingresar el Nombre de Usuario"), vbInformation, "Aviso"
    Exit Sub
    Else
    With RsUsuarios
    
        .Requery
        .Find "Login='" & Trim(nombreUsuario) & "'"
            'si no encuentra el usuario
        If .EOF Then
        MsgBox "No se encontro ningun Usuario con ese Nombre", vbInformation, "Aviso"
        
        .Requery
        
        Exit Sub
        
        Else
        ''si encontro usuario
        
          If MsgBox("Desea eliminar a:" & nombreUsuario, vbInformation + vbYesNo, "Eliminar") = vbYes Then
          .Delete
          .Requery
          Else
          
             .Requery
             
          End If
          
        End If
    End With
End If
End Sub

Private Sub MnuGestordeterminales_Click()
GestordeTerminalesForm.Show
End Sub

Private Sub MnuMantenimientodeBUses_Click()
MantenimientoBusesForm.Show
End Sub

Private Sub MnuModificar_Click()
ModificarUsuarioForm.Show
End Sub

Private Sub MnuSalir_Click()

    If MsgBox("Desea salir del Sistema", vbInformation + vbYesNo, "Aviso") = vbYes Then
    
        Unload Me

End If
End Sub

Private Sub Mnuventadeboletos_Click()
GestordeBoletosForm.Show
End Sub

Private Sub MnuVevtadePasaje_Click()
AsientosForm.Show
End Sub

Private Sub Toolbar1_ButtonClick(ByVal Button As MSComctlLib.Button)
Select Case Button.Index
    
    Case 1
        CrearUsuariosForm.Show
    Case 2
        ModificarUsuarioForm.Show
    Case 3
        ''separador
    Case 4
        MantenimientoBusesForm.Show
    Case 5
        ''separador
    Case 6
        GestordeTerminalesForm.Show
    Case 7
        ''separador
    Case 8
        ClientesForm.Show
    Case 9
        ''separador
    Case 10
        GestordeBoletosForm.Show
    Case 11
        AsientosForm.Show
    
End Select
End Sub
