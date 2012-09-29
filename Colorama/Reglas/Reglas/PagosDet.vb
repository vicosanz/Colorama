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

Imports Infoware.Datos
Imports Infoware.Reglas.General


#Region "PagosDet"
Public Class PagosDet

  Const _Procedimiento As String = "proc_PagosDet"

  Private mSucursal As Sucursal = Nothing

  Private mEntidad As Entidad = Nothing

  Private mMovimientoInventario As MovimientoInventario = Nothing

  Private mPardetTipoCuenta As WWTSParametroDet = Nothing

  Private mPardetTipoMovPago As WWTSParametroDet = Nothing

  Private mPardetBanco As WWTSParametroDet = Nothing

  Private mPardetTarjetaCredito As WWTSParametroDet = Nothing

  Private mCuentaBancaria As CuentaBancaria = Nothing

  Private mPardetConceptoRetencion As WWTSParametroDet = Nothing

  Private mPardetRetencionIVA As WWTSParametroDet = Nothing

  'Private mCuentacontable As CuentaContable = Nothing

  Private mSubcuentacontable As WWTSParametroDet = Nothing

  Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _EsNuevo As Boolean)
    MyBase.New()
    OperadorDatos = _OperadorDatos
    EsNuevo = _EsNuevo
  End Sub

  Public Sub New(ByVal _Sucursal As Sucursal, ByVal _EsNuevo As Boolean)
    Me.New(_Sucursal.OperadorDatos, _EsNuevo)
    Sucursal = _Sucursal
    EsNuevo = _EsNuevo
  End Sub

  Public Sub New(ByVal _Sucursal As Sucursal, ByVal _PardetTipoCuenta As WWTSParametroDet, ByVal _Pagdet_Secuencia As Integer)
    Me.New(_Sucursal, False)
    PardetTipoCuenta = _PardetTipoCuenta
    Pagdet_Secuencia = _Pagdet_Secuencia
    If Me.Recargar Then
    Else
      Throw New System.Exception("No se puede cargar objeto PagosDet")
    End If
  End Sub

  'Sucursal
  Public Overridable Property Sucursal() As Sucursal
    Get
      If Me.mSucursal Is Nothing Then
        Me.mSucursal = New Sucursal(New Empresa(OperadorDatos, Empres_Codigo), Sucurs_Codigo)
      End If
      Return Me.mSucursal
    End Get
    Set(ByVal value As Sucursal)
      Me.mSucursal = value
      Empres_Codigo = Me.mSucursal.Empres_Codigo
      Sucurs_Codigo = msucursal.Sucurs_Codigo
    End Set
  End Property

  'Entidad
  Public Overridable Property Entidad() As Entidad
    Get
      If Me.mEntidad Is Nothing Then
        Me.mEntidad = New Entidad(OperadorDatos, Entida_Codigo)
      End If
      Return Me.mEntidad
    End Get
    Set(ByVal value As Entidad)
      Me.mEntidad = value
      Entida_Codigo = Me.mEntidad.Entida_Codigo
    End Set
  End Property

  'MovimientoInventario
  Public Overridable Property MovimientoInventario() As MovimientoInventario
    Get
      If Me.mMovimientoInventario Is Nothing Then
        If Movinv_Secuencia > 0 Then
          Me.mMovimientoInventario = New MovimientoInventario(Sucursal, New WWTSParametroDet(OperadorDatos, Parame_Tipomovinv, Pardet_Tipomovinv), Movinv_Secuencia)
        End If
      End If
      Return Me.mMovimientoInventario
    End Get
    Set(ByVal value As MovimientoInventario)
      Me.mMovimientoInventario = value
      If value Is Nothing Then
        Parame_Tipomovinv = 0
        Pardet_Tipomovinv = 0
        Movinv_Secuencia = 0
      Else
        Parame_Tipomovinv = value.Parame_Tipomovinv
        Pardet_Tipomovinv = value.Pardet_Tipomovinv
        Empres_Codigo = value.Empres_Bodega
        Sucurs_Codigo = value.Sucurs_Bodega
        Movinv_Secuencia = value.Movinv_Secuencia
      End If
    End Set
  End Property

  Public ReadOnly Property esCxC() As Boolean
    Get
      If Me.MovimientoInventario IsNot Nothing AndAlso Me.MovimientoInventario.Venta IsNot Nothing Then
        Return True
      End If
      Return False
    End Get
  End Property

  Public ReadOnly Property esCxP() As Boolean
    Get
      If Me.MovimientoInventario IsNot Nothing AndAlso Me.MovimientoInventario.Compra IsNot Nothing Then
        Return True
      End If
      Return False
    End Get
  End Property

  Public Property CuentaBancaria() As CuentaBancaria
    Get
      If mCuentaBancaria Is Nothing AndAlso Not Me.CtaBan_Numero = String.Empty Then
        mCuentaBancaria = New CuentaBancaria(New Empresa(OperadorDatos, Me.Empres_Codigo), Me.PardetBanco, Me.CtaBan_Numero)
      End If
      Return mCuentaBancaria
    End Get
    Set(ByVal value As CuentaBancaria)
      mCuentaBancaria = value
      If value IsNot Nothing Then
        Empres_Codigo = value.Empres_Codigo
        PardetBanco = value.PardetBanco
        Me.CtaBan_Numero = value.CtaBan_Numero
      End If
    End Set
  End Property

  'WWTSParametroDet
  Public Overridable Property PardetTipoCuenta() As WWTSParametroDet
    Get
      If Me.mPardetTipoCuenta Is Nothing AndAlso Pardet_TipoCuenta > 0 Then
        Me.mPardetTipoCuenta = New WWTSParametroDet(OperadorDatos, Parame_TipoCuenta, Pardet_TipoCuenta)
      End If
      Return Me.mPardetTipoCuenta
    End Get
    Set(ByVal value As WWTSParametroDet)
      Me.mPardetTipoCuenta = value
      Parame_TipoCuenta = value.Parame_Codigo
      Pardet_TipoCuenta = value.Pardet_Secuencia
    End Set
  End Property

  'WWTSParametroDet
  Public Overridable Property PardetTipoMovPago() As WWTSParametroDet
    Get
      If Me.mPardetTipoMovPago Is Nothing AndAlso Pardet_TipoMovPago > 0 Then
        Me.mPardetTipoMovPago = New WWTSParametroDet(OperadorDatos, Parame_TipoMovPago, Pardet_TipoMovPago)
      End If
      Return Me.mPardetTipoMovPago
    End Get
    Set(ByVal value As WWTSParametroDet)
      Me.mPardetTipoMovPago = value
      Parame_TipoMovPago = value.Parame_Codigo
      Pardet_TipoMovPago = value.Pardet_Secuencia
    End Set
  End Property

  Public ReadOnly Property TipoMovPagoString() As String
    Get
      If PardetTipoMovPago Is Nothing Then
        Return String.Empty
      Else
        Return mPardetTipoMovPago.Pardet_Descripcion
      End If
    End Get
  End Property

  Public Shadows Property Pardet_TipoMovPagoEnum() As Enumerados.enumTipoMovPagos
    Get
      Return CType(Pardet_TipoMovPago, Enumerados.enumTipoMovPagos)
    End Get
    Set(ByVal value As Enumerados.enumTipoMovPagos)
      Parame_TipoMovPago = CInt(Enumerados.EnumParametros.TipoMovPagos)
      Pardet_TipoMovPago = CInt(value)
    End Set
  End Property

  'WWTSParametroDet
  Public Overridable Property PardetBanco() As WWTSParametroDet
    Get
      If Me.mPardetBanco Is Nothing AndAlso Pardet_Banco > 0 Then
        Me.mPardetBanco = New WWTSParametroDet(OperadorDatos, Parame_Banco, Pardet_Banco)
      End If
      Return Me.mPardetBanco
    End Get
    Set(ByVal value As WWTSParametroDet)
      Me.mPardetBanco = value
      If value Is Nothing Then
        Parame_Banco = 0
        Pardet_Banco = 0
      Else
        Parame_Banco = value.Parame_Codigo
        Pardet_Banco = value.Pardet_Secuencia
      End If
    End Set
  End Property

  'WWTSParametroDet
  Public Overridable Property PardetTarjetaCredito() As WWTSParametroDet
    Get
      If Me.mPardetTarjetaCredito Is Nothing AndAlso Pardet_TarjetaCredito > 0 Then
        Me.mPardetTarjetaCredito = New WWTSParametroDet(OperadorDatos, Parame_TarjetaCredito, Pardet_TarjetaCredito)
      End If
      Return Me.mPardetTarjetaCredito
    End Get
    Set(ByVal value As WWTSParametroDet)
      Me.mPardetTarjetaCredito = value
      If value Is Nothing Then
        Parame_TarjetaCredito = 0
        Pardet_TarjetaCredito = 0
      Else
        Parame_TarjetaCredito = value.Parame_Codigo
        Pardet_TarjetaCredito = value.Pardet_Secuencia
      End If
    End Set
  End Property

  'WWTSParametroDet
  Public Overridable Property PardetConceptoRetencion() As WWTSParametroDet
    Get
      If Me.mPardetConceptoRetencion Is Nothing AndAlso Pardet_ConceptoRetencion > 0 Then
        Me.mPardetConceptoRetencion = New WWTSParametroDet(OperadorDatos, Parame_ConceptoRetencion, Pardet_ConceptoRetencion)
      End If
      Return Me.mPardetConceptoRetencion
    End Get
    Set(ByVal value As WWTSParametroDet)
      Me.mPardetConceptoRetencion = value
      If value Is Nothing Then
        Parame_ConceptoRetencion = 0
        Pardet_ConceptoRetencion = 0
      Else
        Parame_ConceptoRetencion = value.Parame_Codigo
        Pardet_ConceptoRetencion = value.Pardet_Secuencia
      End If
    End Set
  End Property

  'WWTSParametroDet
  Public Overridable Property PardetRetencionIVA() As WWTSParametroDet
    Get
      If Me.mPardetRetencionIVA Is Nothing AndAlso Pardet_retencionIVA > 0 Then
        Me.mPardetRetencionIVA = New WWTSParametroDet(OperadorDatos, Parame_retencionIVA, Pardet_retencionIVA)
      End If
      Return Me.mPardetRetencionIVA
    End Get
    Set(ByVal value As WWTSParametroDet)
      Me.mPardetRetencionIVA = value
      If value Is Nothing Then
        Parame_retencionIVA = 0
        Pardet_retencionIVA = 0
      Else
        Parame_retencionIVA = value.Parame_Codigo
        Pardet_retencionIVA = value.Pardet_Secuencia
      End If
    End Set
  End Property

  Public ReadOnly Property Establecimiento() As String
    Get
      Return Left(Me.Pagdet_CompteRetencion, 3)
    End Get
  End Property

  Public ReadOnly Property PuntoEmision() As String
    Get
      Return Me.Pagdet_CompteRetencion.Substring(4, 3)
    End Get
  End Property

  Public ReadOnly Property Secuencial() As String
    Get
      Return Me.Pagdet_CompteRetencion.Substring(8, 7)
    End Get
  End Property

  Public ReadOnly Property Descripcion() As String
    Get
      Dim _descripcion As String = ""
      Select Case Pardet_TipoMovPago
        Case Enumerados.enumTipoMovPagos.Retencionfuente, Enumerados.enumTipoMovPagos.RetencionIVA
          _descripcion = Pagdet_PorcAplicable.ToString("0.00") + "%"
        Case Enumerados.enumTipoMovPagos.Cheque
          If CuentaBancaria Is Nothing Then
            _descripcion = PardetBanco.Pardet_Descripcion
          Else
            _descripcion = String.Format("{0} {1}", PardetBanco.Pardet_Descripcion, CtaBan_Numero)
          End If
        Case Enumerados.enumTipoMovPagos.Documento
          If esCxC Then
            _descripcion = MovimientoInventario.Venta.Venta_Numero
          End If
          If esCxP Then
            _descripcion = MovimientoInventario.CompraVentaString
          End If
      End Select

      Return String.Format("{0} {1} {2}", PardetTipoMovPago.Pardet_Descripcion, _descripcion, Pagdet_Observacion)
    End Get
  End Property

  ''Cuentacontable
  'Public Overridable Property CuentaContable() As CuentaContable
  '  Get
  '    If mCuentacontable Is Nothing AndAlso Not CtaCtb_Codigo = String.Empty Then
  '      mCuentacontable = New CuentaContable(OperadorDatos, Me.CtaCtb_Codigo)
  '    End If
  '    Return Me.mCuentacontable
  '  End Get
  '  Set(ByVal value As CuentaContable)
  '    Me.mCuentacontable = value
  '    If value Is Nothing Then
  '      Me.CtaCtb_Codigo = String.Empty
  '    Else
  '      Me.CtaCtb_Codigo = value.CtaCtb_Codigo
  '    End If
  '  End Set
  'End Property

  'Public ReadOnly Property CuentaContableString() As String
  '  Get
  '    If CuentaContable Is Nothing Then
  '      Return String.Empty
  '    Else
  '      Return String.Format("{0} {1}", CtaCtb_Codigo, CuentaContable.CtaCtb_Descripcion)
  '    End If
  '  End Get
  'End Property

  'Subcuentacontable
  'Public Overridable Property SubCuentaContable() As WWTSParametroDet
  '  Get
  '    If mSubcuentacontable Is Nothing AndAlso Pardet_SubCuenta > 0 Then
  '      mSubcuentacontable = New WWTSParametroDet(OperadorDatos, Me.Parame_SubCuenta, Me.Pardet_SubCuenta)
  '    End If
  '    Return Me.mSubcuentacontable
  '  End Get
  '  Set(ByVal value As WWTSParametroDet)
  '    Me.mSubcuentacontable = value
  '    If value Is Nothing Then
  '      Me.Pardet_SubCuenta = 0
  '    Else
  '      Me.Parame_SubCuenta = value.Parame_Codigo
  '      Me.Pardet_SubCuenta = value.Pardet_Secuencia
  '    End If
  '  End Set
  'End Property

  'Public Overridable ReadOnly Property SubCuentaContableString() As String
  '  Get
  '    If SubCuentaContable Is Nothing Then
  '      Return String.Empty
  '    Else
  '      Return mSubcuentacontable.Pardet_Descripcion
  '    End If
  '  End Get
  'End Property
  Public ReadOnly Property ValorconSigno As Decimal
    Get
      If PardetTipoMovPago Is Nothing Then
        Return 0
      End If
      If Pardet_TipoMovPagoEnum = Enumerados.enumTipoMovPagos.Documento Then
        Return (Pagdet_Valor - Pagdet_AsignacionPago) * PardetTipoMovPago.Pardet_DatoInt1
      End If
      Return Pagdet_Valor * PardetTipoMovPago.Pardet_DatoInt1
    End Get
  End Property

  Public ReadOnly Property Pendiente As Decimal
    Get
      If Not Pardet_TipoMovPagoEnum = Enumerados.enumTipoMovPagos.Documento Then
        Return 0
      End If
      Return Pagdet_Valor - Pagdet_AsignacionPago
    End Get
  End Property

  Public ReadOnly Property Referencia As String
    Get
      If MovimientoInventario Is Nothing Then
        Return String.Empty
      Else
        Return String.Format("{0} {1}", MovimientoInventario.Sucursal.NombreCompleto, MovimientoInventario.Descripcion)
      End If
    End Get
  End Property

  Public Overridable Sub MapearDataRowaObjeto(ByVal Fila As DataRow)
    Empres_Codigo = CType(Fila("Empres_Codigo"), Integer)
    Sucurs_Codigo = CType(Fila("Sucurs_Codigo"), Integer)
    Parame_TipoCuenta = CType(Fila("Parame_TipoCuenta"), Integer) '**
    Pardet_TipoCuenta = CType(Fila("Pardet_TipoCuenta"), Integer) '**
    Pagdet_Secuencia = CType(Fila("Pagdet_Secuencia"), Integer)
    Entida_Codigo = CInt(Fila("Entida_Codigo"))

    Try
      Parame_Tipomovinv = CType(Fila("Parame_Tipomovinv"), Integer)
      Pardet_Tipomovinv = CType(Fila("Pardet_Tipomovinv"), Integer)
      Movinv_Secuencia = CType(Fila("Movinv_Secuencia"), Integer)
    Catch ex As Exception
      Parame_Tipomovinv = 0
      Pardet_Tipomovinv = 0
      Movinv_Secuencia = 0
    End Try

    Parame_TipoMovPago = CType(Fila("Parame_TipoMovPago"), Integer) '**
    Pardet_TipoMovPago = CType(Fila("Pardet_TipoMovPago"), Integer) '**
    Pagdet_Observacion = CStr(Fila("Pagdet_Observacion")) '**
    Pagdet_FechaPago = CType(Fila("Pagdet_FechaPago"), Date) '**
    Pagdet_Valor = CType(Fila("Pagdet_Valor"), Decimal)

    Dim obj As Object
    Select Case Pardet_TipoMovPago
      Case Enumerados.enumTipoMovPagos.Cheque
        Parame_Banco = CType(Fila("Parame_Banco"), Integer)
        Pardet_Banco = CType(Fila("Pardet_Banco"), Integer)
        obj = Fila("CtaBan_Numero")
        If TypeOf obj Is DBNull Then
          CtaBan_Numero = ""
        Else
          CtaBan_Numero = CStr(obj)
        End If
        Pagdet_NumeroCheque = CType(Fila("Pagdet_NumeroCheque"), Integer)
        Pagdet_FechaCheque = CType(Fila("Pagdet_FechaCheque"), Date)
        Pagdet_Verificado = CBool(Fila("Pagdet_Verificado"))
      Case Enumerados.enumTipoMovPagos.Tarjetadecredito
        Parame_TarjetaCredito = CType(Fila("Parame_TarjetaCredito"), Integer)
        Pardet_TarjetaCredito = CType(Fila("Pardet_TarjetaCredito"), Integer)
        Pagdet_Voucher = CStr(Fila("Pagdet_Voucher"))
      Case Enumerados.enumTipoMovPagos.Retencionfuente
        Parame_ConceptoRetencion = CInt(Fila("Parame_ConceptoRetencion"))
        Pardet_ConceptoRetencion = CInt(Fila("Pardet_ConceptoRetencion"))
        Pagdet_BaseImponible = CType(Fila("Pagdet_BaseImponible"), Decimal)
        Pagdet_PorcAplicable = CDec(Fila("Pagdet_PorcAplicable"))
        Pagdet_CompteRetencion = CStr(Fila("Pagdet_CompteRetencion"))
        Pagdet_Autorizacion = CStr(Fila("Pagdet_Autorizacion"))
      Case Enumerados.enumTipoMovPagos.RetencionIVA
        Pagdet_esIVABienes = CBool(Fila("Pagdet_esIVABienes"))
        Parame_retencionIVA = CInt(Fila("Parame_retencionIVA"))
        Pardet_retencionIVA = CInt(Fila("Pardet_retencionIVA"))
        Pagdet_BaseImponible = CType(Fila("Pagdet_BaseImponible"), Decimal)
        Pagdet_PorcAplicable = CType(Fila("Pagdet_PorcAplicable"), Decimal)
        Pagdet_CompteRetencion = CStr(Fila("Pagdet_CompteRetencion"))
        Pagdet_Autorizacion = CStr(Fila("Pagdet_Autorizacion"))
    End Select
    'Try
    '  mCtaCtb_Codigo = CStr(Fila("CtaCtb_Codigo"))
    'Catch ex As Exception
    '  mCtaCtb_Codigo = String.Empty
    'End Try
    'Try
    '  mParame_SubCuenta = CInt(Fila("Parame_SubCuenta"))
    '  mPardet_SubCuenta = CInt(Fila("Pardet_SubCuenta"))
    'Catch ex As Exception
    '  mParame_SubCuenta = 0
    '  mPardet_SubCuenta = 0
    'End Try
    mPagdet_esContabilizado = CBool(Fila("Pagdet_esContabilizado"))
    mPagdet_AsignacionPago = CDec(Fila("Pagdet_AsignacionPago"))
    mSucursal = Nothing
    mEntidad = Nothing
    mMovimientoInventario = Nothing
    mPardetTipoCuenta = Nothing
    mPardetTipoMovPago = Nothing
    mPardetBanco = Nothing
    mPardetTarjetaCredito = Nothing
    mCuentaBancaria = Nothing
    mPardetConceptoRetencion = Nothing
    mPardetRetencionIVA = Nothing
    'mCuentacontable = Nothing
  End Sub

  Public Overridable Function Recargar() As Boolean
    Dim Result As New DataTable
    Dim bReturn As Boolean = True
    OperadorDatos.AgregarParametro("@accion", "C")
    OperadorDatos.AgregarParametro("@Empres_Codigo", Empres_Codigo)
    OperadorDatos.AgregarParametro("@Parame_TipoCuenta", Parame_TipoCuenta)
    OperadorDatos.AgregarParametro("@Pardet_TipoCuenta", Pardet_TipoCuenta)
    OperadorDatos.AgregarParametro("@Pagdet_Secuencia", Pagdet_Secuencia)
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar(Result)
    OperadorDatos.LimpiarParametros()
    Try
      Me.MapearDataRowaObjeto(Result.Rows(0))
      EsNuevo = False
      EsModificado = False
    Catch ex As System.Exception
      bReturn = False
    End Try
    Return bReturn
  End Function

  Public Overridable Function Guardar() As Boolean
    If Not EsNuevo And Not EsModificado Then
      Return True
    End If

    Dim Result As Integer = 0
    Dim bReturn As Boolean = True

    Dim _comenzotransaccion As Boolean = False
    If Not OperadorDatos.EstaenTransaccion Then
      OperadorDatos.ComenzarTransaccion()
      _comenzotransaccion = True
    End If

    Dim sAccion As String = "M"
    If EsNuevo Then
      sAccion = "I"
    End If
    OperadorDatos.AgregarParametro("@accion", sAccion)
    OperadorDatos.AgregarParametro("@Empres_Codigo", Empres_Codigo)
    OperadorDatos.AgregarParametro("@Sucurs_Codigo", Sucurs_Codigo)
    OperadorDatos.AgregarParametro("@Parame_TipoCuenta", Parame_TipoCuenta)
    OperadorDatos.AgregarParametro("@Pardet_TipoCuenta", Pardet_TipoCuenta)
    OperadorDatos.AgregarParametro("@Pagdet_Secuencia", Pagdet_Secuencia)
    OperadorDatos.AgregarParametro("@Entida_Codigo", Entida_Codigo)

    Select Case Pardet_TipoMovPago
      Case Enumerados.enumTipoMovPagos.Documento, Enumerados.enumTipoMovPagos.Retencionfuente, Enumerados.enumTipoMovPagos.RetencionIVA
        OperadorDatos.AgregarParametro("@Parame_Tipomovinv", Parame_Tipomovinv)
        OperadorDatos.AgregarParametro("@Pardet_Tipomovinv", Pardet_Tipomovinv)
        OperadorDatos.AgregarParametro("@Movinv_Secuencia", Movinv_Secuencia)
    End Select

    OperadorDatos.AgregarParametro("@Parame_TipoMovPago", Parame_TipoMovPago)
    OperadorDatos.AgregarParametro("@Pardet_TipoMovPago", Pardet_TipoMovPago)
    OperadorDatos.AgregarParametro("@Pagdet_Observacion", Pagdet_Observacion)
    OperadorDatos.AgregarParametro("@Pagdet_FechaPago", Pagdet_FechaPago)
    OperadorDatos.AgregarParametro("@Pagdet_Valor", Pagdet_Valor)

    Select Case Pardet_TipoMovPago
      Case Enumerados.enumTipoMovPagos.Cheque
        OperadorDatos.AgregarParametro("@Parame_Banco", Parame_Banco)
        OperadorDatos.AgregarParametro("@Pardet_Banco", Pardet_Banco)
        If Not CtaBan_Numero.Trim = String.Empty Then
          OperadorDatos.AgregarParametro("@CtaBan_Numero", CtaBan_Numero)
        End If
        OperadorDatos.AgregarParametro("@Pagdet_NumeroCheque", Pagdet_NumeroCheque)
        OperadorDatos.AgregarParametro("@Pagdet_FechaCheque", Pagdet_FechaCheque)
        OperadorDatos.AgregarParametro("@Pagdet_Verificado", Pagdet_Verificado)
      Case Enumerados.enumTipoMovPagos.Tarjetadecredito
        OperadorDatos.AgregarParametro("@Parame_TarjetaCredito", Parame_TarjetaCredito)
        OperadorDatos.AgregarParametro("@Pardet_TarjetaCredito", Pardet_TarjetaCredito)
        OperadorDatos.AgregarParametro("@Pagdet_Voucher", Pagdet_Voucher)
      Case Enumerados.enumTipoMovPagos.Retencionfuente
        OperadorDatos.AgregarParametro("@Parame_ConceptoRetencion", Parame_ConceptoRetencion)
        OperadorDatos.AgregarParametro("@Pardet_ConceptoRetencion", Pardet_ConceptoRetencion)
        OperadorDatos.AgregarParametro("@Pagdet_BaseImponible", Pagdet_BaseImponible)
        OperadorDatos.AgregarParametro("@Pagdet_PorcAplicable", Pagdet_PorcAplicable)
        OperadorDatos.AgregarParametro("@Pagdet_CompteRetencion", Pagdet_CompteRetencion)
        OperadorDatos.AgregarParametro("@Pagdet_Autorizacion", Pagdet_Autorizacion)
      Case Enumerados.enumTipoMovPagos.RetencionIVA
        OperadorDatos.AgregarParametro("@Pagdet_esIVABienes", Pagdet_esIVABienes)
        OperadorDatos.AgregarParametro("@Parame_retencionIVA", Parame_retencionIVA)
        OperadorDatos.AgregarParametro("@Pardet_retencionIVA", Pardet_retencionIVA)
        OperadorDatos.AgregarParametro("@Pagdet_BaseImponible", Pagdet_BaseImponible)
        OperadorDatos.AgregarParametro("@Pagdet_PorcAplicable", Pagdet_PorcAplicable)
        OperadorDatos.AgregarParametro("@Pagdet_CompteRetencion", Pagdet_CompteRetencion)
        OperadorDatos.AgregarParametro("@Pagdet_Autorizacion", Pagdet_Autorizacion)
    End Select
    'If Not CtaCtb_Codigo = String.Empty Then
    '  OperadorDatos.AgregarParametro("@CtaCtb_Codigo", CtaCtb_Codigo)
    'End If
    'If Parame_SubCuenta > 0 Then
    '  OperadorDatos.AgregarParametro("@Parame_SubCuenta", Parame_SubCuenta)
    '  OperadorDatos.AgregarParametro("@Pardet_SubCuenta", Pardet_SubCuenta)
    'End If
    OperadorDatos.AgregarParametro("@Pagdet_esContabilizado", Pagdet_esContabilizado)
    OperadorDatos.AgregarParametro("@Pagdet_AsignacionPago", Pagdet_AsignacionPago)
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar(Result)
    OperadorDatos.LimpiarParametros()
    If bReturn Then
      If EsNuevo Then
        Pagdet_Secuencia = Result
      End If

      Try
        Select Case Pardet_TipoMovPago
          Case Enumerados.enumTipoMovPagos.RetencionIVA, Enumerados.enumTipoMovPagos.Retencionfuente
            Me.MovimientoInventario.Compra.Proveedor.Entidad.Entida_AutorizacionRetencion = Pagdet_Autorizacion
            Me.MovimientoInventario.Compra.Proveedor.Entidad.Guardar()
        End Select
      Catch ex As Exception

      End Try

      If Not OperadorDatos.EstaenTransaccion Then
        EsNuevo = False
        EsModificado = False
      End If
    End If

    If _comenzotransaccion Then
      If bReturn Then
        OperadorDatos.TerminarTransaccion()
        AceptarCambios()
      Else
        OperadorDatos.CancelarTransaccion()
      End If
    End If
    Return bReturn
  End Function

  Public Overridable Sub AceptarCambios()
    EsNuevo = False
    EsModificado = False
  End Sub

  Public Overridable Function Eliminar() As Boolean
    If EsNuevo Then
      Return True
    End If

    Dim bReturn As Boolean = True
    OperadorDatos.AgregarParametro("@accion", "E")
    OperadorDatos.AgregarParametro("@Empres_Codigo", Empres_Codigo)
    OperadorDatos.AgregarParametro("@Parame_TipoCuenta", Parame_TipoCuenta)
    OperadorDatos.AgregarParametro("@Pardet_TipoCuenta", Pardet_TipoCuenta)
    OperadorDatos.AgregarParametro("@Pagdet_Secuencia", Pagdet_Secuencia)
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar
    OperadorDatos.LimpiarParametros()
    Return bReturn
  End Function
