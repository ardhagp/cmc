Imports System.ComponentModel

Public Class dtp
    Inherits System.Windows.Forms.DateTimePicker

    Public Sub New()
        InitializeComponent()
        MyBase.Font = globalFontTxt
        MyBase.MaxDate = DateAdd(DateInterval.Year, 10, Now.Date)
        MyBase.MinDate = DateAdd(DateInterval.Year, -100, Now.Date)
    End Sub

    Private Sub dtp_EnabledChanged(sender As Object, e As EventArgs) Handles Me.EnabledChanged
        If SLFResetOnDisabled = True And Me.Enabled = False Then
            MyBase.MaxDate = DateAdd(DateInterval.Year, 10, Now.Date)
            MyBase.MinDate = DateAdd(DateInterval.Year, -100, Now.Date)
            Value = Now.Date
        End If
    End Sub

    <Category("Datetimepicker"),
    Description("Potong spasi kiri-kanan secara otomatis saat lost focus")>
    Private _ResetOnDisabled As Boolean
    Public Property SLFResetOnDisabled As Boolean
        Get
            Return _ResetOnDisabled
        End Get
        Set(value As Boolean)
            _ResetOnDisabled = value
        End Set
    End Property


End Class
