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

#Region "PagosDet"
Partial Public Class PagosDet
  Inherits _Database

  Private mEmpres_Codigo As Integer = 0

  Private mParame_TipoCuenta As Integer = 0

  Private mPardet_TipoCuenta As Integer = 0

  Private mPagdet_Secuencia As Integer = 0

  Private mEntida_Codigo As Integer = 0

  Private mParame_Tipomovinv As Integer = 0

  Private mPardet_Tipomovinv As Integer = 0

  Private mSucurs_Codigo As Integer = 0

  Private mMovinv_Secuencia As Integer = 0

  Private mParame_TipoMovPago As Integer = 470

  Private mPardet_TipoMovPago As Integer = 0

  Private mPagdet_BaseImponible As Decimal = 0

  Private mPagdet_PorcAplicable As Decimal = 0

  Private mPagdet_Valor As Decimal = 0

  Private mPagdet_FechaPago As Date = Now

  Private mParame_Banco As Integer = 0

  Private mPardet_Banco As Integer = 0

  Private mCtaBan_Numero As String = String.Empty

  Private mPagdet_NumeroCheque As Integer = 0

  Private mPagdet_FechaCheque As Date = Now.Date

  Private mPagdet_Verificado As Boolean = True

  Private mParame_TarjetaCredito As Integer = 0

  Private mPardet_TarjetaCredito As Integer = 0

  Private mPagdet_Voucher As String = String.Empty

  Private mPagdet_Observacion As String = String.Empty

  Private mParame_ConceptoRetencion As Integer = 0

  Private mPardet_ConceptoRetencion As Integer = 0

  Private mPagdet_esIVABienes As Boolean = True

  Private mParame_retencionIVA As Integer = 0

  Private mPardet_retencionIVA As Integer = 0

  Private mPagdet_CompteRetencion As String = String.Empty

  Private mPagdet_Autorizacion As String = String.Empty

  'Private mCtaCtb_Codigo As String = ""

  'Private mParame_SubCuenta As Integer = 0

  'Private mPardet_SubCuenta As Integer = 0

  Private mPagdet_esContabilizado As Boolean = False

  Private mPagdet_AsignacionPago As Decimal = 0

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
  Public Overridable Property Parame_TipoCuenta() As Integer
    Get
      Return Me.mParame_TipoCuenta
    End Get
    Set(ByVal value As Integer)
      Me.mParame_TipoCuenta = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Pardet_TipoCuenta() As Integer
    Get
      Return Me.mPardet_TipoCuenta
    End Get
    Set(ByVal value As Integer)
      Me.mPardet_TipoCuenta = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Pagdet_Secuencia() As Integer
    Get
      Return Me.mPagdet_Secuencia
    End Get
    Set(ByVal value As Integer)
      Me.mPagdet_Secuencia = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Entida_Codigo() As Integer
    Get
      Return Me.mEntida_Codigo
    End Get
    Set(ByVal value As Integer)
      Me.mEntida_Codigo = value
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
  Public Overridable Property Parame_TipoMovPago() As Integer
    Get
      Return Me.mParame_TipoMovPago
    End Get
    Set(ByVal value As Integer)
      Me.mParame_TipoMovPago = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Pardet_TipoMovPago() As Integer
    Get
      Return Me.mPardet_TipoMovPago
    End Get
    Set(ByVal value As Integer)
      Me.mPardet_TipoMovPago = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Pagdet_BaseImponible() As Decimal
    Get
      Return Me.mPagdet_BaseImponible
    End Get
    Set(ByVal value As Decimal)
      Me.mPagdet_BaseImponible = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Pagdet_PorcAplicable() As Decimal
    Get
      Return Me.mPagdet_PorcAplicable
    End Get
    Set(ByVal value As Decimal)
      Me.mPagdet_PorcAplicable = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Pagdet_Valor() As Decimal
    Get
      Return Me.mPagdet_Valor
    End Get
    Set(ByVal value As Decimal)
      Me.mPagdet_Valor = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Pagdet_FechaPago() As Date
    Get
      Return Me.mPagdet_FechaPago
    End Get
    Set(ByVal value As Date)
      Me.mPagdet_FechaPago = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Parame_Banco() As Integer
    Get
      Return Me.mParame_Banco
    End Get
    Set(ByVal value As Integer)
      Me.mParame_Banco = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Pardet_Banco() As Integer
    Get
      Return Me.mPardet_Banco
    End Get
    Set(ByVal value As Integer)
      Me.mPardet_Banco = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property CtaBan_Numero() As String
    Get
      Return Me.mCtaBan_Numero
    End Get
    Set(ByVal value As String)
      Me.mCtaBan_Numero = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Pagdet_NumeroCheque() As Integer
    Get
      Return Me.mPagdet_NumeroCheque
    End Get
    Set(ByVal value As Integer)
      Me.mPagdet_NumeroCheque = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Pagdet_FechaCheque() As Date
    Get
      Return Me.mPagdet_FechaCheque
    End Get
    Set(ByVal value As Date)
      Me.mPagdet_FechaCheque = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Pagdet_Verificado() As Boolean
    Get
      Return Me.mPagdet_Verificado
    End Get
    Set(ByVal value As Boolean)
      Me.mPagdet_Verificado = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Parame_TarjetaCredito() As Integer
    Get
      Return Me.mParame_TarjetaCredito
    End Get
    Set(ByVal value As Integer)
      Me.mParame_TarjetaCredito = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Pardet_TarjetaCredito() As Integer
    Get
      Return Me.mPardet_TarjetaCredito
    End Get
    Set(ByVal value As Integer)
      Me.mPardet_TarjetaCredito = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Pagdet_Voucher() As String
    Get
      Return Me.mPagdet_Voucher
    End Get
    Set(ByVal value As String)
      Me.mPagdet_Voucher = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Pagdet_Observacion() As String
    Get
      Return Me.mPagdet_Observacion
    End Get
    Set(ByVal value As String)
      Me.mPagdet_Observacion = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Parame_ConceptoRetencion() As Integer
    Get
      Return Me.mParame_ConceptoRetencion
    End Get
    Set(ByVal value As Integer)
      Me.mParame_ConceptoRetencion = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Pardet_ConceptoRetencion() As Integer
    Get
      Return Me.mPardet_ConceptoRetencion
    End Get
    Set(ByVal value As Integer)
      Me.mPardet_ConceptoRetencion = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Pagdet_esIVABienes() As Boolean
    Get
      Return Me.mPagdet_esIVABienes
    End Get
    Set(ByVal value As Boolean)
      Me.mPagdet_esIVABienes = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Parame_retencionIVA() As Integer
    Get
      Return Me.mParame_retencionIVA
    End Get
    Set(ByVal value As Integer)
      Me.mParame_retencionIVA = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Pardet_retencionIVA() As Integer
    Get
      Return Me.mPardet_retencionIVA
    End Get
    Set(ByVal value As Integer)
      Me.mPardet_retencionIVA = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Pagdet_CompteRetencion() As String
    Get
      Return Me.mPagdet_CompteRetencion
    End Get
    Set(ByVal value As String)
      Me.mPagdet_CompteRetencion = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Pagdet_Autorizacion() As String
    Get
      Return Me.mPagdet_Autorizacion
    End Get
    Set(ByVal value As String)
      Me.mPagdet_Autorizacion = value
      EsModificado = True
    End Set
  End Property

  '<XmlAttribute()> _
  'Public Overridable Property CtaCtb_Codigo() As String
  '  Get
  '    Return Me.mCtaCtb_Codigo
  '  End Get
  '  Set(ByVal value As String)
  '    Me.mCtaCtb_Codigo = value
  '    EsModificado = True
  '  End Set
  'End Property

  '<XmlAttribute()> _
  'Public Overridable Property Parame_SubCuenta() As Integer
  '  Get
  '    Return Me.mParame_SubCuenta
  '  End Get
  '  Set(ByVal value As Integer)
  '    Me.mParame_SubCuenta = value
  '    EsModificado = True
  '  End Set
  'End Property

  '<XmlAttribute()> _
  'Public Overridable Property Pardet_SubCuenta() As Integer
  '  Get
  '    Return Me.mPardet_SubCuenta
  '  End Get
  '  Set(ByVal value As Integer)
  '    Me.mPardet_SubCuenta = value
  '    EsModificado = True
  '  End Set
  'End Property

  <XmlAttribute()> _
  Public Overridable Property Pagdet_esContabilizado() As Boolean
    Get
      Return Me.mPagdet_esContabilizado
    End Get
    Set(ByVal value As Boolean)
      Me.mPagdet_esContabilizado = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Pagdet_AsignacionPago() As Decimal
    Get
      Return Me.mPagdet_AsignacionPago
    End Get
    Set(ByVal value As Decimal)
      Me.mPagdet_AsignacionPago = value
      EsModificado = True
    End Set
  End Property
End Class
#End Region