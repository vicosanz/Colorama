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

#Region "UnidadMedidaConversion"
Partial Public Class UnidadMedidaConversion
  Inherits _Database

  Private mParame_Unidadmedida As Integer = 0

  Private mPardet_Unidadmedida As Integer = 0

  Private mParame_unidadmedidadestino As Integer = 0

  Private mPardet_Unidadmedidadestino As Integer = 0

  Private mUnmeco_Factor As Decimal = 0

  Public Sub New()
    MyBase.New()
  End Sub

  <XmlAttribute()> _
  Public Overridable Property Parame_Unidadmedida() As Integer
    Get
      Return Me.mParame_Unidadmedida
    End Get
    Set(ByVal value As Integer)
      Me.mParame_Unidadmedida = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Pardet_Unidadmedida() As Integer
    Get
      Return Me.mPardet_Unidadmedida
    End Get
    Set(ByVal value As Integer)
      Me.mPardet_Unidadmedida = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Parame_unidadmedidadestino() As Integer
    Get
      Return Me.mParame_unidadmedidadestino
    End Get
    Set(ByVal value As Integer)
      Me.mParame_unidadmedidadestino = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Pardet_Unidadmedidadestino() As Integer
    Get
      Return Me.mPardet_Unidadmedidadestino
    End Get
    Set(ByVal value As Integer)
      Me.mPardet_Unidadmedidadestino = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Unmeco_Factor() As Decimal
    Get
      Return Me.mUnmeco_Factor
    End Get
    Set(ByVal value As Decimal)
      Me.mUnmeco_Factor = value
      EsModificado = True
    End Set
  End Property
End Class
#End Region