VERSION 5.00
Begin VB.Form LoginForm 
   BackColor       =   &H80000012&
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "BIENVENIDO AL SISTEMA"
   ClientHeight    =   2550
   ClientLeft      =   45
   ClientTop       =   375
   ClientWidth     =   7200
   DrawMode        =   1  'Blackness
   FillStyle       =   6  'Cross
   BeginProperty Font 
      Name            =   "MS Sans Serif"
      Size            =   9.75
      Charset         =   0
      Weight          =   700
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   FontTransparent =   0   'False
   Icon            =   "LoginForm.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   Picture         =   "LoginForm.frx":058A
   ScaleHeight     =   2550
   ScaleWidth      =   7200
   ShowInTaskbar   =   0   'False
   StartUpPosition =   1  'CenterOwner
   Begin VB.PictureBox Picture1 
      BackColor       =   &H80000005&
      BorderStyle     =   0  'None
      DragIcon        =   "LoginForm.frx":E7B0
      FontTransparent =   0   'False
      Height          =   2055
      Left            =   240
      Picture         =   "LoginForm.frx":2529F
      ScaleHeight     =   2055
      ScaleWidth      =   2055
      TabIndex        =   6
      Top             =   240
      Width           =   2055
   End
   Begin VB.CommandButton cmdCerrar 
      BackColor       =   &H8000000C&
      Caption         =   "Cerrar"
      DownPicture     =   "LoginForm.frx":290B6
      Height          =   375
      Left            =   2640
      MaskColor       =   &H00404040&
      Picture         =   "LoginForm.frx":372DC
      TabIndex        =   5
      Top             =   1800
      Width           =   1575
   End
   Begin VB.CommandButton cmdOk 
      BackColor       =   &H8000000C&
      Caption         =   "Ingresar"
      DownPicture     =   "LoginForm.frx":4DDCB
      Height          =   375
      Left            =   4560
      MaskColor       =   &H00404040&
      Picture         =   "LoginForm.frx":5BFF1
      TabIndex        =   4
      Top             =   1800
      Width           =   1575
   End
   Begin VB.TextBox txtpass 
      BackColor       =   &H80000000&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   405
      IMEMode         =   3  'DISABLE
      Left            =   3960
      PasswordChar    =   "*"
      TabIndex        =   1
      Top             =   1080
      Width           =   2775
   End
   Begin VB.TextBox txtuser 
      BackColor       =   &H80000000&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   405
      Left            =   3960
      TabIndex        =   0
      Top             =   360
      Width           =   2775
   End
   Begin VB.Label Label2 
      BackStyle       =   0  'Transparent
      Caption         =   "Contraseña:"
      Height          =   240
      Left            =   2520
      TabIndex        =   3
      Top             =   1080
      Width           =   1245
   End
   Begin VB.Label Label1 
      BackStyle       =   0  'Transparent
      Caption         =   "Usuario:"
      Height          =   255
      Left            =   2520
      TabIndex        =   2
      Top             =   360
      Width           =   975
   End
End
Attribute VB_Name = "LoginForm"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim Objeto As New EncriptString
Private Sub cmdCerrar_Click()
Unload Me
End Sub

Private Sub cmdOk_Click()
If txtuser.Text = "" Then MsgBox "Ingrese nombre de Usuario", vbInformation, "Aviso": txtuser.SetFocus: Exit Sub
If txtpass.Text = "" Then MsgBox "Ingrese su Contraseña", vbInformation, "Aviso": txtpass.SetFocus: Exit Sub
With RsUsuarios
    .Requery  ' actualizo l a tabla
    .Find "Login='" & Trim(txtuser.Text) & "'"   'comparando Login con txtuser
    If .EOF Then   ' si no encuantra nada
        MsgBox "Usuario Incorrecto", vbInformation, "Aviso"  'aparese el error
        txtuser.Text = ""
        Exit Sub   ' dejo de ejecutar este sub
    Else    'caso contrrio
        If !Password = Objeto.Encriptar(txtpass.Text) Then   'pregunto su el password es correcto
                MDIFormPrincipal.Show    'muestro el siguiente formulario
                Unload Me

        Else    ' caso contrario
            MsgBox "Contraseña Incoarrecta", vbInformation, "Aviso"    ' mensaje de error
            txtpass.Text = ""
            Exit Sub    ' dejo de ejecutar este sub
        End If
    End If
End With
End Sub

Private Sub Form_Load()
usuarios
Set Objeto = New EncriptString
End Sub

