Imports System.Runtime.Remoting.Contexts
Imports PrjTekstiPooraja

Public Class Form1
    Private Sub btnPoora1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnPoora1.Click
        'Objekti loomine liidese baasil; referentsmuutuja pooraja deklatsatsioon
        Dim Pooraja As PrjTekstiPooraja.ITeisendused
        'Seadistame referentsmuutuja viitama uuele objektile
        Pooraja = New PrjTekstiPooraja.CTekstiPooraja
        'TEOSTAME TEKSTI PÖÖRAMISE KASUTADES PARAMEETRISEERITA FUNKTSIOONI pooraTekst 
        'NING LIIDESE ATRIBUUTI strTekst
        Pooraja.strTekst = txtSisendTekst.Text
        txtValjundTekst1.Text = Pooraja.pooraTekst
    End Sub

    Private Sub btnPoora2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnPoora2.Click
        'Objekti loomine liidese baasil; referentsmuutuja pooraja deklatsatsioon
        Dim Pooraja As PrjTekstiPooraja.ITeisendused
        'Seadistame referentsmuutuja viitama uuele objektile
        Pooraja = New PrjTekstiPooraja.CTekstiPooraja
        'TEOSTAME TEKSTI PÖÖRAMISE KASUTADES PARAMEETRISEERITA FUNKTSIOONI pooraTekst 
        'NING LIIDESE ATRIBUUTI strTekst
        Pooraja.strTekst = txtSisendTekst.Text
        txtValjundTekst2.Text = Pooraja.pooraTekst
    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        timerUuenda.Enabled = True
        btnStart.Enabled = False
    End Sub

    Private Sub btnStop_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        timerUuenda.Enabled = False
        btnStart.Enabled = True
    End Sub

    Private Sub timerUuenda_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerUuenda.Tick
        'Objekti loomine liidese baasil; referentsmuutuja pooraja deklatsatsioon
        Dim Pooraja As PrjTekstiPooraja.ITeisendused
        'Seadistame referentsmuutuja viitama uuele objektile
        Pooraja = New PrjTekstiPooraja.CTekstiPooraja
        'TEOSTAME TEKSTI PÖÖRAMISE KASUTADES PARAMEETRISEERITA FUNKTSIOONI pooraTekst 
        'NING LIIDESE ATRIBUUTI strTekst
        Pooraja.strTekst = txtSisendTekst.Text
        txtValjundTekst1.Text = Pooraja.pooraTekst
    End Sub
    'Kirjutame funktsioon pikkuse arvu tekstis leidmiseks kasutades funktsioon Len()
    Function charCount(text As String) As Integer
        Return Len(text)
    End Function
    Function sortCount(sisendtext As String) As Integer 'täishäälike leidmiseks
        Dim characters As String = "aeiouAEIOU"
        Dim sortString As String = ""
        Dim i As Integer = 0
        For Each character As Char In characters
            If sisendtext.Contains(character) Then
                sortString &= character
            End If
        Next

        Return Len(sortString)
    End Function

    'Siin kirjutame leitud eelmisel funktsioonil arvud txtSisendTekst tekstist Labeli 2
    Private Sub txtSisendTekst_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles txtSisendTekst.TextChanged
        Label2.Text = charCount(txtSisendTekst.Text) 'Teksti pikkuse arv
        Label3.Text = sortCount(txtSisendTekst.Text) 'täishäälikke pikkuse arv
    End Sub

    Private Sub CAlgoCheck_CheckedChanged(sender As Object, e As EventArgs) _
        Handles CAlgoCheck.CheckedChanged
        Dim teisendus As PrjTekstiPooraja.ITeisendused
        If CAlgoCheck.Checked Then
            teisendus = New CAlgoritmilinePooraja
        Else
            teisendus = New CTekstiPooraja
        End If
    End Sub
End Class
