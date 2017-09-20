Imports System
Imports System.ComponentModel
Imports System.IO.Ports
Imports System.Runtime.InteropServices

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Key = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modifiers = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KeyCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewConfigToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenConfigToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveConfigToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveConfigAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SetEnableKeyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Serial port:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(12, 47)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(140, 46)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Refresh"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"300", "600", "1200", "4800", "9600", "19200", "38400", "57600", "748800", "115200", "230400", "250000"})
        Me.ComboBox2.Location = New System.Drawing.Point(222, 47)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(219, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Baudrate:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 115)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(121, 20)
        Me.TextBox1.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Code received:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(139, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Key shortcut:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(142, 115)
        Me.TextBox2.MaxLength = 1
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(121, 20)
        Me.TextBox2.TabIndex = 7
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(269, 113)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Record keys"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(350, 112)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(33, 23)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "+"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Code, Me.Key, Me.Modifiers, Me.KeyCode})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 150)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(410, 294)
        Me.DataGridView1.TabIndex = 11
        '
        'Code
        '
        Me.Code.HeaderText = "IR Code"
        Me.Code.Name = "Code"
        Me.Code.ReadOnly = True
        '
        'Key
        '
        Me.Key.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Key.HeaderText = "Key Combination"
        Me.Key.Name = "Key"
        Me.Key.ReadOnly = True
        '
        'Modifiers
        '
        Me.Modifiers.HeaderText = "Modifiers"
        Me.Modifiers.Name = "Modifiers"
        Me.Modifiers.ReadOnly = True
        Me.Modifiers.Visible = False
        '
        'KeyCode
        '
        Me.KeyCode.HeaderText = "Key Code"
        Me.KeyCode.Name = "KeyCode"
        Me.KeyCode.ReadOnly = True
        Me.KeyCode.Visible = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(389, 112)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(33, 23)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "-"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "IR Receiver"
        Me.NotifyIcon1.Visible = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(434, 24)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewConfigToolStripMenuItem, Me.OpenConfigToolStripMenuItem, Me.SaveConfigToolStripMenuItem, Me.SaveConfigAsToolStripMenuItem, Me.ToolStripMenuItem1, Me.SetEnableKeyToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewConfigToolStripMenuItem
        '
        Me.NewConfigToolStripMenuItem.Name = "NewConfigToolStripMenuItem"
        Me.NewConfigToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.NewConfigToolStripMenuItem.Text = "New config"
        '
        'OpenConfigToolStripMenuItem
        '
        Me.OpenConfigToolStripMenuItem.Name = "OpenConfigToolStripMenuItem"
        Me.OpenConfigToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.OpenConfigToolStripMenuItem.Text = "Open config..."
        '
        'SaveConfigToolStripMenuItem
        '
        Me.SaveConfigToolStripMenuItem.Name = "SaveConfigToolStripMenuItem"
        Me.SaveConfigToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.SaveConfigToolStripMenuItem.Text = "Save config"
        '
        'SaveConfigAsToolStripMenuItem
        '
        Me.SaveConfigAsToolStripMenuItem.Name = "SaveConfigAsToolStripMenuItem"
        Me.SaveConfigAsToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.SaveConfigAsToolStripMenuItem.Text = "Save config As..."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(157, 6)
        '
        'SetEnableKeyToolStripMenuItem
        '
        Me.SetEnableKeyToolStripMenuItem.Name = "SetEnableKeyToolStripMenuItem"
        Me.SetEnableKeyToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.SetEnableKeyToolStripMenuItem.Text = "Set 'Enable' key"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "cnf"
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "Configuration file (*.cnf)|*.cnf"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "cnf"
        Me.SaveFileDialog1.Filter = "Configuration file  (*.cnf)|*.cnf"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(12, 75)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(241, 17)
        Me.CheckBox2.TabIndex = 16
        Me.CheckBox2.Text = "Iniciar minimizado en el área de notificaciones"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(372, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "- or -"
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(350, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 22)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "None"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CheckBox1
        '
        Me.CheckBox1.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(350, 47)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(72, 24)
        Me.CheckBox1.TabIndex = 19
        Me.CheckBox1.Text = "Enabled"
        Me.CheckBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 456)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(450, 495)
        Me.MinimumSize = New System.Drawing.Size(450, 495)
        Me.Name = "Main"
        Me.Text = "IR Universal Receiver"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Const KEYEVENTF_KEYDOWN As UInteger = &H0
    Private Const KEYEVENTF_KEYUP As UInteger = &H2

    <DllImport("user32.dll", EntryPoint:="keybd_event")>
    Public Shared Sub keybd_event(ByVal bVk As Byte, ByVal bScan As Byte, ByVal dwFlags As UInteger, ByVal dwExtraInfo As UInteger)
    End Sub

    ' Variables globales
    Dim com1 As IO.Ports.SerialPort = Nothing   ' Puerto de comunicación serial
    Dim indata As String                        ' Datos recibidos por puerto COM
    Dim savedModifiers As Long = 0              ' Modificadores de la última combinación
    Dim savedKeyCode As String = ""             ' Código de la última tecla pulsada
    ' Alamcena si la configuración del mando a distancia ha cambiado respecto al archivo [file]
    Dim hasChanged As Boolean = False

    ' Objetos con eventos (alfbéticamente)
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Code As DataGridViewTextBoxColumn
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Key As DataGridViewTextBoxColumn
    Friend WithEvents KeyCode As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Modifiers As DataGridViewTextBoxColumn
    Friend WithEvents NewConfigToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents OpenConfigToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveConfigAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveConfigToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents SetEnableKeyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator

    ' Carga del formulario
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Iniciar minimizado en el área de notificación
        CheckBox2.Checked = My.Settings.minimized
        If (CheckBox2.Checked) Then
            ' Minimizar
            Me.WindowState = FormWindowState.Minimized
        End If

        ' Cargar tecla de 'Enable' desde configuración
        Label6.Text = My.Settings.enableKey

        ' Configurar el icono de la barra de notificaciones
        NotifyIcon1.Icon = Me.Icon

        ' Recargar lista de puertos COM disponibles
        RefreshPorts()
        ' Comprobar si el puerto guardado en configuración sigue estando disponible
        Dim portIndex = ComboBox1.FindStringExact(My.Settings.port)
        If portIndex >= 0 Then
            ComboBox1.SelectedIndex = portIndex
            ' Ajustar la velocidad de sincronización en la comunicación
            Dim baudIndex = ComboBox2.FindStringExact(My.Settings.baud)
            If baudIndex >= 0 Then
                ComboBox2.SelectedIndex = baudIndex
            End If
        End If

        ' Abrir archivo de configuración de mando a distancia
        If Len(My.Settings.config) <> 0 Then
            OpenConfigFile(My.Settings.config)
        End If
    End Sub

    ' Minimizar al área de notificaciones en lugar de la barra de tareas
    Private Sub Main_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            ShowInTaskbar = False
        End If
    End Sub

    ' Comprobar cambios sin guardar al cerrar el formulario
    Private Sub Main_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If hasChanged Then
            ' ¿Desearía descartar los cambios?
            discardChanges()
        End If
    End Sub

    ' Recarga la lista de puertos COM disponibles
    Private Sub RefreshPorts()
        ' Get a list of serial port names.
        Dim ports As String() = SerialPort.GetPortNames()
        Dim port As String
        ComboBox1.Items.Clear()
        For Each port In ports
            ComboBox1.Items.Add(port)
        Next port
    End Sub

    ' Invoca la recarga de la lista de puertos COM disponibñes
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RefreshPorts()
    End Sub

    ' Abre comunicación a través del puerto COM seleccionado
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim returnStr As String = ""
        Try
            ' Apertura del puerto
            com1 = My.Computer.Ports.OpenSerialPort(ComboBox1.Text)
            ' Selección del tiempo máximo de espera
            com1.ReadTimeout = 10000
            ' Tratamiento de interrupción por llegada de datos
            AddHandler com1.DataReceived, AddressOf DataReceivedHandler
            ' Guardar configuración en registro
            My.Settings.port = ComboBox1.Text
        Catch ex As UnauthorizedAccessException
            MsgBox("Port " + ComboBox1.Text + " currently in use by another process.", MsgBoxStyle.Critical, "Cannot open the Port")
        End Try
    End Sub

    ' Tratamiento de la interrupción por llegada de datos seriales
    Private Sub DataReceivedHandler(sender As Object, e As SerialDataReceivedEventArgs)
        Dim sp As SerialPort = CType(sender, SerialPort)
        ' Si se ha tratado la anterior interrupción
        ' Preveción de fallos en concurrencia
        If indata = "" Then
            ' Guardar el valor recbido
            indata = sp.ReadExisting().ToUpper()
        End If
    End Sub

    ' Ajusta el puerto COM a la velocidad de transferencia selecionada
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Try
            ' Change the port baud rate
            com1.BaudRate = ComboBox2.Text
            ' Guardar configuración en registro
            My.Settings.baud = ComboBox2.Text
        Catch ex As NullReferenceException
            MsgBox("Port " + ComboBox1.Text + " currently in use by another process.", MsgBoxStyle.Critical, "Cannot open the Port")
        End Try
    End Sub

    ' Reproducir pulsación de teclado guardada
    Private Sub SendKeyCombo(i As Integer)
        ' Comprobar si es necesario pulsar algún modificador (CTRL, ALT, SHIFT)
        If DataGridView1.Rows.Item(i).Cells.Item("Modifiers").Value <> 0 Then
            Dim val As Integer = Convert.ToInt32(DataGridView1.Rows.Item(i).Cells.Item("Modifiers").Value)
            If (val And Keys.Control) <> 0 Then keybd_event(CByte(Keys.ControlKey), 0, KEYEVENTF_KEYDOWN, 0)
            If (val And Keys.Alt) <> 0 Then keybd_event(CByte(Keys.Menu), 0, KEYEVENTF_KEYDOWN, 0)
            If (val And Keys.Shift) <> 0 Then keybd_event(CByte(Keys.ShiftKey), 0, KEYEVENTF_KEYDOWN, 0)
        End If

        ' Pulsar y liberar la tecla requerida
        Dim code As Integer = Convert.ToInt32(DataGridView1.Rows.Item(i).Cells.Item("KeyCode").Value)
        keybd_event(CByte(code), 0, KEYEVENTF_KEYDOWN, 0)
        keybd_event(CByte(code), 0, KEYEVENTF_KEYUP, 0)

        ' Liberar la tecla del modificador si fuese necesario
        If DataGridView1.Rows.Item(i).Cells.Item("Modifiers").Value <> 0 Then
            Dim val As Integer = Convert.ToInt32(DataGridView1.Rows.Item(i).Cells.Item("Modifiers").Value)
            If (val And Keys.Control) <> 0 Then keybd_event(CByte(Keys.ControlKey), 0, KEYEVENTF_KEYUP, 0)
            If (val And Keys.Alt) <> 0 Then keybd_event(CByte(Keys.Menu), 0, KEYEVENTF_KEYUP, 0)
            If (val And Keys.Shift) <> 0 Then keybd_event(CByte(Keys.ShiftKey), 0, KEYEVENTF_KEYUP, 0)
        End If
    End Sub

    ' Interrupción de reloj para la actualización del último botón pulsado
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Si hay nueva tecla disponible
        If Len(indata) > 0 Then
            TextBox1.Text = indata
            indata = ""
            ' Si se trata de la tecla 'Enable'
            If (Label6.Text.Equals(TextBox1.Text)) Then
                ' Conmutar estado de activación
                CheckBox1.Checked = Not CheckBox1.Checked
            End If
            ' En el caso de las demás teclas
            If CheckBox1.Checked Then
                ' Buscar la combinación de teclas asociada al botón
                Dim index = FindCodeIndex(TextBox1.Text)
                If index >= 0 Then
                    ' Ejecutar dicha combinación
                    SendKeyCombo(index)
                End If
            End If
        End If
    End Sub

    ' Si existe, devuelve el índice que ocupa el códifo [code]
    ' Si [code] no está registrado devuelve un número negativo
    Private Function FindCodeIndex(code As String) As Integer
        Dim exist As Boolean = False
        Dim rowIndex As Integer
        ' Búsqueda secuencial no garantizada
        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells.Item("Code").Value = code Then
                exist = True
                rowIndex = row.Index
                Exit For
            End If
        Next
        If exist Then
            Return rowIndex
        Else
            Return -1
        End If
    End Function

    ' Activar escucha de nuevas pulsaciones de teclado
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.KeyPreview = True
        Button2.Enabled = False
    End Sub

    ' Tratamiento de nuevas teclas pulsadas
    Private Sub Main_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        TextBox2.Clear()
        ' Si está habilitada la escucha de pulsaciones
        If (Not Button2.Enabled) Then
            e.Handled = True
            ' En caso de modificadores
            If (e.Modifiers <> 0 AndAlso e.KeyCode <> Keys.ControlKey AndAlso e.KeyCode <> Keys.Menu AndAlso e.KeyCode <> Keys.ShiftKey) Then
                TextBox2.Text &= e.Modifiers.ToString.ToUpper & " + "
                ' Salvar modificadores
                savedModifiers = e.Modifiers
            End If

            Dim keyCode As String = ""

            ' En caso de alfa-numéricos
            If e.KeyCode >= Keys.D0 AndAlso e.KeyCode <= Keys.D9 Then
                keyCode = Convert.ToChar(e.KeyCode)
            ElseIf e.KeyCode >= Keys.A AndAlso e.KeyCode <= Keys.Z Then
                keyCode &= e.KeyCode.ToString.ToUpper
            Else
                ' Resto de casos
                keyCode &= "{"
                keyCode &= e.KeyCode.ToString.ToUpper
                keyCode &= "}"
            End If
            ' Texto identificativo a mostrar
            TextBox2.Text &= keyCode
            ' Salvar tecla pulsada
            savedKeyCode = e.KeyCode
        End If
    End Sub

    ' Tratamiento de nuevas teclas liberadas
    Private Sub Main_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Me.KeyPreview = False
        Button2.Enabled = True
    End Sub

    ' Habilitar el botón de 'añadir registro' en función de que los campos sean correctos
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If (TextBox1.TextLength > 0 AndAlso TextBox2.TextLength > 0) Then
            Button3.Enabled = True
        Else
            Button3.Enabled = False
        End If
    End Sub

    ' Habilitar el botón de 'añadir registro' en función de que los campos sean correctos
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If (TextBox1.TextLength > 0 AndAlso TextBox2.TextLength > 0) Then
            Button3.Enabled = True
        Else
            Button3.Enabled = False
        End If
    End Sub

    ' Agregar a la configuración de mando a distancia el nuevo código
    ' Si ya existe, pregunta al usuario sobre su sobreescritura
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim rowIndex = FindCodeIndex(TextBox1.Text)
        ' Ya existía dicho código
        If rowIndex >= 0 Then
            Dim rsp = MsgBox("This code already exists. Do you want to replace it?", MsgBoxStyle.YesNo)
            If rsp = MsgBoxResult.Yes Then
                DataGridView1.Rows.RemoveAt(rowIndex)
                rowIndex = -1
            End If
        End If
        ' si no existe dicho código
        If Not rowIndex >= 0 Then
            ' Inconrporación del nuevo registro
            DataGridView1.Rows.Add(TextBox1.Text, TextBox2.Text, savedModifiers, savedKeyCode)
            ' La configuración va un paso por delante del archivo [file]
            hasChanged = True
            TextBox1.Clear()
            TextBox2.Clear()
            savedKeyCode = 0
            savedModifiers = 0
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DataGridView1.Select()
        ' Si la fila seleccionada no es 'fila nueva'
        If DataGridView1.CurrentCell.RowIndex <> DataGridView1.NewRowIndex Then
            ' Eliminar fila del registro
            DataGridView1.Rows.RemoveAt(DataGridView1.CurrentCell.RowIndex)
            ' La configuración va un paso por delante del archivo [file]
            hasChanged = True
        End If
    End Sub

    ' Mostrar/Ocultar formulario al hacer clic sobre el icono del área de notificación
    Private Sub NotifyIcon1_MouseClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseClick
        If Me.WindowState = FormWindowState.Minimized Then
            ShowInTaskbar = True
            Me.WindowState = FormWindowState.Normal
        Else
            ShowInTaskbar = False
            Me.WindowState = FormWindowState.Minimized
        End If
    End Sub

    ' Pregunta si se desean guardar los cambios recientes
    Private Sub discardChanges()
        Dim discard = (MsgBox("There is unsaved changes." + vbCrLf + vbCrLf + "Would you like to save your current configuration now?" + vbCrLf + "Unsaved configuration will be lost.", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Save File"))
        If discard = MsgBoxResult.Yes Then
            SaveConfigFile()
        End If
        hasChanged = False
    End Sub

    ' Importar archivo [file] de configuración
    Private Sub OpenConfigFile(file As String)
        ' Borrar configuración anterior
        DataGridView1.Rows.Clear()
        Try
            ' Importar cada línea
            For Each line In My.Computer.FileSystem.ReadAllText(file).Split(Environment.NewLine)
                If Not Len(line.Trim) = 0 Then
                    ' Dividir cada campo atendiendo a la tabulación
                    DataGridView1.Rows.Add(Split(line.Trim, vbTab))
                End If
            Next
        Catch exc As System.IO.FileNotFoundException
            ' Si no se pudo abrir el archivo
            MsgBox("Error while opening the config file. The file cannot be accesed.", MsgBoxStyle.Critical, "Cannont ope File")
            My.Settings.config = ""
        End Try
    End Sub

    ' Opción de menú: 'Abrir archivo de configuración'
    Private Sub OpenConfigToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenConfigToolStripMenuItem.Click
        If hasChanged Then
            ' ¿Desea descartar los cambios?
            discardChanges()
        End If

        ' Abrir diálogo de exploración de archivos
        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            OpenConfigFile(OpenFileDialog1.FileName)
            ' Guardar configuración en registro
            My.Settings.config = OpenFileDialog1.FileName
        End If
    End Sub

    ' Exporta a archivo [file] de configuración
    Private Sub SaveConfigFile(file As String)
        ' Nuevo flujo de lectura
        Dim f As System.IO.StreamWriter
        Try
            ' Abrir flujo de lectura
            f = My.Computer.FileSystem.OpenTextFileWriter(file, False)
            ' Guardar fila a fila
            For Each row As DataGridViewRow In DataGridView1.Rows
                ' No guardar última fila ('Nueva Fila')
                If row.Index = DataGridView1.NewRowIndex Then Exit For
                For Each cell As DataGridViewCell In row.Cells
                    ' Separar cada campo con tabulación
                    f.Write(cell.Value.ToString)
                    f.Write(vbTab)
                Next
                ' Separar cada fila con nueva línea
                f.WriteLine()
            Next
            f.Close()
        Catch exc As System.IO.IOException
            MsgBox("Error while saving the current remote configuration. The file may be corrupted.", MsgBoxStyle.Critical, "Cannot save File")
        End Try
    End Sub

    Private Sub SaveConfigFile()
        If My.Settings.config <> "" Then
            ' Ya existe ruta
            SaveConfigFile(My.Settings.config)
        Else
            ' No existe ruta
            ' Abrir diálogo de exploración de archivos
            If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                SaveConfigFile(SaveFileDialog1.FileName)
                ' Cambios sincronizados
                hasChanged = False
                ' Guardar configiuración en registro
                My.Settings.config = SaveFileDialog1.FileName
            End If
        End If
    End Sub

    ' Opción de menú: 'Guardar archivo de configuración'
    Private Sub SaveConfigToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveConfigToolStripMenuItem.Click
        SaveConfigFile()
    End Sub

    ' Opción de menú: 'Guardar archivo de configuración cómo...'
    Private Sub SaveConfigAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveConfigAsToolStripMenuItem.Click
        ' Abrir diálogo de exploración de archivos
        If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            SaveConfigFile(SaveFileDialog1.FileName)
            ' Guardar configiuración en registro
            My.Settings.config = SaveFileDialog1.FileName
        End If
    End Sub

    ' Opción de menú: 'Nuevo archivo de configuración'
    Private Sub NewConfigToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewConfigToolStripMenuItem.Click
        If hasChanged Then
            ' ¿Desea descartar los cambios?
            discardChanges()
        End If
        ' Borrar configuración anterior
        DataGridView1.Rows.Clear()
        ' Guardar configiuración en registro
        My.Settings.config = ""
    End Sub

    ' Guardar configuración en registro: 'Iniciar minimizado'
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        My.Settings.minimized = CheckBox2.Checked
    End Sub

    ' Establecer botón para tecla 'Enabled'
    Private Sub SetEnableKeyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetEnableKeyToolStripMenuItem.Click
        If (Len(TextBox1.Text) > 0) Then
            Dim rowIndex = FindCodeIndex(TextBox1.Text)
            ' Confirmar sobreescritura si procede
            If rowIndex >= 0 Then
                Dim rsp = MsgBox("This code already exists. Do you want to replace it?", MsgBoxStyle.YesNo)
                If rsp = MsgBoxResult.Yes Then
                    DataGridView1.Rows.RemoveAt(rowIndex)
                    rowIndex = -1
                End If
            End If
            ' Cambiar valor
            If Not rowIndex >= 0 Then
                Label6.Text = TextBox1.Text
                TextBox1.Clear()
            End If
        Else
            Label6.Text = "None"
        End If
        ' Guardar configuración en registro
        My.Settings.enableKey = Label6.Text

    End Sub

    ' Pop-up al activar y desactivar la aplicación
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            CheckBox1.Text = "Enabled"
        Else
            CheckBox1.Text = "Disabled"
        End If

        NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
        If (CheckBox1.Checked) Then
            NotifyIcon1.BalloonTipTitle = "IR Receiver enabled"
            NotifyIcon1.BalloonTipText = "Now your remote is controlling the PC."
        Else
            NotifyIcon1.BalloonTipTitle = "IR Receiver disabled"
            NotifyIcon1.BalloonTipText = "Your remote won't have any effect on the PC."
        End If
        ' Mostrar durante 3 segundos (3000 ms)
        NotifyIcon1.ShowBalloonTip(3000)
    End Sub
End Class
