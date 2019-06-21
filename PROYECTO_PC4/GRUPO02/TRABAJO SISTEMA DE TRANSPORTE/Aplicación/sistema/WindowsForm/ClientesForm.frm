VERSION 5.00
Object = "{67397AA1-7FB1-11D0-B148-00A0C922E820}#6.0#0"; "MSADODC.OCX"
Object = "{CDE57A40-8B86-11D0-B3C6-00A0C90AEA82}#1.0#0"; "MSDATGRD.OCX"
Begin VB.Form ClientesForm 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Consulta de Clientes"
   ClientHeight    =   8370
   ClientLeft      =   45
   ClientTop       =   375
   ClientWidth     =   14385
   Icon            =   "ClientesForm.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   MinButton       =   0   'False
   Picture         =   "ClientesForm.frx":058A
   ScaleHeight     =   8370
   ScaleWidth      =   14385
   ShowInTaskbar   =   0   'False
   Begin VB.CommandButton Command2 
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   735
      Left            =   11160
      Picture         =   "ClientesForm.frx":64C03
      Style           =   1  'Graphical
      TabIndex        =   37
      Top             =   840
      Width           =   2775
   End
   Begin VB.CommandButton Command1 
      Caption         =   "Imprimir"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1455
      Left            =   12480
      Picture         =   "ClientesForm.frx":66F05
      Style           =   1  'Graphical
      TabIndex        =   35
      Top             =   6720
      Width           =   1575
   End
   Begin VB.TextBox TxtNombres 
      Appearance      =   0  'Flat
      BackColor       =   &H80000004&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   390
      Left            =   600
      TabIndex        =   34
      Top             =   2400
      Width           =   6855
   End
   Begin MSAdodcLib.Adodc Adodc1 
      Height          =   330
      Left            =   12120
      Top             =   120
      Width           =   2055
      _ExtentX        =   3625
      _ExtentY        =   582
      ConnectMode     =   0
      CursorLocation  =   3
      IsolationLevel  =   -1
      ConnectionTimeout=   15
      CommandTimeout  =   30
      CursorType      =   3
      LockType        =   3
      CommandType     =   8
      CursorOptions   =   0
      CacheSize       =   50
      MaxRecords      =   0
      BOFAction       =   0
      EOFAction       =   0
      ConnectStringType=   1
      Appearance      =   1
      BackColor       =   -2147483643
      ForeColor       =   -2147483640
      Orientation     =   0
      Enabled         =   -1
      Connect         =   ""
      OLEDBString     =   ""
      OLEDBFile       =   ""
      DataSourceName  =   ""
      OtherAttributes =   ""
      UserName        =   ""
      Password        =   ""
      RecordSource    =   ""
      Caption         =   "Adodc1"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      _Version        =   393216
   End
   Begin VB.TextBox DataBuses 
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
      Left            =   6240
      TabIndex        =   30
      Top             =   6360
      Width           =   1935
   End
   Begin VB.TextBox TxtTime 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000C&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   390
      Left            =   11400
      TabIndex        =   12
      Top             =   5880
      Width           =   1935
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
      Left            =   6240
      TabIndex        =   11
      Top             =   7320
      Width           =   1935
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
      Left            =   6240
      TabIndex        =   10
      Top             =   7800
      Width           =   1935
   End
   Begin VB.TextBox TxtFecha 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000C&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   390
      Left            =   10320
      TabIndex        =   9
      Top             =   6840
      Width           =   1935
   End
   Begin VB.TextBox TxtHora 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000C&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   390
      Left            =   10320
      TabIndex        =   8
      Top             =   6360
      Width           =   1935
   End
   Begin VB.TextBox TxtDate 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000C&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   390
      Left            =   7080
      TabIndex        =   7
      Top             =   5880
      Width           =   1935
   End
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
      Left            =   6240
      TabIndex        =   6
      Top             =   6840
      Width           =   1935
   End
   Begin VB.TextBox TxtNombre 
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
      Left            =   1680
      TabIndex        =   5
      Top             =   6360
      Width           =   2775
   End
   Begin VB.TextBox TxtApellido 
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
      Left            =   1680
      TabIndex        =   4
      Top             =   6840
      Width           =   2775
   End
   Begin VB.TextBox TxtDNI 
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
      Left            =   1680
      TabIndex        =   3
      Top             =   7320
      Width           =   1935
   End
   Begin VB.TextBox TxtPrecio 
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
      Left            =   1680
      TabIndex        =   2
      Top             =   7800
      Width           =   1095
   End
   Begin VB.TextBox TxtUbicacion 
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
      Left            =   10320
      TabIndex        =   1
      Top             =   7800
      Width           =   1935
   End
   Begin VB.TextBox TxtAsiento 
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
      Left            =   10320
      TabIndex        =   0
      Top             =   7320
      Width           =   1935
   End
   Begin MSDataGridLib.DataGrid DataClientes 
      Height          =   2535
      Left            =   600
      TabIndex        =   31
      Top             =   3000
      Width           =   13215
      _ExtentX        =   23310
      _ExtentY        =   4471
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
      Caption         =   "Busqueda de Clientes"
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
   Begin VB.Frame Frame1 
      Caption         =   "Busqueda de Clientes"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   3975
      Left            =   480
      TabIndex        =   32
      Top             =   1680
      Width           =   13455
      Begin VB.ComboBox ComboTex 
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
         Left            =   120
         Style           =   2  'Dropdown List
         TabIndex        =   36
         Top             =   240
         Width           =   2415
      End
   End
   Begin VB.Label LblIDClientes 
      BackStyle       =   0  'Transparent
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   26.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000B&
      Height          =   615
      Left            =   10320
      TabIndex        =   33
      Top             =   240
      Width           =   2175
   End
   Begin VB.Label Label1 
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
      Left            =   -360
      TabIndex        =   29
      Top             =   6360
      Width           =   1935
   End
   Begin VB.Label Label2 
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
      Left            =   -360
      TabIndex        =   28
      Top             =   6840
      Width           =   1935
   End
   Begin VB.Label Label3 
      Alignment       =   1  'Right Justify
      BackStyle       =   0  'Transparent
      Caption         =   "DNI:"
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
      TabIndex        =   27
      Top             =   7320
      Width           =   1935
   End
   Begin VB.Label Label4 
      Alignment       =   1  'Right Justify
      BackStyle       =   0  'Transparent
      Caption         =   "Precio:"
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
      TabIndex        =   26
      Top             =   7800
      Width           =   1935
   End
   Begin VB.Label Label5 
      Alignment       =   1  'Right Justify
      BackStyle       =   0  'Transparent
      Caption         =   "ID de BUS:"
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
      Left            =   4560
      TabIndex        =   25
      Top             =   6360
      Width           =   1575
   End
   Begin VB.Label Label6 
      Alignment       =   1  'Right Justify
      BackStyle       =   0  'Transparent
      Caption         =   "Tipo de BUS:"
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
      Left            =   4440
      TabIndex        =   24
      Top             =   6840
      Width           =   1695
   End
   Begin VB.Label Label7 
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
      Left            =   4680
      TabIndex        =   23
      Top             =   7320
      Width           =   1455
   End
   Begin VB.Label Label8 
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
      Left            =   4680
      TabIndex        =   22
      Top             =   7800
      Width           =   1455
   End
   Begin VB.Label Label9 
      Alignment       =   1  'Right Justify
      BackStyle       =   0  'Transparent
      Caption         =   "Fecha de salida:"
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
      Left            =   8280
      TabIndex        =   21
      Top             =   6840
      Width           =   1935
   End
   Begin VB.Label Label10 
      Alignment       =   1  'Right Justify
      BackStyle       =   0  'Transparent
      Caption         =   "Hora de salida:"
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
      Left            =   8280
      TabIndex        =   20
      Top             =   6360
      Width           =   1935
   End
   Begin VB.Label Label11 
      Alignment       =   1  'Right Justify
      BackStyle       =   0  'Transparent
      Caption         =   "Fecha de registrol:"
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
      Left            =   4680
      TabIndex        =   19
      Top             =   5880
      Width           =   2295
   End
   Begin VB.Label Label12 
      Alignment       =   1  'Right Justify
      BackStyle       =   0  'Transparent
      Caption         =   "Hora de registro:"
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
      Left            =   9360
      TabIndex        =   18
      Top             =   5880
      Width           =   1935
   End
   Begin VB.Label Label13 
      Alignment       =   1  'Right Justify
      BackStyle       =   0  'Transparent
      Caption         =   "Ubicación:"
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
      Left            =   8280
      TabIndex        =   17
      Top             =   7800
      Width           =   1935
   End
   Begin VB.Label Label14 
      Alignment       =   1  'Right Justify
      BackStyle       =   0  'Transparent
      Caption         =   "N° de Asiento:"
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
      Left            =   8280
      TabIndex        =   16
      Top             =   7320
      Width           =   1935
   End
   Begin VB.Label Label15 
      Alignment       =   1  'Right Justify
      BackStyle       =   0  'Transparent
      Caption         =   ".Soles"
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
      Left            =   2760
      TabIndex        =   15
      Top             =   7920
      Width           =   735
   End
   Begin VB.Label Lbl_Id 
      BackStyle       =   0  'Transparent
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000B&
      Height          =   375
      Left            =   1680
      TabIndex        =   14
      Top             =   5880
      Width           =   2775
   End
   Begin VB.Label Label16 
      Alignment       =   1  'Right Justify
      BackStyle       =   0  'Transparent
      Caption         =   "Codigo:"
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
      Height          =   255
      Left            =   0
      TabIndex        =   13
      Top             =   5880
      Width           =   1575
   End
