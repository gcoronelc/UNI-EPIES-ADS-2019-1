VERSION 5.00
Object = "{67397AA1-7FB1-11D0-B148-00A0C922E820}#6.0#0"; "MSADODC.OCX"
Object = "{CDE57A40-8B86-11D0-B3C6-00A0C90AEA82}#1.0#0"; "MSDATGRD.OCX"
Object = "{F0D2F211-CCB0-11D0-A316-00AA00688B10}#1.0#0"; "MSDATLST.OCX"
Begin VB.Form AsientosForm 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Gestor de Asientos"
   ClientHeight    =   11520
   ClientLeft      =   45
   ClientTop       =   375
   ClientWidth     =   15360
   Icon            =   "AsientosForm.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   MinButton       =   0   'False
   Picture         =   "AsientosForm.frx":058A
   ScaleHeight     =   11520
   ScaleWidth      =   15360
   ShowInTaskbar   =   0   'False
   Begin VB.TextBox TxtCodigo 
      Alignment       =   2  'Center
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
      Left            =   8400
      TabIndex        =   99
      Top             =   2280
      Width           =   2535
   End
   Begin VB.OptionButton OptBusca 
      Caption         =   "Nombres"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Index           =   0
      Left            =   6600
      TabIndex        =   98
      Top             =   6120
      Width           =   1335
   End
   Begin VB.TextBox Texto 
      Appearance      =   0  'Flat
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
      Left            =   6600
      TabIndex        =   95
      Top             =   6480
      Width           =   4215
   End
   Begin VB.OptionButton OptBusca 
      Caption         =   "DNI"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Index           =   2
      Left            =   9840
      TabIndex        =   94
      Top             =   6120
      Width           =   855
   End
   Begin VB.OptionButton OptBusca 
      Caption         =   "Apellidos"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Index           =   1
      Left            =   8160
      TabIndex        =   93
      Top             =   6120
      Width           =   1335
   End
   Begin VB.CommandButton Command1 
      Appearance      =   0  'Flat
      Caption         =   "Vaciar BUS"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   6480
      TabIndex        =   89
      Top             =   7080
      Width           =   2295
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
      Left            =   11520
      MaskColor       =   &H00E0E0E0&
      TabIndex        =   87
      Top             =   5280
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
      Left            =   13320
      MaskColor       =   &H00E0E0E0&
      TabIndex        =   86
      Top             =   5280
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
      Left            =   12360
      MaskColor       =   &H00E0E0E0&
      TabIndex        =   85
      Top             =   7080
      Width           =   1695
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
      Left            =   13320
      MaskColor       =   &H00E0E0E0&
      TabIndex        =   84
      Top             =   6480
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
      Left            =   11520
      MaskColor       =   &H00E0E0E0&
      TabIndex        =   83
      Top             =   6480
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
      Left            =   13320
      MaskColor       =   &H00E0E0E0&
      TabIndex        =   82
      Top             =   5880
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
      Left            =   11520
      MaskColor       =   &H00E0E0E0&
      TabIndex        =   81
      Top             =   5880
      Width           =   1575
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
      Left            =   12960
      TabIndex        =   78
      Top             =   4200
      Width           =   1935
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
      Left            =   12960
      TabIndex        =   77
      Top             =   4680
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
      Left            =   8400
      TabIndex        =   67
      Top             =   4200
      Width           =   1095
   End
   Begin VB.TextBox TxtDNI 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000C&
      BeginProperty DataFormat 
         Type            =   0
         Format          =   "0"
         HaveTrueFalseNull=   0
         FirstDayOfWeek  =   0
         FirstWeekOfYear =   0
         LCID            =   10250
         SubFormatType   =   0
      EndProperty
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
      Left            =   8400
      TabIndex        =   65
      Top             =   3720
      Width           =   1935
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
      Left            =   8400
      TabIndex        =   63
      Top             =   3240
      Width           =   2535
   End
   Begin MSDataGridLib.DataGrid DataClientes 
      Height          =   2415
      Left            =   6480
      TabIndex        =   61
      Top             =   7680
      Width           =   8655
      _ExtentX        =   15266
      _ExtentY        =   4260
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
      Caption         =   "Clientes"
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
      Left            =   8400
      TabIndex        =   60
      Top             =   2760
      Width           =   2535
   End
   Begin VB.CommandButton Cmd25l 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000E&
      Caption         =   "25"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   20.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   2880
      MaskColor       =   &H00FFFFFF&
      Picture         =   "AsientosForm.frx":9CB1B
      Style           =   1  'Graphical
      TabIndex        =   59
      Top             =   10200
      Width           =   975
   End
   Begin VB.CommandButton Cmd25o 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000E&
      Caption         =   "25"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   20.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   2880
      MaskColor       =   &H00FFFFFF&
      Picture         =   "AsientosForm.frx":9D3D2
      Style           =   1  'Graphical
      TabIndex        =   58
      Top             =   10200
      Width           =   975
   End
   Begin VB.CommandButton Cmd21l 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000E&
      Caption         =   "21"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   20.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   4920
      MaskColor       =   &H00FFFFFF&
      Picture         =   "AsientosForm.frx":9DB64
      Style           =   1  'Graphical
      TabIndex        =   56
      Top             =   10200
      Width           =   1095
   End
   Begin VB.CommandButton Cmd22l 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000E&
      Caption         =   "22"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   20.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   3840
      MaskColor       =   &H00FFFFFF&
      Picture         =   "AsientosForm.frx":9E41B
      Style           =   1  'Graphical
      TabIndex        =   54
      Top             =   10200
      Width           =   1095
   End
   Begin VB.CommandButton Cmd24l 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000E&
      Caption         =   "24"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   20.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   1800
      MaskColor       =   &H00FFFFFF&
      Picture         =   "AsientosForm.frx":9ECD2
      Style           =   1  'Graphical
      TabIndex        =   52
      Top             =   10200
      Width           =   1095
   End
   Begin VB.CommandButton Cmd23l 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000E&
      Caption         =   "23"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   20.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   720
      MaskColor       =   &H00FFFFFF&
      Picture         =   "AsientosForm.frx":9F589
      Style           =   1  'Graphical
      TabIndex        =   50
      Top             =   10200
      Width           =   1095
   End
   Begin VB.CommandButton Cmd17l 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000E&
      Caption         =   "17"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   20.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   4920
      MaskColor       =   &H00FFFFFF&
      Picture         =   "AsientosForm.frx":9FE40
      Style           =   1  'Graphical
      TabIndex        =   48
      Top             =   8880
      Width           =   1095
   End
   Begin VB.CommandButton Cmd18l 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000E&
      Caption         =   "18"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   20.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   3840
      MaskColor       =   &H00FFFFFF&
      Picture         =   "AsientosForm.frx":A06F7
      Style           =   1  'Graphical
      TabIndex        =   46
      Top             =   8880
      Width           =   1095
   End
   Begin VB.CommandButton Cmd20l 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000E&
      Caption         =   "20"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   20.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   1800
      MaskColor       =   &H00FFFFFF&
      Picture         =   "AsientosForm.frx":A0FAE
      Style           =   1  'Graphical
      TabIndex        =   44
      Top             =   8880
      Width           =   1095
   End
   Begin VB.CommandButton Cmd19l 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000E&
      Caption         =   "19"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   20.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   720
      MaskColor       =   &H00FFFFFF&
      Picture         =   "AsientosForm.frx":A1865
      Style           =   1  'Graphical
      TabIndex        =   42
      Top             =   8880
      Width           =   1095
   End
   Begin VB.CommandButton Cmd13l 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000E&
      Caption         =   "13"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   20.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   4920
      MaskColor       =   &H00FFFFFF&
      Picture         =   "AsientosForm.frx":A211C
      Style           =   1  'Graphical
      TabIndex        =   40
      Top             =   7440
      Width           =   1095
   End
   Begin VB.CommandButton Cmd14l 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000E&
      Caption         =   "14"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   20.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   3840
      MaskColor       =   &H00FFFFFF&
      Picture         =   "AsientosForm.frx":A29D3
      Style           =   1  'Graphical
      TabIndex        =   38
      Top             =   7440
      Width           =   1095
   End
   Begin VB.CommandButton Cmd16l 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000E&
      Caption         =   "16"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   20.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   1800
      MaskColor       =   &H00FFFFFF&
      Picture         =   "AsientosForm.frx":A328A
      Style           =   1  'Graphical
      TabIndex        =   36
      Top             =   7440
      Width           =   1095
   End
   Begin VB.CommandButton Cmd15l 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000E&
      Caption         =   "15"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   20.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   720
      MaskColor       =   &H00FFFFFF&
      Picture         =   "AsientosForm.frx":A3B41
      Style           =   1  'Graphical
      TabIndex        =   34
      Top             =   7440
      Width           =   1095
   End
   Begin VB.CommandButton Cmd9l 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000E&
      Caption         =   "9"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   20.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   4920
      MaskColor       =   &H00FFFFFF&
      Picture         =   "AsientosForm.frx":A43F8
      Style           =   1  'Graphical
      TabIndex        =   32
      Top             =   6000
      Width           =   1095
   End
   Begin VB.CommandButton Cmd10l 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000E&
      Caption         =   "10"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   20.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   3840
      MaskColor       =   &H00FFFFFF&
      Picture         =   "AsientosForm.frx":A4CAF
      Style           =   1  'Graphical
      TabIndex        =   30
      Top             =   6000
      Width           =   1095
   End
   Begin VB.CommandButton Cmd12l 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000E&
      Caption         =   "12"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   20.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   1800
      MaskColor       =   &H00FFFFFF&
      Picture         =   "AsientosForm.frx":A5566
      Style           =   1  'Graphical
      TabIndex        =   28
      Top             =   6000
      Width           =   1095
   End
   Begin VB.CommandButton Cmd11l 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000E&
      Caption         =   "11"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   20.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   720
      MaskColor       =   &H00FFFFFF&
      Picture         =   "AsientosForm.frx":A5E1D
      Style           =   1  'Graphical
      TabIndex        =   26
      Top             =   6000
      Width           =   1095
   End
   Begin VB.CommandButton Cmd8l 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000E&
      Caption         =   "8"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   20.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   1800
      MaskColor       =   &H00FFFFFF&
      Picture         =   "AsientosForm.frx":A66D4
      Style           =   1  'Graphical
      TabIndex        =   24
      Top             =   4680
      Width           =   1095
   End
   Begin VB.CommandButton Cmd7l 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000E&
      Caption         =   "7"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   20.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   720
      MaskColor       =   &H00FFFFFF&
      Picture         =   "AsientosForm.frx":A6F8B
      Style           =   1  'Graphical
      TabIndex        =   22
      Top             =   4680
      Width           =   1095
   End
   Begin VB.CommandButton Cmd5l 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000E&
      Caption         =   "5"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   20.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   4920
      MaskColor       =   &H00FFFFFF&
      Picture         =   "AsientosForm.frx":A7842
      Style           =   1  'Graphical
      TabIndex        =   20
      Top             =   3960
      Width           =   1095
   End
   Begin VB.CommandButton Cmd6l 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000E&
      Caption         =   "6"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   20.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   3840
      MaskColor       =   &H00FFFFFF&
      Picture         =   "AsientosForm.frx":A80F9
      Style           =   1  'Graphical
      TabIndex        =   18
      Top             =   3960
      Width           =   1095
   End
   Begin VB.CommandButton Cmd3l 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000E&
      Caption         =   "3"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   20.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   4920
      MaskColor       =   &H00FFFFFF&
      Picture         =   "AsientosForm.frx":A89B0
      Style           =   1  'Graphical
      TabIndex        =   16
      Top             =   2880
      Width           =   1095
   End
   Begin VB.CommandButton Cmd4l 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000E&
      Caption         =   "4"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   20.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   3840
      MaskColor       =   &H00FFFFFF&
      Picture         =   "AsientosForm.frx":A9267
      Style           =   1  'Graphical
      TabIndex        =   14
      Top             =   2880
      Width           =   1095
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
      Left            =   12960
      TabIndex        =   13
      Top             =   1800
      Width           =   1935
   End
   Begin VB.CommandButton Ocupado 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000E&
      Caption         =   "Ocupado"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   450
      Left            =   3360
      MaskColor       =   &H00FFFFFF&
      Picture         =   "AsientosForm.frx":A9B1E
      Style           =   1  'Graphical
      TabIndex        =   12
      Top             =   1200
      Width           =   1455
   End
   Begin VB.CommandButton Libre 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000E&
      Caption         =   "Libre"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   450
      Left            =   1920
      MaskColor       =   &H00FFFFFF&
      Picture         =   "AsientosForm.frx":AA2B0
      Style           =   1  'Graphical
      TabIndex        =   11
      Top             =   1200
      Width           =   1455
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
      Left            =   8400
      TabIndex        =   10
      Top             =   1800
      Width           =   1935
   End
   Begin VB.Timer Timer1 
      Interval        =   1
      Left            =   240
      Top             =   1800
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
      Left            =   12960
      TabIndex        =   8
      Top             =   3240
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
      Left            =   12960
      TabIndex        =   7
      Top             =   3720
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
      Left            =   12960
      TabIndex        =   6
      Top             =   2760
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
      Left            =   12960
      TabIndex        =   5
      Top             =   2280
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
      Left            =   8400
      TabIndex        =   4
      Top             =   1320
      Width           =   1935
   End
   Begin VB.CommandButton Cmd1l 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000E&
      Caption         =   "1"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   20.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   720
      MaskColor       =   &H00FFFFFF&
      Picture         =   "AsientosForm.frx":AAB67
      Style           =   1  'Graphical
      TabIndex        =   1
      Top             =   3480
      Width           =   1095
   End
   Begin VB.CommandButton Cmd1o 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000E&
      Caption         =   "1"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   20.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   720
      MaskColor       =   &H00FFFFFF&
      Picture         =   "AsientosForm.frx":AB41E
      Style           =   1  'Graphical
      TabIndex        =   0
      Top             =   3480
      Width           =   1095
   End
   Begin VB.CommandButton Cmd2l 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000E&
      Caption         =   "2"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   20.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   1800
      MaskColor       =   &H00FFFFFF&
      Picture         =   "AsientosForm.frx":ABBB0
      Style           =   1  'Graphical
      TabIndex        =   2
      Top             =   3480
      Width           =   1095
   End
   Begin VB.CommandButton Cmd2o 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000E&
      Caption         =   "2"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   20.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   1800
      MaskColor       =   &H00FFFFFF&
      Picture         =   "AsientosForm.frx":AC467
      Style           =   1  'Graphical
      TabIndex        =   3
      Top             =   3480
      Width           =   1095
   End
   Begin MSDataListLib.DataCombo DataBuses 
      Height          =   405
      Left            =   12960
      TabIndex        =   9
      Top             =   1320
      Width           =   2175
      _ExtentX        =   3836
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
   Begin VB.CommandButton Cmd3o 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000E&
      Caption         =   "3"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   20.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   4920
      MaskColor       =   &H00FFFFFF&
      Picture         =   "AsientosForm.frx":ACBF9
      Style           =   1  'Graphical
      TabIndex        =   17
      Top             =   2880
      Width           =   1095
   End
   Begin VB.CommandButton Cmd4o 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000E&
      Caption         =   "4"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   20.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   3840
      MaskColor       =   &H00FFFFFF&
      Picture         =   "AsientosForm.frx":AD38B
      Style           =   1  'Graphical
      TabIndex        =   15
      Top             =   2880
      Width           =   1095
   End
   Begin VB.CommandButton Cmd5o 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000E&
      Caption         =   "5"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   20.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   4920
      MaskColor       =   &H00FFFFFF&
      Picture         =   "AsientosForm.frx":ADB1D
      Style           =   1  'Graphical
      TabIndex        =   21
      Top             =   3960
      Width           =   1095
   End
   Begin VB.CommandButton Cmd6o 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000E&
      Caption         =   "6"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   20.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   3840
      MaskColor       =   &H00FFFFFF&
      Picture         =   "AsientosForm.frx":AE2AF
      Style           =   1  'Graphical
      TabIndex        =   19
      Top             =   3960
      Width           =   1095
   End
   Begin VB.CommandButton Cmd7o 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000E&
      Caption         =   "7"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   20.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   720
      MaskColor       =   &H00FFFFFF&
      Picture         =   "AsientosForm.frx":AEA41
      Style           =   1  'Graphical
      TabIndex        =   23
      Top             =   4680
      Width           =   1095
   End
   Begin VB.CommandButton Cmd8o 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000E&
      Caption         =   "8"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   20.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   1800
      MaskColor       =   &H00FFFFFF&
      Picture         =   "AsientosForm.frx":AF1D3
      Style           =   1  'Graphical
      TabIndex        =   25
      Top             =   4680
      Width           =   1095
   End
   Begin VB.CommandButton Cmd9o 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000E&
      Caption         =   "9"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   20.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   4920
      MaskColor       =   &H00FFFFFF&
      Picture         =   "AsientosForm.frx":AF965
      Style           =   1  'Graphical
      TabIndex        =   33
      Top             =   6000
      Width           =   1095
   End
   Begin VB.CommandButton Cmd10o 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000E&
      Caption         =   "10"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   20.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   3840
      MaskColor       =   &H00FFFFFF&
      Picture         =   "AsientosForm.frx":B00F7
      Style           =   1  'Graphical
      TabIndex        =   31
      Top             =   6000
      Width           =   1095
   End
   Begin VB.CommandButton Cmd11o 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000E&
      Caption         =   "11"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   20.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   720
      MaskColor       =   &H00FFFFFF&
      Picture         =   "AsientosForm.frx":B0889
      Style           =   1  'Graphical
      TabIndex        =   27
      Top             =   6000
      Width           =   1095
   End
   Begin VB.CommandButton Cmd12o 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000E&
      Caption         =   "12"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   20.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   1800
      MaskColor       =   &H00FFFFFF&
      Picture         =   "AsientosForm.frx":B101B
      Style           =   1  'Graphical
      TabIndex        =   29
      Top             =   6000
      Width           =   1095
   End
   Begin VB.CommandButton Cmd13o 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000E&
      Caption         =   "13"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   20.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   4920
      MaskColor       =   &H00FFFFFF&
      Picture         =   "AsientosForm.frx":B17AD
      Style           =   1  'Graphical
      TabIndex        =   41
      Top             =   7440
      Width           =   1095
   End
   Begin VB.CommandButton Cmd14o 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000E&
      Caption         =   "14"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   20.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   3840
      MaskColor       =   &H00FFFFFF&
      Picture         =   "AsientosForm.frx":B1F3F
      Style           =   1  'Graphical
      TabIndex        =   39
      Top             =   7440
      Width           =   1095
   End
   Begin VB.CommandButton Cmd15o 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000E&
      Caption         =   "15"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   20.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   720
      MaskColor       =   &H00FFFFFF&
      Picture         =   "AsientosForm.frx":B26D1
      Style           =   1  'Graphical
      TabIndex        =   35
      Top             =   7440
      Width           =   1095
   End
   Begin VB.CommandButton Cmd16o 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000E&
      Caption         =   "16"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   20.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   1800
      MaskColor       =   &H00FFFFFF&
      Picture         =   "AsientosForm.frx":B2E63
      Style           =   1  'Graphical
      TabIndex        =   37
      Top             =   7440
      Width           =   1095
   End
   Begin VB.CommandButton Cmd17o 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000E&
      Caption         =   "17"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   20.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   4920
      MaskColor       =   &H00FFFFFF&
      Picture         =   "AsientosForm.frx":B35F5
      Style           =   1  'Graphical
      TabIndex        =   49
      Top             =   8880
      Width           =   1095
   End
   Begin VB.CommandButton Cmd18o 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000E&
      Caption         =   "18"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   20.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   3840
      MaskColor       =   &H00FFFFFF&
      Picture         =   "AsientosForm.frx":B3D87
      Style           =   1  'Graphical
      TabIndex        =   47
      Top             =   8880
      Width           =   1095
   End
   Begin VB.CommandButton Cmd19o 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000E&
      Caption         =   "19"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   20.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   720
      MaskColor       =   &H00FFFFFF&
      Picture         =   "AsientosForm.frx":B4519
      Style           =   1  'Graphical
      TabIndex        =   43
      Top             =   8880
      Width           =   1095
   End
   Begin VB.CommandButton Cmd20o 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000E&
      Caption         =   "20"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   20.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   1800
      MaskColor       =   &H00FFFFFF&
      Picture         =   "AsientosForm.frx":B4CAB
      Style           =   1  'Graphical
      TabIndex        =   45
      Top             =   8880
      Width           =   1095
   End
   Begin VB.CommandButton Cmd21o 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000E&
      Caption         =   "21"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   20.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   4920
      MaskColor       =   &H00FFFFFF&
      Picture         =   "AsientosForm.frx":B543D
      Style           =   1  'Graphical
      TabIndex        =   57
      Top             =   10200
      Width           =   1095
   End
   Begin VB.CommandButton Cmd22o 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000E&
      Caption         =   "22"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   20.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   3840
      MaskColor       =   &H00FFFFFF&
      Picture         =   "AsientosForm.frx":B5BCF
      Style           =   1  'Graphical
      TabIndex        =   55
      Top             =   10200
      Width           =   1095
   End
   Begin VB.CommandButton Cmd23o 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000E&
      Caption         =   "23"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   20.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   720
      MaskColor       =   &H00FFFFFF&
      Picture         =   "AsientosForm.frx":B6361
      Style           =   1  'Graphical
      TabIndex        =   51
      Top             =   10200
      Width           =   1095
   End
   Begin VB.CommandButton Cmd24o 
      Appearance      =   0  'Flat
      BackColor       =   &H8000000E&
      Caption         =   "24"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   20.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   1800
      MaskColor       =   &H00FFFFFF&
      Picture         =   "AsientosForm.frx":B6AF3
      Style           =   1  'Graphical
      TabIndex        =   53
      Top             =   10200
      Width           =   1095
   End
   Begin VB.Frame Frame1 
      Caption         =   "Gestor de Clientes [-Busqueda-]"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1215
      Left            =   6480
      TabIndex        =   92
      Top             =   5760
      Width           =   4455
   End
   Begin MSAdodcLib.Adodc Adodc1 
      Height          =   450
      Left            =   8760
      Top             =   7080
      Width           =   2175
      _ExtentX        =   3836
      _ExtentY        =   794
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
   Begin MSDataGridLib.DataGrid DataClientes1 
      Height          =   1335
      Left            =   6480
      TabIndex        =   97
      Top             =   10080
      Width           =   8655
      _ExtentX        =   15266
      _ExtentY        =   2355
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
   Begin VB.Label LblBoleto 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "Boleto"
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
      Left            =   11280
      TabIndex        =   101
      Top             =   720
      Width           =   3375
   End
   Begin VB.Label Label17 
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
      Height          =   375
      Left            =   6360
      TabIndex        =   100
      Top             =   2280
      Width           =   1935
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
      Left            =   0
      TabIndex        =   96
      Top             =   0
      Width           =   2175
   End
   Begin VB.Label Label16 
      Alignment       =   1  'Right Justify
      BackStyle       =   0  'Transparent
      Caption         =   "ID de Cliente:"
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
      Left            =   6600
      TabIndex        =   91
      Top             =   5040
      Width           =   1575
   End
   Begin VB.Label Lbl_Id 
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
      Left            =   8280
      TabIndex        =   90
      Top             =   4920
      Width           =   1695
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
      Left            =   9480
      TabIndex        =   88
      Top             =   4320
      Width           =   735
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
      Left            =   10920
      TabIndex        =   80
      Top             =   4200
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
      Left            =   10920
      TabIndex        =   79
      Top             =   4680
      Width           =   1935
   End
   Begin VB.Label Label12 
      Alignment       =   1  'Right Justify
      BackStyle       =   0  'Transparent
      Caption         =   "Hora actual:"
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
      Left            =   6360
      TabIndex        =   76
      Top             =   1320
      Width           =   1935
   End
   Begin VB.Label Label11 
      Alignment       =   1  'Right Justify
      BackStyle       =   0  'Transparent
      Caption         =   "Fecha actual:"
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
      Left            =   6360
      TabIndex        =   75
      Top             =   1800
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
      Left            =   10920
      TabIndex        =   74
      Top             =   3240
      Width           =   1935
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
      Left            =   10920
      TabIndex        =   73
      Top             =   3720
      Width           =   1935
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
      Left            =   10920
      TabIndex        =   72
      Top             =   2760
      Width           =   1935
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
      Left            =   10920
      TabIndex        =   71
      Top             =   2280
      Width           =   1935
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
      Left            =   10920
      TabIndex        =   70
      Top             =   1800
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
      Left            =   10920
      TabIndex        =   69
      Top             =   1320
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
      Left            =   6360
      TabIndex        =   68
      Top             =   4200
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
      Left            =   6360
      TabIndex        =   66
      Top             =   3720
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
      Left            =   6360
      TabIndex        =   64
      Top             =   3240
      Width           =   1935
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
      Left            =   6360
      TabIndex        =   62
      Top             =   2760
      Width           =   1935
   End
