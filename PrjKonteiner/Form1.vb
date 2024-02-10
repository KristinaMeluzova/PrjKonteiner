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
        btnStop.Enabled = False
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



End Class
