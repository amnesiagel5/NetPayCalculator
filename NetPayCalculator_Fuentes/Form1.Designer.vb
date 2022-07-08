<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NetPay_Calculator
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblGross = New System.Windows.Forms.Label()
        Me.lblSSS = New System.Windows.Forms.Label()
        Me.lblPhilHealth = New System.Windows.Forms.Label()
        Me.lblPagibig = New System.Windows.Forms.Label()
        Me.lblHealthcare = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtGross = New System.Windows.Forms.TextBox()
        Me.txtSSS = New System.Windows.Forms.TextBox()
        Me.txtPhilHealth = New System.Windows.Forms.TextBox()
        Me.txtPagibig = New System.Windows.Forms.TextBox()
        Me.txtHealthcare = New System.Windows.Forms.TextBox()
        Me.btnCalc_Netpay = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(164, 116)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(50, 18)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name :"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.Location = New System.Drawing.Point(176, 144)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(36, 18)
        Me.lblAge.TabIndex = 1
        Me.lblAge.Text = "Age :"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(150, 181)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(62, 18)
        Me.lblAddress.TabIndex = 2
        Me.lblAddress.Text = "Address :"
        '
        'lblGross
        '
        Me.lblGross.AutoSize = True
        Me.lblGross.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGross.Location = New System.Drawing.Point(139, 246)
        Me.lblGross.Name = "lblGross"
        Me.lblGross.Size = New System.Drawing.Size(73, 18)
        Me.lblGross.TabIndex = 3
        Me.lblGross.Text = "Gross Pay :"
        '
        'lblSSS
        '
        Me.lblSSS.AutoSize = True
        Me.lblSSS.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSSS.Location = New System.Drawing.Point(177, 290)
        Me.lblSSS.Name = "lblSSS"
        Me.lblSSS.Size = New System.Drawing.Size(35, 18)
        Me.lblSSS.TabIndex = 4
        Me.lblSSS.Text = "SSS :"
        '
        'lblPhilHealth
        '
        Me.lblPhilHealth.AutoSize = True
        Me.lblPhilHealth.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhilHealth.Location = New System.Drawing.Point(135, 330)
        Me.lblPhilHealth.Name = "lblPhilHealth"
        Me.lblPhilHealth.Size = New System.Drawing.Size(76, 18)
        Me.lblPhilHealth.TabIndex = 5
        Me.lblPhilHealth.Text = "PhilHealth :"
        '
        'lblPagibig
        '
        Me.lblPagibig.AutoSize = True
        Me.lblPagibig.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPagibig.Location = New System.Drawing.Point(150, 375)
        Me.lblPagibig.Name = "lblPagibig"
        Me.lblPagibig.Size = New System.Drawing.Size(62, 18)
        Me.lblPagibig.TabIndex = 6
        Me.lblPagibig.Text = "Pag-Ibig :"
        '
        'lblHealthcare
        '
        Me.lblHealthcare.AutoSize = True
        Me.lblHealthcare.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHealthcare.Location = New System.Drawing.Point(129, 420)
        Me.lblHealthcare.Name = "lblHealthcare"
        Me.lblHealthcare.Size = New System.Drawing.Size(84, 18)
        Me.lblHealthcare.TabIndex = 7
        Me.lblHealthcare.Text = "Health Care :"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.MintCream
        Me.txtName.Location = New System.Drawing.Point(218, 105)
        Me.txtName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(405, 25)
        Me.txtName.TabIndex = 8
        '
        'txtAge
        '
        Me.txtAge.BackColor = System.Drawing.Color.MintCream
        Me.txtAge.Location = New System.Drawing.Point(218, 141)
        Me.txtAge.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(405, 25)
        Me.txtAge.TabIndex = 9
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.Color.MintCream
        Me.txtAddress.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(218, 177)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(405, 25)
        Me.txtAddress.TabIndex = 10
        '
        'txtGross
        '
        Me.txtGross.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGross.Location = New System.Drawing.Point(218, 242)
        Me.txtGross.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtGross.Name = "txtGross"
        Me.txtGross.Size = New System.Drawing.Size(165, 25)
        Me.txtGross.TabIndex = 11
        '
        'txtSSS
        '
        Me.txtSSS.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSSS.Location = New System.Drawing.Point(218, 287)
        Me.txtSSS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSSS.Name = "txtSSS"
        Me.txtSSS.Size = New System.Drawing.Size(165, 25)
        Me.txtSSS.TabIndex = 12
        '
        'txtPhilHealth
        '
        Me.txtPhilHealth.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPhilHealth.Location = New System.Drawing.Point(217, 330)
        Me.txtPhilHealth.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPhilHealth.Name = "txtPhilHealth"
        Me.txtPhilHealth.Size = New System.Drawing.Size(166, 25)
        Me.txtPhilHealth.TabIndex = 13
        '
        'txtPagibig
        '
        Me.txtPagibig.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPagibig.Location = New System.Drawing.Point(217, 372)
        Me.txtPagibig.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPagibig.Name = "txtPagibig"
        Me.txtPagibig.Size = New System.Drawing.Size(166, 25)
        Me.txtPagibig.TabIndex = 14
        '
        'txtHealthcare
        '
        Me.txtHealthcare.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtHealthcare.Location = New System.Drawing.Point(218, 415)
        Me.txtHealthcare.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtHealthcare.Name = "txtHealthcare"
        Me.txtHealthcare.Size = New System.Drawing.Size(165, 25)
        Me.txtHealthcare.TabIndex = 15
        '
        'btnCalc_Netpay
        '
        Me.btnCalc_Netpay.Font = New System.Drawing.Font("Open Sans Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc_Netpay.Location = New System.Drawing.Point(507, 287)
        Me.btnCalc_Netpay.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCalc_Netpay.Name = "btnCalc_Netpay"
        Me.btnCalc_Netpay.Size = New System.Drawing.Size(117, 32)
        Me.btnCalc_Netpay.TabIndex = 16
        Me.btnCalc_Netpay.Text = "&Calculate Net Pay"
        Me.btnCalc_Netpay.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Open Sans Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(507, 346)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(117, 32)
        Me.btnReset.TabIndex = 17
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Open Sans Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(507, 411)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(117, 32)
        Me.btnExit.TabIndex = 18
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'NetPay_Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(933, 623)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalc_Netpay)
        Me.Controls.Add(Me.txtHealthcare)
        Me.Controls.Add(Me.txtPagibig)
        Me.Controls.Add(Me.txtPhilHealth)
        Me.Controls.Add(Me.txtSSS)
        Me.Controls.Add(Me.txtGross)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblHealthcare)
        Me.Controls.Add(Me.lblPagibig)
        Me.Controls.Add(Me.lblPhilHealth)
        Me.Controls.Add(Me.lblSSS)
        Me.Controls.Add(Me.lblGross)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.lblName)
        Me.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "NetPay_Calculator"
        Me.Text = "Net Pay Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblGross As Label
    Friend WithEvents lblSSS As Label
    Friend WithEvents lblPhilHealth As Label
    Friend WithEvents lblPagibig As Label
    Friend WithEvents lblHealthcare As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtGross As TextBox
    Friend WithEvents txtSSS As TextBox
    Friend WithEvents txtPhilHealth As TextBox
    Friend WithEvents txtPagibig As TextBox
    Friend WithEvents txtHealthcare As TextBox
    Friend WithEvents btnCalc_Netpay As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
End Class
