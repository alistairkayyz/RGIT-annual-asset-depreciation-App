<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDepreciationApp
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
        Me.txtAssetCost = New System.Windows.Forms.TextBox()
        Me.txtSalvageValue = New System.Windows.Forms.TextBox()
        Me.cboUsefulLife = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnDDS = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lstDisplaySYD = New System.Windows.Forms.ListBox()
        Me.lstDisplayDDB = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtAssetCost
        '
        Me.txtAssetCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAssetCost.Location = New System.Drawing.Point(125, 34)
        Me.txtAssetCost.Name = "txtAssetCost"
        Me.txtAssetCost.Size = New System.Drawing.Size(167, 21)
        Me.txtAssetCost.TabIndex = 0
        '
        'txtSalvageValue
        '
        Me.txtSalvageValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalvageValue.Location = New System.Drawing.Point(125, 89)
        Me.txtSalvageValue.Name = "txtSalvageValue"
        Me.txtSalvageValue.Size = New System.Drawing.Size(167, 21)
        Me.txtSalvageValue.TabIndex = 1
        '
        'cboUsefulLife
        '
        Me.cboUsefulLife.BackColor = System.Drawing.SystemColors.Info
        Me.cboUsefulLife.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUsefulLife.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboUsefulLife.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUsefulLife.FormattingEnabled = True
        Me.cboUsefulLife.Location = New System.Drawing.Point(125, 144)
        Me.cboUsefulLife.Name = "cboUsefulLife"
        Me.cboUsefulLife.Size = New System.Drawing.Size(167, 23)
        Me.cboUsefulLife.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Asset Cost:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Salvage value:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(43, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Useful life:"
        '
        'btnDDS
        '
        Me.btnDDS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDDS.Location = New System.Drawing.Point(22, 234)
        Me.btnDDS.Name = "btnDDS"
        Me.btnDDS.Size = New System.Drawing.Size(156, 49)
        Me.btnDDS.TabIndex = 6
        Me.btnDDS.Text = "Display depreciation schedules"
        Me.btnDDS.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ImageKey = "(none)"
        Me.btnExit.Location = New System.Drawing.Point(217, 234)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 49)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lstDisplaySYD)
        Me.GroupBox1.Controls.Add(Me.lstDisplayDDB)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.GroupBox1.Location = New System.Drawing.Point(378, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(443, 305)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Depreciation schedules"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(244, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 15)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Sum-of-year's digits:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Double-declining balances:"
        '
        'lstDisplaySYD
        '
        Me.lstDisplaySYD.FormattingEnabled = True
        Me.lstDisplaySYD.Location = New System.Drawing.Point(244, 71)
        Me.lstDisplaySYD.Name = "lstDisplaySYD"
        Me.lstDisplaySYD.Size = New System.Drawing.Size(180, 186)
        Me.lstDisplaySYD.TabIndex = 1
        '
        'lstDisplayDDB
        '
        Me.lstDisplayDDB.FormattingEnabled = True
        Me.lstDisplayDDB.Location = New System.Drawing.Point(33, 71)
        Me.lstDisplayDDB.Name = "lstDisplayDDB"
        Me.lstDisplayDDB.Size = New System.Drawing.Size(180, 186)
        Me.lstDisplayDDB.TabIndex = 0
        '
        'frmDepreciationApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(849, 409)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDDS)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboUsefulLife)
        Me.Controls.Add(Me.txtSalvageValue)
        Me.Controls.Add(Me.txtAssetCost)
        Me.Name = "frmDepreciationApp"
        Me.Text = "RGIT Annual Asset Depreciation App"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtAssetCost As System.Windows.Forms.TextBox
    Friend WithEvents txtSalvageValue As System.Windows.Forms.TextBox
    Friend WithEvents cboUsefulLife As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnDDS As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lstDisplaySYD As System.Windows.Forms.ListBox
    Friend WithEvents lstDisplayDDB As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox

End Class
