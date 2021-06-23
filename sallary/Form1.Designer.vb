<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Lbl_totalin = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Lbl_in2 = New System.Windows.Forms.Label()
        Me.Lbl_in1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Lbl_totalOut = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Lbl_out2 = New System.Windows.Forms.Label()
        Me.Lbl_out1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Btn_Calc = New System.Windows.Forms.Button()
        Me.Txt_AbsDays = New System.Windows.Forms.TextBox()
        Me.Txt_Sallary = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Lbl_netSallary = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(607, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "الراتب الأساسي"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(206, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "بدل طبيعة عمل 7%:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(258, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "بدل ؟ 5%:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(216, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "التأمين الصحي 8%:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(216, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "غياب 2%:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Lbl_totalin)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Lbl_in2)
        Me.GroupBox1.Controls.Add(Me.Lbl_in1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(401, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(357, 173)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "مستحقات"
        '
        'Lbl_totalin
        '
        Me.Lbl_totalin.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Lbl_totalin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_totalin.Location = New System.Drawing.Point(19, 125)
        Me.Lbl_totalin.Name = "Lbl_totalin"
        Me.Lbl_totalin.Size = New System.Drawing.Size(194, 28)
        Me.Lbl_totalin.TabIndex = 12
        Me.Lbl_totalin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(219, 131)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(118, 17)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "إجمالي المستحق:"
        '
        'Lbl_in2
        '
        Me.Lbl_in2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Lbl_in2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_in2.Location = New System.Drawing.Point(6, 62)
        Me.Lbl_in2.Name = "Lbl_in2"
        Me.Lbl_in2.Size = New System.Drawing.Size(194, 28)
        Me.Lbl_in2.TabIndex = 10
        Me.Lbl_in2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_in1
        '
        Me.Lbl_in1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Lbl_in1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_in1.Location = New System.Drawing.Point(6, 32)
        Me.Lbl_in1.Name = "Lbl_in1"
        Me.Lbl_in1.Size = New System.Drawing.Size(194, 28)
        Me.Lbl_in1.TabIndex = 9
        Me.Lbl_in1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Lbl_totalOut)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Lbl_out2)
        Me.GroupBox2.Controls.Add(Me.Lbl_out1)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(30, 67)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(365, 173)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "خصومات"
        '
        'Lbl_totalOut
        '
        Me.Lbl_totalOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Lbl_totalOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_totalOut.Location = New System.Drawing.Point(21, 125)
        Me.Lbl_totalOut.Name = "Lbl_totalOut"
        Me.Lbl_totalOut.Size = New System.Drawing.Size(194, 28)
        Me.Lbl_totalOut.TabIndex = 14
        Me.Lbl_totalOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(221, 131)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(98, 17)
        Me.Label16.TabIndex = 13
        Me.Label16.Text = "إجمالي الخصم:"
        '
        'Lbl_out2
        '
        Me.Lbl_out2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Lbl_out2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_out2.Location = New System.Drawing.Point(21, 62)
        Me.Lbl_out2.Name = "Lbl_out2"
        Me.Lbl_out2.Size = New System.Drawing.Size(194, 28)
        Me.Lbl_out2.TabIndex = 8
        Me.Lbl_out2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_out1
        '
        Me.Lbl_out1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Lbl_out1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_out1.Location = New System.Drawing.Point(21, 32)
        Me.Lbl_out1.Name = "Lbl_out1"
        Me.Lbl_out1.Size = New System.Drawing.Size(194, 28)
        Me.Lbl_out1.TabIndex = 6
        Me.Lbl_out1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Btn_Calc)
        Me.GroupBox3.Controls.Add(Me.Txt_AbsDays)
        Me.GroupBox3.Controls.Add(Me.Txt_Sallary)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(30, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(728, 49)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "حساب"
        '
        'Btn_Calc
        '
        Me.Btn_Calc.Location = New System.Drawing.Point(115, 13)
        Me.Btn_Calc.Name = "Btn_Calc"
        Me.Btn_Calc.Size = New System.Drawing.Size(76, 28)
        Me.Btn_Calc.TabIndex = 4
        Me.Btn_Calc.Text = "حساب"
        Me.Btn_Calc.UseVisualStyleBackColor = True
        '
        'Txt_AbsDays
        '
        Me.Txt_AbsDays.Location = New System.Drawing.Point(207, 13)
        Me.Txt_AbsDays.Name = "Txt_AbsDays"
        Me.Txt_AbsDays.Size = New System.Drawing.Size(100, 24)
        Me.Txt_AbsDays.TabIndex = 3
        Me.Txt_AbsDays.Text = "0"
        Me.Txt_AbsDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_Sallary
        '
        Me.Txt_Sallary.Location = New System.Drawing.Point(434, 17)
        Me.Txt_Sallary.Name = "Txt_Sallary"
        Me.Txt_Sallary.Size = New System.Drawing.Size(167, 24)
        Me.Txt_Sallary.TabIndex = 2
        Me.Txt_Sallary.Text = "30000"
        Me.Txt_Sallary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(313, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 17)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "عدد أيام الغياب"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Lbl_netSallary)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Location = New System.Drawing.Point(30, 246)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(728, 49)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "الإجمالي"
        '
        'Lbl_netSallary
        '
        Me.Lbl_netSallary.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Lbl_netSallary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_netSallary.Location = New System.Drawing.Point(205, 10)
        Me.Lbl_netSallary.Name = "Lbl_netSallary"
        Me.Lbl_netSallary.Size = New System.Drawing.Size(194, 28)
        Me.Lbl_netSallary.TabIndex = 14
        Me.Lbl_netSallary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(405, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 17)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "إجمالي الراتب:"
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(771, 307)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "حساب راتب الموظف"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Btn_Calc As Button
    Friend WithEvents Txt_AbsDays As TextBox
    Friend WithEvents Txt_Sallary As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Lbl_totalin As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Lbl_in2 As Label
    Friend WithEvents Lbl_in1 As Label
    Friend WithEvents Lbl_totalOut As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Lbl_out2 As Label
    Friend WithEvents Lbl_out1 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Lbl_netSallary As Label
    Friend WithEvents Label9 As Label
End Class
