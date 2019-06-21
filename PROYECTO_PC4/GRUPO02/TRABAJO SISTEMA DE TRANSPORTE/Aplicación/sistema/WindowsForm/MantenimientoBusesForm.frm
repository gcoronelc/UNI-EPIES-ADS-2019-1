VERSION 5.00
Object = "{86CF1D34-0C5F-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCT2.OCX"
Object = "{CDE57A40-8B86-11D0-B3C6-00A0C90AEA82}#1.0#0"; "MSDATGRD.OCX"
Object = "{F0D2F211-CCB0-11D0-A316-00AA00688B10}#1.0#0"; "MSDATLST.OCX"
Begin VB.Form MantenimientoBusesForm 
   AutoRedraw      =   -1  'True
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Mantenimiento de Buses"
   ClientHeight    =   9705
   ClientLeft      =   45
   ClientTop       =   375
   ClientWidth     =   14685
   Icon            =   "MantenimientoBusesForm.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   MinButton       =   0   'False
   Picture         =   "MantenimientoBusesForm.frx":058A
   ScaleHeight     =   9705
   ScaleWidth      =   14685
   ShowInTaskbar   =   0   'False
   Begin MSDataGridLib.DataGrid GridBuses 
      Height          =   3495
      Left            =   480
      TabIndex        =   21
      Top             =   5760
      Width           =   13695
      _ExtentX        =   24156
      _ExtentY        =   6165
      _Version        =   393216
      HeadLines       =   1
      RowHeight       =   20
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
      Caption         =   "Buses"
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
      Left            =   8040
      MaskColor       =   &H00E0E0E0&
      TabIndex        =   20
      Top             =   2760
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
      Left            =   10200
      MaskColor       =   &H00E0E0E0&
      TabIndex        =   19
      Top             =   2760
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
      Left            =   8040
      MaskColor       =   &H00E0E0E0&
      TabIndex        =   18
      Top             =   3600
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
      Left            =   10200
      MaskColor       =   &H00E0E0E0&
      TabIndex        =   17
      Top             =   3600
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
      Left            =   9120
      MaskColor       =   &H00E0E0E0&
      TabIndex        =   16
      Top             =   4440
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
      Left            =   10200
      MaskColor       =   &H00E0E0E0&
      TabIndex        =   15
      Top             =   1920
      Width           =   1575
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
      Left            =   8040
      MaskColor       =   &H00E0E0E0&
      TabIndex        =   14
      Top             =   1920
      Width           =   1575
   End
   Begin VB.TextBox txtMatricula 
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
      TabIndex        =   11
      Top             =   4080
      Width           =   3255
   End
   Begin MSComCtl2.DTPicker DTPFecha 
      Height          =   375
      Left            =   4080
      TabIndex        =   10
      Top             =   5160
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
      Format          =   83623937
      CurrentDate     =   41235
   End
   Begin VB.TextBox txtBus 
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
      Top             =   3600
      Width           =   3255
   End
   Begin VB.TextBox txtDescripcion 
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
      TabIndex        =   3
      Top             =   3120
      Width           =   3255
   End
   Begin VB.TextBox txtDestino 
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
      TabIndex        =   2
      Top             =   2640
      Width           =   3255
   End
   Begin VB.TextBox txtAsiento 
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
      TabIndex        =   1
      Top             =   2160
      Width           =   1335
   End
   Begin MSDataListLib.DataCombo DataTipo 
      Height          =   405
      Left            =   4080
      TabIndex        =   0
      Top             =   4560
      Width           =   1695
      _ExtentX        =   2990
      _ExtentY        =   714
      _Version        =   393216
      BackColor       =   -2147483636
      ListField       =   ""
      BoundColumn     =   ""
      Text            =   ""
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin MSDataListLib.DataCombo DataTerminal 
      Height          =   405
      Left            =   4080
      TabIndex        =   22
      Top             =   1560
      Width           =   2295
      _ExtentX        =   4048
      _ExtentY        =   714
      _Version        =   393216
      Style           =   2
      BackColor       =   -2147483636
      ListField       =   ""
      BoundColumn     =   ""
      Text            =   ""
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin VB.Label Label8 
      Alignment       =   1  'Right Justify
      BackStyle       =   0  'Transparent
      Caption         =   "Terminal a donde pertenese:"
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
      Height          =   735
      Left            =   1200
      TabIndex        =   23
      Top             =   1440
      Width           =   2775
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
      Left            =   1440
      TabIndex        =   13
      Top             =   5160
      Width           =   2535
   End
   Begin VB.Label Label6 
      Alignment       =   1  'Right Justify
      BackStyle       =   0  'Transparent
      Caption         =   "Matricula:"
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
      TabIndex        =   12
      Top             =   4080
      Width           =   2535
   End
   Begin VB.Label Label3 
      Alignment       =   1  'Right Justify
      BackStyle       =   0  'Transparent
      Caption         =   "ID del Bus:"
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
      TabIndex        =   9
      Top             =   3600
      Width           =   2535
   End
   Begin VB.Label Label2 
      Alignment       =   1  'Right Justify
      BackStyle       =   0  'Transparent
      Caption         =   "Descripción:"
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
      TabIndex        =   8
      Top             =   3120
      Width           =   2535
   End
   Begin VB.Label Label1 
      Alignment       =   1  'Right Justify
      BackStyle       =   0  'Transparent
      Caption         =   "Destino:"
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
      TabIndex        =   7
      Top             =   2640
      Width           =   2535
   End
   Begin VB.Label Label5 
      Alignment       =   1  'Right Justify
      BackStyle       =   0  'Transparent
      Caption         =   "Tipo:"
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
      Left            =   3240
      TabIndex        =   6
      Top             =   4560
      Width           =   735
   End
   Begin VB.Label Label4 
      Alignment       =   1  'Right Justify
      BackStyle       =   0  'Transparent
      Caption         =   "N° de Asientos:"
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
      TabIndex        =   5
      Top             =   2160
      Width           =   2535
   End