End
Attribute VB_Name = "AsientosForm"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Cmd10l_Click()
TxtAsiento.Text = "10"
TxtUbicacion.Text = "Pasadizo"
    Cmd10l.Visible = False
End Sub

Private Sub Cmd10o_Click()
If MsgBox("Desea Liberar el Asiento 10:", vbInformation + vbYesNo) = vbYes Then
    Cmd10l.Visible = True
End If
End Sub

Private Sub Cmd11l_Click()
TxtAsiento.Text = "11"
TxtUbicacion.Text = "Ventana"
    Cmd11l.Visible = False
End Sub

Private Sub Cmd11o_Click()
If MsgBox("Desea Liberar el Asiento 11:", vbInformation + vbYesNo) = vbYes Then
    Cmd11l.Visible = True
End If
End Sub

Private Sub Cmd12l_Click()
TxtAsiento.Text = "12"
TxtUbicacion.Text = "Pasadizo"
    Cmd12l.Visible = False
End Sub

Private Sub Cmd12o_Click()
If MsgBox("Desea Liberar el Asiento 12:", vbInformation + vbYesNo) = vbYes Then
    Cmd12l.Visible = True
End If
End Sub

Private Sub Cmd13l_Click()
TxtAsiento.Text = "13"
TxtUbicacion.Text = "Ventana"
   ''pones en falso el boton
    Cmd13l.Visible = False
