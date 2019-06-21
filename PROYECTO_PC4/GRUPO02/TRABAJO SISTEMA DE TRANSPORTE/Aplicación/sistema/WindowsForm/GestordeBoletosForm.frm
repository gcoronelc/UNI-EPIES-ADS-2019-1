VERSION 5.00
Object = "{86CF1D34-0C5F-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCT2.OCX"
Object = "{CDE57A40-8B86-11D0-B3C6-00A0C90AEA82}#1.0#0"; "MSDATGRD.OCX"
Object = "{F0D2F211-CCB0-11D0-A316-00AA00688B10}#1.0#0"; "MSDATLST.OCX"
Begin VB.Form GestordeBoletosForm 
   Appearance      =   0  'Flat
   BackColor       =   &H80000005&
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Gestor de buses y Boletos"
   ClientHeight    =   7725
   ClientLeft      =   45
   ClientTop       =   375
   ClientWidth     =   11490
   Icon            =   "GestordeBoletosForm.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   MinButton       =   0   'False
   Picture         =   "GestordeBoletosForm.frx":058A
   ScaleHeight     =   7725
   ScaleWidth      =   11490
   ShowInTaskbar   =   0   'False
   Begin VB.TextBox TxtTipo 
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
      TabIndex        =   21
      Top             =   2760
      Width           =   2415
   End
   Begin VB.TextBox TxtDestino 
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
      TabIndex        =   20
      Top             =   3720
      Width           =   2775
   End
   Begin VB.TextBox TxtOrigen 
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
      TabIndex        =   19
      Top             =   3240
      Width           =   2775
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
      Left            =   7200
      MaskColor       =   &H00E0E0E0&
      TabIndex        =   16
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
      Left            =   9000
      MaskColor       =   &H00E0E0E0&
      TabIndex        =   15
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
      Left            =   7200
      MaskColor       =   &H00E0E0E0&
      TabIndex        =   14
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
      Left            =   9000
      MaskColor       =   &H00E0E0E0&
      TabIndex        =   13
      Top             =   3960
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
      Left            =   8040
      MaskColor       =   &H00E0E0E0&
      TabIndex        =   12
      Top             =   4680
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
      Left            =   9000
      MaskColor       =   &H00E0E0E0&
      TabIndex        =   11
      Top             =   2520
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
      Left            =   7200
      MaskColor       =   &H00E0E0E0&
      TabIndex        =   10
      Top             =   2520
      Width           =   1575
   End
   Begin MSComCtl2.DTPicker DTPHora 
      Height          =   495
      Left            =   2400
      TabIndex        =   4
      Top             =   4200
      Width           =   2655
      _ExtentX        =   4683
      _ExtentY        =   873
      _Version        =   393216
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Arial"
         Size            =   18
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Format          =   6356994
      CurrentDate     =   41256
   End
   Begin MSDataGridLib.DataGrid DataSalidas 
      Height          =   1815
      Left            =   360
      TabIndex        =   3
      Top             =   5520
      Width           =   10695
      _ExtentX        =   18865
      _ExtentY        =   3201
      _Version        =   393216
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
   Begin VB.CommandButton cmdVender 
      Caption         =   "Ver - Vender Boletos"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   20.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   735
      Left            =   6840
      Picture         =   "GestordeBoletosForm.frx":453DA
      Style           =   1  'Graphical
      TabIndex        =   2
      Top             =   1560
      Width           =   4095
   End
   Begin VB.TextBox TxtFecha 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000C&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   18
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   4320
      TabIndex        =   1
      Top             =   1440
      Width           =   1935
   End
   Begin VB.TextBox txtHora 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000C&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   27.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   660
      Left            =   480
      TabIndex        =   0
      Top             =   1320
      Width           =   3495
   End
   Begin VB.Timer Timer1 
      Interval        =   1
      Left            =   480
      Top             =   2160
   End
   Begin MSComCtl2.DTPicker DTPFecha 
      Height          =   495
      Left            =   2400
      TabIndex        =   5
      Top             =   4800
      Width           =   2655
      _ExtentX        =   4683
      _ExtentY        =   873
      _Version        =   393216
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Arial"
         Size            =   18
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Format          =   6356993
      CurrentDate     =   41256
   End
   Begin MSDataListLib.DataCombo DataBuses 
      Height          =   405
      Left            =   2400
      TabIndex        =   17
      Top             =   2280
      Width           =   2655
      _ExtentX        =   4683
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
   Begin VB.Label Label6 
      Alignment       =   1  'Right Justify
      BackStyle       =   0  'Transparent
      Caption         =   "Tipo de Bus:"
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
      TabIndex        =   22
      Top             =   2880
      Width           =   2055
   End
   Begin VB.Label Label5 
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
      Left            =   240
      TabIndex        =   18
      Top             =   2400
      Width           =   2055
   End
   Begin VB.Label Label4 
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
      Left            =   240
      TabIndex        =   9
      Top             =   3840
      Width           =   2055
   End
   Begin VB.Label Label3 
      Alignment       =   1  'Right Justify
      BackStyle       =   0  'Transparent
      Caption         =   "Origen:"
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
      TabIndex        =   8
      Top             =   3360
      Width           =   2055
   End
   Begin VB.Label Label2 
      Alignment       =   1  'Right Justify
      BackStyle       =   0  'Transparent
      Caption         =   "Fecha de Salida:"
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
      Left            =   -240
      TabIndex        =   7
      Top             =   4920
      Width           =   2535
   End
   Begin VB.Label Label1 
      Alignment       =   1  'Right Justify
      BackStyle       =   0  'Transparent
      Caption         =   "Hora de Salida:"
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
      Left            =   480
      TabIndex        =   6
      Top             =   4320
      Width           =   1815
   End
