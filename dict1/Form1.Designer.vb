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
        Me.decipher_btn = New System.Windows.Forms.Button()
        Me.txtbox2 = New System.Windows.Forms.TextBox()
        Me.cipher_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'decipher_btn
        '
        Me.decipher_btn.Location = New System.Drawing.Point(473, 136)
        Me.decipher_btn.Margin = New System.Windows.Forms.Padding(6)
        Me.decipher_btn.Name = "decipher_btn"
        Me.decipher_btn.Size = New System.Drawing.Size(150, 44)
        Me.decipher_btn.TabIndex = 0
        Me.decipher_btn.Text = "DeCipher"
        Me.decipher_btn.UseVisualStyleBackColor = True
        '
        'txtbox2
        '
        Me.txtbox2.Location = New System.Drawing.Point(71, 42)
        Me.txtbox2.Margin = New System.Windows.Forms.Padding(6)
        Me.txtbox2.Name = "txtbox2"
        Me.txtbox2.Size = New System.Drawing.Size(702, 31)
        Me.txtbox2.TabIndex = 1
        '
        'cipher_btn
        '
        Me.cipher_btn.Location = New System.Drawing.Point(256, 136)
        Me.cipher_btn.Margin = New System.Windows.Forms.Padding(6)
        Me.cipher_btn.Name = "cipher_btn"
        Me.cipher_btn.Size = New System.Drawing.Size(150, 44)
        Me.cipher_btn.TabIndex = 0
        Me.cipher_btn.Text = "Cipher"
        Me.cipher_btn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 506)
        Me.Controls.Add(Me.txtbox2)
        Me.Controls.Add(Me.cipher_btn)
        Me.Controls.Add(Me.decipher_btn)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Form1"
        Me.Text = "CIPHER"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents decipher_btn As Button
    Friend WithEvents txtbox2 As TextBox
    Friend WithEvents cipher_btn As Button
End Class
