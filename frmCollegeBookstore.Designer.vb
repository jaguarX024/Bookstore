<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCollegeBookstore
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCollegeBookstore))
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cboSoftwares = New System.Windows.Forms.ComboBox()
        Me.lblCreditCard = New System.Windows.Forms.Label()
        Me.txtCreditCardNumber = New System.Windows.Forms.TextBox()
        Me.lblExpirationDate = New System.Windows.Forms.Label()
        Me.txtExpirationDate = New System.Windows.Forms.TextBox()
        Me.grpStudent = New System.Windows.Forms.GroupBox()
        Me.radCustomer = New System.Windows.Forms.RadioButton()
        Me.radStudent = New System.Windows.Forms.RadioButton()
        Me.btnFinalTotal = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDailyTotal = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTotalNumber = New System.Windows.Forms.Label()
        Me.lblDailyTotal = New System.Windows.Forms.Label()
        Me.lblDailyTotalInNumber = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpStudent.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(345, 23)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(305, 25)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "College Bookstore Access Codes"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 82)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(258, 191)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'cboSoftwares
        '
        Me.cboSoftwares.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSoftwares.FormattingEnabled = True
        Me.cboSoftwares.Items.AddRange(New Object() {"Visio $14.99", "QuickBooks $24.99", "Project $17.99", "Power Bi $9.99", "Speed Type $29.99"})
        Me.cboSoftwares.Location = New System.Drawing.Point(428, 91)
        Me.cboSoftwares.Name = "cboSoftwares"
        Me.cboSoftwares.Size = New System.Drawing.Size(151, 26)
        Me.cboSoftwares.TabIndex = 2
        Me.cboSoftwares.Text = "Select a Software"
        '
        'lblCreditCard
        '
        Me.lblCreditCard.AutoSize = True
        Me.lblCreditCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreditCard.Location = New System.Drawing.Point(289, 163)
        Me.lblCreditCard.Name = "lblCreditCard"
        Me.lblCreditCard.Size = New System.Drawing.Size(200, 20)
        Me.lblCreditCard.TabIndex = 3
        Me.lblCreditCard.Text = "Enter credit card number:"
        '
        'txtCreditCardNumber
        '
        Me.txtCreditCardNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreditCardNumber.Location = New System.Drawing.Point(495, 163)
        Me.txtCreditCardNumber.Name = "txtCreditCardNumber"
        Me.txtCreditCardNumber.Size = New System.Drawing.Size(281, 24)
        Me.txtCreditCardNumber.TabIndex = 4
        '
        'lblExpirationDate
        '
        Me.lblExpirationDate.AutoSize = True
        Me.lblExpirationDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpirationDate.Location = New System.Drawing.Point(293, 213)
        Me.lblExpirationDate.Name = "lblExpirationDate"
        Me.lblExpirationDate.Size = New System.Drawing.Size(217, 20)
        Me.lblExpirationDate.TabIndex = 5
        Me.lblExpirationDate.Text = "Enter expiration date (year):"
        '
        'txtExpirationDate
        '
        Me.txtExpirationDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExpirationDate.Location = New System.Drawing.Point(528, 211)
        Me.txtExpirationDate.Name = "txtExpirationDate"
        Me.txtExpirationDate.Size = New System.Drawing.Size(100, 24)
        Me.txtExpirationDate.TabIndex = 6
        '
        'grpStudent
        '
        Me.grpStudent.BackColor = System.Drawing.Color.Tan
        Me.grpStudent.Controls.Add(Me.radCustomer)
        Me.grpStudent.Controls.Add(Me.radStudent)
        Me.grpStudent.Location = New System.Drawing.Point(297, 258)
        Me.grpStudent.Name = "grpStudent"
        Me.grpStudent.Size = New System.Drawing.Size(200, 92)
        Me.grpStudent.TabIndex = 7
        Me.grpStudent.TabStop = False
        Me.grpStudent.Text = "GroupBox1"
        '
        'radCustomer
        '
        Me.radCustomer.AutoSize = True
        Me.radCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCustomer.Location = New System.Drawing.Point(7, 66)
        Me.radCustomer.Name = "radCustomer"
        Me.radCustomer.Size = New System.Drawing.Size(144, 22)
        Me.radCustomer.TabIndex = 1
        Me.radCustomer.TabStop = True
        Me.radCustomer.Text = "Simple Customer"
        Me.radCustomer.UseVisualStyleBackColor = True
        '
        'radStudent
        '
        Me.radStudent.AutoSize = True
        Me.radStudent.Checked = True
        Me.radStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radStudent.Location = New System.Drawing.Point(7, 22)
        Me.radStudent.Name = "radStudent"
        Me.radStudent.Size = New System.Drawing.Size(79, 22)
        Me.radStudent.TabIndex = 0
        Me.radStudent.TabStop = True
        Me.radStudent.Text = "Student"
        Me.radStudent.UseVisualStyleBackColor = True
        '
        'btnFinalTotal
        '
        Me.btnFinalTotal.BackColor = System.Drawing.Color.PeachPuff
        Me.btnFinalTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinalTotal.Location = New System.Drawing.Point(87, 405)
        Me.btnFinalTotal.Name = "btnFinalTotal"
        Me.btnFinalTotal.Size = New System.Drawing.Size(157, 33)
        Me.btnFinalTotal.TabIndex = 8
        Me.btnFinalTotal.Text = "Final Button"
        Me.btnFinalTotal.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.PeachPuff
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(350, 405)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 33)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnDailyTotal
        '
        Me.btnDailyTotal.BackColor = System.Drawing.Color.PeachPuff
        Me.btnDailyTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDailyTotal.Location = New System.Drawing.Point(536, 405)
        Me.btnDailyTotal.Name = "btnDailyTotal"
        Me.btnDailyTotal.Size = New System.Drawing.Size(163, 33)
        Me.btnDailyTotal.TabIndex = 10
        Me.btnDailyTotal.Text = "Daily Total"
        Me.btnDailyTotal.UseVisualStyleBackColor = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.LightCyan
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(524, 268)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(115, 22)
        Me.lblTotal.TabIndex = 11
        Me.lblTotal.Text = "Your total is :"
        Me.lblTotal.Visible = False
        '
        'lblTotalNumber
        '
        Me.lblTotalNumber.AutoSize = True
        Me.lblTotalNumber.BackColor = System.Drawing.Color.LightCyan
        Me.lblTotalNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalNumber.Location = New System.Drawing.Point(699, 268)
        Me.lblTotalNumber.Name = "lblTotalNumber"
        Me.lblTotalNumber.Size = New System.Drawing.Size(46, 22)
        Me.lblTotalNumber.TabIndex = 12
        Me.lblTotalNumber.Text = "XXX"
        Me.lblTotalNumber.Visible = False
        '
        'lblDailyTotal
        '
        Me.lblDailyTotal.AutoSize = True
        Me.lblDailyTotal.BackColor = System.Drawing.Color.LightCyan
        Me.lblDailyTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDailyTotal.Location = New System.Drawing.Point(525, 314)
        Me.lblDailyTotal.Name = "lblDailyTotal"
        Me.lblDailyTotal.Size = New System.Drawing.Size(157, 22)
        Me.lblDailyTotal.TabIndex = 13
        Me.lblDailyTotal.Text = "Your daily total is: "
        Me.lblDailyTotal.Visible = False
        '
        'lblDailyTotalInNumber
        '
        Me.lblDailyTotalInNumber.AutoSize = True
        Me.lblDailyTotalInNumber.BackColor = System.Drawing.Color.LightCyan
        Me.lblDailyTotalInNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDailyTotalInNumber.Location = New System.Drawing.Point(699, 314)
        Me.lblDailyTotalInNumber.Name = "lblDailyTotalInNumber"
        Me.lblDailyTotalInNumber.Size = New System.Drawing.Size(46, 22)
        Me.lblDailyTotalInNumber.TabIndex = 14
        Me.lblDailyTotalInNumber.Text = "XXX"
        Me.lblDailyTotalInNumber.Visible = False
        '
        'frmCollegeBookstore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblDailyTotalInNumber)
        Me.Controls.Add(Me.lblDailyTotal)
        Me.Controls.Add(Me.lblTotalNumber)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnDailyTotal)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnFinalTotal)
        Me.Controls.Add(Me.grpStudent)
        Me.Controls.Add(Me.txtExpirationDate)
        Me.Controls.Add(Me.lblExpirationDate)
        Me.Controls.Add(Me.txtCreditCardNumber)
        Me.Controls.Add(Me.lblCreditCard)
        Me.Controls.Add(Me.cboSoftwares)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmCollegeBookstore"
        Me.Text = "College Bookstore Access Codes"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpStudent.ResumeLayout(False)
        Me.grpStudent.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cboSoftwares As ComboBox
    Friend WithEvents lblCreditCard As Label
    Friend WithEvents txtCreditCardNumber As TextBox
    Friend WithEvents lblExpirationDate As Label
    Friend WithEvents txtExpirationDate As TextBox
    Friend WithEvents grpStudent As GroupBox
    Friend WithEvents radStudent As RadioButton
    Friend WithEvents radCustomer As RadioButton
    Friend WithEvents btnFinalTotal As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDailyTotal As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTotalNumber As Label
    Friend WithEvents lblDailyTotal As Label
    Friend WithEvents lblDailyTotalInNumber As Label
End Class