End Sub

Private Sub Cmd13o_Click()
If MsgBox("Desea Liberar el Asiento 13:", vbInformation + vbYesNo) = vbYes Then
    Cmd13l.Visible = True
End If
End Sub

Private Sub Cmd14l_Click()
TxtAsiento.Text = "14"
TxtUbicacion.Text = "Pasadizo"
    Cmd14l.Visible = False
End Sub

Private Sub Cmd14o_Click()
If MsgBox("Desea Liberar el Asiento 14:", vbInformation + vbYesNo) = vbYes Then
    Cmd14l.Visible = True
End If
End Sub

Private Sub Cmd15l_Click()
TxtAsiento.Text = "15"
TxtUbicacion.Text = "Ventana"
    Cmd15l.Visible = False
End Sub

Private Sub Cmd15o_Click()
If MsgBox("Desea Liberar el Asiento 15:", vbInformation + vbYesNo) = vbYes Then
    Cmd15l.Visible = True
End If
End Sub

Private Sub Cmd16l_Click()
TxtAsiento.Text = "16"
TxtUbicacion.Text = "Pasadizo"
    Cmd16l.Visible = False
End Sub

Private Sub Cmd16o_Click()
If MsgBox("Desea Liberar el Asiento 16:", vbInformation + vbYesNo) = vbYes Then
    Cmd16l.Visible = True