End
Attribute VB_Name = "ClientesForm"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim Obj_Excel   As Object
Dim Obj_Libro   As Object
Dim Obj_Hoja    As Object
Private Sub exportar_Datagrid(Datagrid As Datagrid, TotalFilas As Long)
On Error GoTo MensajeError
If TotalFilas = 0 Then
    MsgBox "Esta Grilla no tiene Registros para Exportar a Excel.", vbCritical, "No hay registros"
    Exit Sub
Else
     Me.MousePointer = vbHourglass
    Set Obj_Excel = CreateObject("Excel.Application")
    Set Obj_Libro = Obj_Excel.Workbooks.Open(App.Path & "\Excel.xls")
    Set Obj_Hoja = Obj_Excel.ActiveSheet
    Columna = 0
        For x = 0 To DataClientes.Columns.Count - 1
            If DataClientes.Columns(x).Visible Then
            Columna = Columna + 1
            Obj_Hoja.cells(1, Columna) = DataClientes.Columns(x).Caption
                For Y = 0 To TotalFilas - 1
                    Obj_Hoja.cells(Y + 2, Columna) = DataClientes.Columns(x).CellValue(DataClientes.GetBookmark(Y))
                Next
            End If
        Next
Obj_Excel.Visible = True
With Obj_Hoja
    .Rows(1).Font.Bold = True
    .Rows(1).Font.Color = vbRed
    .Columns("A:Z").AutoFit
