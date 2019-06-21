VERSION 5.00
Object = "{CDE57A40-8B86-11D0-B3C6-00A0C90AEA82}#1.0#0"; "MSDATGRD.OCX"
Begin VB.Form CrearUsuariosForm 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Crear Nuevas Cuentas de Usuarios"
   ClientHeight    =   9420
   ClientLeft      =   45
   ClientTop       =   375
   ClientWidth     =   9420
   Icon            =   "CrearUsuariosForm.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   MinButton       =   0   'False
   Picture         =   "CrearUsuariosForm.frx":058A
   ScaleHeight     =   9420
   ScaleWidth      =   9420
   ShowInTaskbar   =   0   'False
   Begin VB.Timer Timer1 
      Interval        =   1
      Left            =   360
      Top             =   1440
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
      TabIndex        =   15
      Top             =   4920
      Width           =   2895
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
      TabIndex        =   14
      Top             =   4440
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
      TabIndex        =   13
      Top             =   3960
      Width           =   4335
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
      TabIndex        =   12
      Top             =   3480
      Width           =   4335
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
      IMEMode         =   3  'DISABLE
      Left            =   4080
      PasswordChar    =   "°"
      TabIndex        =   11
      Top             =   2400
      Width           =   3255
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
      TabIndex        =   10
      Top             =   1785
      Width           =   3255
   End
   Begin MSDataGridLib.DataGrid GridUsuarios 
      Height          =   2535
      Left            =   480
      TabIndex        =   9
      Top             =   6600
      Width           =   8535
      _ExtentX        =   15055
      _ExtentY        =   4471
      _Version        =   393216
      ForeColor       =   -2147483641
      HeadLines       =   1
      RowHeight       =   21
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
      Left            =   4080
      TabIndex        =   8
      Top             =   6000
      Width           =   1575
   End
   Begin VB.CommandButton cmdCrear 
      Appearance      =   0  'Flat
      BackColor       =   &H80000012&
      Caption         =   "Crear Cuenta"
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
      TabIndex        =   7
      Top             =   6000
      Width           =   1575
   End
   Begin VB.Shape Shape2 
      BackStyle       =   1  'Opaque
      Height          =   2775
      Left            =   360
      Top             =   6480
      Width           =   8775
   End
   Begin VB.Label LabelFecha 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "Fecha"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   18
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   2400
      TabIndex        =   16
      Top             =   5400
      Width           =   2295
   End
   Begin VB.Label Label6 
      Alignment       =   1  'Right Justify
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
      Left            =   1080
      TabIndex        =   5
      Top             =   4920
      Width           =   1215
   End
   Begin VB.Label Label7 
      Alignment       =   1  'Right Justify
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
      Left            =   1080
      TabIndex        =   6
      Top             =   5400
      Width           =   1215
   End
   Begin VB.Label Label5 
      Alignment       =   1  'Right Justify
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
      Left            =   1080
      TabIndex        =   4
      Top             =   4440
      Width           =   1215
   End
   Begin VB.Label Label4 
      Alignment       =   1  'Right Justify
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
      Left            =   1080
      TabIndex        =   3
      Top             =   3960
      Width           =   1215
   End
   Begin VB.Label Label3 
      Alignment       =   1  'Right Justify
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
      Left            =   1080
      TabIndex        =   2
      Top             =   3480
      Width           =   1215
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
      Left            =   1920
      TabIndex        =   1
      Top             =   2400
      Width           =   2175
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
      TabIndex        =   0
      Top             =   1800
      Width           =   2295
   End
   Begin VB.Shape Shape1 
      BackStyle       =   1  'Opaque
      Height          =   495
      Left            =   2400
      Top             =   5400
      Width           =   2295
   End
   Begin VB.Label LabelHora 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "Hora"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   4800
      TabIndex        =   17
      Top             =   5400
      Width           =   2295
   End
   Begin VB.Shape Shape3 
      BackStyle       =   1  'Opaque
      Height          =   375
      Left            =   4800
      Top             =   5400
      Width           =   2295
   End
End
Attribute VB_Name = "CrearUsuariosForm"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim Objeto As EncriptString
Private Sub cmdCancelar_Click()
Unload Me
End Sub

Private Sub cmdCrear_Click()
If txtID.Text = "" Then MsgBox "El campo ID no puede estar vacio", vbInformation, "Aviso": txtID.SetFocus: Exit Sub
If txtClave.Text = "" Then MsgBox "El campo de CLAVE no uede estar vacio", vbInformation, "Aviso": txtClave.SetFocus: Exit Sub
If txtNombre.Text = "" Then MsgBox "El campo NOMBRES no puede estas vacio", vbInformation, "Aviso": txtNombre.SetFocus: Exit Sub
If txtApellido.Text = "" Then MsgBox "El campo APELLIDOS no puede estas vacio", vbInformation, "Aviso": txtApellido.SetFocus: Exit Sub
If txtDireccion.Text = "" Then MsgBox "El campo DIRECCION no puede estas vacio", vbInformation, "Aviso": txtDireccion.SetFocus: Exit Sub
If txtTelefono.Text = "" Then MsgBox "El campo TELEFONO no puede estas vacio", vbInformation, "Aviso": txtTelefono.SetFocus: Exit Sub
With RsUsuarios
    .Requery
    .Find "Login='" & Trim(txtID.Text) & "'"
    If .BOF Or .EOF Then
    .AddNew
        !Login = txtID.Text
        !Password = Objeto.Encriptar(txtClave.Text)
        !Nombres = txtNombre.Text
        !Apellidos = txtApellido.Text
        !Direccion = txtDireccion.Text
        !Telefono = txtTelefono.Text
        !fecha = LabelFecha.Caption
        !Hora = LabelHora.Caption
    .Update
    .Requery
    MsgBox "El nuevo USUARIO ha sido grabado de forma satisfactoria", vbInformation, "Aviso"
    Limpiar
    GrillaUsuario
        Else
            MsgBox "Ya existe un Usuario con ese misno ID de usuario, debe de elegir otro ID de usuario", vbCritical, "Elija otro ID de usuario"
            txtID.Text = ""
            txtID.SetFocus
            GrillaUsuario
        Exit Sub
    End If
    
End With
End Sub
Sub Limpiar()
    txtID.Text = ""
    txtClave.Text = ""
    txtNombre.Text = ""
    txtApellido.Text = ""
    txtDireccion.Text = ""
    txtTelefono.Text = ""
End Sub


Private Sub Form_Load()

    usuarios
        Set Objeto = New EncriptString
        Set GridUsuarios.DataSource = RsUsuarios
        GrillaUsuario
        Limpiar
End Sub

Private Sub GridUsuarios_Click()
GrillaUsuario
End Sub

Private Sub Timer1_Timer()
LabelFecha.Caption = Date
LabelHora.Caption = Time
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
