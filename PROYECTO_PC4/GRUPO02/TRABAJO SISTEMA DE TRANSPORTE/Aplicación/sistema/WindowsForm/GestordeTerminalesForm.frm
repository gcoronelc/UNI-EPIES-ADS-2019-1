VERSION 5.00
Object = "{86CF1D34-0C5F-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCT2.OCX"
Object = "{CDE57A40-8B86-11D0-B3C6-00A0C90AEA82}#1.0#0"; "MSDATGRD.OCX"
Begin VB.Form GestordeTerminalesForm 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Gestor de Terminales"
   ClientHeight    =   7605
   ClientLeft      =   45
   ClientTop       =   375
   ClientWidth     =   10410
   Icon            =   "GestordeTerminalesForm.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   MinButton       =   0   'False
   Picture         =   "GestordeTerminalesForm.frx":058A
   ScaleHeight     =   7605
   ScaleWidth      =   10410
   ShowInTaskbar   =   0   'False
   Begin VB.TextBox TxtID 
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
      Left            =   2280
      TabIndex        =   22
      Top             =   3960
      Width           =   1335
   End
   Begin VB.CommandButton cmdNuevo 
      Appearance      =   0  'Flat
      BackColor       =   &H80000012&
      Caption         =   "Nuevo"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   11.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   6600
      MaskColor       =   &H00E0E0E0&
      TabIndex        =   21
      Top             =   1800
      Width           =   1575
   End
   Begin VB.CommandButton cmdModificar 
      Appearance      =   0  'Flat
      BackColor       =   &H80000012&
      Caption         =   "Modificar"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   11.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   8400
      MaskColor       =   &H00E0E0E0&
      TabIndex        =   20
      Top             =   1800
      Width           =   1575
   End
   Begin VB.CommandButton cmdSalir 
      Appearance      =   0  'Flat
      BackColor       =   &H80000012&
      Caption         =   "Salir"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   11.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   7440
      MaskColor       =   &H00E0E0E0&
      TabIndex        =   19
      Top             =   3960
      Width           =   1575
   End
   Begin VB.CommandButton cmdBuscar 
      Appearance      =   0  'Flat
      BackColor       =   &H80000012&
      Caption         =   "Buscar"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   11.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   8400
      MaskColor       =   &H00E0E0E0&
      TabIndex        =   18
      Top             =   3240
      Width           =   1575
   End
   Begin VB.CommandButton cmdCancelar 
      Appearance      =   0  'Flat
      BackColor       =   &H80000012&
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
      Height          =   495
      Left            =   6600
      MaskColor       =   &H00E0E0E0&
      TabIndex        =   17
      Top             =   3240
      Width           =   1575
   End
   Begin VB.CommandButton cmdEliminar 
      Appearance      =   0  'Flat
      BackColor       =   &H80000012&
      Caption         =   "Eliminar"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   11.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   8400
      MaskColor       =   &H00E0E0E0&
      TabIndex        =   16
      Top             =   2520
      Width           =   1575
   End
   Begin VB.CommandButton cmdGrabar 
      Appearance      =   0  'Flat
      BackColor       =   &H80000012&
      Caption         =   "Grabar"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   11.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   6600
      MaskColor       =   &H00E0E0E0&
      TabIndex        =   15
      Top             =   2520
      Width           =   1575
   End
   Begin MSDataGridLib.DataGrid DataTerminales 
      Height          =   2175
      Left            =   240
      TabIndex        =   14
      Top             =   5160
      Width           =   9975
      _ExtentX        =   17595
      _ExtentY        =   3836
      _Version        =   393216
      BackColor       =   -2147483636
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
      Caption         =   "Terminales"
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
            ColumnWidth     =   1154.835
         EndProperty
         BeginProperty Column01 
            ColumnWidth     =   1275.024
         EndProperty
      EndProperty
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
      Left            =   2280
      TabIndex        =   5
      Top             =   1560
      Width           =   1335
   End
   Begin VB.TextBox txtAdministrador 
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
      Left            =   2280
      TabIndex        =   4
      Top             =   2040
      Width           =   3255
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
      Left            =   2280
      TabIndex        =   3
      Top             =   2520
      Width           =   3255
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
      Left            =   2280
      TabIndex        =   2
      Top             =   3000
      Width           =   3255
   End
   Begin VB.TextBox txtEmail 
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
      Left            =   2280
      TabIndex        =   0
      Top             =   3480
      Width           =   3255
   End
   Begin MSComCtl2.DTPicker DTPFecha 
      Height          =   375
      Left            =   2880
      TabIndex        =   1
      Top             =   4560
      Width           =   1695
      _ExtentX        =   2990
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
      Format          =   39649281
      CurrentDate     =   41235
   End
   Begin VB.Label Label8 
      BackStyle       =   0  'Transparent
      Caption         =   "Detalles de la Sucursal"
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
      TabIndex        =   13
      Top             =   1200
      Width           =   2775
   End
   Begin VB.Label Label4 
      Alignment       =   1  'Right Justify
      BackStyle       =   0  'Transparent
      Caption         =   "Nombre."
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
      Left            =   -360
      TabIndex        =   12
      Top             =   1560
      Width           =   2535
   End
   Begin VB.Label Label5 
      Alignment       =   1  'Right Justify
      BackStyle       =   0  'Transparent
      Caption         =   "ID:"
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
      Left            =   1440
      TabIndex        =   11
      Top             =   3960
      Width           =   735
   End
   Begin VB.Label Label1 
      Alignment       =   1  'Right Justify
      BackStyle       =   0  'Transparent
      Caption         =   "Administrador:"
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
      Left            =   -360
      TabIndex        =   10
      Top             =   2040
      Width           =   2535
   End
   Begin VB.Label Label2 
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
      Left            =   -360
      TabIndex        =   9
      Top             =   2520
      Width           =   2535
   End
   Begin VB.Label Label3 
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
      Left            =   -360
      TabIndex        =   8
      Top             =   3000
      Width           =   2535
   End
   Begin VB.Label Label6 
      Alignment       =   1  'Right Justify
      BackStyle       =   0  'Transparent
      Caption         =   "Email:"
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
      Left            =   -360
      TabIndex        =   7
      Top             =   3480
      Width           =   2535
   End
   Begin VB.Label Label7 
      Alignment       =   1  'Right Justify
      BackStyle       =   0  'Transparent
      Caption         =   "Fecha de Registro:"
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
      Left            =   240
      TabIndex        =   6
      Top             =   4560
      Width           =   2535
   End