End If
End Sub

Private Sub Cmd17l_Click()
TxtAsiento.Text = "17"
TxtUbicacion.Text = "Ventana"
   ''pones en falso el boton
    Cmd17l.Visible = False
End Sub

Private Sub Cmd17o_Click()
If MsgBox("Desea Liberar el Asiento 17:", vbInformation + vbYesNo) = vbYes Then
    Cmd17l.Visible = True
End If
End Sub

Private Sub Cmd18l_Click()
TxtAsiento.Text = "18"
TxtUbicacion.Text = "Pasadizo"
    Cmd18l.Visible = False
End Sub

Private Sub Cmd18o_Click()
If MsgBox("Desea Liberar el Asiento 18:", vbInformation + vbYesNo) = vbYes Then
    Cmd18l.Visible = True
End If
End Sub

Private Sub Cmd19l_Click()
TxtAsiento.Text = "19"
TxtUbicacion.Text = "Ventana"
    Cmd19l.Visible = False
End Sub

Private Sub Cmd19o_Click()
If MsgBox("Desea Liberar el Asiento 19:", vbInformation + vbYesNo) = vbYes Then
    Cmd19l.Visible = True
End If
End Sub

Private Sub Cmd1l_Click()
TxtAsiento.Text = "1"
TxtUbicacion.Text = "Ventana"
   ''pones en falso el boton
    Cmd1l.Visible = False
