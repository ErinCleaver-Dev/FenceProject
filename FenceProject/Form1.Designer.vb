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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.lbCost = New System.Windows.Forms.Label()
        Me.txtWidth = New System.Windows.Forms.TextBox()
        Me.lbWidth = New System.Windows.Forms.Label()
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.lbLength = New System.Windows.Forms.Label()
        Me.lbTotalCost = New System.Windows.Forms.Label()
        Me.txtTotalCost = New System.Windows.Forms.TextBox()
        Me.bntCalculate = New System.Windows.Forms.Button()
        Me.bntExit = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtCost)
        Me.Panel1.Controls.Add(Me.lbCost)
        Me.Panel1.Controls.Add(Me.txtWidth)
        Me.Panel1.Controls.Add(Me.lbWidth)
        Me.Panel1.Controls.Add(Me.txtLength)
        Me.Panel1.Controls.Add(Me.lbLength)
        Me.Panel1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.Location = New System.Drawing.Point(12, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(352, 97)
        Me.Panel1.TabIndex = 0
        '
        'txtCost
        '
        Me.txtCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCost.Location = New System.Drawing.Point(228, 51)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(56, 23)
        Me.txtCost.TabIndex = 5
        '
        'lbCost
        '
        Me.lbCost.AutoSize = True
        Me.lbCost.ForeColor = System.Drawing.Color.Black
        Me.lbCost.Location = New System.Drawing.Point(228, 33)
        Me.lbCost.Name = "lbCost"
        Me.lbCost.Size = New System.Drawing.Size(114, 15)
        Me.lbCost.TabIndex = 4
        Me.lbCost.Text = "Cost (per linear feet)"
        '
        'txtWidth
        '
        Me.txtWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtWidth.Location = New System.Drawing.Point(118, 51)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(56, 23)
        Me.txtWidth.TabIndex = 3
        '
        'lbWidth
        '
        Me.lbWidth.AutoSize = True
        Me.lbWidth.ForeColor = System.Drawing.Color.Black
        Me.lbWidth.Location = New System.Drawing.Point(118, 33)
        Me.lbWidth.Name = "lbWidth"
        Me.lbWidth.Size = New System.Drawing.Size(73, 15)
        Me.lbWidth.TabIndex = 2
        Me.lbWidth.Text = "Width (feet):"
        '
        'txtLength
        '
        Me.txtLength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLength.Location = New System.Drawing.Point(11, 51)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(56, 23)
        Me.txtLength.TabIndex = 1
        '
        'lbLength
        '
        Me.lbLength.AutoSize = True
        Me.lbLength.ForeColor = System.Drawing.Color.Black
        Me.lbLength.Location = New System.Drawing.Point(11, 33)
        Me.lbLength.Name = "lbLength"
        Me.lbLength.Size = New System.Drawing.Size(78, 15)
        Me.lbLength.TabIndex = 0
        Me.lbLength.Text = "Length (feet):"
        '
        'lbTotalCost
        '
        Me.lbTotalCost.AutoSize = True
        Me.lbTotalCost.ForeColor = System.Drawing.Color.Black
        Me.lbTotalCost.Location = New System.Drawing.Point(24, 164)
        Me.lbTotalCost.Name = "lbTotalCost"
        Me.lbTotalCost.Size = New System.Drawing.Size(62, 15)
        Me.lbTotalCost.TabIndex = 6
        Me.lbTotalCost.Text = "Total Cost:"
        '
        'txtTotalCost
        '
        Me.txtTotalCost.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalCost.Enabled = False
        Me.txtTotalCost.Location = New System.Drawing.Point(24, 182)
        Me.txtTotalCost.Multiline = True
        Me.txtTotalCost.Name = "txtTotalCost"
        Me.txtTotalCost.ReadOnly = True
        Me.txtTotalCost.Size = New System.Drawing.Size(119, 28)
        Me.txtTotalCost.TabIndex = 7
        '
        'bntCalculate
        '
        Me.bntCalculate.BackColor = System.Drawing.SystemColors.ControlDark
        Me.bntCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bntCalculate.Location = New System.Drawing.Point(179, 182)
        Me.bntCalculate.Name = "bntCalculate"
        Me.bntCalculate.Size = New System.Drawing.Size(91, 28)
        Me.bntCalculate.TabIndex = 8
        Me.bntCalculate.Text = "Calculate"
        Me.bntCalculate.UseVisualStyleBackColor = False
        '
        'bntExit
        '
        Me.bntExit.BackColor = System.Drawing.SystemColors.ControlDark
        Me.bntExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bntExit.Location = New System.Drawing.Point(274, 182)
        Me.bntExit.Name = "bntExit"
        Me.bntExit.Size = New System.Drawing.Size(90, 28)
        Me.bntExit.TabIndex = 9
        Me.bntExit.Text = "Exit"
        Me.bntExit.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 238)
        Me.Controls.Add(Me.bntExit)
        Me.Controls.Add(Me.bntCalculate)
        Me.Controls.Add(Me.txtTotalCost)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbTotalCost)
        Me.Name = "Form1"
        Me.Text = "Fencing Haven"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtCost As TextBox
    Friend WithEvents lbCost As Label
    Friend WithEvents txtWidth As TextBox
    Friend WithEvents lbWidth As Label
    Friend WithEvents txtLength As TextBox
    Friend WithEvents lbLength As Label
    Friend WithEvents lbTotalCost As Label
    Friend WithEvents txtTotalCost As TextBox
    Friend WithEvents bntCalculate As Button
    Friend WithEvents bntExit As Button
End Class
