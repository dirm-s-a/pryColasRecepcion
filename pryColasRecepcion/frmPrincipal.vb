Imports Turnos.Entities
Imports Turnos.Business
Imports System.Drawing.Printing
Imports System.IO

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
        Dim BotonHeight As Double
        Dim CantBotones As Integer = mListColasRecepcion.Count
        If mListColasRecepcion IsNot Nothing AndAlso mListColasRecepcion.Count = 1 Then
            BotonHeight = 100
            pnlColas.Height = 110
            pnlColas.Top = (Me.Height / 2) - (pnlColas.Height / 2)
        Else
            BotonHeight = (pnlColas.Height / mListColasRecepcion.Count) - BotonEspaciado
        End If
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
            If mListColasRecepcion.Count = 1 Then
                btnCola.Top = (pnlColas.Height / 2) - (btnCola.Height / 2)
            Else
                btnCola.Top = (qBoton - 1) * (BotonHeight + BotonEspaciado)
            End If
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

        Dim RptFontBuenDia As Font = New Drawing.Font("Gill Sans MT", 12, FontStyle.Bold)
        Dim RptFont As Font = New Drawing.Font("Gill Sans MT", 10)
        Dim RptFontNumero As Font = New Drawing.Font("Gill Sans MT", 22)



        CurrentX = (ps.Width - e.Graphics.MeasureString("¡Hola! Tomá asiento y", RptFontBuenDia).Width) / 2
        e.Graphics.DrawString("¡Hola! Tomá asiento y", RptFontBuenDia, Brushes.Black, New Point(CurrentX, 0))

        CurrentX = (ps.Width - e.Graphics.MeasureString("aguardá a ser llamado.", RptFontBuenDia).Width) / 2
        e.Graphics.DrawString("aguardá a ser llamado.", RptFontBuenDia, Brushes.Black, New Point(CurrentX, 15))

        CurrentX = (ps.Width - e.Graphics.MeasureString("Podés descargar tus estudios", RptFont).Width) / 2
        e.Graphics.DrawString("Podés descargar tus estudios", RptFont, Brushes.Black, New Point(CurrentX, 35))

        CurrentX = (ps.Width - e.Graphics.MeasureString("desde la App DIM Salud.", RptFont).Width) / 2
        e.Graphics.DrawString("desde la App DIM Salud.", RptFont, Brushes.Black, New Point(CurrentX, 45))

        'RECUADRO CON EL NÚMERO
        CurrentX = (ps.Width - e.Graphics.MeasureString(mCadenaNumero, RptFontNumero).Width) / 2
        e.Graphics.DrawString(mCadenaNumero, RptFontNumero, Brushes.Black, New Point(CurrentX, 65))

        CurrentX = (ps.Width - e.Graphics.MeasureString("Por favor, prepará tu credencial y DNI", RptFont).Width) / 2
        e.Graphics.DrawString("Por favor, prepará tu credencial y DNI", RptFont, Brushes.Black, New Point(CurrentX, 120))

        CurrentX = (ps.Width - e.Graphics.MeasureString("para agilizar el proceso", RptFont).Width) / 2
        e.Graphics.DrawString("para agilizar el proceso", RptFont, Brushes.Black, New Point(CurrentX, 130))

        CurrentX = (ps.Width - e.Graphics.MeasureString("en la recepción.", RptFont).Width) / 2
        e.Graphics.DrawString("en la recepción.", RptFont, Brushes.Black, New Point(CurrentX, 140))



        'CurrentX = (ps.Width - e.Graphics.MeasureString("¡HOLA! TOMÁ ASIENTO Y", RptFontBuenDia).Width) / 2
        'e.Graphics.DrawString("¡HOLA! TOMÁ ASIENTO Y", RptFontBuenDia, Brushes.Black, New Point(CurrentX, 0))

        'CurrentX = (ps.Width - e.Graphics.MeasureString("AGUARDÁ A SER LLAMADO", RptFontBuenDia).Width) / 2
        'e.Graphics.DrawString("AGUARDÁ A SER LLAMADO", RptFontBuenDia, Brushes.Black, New Point(CurrentX, 15))

        'CurrentX = (ps.Width - e.Graphics.MeasureString("PODÉS DESCARGAR TUS ESTUDIOS", RptFont).Width) / 2
        'e.Graphics.DrawString("PODÉS DESCARGAR TUS ESTUDIOS", RptFont, Brushes.Black, New Point(CurrentX, 35))

        'CurrentX = (ps.Width - e.Graphics.MeasureString("DESDE LA APP YA QUE", RptFont).Width) / 2
        'e.Graphics.DrawString("DESDE LA APP YA QUE", RptFont, Brushes.Black, New Point(CurrentX, 45))

        'CurrentX = (ps.Width - e.Graphics.MeasureString("PERSONALMENTE PODRÍAMOS TENER", RptFont).Width) / 2
        'e.Graphics.DrawString("PERSONALMENTE PODRÍAMOS TENER", RptFont, Brushes.Black, New Point(CurrentX, 55))

        'CurrentX = (ps.Width - e.Graphics.MeasureString("1 HORA DE DEMORA", RptFont).Width) / 2
        'e.Graphics.DrawString("1 HORA DE DEMORA", RptFont, Brushes.Black, New Point(CurrentX, 65))

        ''RECUADRO CON EL NÚMERO
        'CurrentX = (ps.Width - e.Graphics.MeasureString(mCadenaNumero, RptFontNumero).Width) / 2
        'e.Graphics.DrawString(mCadenaNumero, RptFontNumero, Brushes.Black, New Point(CurrentX, 85))

        ''CurrentX = (ps.Width - e.Graphics.MeasureString("Solicite turnos 100% online", RptFont).Width) / 2
        ''e.Graphics.DrawString("Solicite turnos 100% online", RptFont, Brushes.Black, New Point(CurrentX, 140))
        ''CurrentX = (ps.Width - e.Graphics.MeasureString("en dim.com.ar", RptFont).Width) / 2
        ''e.Graphics.DrawString("en dim.com.ar", RptFont, Brushes.Black, New Point(CurrentX, 155))
        'CurrentX = (ps.Width - e.Graphics.MeasureString("POR FAVOR PREPARÁ TU CREDENCIAL Y DNI", RptFont).Width) / 2
        'e.Graphics.DrawString("POR FAVOR PREPARÁ TU CREDENCIAL Y DNI", RptFont, Brushes.Black, New Point(CurrentX, 140))

        'CurrentX = (ps.Width - e.Graphics.MeasureString("PARA AGILIZAR EL PROCESO", RptFont).Width) / 2
        'e.Graphics.DrawString("PARA AGILIZAR EL PROCESO", RptFont, Brushes.Black, New Point(CurrentX, 150))

        'CurrentX = (ps.Width - e.Graphics.MeasureString("EN LA RECEPCIÓN", RptFont).Width) / 2
        'e.Graphics.DrawString("EN LA RECEPCIÓN", RptFont, Brushes.Black, New Point(CurrentX, 160))


        'CurrentX = (ps.Width - e.Graphics.MeasureString("e imprimir sus estudios de laboratorio", RptFont).Width) / 2
        'e.Graphics.DrawString("e imprimir sus estudios de laboratorio", RptFont, Brushes.Black, New Point(CurrentX, 170))
        'CurrentX = (ps.Width - e.Graphics.MeasureString("en dim.com.ar", RptFont).Width) / 2
        'e.Graphics.DrawString("en dim.com.ar", RptFont, Brushes.Black, New Point(CurrentX, 185))

        'Cuadros y marcos del ticket
        e.Graphics.DrawRectangle(Pens.Black, New Rectangle(New Point(25, 63), New Size(New Point(ps.Width - 50, 45))))
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

    Private Sub frmPrincipal_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim img As Image = Image.FromFile(System.Configuration.ConfigurationManager.AppSettings("backgroundImagePath"))
        Dim rect As New Rectangle(0, 0, Me.Width, Me.Height)
        Me.BackgroundImageLayout = ImageLayout.Stretch
        e.Graphics.DrawImage(img, rect)
    End Sub

End Class
