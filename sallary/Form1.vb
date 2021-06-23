Public Class Form1

    Private Sub Btn_Calc_Click(sender As Object, e As EventArgs) Handles Btn_Calc.Click
        'المتغيرات
        'يمكن للمرتب أن يكون من Double
        'إذا كان المرتب يقبل الكسور العشرية

        Dim sallary As Integer = Val(Txt_Sallary.Text)
        Dim absDays As Integer = Val(Txt_AbsDays.Text)

        'المستحق
        Lbl_in1.Text = sallary * 0.07
        Lbl_in2.Text = sallary * 0.05
        'إجمالي المستحق
        Lbl_totalin.Text = Val(Lbl_in1.Text) + Val(Lbl_in2.Text) + sallary

        'المستقطع
        Lbl_out1.Text = sallary * 0.08
        'مستقطع أيام الغياب
        If absDays = 0 Then
            'لايجد غياب
            Lbl_out2.Text = "0"
        Else
            'يوجد غياب
            Lbl_out2.Text = sallary * absDays * 0.02
        End If


        'الإجمالي المستقطع
        Lbl_totalOut.Text = Val(Lbl_out1.Text) + Val(Lbl_out2.Text)

        'إجمالي الراتب
        Lbl_netSallary.Text = Val(Lbl_totalin.Text) - Val(Lbl_totalOut.Text)
    End Sub

End Class