End
Attribute VB_Name = "MantenimientoBusesForm"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdBuscar_Click()
MatriculaBus = InputBox("Ingrese la Matricula del Bus que desea buscar: ", "Busqueda", "Ingrese Nonbre")
If MatriculaBus = "" Then

    MsgBox "Nose ingreso ningun texto", vbInformation, "Aviso"
    Exit Sub
    
Else
''si se ingreso texto

With RsBuses
    .Requery
    .Find "Matricula='" & Trim(MatriculaBus) & "'"
    If .EOF Then
        MsgBox "No se encontro ningun registro ", vbInformation, "Aviso"
        Exit Sub
        Else
            ''llenar los datos en la caja de texto
            DataTerminal.Text = !Terminal
            TxtAsiento.Text = !Asientos
            TxtDestino.Text = !Destino
            txtDescripcion.Text = !Descripcion
            txtBus.Text = !Id_Bus
            txtMatricula.Text = !matricula
            DTPFecha.Value = !fecha
            Dim Vari
            Vari = !Tipo
            
            
            ''cambiar el nombre del tipo bus a su codigoo Id_bus o solo Id
                Dim tipobus123
                With RsTipobus
                    .Requery
                    .Find "ID='" & Trim(Vari) & "'"
                    tipobus123 = !Tipo
                End With
                DataTipo = tipobus123
            ''el terminal
            Dim termi
            termi = !Terminal
            ''cambiar el nombre del terminal al codigo ID
                Dim Termin
                With RsTerminales
                .Requery
                .Find "Id='" & Trim(termi) & "'"
                Termin = !NOmbre
                End With
                DataTerminal = Termin
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
If IdBuses = 0 Then
    MsgBox "Elija un registro...", vbInformation, "Aviso"
    Exit Sub
    Else
        With RsBuses
            .Find "Id='" & Trim(IdBuses) & "'"
            If .EOF Then '' si encontro el registro
            MsgBox "No se encontro el Registro", vbInformation, "Aviso"
            Exit Sub
            Else
                If MsgBox("Desea eliminar el registro: " & GridBuses.Columns(4).Text, vbInformation + vbYesNo) = vbYes Then
                .Delete
                .Requery
                
                End If
            End If
        End With
   End If

End Sub

