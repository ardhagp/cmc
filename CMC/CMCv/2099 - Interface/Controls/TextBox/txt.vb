Imports System.Management
Imports System.ComponentModel
Imports System.Text.RegularExpressions

''' <project>Mainframe : txt (Textbox Custom Component)</project>
''' <author>Ardha Gp</author>
''' <summary>
''' Custom komponen textbox. Dilengkapi dengan sekuensial validasi pada button clicked.
''' </summary>
''' <remarks></remarks>
Public Class txt
    Inherits System.Windows.Forms.TextBox

    Public Sub New()
        InitializeComponent()
        MyBase.Font = globalFontTxt
        MyBase.MaxLength = 255
        MyBase.Height = 23
        MyBase.Width = 206
        Me.SLFHarusDiisi = False
        Me.SLFHarusDiisiWarnaLatar = Drawing.Color.LightPink
        Me.SLFHarusDiisiWarnaLatarDefault = Drawing.Color.White
        Me.SLFTanpaSpasi = False
        Me.SLFAutoTrim = False
        Me.SLFHightlightSaatFokus = False
        Me.SLFHightlightSaatFokusWarna = Drawing.Color.LightYellow
        Me.SLFPilihSemuaSaatFokus = False
        Me.SLFRestriction = ControlCodeBase.enuRestriction.None
        Me.SLFIsBlank = True
        Me.SLFJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        Me.SLFIsSearchBox = False
        Me.SLFSearchBoxText = "Type then press Enter"
        Me.SLFPwdLengthMin = 8
        Me.SLFPwdStrengthCalculate = False
        Call FontSearchBox(True)
    End Sub