End
Attribute VB_Name = "GestordeTerminalesForm"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdBuscar_Click()
NombreDeTerminal = InputBox("Ingrese el Nombre del terminal que buscara: ", "Busqueda", "Ingrese Nonbre")
If NombreDeTerminal = "" Then
    MsgBox "Nose ingreso ningun texto ", vbInformation, "Aviso"
Exit Sub
    Else
        With RsTerminales
            .Requery
            .Find "Nombre='" & Trim(NombreDeTerminal) & "'"
            If .EOF Then
            MsgBox "Nose encontro ningun registro ", vbInformation, "Aviso"
            Exit Sub
            Else
                ''lenar los datos en la caja de texto
                TxtNombre.Text = !NOmbre
                txtAdministrador.Text = !Administrador
                txtDireccion.Text = !Direccion
                txtTelefono.Text = !Telefono
                txtEmail.Text = !Email
                TxtID.Text = !ID_local
                DTPFecha.Value = !fecha
            End If
        End With
End If
End Sub

Private Sub cmdCancelar_Click()
HabilitarBotones True, False
HabilitarCajas True
    Limpiar
End Sub

Private Sub cmdEliminar_Click()
If IdTerminal = 0 Then
    MsgBox "Elija un registro...", vbInformation, "aviso"
    Exit Sub
    Else
        With RsTerminales
            .Find "Id='" & Trim(IdTerminal) & "'"
            If .EOF Then '' si encontro el registro
            MsgBox "No se encontro el registro", vbInformation, "Aviso"
            Exit Sub
            Else
                If MsgBox("Dese eliminar el Terminal de : " & DataTerminales.Columns(1).Text, vbInformation + vbYesNo) = vbYes Then
                .Delete
                .Requery
                End If
            End If
        End With
End If
End Sub

