<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Vista
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
        Me.Artistas = New System.Windows.Forms.TabControl()
        Me.PestañaUsuarios = New System.Windows.Forms.TabPage()
        Me.LimpiarUser = New System.Windows.Forms.Button()
        Me.updateUserButton = New System.Windows.Forms.Button()
        Me.deleterUserButton = New System.Windows.Forms.Button()
        Me.insertUserButton = New System.Windows.Forms.Button()
        Me.lblFechaNacimiento = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtEmailUsuario = New System.Windows.Forms.TextBox()
        Me.txtApellidoUsuario = New System.Windows.Forms.TextBox()
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.CalendarUsuario = New System.Windows.Forms.DateTimePicker()
        Me.txtSelectedDB = New System.Windows.Forms.TextBox()
        Me.selectDBButton = New System.Windows.Forms.Button()
        Me.connectButton = New System.Windows.Forms.Button()
        Me.usersList = New System.Windows.Forms.ListBox()
        Me.PestañaArtistas = New System.Windows.Forms.TabPage()
        Me.PicmostrarImagen = New System.Windows.Forms.PictureBox()
        Me.lblImageArtist = New System.Windows.Forms.Label()
        Me.imageArtist = New System.Windows.Forms.PictureBox()
        Me.lblCountryArtist = New System.Windows.Forms.Label()
        Me.lblIdArtista = New System.Windows.Forms.Label()
        Me.lblNameArtist = New System.Windows.Forms.Label()
        Me.txtArtistCountry = New System.Windows.Forms.TextBox()
        Me.txtArtistID = New System.Windows.Forms.TextBox()
        Me.txtArtistName = New System.Windows.Forms.TextBox()
        Me.cleanArtist = New System.Windows.Forms.Button()
        Me.deleteArtist = New System.Windows.Forms.Button()
        Me.updateArtist = New System.Windows.Forms.Button()
        Me.insertArtist = New System.Windows.Forms.Button()
        Me.lbl_cancAlb = New System.Windows.Forms.Label()
        Me.lbl_albArt = New System.Windows.Forms.Label()
        Me.lbl_art = New System.Windows.Forms.Label()
        Me.lstCanciones = New System.Windows.Forms.ListBox()
        Me.lstAlbumes = New System.Windows.Forms.ListBox()
        Me.lstArtistas = New System.Windows.Forms.ListBox()
        Me.cleanupAlbum = New System.Windows.Forms.Button()
        Me.deleteAlbum = New System.Windows.Forms.Button()
        Me.updateAlbum = New System.Windows.Forms.Button()
        Me.insertAlbum = New System.Windows.Forms.Button()
        Me.lblIdAlbum = New System.Windows.Forms.Label()
        Me.txtIdAlbum = New System.Windows.Forms.TextBox()
        Me.lblArtista = New System.Windows.Forms.Label()
        Me.txtArtista = New System.Windows.Forms.TextBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.CalendarAlbum = New System.Windows.Forms.DateTimePicker()
        Me.lblNombreAlbum = New System.Windows.Forms.Label()
        Me.txtNombreAlbum = New System.Windows.Forms.TextBox()
        Me.limpiarCancionboton = New System.Windows.Forms.Button()
        Me.actualizarCancionboton = New System.Windows.Forms.Button()
        Me.borrarcancionboton = New System.Windows.Forms.Button()
        Me.insertarcancionboton = New System.Windows.Forms.Button()
        Me.txtIdCancion = New System.Windows.Forms.TextBox()
        Me.txtDuracion = New System.Windows.Forms.TextBox()
        Me.lblIdCancion = New System.Windows.Forms.Label()
        Me.lblDuracion = New System.Windows.Forms.Label()
        Me.lblNombreCancion = New System.Windows.Forms.Label()
        Me.txtNombreCancion = New System.Windows.Forms.TextBox()
        Me.lblAlbum = New System.Windows.Forms.Label()
        Me.txtAlbum = New System.Windows.Forms.TextBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lstC1 = New System.Windows.Forms.ListBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.ofdRuta = New System.Windows.Forms.OpenFileDialog()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Tiempo = New System.Windows.Forms.Timer(Me.components)
        Me.Tiempo_Duracion = New System.Windows.Forms.Timer(Me.components)
        Me.Artistas.SuspendLayout()
        Me.PestañaUsuarios.SuspendLayout()
        Me.PestañaArtistas.SuspendLayout()
        CType(Me.PicmostrarImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imageArtist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Artistas
        '
        Me.Artistas.Controls.Add(Me.PestañaUsuarios)
        Me.Artistas.Controls.Add(Me.PestañaArtistas)
        Me.Artistas.Controls.Add(Me.TabPage1)
        Me.Artistas.Controls.Add(Me.TabPage2)
        Me.Artistas.Controls.Add(Me.TabPage3)
        Me.Artistas.Controls.Add(Me.TabPage4)
        Me.Artistas.Controls.Add(Me.TabPage5)
        Me.Artistas.Location = New System.Drawing.Point(-6, 8)
        Me.Artistas.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.Artistas.Name = "Artistas"
        Me.Artistas.SelectedIndex = 0
        Me.Artistas.Size = New System.Drawing.Size(1414, 818)
        Me.Artistas.TabIndex = 0
        '
        'PestañaUsuarios
        '
        Me.PestañaUsuarios.BackColor = System.Drawing.Color.IndianRed
        Me.PestañaUsuarios.Controls.Add(Me.LimpiarUser)
        Me.PestañaUsuarios.Controls.Add(Me.updateUserButton)
        Me.PestañaUsuarios.Controls.Add(Me.deleterUserButton)
        Me.PestañaUsuarios.Controls.Add(Me.insertUserButton)
        Me.PestañaUsuarios.Controls.Add(Me.lblFechaNacimiento)
        Me.PestañaUsuarios.Controls.Add(Me.lblEmail)
        Me.PestañaUsuarios.Controls.Add(Me.lblApellido)
        Me.PestañaUsuarios.Controls.Add(Me.lblNombre)
        Me.PestañaUsuarios.Controls.Add(Me.txtEmailUsuario)
        Me.PestañaUsuarios.Controls.Add(Me.txtApellidoUsuario)
        Me.PestañaUsuarios.Controls.Add(Me.txtNombreUsuario)
        Me.PestañaUsuarios.Controls.Add(Me.CalendarUsuario)
        Me.PestañaUsuarios.Controls.Add(Me.txtSelectedDB)
        Me.PestañaUsuarios.Controls.Add(Me.selectDBButton)
        Me.PestañaUsuarios.Controls.Add(Me.connectButton)
        Me.PestañaUsuarios.Controls.Add(Me.usersList)
        Me.PestañaUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PestañaUsuarios.Location = New System.Drawing.Point(4, 29)
        Me.PestañaUsuarios.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PestañaUsuarios.Name = "PestañaUsuarios"
        Me.PestañaUsuarios.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PestañaUsuarios.Size = New System.Drawing.Size(1406, 785)
        Me.PestañaUsuarios.TabIndex = 0
        Me.PestañaUsuarios.Text = "Usuarios"
        '
        'LimpiarUser
        '
        Me.LimpiarUser.Location = New System.Drawing.Point(928, 329)
        Me.LimpiarUser.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LimpiarUser.Name = "LimpiarUser"
        Me.LimpiarUser.Size = New System.Drawing.Size(225, 69)
        Me.LimpiarUser.TabIndex = 15
        Me.LimpiarUser.Text = "Limpiar"
        Me.LimpiarUser.UseVisualStyleBackColor = True
        '
        'updateUserButton
        '
        Me.updateUserButton.Location = New System.Drawing.Point(928, 254)
        Me.updateUserButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.updateUserButton.Name = "updateUserButton"
        Me.updateUserButton.Size = New System.Drawing.Size(225, 69)
        Me.updateUserButton.TabIndex = 14
        Me.updateUserButton.Text = "Actualizar usuario"
        Me.updateUserButton.UseVisualStyleBackColor = True
        '
        'deleterUserButton
        '
        Me.deleterUserButton.Location = New System.Drawing.Point(624, 329)
        Me.deleterUserButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.deleterUserButton.Name = "deleterUserButton"
        Me.deleterUserButton.Size = New System.Drawing.Size(225, 69)
        Me.deleterUserButton.TabIndex = 13
        Me.deleterUserButton.Text = "Borrar usuario"
        Me.deleterUserButton.UseVisualStyleBackColor = True
        '
        'insertUserButton
        '
        Me.insertUserButton.Location = New System.Drawing.Point(624, 251)
        Me.insertUserButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.insertUserButton.Name = "insertUserButton"
        Me.insertUserButton.Size = New System.Drawing.Size(225, 69)
        Me.insertUserButton.TabIndex = 12
        Me.insertUserButton.Text = "Insertar Usuario"
        Me.insertUserButton.UseVisualStyleBackColor = True
        '
        'lblFechaNacimiento
        '
        Me.lblFechaNacimiento.AutoSize = True
        Me.lblFechaNacimiento.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblFechaNacimiento.Location = New System.Drawing.Point(924, 149)
        Me.lblFechaNacimiento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFechaNacimiento.Name = "lblFechaNacimiento"
        Me.lblFechaNacimiento.Size = New System.Drawing.Size(183, 20)
        Me.lblFechaNacimiento.TabIndex = 11
        Me.lblFechaNacimiento.Text = "Fecha de nacimiento"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblEmail.Location = New System.Drawing.Point(924, 58)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(56, 20)
        Me.lblEmail.TabIndex = 10
        Me.lblEmail.Text = "Email"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblApellido.Location = New System.Drawing.Point(620, 149)
        Me.lblApellido.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(76, 20)
        Me.lblApellido.TabIndex = 9
        Me.lblApellido.Text = "Apellido"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblNombre.Location = New System.Drawing.Point(620, 63)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(74, 20)
        Me.lblNombre.TabIndex = 8
        Me.lblNombre.Text = "Nombre"
        '
        'txtEmailUsuario
        '
        Me.txtEmailUsuario.Location = New System.Drawing.Point(928, 88)
        Me.txtEmailUsuario.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtEmailUsuario.Name = "txtEmailUsuario"
        Me.txtEmailUsuario.Size = New System.Drawing.Size(298, 26)
        Me.txtEmailUsuario.TabIndex = 7
        '
        'txtApellidoUsuario
        '
        Me.txtApellidoUsuario.Location = New System.Drawing.Point(624, 174)
        Me.txtApellidoUsuario.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtApellidoUsuario.Name = "txtApellidoUsuario"
        Me.txtApellidoUsuario.Size = New System.Drawing.Size(223, 26)
        Me.txtApellidoUsuario.TabIndex = 6
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.Location = New System.Drawing.Point(624, 88)
        Me.txtNombreUsuario.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.Size = New System.Drawing.Size(223, 26)
        Me.txtNombreUsuario.TabIndex = 5
        '
        'CalendarUsuario
        '
        Me.CalendarUsuario.CalendarTitleBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.CalendarUsuario.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.CalendarUsuario.Location = New System.Drawing.Point(928, 174)
        Me.CalendarUsuario.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CalendarUsuario.MaxDate = New Date(2021, 3, 31, 0, 0, 0, 0)
        Me.CalendarUsuario.MinDate = New Date(1939, 1, 1, 0, 0, 0, 0)
        Me.CalendarUsuario.Name = "CalendarUsuario"
        Me.CalendarUsuario.Size = New System.Drawing.Size(298, 26)
        Me.CalendarUsuario.TabIndex = 4
        Me.CalendarUsuario.Value = New Date(2021, 3, 31, 0, 0, 0, 0)
        '
        'txtSelectedDB
        '
        Me.txtSelectedDB.Enabled = False
        Me.txtSelectedDB.Location = New System.Drawing.Point(63, 438)
        Me.txtSelectedDB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSelectedDB.Multiline = True
        Me.txtSelectedDB.Name = "txtSelectedDB"
        Me.txtSelectedDB.ReadOnly = True
        Me.txtSelectedDB.Size = New System.Drawing.Size(512, 87)
        Me.txtSelectedDB.TabIndex = 3
        Me.txtSelectedDB.TabStop = False
        '
        'selectDBButton
        '
        Me.selectDBButton.Location = New System.Drawing.Point(201, 338)
        Me.selectDBButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.selectDBButton.Name = "selectDBButton"
        Me.selectDBButton.Size = New System.Drawing.Size(174, 75)
        Me.selectDBButton.TabIndex = 2
        Me.selectDBButton.Text = "Seleccionar Base de Datos"
        Me.selectDBButton.UseVisualStyleBackColor = True
        '
        'connectButton
        '
        Me.connectButton.Location = New System.Drawing.Point(201, 254)
        Me.connectButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.connectButton.Name = "connectButton"
        Me.connectButton.Size = New System.Drawing.Size(174, 62)
        Me.connectButton.TabIndex = 1
        Me.connectButton.Text = "Conectar"
        Me.connectButton.UseVisualStyleBackColor = True
        '
        'usersList
        '
        Me.usersList.FormattingEnabled = True
        Me.usersList.ItemHeight = 20
        Me.usersList.Location = New System.Drawing.Point(63, 58)
        Me.usersList.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.usersList.Name = "usersList"
        Me.usersList.Size = New System.Drawing.Size(512, 184)
        Me.usersList.TabIndex = 0
        '
        'PestañaArtistas
        '
        Me.PestañaArtistas.BackColor = System.Drawing.Color.Teal
        Me.PestañaArtistas.Controls.Add(Me.PicmostrarImagen)
        Me.PestañaArtistas.Controls.Add(Me.lblImageArtist)
        Me.PestañaArtistas.Controls.Add(Me.imageArtist)
        Me.PestañaArtistas.Controls.Add(Me.lblCountryArtist)
        Me.PestañaArtistas.Controls.Add(Me.lblIdArtista)
        Me.PestañaArtistas.Controls.Add(Me.lblNameArtist)
        Me.PestañaArtistas.Controls.Add(Me.txtArtistCountry)
        Me.PestañaArtistas.Controls.Add(Me.txtArtistID)
        Me.PestañaArtistas.Controls.Add(Me.txtArtistName)
        Me.PestañaArtistas.Controls.Add(Me.cleanArtist)
        Me.PestañaArtistas.Controls.Add(Me.deleteArtist)
        Me.PestañaArtistas.Controls.Add(Me.updateArtist)
        Me.PestañaArtistas.Controls.Add(Me.insertArtist)
        Me.PestañaArtistas.Controls.Add(Me.lbl_cancAlb)
        Me.PestañaArtistas.Controls.Add(Me.lbl_albArt)
        Me.PestañaArtistas.Controls.Add(Me.lbl_art)
        Me.PestañaArtistas.Controls.Add(Me.lstCanciones)
        Me.PestañaArtistas.Controls.Add(Me.lstAlbumes)
        Me.PestañaArtistas.Controls.Add(Me.lstArtistas)
        Me.PestañaArtistas.Controls.Add(Me.cleanupAlbum)
        Me.PestañaArtistas.Controls.Add(Me.deleteAlbum)
        Me.PestañaArtistas.Controls.Add(Me.updateAlbum)
        Me.PestañaArtistas.Controls.Add(Me.insertAlbum)
        Me.PestañaArtistas.Controls.Add(Me.lblIdAlbum)
        Me.PestañaArtistas.Controls.Add(Me.txtIdAlbum)
        Me.PestañaArtistas.Controls.Add(Me.lblArtista)
        Me.PestañaArtistas.Controls.Add(Me.txtArtista)
        Me.PestañaArtistas.Controls.Add(Me.lblFecha)
        Me.PestañaArtistas.Controls.Add(Me.CalendarAlbum)
        Me.PestañaArtistas.Controls.Add(Me.lblNombreAlbum)
        Me.PestañaArtistas.Controls.Add(Me.txtNombreAlbum)
        Me.PestañaArtistas.Controls.Add(Me.limpiarCancionboton)
        Me.PestañaArtistas.Controls.Add(Me.actualizarCancionboton)
        Me.PestañaArtistas.Controls.Add(Me.borrarcancionboton)
        Me.PestañaArtistas.Controls.Add(Me.insertarcancionboton)
        Me.PestañaArtistas.Controls.Add(Me.txtIdCancion)
        Me.PestañaArtistas.Controls.Add(Me.txtDuracion)
        Me.PestañaArtistas.Controls.Add(Me.lblIdCancion)
        Me.PestañaArtistas.Controls.Add(Me.lblDuracion)
        Me.PestañaArtistas.Controls.Add(Me.lblNombreCancion)
        Me.PestañaArtistas.Controls.Add(Me.txtNombreCancion)
        Me.PestañaArtistas.Controls.Add(Me.lblAlbum)
        Me.PestañaArtistas.Controls.Add(Me.txtAlbum)
        Me.PestañaArtistas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PestañaArtistas.Location = New System.Drawing.Point(4, 29)
        Me.PestañaArtistas.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PestañaArtistas.Name = "PestañaArtistas"
        Me.PestañaArtistas.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PestañaArtistas.Size = New System.Drawing.Size(1406, 785)
        Me.PestañaArtistas.TabIndex = 1
        Me.PestañaArtistas.Text = "Menú"
        '
        'PicmostrarImagen
        '
        Me.PicmostrarImagen.Location = New System.Drawing.Point(544, 583)
        Me.PicmostrarImagen.Name = "PicmostrarImagen"
        Me.PicmostrarImagen.Size = New System.Drawing.Size(328, 145)
        Me.PicmostrarImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicmostrarImagen.TabIndex = 42
        Me.PicmostrarImagen.TabStop = False
        '
        'lblImageArtist
        '
        Me.lblImageArtist.AutoSize = True
        Me.lblImageArtist.BackColor = System.Drawing.Color.Transparent
        Me.lblImageArtist.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblImageArtist.Location = New System.Drawing.Point(183, 511)
        Me.lblImageArtist.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblImageArtist.Name = "lblImageArtist"
        Me.lblImageArtist.Size = New System.Drawing.Size(69, 20)
        Me.lblImageArtist.TabIndex = 39
        Me.lblImageArtist.Text = "Imagen"
        Me.lblImageArtist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'imageArtist
        '
        Me.imageArtist.Location = New System.Drawing.Point(68, 537)
        Me.imageArtist.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.imageArtist.Name = "imageArtist"
        Me.imageArtist.Size = New System.Drawing.Size(328, 189)
        Me.imageArtist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imageArtist.TabIndex = 38
        Me.imageArtist.TabStop = False
        '
        'lblCountryArtist
        '
        Me.lblCountryArtist.AutoSize = True
        Me.lblCountryArtist.BackColor = System.Drawing.Color.Transparent
        Me.lblCountryArtist.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCountryArtist.Location = New System.Drawing.Point(206, 452)
        Me.lblCountryArtist.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCountryArtist.Name = "lblCountryArtist"
        Me.lblCountryArtist.Size = New System.Drawing.Size(46, 20)
        Me.lblCountryArtist.TabIndex = 37
        Me.lblCountryArtist.Text = "País"
        Me.lblCountryArtist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblIdArtista
        '
        Me.lblIdArtista.AutoSize = True
        Me.lblIdArtista.BackColor = System.Drawing.Color.Transparent
        Me.lblIdArtista.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblIdArtista.Location = New System.Drawing.Point(164, 397)
        Me.lblIdArtista.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIdArtista.Name = "lblIdArtista"
        Me.lblIdArtista.Size = New System.Drawing.Size(119, 20)
        Me.lblIdArtista.TabIndex = 36
        Me.lblIdArtista.Text = "ID del artista"
        Me.lblIdArtista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNameArtist
        '
        Me.lblNameArtist.AutoSize = True
        Me.lblNameArtist.BackColor = System.Drawing.Color.Transparent
        Me.lblNameArtist.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblNameArtist.Location = New System.Drawing.Point(148, 335)
        Me.lblNameArtist.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNameArtist.Name = "lblNameArtist"
        Me.lblNameArtist.Size = New System.Drawing.Size(165, 20)
        Me.lblNameArtist.TabIndex = 35
        Me.lblNameArtist.Text = "Nombre del artista"
        Me.lblNameArtist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtArtistCountry
        '
        Me.txtArtistCountry.Location = New System.Drawing.Point(68, 477)
        Me.txtArtistCountry.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtArtistCountry.Name = "txtArtistCountry"
        Me.txtArtistCountry.Size = New System.Drawing.Size(328, 26)
        Me.txtArtistCountry.TabIndex = 34
        '
        'txtArtistID
        '
        Me.txtArtistID.Location = New System.Drawing.Point(68, 422)
        Me.txtArtistID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtArtistID.Name = "txtArtistID"
        Me.txtArtistID.Size = New System.Drawing.Size(328, 26)
        Me.txtArtistID.TabIndex = 33
        '
        'txtArtistName
        '
        Me.txtArtistName.Location = New System.Drawing.Point(68, 360)
        Me.txtArtistName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtArtistName.Name = "txtArtistName"
        Me.txtArtistName.Size = New System.Drawing.Size(328, 26)
        Me.txtArtistName.TabIndex = 32
        '
        'cleanArtist
        '
        Me.cleanArtist.Location = New System.Drawing.Point(234, 275)
        Me.cleanArtist.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cleanArtist.Name = "cleanArtist"
        Me.cleanArtist.Size = New System.Drawing.Size(210, 46)
        Me.cleanArtist.TabIndex = 31
        Me.cleanArtist.Text = "Limpiar"
        Me.cleanArtist.UseVisualStyleBackColor = True
        '
        'deleteArtist
        '
        Me.deleteArtist.Location = New System.Drawing.Point(15, 275)
        Me.deleteArtist.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.deleteArtist.Name = "deleteArtist"
        Me.deleteArtist.Size = New System.Drawing.Size(210, 46)
        Me.deleteArtist.TabIndex = 30
        Me.deleteArtist.Text = "Borrar artista"
        Me.deleteArtist.UseVisualStyleBackColor = True
        '
        'updateArtist
        '
        Me.updateArtist.Location = New System.Drawing.Point(234, 218)
        Me.updateArtist.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.updateArtist.Name = "updateArtist"
        Me.updateArtist.Size = New System.Drawing.Size(210, 46)
        Me.updateArtist.TabIndex = 29
        Me.updateArtist.Text = "Actualizar artista"
        Me.updateArtist.UseVisualStyleBackColor = True
        '
        'insertArtist
        '
        Me.insertArtist.Location = New System.Drawing.Point(15, 218)
        Me.insertArtist.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.insertArtist.Name = "insertArtist"
        Me.insertArtist.Size = New System.Drawing.Size(210, 46)
        Me.insertArtist.TabIndex = 28
        Me.insertArtist.Text = "Insertar artista"
        Me.insertArtist.UseVisualStyleBackColor = True
        '
        'lbl_cancAlb
        '
        Me.lbl_cancAlb.AutoSize = True
        Me.lbl_cancAlb.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_cancAlb.Location = New System.Drawing.Point(948, 25)
        Me.lbl_cancAlb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_cancAlb.Name = "lbl_cancAlb"
        Me.lbl_cancAlb.Size = New System.Drawing.Size(235, 20)
        Me.lbl_cancAlb.TabIndex = 5
        Me.lbl_cancAlb.Text = "CANCIONES DEL ÁLBUM:"
        '
        'lbl_albArt
        '
        Me.lbl_albArt.AutoSize = True
        Me.lbl_albArt.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_albArt.Location = New System.Drawing.Point(489, 25)
        Me.lbl_albArt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_albArt.Name = "lbl_albArt"
        Me.lbl_albArt.Size = New System.Drawing.Size(228, 20)
        Me.lbl_albArt.TabIndex = 4
        Me.lbl_albArt.Text = "ÁLBUMES DEL ARTISTA:"
        '
        'lbl_art
        '
        Me.lbl_art.AutoSize = True
        Me.lbl_art.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_art.Location = New System.Drawing.Point(15, 25)
        Me.lbl_art.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_art.Name = "lbl_art"
        Me.lbl_art.Size = New System.Drawing.Size(103, 20)
        Me.lbl_art.TabIndex = 3
        Me.lbl_art.Text = "ARTISTAS:"
        Me.lbl_art.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lstCanciones
        '
        Me.lstCanciones.FormattingEnabled = True
        Me.lstCanciones.ItemHeight = 20
        Me.lstCanciones.Location = New System.Drawing.Point(956, 49)
        Me.lstCanciones.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstCanciones.Name = "lstCanciones"
        Me.lstCanciones.Size = New System.Drawing.Size(238, 144)
        Me.lstCanciones.TabIndex = 2
        '
        'lstAlbumes
        '
        Me.lstAlbumes.FormattingEnabled = True
        Me.lstAlbumes.ItemHeight = 20
        Me.lstAlbumes.Location = New System.Drawing.Point(494, 49)
        Me.lstAlbumes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstAlbumes.Name = "lstAlbumes"
        Me.lstAlbumes.Size = New System.Drawing.Size(238, 144)
        Me.lstAlbumes.TabIndex = 1
        '
        'lstArtistas
        '
        Me.lstArtistas.FormattingEnabled = True
        Me.lstArtistas.ItemHeight = 20
        Me.lstArtistas.Location = New System.Drawing.Point(15, 49)
        Me.lstArtistas.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstArtistas.Name = "lstArtistas"
        Me.lstArtistas.Size = New System.Drawing.Size(238, 144)
        Me.lstArtistas.TabIndex = 0
        '
        'cleanupAlbum
        '
        Me.cleanupAlbum.Location = New System.Drawing.Point(712, 275)
        Me.cleanupAlbum.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cleanupAlbum.Name = "cleanupAlbum"
        Me.cleanupAlbum.Size = New System.Drawing.Size(210, 46)
        Me.cleanupAlbum.TabIndex = 21
        Me.cleanupAlbum.Text = "Limpiar"
        Me.cleanupAlbum.UseVisualStyleBackColor = True
        '
        'deleteAlbum
        '
        Me.deleteAlbum.Location = New System.Drawing.Point(494, 275)
        Me.deleteAlbum.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.deleteAlbum.Name = "deleteAlbum"
        Me.deleteAlbum.Size = New System.Drawing.Size(210, 46)
        Me.deleteAlbum.TabIndex = 20
        Me.deleteAlbum.Text = "Borrar álbum"
        Me.deleteAlbum.UseVisualStyleBackColor = True
        '
        'updateAlbum
        '
        Me.updateAlbum.Location = New System.Drawing.Point(711, 218)
        Me.updateAlbum.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.updateAlbum.Name = "updateAlbum"
        Me.updateAlbum.Size = New System.Drawing.Size(210, 46)
        Me.updateAlbum.TabIndex = 19
        Me.updateAlbum.Text = "Actualizar álbum"
        Me.updateAlbum.UseVisualStyleBackColor = True
        '
        'insertAlbum
        '
        Me.insertAlbum.Location = New System.Drawing.Point(492, 218)
        Me.insertAlbum.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.insertAlbum.Name = "insertAlbum"
        Me.insertAlbum.Size = New System.Drawing.Size(210, 46)
        Me.insertAlbum.TabIndex = 18
        Me.insertAlbum.Text = "Insertar álbum"
        Me.insertAlbum.UseVisualStyleBackColor = True
        '
        'lblIdAlbum
        '
        Me.lblIdAlbum.AutoSize = True
        Me.lblIdAlbum.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblIdAlbum.Location = New System.Drawing.Point(645, 457)
        Me.lblIdAlbum.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIdAlbum.Name = "lblIdAlbum"
        Me.lblIdAlbum.Size = New System.Drawing.Size(115, 20)
        Me.lblIdAlbum.TabIndex = 17
        Me.lblIdAlbum.Text = "ID del álbum"
        '
        'txtIdAlbum
        '
        Me.txtIdAlbum.Location = New System.Drawing.Point(544, 477)
        Me.txtIdAlbum.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtIdAlbum.Name = "txtIdAlbum"
        Me.txtIdAlbum.Size = New System.Drawing.Size(328, 26)
        Me.txtIdAlbum.TabIndex = 16
        '
        'lblArtista
        '
        Me.lblArtista.AutoSize = True
        Me.lblArtista.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblArtista.Location = New System.Drawing.Point(669, 395)
        Me.lblArtista.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblArtista.Name = "lblArtista"
        Me.lblArtista.Size = New System.Drawing.Size(65, 20)
        Me.lblArtista.TabIndex = 15
        Me.lblArtista.Text = "Artista"
        '
        'txtArtista
        '
        Me.txtArtista.Location = New System.Drawing.Point(544, 422)
        Me.txtArtista.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtArtista.Name = "txtArtista"
        Me.txtArtista.Size = New System.Drawing.Size(328, 26)
        Me.txtArtista.TabIndex = 14
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblFecha.Location = New System.Drawing.Point(669, 512)
        Me.lblFecha.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(60, 20)
        Me.lblFecha.TabIndex = 13
        Me.lblFecha.Text = "Fecha"
        '
        'CalendarAlbum
        '
        Me.CalendarAlbum.CalendarTitleBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.CalendarAlbum.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.CalendarAlbum.Location = New System.Drawing.Point(544, 537)
        Me.CalendarAlbum.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.CalendarAlbum.MaxDate = New Date(2021, 3, 31, 0, 0, 0, 0)
        Me.CalendarAlbum.MinDate = New Date(1939, 1, 1, 0, 0, 0, 0)
        Me.CalendarAlbum.Name = "CalendarAlbum"
        Me.CalendarAlbum.Size = New System.Drawing.Size(328, 26)
        Me.CalendarAlbum.TabIndex = 12
        Me.CalendarAlbum.Value = New Date(2021, 3, 31, 0, 0, 0, 0)
        '
        'lblNombreAlbum
        '
        Me.lblNombreAlbum.AutoSize = True
        Me.lblNombreAlbum.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblNombreAlbum.Location = New System.Drawing.Point(645, 335)
        Me.lblNombreAlbum.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombreAlbum.Name = "lblNombreAlbum"
        Me.lblNombreAlbum.Size = New System.Drawing.Size(132, 20)
        Me.lblNombreAlbum.TabIndex = 4
        Me.lblNombreAlbum.Text = "Nombre Album"
        '
        'txtNombreAlbum
        '
        Me.txtNombreAlbum.Location = New System.Drawing.Point(544, 360)
        Me.txtNombreAlbum.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNombreAlbum.Name = "txtNombreAlbum"
        Me.txtNombreAlbum.Size = New System.Drawing.Size(328, 26)
        Me.txtNombreAlbum.TabIndex = 3
        '
        'limpiarCancionboton
        '
        Me.limpiarCancionboton.Location = New System.Drawing.Point(1178, 272)
        Me.limpiarCancionboton.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.limpiarCancionboton.Name = "limpiarCancionboton"
        Me.limpiarCancionboton.Size = New System.Drawing.Size(210, 46)
        Me.limpiarCancionboton.TabIndex = 21
        Me.limpiarCancionboton.Text = "Limpiar"
        Me.limpiarCancionboton.UseVisualStyleBackColor = True
        '
        'actualizarCancionboton
        '
        Me.actualizarCancionboton.Location = New System.Drawing.Point(1178, 218)
        Me.actualizarCancionboton.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.actualizarCancionboton.Name = "actualizarCancionboton"
        Me.actualizarCancionboton.Size = New System.Drawing.Size(210, 46)
        Me.actualizarCancionboton.TabIndex = 20
        Me.actualizarCancionboton.Text = "Actualizar canción"
        Me.actualizarCancionboton.UseVisualStyleBackColor = True
        '
        'borrarcancionboton
        '
        Me.borrarcancionboton.Location = New System.Drawing.Point(956, 272)
        Me.borrarcancionboton.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.borrarcancionboton.Name = "borrarcancionboton"
        Me.borrarcancionboton.Size = New System.Drawing.Size(210, 46)
        Me.borrarcancionboton.TabIndex = 19
        Me.borrarcancionboton.Text = "Borrar canción"
        Me.borrarcancionboton.UseVisualStyleBackColor = True
        '
        'insertarcancionboton
        '
        Me.insertarcancionboton.Location = New System.Drawing.Point(956, 218)
        Me.insertarcancionboton.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.insertarcancionboton.Name = "insertarcancionboton"
        Me.insertarcancionboton.Size = New System.Drawing.Size(210, 46)
        Me.insertarcancionboton.TabIndex = 18
        Me.insertarcancionboton.Text = "Insertar canción"
        Me.insertarcancionboton.UseVisualStyleBackColor = True
        '
        'txtIdCancion
        '
        Me.txtIdCancion.Location = New System.Drawing.Point(1012, 422)
        Me.txtIdCancion.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.txtIdCancion.Name = "txtIdCancion"
        Me.txtIdCancion.Size = New System.Drawing.Size(332, 26)
        Me.txtIdCancion.TabIndex = 15
        '
        'txtDuracion
        '
        Me.txtDuracion.Location = New System.Drawing.Point(1012, 475)
        Me.txtDuracion.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.txtDuracion.Name = "txtDuracion"
        Me.txtDuracion.Size = New System.Drawing.Size(332, 26)
        Me.txtDuracion.TabIndex = 14
        '
        'lblIdCancion
        '
        Me.lblIdCancion.AutoSize = True
        Me.lblIdCancion.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblIdCancion.Location = New System.Drawing.Point(1120, 394)
        Me.lblIdCancion.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblIdCancion.Name = "lblIdCancion"
        Me.lblIdCancion.Size = New System.Drawing.Size(146, 20)
        Me.lblIdCancion.TabIndex = 13
        Me.lblIdCancion.Text = "ID de la canción"
        '
        'lblDuracion
        '
        Me.lblDuracion.AutoSize = True
        Me.lblDuracion.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDuracion.Location = New System.Drawing.Point(1134, 457)
        Me.lblDuracion.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblDuracion.Name = "lblDuracion"
        Me.lblDuracion.Size = New System.Drawing.Size(85, 20)
        Me.lblDuracion.TabIndex = 12
        Me.lblDuracion.Text = "Duración"
        '
        'lblNombreCancion
        '
        Me.lblNombreCancion.AutoSize = True
        Me.lblNombreCancion.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblNombreCancion.Location = New System.Drawing.Point(1134, 335)
        Me.lblNombreCancion.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblNombreCancion.Name = "lblNombreCancion"
        Me.lblNombreCancion.Size = New System.Drawing.Size(74, 20)
        Me.lblNombreCancion.TabIndex = 11
        Me.lblNombreCancion.Text = "Nombre"
        '
        'txtNombreCancion
        '
        Me.txtNombreCancion.Location = New System.Drawing.Point(1012, 360)
        Me.txtNombreCancion.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.txtNombreCancion.Name = "txtNombreCancion"
        Me.txtNombreCancion.Size = New System.Drawing.Size(332, 26)
        Me.txtNombreCancion.TabIndex = 10
        '
        'lblAlbum
        '
        Me.lblAlbum.AutoSize = True
        Me.lblAlbum.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblAlbum.Location = New System.Drawing.Point(1148, 514)
        Me.lblAlbum.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblAlbum.Name = "lblAlbum"
        Me.lblAlbum.Size = New System.Drawing.Size(61, 20)
        Me.lblAlbum.TabIndex = 23
        Me.lblAlbum.Text = "Álbum"
        '
        'txtAlbum
        '
        Me.txtAlbum.Location = New System.Drawing.Point(1012, 537)
        Me.txtAlbum.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.txtAlbum.Name = "txtAlbum"
        Me.txtAlbum.Size = New System.Drawing.Size(332, 26)
        Me.txtAlbum.TabIndex = 22
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.lstC1)
        Me.TabPage1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage1.Size = New System.Drawing.Size(1406, 785)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Consulta 1"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(989, 328)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(199, 84)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Consulta1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lstC1
        '
        Me.lstC1.FormattingEnabled = True
        Me.lstC1.ItemHeight = 20
        Me.lstC1.Location = New System.Drawing.Point(15, 24)
        Me.lstC1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstC1.Name = "lstC1"
        Me.lstC1.Size = New System.Drawing.Size(832, 664)
        Me.lstC1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.ListBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1406, 785)
        Me.TabPage2.TabIndex = 3
        Me.TabPage2.Text = "Consulta 2"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlText
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(204, 377)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(157, 80)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Consulta2"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(587, 27)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(752, 684)
        Me.ListBox1.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TabPage3.Controls.Add(Me.Button3)
        Me.TabPage3.Controls.Add(Me.ListBox2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1406, 785)
        Me.TabPage3.TabIndex = 4
        Me.TabPage3.Text = "Consulta 3"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(1021, 313)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(196, 88)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Consulta3"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 20
        Me.ListBox2.Location = New System.Drawing.Point(27, 27)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(796, 664)
        Me.ListBox2.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TabPage4.Controls.Add(Me.Button4)
        Me.TabPage4.Controls.Add(Me.ListBox3)
        Me.TabPage4.Location = New System.Drawing.Point(4, 29)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1406, 785)
        Me.TabPage4.TabIndex = 5
        Me.TabPage4.Text = "Consulta 4"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button4.Location = New System.Drawing.Point(160, 361)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(181, 82)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "Consulta4"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 20
        Me.ListBox3.Location = New System.Drawing.Point(521, 41)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(837, 684)
        Me.ListBox3.TabIndex = 0
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TabPage5.Controls.Add(Me.Button5)
        Me.TabPage5.Controls.Add(Me.ListBox4)
        Me.TabPage5.Location = New System.Drawing.Point(4, 29)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(1406, 785)
        Me.TabPage5.TabIndex = 6
        Me.TabPage5.Text = "Consulta 5"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button5.Location = New System.Drawing.Point(980, 355)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(201, 74)
        Me.Button5.TabIndex = 1
        Me.Button5.Text = "Consulta5"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'ListBox4
        '
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.ItemHeight = 20
        Me.ListBox4.Location = New System.Drawing.Point(48, 55)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(758, 664)
        Me.ListBox4.TabIndex = 0
        '
        'ofdRuta
        '
        Me.ofdRuta.FileName = "OpenFileDialog1"
        '
        'Vista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1406, 777)
        Me.Controls.Add(Me.Artistas)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Vista"
        Me.Text = " "
        Me.Artistas.ResumeLayout(False)
        Me.PestañaUsuarios.ResumeLayout(False)
        Me.PestañaUsuarios.PerformLayout()
        Me.PestañaArtistas.ResumeLayout(False)
        Me.PestañaArtistas.PerformLayout()
        CType(Me.PicmostrarImagen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imageArtist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Artistas As TabControl
    Friend WithEvents PestañaUsuarios As TabPage
    Friend WithEvents PestañaArtistas As TabPage
    Friend WithEvents usersList As ListBox
    Friend WithEvents connectButton As Button
    Friend WithEvents selectDBButton As Button
    Friend WithEvents ofdRuta As OpenFileDialog
    Friend WithEvents txtSelectedDB As TextBox
    Friend WithEvents CalendarUsuario As DateTimePicker
    Friend WithEvents txtEmailUsuario As TextBox
    Friend WithEvents txtApellidoUsuario As TextBox
    Friend WithEvents txtNombreUsuario As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblFechaNacimiento As Label
    Friend WithEvents insertUserButton As Button
    Friend WithEvents deleterUserButton As Button
    Friend WithEvents updateUserButton As Button
    Friend WithEvents LimpiarUser As Button
    Friend WithEvents lstAlbumes As ListBox
    Friend WithEvents lstArtistas As ListBox
    Friend WithEvents lbl_cancAlb As Label
    Friend WithEvents lbl_albArt As Label
    Friend WithEvents lbl_art As Label
    Friend WithEvents lstCanciones As ListBox
    Friend WithEvents lblNombreAlbum As Label
    Friend WithEvents txtNombreAlbum As TextBox
    Friend WithEvents lblArtista As Label
    Friend WithEvents txtArtista As TextBox
    Friend WithEvents lblFecha As Label
    Friend WithEvents CalendarAlbum As DateTimePicker

    Friend WithEvents lblIdAlbum As Label
    Friend WithEvents txtIdAlbum As TextBox
    Friend WithEvents cleanupAlbum As Button
    Friend WithEvents deleteAlbum As Button
    Friend WithEvents updateAlbum As Button
    Friend WithEvents insertAlbum As Button

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Tiempo As Timer
    Friend WithEvents lblNombreCancion As Label
    Friend WithEvents txtNombreCancion As TextBox
    Friend WithEvents Tiempo_Duracion As Timer
    Friend WithEvents txtIdCancion As TextBox
    Friend WithEvents txtDuracion As TextBox
    Friend WithEvents lblIdCancion As Label
    Friend WithEvents lblDuracion As Label
    Friend WithEvents limpiarCancionboton As Button
    Friend WithEvents actualizarCancionboton As Button
    Friend WithEvents borrarcancionboton As Button
    Friend WithEvents insertarcancionboton As Button
    Friend WithEvents lblAlbum As Label
    Friend WithEvents txtAlbum As TextBox
    Friend WithEvents updateArtist As Button
    Friend WithEvents insertArtist As Button
    Friend WithEvents cleanArtist As Button
    Friend WithEvents deleteArtist As Button
    Friend WithEvents lblNameArtist As Label
    Friend WithEvents txtArtistCountry As TextBox
    Friend WithEvents txtArtistID As TextBox
    Friend WithEvents txtArtistName As TextBox
    Friend WithEvents lblImageArtist As Label
    Friend WithEvents imageArtist As PictureBox
    Friend WithEvents lblCountryArtist As Label
    Friend WithEvents lblIdArtista As Label
    Friend WithEvents PicmostrarImagen As PictureBox
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents lstC1 As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Button2 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Button3 As Button
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Button4 As Button
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents Button5 As Button
    Friend WithEvents ListBox4 As ListBox
End Class