End
Attribute VB_Name = "GestordeBoletosForm"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdBuscar_Click()
    SalidaBus = InputBox("Ingrese el ID del bus que desea buscar: ", "Busqueda", "Ingrese ID de Bus")
    If SalidaBus = "" Then
        MsgBox "Nose ingreso ningun texto", vbInformation, "Aviso"
        Exit Sub
        Else
        With RsSalidas
            .Requery
            .Find "Buses='" & Trim(SalidaBus) & "'"
            If .EOF Then
            MsgBox "Nose encontro ningun registro", vbInformation, "Aviso"
            Exit Sub
                Else
                    '''llenar la caja de texto pos
                    DataBuses.Text = !Buses
                    TxtOrigen.Text = !Terminal
                    TxtDestino.Text = !Destino
                    DTPHora.Value = !Hora_salida
                    DTPFecha.Value = !Fecha_salida
            End If
        End With

End If
End Sub

Private Sub cmdCancelar_Click()
HabilitarCaja True
HabilitarBotones True, False
Limpiar
cerrargrilla
End Sub

Private Sub cmdEliminar_Click()
If IdSalida = 0 Then
    MsgBox "Elija un registro...", vbInformation, "Aviso"
    Exit Sub
    Else
        With RsSalidas
            .Find "Id='" & Trim(IdSalida) & "'"
            If .EOF Then
            MsgBox "Nose encontro ningun registro", vbInformation, "Asiso"
            Exit Sub
            Else
                If MsgBox("Desea eliminar el terminal de :" & DataSalidas.Columns(1).Text, vbInformation + vbYesNo) = vbYes Then
                .Delete
                .Requery
            End If
            End If
        End With
End If
End Sub

Private Sub cmdGrabar_Click()
If DataBuses.Text = "" Then MsgBox "El campo esta Origen esta vacio", vbInformation, "Aviso": DataBuses.SetFocus: Exit Sub
If TxtOrigen.Text = "" Then MsgBox "El campo esta Origen esta vacio", vbInformation, "Aviso": TxtOrigen.SetFocus: Exit Sub
If TxtDestino.Text = "" Then MsgBox "El campo esta Destino esta vacio", vbInformation, "Aviso": TxtDestino.SetFocus: Exit Sub
If Modi = False Then
     With RsSalidas
     .Requery
     .AddNew
        !Buses = DataBuses.Text
        !Terminal = TxtOrigen.Text
        !Destino = TxtDestino.Text
        !Hora_salida = DTPHora.Value
        !Fecha_salida = DTPFecha.Value
        !Tipo = TxtTipo.Text
        .Update
        .Requery
        
     End With
     ''modificar
     Else
     With RsSalidas
        .Requery
        .Find "Id='" & Trim(IdSalida) & "'"
        
            !Buses = DataBuses.Text
            !Terminal = TxtOrigen.Text
            !Destino = TxtDestino.Text
            !Hora_salida = DTPHora.Value
            !Fecha_salida = DTPFecha.Value
            !Tipo = TxtTipo.Text
        .UpdateBatch
        .Requery
     End With
End If
HabilitarCaja True
HabilitarBotones True, False
Limpiar
cerrargrilla
End Sub

Private Sub cmdModificar_Click()
    Modi = True
    HabilitarBotones False, True
    HabilitarCaja False
    Limpiar
End Sub

Private Sub cmdNuevo_Click()
Modi = False
HabilitarBotones False, True
HabilitarCaja True
Limpiar
End Sub

Private Sub cmdSalir_Click()
If MsgBox("Desea salir del Sistema", vbInformation + vbYesNo, "Aviso") = vbYes Then
    Unload Me
    End If
End Sub

Private Sub cmdVender_Click()
AsientosForm.Show
End Sub

Private Sub DataBuses_Change()
''destino
With RsBuses
    .Requery
    .Find "Id_Bus='" & Trim(DataBuses.Text) & "'"
    If .EOF Then
    Exit Sub
    Else
    TxtDestino.Text = !Destino
    
    ''origen
        Dim Vari
        Vari = !Terminal
        Dim SalidaOrigen
            With RsTerminales
            .Requery
            .Find "Id='" & Trim(Vari) & "'"
            SalidaOrigen = !NOmbre
            
            End With
            TxtOrigen.Text = SalidaOrigen
            '''''''tipo de bus
                Dim Vari1
                Vari1 = !Tipo
                Dim SalidaOrigen1
                    With RsTipobus
                    .Requery
                    .Find "Id='" & Trim(Vari1) & "'"
                    SalidaOrigen1 = !Tipo
                    End With
                    TxtTipo.Text = SalidaOrigen1
    End If
End With
End Sub

Private Sub DataSalidas_Click()
With RsSalidas
    If .BOF Or .EOF Then Exit Sub
    IdSalida = DataSalidas.Columns(0).Text
        
End With
End Sub

Private Sub Form_Load()
Salidas
Buses
TipoBus
Terminales
''agregar origen y destino
    ''origen
    Set DataBuses.RowSource = RsBuses
    DataBuses.BoundColumn = "Id_Bus"
    DataBuses.ListField = "Id_Bus"
    ''destino
       
    Set DataSalidas.DataSource = RsSalidas
'''habilitar y desabilitar cajas
        HabilitarCaja True
        HabilitarBotones True, False