End Sub

Private Sub Cmd1o_Click()
If MsgBox("Desea Liberar el Asiento 1:", vbInformation + vbYesNo) = vbYes Then
    Cmd1l.Visible = True
End If
End Sub

Private Sub Cmd20l_Click()
TxtAsiento.Text = "20"
TxtUbicacion.Text = "Pasadizo"
    Cmd20l.Visible = False
End Sub

Private Sub Cmd20o_Click()
If MsgBox("Desea Liberar el Asiento 20:", vbInformation + vbYesNo) = vbYes Then
    Cmd20l.Visible = True
End If
End Sub

Private Sub Cmd21l_Click()
TxtAsiento.Text = "21"
TxtUbicacion.Text = "Ventana"
   ''pones en falso el boton
    Cmd21l.Visible = False
End Sub

Private Sub Cmd21o_Click()
If MsgBox("Desea Liberar el Asiento 21:", vbInformation + vbYesNo) = vbYes Then
    Cmd21l.Visible = True
End If
End Sub

Private Sub Cmd22l_Click()
TxtAsiento.Text = "22"
TxtUbicacion.Text = "Pasadizo"
    Cmd22l.Visible = False
End Sub

Private Sub Cmd22o_Click()
If MsgBox("Desea Liberar el Asiento 22:", vbInformation + vbYesNo) = vbYes Then
    Cmd22l.Visible = True
End If
End Sub

Private Sub Cmd23l_Click()
TxtAsiento.Text = "23"
TxtUbicacion.Text = "Ventana"
    Cmd23l.Visible = False
End Sub

Private Sub Cmd23o_Click()
If MsgBox("Desea Liberar el Asiento 23:", vbInformation + vbYesNo) = vbYes Then
    Cmd23l.Visible = True
End If
End Sub

Private Sub Cmd24l_Click()
TxtAsiento.Text = "24"
TxtUbicacion.Text = "Pasadizo"
    Cmd24l.Visible = False
End Sub

Private Sub Cmd24o_Click()
If MsgBox("Desea Liberar el Asiento 24:", vbInformation + vbYesNo) = vbYes Then
    Cmd24l.Visible = True
End If
End Sub

Private Sub Cmd25l_Click()
TxtAsiento.Text = "25"
TxtUbicacion.Text = "Pasadizo"
    Cmd25l.Visible = False
End Sub

Private Sub Cmd25o_Click()
If MsgBox("Desea Liberar el Asiento 25:", vbInformation + vbYesNo) = vbYes Then
    Cmd25l.Visible = True
End If
End Sub

Private Sub Cmd2l_Click()
TxtAsiento.Text = "2"
TxtUbicacion.Text = "Pasadizo"
    Cmd2l.Visible = False
End Sub
Private Sub cmd2o_click()
If MsgBox("Desea Liberar el Asiento 2:", vbInformation + vbYesNo) = vbYes Then
    Cmd2l.Visible = True
End If
End Sub

Private Sub Cmd3l_Click()
TxtAsiento.Text = "3"
TxtUbicacion.Text = "Ventana"
   ''pones en falso el boton
    Cmd3l.Visible = False
End Sub

Private Sub Cmd3o_Click()
If MsgBox("Desea Liberar el Asiento 3:", vbInformation + vbYesNo) = vbYes Then
    Cmd3l.Visible = True
End If
End Sub

Private Sub Cmd4l_Click()
TxtAsiento.Text = "4"
TxtUbicacion.Text = "Pasadizo"
    Cmd4l.Visible = False
End Sub

Private Sub Cmd4o_Click()
If MsgBox("Desea Liberar el Asiento 4:", vbInformation + vbYesNo) = vbYes Then
    Cmd4l.Visible = True
End If
End Sub

Private Sub Cmd5l_Click()
TxtAsiento.Text = "5"
TxtUbicacion.Text = "Ventana"
   ''pones en falso el boton
    Cmd5l.Visible = False
End Sub

Private Sub Cmd5o_Click()
If MsgBox("Desea Liberar el Asiento 5:", vbInformation + vbYesNo) = vbYes Then
    Cmd5l.Visible = True
End If
End Sub

Private Sub Cmd6l_Click()
TxtAsiento.Text = "6"
TxtUbicacion.Text = "Pasadizo"
    Cmd6l.Visible = False
End Sub

Private Sub Cmd6o_Click()
If MsgBox("Desea Liberar el Asiento 6:", vbInformation + vbYesNo) = vbYes Then
    Cmd6l.Visible = True
End If
End Sub

Private Sub Cmd7l_Click()
TxtAsiento.Text = "7"
TxtUbicacion.Text = "Ventana"
    Cmd7l.Visible = False
End Sub

Private Sub Cmd7o_Click()
If MsgBox("Desea Liberar el Asiento 7:", vbInformation + vbYesNo) = vbYes Then
    Cmd7l.Visible = True
End If
End Sub

Private Sub Cmd8l_Click()
TxtAsiento.Text = "8"
TxtUbicacion.Text = "Pasadizo"
    Cmd8l.Visible = False
End Sub

Private Sub Cmd8o_Click()
If MsgBox("Desea Liberar el Asiento 8:", vbInformation + vbYesNo) = vbYes Then
    Cmd8l.Visible = True
End If
End Sub

Private Sub Cmd9l_Click()
TxtAsiento.Text = "9"
TxtUbicacion.Text = "Ventana"
   ''pones en falso el boton
    Cmd9l.Visible = False
End Sub

Private Sub Cmd9o_Click()
If MsgBox("Desea Liberar el Asiento 9:", vbInformation + vbYesNo) = vbYes Then
    Cmd9l.Visible = True
End If
End Sub

