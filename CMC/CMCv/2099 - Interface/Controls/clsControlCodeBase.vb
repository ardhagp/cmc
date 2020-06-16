Public Class ControlCodeBase
    ''' <summary>
    ''' Enumerasi jenis tombol
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum enuJenisTombol
        Yes = 1
        No = 2
        [Default] = 3
        Warning = 4
        Custom = 99
    End Enum

    ''' <summary>
    ''' Enumerasi jenis warna label
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum enuJenisLabel
        [Default] = 1
        Green = 2
        Red = 3
        Grey = 4
        Yellow = 5
        Custom = 99
    End Enum

    ''' <summary>
    ''' Enumerasi jenis warna
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum enuJenisWarna
        Solid = 1
        Gradien = 2
    End Enum

    ''' <summary>
    ''' Enumerasi arah gradien
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum enuArahGradien
        Vertikal = 1
        Horizontal = 2
    End Enum

    ''' <summary>
    ''' Enumerasi jenis validasi
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum enuJenisValidasi
        Email = 1
        HanyaAngka = 2
        TanpaValidasi = 99
    End Enum

    ''' <summary>
    ''' Enumerasi jenis kapital
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum enuJenisKapital
        KAPITALSEMUA = 1
        kecilsemua = 2
        Normal = 99
    End Enum

    ''' <summary>
    ''' Enumerasi warna
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum enuOpasitasWarna
        Darker = 1
        Lighter = 2
    End Enum

    Public Enum enuRestriction
        None = 0
        OnlyText = 1
        OnlyNumber = 2
        TextAndNumber = 3
        TextAndSymbol = 4
        Email = 5
    End Enum

    ''' <summary>
    ''' Fungsi untuk mengembalikan nilai warna baru secara acak.
    ''' </summary>
    ''' <returns>Color</returns>
    ''' <remarks></remarks>
    ''' <param name="RMin">Nilai minimum warna merah</param>
    ''' <param name="RMax">Nilai maksimum warna merah</param>
    ''' <param name="GMin">Nilai maminimum warna hijau</param>
    ''' <param name="GMax">Nilai maksimum warna hijau</param>
    ''' <param name="BMin">Nilai minimum warna biru</param>
    ''' <param name="BMax">Nilai maksimum warna biru</param>
    Public Function WarnaAcakBaru(ByVal RMin As Integer, ByVal RMax As Integer, ByVal GMin As Integer, ByVal GMax As Integer, ByVal BMin As Integer, ByVal BMax As Integer) As System.Drawing.Color
        Return System.Drawing.Color.FromArgb(_randomcolor.Next(RMin, RMax), _randomcolor.Next(GMin, GMax), _randomcolor.Next(BMin, BMax))
    End Function

    ''' <summary>
    ''' Fungsi untuk mengambil warna.
    ''' </summary>
    ''' <param name="_valWarnaObjek">Objek warna.</param>
    ''' <param name="_valOpasitasWarna">Opasitas warna.</param>
    ''' <param name="_valIntensitasPerubahan">Intensitas perubahan.</param>
    ''' <returns>Wara RGB</returns>
    Public Function AmbilWarna(ByVal _valWarnaObjek As System.Drawing.Color, ByVal _valOpasitasWarna As enuOpasitasWarna, ByVal _valIntensitasPerubahan As Integer) As System.Drawing.Color
        Dim re As Integer = _valWarnaObjek.R
        Dim gr As Integer = _valWarnaObjek.G
        Dim bl As Integer = _valWarnaObjek.B

        Select Case _valOpasitasWarna
            Case enuOpasitasWarna.Darker
                If Not (re < (0 + _valIntensitasPerubahan)) Then
                    re = re - _valIntensitasPerubahan
                End If
                If Not (gr < (0 + _valIntensitasPerubahan)) Then
                    gr = gr - _valIntensitasPerubahan
                End If
                If Not (bl < (0 + _valIntensitasPerubahan)) Then
                    bl = bl - _valIntensitasPerubahan
                End If
            Case enuOpasitasWarna.Lighter
                If Not (re > (255 - _valIntensitasPerubahan)) Then
                    re = re + _valIntensitasPerubahan
                End If
                If Not (gr > (255 - _valIntensitasPerubahan)) Then
                    gr = gr + _valIntensitasPerubahan
                End If
                If Not (bl > (255 - _valIntensitasPerubahan)) Then
                    bl = bl + _valIntensitasPerubahan
                End If
        End Select

        Return System.Drawing.Color.FromArgb(re, gr, bl)
    End Function

    'Public Function GantiJenisKapital(ByVal _valJenisKapital As enuJenisKapital) As System.Windows.Forms.CharacterCasing
    '    Dim _varKapital As System.Windows.Forms.CharacterCasing
    '    Select Case _valJenisKapital
    '        Case enuJenisKapital.KAPITALSEMUA
    '            _varKapital = System.Windows.Forms.CharacterCasing.Upper
    '        Case enuJenisKapital.kecilsemua
    '            _varKapital = System.Windows.Forms.CharacterCasing.Lower
    '        Case enuJenisKapital.Normal
    '            _varKapital = System.Windows.Forms.CharacterCasing.Normal
    '    End Select

    '    Return _varKapital
    'End Function
End Class
