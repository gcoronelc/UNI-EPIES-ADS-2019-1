Attribute VB_Name = "ModuleDeclare"
''variable de BD y tablas
Global Base As New ADODB.Connection
Global CodigodeClientes As New ADODB.Connection
Global RsUsuarios As New ADODB.Recordset
Global RsBuses As New ADODB.Recordset
Global RsTipobus As New ADODB.Recordset
Global RsTerminales As New ADODB.Recordset
Global RsSalidas As New ADODB.Recordset
Global RsClientes As New ADODB.Recordset
Global RsCodigo As New ADODB.Recordset
Global RsBoleto As New ADODB.Recordset

''variables de factura.................
Global FacID As String               '.
Global FacCodigo As String           '.
Global FacNombre As String           '.
Global FacApellido As String         '.
Global FacDNI As String              '.
Global FacPrecio As String           '.
Global FacBus As String              '.
Global FacTipo As String             '.
Global FacOrigen As String           '.
Global FacDestino As String          '.
Global FacHSalida As String          '.
Global FacFSalida As String          '.
Global FacAsiento As String          '.
Global FacUbicacion As String        '.
Global FacBoleto As String           '.
'......................................

''variable de uso
Global Modi As Boolean

Global IdBuses As Integer
Global MatriculaBus As String
''terminales
Global IdTerminal As Integer
Global NombreDeTerminal As String
''salida de bus
Global IdSalida As Integer
Global SalidaBus As String
''clientes
Global IdCliente As Integer
Global RegistrodelCliente As String

Global NumeroCodigo As Long
Global CodigoGuardar As Long

Global NumeroBoleto As Long
Global BoletoGuardar As Long