End Class
#End Region

#Region "PagosDetList"
Public Class PagosDetList
  Inherits System.ComponentModel.BindingList(Of PagosDet)

  Public Shared Function ObtenerListaPendientes(ByVal _Sucursal As Sucursal, ByVal _Entidad As Entidad, ByVal _TipoCuenta As Enumerados.enumTipoCuenta) As PagosDetList
    Dim oResult As PagosDetList = New PagosDetList
    Dim bReturn As Boolean
    Dim ds As DataTable = Nothing
    With _Sucursal.OperadorDatos
      .AgregarParametro("@Accion", "Fp")
      .AgregarParametro("@Empres_Codigo", _Sucursal.Empres_Codigo)
      .AgregarParametro("@Sucurs_Codigo", _Sucursal.Sucurs_Codigo)
      .AgregarParametro("@Entida_Codigo", _Entidad.Entida_Codigo)
      .AgregarParametro("@Pardet_TipoCuenta", _TipoCuenta)
      .Procedimiento = "proc_PagosDet"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      For Each _dr As DataRow In ds.Rows
        Dim _fila As New PagosDet(_Sucursal, False)
        _fila.MapearDataRowaObjeto(_dr)
        oResult.Add(_fila)
      Next
    End If
    Return oResult
  End Function

  Public Shared Function ObtenerLista(ByVal _MovimientoInventario As MovimientoInventario) As PagosDetList
    Dim oResult As PagosDetList = New PagosDetList
    Dim bReturn As Boolean
    Dim ds As DataTable = Nothing
    With _MovimientoInventario.OperadorDatos
      .AgregarParametro("@Accion", "F")
      .AgregarParametro("@Parame_Tipomovinv", _MovimientoInventario.Parame_Tipomovinv)
      .AgregarParametro("@Pardet_Tipomovinv", _MovimientoInventario.Pardet_Tipomovinv)
      .AgregarParametro("@Empres_Codigo", _MovimientoInventario.Empres_Bodega)
      .AgregarParametro("@Sucurs_Codigo", _MovimientoInventario.Sucurs_Bodega)
      .AgregarParametro("@Movinv_Secuencia", _MovimientoInventario.Movinv_Secuencia)
      .Procedimiento = "proc_PagosDet"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      For Each _dr As DataRow In ds.Rows
        Dim _fila As New PagosDet(_MovimientoInventario.Sucursal, False)
        _fila.MapearDataRowaObjeto(_dr)
        oResult.Add(_fila)
      Next
    End If
    Return oResult
  End Function
End Class
#End Region