Private Sub cmdBuscar_Click()
  RegistrodelCliente = InputBox("Ingrese el Nombre que desea buscar: ", "Busqueda", "Ingrese el Nombre del Cliente")
    If RegistrodelCliente = "" Then
        MsgBox "Nose ingreso ningun texto", vbInformation, "Aviso"
        Exit Sub
        Else
        With RsClientes
            .Requery
            .Find "Nombre='" & Trim(RegistrodelCliente) & "'"
            If .EOF Then
            MsgBox "Nose encontro ningun registro", vbInformation, "Aviso"
            Exit Sub
                Else
                    '''llenar la caja de texto pos
                    Lbl_Id.Caption = !Id
                    TxtNombre.Text = !NOmbre
                    TxtApellido.Text = !Apellido
                    TxtDNI.Text = !DNI
                    TxtPrecio.Text = !Precio
                    DataBuses.Text = !Bus
                    TxtTipo.Text = !Tipo
                    TxtOrigen.Text = !origen
                    TxtDestino.Text = !Destino
                    TxtHora.Text = !H_salida
                    TxtFecha.Text = !F_salida
                    TxtTime.Text = !H_registro
                    TxtDate.Text = !F_registro
                    TxtAsiento.Text = !N_asiento
                    TxtUbicacion.Text = !Ubicacion
            End If
        End With

End If
End Sub

Private Sub cmdCancelar_Click()

HabilitarCaja True
HabilitarBotones True, False
Limpiar
End Sub

Private Sub cmdEliminar_Click()
If IdCliente = 0 Then
    MsgBox "Elija un registro...", vbInformation, "aviso"
    Exit Sub
    Else
        With RsClientes
            .Find "Id='" & Trim(IdCliente) & "'"
            If .EOF Then '' si encontro el registro
            MsgBox "No se encontro el registro", vbInformation, "Aviso"
            Exit Sub
            Else
                If MsgBox("No le recomendamos eliminar...!" & vbNewLine & " " & vbNewLine & "   Dese eliminar al cliente : " & DataClientes.Columns(1).Text, vbInformation + vbYesNo) = vbYes Then
                .Delete
                .Requery
                End If
            End If
        End With
End If
End Sub

Private Sub cmdGrabar_Click()
If TxtNombre.Text = "" Then MsgBox "El campo Nombres esta vacio", vbInformation, "Aviso": TxtNombre.SetFocus: Exit Sub
If TxtApellido.Text = "" Then MsgBox "El campo Apellodos esta vacio", vbInformation, "Aviso": TxtApellido.SetFocus: Exit Sub
If TxtDNI.Text = "" Then MsgBox "El campo DNI esta vacio", vbInformation, "Aviso": TxtDNI.SetFocus: Exit Sub
If TxtPrecio.Text = "" Then MsgBox "El campo Precio esta vacio", vbInformation, "Aviso": TxtPrecio.SetFocus: Exit Sub
If DataBuses.Text = "" Then MsgBox "El campo ID de BUS esta vacio", vbInformation, "Aviso": DataBuses.SetFocus: Exit Sub
If TxtTipo.Text = "" Then MsgBox "El campo Tipo esta vacio", vbInformation, "Aviso": TxtTipo.SetFocus: Exit Sub
If TxtOrigen.Text = "" Then MsgBox "El campo Origen esta vacio", vbInformation, "Aviso": TxtOrigen.SetFocus: Exit Sub
If TxtDestino.Text = "" Then MsgBox "El campo Destino esta vacio", vbInformation, "Aviso": TxtDestino.SetFocus: Exit Sub
If TxtHora.Text = "" Then MsgBox "El campo Hora de salida esta vacio", vbInformation, "Aviso": TxtHora.SetFocus: Exit Sub
If TxtFecha.Text = "" Then MsgBox "El campo Fecha de salida esta vacio", vbInformation, "Aviso": TxtFecha.SetFocus: Exit Sub
If TxtTime.Text = "" Then MsgBox "El campo Hora actual esta vacio", vbInformation, "Aviso": TxtTime.SetFocus: Exit Sub
If TxtDate.Text = "" Then MsgBox "El campo Fecha actual esta vacio", vbInformation, "Aviso": TxtDate.SetFocus: Exit Sub
If TxtAsiento.Text = "" Then MsgBox "El campo Asiento esta vacio", vbInformation, "Aviso": TxtAsiento.SetFocus: Exit Sub
If TxtUbicacion.Text = "" Then MsgBox "El campo Ubicación esta vacio", vbInformation, "Aviso": TxtUbicacion.SetFocus: Exit Sub

    ''pregunta si el nuevo registro Modi = false
    If Modi = False Then ''crear un nuevo registro
    With RsClientes
        .Requery
        .AddNew
            !Codigo = TxtCodigo.Text
            !NOmbre = TxtNombre.Text
            !Apellido = TxtApellido.Text
            !DNI = TxtDNI.Text
            !Precio = TxtPrecio.Text
            !Bus = DataBuses.Text
            !Tipo = TxtTipo.Text
            !origen = TxtOrigen.Text
            !Destino = TxtDestino.Text
            !H_salida = TxtHora.Text
            !F_salida = TxtFecha.Text
            !H_registro = TxtTime.Text
            !F_registro = TxtDate.Text
            !N_asiento = TxtAsiento.Text
            !Ubicacion = TxtUbicacion.Text
            !Boleto = LblBoleto.Caption
            .Update
            .Requery
            
            '''''''''''''''''''''''''''''''FACTURACION'''''''''''''''''''''''''
    With RsClientes
        Dim Idbus
        Idbus = !Id
        If .EOF Then Exit Sub
        Lbl_Id.Caption = Idbus
        FacID = Idbus
    End With
    ''''codigo de cliente
    With RsCodigo
        .Requery
        .MoveFirst
        !Codigo = CodigoGuardar
        .UpdateBatch
    End With
    With RsBoleto
        .Requery
        .MoveFirst
        !Codigo = BoletoGuardar
        .UpdateBatch
    End With
    FacCodigo = TxtCodigo
    FacNombre = TxtNombre.Text
    FacApellido = TxtApellido.Text
    FacDNI = TxtDNI.Text
    FacPrecio = TxtPrecio.Text
    FacBus = DataBuses.Text
    FacTipo = TxtTipo.Text
    FacOrigen = TxtOrigen.Text
    FacDestino = TxtDestino.Text
    FacHSalida = TxtHora.Text
    FacFSalida = TxtFecha.Text
    FacAsiento = TxtAsiento.Text
    FacUbicacion = TxtUbicacion.Text
    FacBoleto = LblBoleto.Caption
    '''salir
    'Unload Me
    
    Set DrFacturacion.DataSource = RsClientes
    DrFacturacion.WindowState = 2
    ''estamos en la seccion 2
        DrFacturacion.Sections("Sección2").Controls("Etiqueta4").Caption = FacCodigo
        DrFacturacion.Sections("Sección2").Controls("Etiqueta1").Caption = FacNombre
        DrFacturacion.Sections("Sección2").Controls("Etiqueta2").Caption = FacApellido
        DrFacturacion.Sections("Sección2").Controls("Etiqueta6").Caption = FacDNI
        DrFacturacion.Sections("Sección2").Controls("Etiqueta7").Caption = FacPrecio
        DrFacturacion.Sections("Sección2").Controls("Etiqueta9").Caption = FacBus
        DrFacturacion.Sections("Sección2").Controls("Etiqueta10").Caption = FacTipo
        DrFacturacion.Sections("Sección2").Controls("Etiqueta11").Caption = FacOrigen
        DrFacturacion.Sections("Sección2").Controls("Etiqueta12").Caption = FacDestino
        DrFacturacion.Sections("Sección2").Controls("Etiqueta13").Caption = FacHSalida
        DrFacturacion.Sections("Sección2").Controls("Etiqueta14").Caption = FacFSalida
        DrFacturacion.Sections("Sección2").Controls("Etiqueta15").Caption = FacAsiento
        DrFacturacion.Sections("Sección2").Controls("Etiqueta16").Caption = FacUbicacion
        DrFacturacion.Sections("Sección2").Controls("Etiqueta17").Caption = FacBoleto
        DrFacturacion.Show
'''''''''''''''''''''''''''''''''''''fin de facturacion''''''''''''''''''''''''''''''''''''''''''''''
    End With
