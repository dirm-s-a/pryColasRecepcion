<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlDni = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.pnlTeclado = New System.Windows.Forms.Panel()
        Me.RoundedButton0 = New pryColasRecepcion.RoundedButton()
        Me.RoundedButton9 = New pryColasRecepcion.RoundedButton()
        Me.RoundedButton8 = New pryColasRecepcion.RoundedButton()
        Me.RoundedButton7 = New pryColasRecepcion.RoundedButton()
        Me.RoundedButton6 = New pryColasRecepcion.RoundedButton()
        Me.RoundedButton5 = New pryColasRecepcion.RoundedButton()
        Me.RoundedButton4 = New pryColasRecepcion.RoundedButton()
        Me.RoundedButton3 = New pryColasRecepcion.RoundedButton()
        Me.RoundedButton2 = New pryColasRecepcion.RoundedButton()
        Me.RoundedButton1 = New pryColasRecepcion.RoundedButton()
        Me.pnlColas = New System.Windows.Forms.Panel()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.pnlDni.SuspendLayout()
        Me.pnlTeclado.SuspendLayout()
        Me.pnlColas.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(182, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 23)
        Me.Label2.TabIndex = 14
        '
        'pnlDni
        '
        Me.pnlDni.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlDni.Controls.Add(Me.Label4)
        Me.pnlDni.Controls.Add(Me.Label3)
        Me.pnlDni.Controls.Add(Me.btnSiguiente)
        Me.pnlDni.Controls.Add(Me.Label1)
        Me.pnlDni.Controls.Add(Me.btnBorrar)
        Me.pnlDni.Controls.Add(Me.txtDNI)
        Me.pnlDni.Controls.Add(Me.pnlTeclado)
        Me.pnlDni.Location = New System.Drawing.Point(295, 90)
        Me.pnlDni.Name = "pnlDni"
        Me.pnlDni.Size = New System.Drawing.Size(654, 468)
        Me.pnlDni.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Gill Sans MT", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(406, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(178, 48)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Bienvenido" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Gill Sans MT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(396, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(201, 30)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "y presione ""Siguiente"""
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSiguiente.BackColor = System.Drawing.Color.Green
        Me.btnSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSiguiente.Font = New System.Drawing.Font("Gill Sans MT", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente.ForeColor = System.Drawing.Color.White
        Me.btnSiguiente.Location = New System.Drawing.Point(348, 246)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(291, 53)
        Me.btnSiguiente.TabIndex = 20
        Me.btnSiguiente.Text = "SIGUIENTE"
        Me.btnSiguiente.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gill Sans MT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(388, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 30)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Ingrese su Nro. de DNI"
        '
        'btnBorrar
        '
        Me.btnBorrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBorrar.BackColor = System.Drawing.Color.Red
        Me.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBorrar.Font = New System.Drawing.Font("Gill Sans MT", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrar.ForeColor = System.Drawing.Color.White
        Me.btnBorrar.Location = New System.Drawing.Point(16, 400)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(291, 53)
        Me.btnBorrar.TabIndex = 18
        Me.btnBorrar.Text = "Borra último Nro."
        Me.btnBorrar.UseVisualStyleBackColor = False
        '
        'txtDNI
        '
        Me.txtDNI.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtDNI.BackColor = System.Drawing.Color.White
        Me.txtDNI.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDNI.Location = New System.Drawing.Point(372, 180)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(237, 37)
        Me.txtDNI.TabIndex = 16
        Me.txtDNI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'pnlTeclado
        '
        Me.pnlTeclado.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlTeclado.BackColor = System.Drawing.Color.Silver
        Me.pnlTeclado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTeclado.Controls.Add(Me.RoundedButton0)
        Me.pnlTeclado.Controls.Add(Me.RoundedButton9)
        Me.pnlTeclado.Controls.Add(Me.RoundedButton8)
        Me.pnlTeclado.Controls.Add(Me.RoundedButton7)
        Me.pnlTeclado.Controls.Add(Me.RoundedButton6)
        Me.pnlTeclado.Controls.Add(Me.RoundedButton5)
        Me.pnlTeclado.Controls.Add(Me.RoundedButton4)
        Me.pnlTeclado.Controls.Add(Me.RoundedButton3)
        Me.pnlTeclado.Controls.Add(Me.RoundedButton2)
        Me.pnlTeclado.Controls.Add(Me.RoundedButton1)
        Me.pnlTeclado.Location = New System.Drawing.Point(12, 16)
        Me.pnlTeclado.Name = "pnlTeclado"
        Me.pnlTeclado.Size = New System.Drawing.Size(302, 382)
        Me.pnlTeclado.TabIndex = 17
        '
        'RoundedButton0
        '
        Me.RoundedButton0.BackColor = System.Drawing.Color.Gray
        Me.RoundedButton0.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RoundedButton0.Font = New System.Drawing.Font("Gill Sans MT", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoundedButton0.ForeColor = System.Drawing.Color.White
        Me.RoundedButton0.Location = New System.Drawing.Point(102, 288)
        Me.RoundedButton0.Name = "RoundedButton0"
        Me.RoundedButton0.Size = New System.Drawing.Size(93, 89)
        Me.RoundedButton0.TabIndex = 30
        Me.RoundedButton0.Text = "0"
        Me.RoundedButton0.TextAling = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RoundedButton9
        '
        Me.RoundedButton9.BackColor = System.Drawing.Color.Gray
        Me.RoundedButton9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RoundedButton9.Font = New System.Drawing.Font("Gill Sans MT", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoundedButton9.ForeColor = System.Drawing.Color.White
        Me.RoundedButton9.Location = New System.Drawing.Point(201, 3)
        Me.RoundedButton9.Name = "RoundedButton9"
        Me.RoundedButton9.Size = New System.Drawing.Size(93, 89)
        Me.RoundedButton9.TabIndex = 29
        Me.RoundedButton9.Text = "9"
        Me.RoundedButton9.TextAling = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RoundedButton8
        '
        Me.RoundedButton8.BackColor = System.Drawing.Color.Gray
        Me.RoundedButton8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RoundedButton8.Font = New System.Drawing.Font("Gill Sans MT", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoundedButton8.ForeColor = System.Drawing.Color.White
        Me.RoundedButton8.Location = New System.Drawing.Point(102, 3)
        Me.RoundedButton8.Name = "RoundedButton8"
        Me.RoundedButton8.Size = New System.Drawing.Size(93, 89)
        Me.RoundedButton8.TabIndex = 28
        Me.RoundedButton8.Text = "8"
        Me.RoundedButton8.TextAling = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RoundedButton7
        '
        Me.RoundedButton7.BackColor = System.Drawing.Color.Gray
        Me.RoundedButton7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RoundedButton7.Font = New System.Drawing.Font("Gill Sans MT", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoundedButton7.ForeColor = System.Drawing.Color.White
        Me.RoundedButton7.Location = New System.Drawing.Point(3, 3)
        Me.RoundedButton7.Name = "RoundedButton7"
        Me.RoundedButton7.Size = New System.Drawing.Size(93, 89)
        Me.RoundedButton7.TabIndex = 27
        Me.RoundedButton7.Text = "7"
        Me.RoundedButton7.TextAling = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RoundedButton6
        '
        Me.RoundedButton6.BackColor = System.Drawing.Color.Gray
        Me.RoundedButton6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RoundedButton6.Font = New System.Drawing.Font("Gill Sans MT", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoundedButton6.ForeColor = System.Drawing.Color.White
        Me.RoundedButton6.Location = New System.Drawing.Point(201, 98)
        Me.RoundedButton6.Name = "RoundedButton6"
        Me.RoundedButton6.Size = New System.Drawing.Size(93, 89)
        Me.RoundedButton6.TabIndex = 26
        Me.RoundedButton6.Text = "6"
        Me.RoundedButton6.TextAling = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RoundedButton5
        '
        Me.RoundedButton5.BackColor = System.Drawing.Color.Gray
        Me.RoundedButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RoundedButton5.Font = New System.Drawing.Font("Gill Sans MT", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoundedButton5.ForeColor = System.Drawing.Color.White
        Me.RoundedButton5.Location = New System.Drawing.Point(102, 98)
        Me.RoundedButton5.Name = "RoundedButton5"
        Me.RoundedButton5.Size = New System.Drawing.Size(93, 89)
        Me.RoundedButton5.TabIndex = 25
        Me.RoundedButton5.Text = "5"
        Me.RoundedButton5.TextAling = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RoundedButton4
        '
        Me.RoundedButton4.BackColor = System.Drawing.Color.Gray
        Me.RoundedButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RoundedButton4.Font = New System.Drawing.Font("Gill Sans MT", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoundedButton4.ForeColor = System.Drawing.Color.White
        Me.RoundedButton4.Location = New System.Drawing.Point(3, 98)
        Me.RoundedButton4.Name = "RoundedButton4"
        Me.RoundedButton4.Size = New System.Drawing.Size(93, 89)
        Me.RoundedButton4.TabIndex = 24
        Me.RoundedButton4.Text = "4"
        Me.RoundedButton4.TextAling = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RoundedButton3
        '
        Me.RoundedButton3.BackColor = System.Drawing.Color.Gray
        Me.RoundedButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RoundedButton3.Font = New System.Drawing.Font("Gill Sans MT", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoundedButton3.ForeColor = System.Drawing.Color.White
        Me.RoundedButton3.Location = New System.Drawing.Point(201, 193)
        Me.RoundedButton3.Name = "RoundedButton3"
        Me.RoundedButton3.Size = New System.Drawing.Size(93, 89)
        Me.RoundedButton3.TabIndex = 23
        Me.RoundedButton3.Text = "3"
        Me.RoundedButton3.TextAling = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RoundedButton2
        '
        Me.RoundedButton2.BackColor = System.Drawing.Color.Gray
        Me.RoundedButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RoundedButton2.Font = New System.Drawing.Font("Gill Sans MT", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoundedButton2.ForeColor = System.Drawing.Color.White
        Me.RoundedButton2.Location = New System.Drawing.Point(102, 193)
        Me.RoundedButton2.Name = "RoundedButton2"
        Me.RoundedButton2.Size = New System.Drawing.Size(93, 89)
        Me.RoundedButton2.TabIndex = 22
        Me.RoundedButton2.Text = "2"
        Me.RoundedButton2.TextAling = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RoundedButton1
        '
        Me.RoundedButton1.BackColor = System.Drawing.Color.Gray
        Me.RoundedButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RoundedButton1.Font = New System.Drawing.Font("Gill Sans MT", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoundedButton1.ForeColor = System.Drawing.Color.White
        Me.RoundedButton1.Location = New System.Drawing.Point(3, 193)
        Me.RoundedButton1.Name = "RoundedButton1"
        Me.RoundedButton1.Size = New System.Drawing.Size(93, 89)
        Me.RoundedButton1.TabIndex = 21
        Me.RoundedButton1.Text = "1"
        Me.RoundedButton1.TextAling = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlColas
        '
        Me.pnlColas.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlColas.Controls.Add(Me.Label2)
        Me.pnlColas.Location = New System.Drawing.Point(245, 90)
        Me.pnlColas.Name = "pnlColas"
        Me.pnlColas.Size = New System.Drawing.Size(751, 468)
        Me.pnlColas.TabIndex = 17
        Me.pnlColas.Visible = False
        '
        'btnVolver
        '
        Me.btnVolver.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnVolver.BackColor = System.Drawing.Color.Red
        Me.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnVolver.Font = New System.Drawing.Font("Gill Sans MT", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.Color.White
        Me.btnVolver.Location = New System.Drawing.Point(103, 515)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(136, 43)
        Me.btnVolver.TabIndex = 19
        Me.btnVolver.Text = "Cancelar"
        Me.btnVolver.UseVisualStyleBackColor = False
        Me.btnVolver.Visible = False
        '
        'PrintDocument1
        '
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1266, 642)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.pnlDni)
        Me.Controls.Add(Me.pnlColas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPrincipal"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlDni.ResumeLayout(False)
        Me.pnlDni.PerformLayout()
        Me.pnlTeclado.ResumeLayout(False)
        Me.pnlColas.ResumeLayout(False)
        Me.pnlColas.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pnlDni As System.Windows.Forms.Panel
    Friend WithEvents btnSiguiente As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents txtDNI As System.Windows.Forms.TextBox
    Friend WithEvents pnlTeclado As System.Windows.Forms.Panel
    Friend WithEvents RoundedButton0 As pryColasRecepcion.RoundedButton
    Friend WithEvents RoundedButton9 As pryColasRecepcion.RoundedButton
    Friend WithEvents RoundedButton8 As pryColasRecepcion.RoundedButton
    Friend WithEvents RoundedButton7 As pryColasRecepcion.RoundedButton
    Friend WithEvents RoundedButton6 As pryColasRecepcion.RoundedButton
    Friend WithEvents RoundedButton5 As pryColasRecepcion.RoundedButton
    Friend WithEvents RoundedButton4 As pryColasRecepcion.RoundedButton
    Friend WithEvents RoundedButton3 As pryColasRecepcion.RoundedButton
    Friend WithEvents RoundedButton2 As pryColasRecepcion.RoundedButton
    Friend WithEvents RoundedButton1 As pryColasRecepcion.RoundedButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents pnlColas As System.Windows.Forms.Panel
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