End With
End If
Set Obj_Hoja = Nothing
Set Obj_Libro = Nothing
Set Obj_Excel = Nothing
Me.MousePointer = vbDefault
Exit Sub
MensajeError:
      MsgBox Err.Description, vbCritical
On Error Resume Next
Set Obj_Hoja = Nothing
Set Obj_Libro = Nothing
Set Obj_Excel = Nothing
Me.MousePointer = vbDefault
End Sub
Private Sub Command1_Click()
With RsClientes
    Set DrClientes.DataSource = RsClientes
    DrClientes.WindowState = 2
    Unload Me
    DrClientes.Show
End With
End Sub

Private Sub Command2_Click()
Call exportar_Datagrid(DataClientes, DataClientes.ApproxCount)
End Sub

Private Sub DataClientes_Click()
With RsClientes
        If .BOF Or .EOF Then Exit Sub
        
                    Lbl_Id.Caption = DataClientes.Columns(1).Text
                    TxtNombre.Text = DataClientes.Columns(2).Text
                    TxtApellido.Text = DataClientes.Columns(3).Text
                    TxtDNI.Text = DataClientes.Columns(4).Text
                    TxtPrecio.Text = DataClientes.Columns(5).Text
                    DataBuses.Text = DataClientes.Columns(6).Text
                    TxtTipo.Text = DataClientes.Columns(7).Text
                    TxtOrigen.Text = DataClientes.Columns(8).Text
                    TxtDestino.Text = DataClientes.Columns(9).Text
                    TxtHora.Text = DataClientes.Columns(10).Text
                    TxtFecha.Text = DataClientes.Columns(11).Text
                    TxtTime.Text = DataClientes.Columns(12).Text
                    TxtDate.Text = DataClientes.Columns(13).Text
                    TxtAsiento.Text = DataClientes.Columns(14).Text
                    TxtUbicacion.Text = DataClientes.Columns(15).Text
    End With