Else
        With RsClientes
            .Requery
            .Find "Id='" & Trim(IdCliente) & "'"
                !Codigo = TxtCodigo.Text
                !NOmbre = TxtNombre.Text
                !Apellido = TxtApellido.Text
                !DNI = TxtDNI.Text
                !Precio = TxtPrecio.Text
                !Bus = DataBuses.Text
                !Tipo = TxtTipo.Text
                !origen = TxtOrigen.Text
                !Destino = TxtDestino.Text
                !H_salida = TxtHora.Text
                !F_salida = TxtFecha.Text
                !H_registro = TxtTime.Text
                !F_registro = TxtDate.Text
                !N_asiento = TxtAsiento.Text
                !Ubicacion = TxtUbicacion.Text
            .UpdateBatch
            .Requery
            
        End With
End If

HabilitarCaja True
HabilitarBotones True, False
Limpiar
End Sub

Private Sub cmdModificar_Click()
Modi = True
HabilitarCaja False
HabilitarBotones False, True
Limpiar
End Sub

Private Sub cmdNuevo_Click()
Modi = False
HabilitarCaja False
HabilitarBotones False, True
CodigoCliente
Limpiar
End Sub

Private Sub cmdSalir_Click()
If MsgBox("Desea salir del sistema...!", vbInformation + vbYesNo) = vbYes Then
    Unload Me
End If
End Sub

Private Sub Command1_Click()
If MsgBox("Desea vaciar el BUS por completo", vbInformation + vbYesNo) = vbYes Then
    Limpiar_todo
    ''poner en verdadero los botones..
        Cmd1l.Visible = True
        Cmd2l.Visible = True
        Cmd3l.Visible = True
        Cmd4l.Visible = True
        Cmd5l.Visible = True
        Cmd6l.Visible = True
        Cmd7l.Visible = True
        Cmd8l.Visible = True
        Cmd9l.Visible = True
        Cmd10l.Visible = True
        Cmd11l.Visible = True
        Cmd12l.Visible = True
        Cmd13l.Visible = True
        Cmd14l.Visible = True
        Cmd15l.Visible = True
        Cmd16l.Visible = True
        Cmd17l.Visible = True
        Cmd18l.Visible = True
        Cmd19l.Visible = True
        Cmd20l.Visible = True
        Cmd21l.Visible = True
        Cmd22l.Visible = True
        Cmd23l.Visible = True
        Cmd24l.Visible = True
        Cmd25l.Visible = True
        Texto.Text = ""
    DataClientes1.Visible = False
    
End If
End Sub

Private Sub DataBuses_Change()
With RsSalidas
    .Requery
    .Find "Buses='" & Trim(DataBuses.Text) & "'"
    If .EOF Then
    Exit Sub
    Else
        TxtOrigen.Text = !Terminal
        TxtDestino.Text = !Destino
        TxtHora.Text = !Hora_salida
        TxtFecha.Text = !Fecha_salida
        TxtTipo.Text = !Tipo
    End If
End With
End Sub


Private Sub DataClientes_Click()
With RsClientes
        If .BOF Or .EOF Then Exit Sub
        IdCliente = DataClientes.Columns(0).Text
        
        Lbl_Id.Caption = !Id
        
        .Find "Id='" & Val(DataClientes.Columns(0).Text) & "'"
        
                    TxtCodigo.Text = !Codigo
                    TxtNombre.Text = !NOmbre
                    TxtApellido.Text = !Apellido
                    TxtDNI.Text = !DNI
                    TxtPrecio.Text = !Precio
                    DataBuses.Text = !Bus
                    TxtTipo.Text = !Tipo
                    TxtOrigen.Text = !origen
                    TxtDestino.Text = !Destino
                    TxtHora.Text = !H_salida
                    TxtFecha.Text = !F_salida
                    TxtTime.Text = !H_registro
                    TxtDate.Text = !F_registro
                    TxtAsiento.Text = !N_asiento
                    TxtUbicacion.Text = !Ubicacion
    End With
End Sub

Private Sub DataClientes1_Click()
With RsClientes
        If .BOF Or .EOF Then Exit Sub
                    
                    
                    Lbl_Id.Caption = DataClientes1.Columns(0).Text
                    TxtCodigo.Text = DataClientes1.Columns(1).Text
                    TxtNombre.Text = DataClientes1.Columns(2).Text
                    TxtApellido.Text = DataClientes1.Columns(3).Text
                    TxtDNI.Text = DataClientes1.Columns(4).Text
                    TxtPrecio.Text = DataClientes1.Columns(5).Text
                    DataBuses.Text = DataClientes1.Columns(6).Text
                    TxtTipo.Text = DataClientes1.Columns(7).Text
                    TxtOrigen.Text = DataClientes1.Columns(8).Text
                    TxtDestino.Text = DataClientes1.Columns(9).Text
                    TxtHora.Text = DataClientes1.Columns(10).Text
                    TxtFecha.Text = DataClientes1.Columns(11).Text
                    TxtTime.Text = DataClientes1.Columns(12).Text
                    TxtDate.Text = DataClientes1.Columns(13).Text
                    TxtAsiento.Text = DataClientes1.Columns(14).Text
                    TxtUbicacion.Text = DataClientes1.Columns(15).Text
End With
End Sub

Private Sub Form_Load()
Clientes
Buses
Salidas
Codigo
Boleto
Terminales
CodigoCliente
CodigoBoleto
''agregar origen y destino
    ''origen
    Set DataBuses.RowSource = RsSalidas
    DataBuses.BoundColumn = "Buses"
    DataBuses.ListField = "Buses"
      
    Set DataClientes.DataSource = RsClientes
    
''Adodc1
        Adodc1.CursorLocation = adUseClient
        Adodc1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & App.Path & "\usuario.mdb;Persist Security Info=False"
        ''Ado como secordset
        Adodc1.RecordSource = "select * from Clientes where [Nombre] like '" & LblIDClientes.Caption & "'"
        Adodc1.Refresh
        Set DataClientes1.DataSource = Adodc1
        Adodc1.Visible = False
        
DataClientes1.Visible = False
HabilitarBotones True, False
HabilitarCaja_Bus True
HabilitarCaja True
OptBusca(0).Value = True
FormatoGrilla
End Sub
Public Sub HabilitarCaja_Bus(estado As Boolean)
TxtTipo.Locked = estado
TxtOrigen.Locked = estado
TxtDestino.Locked = estado
TxtHora.Locked = estado
TxtFecha.Locked = estado
TxtAsiento.Locked = estado
TxtUbicacion.Locked = estado
End Sub
Public Sub HabilitarCaja(estado As Boolean)
    TxtNombre.Locked = estado
    TxtApellido.Locked = estado
    TxtDNI.Locked = estado
    TxtPrecio.Locked = estado
    
End Sub


Private Sub Imprimir_Click()
Set DataReportClientes.DataSource = RsClientes
Unload Me
DataReportClientes.Show
End Sub


Private Sub Timer1_Timer()
    TxtTime.Text = Time
    TxtDate.Text = Date
End Sub
Sub Limpiar_todo()
    Lbl_Id.Caption = ""
    TxtNombre.Text = ""
    TxtApellido.Text = ""
    TxtDNI.Text = ""
    TxtPrecio.Text = ""
    DataBuses.Text = ""
    TxtTipo.Text = ""
    TxtOrigen.Text = ""
    TxtDestino.Text = ""
    TxtHora.Text = ""
    TxtFecha.Text = ""
    TxtAsiento.Text = ""
    TxtUbicacion.Text = ""
    CodigoCliente
    CodigoBoleto