#Region "Properties"
    <Category("Text"),
    Description("Potong spasi kiri-kanan secara otomatis saat lost focus")>
    Private _varAutoTrim As Boolean
    Public Property SLFAutoTrim() As Boolean
        Get
            Return _varAutoTrim
        End Get
        Set(value As Boolean)
            _varAutoTrim = value
        End Set
    End Property

    <Category("Text"),
    Description("Teksboks harus diisi")>
    Private _varHarusDiisi As Boolean
    Public Property SLFHarusDiisi As Boolean
        Get
            Return _varHarusDiisi
        End Get
        Set(value As Boolean)
            _varHarusDiisi = value
        End Set
    End Property

    Private _varHightlightSaatFokus As Boolean
    <Category("Text"),
    Description("Jenis tombol akan mempengaruhi (warna latar, jenis font) tombol")>
    Public Property SLFHightlightSaatFokus() As Boolean
        Get
            Return _varHightlightSaatFokus
        End Get
        Set(value As Boolean)
            _varHightlightSaatFokus = value
        End Set
    End Property

    Private _varHighlightSaatFokusWarna As System.Drawing.Color
    <Category("Text"),
    Description("Warna highlight")>
    Public Property SLFHightlightSaatFokusWarna() As System.Drawing.Color
        Get
            Return _varHighlightSaatFokusWarna
        End Get
        Set(value As System.Drawing.Color)
            _varHighlightSaatFokusWarna = value
        End Set
    End Property

    <Category("Text"),
   Description("Panjang password minimum")>
    Private _varPwdLengthMin As Integer
    Public Property SLFPwdLengthMin As Integer
        Get
            Return _varPwdLengthMin
        End Get
        Set(value As Integer)
            _varPwdLengthMin = value
        End Set
    End Property

    <Category("Text"),
   Description("Aktifkan penghitung kekuatan password")>
    Private _varPwdStrengthCalculate As Boolean
    Public Property SLFPwdStrengthCalculate As Boolean
        Get
            Return _varPwdStrengthCalculate
        End Get
        Set(value As Boolean)
            _varPwdStrengthCalculate = value
        End Set
    End Property

    <Category("Text"),
   Description("Indikator kekuatan password (skor)")>
    Private _varPwdStrengthScore As Integer
    Public Property SLFPwdStrengthScore As Integer
        Get
            Return _varPwdStrengthScore
        End Get
        Set(value As Integer)
            _varPwdStrengthScore = value
        End Set
    End Property

    <Category("Text"),
   Description("Indikator kekuatan password (teks)")>
    Private _varPwdStrengthText As String
    Public Property SLFPwdStrengthText As String
        Get
            Return _varPwdStrengthText
        End Get
        Set(value As String)
            _varPwdStrengthText = value
        End Set
    End Property

    <Category("Text"),
   Description("Mengisi teksboks kosong dengan tanda (-)")>
    Private _varTanpaSpasi As Boolean
    Public Property SLFTanpaSpasi As Boolean
        Get
            Return _varTanpaSpasi
        End Get
        Set(value As Boolean)
            _varTanpaSpasi = value
        End Set
    End Property

    <Category("Text"),
   Description("Teks yang dikonversi untuk sql")>
    Private _varSQLText As String
    Public Property SLFSQLText As String
        Get
            Return _varSQLText
        End Get
        Set(value As String)
            _varSQLText = value
        End Set
    End Property

    Private _varHarusDiisiWarnaLatarDefault As System.Drawing.Color
    Private _varHarusDiisiWarnaLatar As System.Drawing.Color
    <Category("Text"),
    Description("Warna saat teksboks tidak diisi")>
    Public Property SLFHarusDiisiWarnaLatar As System.Drawing.Color
        Get
            Return _varHarusDiisiWarnaLatar
        End Get
        Set(value As System.Drawing.Color)
            _varHarusDiisiWarnaLatar = value
        End Set
    End Property

    <Category("Text"),
    Description("Warna saat teksboks tidak diisi jika bernilai False")>
    Public Property SLFHarusDiisiWarnaLatarDefault As System.Drawing.Color
        Get
            Return _varHarusDiisiWarnaLatarDefault
        End Get
        Set(value As System.Drawing.Color)
            _varHarusDiisiWarnaLatarDefault = value
        End Set
    End Property

    Private _varValidasiField As String
    <Category("Text"),
    Description("Field yang ditampilkan saat validasi tidak diisi")>
    Public Property SLFValidasiField As String
        Get
            Return _varValidasiField
        End Get
        Set(value As String)
            _varValidasiField = value
        End Set
    End Property

    Private _varPilihSemuaSaatFokus As Boolean
    <System.ComponentModel.Category("Text"),
    System.ComponentModel.Description("Memilih semua teks saat fokus")>
    Public Property SLFPilihSemuaSaatFokus() As Boolean
        Get
            Return _varPilihSemuaSaatFokus
        End Get
        Set(value As Boolean)
            _varPilihSemuaSaatFokus = value
        End Set
    End Property

    Private _varIsBlank As Boolean
    ''' <summary>
    ''' Nilai ini terisi secara otomatis
    ''' </summary>
    ''' <value>True/False</value>
    ''' <returns>True/False</returns>
    ''' <remarks></remarks>
    Public Property SLFIsBlank() As Boolean
        Get
            Return _varIsBlank
        End Get
        Set(value As Boolean)
            _varIsBlank = value
        End Set
    End Property

    Private _varJenisKapital As String
    <Category("Text"),
    Description("Isi akan diubah menjadi kapital semua")>
    Public Property SLFJenisKapital As ControlCodeBase.enuJenisKapital
        Get
            Return _varJenisKapital
        End Get
        Set(value As ControlCodeBase.enuJenisKapital)
            _varJenisKapital = value
        End Set
    End Property

    Private _varRestriction As ControlCodeBase.enuRestriction
    Public Property SLFRestriction As ControlCodeBase.enuRestriction
        Get
            Return _varRestriction
        End Get
        Set(value As ControlCodeBase.enuRestriction)
            _varRestriction = value
        End Set
    End Property

    Private _varIsSearchBox As Boolean
    Public Property SLFIsSearchBox As Boolean
        Get
            Return _varIsSearchBox
        End Get
        Set(value As Boolean)
            _varIsSearchBox = value
        End Set
    End Property

    Private _varSearchBoxText As String
    Public Property SLFSearchBoxText As String
        Get
            Return _varSearchBoxText
        End Get
        Set(value As String)
            _varSearchBoxText = value
        End Set
    End Property
#End Region

#Region "Function"
    Private Function SQLSafeText(ByVal txtControl As txt) As String
        Dim _SQLSafeText As String = txtControl.Text

        If (txtControl.SLFIsSearchBox = True) And (txtControl.Text = txtControl.SLFSearchBoxText) Then
            _SQLSafeText = String.Empty
        End If

        _SQLSafeText = _SQLSafeText.Replace("'", "").Replace(";", "").Replace("--", "").Replace("drop table ", "").Replace("update ", "").Replace("insert into ", "").Replace("--", "").Replace("xp_", "").Trim
        If SLFJenisKapital = ControlCodeBase.enuJenisKapital.KAPITALSEMUA Then
            _SQLSafeText = _SQLSafeText.ToUpper
        ElseIf SLFJenisKapital = ControlCodeBase.enuJenisKapital.kecilsemua Then
            _SQLSafeText = _SQLSafeText.ToLower
        End If
        Return _SQLSafeText
    End Function

    Private Sub CheckRestriction(ByVal _valEnuRestriction As ControlCodeBase.enuRestriction)
        Select Case _valEnuRestriction
            Case ControlCodeBase.enuRestriction.None
                'Do nothing
            Case ControlCodeBase.enuRestriction.OnlyNumber
                'Do Only Number
            Case ControlCodeBase.enuRestriction.OnlyText
                'Do Only Text
            Case ControlCodeBase.enuRestriction.TextAndNumber
                'Do Text and Number
            Case ControlCodeBase.enuRestriction.TextAndSymbol
                'Do Text and Symbol
            Case ControlCodeBase.enuRestriction.Email
                'Do Email
        End Select
    End Sub
