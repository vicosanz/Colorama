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

#Region "TipoMovimientoCompraVenta"
Partial Public Class TipoMovimientoCompraVenta
  Inherits _Database

  Private mParame_TipoCompraVenta As Integer = 0

  Private mPardet_TipoCompraVenta As Integer = 0

  Private mEmpres_Codigo As Integer = 0

  Private mSucurs_Codigo As Integer = 0

  Private mTiMoCv_Formato As String = ""

  Private mTiMoCv_Secuencia As Integer = 0

  Public Sub New()
    MyBase.New()
  End Sub

  <XmlAttribute()> _
  Public Overridable Property Parame_TipoCompraVenta() As Integer
    Get
      Return Me.mParame_TipoCompraVenta
    End Get
    Set(ByVal value As Integer)
      Me.mParame_TipoCompraVenta = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Pardet_TipoCompraVenta() As Integer
    Get
      Return Me.mPardet_TipoCompraVenta
    End Get
    Set(ByVal value As Integer)
      Me.mPardet_TipoCompraVenta = value
      EsModificado = True
    End Set
  End Property

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
  Public Overridable Property TiMoCv_Formato() As String
    Get
      Return Me.mTiMoCv_Formato
    End Get
    Set(ByVal value As String)
      Me.mTiMoCv_Formato = value
      EsModificado = True
    End Set
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Secuencia", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Numero, 100, True)> _
  <XmlAttribute()> _
  Public Overridable Property TiMoCv_Secuencia() As Integer
    Get
      Return Me.mTiMoCv_Secuencia
    End Get
    Set(ByVal value As Integer)
      Me.mTiMoCv_Secuencia = value
      EsModificado = True
    End Set
  End Property
End Class
#End Region
