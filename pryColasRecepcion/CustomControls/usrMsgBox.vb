Public Class usrMsgBox
#Region "Atributos"
    Private mAsunto As String
    Private mDetalle As String
    Private mTime As Double
    Private mflgEsAlerta As Boolean

    Private mButtons As MessageBoxButtons

    Private mElapsedTime As Double
#End Region

#Region "Propiedades"
    Public WriteOnly Property EsAlerta As Boolean
        Set(value As Boolean)
            mflgEsAlerta = value
        End Set
    End Property
    Public WriteOnly Property cmdAceptarText As String
        Set(value As String)
            btnAceptar.Text = value
        End Set
    End Property
    Public WriteOnly Property cmdCancelarText As String
        Set(value As String)
            btnCancelar.Text = value
        End Set
    End Property
    Public WriteOnly Property ScrollBarType As Integer
        Set(ByVal value As Integer)
            txtDetalle.ScrollBars = CType(value, ScrollBars)
        End Set
    End Property
    Public WriteOnly Property Asunto As String
        Set(ByVal value As String)
            mAsunto = value
        End Set
    End Property
    Public WriteOnly Property Detalle As String
        Set(ByVal value As String)
            mDetalle = value
        End Set
    End Property
    Public WriteOnly Property Time As Double
        Set(ByVal value As Double)
            mTime = value
        End Set
    End Property

    Public WriteOnly Property Buttons As MessageBoxButtons
        Set(ByVal value As MessageBoxButtons)
            mButtons = value
        End Set
    End Property
#End Region

#Region "Eventos Formulario"

    Private Sub MsgBox_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim tSpan As TimeSpan

        btnAceptar.Focus()
        lblAsunto.Text = mAsunto
        lblAsunto.Left = (Me.Width - lblAsunto.Width) / 2
        txtDetalle.Text = mDetalle

        If mTime > 0 Then
            lblTimer.Visible = True
            timerMsg.Enabled = True
            timerMsg.Interval = 1000

            tSpan = TimeSpan.FromSeconds(mTime)
            lblTimer.Text = tSpan.ToString
        Else
            lblTimer.Visible = False
        End If

        If mflgEsAlerta Then
            pnlAsunto.BackColor = Color.Red
            lblAsunto.ForeColor = Color.White
        End If

        Select Case mButtons
            Case MessageBoxButtons.OK
                btnAceptar.Visible = True
                btnAceptar.Width = Me.Width
                btnCancelar.Visible = False
            Case MessageBoxButtons.OKCancel
                btnAceptar.Visible = True
                btnCancelar.Visible = True
            Case MessageBoxButtons.YesNo
                btnAceptar.Visible = True
                btnCancelar.Visible = True
        End Select

    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub timerMsg_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles timerMsg.Tick
        Dim tSpan As TimeSpan

        mElapsedTime = mElapsedTime + 1
        If mTime > mElapsedTime Then
            tSpan = TimeSpan.FromSeconds(mTime - mElapsedTime)
            lblTimer.Text = tSpan.ToString
            Application.DoEvents()
        Else
            Me.DialogResult = DialogResult.Cancel
        End If
    End Sub
#End Region

End Class