#End Region

#Region "Password Strenght Indicator"
    Private _Password As String
    Private _ChrPassword() As Char
    Private _MinPasswordLength As Integer = 8
    Private _BaseScore As Integer
    Private _Score As Integer
    Private _Result As String
    Private _Bonus As New Bonus
    Private _Num As New Num

    Private Sub InitPasswordStrength(ByVal UserInput As String)
        _Password = UserInput
        _ChrPassword = _Password.ToCharArray()

        _Num.Excess = 0
        _Num.Upper = 0
        _Num.Numbers = 0
        _Num.Symbols = 0
        _Bonus.Combo = 0
        _Bonus.FlatLower = 0
        _Bonus.FlatNumber = 0
        _BaseScore = 0
        _Score = 0
    End Sub

    Private Sub AnalyzePassword()

        For i = 0 To (_Password.Length - 1)
            If Regex.IsMatch(_ChrPassword(i), "[0-9]") Then
                _Num.Upper += 1
            ElseIf Regex.IsMatch(_ChrPassword(i), "[A-Z]") Then
                _Num.Numbers += 2
            ElseIf Regex.IsMatch(_ChrPassword(i), "\W") Then
                _Num.Symbols += 3
            End If
        Next

        'If _Match1.Success Then
        '        _Num.Upper += 1
        '    ElseIf _Match2.Success Then
        '    _Num.Numbers += 1
        'ElseIf _Match3.Success Then
        '    _Num.Symbols += 1
        'End If
        '    i += 1
        'Next

        _Num.Excess = _Password.Length - _MinPasswordLength

        If (_Num.Upper > 0 AndAlso _Num.Numbers > 0 AndAlso _Num.Symbols > 0) Then
            _Bonus.Combo = 25
        ElseIf (_Num.Upper > 0 AndAlso _Num.Numbers > 0) Or (_Num.Upper > 0 AndAlso _Num.Symbols > 0) Or (_Num.Numbers > 0 AndAlso _Num.Symbols > 0) Then
            _Bonus.Combo = 15
        End If

        If Regex.IsMatch(_Password, "^[\sa-z]+$") Then
            _Bonus.FlatLower = -15
        End If

        If Regex.IsMatch(_Password, "^[\s0-9]+$") Then
            _Bonus.FlatLower = -35
        End If

    End Sub

    Private Function OutputResultScore() As Integer
        _Score = _BaseScore + (_Num.Excess * _Bonus.Excess) + (_Num.Upper * _Bonus.Upper) + (_Num.Numbers * _Bonus.Numbers) + (_Num.Symbols * _Bonus.Symbols) + _Bonus.Combo + _Bonus.FlatLower + _Bonus.FlatNumber

        If _Score < 0 Then
            _Score = 0
        ElseIf _Score > 100 Then
            _Score = 100
        End If

        Return _Score
    End Function

    Private Function OutputResultText() As String
        _Result = String.Empty
        If _Password.Trim = "" Then
            _Result = "Password must not be empty"
        ElseIf _Password.Length < _MinPasswordLength Then
            _Result = "At leaset " & _MinPasswordLength & " characters please!"
        ElseIf _Score < 50 Then
            _Result = "Weak!"
        ElseIf (_Score >= 50 AndAlso _Score < 75) Then
            _Result = "Average!"
        ElseIf (_Score >= 75 AndAlso _Score < 100) Then
            _Result = "Strong!"
        ElseIf _Score >= 100 Then
            _Result = "Secure!"
        End If
        Return _Result
    End Function