Private Sub cmdGrabar_Click()
''validar
    If TxtNombre.Text = "" Then MsgBox "El campo Asientos esta vacio", vbInformation, "Aviso": TxtNombre.SetFocus: Exit Sub
    If txtAdministrador.Text = "" Then MsgBox "El campo Asientos esta vacio", vbInformation, "Aviso": txtAdministrador.SetFocus: Exit Sub
    If txtDireccion.Text = "" Then MsgBox "El campo Asientos esta vacio", vbInformation, "Aviso": txtDireccion.SetFocus: Exit Sub
    If txtTelefono.Text = "" Then MsgBox "El campo Asientos esta vacio", vbInformation, "Aviso": txtTelefono.SetFocus: Exit Sub
    If txtEmail.Text = "" Then MsgBox "El campo Asientos esta vacio", vbInformation, "Aviso": txtEmail.SetFocus: Exit Sub
    If TxtID.Text = "" Then MsgBox "El campo Asientos esta vacio", vbInformation, "Aviso": TxtID.SetFocus: Exit Sub
    ''pregunta si el nuevo registro Modi = false
    If Modi = False Then ''crear un nuevo registro
    With RsTerminales
        .Requery
        .AddNew
            !NOmbre = TxtNombre.Text
            !Administrador = txtAdministrador.Text
            !Direccion = txtDireccion.Text
            !Telefono = txtTelefono.Text
            !Email = txtEmail.Text
            !ID_local = TxtID.Text
            !fecha = DTPFecha.Value
        .Update
        .Requery
            
    End With
    ''ahora midificar
    Else ''el Modi = True ====> modificar los registros existentes
        With RsTerminales
        .Requery
        .Find "Id='" & Trim(IdTerminal) & "'"
            !NOmbre = TxtNombre.Text
            !Administrador = txtAdministrador.Text
            !Direccion = txtDireccion.Text
            !Telefono = txtTelefono.Text
            !Email = txtEmail.Text
            !ID_local = TxtID.Text
            !fecha = DTPFecha.Value
            .UpdateBatch
            .Requery
        End With
End If
HabilitarCajas True
HabilitarBotones True, False
Limpiar
cerrargrilla
End Sub

Private Sub cmdModificar_Click()
    Modi = True
    HabilitarCajas False
    HabilitarBotones False, True
End Sub

Private Sub cmdNuevo_Click()
  HabilitarCajas False
    Limpiar
    Modi = False
    HabilitarBotones False, True
End Sub

Private Sub cmdSalir_Click()
    If MsgBox("Desea salir del Sistema", vbInformation + vbYesNo, "Aviso") = vbYes Then
    Unload Me
    End If
End Sub

Private Sub DataTerminales_Click()
With RsTerminales
    If .BOF Or .EOF Then Exit Sub
    IdTerminal = DataTerminales.Columns(0).Text
    
End With
End Sub

Private Sub Form_Load()
 Terminales
 Set DataTerminales.DataSource = RsTerminales
 
 cerrargrilla
 HabilitarCajas True
 HabilitarBotones True, False
End Sub
Sub cerrargrilla()
    DataTerminales.Columns(0).Locked = True
    DataTerminales.Columns(1).Locked = True
    DataTerminales.Columns(2).Locked = True
    DataTerminales.Columns(3).Locked = True
    DataTerminales.Columns(4).Locked = True
    DataTerminales.Columns(5).Locked = True
    DataTerminales.Columns(6).Locked = True
    DataTerminales.Columns(7).Locked = True
    DataTerminales.Columns(0).Width = 0
End Sub
Public Sub HabilitarCajas(estado As Boolean)
    TxtNombre.Locked = estado
    txtAdministrador.Locked = estado
    txtDireccion.Locked = estado
    txtTelefono.Locked = estado
    txtEmail.Locked = estado
    TxtID.Locked = estado
End Sub
Public Sub HabilitarBotones(estado1 As Boolean, estado2 As BookmarkEnum)
    cmdNuevo.Enabled = estado1
    cmdModificar.Enabled = estado1
    cmdGrabar.Enabled = estado2
    cmdEliminar.Enabled = estado1
    cmdCancelar.Enabled = estado2
    cmdBuscar.Enabled = estado1
End Sub
Sub Limpiar()
    TxtNombre.Text = ""
    txtAdministrador.Text = ""
    txtDireccion.Text = ""
    txtTelefono.Text = ""
    txtEmail.Text = ""
    TxtID.Text = ""
    DTPFecha.Value = Date
    TxtNombre.SetFocus
End Sub
Private Sub DTPFecha_CallbackKeyDown(ByVal KeyCode As Integer, ByVal Shift As Integer, ByVal CallbackField As String, CallbackDate As Date)
DTPFecha.Value = Date
End Sub
