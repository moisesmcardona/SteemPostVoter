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
        Me.identifier = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.weight = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pk = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.voter = New System.Windows.Forms.TextBox()
        CType(Me.weight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Post Identifier:"
        '
        'identifier
        '
        Me.identifier.Location = New System.Drawing.Point(12, 29)
        Me.identifier.Name = "identifier"
        Me.identifier.Size = New System.Drawing.Size(260, 20)
        Me.identifier.TabIndex = 1
        Me.identifier.Text = "@user/link"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Weight:"
        '
        'weight
        '
        Me.weight.Location = New System.Drawing.Point(12, 68)
        Me.weight.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.weight.Name = "weight"
        Me.weight.Size = New System.Drawing.Size(120, 20)
        Me.weight.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Private Posting Key:"
        '
        'pk
        '
        Me.pk.Location = New System.Drawing.Point(11, 146)
        Me.pk.Name = "pk"
        Me.pk.Size = New System.Drawing.Size(261, 20)
        Me.pk.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 172)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(260, 41)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Vote!"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Voter:"
        '
        'voter
        '
        Me.voter.Location = New System.Drawing.Point(11, 107)
        Me.voter.Name = "voter"
        Me.voter.Size = New System.Drawing.Size(261, 20)
        Me.voter.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 236)
        Me.Controls.Add(Me.voter)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pk)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.weight)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.identifier)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "STEEM Post Voter"
        CType(Me.weight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents identifier As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents weight As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents pk As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents voter As TextBox
End Class
