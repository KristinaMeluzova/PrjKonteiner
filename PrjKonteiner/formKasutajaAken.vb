Imports System.Runtime.Remoting.Contexts
Imports PrjTekstiPooraja2

Public Class formKasutajaAken
    Private Sub btnPoora1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnPoora1.Click
        'Objekti loomine liidese baasil; referentsmuutuja pooraja deklatsatsioon
        Dim Pooraja As PrjTekstiPooraja2.ITeisendused
        'Seadistame referentsmuutuja viitama uuele objektile
        Pooraja = New PrjTekstiPooraja2.CTekstiPooraja
        'TEOSTAME TEKSTI PÖÖRAMISE KASUTADES PARAMEETRISEERITA FUNKTSIOONI pooraTekst 
        'NING LIIDESE ATRIBUUTI strTekst
        Pooraja.strTekst = txtSisendTekst.Text
        txtValjundTekst1.Text = Pooraja.pooraTekst
    End Sub

    Private Sub btnPoora2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnPoora2.Click
        'Objekti loomine liidese baasil; referentsmuutuja pooraja deklatsatsioon
        Dim Pooraja As PrjTekstiPooraja2.ITeisendused
        'Seadistame referentsmuutuja viitama uuele objektile
        Pooraja = New PrjTekstiPooraja2.CTekstiPooraja
        'TEOSTAME TEKSTI PÖÖRAMISE KASUTADES PARAMEETRISEERITA FUNKTSIOONI pooraTekst 
        'NING LIIDESE ATRIBUUTI strTekst
        Pooraja.teisendaTekst(txtSisendTekst.Text)
        txtValjundTekst2.Text = Pooraja.strTekst
    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        timerUuenda.Enabled = True
        btnStart.Enabled = False
    End Sub

    Private Sub timerUuenda_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles timerUuenda.Tick
        'Objekti loomine liidese baasil; referentsmuutuja pooraja deklatsatsioon
        Dim Pooraja As PrjTekstiPooraja2.ITeisendused
        'Seadistame referentsmuutuja viitama uuele objektile
        Pooraja = New PrjTekstiPooraja2.CTekstiPooraja
        'TEOSTAME TEKSTI PÖÖRAMISE KASUTADES PARAMEETRISEERITA FUNKTSIOONI pooraTekst 
        'NING LIIDESE ATRIBUUTI strTekst
        Pooraja.strTekst = txtSisendTekst.Text
        txtValjundTekst1.Text = Pooraja.pooraTekst
    End Sub

    Private Sub btnStop_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        timerUuenda.Enabled = False
        btnStart.Enabled = True
    End Sub

    'Kirjutame funktsioon pikkuse arvu tekstis leidmiseks kasutades funktsioon Len()
    Function charCount(text As String) As Integer
        Return Len(text)
    End Function

    Private Function countChar(ByVal text As String) As Integer
        Dim charstate As Integer = 0  'tääshääliku arvutamiseks 
        For Each charac As Char In text.ToLower()
            If "aeiouy".Contains(charac) Then
                charstate += 1
            End If
        Next
        Return charstate
    End Function

    'Siin kirjutame leitud eelmisel funktsioonil arvud txtSisendTekst tekstist Labeli 2
    Private Sub txtSisendTekst_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles txtSisendTekst.TextChanged
        Label2.Text = charCount(txtSisendTekst.Text) 'Teksti pikkuse arv
        Label3.Text = countChar(txtSisendTekst.Text).ToString()  'täishäälike pikkuse arv
    End Sub

    Private Sub CAlgoCheck_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles CAlgoCheck.CheckedChanged
        Dim teisendus As PrjTekstiPooraja2.ITeisendused
        If CAlgoCheck.Checked Then
            teisendus = New CAlgoritmilinePooraja
        Else
            teisendus = New CTekstiPooraja
        End If
    End Sub
End Class
