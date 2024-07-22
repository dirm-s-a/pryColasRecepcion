Imports System.Drawing.Drawing2D
Public Class RoundedButton
    'Lapiz Y brocha Para La figura Deseada
    Private _solidbrushExt As SolidBrush ' Color De Fondo Exterior
    Private _solidbrushInt As SolidBrush ' Color De Fondo Interior
    Private _pen As Pen
    'Brocha Para El Texto
    Private _brushText As SolidBrush
    'Al Pasar El Puntero Sobre El Control
    Private _posColor As Color = Color.FromKnownColor(KnownColor.ControlDark)
    Private _posText As ContentAlignment
    'Instanciamos
    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'definimos El Tamaño Del Control
        Me.Width = 100
        Me.Height = 100
        Me.TextAling = ContentAlignment.MiddleCenter
        'damos el Color Al Control
        _pen = New Pen(BackColor)
        _solidbrushExt = New SolidBrush(Color.FromKnownColor(KnownColor.Control))
        'pintamos el
        _solidbrushInt = New SolidBrush(BackColor)
        _brushText = New SolidBrush(ForeColor)
        'asiganmos un cursor
        Me.Cursor = Cursors.Hand
        'color predertermiado
        Me.BackColor = Color.LightSteelBlue
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub
    'Creamos Una Propiedad Para Asignarle La Posicion Del Texto Dentro Del Control creado
    'agremamos la propiedad TextAling
    Public Property TextAling() As ContentAlignment
        Get
            Return _posText
        End Get
        Set(ByVal value As ContentAlignment)
            _posText = value
            Me.Invalidate()
        End Set
    End Property
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)
        'dibujamos El Circulo
        e.Graphics.FillRectangle(_solidbrushExt, 0, 0, ClientSize.Width, ClientSize.Height)
        e.Graphics.DrawEllipse(_pen, 0, 0, ClientSize.Width, ClientSize.Height)
        e.Graphics.FillEllipse(_solidbrushInt, 0, 0, ClientSize.Width, ClientSize.Height)
        'Para Que Considere Solo El Area Del Circulo
        Dim Zone As New GraphicsPath()
        Zone.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height)
        Me.Region = New Region(Zone)
        DibujarTexto(e.Graphics)
    End Sub

    Private Sub ButtonRedondo_BackColorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.BackColorChanged
        'Para Que Al Cambiar El Color Del Control Se Realizen Los Cambios
        _pen.Color = BackColor
        _solidbrushInt.Color = BackColor
    End Sub
    Public Sub DibujarTexto(ByVal oGraphics As Graphics)
        ' dibujar el título del control
        Dim oStrFormat As New StringFormat()
        'calculamos la posicion del texto
        Select Case _posText
            Case ContentAlignment.BottomCenter
                oStrFormat.Alignment = StringAlignment.Center
                oStrFormat.LineAlignment = StringAlignment.Far
            Case ContentAlignment.BottomLeft
                oStrFormat.Alignment = StringAlignment.Near
                oStrFormat.LineAlignment = StringAlignment.Far
            Case ContentAlignment.BottomRight
                oStrFormat.Alignment = StringAlignment.Far
                oStrFormat.LineAlignment = StringAlignment.Far
            Case ContentAlignment.MiddleCenter
                oStrFormat.Alignment = StringAlignment.Center
                oStrFormat.LineAlignment = StringAlignment.Center
            Case ContentAlignment.MiddleLeft
                oStrFormat.Alignment = StringAlignment.Near
                oStrFormat.LineAlignment = StringAlignment.Center
            Case ContentAlignment.MiddleRight
                oStrFormat.Alignment = StringAlignment.Far
                oStrFormat.LineAlignment = StringAlignment.Center
            Case ContentAlignment.TopCenter
                oStrFormat.Alignment = StringAlignment.Center
                oStrFormat.LineAlignment = StringAlignment.Near
            Case ContentAlignment.TopLeft
                oStrFormat.Alignment = StringAlignment.Near
                oStrFormat.LineAlignment = StringAlignment.Near
            Case ContentAlignment.TopRight
                oStrFormat.Alignment = StringAlignment.Far
                oStrFormat.LineAlignment = StringAlignment.Near
        End Select

        oStrFormat.HotkeyPrefix = Drawing.Text.HotkeyPrefix.Show
        'agregamos la posicion y el texto
        oGraphics.DrawString(Me.Text, Me.Font, New SolidBrush(Me.ForeColor), Me.ClientRectangle, oStrFormat)
    End Sub

    Private Sub ButtonRedondo_ForeColorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ForeColorChanged
        _brushText.Color = ForeColor
    End Sub

    Private Sub ButtonRedondo_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseEnter
        _pen.Color = _posColor
        _solidbrushInt.Color = _posColor
        Me.Invalidate()
    End Sub

    Private Sub ButtonRedondo_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseLeave
        _pen.Color = BackColor
        _solidbrushInt.Color = BackColor
        Me.Invalidate()
    End Sub
End Class