End Sub
Sub Limpiar()
    Lbl_Id.Caption = ""
    TxtNombre.Text = ""
    TxtApellido.Text = ""
    TxtDNI.Text = ""
    TxtPrecio.Text = ""
    'DataBuses.Text = ""
    'TxtTipo.Text = ""
    'TxtOrigen.Text = ""
    'TxtDestino.Text = ""
    'TxtHora.Text = ""
    'TxtFecha.Text = ""
    TxtAsiento.Text = ""
    TxtUbicacion.Text = ""
    CodigoCliente
    CodigoBoleto
End Sub

Public Sub HabilitarBotones(estado1 As Boolean, estado2 As BookmarkEnum)
    cmdNuevo.Enabled = estado1
    cmdModificar.Enabled = estado1
    cmdGrabar.Enabled = estado2
    cmdEliminar.Enabled = estado1
    cmdCancelar.Enabled = estado2
    cmdBuscar.Enabled = estado1
    
End Sub

Private Sub Texto_Change()

    If OptBusca(0).Value = True Then BUSCANOMBRE
    If OptBusca(1).Value = True Then BUSCAAPELLIDO
    If OptBusca(2).Value = True Then BUSCADNI
    DataClientes1.Visible = True
End Sub


Sub BUSCANOMBRE()
Dim Busca As String
    Busca = UCase(Trim(Texto.Text)) & "%"
    Adodc1.RecordSource = "select * from Clientes where [Nombre] like '" & Busca & "'"
    Adodc1.Refresh
    FormatoGrilla
End Sub
Sub BUSCAAPELLIDO()
    Busca = UCase(Trim(Texto.Text)) & "%"
    Adodc1.RecordSource = "select * from Clientes where [Apellido] like '" & Busca & "'"
    Adodc1.Refresh
    FormatoGrilla
End Sub
Sub BUSCADNI()
    Busca = UCase(Trim(Texto.Text)) & "%"
    Adodc1.RecordSource = "select * from Clientes where [DNI] like '" & Busca & "'"
    Adodc1.Refresh
    FormatoGrilla
End Sub
Sub FormatoGrilla()
    DataClientes1.Columns(0).Width = 500
    DataClientes1.Columns(1).Width = 2000
    DataClientes1.Columns(2).Width = 2000
    DataClientes1.Columns(3).Width = 1300
    DataClientes1.Columns(4).Width = 0
    DataClientes1.Columns(5).Width = 0
    DataClientes1.Columns(6).Width = 0
    DataClientes1.Columns(7).Width = 1100
    DataClientes1.Columns(8).Width = 1100
    DataClientes1.Columns(9).Width = 0
    DataClientes1.Columns(10).Width = 0
    DataClientes1.Columns(11).Width = 0
    DataClientes1.Columns(12).Width = 0
    DataClientes1.Columns(13).Width = 0
    DataClientes1.Columns(14).Width = 0
End Sub
Sub CodigoCliente()
With RsCodigo
    .Requery
    If !Codigo = 0 Then
        NumeroCodigo = 1
        CodigoGuardar = 1
    Else
        NumeroCodigo = !Codigo + 1
        CodigoGuardar = !Codigo + 1
    End If
End With
If Len(Trim(NumeroCodigo)) = 1 Then TxtCodigo.Text = Format(NumeroCodigo, "0000000#"): TxtCodigo.Text = "CL" & TxtCodigo.Text
If Len(Trim(NumeroCodigo)) = 2 Then TxtCodigo.Text = Format(NumeroCodigo, "000000##"): TxtCodigo.Text = "CL" & TxtCodigo.Text
If Len(Trim(NumeroCodigo)) = 3 Then TxtCodigo.Text = Format(NumeroCodigo, "00000###"): TxtCodigo.Text = "CL" & TxtCodigo.Text
If Len(Trim(NumeroCodigo)) = 4 Then TxtCodigo.Text = Format(NumeroCodigo, "0000####"): TxtCodigo.Text = "CL" & TxtCodigo.Text
If Len(Trim(NumeroCodigo)) = 5 Then TxtCodigo.Text = Format(NumeroCodigo, "000#####"): TxtCodigo.Text = "CL" & TxtCodigo.Text
If Len(Trim(NumeroCodigo)) = 6 Then TxtCodigo.Text = Format(NumeroCodigo, "00######"): TxtCodigo.Text = "CL" & TxtCodigo.Text
If Len(Trim(NumeroCodigo)) = 7 Then TxtCodigo.Text = Format(NumeroCodigo, "0#######"): TxtCodigo.Text = "CL" & TxtCodigo.Text
If Len(Trim(NumeroCodigo)) = 8 Then TxtCodigo.Text = Format(NumeroCodigo, "########"): TxtCodigo.Text = "CL" & TxtCodigo.Text
If Len(Trim(NumeroCodigo)) = 9 Then TxtCodigo.Text = Format(NumeroCodigo, "#########"): TxtCodigo.Text = "CL" & TxtCodigo.Text
If Len(Trim(NumeroCodigo)) = 10 Then TxtCodigo.Text = Format(NumeroCodigo, "##########"): TxtCodigo.Text = "CL" & TxtCodigo.Text
End Sub
Sub CodigoBoleto()
With RsBoleto
    .Requery
    If !Codigo = 0 Then
    NumeroBoleto = 1
    BoletoGuardar = 1
    Else
    NumeroBoleto = !Codigo + 1
    BoletoGuardar = !Codigo + 1
    End If
End With
If Len(Trim(NumeroBoleto)) = 1 Then LblBoleto.Caption = Format(NumeroBoleto, "0000000#"): LblBoleto.Caption = "BL" & LblBoleto.Caption
If Len(Trim(NumeroBoleto)) = 2 Then LblBoleto.Caption = Format(NumeroBoleto, "000000##"): LblBoleto.Caption = "BL" & LblBoleto.Caption
If Len(Trim(NumeroBoleto)) = 3 Then LblBoleto.Caption = Format(NumeroBoleto, "00000###"): LblBoleto.Caption = "BL" & LblBoleto.Caption
If Len(Trim(NumeroBoleto)) = 4 Then LblBoleto.Caption = Format(NumeroBoleto, "0000####"): LblBoleto.Caption = "BL" & LblBoleto.Caption
If Len(Trim(NumeroBoleto)) = 5 Then LblBoleto.Caption = Format(NumeroBoleto, "000#####"): LblBoleto.Caption = "BL" & LblBoleto.Caption
If Len(Trim(NumeroBoleto)) = 6 Then LblBoleto.Caption = Format(NumeroBoleto, "00######"): LblBoleto.Caption = "BL" & LblBoleto.Caption
If Len(Trim(NumeroBoleto)) = 7 Then LblBoleto.Caption = Format(NumeroBoleto, "0#######"): LblBoleto.Caption = "BL" & LblBoleto.Caption
If Len(Trim(NumeroBoleto)) = 8 Then LblBoleto.Caption = Format(NumeroBoleto, "########"): LblBoleto.Caption = "BL" & LblBoleto.Caption
If Len(Trim(NumeroBoleto)) = 9 Then LblBoleto.Caption = Format(NumeroBoleto, "#########"): LblBoleto.Caption = "BL" & LblBoleto.Caption
If Len(Trim(NumeroBoleto)) = 10 Then LblBoleto.Caption = Format(NumeroBoleto, "##########"): LblBoleto.Caption = "BL" & LblBoleto.Caption

End Sub
