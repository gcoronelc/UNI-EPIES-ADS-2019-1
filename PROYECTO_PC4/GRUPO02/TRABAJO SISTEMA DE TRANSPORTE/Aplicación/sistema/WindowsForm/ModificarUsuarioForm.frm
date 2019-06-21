VERSION 5.00
Object = "{86CF1D34-0C5F-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCT2.OCX"
Object = "{CDE57A40-8B86-11D0-B3C6-00A0C90AEA82}#1.0#0"; "MSDATGRD.OCX"
Begin VB.Form ModificarUsuarioForm 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Modificar Usuario"
   ClientHeight    =   10530
   ClientLeft      =   45
   ClientTop       =   375
   ClientWidth     =   9420
   Icon            =   "ModificarUsuarioForm.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   MinButton       =   0   'False
   Picture         =   "ModificarUsuarioForm.frx":058A
   ScaleHeight     =   10530
   ScaleWidth      =   9420
   ShowInTaskbar   =   0   'False
   Begin VB.CommandButton cmdModificar 
      Appearance      =   0  'Flat
      BackColor       =   &H80000012&
      Caption         =   "Modificar Datos"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   11.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   2400
      MaskColor       =   &H00E0E0E0&
      TabIndex        =   9
      Top             =   6975
      Width           =   2055
   End
   Begin VB.CommandButton cmdCancelar 
      Appearance      =   0  'Flat
      Caption         =   "Cancelar"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   11.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   4920
      TabIndex        =   8
      Top             =   6975
      Width           =   1575
   End
   Begin VB.TextBox txtID 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000C&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   390
      Left            =   4080
      TabIndex        =   5
      Top             =   1800
      Width           =   3255
   End
   Begin VB.TextBox txtClave 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000C&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   390
      Left            =   4080
      TabIndex        =   4
      Top             =   2415
      Width           =   3255
   End
   Begin VB.TextBox txtNombre 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000C&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   390
      Left            =   2400
      TabIndex        =   3
      Top             =   3495
      Width           =   4335
   End
   Begin VB.TextBox txtApellido 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000C&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   390
      Left            =   2400
      TabIndex        =   2
      Top             =   4215
      Width           =   4335
   End
   Begin VB.TextBox txtDireccion 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000C&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   390
      Left            =   2400
      TabIndex        =   1
      Top             =   4935
      Width           =   4335
   End
   Begin VB.TextBox txtTelefono 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000C&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   390
      Left            =   2400
      TabIndex        =   0
      Top             =   5655
      Width           =   2895
   End
   Begin MSDataGridLib.DataGrid GridUsuarios 
      Height          =   2535
      Left            =   480
      TabIndex        =   6
      Top             =   7560
      Width           =   8415
      _ExtentX        =   14843
      _ExtentY        =   4471
      _Version        =   393216
      ForeColor       =   -2147483641
      HeadLines       =   1
      RowHeight       =   15
      BeginProperty HeadFont {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Caption         =   "Usuarios"
      ColumnCount     =   2
      BeginProperty Column00 
         DataField       =   ""
         Caption         =   ""
         BeginProperty DataFormat {6D835690-900B-11D0-9484-00A0C91110ED} 
            Type            =   0
            Format          =   ""
            HaveTrueFalseNull=   0
            FirstDayOfWeek  =   0
            FirstWeekOfYear =   0
            LCID            =   10250
            SubFormatType   =   0
         EndProperty
      EndProperty
      BeginProperty Column01 
         DataField       =   ""
         Caption         =   ""
         BeginProperty DataFormat {6D835690-900B-11D0-9484-00A0C91110ED} 
            Type            =   0
            Format          =   ""
            HaveTrueFalseNull=   0
            FirstDayOfWeek  =   0
            FirstWeekOfYear =   0
            LCID            =   10250
            SubFormatType   =   0
         EndProperty
      EndProperty
      SplitCount      =   1
      BeginProperty Split0 
         BeginProperty Column00 
         EndProperty
         BeginProperty Column01 
         EndProperty
      EndProperty
   End
   Begin MSComCtl2.DTPicker DTPFecha 
      Height          =   375
      Left            =   2400
      TabIndex        =   7
      Top             =   6375
      Width           =   2055
      _ExtentX        =   3625
      _ExtentY        =   661
      _Version        =   393216
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      CalendarBackColor=   -2147483637
      Format          =   39976961
      CurrentDate     =   41231
   End
   Begin VB.Label lblId_usuario 
      BackStyle       =   0  'Transparent
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   36
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000B&
      Height          =   855
      Left            =   7440
      TabIndex        =   17
      Top             =   1800
      Width           =   2295
   End
   Begin VB.Label Label1 
      BackStyle       =   0  'Transparent
      Caption         =   " ID de Usuario:"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000B&
      Height          =   375
      Left            =   2280
      TabIndex        =   16
      Top             =   1815
      Width           =   2295
   End
   Begin VB.Label Label2 
      BackStyle       =   0  'Transparent
      Caption         =   "Clave de Usuario:"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000B&
      Height          =   375
      Left            =   1800
      TabIndex        =   15
      Top             =   2415
      Width           =   2175
   End
   Begin VB.Label Label3 
      BackStyle       =   0  'Transparent
      Caption         =   "Nombres:"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000B&
      Height          =   375
      Left            =   960
      TabIndex        =   14
      Top             =   3495
      Width           =   1215
   End
   Begin VB.Label Label4 
      BackStyle       =   0  'Transparent
      Caption         =   "Apellidos:"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000B&
      Height          =   375
      Left            =   960
      TabIndex        =   13
      Top             =   4215
      Width           =   1215
   End
   Begin VB.Label Label5 
      BackStyle       =   0  'Transparent
      Caption         =   "Dirección:"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000B&
      Height          =   375
      Left            =   960
      TabIndex        =   12
      Top             =   4935
      Width           =   1215
   End
   Begin VB.Label Label7 
      BackStyle       =   0  'Transparent
      Caption         =   "Fecha:"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000B&
      Height          =   375
      Left            =   960
      TabIndex        =   11
      Top             =   6375
      Width           =   2295
   End
   Begin VB.Label Label6 
      BackStyle       =   0  'Transparent
      Caption         =   "Telefono:"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000B&
      Height          =   375
      Left            =   960
      TabIndex        =   10
      Top             =   5655
      Width           =   1215
   End
End
Attribute VB_Name = "ModificarUsuarioForm"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim Objeto As New EncriptString
Private Sub cmdCancelar_Click()
Unload Me
End Sub
Private Sub cmdModificar_Click()
If txtID.Text = "" Then MsgBox "El campo ID no puede estar vacio", vbInformation, "Aviso": txtID.SetFocus: Exit Sub
If txtClave.Text = "" Then MsgBox "El campo de CLAVE no uede estar vacio", vbInformation, "Aviso": txtClave.SetFocus: Exit Sub
If txtNombre.Text = "" Then MsgBox "El campo NOMBRES no puede estas vacio", vbInformation, "Aviso": txtNombre.SetFocus: Exit Sub
If txtApellido.Text = "" Then MsgBox "El campo APELLIDOS no puede estas vacio", vbInformation, "Aviso": txtApellido.SetFocus: Exit Sub
If txtDireccion.Text = "" Then MsgBox "El campo DIRECCION no puede estas vacio", vbInformation, "Aviso": txtDireccion.SetFocus: Exit Sub
If txtTelefono.Text = "" Then MsgBox "El campo TELEFONO no puede estas vacio", vbInformation, "Aviso": txtTelefono.SetFocus: Exit Sub

With RsUsuarios
    .Requery
    .Find "Id_usuario='" & Val(lblId_usuario.Caption) & "'"
        !Login = txtID.Text
        !Password = Objeto.Encriptar(txtClave.Text)
        !Nombres = txtNombre.Text
        !Apellidos = txtApellido.Text
        !Direccion = txtDireccion.Text
        !Telefono = txtTelefono.Text
        !fecha = DTPFecha.Value
    .UpdateBatch
    .Requery
    Limpiar
End With
End Sub
Sub Limpiar()
    txtID.Text = ""
    txtClave.Text = ""
    txtNombre.Text = ""
    txtApellido.Text = ""
    txtDireccion.Text = ""
    txtTelefono.Text = ""
    DTPFecha.Value = Date
    GrillaUsuario
End Sub
Private Sub Form_Load()
 usuarios
    Set GridUsuarios.DataSource = RsUsuarios
    Set Objeto = New EncriptString
    Limpiar
End Sub
Private Sub GridUsuarios_Click()
    With RsUsuarios
        If .BOF Or .EOF Then Exit Sub
        lblId_usuario.Caption = !Id_usuario
        .Find "Id_usuario='" & Val(GridUsuarios.Columns(0).Text) & "'"
        txtID.Text = !Login
        txtClave.Text = !Password
        txtNombre.Text = !Nombres
        txtApellido.Text = !Apellidos
        txtDireccion.Text = !Direccion
        txtTelefono.Text = !Telefono
        DTPFecha.Value = !fecha
    End With
End Sub
Sub GrillaUsuario()
GridUsuarios.Columns(0).Width = 0
GridUsuarios.Columns(1).Width = 2000
GridUsuarios.Columns(2).Width = 0
GridUsuarios.Columns(3).Width = 2000
GridUsuarios.Columns(4).Width = 2000
GridUsuarios.Columns(5).Width = 0
GridUsuarios.Columns(6).Width = 0
GridUsuarios.Columns(7).Width = 0
GridUsuarios.Columns(8).Width = 0
End Sub