cerrargrilla
End Sub

Private Sub Timer1_Timer()
TxtHora.Text = Time
TxtFecha.Text = Date
End Sub


Public Sub HabilitarBotones(estado1 As Boolean, estado2 As BookmarkEnum)
    cmdNuevo.Enabled = estado1
    cmdModificar.Enabled = estado1
    cmdGrabar.Enabled = estado2
    cmdEliminar.Enabled = estado1
    cmdCancelar.Enabled = estado2
    cmdBuscar.Enabled = estado1
    
End Sub
Public Sub HabilitarCaja(estado As Boolean)
'DataBuses.Locked = estado
TxtOrigen.Locked = estado
TxtDestino.Locked = estado
DTPHora.Value = estado
DTPFecha.Value = estado
TxtTipo.Locked = estado
End Sub

Sub Limpiar()
DataBuses.Text = ""
TxtOrigen.Text = ""
TxtDestino.Text = ""
DTPHora.Value = Time
DTPFecha.Value = Date
TxtTipo.Text = ""
End Sub
Sub cerrargrilla()

    DataSalidas.Columns(0).Locked = True
    DataSalidas.Columns(1).Locked = True
    DataSalidas.Columns(2).Locked = True
    DataSalidas.Columns(3).Locked = True
    DataSalidas.Columns(4).Locked = True
    DataSalidas.Columns(5).Locked = True
    DataSalidas.Columns(0).Width = 0
End Sub