#End Region

    Private _varFlagAutoSelect As Boolean
    Private Sub txt_GotFocus(sender As Object, e As System.EventArgs) Handles Me.GotFocus
        Call FontSearchBox(True)

        If Me.SLFPilihSemuaSaatFokus AndAlso (MouseButtons = Windows.Forms.MouseButtons.None) Then
            Me.SelectAll()
            _varFlagAutoSelect = True
        End If
        If Me.SLFHightlightSaatFokus Then
            MyBase.BackColor = Me.SLFHightlightSaatFokusWarna
        End If
        If Me.SLFPilihSemuaSaatFokus Then
            Me.Select(0, Me.Text.Length)
        End If
        If Not HasKeyboard() Then
            'Call OSK
            Dim OSKProccess As Process = Nothing
            If OSKProccess Is Nothing OrElse OSKProccess.HasExited Then
                If OSKProccess IsNot Nothing AndAlso OSKProccess.HasExited Then
                    OSKProccess.Close()
                End If
                OSKProccess = Process.Start("osk")
            End If
        End If
    End Sub

    Private Sub txt_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If (e.Control And e.KeyCode = Windows.Forms.Keys.A) Then
            Me.SelectAll()
        End If
    End Sub

    Private Sub txt_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress

    End Sub

    Private Sub txt_Leave(sender As Object, e As System.EventArgs) Handles Me.Leave
        _varFlagAutoSelect = False
    End Sub

    Private Sub txt_LostFocus(sender As Object, e As System.EventArgs) Handles Me.LostFocus
        If Me.SLFAutoTrim Then
            Me.Text = Me.Text.Trim()
        End If

        'If Me.SLFHightlightSaatFokus AndAlso Not Me.Focused AndAlso Not Me.SLFHarusDiisi Then
        '    MyBase.BackColor = _varHarusDiisiWarnaLatarDefault
        'ElseIf Me.SLFHightlightSaatFokus AndAlso Not Me.Focused Then
        '    MyBase.BackColor = _varHarusDiisiWarnaLatarDefault
        If Me.ReadOnly = False Then
            If Me.SLFHarusDiisi = True AndAlso Me.Text.Trim = "" Then
                MyBase.BackColor = Me.SLFHarusDiisiWarnaLatar
            Else
                MyBase.BackColor = Me.SLFHarusDiisiWarnaLatarDefault
            End If
        End If

        Call FontSearchBox(False)

        If (Me.SLFPwdStrengthCalculate = True) Then
            Call InitPasswordStrength(MyBase.Text)
            Call AnalyzePassword()
            Me.SLFPwdStrengthScore = OutputResultScore()
            Me.SLFPwdStrengthText = OutputResultText()
        End If
    End Sub

    Private Sub txt_MouseHover(sender As Object, e As EventArgs) Handles Me.MouseHover
        If Me.SLFHightlightSaatFokus And Me.ReadOnly = False Then
            MyBase.BackColor = Me.SLFHightlightSaatFokusWarna
        End If
    End Sub

    Private Sub txt_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        If Me.SLFHightlightSaatFokus And Not Me.Focused And Me.ReadOnly = False Then
            MyBase.BackColor = Me.SLFHarusDiisiWarnaLatarDefault
        End If
    End Sub

    Private Sub txt_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        If Me.SLFPilihSemuaSaatFokus AndAlso (Not _varFlagAutoSelect AndAlso Me.SelectionLength = 0) Then
            _varFlagAutoSelect = True
            Me.SelectAll()
        End If
    End Sub

    Private Sub txt_TextChanged(sender As Object, e As System.EventArgs) Handles Me.TextChanged
        SLFSQLText = SQLSafeText(Me)

        If Me.Text = Nothing Then
            SLFSQLText = ""
        End If
    End Sub

    Public Sub FontSearchBox(ByVal OnFocus As Boolean)
        Try
            If Me.SLFIsSearchBox = True Then
                If OnFocus = True And Me.Text = Me.SLFSearchBoxText Then
                    Me.Text = ""
                    Me.Font = New System.Drawing.Font(Me.Font, System.Drawing.FontStyle.Regular)
                    Me.ForeColor = System.Drawing.SystemColors.WindowText
                ElseIf OnFocus = True And Me.Text = String.Empty Then

                ElseIf OnFocus = False And Me.Text = String.Empty Then
                    Me.Font = New System.Drawing.Font(Me.Font, System.Drawing.FontStyle.Italic)
                    Me.ForeColor = System.Drawing.Color.LightGray
                    Me.Text = Me.SLFSearchBoxText
                End If
            Else
                MyBase.Font = New System.Drawing.Font(MyBase.Font, System.Drawing.FontStyle.Regular)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt_Validating(sender As Object, e As CancelEventArgs) Handles Me.Validating
        If Me.SLFHarusDiisi = True AndAlso Me.Text.Trim = "" Then
            Me.SLFIsBlank = True
        Else
            Me.SLFIsBlank = False
        End If
    End Sub

    Private Function HasKeyboard()
        Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_Keyboard")
        Dim result = From mobj In searcher.Get()
                     Select mobj Where mobj("Status").ToString() = 0
        Return Not IsNothing(result)
    End Function

    Public Sub ClearSearch()
        Call FontSearchBox(False)
    End Sub
End Class

''' <summary>
''' 
''' </summary>
Public Class Num
    Property Excess As Integer = 0
    Property Upper As Integer = 0
    Property Numbers As Integer = 0
    Property Symbols As Integer = 0
End Class

Public Class Bonus
    Property Excess As Integer = 3
    Property Upper As Integer = 4
    Property Numbers As Integer = 5
    Property Symbols As Integer = 5
    Property Combo As Integer = 0
    Property FlatLower As Integer = 0
    Property FlatNumber As Integer = 0
End Class
