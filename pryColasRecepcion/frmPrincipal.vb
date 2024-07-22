Imports Turnos.Entities
Imports Turnos.Business
Imports System.Drawing.Printing

Public Class frmPrincipal
    Private mCadenaNumero As String
    Private mListColasRecepcion As List(Of ColaRecepcion)
    Private mCadenaCon As String = String.Empty

    Private Sub Form1_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        pnlDni.Left = (Me.Width - pnlDni.Width) / 2
        pnlColas.Left = (Me.Width - pnlColas.Width) / 2
        btnVolver.Left = pnlColas.Left - btnVolver.Width - 10
    End Sub

    Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        mCadenaCon = System.Configuration.ConfigurationManager.AppSettings("ConexionString")

        For Each objControl As Control In Me.pnlTeclado.Controls
            If TypeOf (objControl) Is RoundedButton Then
                AddHandler objControl.Click, AddressOf BotonPresionado
            End If
        Next
        Call CargarColas()
    End Sub

    Private Sub BotonPresionado(sender As Object, e As EventArgs)
        Dim ctro As RoundedButton = CType(sender, RoundedButton)
        txtDNI.Text &= ctro.Text
        Call LimpiarBotones()
        ctro.ForeColor = Color.LightGreen
    End Sub

    Private Sub CargarColas()
        Dim entColaRecepcion As ColaRecepcion
        Dim objColaRecepcion As New ColaRecepcionComponent(mCadenaCon)
        Dim idRecepcion As Integer
        idRecepcion = CInt(System.Configuration.ConfigurationManager.AppSettings("idRecepcion"))

        mListColasRecepcion = objColaRecepcion.GetByIdrecepcion(idRecepcion).Where(Function(f) f.ACTIVA - Equals(True) And f.VISIBLE = Equals(True)).ToList

        Dim BotonesColumnas As Integer = 1
        Dim BotonEspaciado As Integer = 5

        Dim CantBotones As Integer = mListColasRecepcion.Count
        Dim BotonHeight As Double = (pnlColas.Height / mListColasRecepcion.Count) - BotonEspaciado
        Dim BotonWidth As Double = pnlColas.Width

        Dim qBoton As Integer = 0
        Dim ColBoton As Integer = 0

        For Each entColaRecepcion In mListColasRecepcion
            Dim btnCola As New Button
            qBoton += 1

            btnCola.Name = "btn" & Convert.ToString(entColaRecepcion.ID)
            btnCola.Text = entColaRecepcion.DESCRIPCION.ToUpper
            btnCola.Font = New Font("Gill Sans MT", 20, FontStyle.Regular)
            btnCola.ForeColor = Color.White
            btnCola.BackColor = Color.Gray

            btnCola.Width = BotonWidth
            btnCola.Height = BotonHeight
            btnCola.Top = (qBoton - 1) * (BotonHeight + BotonEspaciado)
            btnCola.Visible = True

            pnlColas.Controls.Add(btnCola)
            AddHandler btnCola.Click, AddressOf BotonColaPresionado
        Next
    End Sub

    Private Sub btnSiguiente_Click(sender As System.Object, e As System.EventArgs) Handles btnSiguiente.Click
        If txtDNI.Text.Length < 6 And txtDNI.Text.Length > 0 Then
            MsgBox("ATENCIÓN", "El número del DNI deber tener por lo menos 6 dígitos", MessageBoxButtons.OK, 5, , , , , True)
        Else
            pnlDni.Visible = False
            pnlColas.Visible = True
            btnVolver.Visible = True
        End If
    End Sub

    Private Sub LimpiarBotones()
        For Each objControl As Control In Me.pnlTeclado.Controls
            If TypeOf (objControl) Is RoundedButton Then
                objControl.ForeColor = Color.White
            End If
        Next
    End Sub

    Private Sub btnBorrar_Click(sender As System.Object, e As System.EventArgs) Handles btnBorrar.Click
        If txtDNI.Text.Length - 1 >= 0 Then
            txtDNI.Text = Strings.Left(txtDNI.Text, txtDNI.Text.Length - 1)
            Call LimpiarBotones()
        End If
    End Sub

    Private Sub BotonColaPresionado(sender As Object, e As EventArgs)
        Dim IdColaRecPac As Long
        Dim idColaRecepcion As Long
        Dim Boton As Button = CType(sender, Button)
        Dim objColaRecPac As New ColaRecPacComponent(mCadenaCon)
        Dim entColaRecPac As New ColaRecPac

        idColaRecepcion = Convert.ToInt64(Boton.Name.Replace("btn", ""))
        If idColaRecepcion = 8 Then
            MsgBox("ATENCIÓN", "Por favor, dirigirse al 3er piso para ser recepcionado. Muchas gracias.", MessageBoxButtons.OK, 7)
            Call LimpiarPantalla()
        Else
            entColaRecPac.BeginUpdate()
            entColaRecPac.NRODOCUMENTO = txtDNI.Text
            If Turnos.GlobalFunctions.Data.F_IsNullValue(txtDNI.Text) OrElse objColaRecPac.GetListByEnt(entColaRecPac).Count = 0 Then
                If objColaRecPac.Encolar(idColaRecepcion, txtDNI.Text, IdColaRecPac) Then
                    entColaRecPac = objColaRecPac.GetEntById(IdColaRecPac)
                    mCadenaNumero = mListColasRecepcion.Where(Function(f) f.ID = idColaRecepcion).ToList(0).PREFIJOTICKET
                    mCadenaNumero &= $"-{Strings.Left("0000", 4 - Convert.ToString(entColaRecPac.NUMEROCOLA).Length)}{Convert.ToString(entColaRecPac.NUMEROCOLA)}"
                    PrintDocument1.Print()
                    MsgBox("RETIRE EL TICKET", "Por favor retire el ticket y aguarde a ser llamado desde uno de los Leds de nuestro salón. Puede tomar asiento y esperar comodamente.", MessageBoxButtons.OK, 5)
                    Call LimpiarPantalla()
                Else
                    MsgBox("ATENCIÓN", "Ha ocurrido un error al encolarlo en el sistema. Por favor llame a un aistente que lo ayudará con el inconveniente", MessageBoxButtons.OK, 25, , , , , True)
                End If
            Else
                MsgBox("YA SE HA ENCOLADO", "Ya figuraba encolado en el sistema. Por favor aguarde a ser llamado desde uno de los Leds de nuestro salón. Puede tomar asiento y esperar comodamente.", MessageBoxButtons.OK, 5)
            End If


        End If

    End Sub

    Private Sub LimpiarPantalla()
        mCadenaNumero = String.Empty
        Call LimpiarBotones()
        txtDNI.Text = String.Empty
        pnlColas.Visible = False
        btnVolver.Visible = False
        pnlDni.Visible = True
    End Sub

    Private Sub btnVolver_Click(sender As System.Object, e As System.EventArgs) Handles btnVolver.Click
        Call LimpiarPantalla()
    End Sub

    Public Shared Sub MsgBox(ByVal nAsunto As String, ByVal nDetalle As String, ByVal nButtons As MessageBoxButtons, _
                                  Optional ByVal nTime As Double = 0, Optional ByVal ScrollBarType As Integer = ScrollBars.None, _
                                  Optional ByVal cmdAceptarText As String = "", Optional ByVal cmdCancelarText As String = "", _
                                  Optional ByVal XtraHeight As Boolean = False, Optional ByVal nEsAlerta As Boolean = False)
        Dim oMsgBox As New usrMsgBox

        oMsgBox.Asunto = nAsunto
        oMsgBox.Detalle = nDetalle
        oMsgBox.Buttons = nButtons
        oMsgBox.EsAlerta = nEsAlerta
        oMsgBox.Time = nTime
        If XtraHeight Then
            oMsgBox.Height += 40
            oMsgBox.txtDetalle.Height += 40
        End If
        If cmdCancelarText <> "" Then oMsgBox.cmdCancelarText = cmdCancelarText
        If cmdAceptarText <> "" Then oMsgBox.cmdAceptarText = cmdAceptarText
        oMsgBox.ScrollBarType = ScrollBarType
        oMsgBox.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim CurrentX As Integer
        Dim psPrinter As PaperSize = e.PageSettings.PaperSize

        'e.Graphics.PageUnit = GraphicsUnit.Millimeter

        Dim ps As New PaperSize("Custom", psPrinter.Width, 230)
        e.PageSettings.PaperSize = ps

        Dim RptFontBuenDia As Font = New Drawing.Font("Gill Sans MT", 14)
        Dim RptFont As Font = New Drawing.Font("Gill Sans MT", 12)
        Dim RptFontNumero As Font = New Drawing.Font("Gill Sans MT", 22)

        CurrentX = (ps.Width - e.Graphics.MeasureString(CadenaDia, RptFontBuenDia).Width) / 2
        e.Graphics.DrawString(CadenaDia, RptFontBuenDia, Brushes.Black, New Point(CurrentX, 0))
        CurrentX = (ps.Width - e.Graphics.MeasureString("POR FAVOR AGUARDE", RptFont).Width) / 2
        e.Graphics.DrawString("POR FAVOR AGUARDE", RptFont, Brushes.Black, New Point(CurrentX, 30))
        CurrentX = (ps.Width - e.Graphics.MeasureString("A SER LLAMADO", RptFont).Width) / 2
        e.Graphics.DrawString("A SER LLAMADO", RptFont, Brushes.Black, New Point(CurrentX, 50))
        CurrentX = (ps.Width - e.Graphics.MeasureString(mCadenaNumero, RptFontNumero).Width) / 2
        e.Graphics.DrawString(mCadenaNumero, RptFontNumero, Brushes.Black, New Point(CurrentX, 90))
        'CurrentX = (ps.Width - e.Graphics.MeasureString("Solicite turnos 100% online", RptFont).Width) / 2
        'e.Graphics.DrawString("Solicite turnos 100% online", RptFont, Brushes.Black, New Point(CurrentX, 140))
        'CurrentX = (ps.Width - e.Graphics.MeasureString("en dim.com.ar", RptFont).Width) / 2
        'e.Graphics.DrawString("en dim.com.ar", RptFont, Brushes.Black, New Point(CurrentX, 155))
        CurrentX = (ps.Width - e.Graphics.MeasureString("Tenga lista su credencial y DNI", RptFont).Width) / 2
        e.Graphics.DrawString("Tenga lista su credencial y DNI", RptFont, Brushes.Black, New Point(CurrentX, 140))
        CurrentX = (ps.Width - e.Graphics.MeasureString("en mano. Recuerde que puede tomar turnos", RptFont).Width) / 2
        e.Graphics.DrawString("en mano.", RptFont, Brushes.Black, New Point(CurrentX, 155))
        e.Graphics.DrawString("en mano. Recuerde que puede tomar turnos", RptFont, Brushes.Black, New Point(CurrentX, 155))
        CurrentX = (ps.Width - e.Graphics.MeasureString("e imprimir sus estudios de laboratorio", RptFont).Width) / 2
        e.Graphics.DrawString("e imprimir sus estudios de laboratorio", RptFont, Brushes.Black, New Point(CurrentX, 170))
        CurrentX = (ps.Width - e.Graphics.MeasureString("en dim.com.ar", RptFont).Width) / 2
        e.Graphics.DrawString("en dim.com.ar", RptFont, Brushes.Black, New Point(CurrentX, 185))

        'Cuadros y marcos del ticket
        e.Graphics.DrawRectangle(Pens.Black, New Rectangle(New Point(25, 88), New Size(New Point(ps.Width - 50, 45))))
    End Sub

    Public Function CadenaDia() As String
        If DatePart(DateInterval.Hour, Date.Now) < 12 Then
            Return "BUENOS DÍAS"
        ElseIf DatePart(DateInterval.Hour, Date.Now) < 19 Then
            Return "BUENAS TARDES"
        Else
            Return "BUENAS NOCHES"
        End If
    End Function
End Class
