<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrMsgBox
    Inherits System.Windows.Forms.Form

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.timerMsg = New System.Windows.Forms.Timer(Me.components)
        Me.pnlAsunto = New System.Windows.Forms.Panel()
        Me.lblAsunto = New System.Windows.Forms.Label()
        Me.txtDetalle = New System.Windows.Forms.RichTextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.pnlAsunto.SuspendLayout()
        Me.SuspendLayout()
        '
        'timerMsg
        '
        '
        'pnlAsunto
        '
        Me.pnlAsunto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAsunto.Controls.Add(Me.lblAsunto)
        Me.pnlAsunto.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAsunto.Location = New System.Drawing.Point(0, 0)
        Me.pnlAsunto.Name = "pnlAsunto"
        Me.pnlAsunto.Size = New System.Drawing.Size(312, 32)
        Me.pnlAsunto.TabIndex = 5
        '
        'lblAsunto
        '
        Me.lblAsunto.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAsunto.AutoSize = True
        Me.lblAsunto.Font = New System.Drawing.Font("Gill Sans MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAsunto.Location = New System.Drawing.Point(51, 2)
        Me.lblAsunto.Name = "lblAsunto"
        Me.lblAsunto.Size = New System.Drawing.Size(209, 27)
        Me.lblAsunto.TabIndex = 1
        Me.lblAsunto.Text = "ASUNTO DEL MENSAJE"
        '
        'txtDetalle
        '
        Me.txtDetalle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtDetalle.BackColor = System.Drawing.SystemColors.Control
        Me.txtDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDetalle.Font = New System.Drawing.Font("Gill Sans MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetalle.Location = New System.Drawing.Point(1, 33)
        Me.txtDetalle.Name = "txtDetalle"
        Me.txtDetalle.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txtDetalle.Size = New System.Drawing.Size(311, 148)
        Me.txtDetalle.TabIndex = 6
        Me.txtDetalle.Text = ""
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Red
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCancelar.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(156, 214)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(157, 36)
        Me.btnCancelar.TabIndex = 26
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.Green
        Me.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAceptar.Font = New System.Drawing.Font("Gill Sans MT", 12.0!)
        Me.btnAceptar.ForeColor = System.Drawing.Color.White
        Me.btnAceptar.Location = New System.Drawing.Point(0, 214)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(157, 36)
        Me.btnAceptar.TabIndex = 25
        Me.btnAceptar.Text = "ACEPTAR"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'lblTimer
        '
        Me.lblTimer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTimer.AutoSize = True
        Me.lblTimer.Font = New System.Drawing.Font("Gill Sans MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.Location = New System.Drawing.Point(113, 184)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(80, 27)
        Me.lblTimer.TabIndex = 24
        Me.lblTimer.Text = "00:00:00"
        '
        'usrMsgBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 250)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.txtDetalle)
        Me.Controls.Add(Me.pnlAsunto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "usrMsgBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlAsunto.ResumeLayout(False)
        Me.pnlAsunto.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents timerMsg As System.Windows.Forms.Timer
    Friend WithEvents pnlAsunto As System.Windows.Forms.Panel
    Friend WithEvents lblAsunto As System.Windows.Forms.Label
    Friend WithEvents txtDetalle As System.Windows.Forms.RichTextBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents lblTimer As System.Windows.Forms.Label

End Class
