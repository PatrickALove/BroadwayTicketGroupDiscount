<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBroadwayTicketGroup
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
        Me.grpCostBySize = New System.Windows.Forms.GroupBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtNumOfTickets = New System.Windows.Forms.TextBox()
        Me.lblTicketPrompt = New System.Windows.Forms.Label()
        Me.cmbGroupSize = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblGroupPrompt = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.grpCostBySize.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpCostBySize
        '
        Me.grpCostBySize.Controls.Add(Me.btnClear)
        Me.grpCostBySize.Controls.Add(Me.txtNumOfTickets)
        Me.grpCostBySize.Controls.Add(Me.lblTicketPrompt)
        Me.grpCostBySize.Controls.Add(Me.cmbGroupSize)
        Me.grpCostBySize.Controls.Add(Me.Label5)
        Me.grpCostBySize.Controls.Add(Me.Label4)
        Me.grpCostBySize.Controls.Add(Me.Label3)
        Me.grpCostBySize.Controls.Add(Me.Label2)
        Me.grpCostBySize.Controls.Add(Me.lblGroupPrompt)
        Me.grpCostBySize.Controls.Add(Me.btnCalculate)
        Me.grpCostBySize.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCostBySize.ForeColor = System.Drawing.Color.Cyan
        Me.grpCostBySize.Location = New System.Drawing.Point(125, 86)
        Me.grpCostBySize.Name = "grpCostBySize"
        Me.grpCostBySize.Size = New System.Drawing.Size(541, 275)
        Me.grpCostBySize.TabIndex = 0
        Me.grpCostBySize.TabStop = False
        Me.grpCostBySize.Text = "Group Cost by Size"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Transparent
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Location = New System.Drawing.Point(385, 219)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(137, 39)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'txtNumOfTickets
        '
        Me.txtNumOfTickets.AcceptsReturn = True
        Me.txtNumOfTickets.Location = New System.Drawing.Point(87, 198)
        Me.txtNumOfTickets.Name = "txtNumOfTickets"
        Me.txtNumOfTickets.Size = New System.Drawing.Size(121, 36)
        Me.txtNumOfTickets.TabIndex = 12
        '
        'lblTicketPrompt
        '
        Me.lblTicketPrompt.AutoSize = True
        Me.lblTicketPrompt.Location = New System.Drawing.Point(29, 137)
        Me.lblTicketPrompt.Name = "lblTicketPrompt"
        Me.lblTicketPrompt.Size = New System.Drawing.Size(254, 58)
        Me.lblTicketPrompt.TabIndex = 11
        Me.lblTicketPrompt.Text = "How many tickets" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "are you purchasing?"
        '
        'cmbGroupSize
        '
        Me.cmbGroupSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGroupSize.FormattingEnabled = True
        Me.cmbGroupSize.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.cmbGroupSize.Items.AddRange(New Object() {"1-8", "9-12", "13-24", "25-99"})
        Me.cmbGroupSize.Location = New System.Drawing.Point(87, 90)
        Me.cmbGroupSize.Name = "cmbGroupSize"
        Me.cmbGroupSize.Size = New System.Drawing.Size(121, 37)
        Me.cmbGroupSize.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(369, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 29)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "$169/person"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(369, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 29)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "$199/person"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(369, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 29)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "$219/person"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(369, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 29)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "$249/person"
        '
        'lblGroupPrompt
        '
        Me.lblGroupPrompt.AutoSize = True
        Me.lblGroupPrompt.Location = New System.Drawing.Point(1, 54)
        Me.lblGroupPrompt.Name = "lblGroupPrompt"
        Me.lblGroupPrompt.Size = New System.Drawing.Size(311, 29)
        Me.lblGroupPrompt.TabIndex = 5
        Me.lblGroupPrompt.Text = "What is your group size?"
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.Transparent
        Me.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCalculate.Location = New System.Drawing.Point(242, 219)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(137, 39)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Book Ticket"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'frmBroadwayTicketGroup
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.grpCostBySize)
        Me.Name = "frmBroadwayTicketGroup"
        Me.Text = "Broadway Ticket Group Discount"
        Me.grpCostBySize.ResumeLayout(False)
        Me.grpCostBySize.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpCostBySize As GroupBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblGroupPrompt As Label
    Friend WithEvents lblTicketPrompt As Label
    Friend WithEvents cmbGroupSize As ComboBox
    Friend WithEvents txtNumOfTickets As TextBox
    Friend WithEvents btnClear As Button
End Class