Private Sub cmdGrabar_Click()
'' validar
    If TxtAsiento.Text = "" Then MsgBox "El campo Asientos esta vacio", vbInformation, "Aviso": TxtAsiento.SetFocus: Exit Sub
    If TxtDestino.Text = "" Then MsgBox "El campo Destino esta vacio", vbInformation, "Aviso": TxtDestino.SetFocus: Exit Sub
    If txtDescripcion.Text = "" Then MsgBox "El campo Descripcion esta vacio", vbInformation, "Aviso": txtDescripcion.SetFocus: Exit Sub
    If txtBus.Text = "" Then MsgBox "El campo ID del Bus esta vacio", vbInformation, "Aviso": txtBus.SetFocus: Exit Sub
    If txtMatricula.Text = "" Then MsgBox "El campo Matricula esta vacio", vbInformation, "Aviso": txtMatricula.SetFocus: Exit Sub
    If DataTipo.Text = "" Then MsgBox "El campo Tipo esta vacio", vbInformation, "Aviso": DataTipo.SetFocus: Exit Sub
    ''preguntar si el nuenvo registro Modi = False
    If Modi = False Then '''crear nuenvo registro
    With RsBuses
        .Requery
        .AddNew
            !Asientos = TxtAsiento.Text
            !Destino = TxtDestino.Text
            !Descripcion = txtDescripcion.Text
            !Id_Bus = txtBus.Text
            !matricula = txtMatricula.Text
            !fecha = DTPFecha.Value
            ''cambiar el nombre del tipo bus a su codigoo Id_bus o solo Id
                Dim codigotipobus
                With RsTipobus
                    .Requery
                    .Find "Tipo='" & Trim(DataTipo.Text) & "'"
                    codigotipobus = !Id
                    
                End With
                !Tipo = codigotipobus
                
            ''terminales
                Dim codigoterminal
                With RsTerminales
                    .Requery
                    .Find "Nombre='" & Trim(DataTerminal.Text) & "'"
                    codigoterminal = !Id
                End With
                    !Terminal = codigoterminal
                .Update
                .Requery
                
    End With
Else '''' el Modi = true  ===> modificar el registro existente
    With RsBuses
        .Requery
        .Find "Id='" & Trim(IdBuses) & "'"
        
            !Asientos = TxtAsiento.Text
            !Destino = TxtDestino.Text
            !Descripcion = txtDescripcion.Text
            !Id_Bus = txtBus.Text
            !matricula = txtMatricula.Text
            !fecha = DTPFecha.Value
            ''cambiar el nombre del tipo bus a su codigoo Id_bus o solo Id
                Dim codigotipobus2
                With RsTipobus
                    .Requery
                    .Find "Tipo='" & Trim(DataTipo.Text) & "'"
                    codigotipobus2 = !Id
                    
                End With
                !Tipo = codigotipobus2
                ''terminal
                    Dim codigoterminal2
                    With RsTerminales
                        .Requery
                        .Find "Nombre='" & Trim(DataTerminal.Text) & "'"
                    codigoterminal2 = !Id
                End With
                    !Terminal = codigoterminal2
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
HabilitarCajas False
    Modi = True
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

Private Sub DTPFecha_CallbackKeyDown(ByVal KeyCode As Integer, ByVal Shift As Integer, ByVal CallbackField As String, CallbackDate As Date)
DTPFecha.Value = Date
End Sub

Private Sub Form_Load()
Buses
TipoBus
Terminales
''agregar los tipos de buses en el data combo
    Set DataTipo.RowSource = RsTipobus
      DataTipo.BoundColumn = "Tipo"
      DataTipo.ListField = "Tipo"
    
    ''terminal
    Set DataTerminal.RowSource = RsTerminales
        DataTerminal.BoundColumn = "Nombre"
        DataTerminal.ListField = "Nombre"
    ''lenar grilla de buses
    Set GridBuses.DataSource = RsBuses
    cerrargrilla
    
    HabilitarCajas True
    HabilitarBotones True, False
End Sub
Sub cerrargrilla()
    GridBuses.Columns(0).Locked = True
    GridBuses.Columns(1).Locked = True
    GridBuses.Columns(2).Locked = True
    GridBuses.Columns(3).Locked = True
    GridBuses.Columns(4).Locked = True
    GridBuses.Columns(5).Locked = True
    GridBuses.Columns(6).Locked = True
    GridBuses.Columns(7).Locked = True
    GridBuses.Columns(8).Locked = True
    GridBuses.Columns(0).Width = 0
End Sub

Public Sub HabilitarCajas(estado As Boolean)
    TxtAsiento.Locked = estado
    TxtDestino.Locked = estado
    txtDescripcion.Locked = estado
    txtBus.Locked = estado
    txtMatricula.Locked = estado
    DataTipo.Locked = estado
    DataTerminal.Locked = estado
    
End Sub
Sub Limpiar()
    DataTerminal.Text = ""
    TxtAsiento.Text = ""
    TxtDestino.Text = ""
    txtDescripcion.Text = ""
    txtBus.Text = ""
    txtMatricula.Text = ""
    DataTipo.Text = ""
    DTPFecha.Value = Date
    TxtAsiento.SetFocus
End Sub

Public Sub HabilitarBotones(estado1 As Boolean, estado2 As BookmarkEnum)
    cmdNuevo.Enabled = estado1
    cmdModificar.Enabled = estado1
    cmdGrabar.Enabled = estado2
    cmdEliminar.Enabled = estado1
    cmdCancelar.Enabled = estado2
    cmdBuscar.Enabled = estado1
    
End Sub

Private Sub GridBuses_Click()
With RsBuses
    If .BOF Or .EOF Then Exit Sub
    IdBuses = GridBuses.Columns(0).Text
    
End With
End Sub

