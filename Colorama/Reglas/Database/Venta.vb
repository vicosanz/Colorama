'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.42
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.Xml
Imports System.Xml.Serialization
Imports Infoware.Reglas
Imports Infoware.Reglas.General


#Region "Venta"
Partial Public Class Venta
  Inherits _Database

  Private mEmpres_Codigo As Integer = 0

  Private mSucurs_Codigo As Integer = 0

  Private mParame_TipoVenta As Integer = 442

  Private mPardet_TipoVenta As Integer = 1

  Private mVenta_Numero As Integer = 0

  Private mParame_Tipomovinv As Integer = 440

  Private mPardet_Tipomovinv As Integer = 0

  Private mMovinv_Secuencia As Integer = 0

  Private mEntida_Cliente As Integer = 0

  Private mEntida_Vendedor As Integer = 0

  Private mParame_TipoPago As Integer = CInt(Enumerados.EnumParametros.TipoFormaPago)

  Private mPardet_TipoPago As Integer = CInt(Enumerados.enumTipoFormaPago.Contado)

  Private mParame_TipoPrecio As Integer = CInt(Enumerados.EnumParametros.TipoPrecio)

  Private mPardet_TipoPrecio As Integer = CInt(Enumerados.enumTipoPrecio.PrecioContado)

  Private mSRI_secuencialtransaccion As String = String.Empty

  Private mSRI_tipocomprobante As String = String.Empty

  Private mVenta_esConsumidorFinal As Boolean = False

  Private mParame_Tipodireccion As Integer = 0

  Private mPardet_Tipodireccion As Integer = 0

  Public Sub New()
    MyBase.New()
  End Sub

  <XmlAttribute()> _
  Public Overridable Property Empres_Codigo() As Integer
    Get
      Return Me.mEmpres_Codigo
    End Get
    Set(ByVal value As Integer)
      Me.mEmpres_Codigo = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Sucurs_Codigo() As Integer
    Get
      Return Me.mSucurs_Codigo
    End Get
    Set(ByVal value As Integer)
      Me.mSucurs_Codigo = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Parame_TipoVenta() As Integer
    Get
      Return Me.mParame_TipoVenta
    End Get
    Set(ByVal value As Integer)
      Me.mParame_TipoVenta = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Pardet_TipoVenta() As Integer
    Get
      Return Me.mPardet_TipoVenta
    End Get
    Set(ByVal value As Integer)
      Me.mPardet_TipoVenta = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Venta_Numero() As Integer
    Get
      Return Me.mVenta_Numero
    End Get
    Set(ByVal value As Integer)
      Me.mVenta_Numero = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Parame_Tipomovinv() As Integer
    Get
      Return Me.mParame_Tipomovinv
    End Get
    Set(ByVal value As Integer)
      Me.mParame_Tipomovinv = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Pardet_Tipomovinv() As Integer
    Get
      Return Me.mPardet_Tipomovinv
    End Get
    Set(ByVal value As Integer)
      Me.mPardet_Tipomovinv = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Movinv_Secuencia() As Integer
    Get
      Return Me.mMovinv_Secuencia
    End Get
    Set(ByVal value As Integer)
      Me.mMovinv_Secuencia = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Entida_Cliente() As Integer
    Get
      Return Me.mEntida_Cliente
    End Get
    Set(ByVal value As Integer)
      Me.mEntida_Cliente = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Entida_Vendedor() As Integer
    Get
      Return Me.mEntida_Vendedor
    End Get
    Set(ByVal value As Integer)
      Me.mEntida_Vendedor = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Parame_TipoPago() As Integer
    Get
      Return Me.mParame_TipoPago
    End Get
    Set(ByVal value As Integer)
      Me.mParame_TipoPago = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Pardet_TipoPago() As Integer
    Get
      Return Me.mPardet_TipoPago
    End Get
    Set(ByVal value As Integer)
      Me.mPardet_TipoPago = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Parame_TipoPrecio() As Integer
    Get
      Return Me.mParame_TipoPrecio
    End Get
    Set(ByVal value As Integer)
      Me.mParame_TipoPrecio = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Pardet_TipoPrecio() As Integer
    Get
      Return Me.mPardet_TipoPrecio
    End Get
    Set(ByVal value As Integer)
      Me.mPardet_TipoPrecio = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property SRI_secuencialtransaccion() As String
    Get
      Return Me.mSRI_secuencialtransaccion
    End Get
    Set(ByVal value As String)
      Me.mSRI_secuencialtransaccion = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property SRI_tipocomprobante() As String
    Get
      Return Me.mSRI_tipocomprobante
    End Get
    Set(ByVal value As String)
      Me.mSRI_tipocomprobante = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Venta_esConsumidorFinal() As Boolean
    Get
      Return Me.mVenta_esConsumidorFinal
    End Get
    Set(ByVal value As Boolean)
      Me.mVenta_esConsumidorFinal = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Parame_Tipodireccion() As Integer
    Get
      Return mParame_Tipodireccion
    End Get
    Set(ByVal value As Integer)
      mParame_Tipodireccion = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Pardet_Tipodireccion() As Integer
    Get
      Return mPardet_Tipodireccion
    End Get
    Set(ByVal value As Integer)
      mPardet_Tipodireccion = value
      EsModificado = True
    End Set
  End Property
End Class
#End Region