End Sub

Private Sub Form_Load()
Clientes
Adodc1.CursorLocation = adUseClient
Adodc1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & App.Path & "\usuario.mdb;Persist Security Info=False"
''Ado como secordset
Adodc1.RecordSource = "select * from Clientes where [ID] like '" & LblIDClientes.Caption & "'"
Adodc1.Refresh
Set DataClientes.DataSource = Adodc1
'Set DataClientes.DataSource = RsClientes
Adodc1.Visible = False
ComboTex.AddItem "Nombres"
ComboTex.AddItem "Apellidos"
ComboTex.AddItem "DNI"
ComboTex.AddItem "Codigo"
ComboTex.AddItem "Codigo de Boleto"
ComboTex.Text = "Nombres"
FormatoData
DataClientes.Visible = False
HabilitarCaja True
End Sub
Private Sub TxtNombres_Change()
    If ComboTex.Text = "Nombres" Then BUSCANOMBRE
    If ComboTex.Text = "DNI" Then BUSCADNI
    If ComboTex.Text = "Apellidos" Then BUSCAAPELLIDO
    If ComboTex.Text = "Codigo" Then BUSCACODIGO
    If ComboTex.Text = "Codigo de Boleto" Then BUSCABOLETO
    
    
DataClientes.Visible = True
End Sub

Sub FormatoData()
    DataClientes.Columns(0).Width = 0
    DataClientes.Columns(1).Width = 1300
    DataClientes.Columns(2).Width = 1800
    DataClientes.Columns(3).Width = 1800
    DataClientes.Columns(4).Width = 1000
    DataClientes.Columns(5).Width = 700
    DataClientes.Columns(6).Width = 1000
    DataClientes.Columns(7).Width = 1000
    DataClientes.Columns(8).Width = 1300
    DataClientes.Columns(9).Width = 1300
    DataClientes.Columns(10).Width = 0
    DataClientes.Columns(11).Width = 0
    DataClientes.Columns(12).Width = 0
    DataClientes.Columns(13).Width = 0
    DataClientes.Columns(14).Width = 0
    DataClientes.Columns(15).Width = 0
    DataClientes.Columns(16).Width = 1300
    
End Sub
Sub BUSCANOMBRE()
Dim Busca As String
    Busca = UCase(Trim(TxtNombres.Text)) & "%"
    Adodc1.RecordSource = "select * from Clientes where [Nombre] like '" & Busca & "'"
    Adodc1.Refresh
    FormatoData
End Sub
Sub BUSCADNI()
    Busca = UCase(Trim(TxtNombres.Text)) & "%"
    Adodc1.RecordSource = "select * from Clientes where [DNI] like '" & Busca & "'"
    Adodc1.Refresh
    FormatoData
End Sub
Sub BUSCAAPELLIDO()
    Busca = UCase(Trim(TxtNombres.Text)) & "%"
    Adodc1.RecordSource = "select * from Clientes where [Apellido] like '" & Busca & "'"
    Adodc1.Refresh
    FormatoData
End Sub
Sub BUSCACODIGO()
    Busca = UCase(Trim(TxtNombres.Text)) & "%"
    Adodc1.RecordSource = "select * from Clientes where [Codigo] like '" & Busca & "'"
    Adodc1.Refresh
    FormatoData
End Sub
Sub BUSCABOLETO()
    Busca = UCase(Trim(TxtNombres.Text)) & "%"
    Adodc1.RecordSource = "select * from Clientes where [Boleto] like '" & Busca & "'"
    Adodc1.Refresh
    FormatoData
End Sub
Public Sub HabilitarCaja(estado As Boolean)
    
                    TxtNombre.Locked = estado
                    TxtApellido.Locked = estado
                    TxtDNI.Locked = estado
                    TxtPrecio.Locked = estado
                    DataBuses.Locked = estado
                    TxtTipo.Locked = estado
                    TxtOrigen.Locked = estado
                    TxtDestino.Locked = estado
                    TxtHora.Locked = estado
                    TxtFecha.Locked = estado
                    TxtTime.Locked = estado
                    TxtDate.Locked = estado
                    TxtAsiento.Locked = estado
                    TxtUbicacion.Locked = estado
End Sub
