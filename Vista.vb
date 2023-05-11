Imports System.Data.SqlClient

Public Class Vista

    Private u As Usuario

    Private Sub UsersList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles usersList.SelectedIndexChanged
        Me.updateUserButton.Enabled = True
        Me.deleterUserButton.Enabled = True
        Me.txtEmailUsuario.Enabled = False
        Me.txtApellidoUsuario.Enabled = True
        Me.txtNombreUsuario.Enabled = True
        Me.CalendarUsuario.Enabled = True
        If Not Me.usersList.SelectedItem Is Nothing Then
            Me.u = New Usuario(Me.usersList.SelectedItem.ToString)
            Try
                Me.u.LeerUsuario()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            Me.txtEmailUsuario.Text = Me.u.Email.ToString
            Me.txtNombreUsuario.Text = Me.u.Nombre.ToString
            Me.txtApellidoUsuario.Text = Me.u.Apellidos.ToString
            Me.CalendarUsuario.Text = Me.u.FechaNacimiento.ToString
        End If
    End Sub

    Private Sub ConnectButton_Click(sender As Object, e As EventArgs) Handles connectButton.Click
        Dim userAux As Usuario
        Dim atAux As Artista
        Dim aAux As Album
        Dim cAux As Cancion

        Me.u = New Usuario
        Me.at = New Artista
        Me.a = New Album
        Me.c = New Cancion

        Try
            Me.u.LeerTodosUsuarios(ofdRuta.FileName)
            Me.at.LeerTodosArtistas(ofdRuta.FileName)
            'Me.c.LeerTodasCanciones(ofdRuta.FileName)
            'Me.a.LeerTodosAlbumes(ofdRuta.FileName)

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        For Each userAux In Me.u.UsDAO.Usuario
            Me.usersList.Items.Add(userAux.Email)
        Next
        For Each atAux In Me.at.AtDAO.Artista
            Me.lstArtistas.Items.Add(atAux.IdArtista)
        Next
        For Each aAux In Me.a.AlbDAO.Album
            Me.lstAlbumes.Items.Add(aAux.IdAlbum)
        Next
        For Each cAux In Me.c.CaDAO.Cancion
            Me.lstCanciones.Items.Add(cAux.IdCancion)
        Next

        connectButton.Enabled = False
        selectDBButton.Enabled = False
        insertUserButton.Enabled = True

    End Sub

    Private Sub SelectDBButton_Click(sender As Object, e As EventArgs) Handles selectDBButton.Click
        Me.ofdRuta.InitialDirectory = Application.StartupPath
        If Me.ofdRuta.ShowDialog() = DialogResult.OK Then
            Me.txtSelectedDB.Text = Me.ofdRuta.FileName
            connectButton.Enabled = True
        End If
    End Sub

    Private Sub InsertUser_Click(sender As Object, e As EventArgs) Handles insertUserButton.Click
        If Me.txtEmailUsuario.Text <> String.Empty And Me.txtNombreUsuario.Text <> String.Empty And Me.txtApellidoUsuario.Text <> String.Empty And Me.lblFechaNacimiento.Text <> String.Empty Then
            u = New Usuario
            u.Email = txtEmailUsuario.Text
            u.Nombre = txtNombreUsuario.Text
            u.Apellidos = txtApellidoUsuario.Text
            u.FechaNacimiento = CalendarUsuario.Text



            Try
                If u.InsertarUsuario() <> 1 Then
                    MessageBox.Show("INSERT return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            Me.usersList.Items.Add(u.Email)
        End If
    End Sub

    Private Sub DeleteUser_Click(sender As Object, e As EventArgs) Handles deleterUserButton.Click
        If Not Me.u Is Nothing Then
            If MessageBox.Show("¿Estás seguro que quieres borrar " & Me.u.Email & "?", "Por favor, confirma", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    If Me.u.BorrarUsuario <> 1 Then
                        MessageBox.Show("DELETE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End Try
                Me.usersList.Items.Remove(u.Email)
            End If
            Me.LimpiarUser.PerformClick()
        End If
    End Sub

    Private Sub UpdateUser_Click(sender As Object, e As EventArgs) Handles updateUserButton.Click
        If Not u Is Nothing Then
            u.Email = txtEmailUsuario.Text
            u.Nombre = txtNombreUsuario.Text
            u.Apellidos = txtApellidoUsuario.Text
            u.FechaNacimiento = CalendarUsuario.Text
            Try
                If u.ActualizarUsuario() <> 1 Then
                    MessageBox.Show("UPDATE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            MessageBox.Show(u.Nombre & " actualizado correctamente!")
        End If
    End Sub

    Private Sub LimpiarUser_Click(sender As Object, e As EventArgs) Handles LimpiarUser.Click
        Me.txtEmailUsuario.Text = String.Empty
        Me.txtNombreUsuario.Text = String.Empty
        Me.txtApellidoUsuario.Text = String.Empty
        Me.lblFechaNacimiento.Text = String.Empty
        Me.updateUserButton.Enabled = False
        Me.deleterUserButton.Enabled = False
        Me.txtEmailUsuario.Enabled = True
    End Sub

    Private Sub TxtSelectedDB_TextChanged(sender As Object, e As EventArgs) Handles txtSelectedDB.TextChanged

    End Sub

    Private Sub PestañaUsuarios_Click(sender As Object, e As EventArgs) Handles PestañaUsuarios.Click

    End Sub

    Private Sub CalendarUsuario_ValueChanged(sender As Object, e As EventArgs) Handles CalendarUsuario.ValueChanged

    End Sub

    Private Sub TxtEmailUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtEmailUsuario.TextChanged

    End Sub

    Private Sub TxtApellidoUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtApellidoUsuario.TextChanged

    End Sub

    Private Sub TxtNombreUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtNombreUsuario.TextChanged

    End Sub

    Private Sub LblNombreUsuario_Click(sender As Object, e As EventArgs) Handles lblNombre.Click

    End Sub

    Private Sub LblApellidoUsuario_Click(sender As Object, e As EventArgs) Handles lblApellido.Click

    End Sub

    Private Sub LblEmailUsuario_Click(sender As Object, e As EventArgs) Handles lblEmail.Click

    End Sub

    Private Sub LblFechaNacimientoUsuario_Click(sender As Object, e As EventArgs) Handles lblFechaNacimiento.Click

    End Sub

    Private Sub Vista_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    '
    '
    'ALBUMES
    '
    '
    Private a As Album

    Private Sub lstAlbumes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAlbumes.SelectedIndexChanged
        Me.updateAlbum.Enabled = True
        Me.deleteAlbum.Enabled = True
        Me.txtIdAlbum.Enabled = True
        Me.txtNombreAlbum.Enabled = True
        Me.CalendarAlbum.Enabled = True
        Me.txtArtista.Enabled = True
        Me.PicmostrarImagen.Enabled = True

        If Not Me.lstAlbumes.SelectedItem Is Nothing Then
            Me.a = New Album(Me.lstAlbumes.SelectedItem.ToString)
            Try
                Me.a.LeerAlbumes()
                Me.c.LeerTodosporAlbumes(ofdRuta.FileName, a.IdAlbum)

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            For Each cAux In Me.c.CaDAO.Cancion
                Me.lstCanciones.Items.Add(cAux.IdCancion)
            Next

            Me.txtIdAlbum.Text = Me.a.IdAlbum.ToString
            Me.txtNombreAlbum.Text = Me.a.NombreAlbum.ToString
            Me.CalendarAlbum.Text = Me.a.Fecha.Date
            Me.txtArtista.Text = Me.a.Artista.ToString
            If Me.a.Portada Is Nothing Then
                'SI la imagen llega vacia entonces -> mostrar imagen generica 
                Me.PicmostrarImagen.Image = Image.FromFile(Environment.CurrentDirectory & "\Imagenes\Albumes\generica.jpg")
            Else
                'SI NO -> la imagen del artista
                Me.PicmostrarImagen.Image = Image.FromFile(Environment.CurrentDirectory & "\Imagenes\Albumes\" & Me.a.Portada.ToString)


            End If
        End If
    End Sub
    Private Sub PicmostrarImagen_Click(sender As Object, e As EventArgs) Handles PicmostrarImagen.Click

    End Sub

    Private Sub txtSelectAlbum_TextChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub PestañaArtistas_Click(sender As Object, e As EventArgs) Handles PestañaArtistas.Click

    End Sub

    Private Sub CalendarAlbum_ValueChanged(sender As Object, e As EventArgs) Handles CalendarAlbum.ValueChanged

    End Sub
    Private Sub lblFecha_Click(sender As Object, e As EventArgs) Handles lblFecha.Click

    End Sub
    Private Sub txtNombreAlbum_TextChanged(sender As Object, e As EventArgs) Handles txtNombreAlbum.TextChanged

    End Sub
    Private Sub lblNombreAlbum_Click(sender As Object, e As EventArgs) Handles lblNombreAlbum.Click

    End Sub
    Private Sub txtArtista_TextChanged(sender As Object, e As EventArgs) Handles txtArtista.TextChanged

    End Sub
    Private Sub lblArtista_Click(sender As Object, e As EventArgs) Handles lblArtista.Click

    End Sub
    Private Sub txtIdAlbum_TextChanged(sender As Object, e As EventArgs) Handles txtIdAlbum.TextChanged

    End Sub
    Private Sub lblIdAlbum_Click(sender As Object, e As EventArgs) Handles lblIdAlbum.Click

    End Sub
    Private Sub insertAlbum_Click(sender As Object, e As EventArgs) Handles insertAlbum.Click
        If Me.txtIdAlbum.Text <> String.Empty And Me.txtNombreAlbum.Text <> String.Empty And Me.CalendarAlbum.Text <> String.Empty And Me.txtArtista.Text <> String.Empty And Me.PicmostrarImagen.Text <> String.Empty Then

            a = New Album
            a.IdAlbum = txtIdAlbum.Text
            a.NombreAlbum = txtNombreAlbum.Text
            a.Fecha = CalendarAlbum.Text
            a.Artista = txtArtista.Text
            a.Portada = PicmostrarImagen.Text

            Try
                If a.InsertarAlbum() <> 1 Then
                    MessageBox.Show("INSERT return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            Me.lstAlbumes.Items.Add(a.IdAlbum)
        End If

    End Sub

    Private Sub deleteAlbum_Click(sender As Object, e As EventArgs) Handles deleteAlbum.Click
        If Not Me.a Is Nothing Then
            If MessageBox.Show("¿Estás seguro que quieres borrar " & Me.a.IdAlbum & "?", "Por favor, confirma", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    If Me.a.BorrarAlbum <> 1 Then
                        MessageBox.Show("DELETE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End Try
                Me.lstAlbumes.Items.Remove(a.IdAlbum)
            End If
            Me.cleanupAlbum.PerformClick()
        End If
    End Sub

    Private Sub updateAlbum_Click(sender As Object, e As EventArgs) Handles updateAlbum.Click
        If Not a Is Nothing Then
            a.IdAlbum = txtIdAlbum.Text
            a.NombreAlbum = txtNombreAlbum.Text
            a.Fecha = CalendarAlbum.Text
            a.Artista = txtArtista.Text
            a.Portada = PicmostrarImagen.Text

            Try
                If a.ActualizarAlbum() <> 1 Then
                    MessageBox.Show("UPDATE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            MessageBox.Show(a.NombreAlbum & " actualizado correctamente!")
        End If
    End Sub


    Private Sub cleanupAlbum_Click(sender As Object, e As EventArgs) Handles cleanupAlbum.Click

        Me.txtIdAlbum.Text = String.Empty
        Me.txtNombreAlbum.Text = String.Empty
        Me.CalendarAlbum.Text = String.Empty
        Me.txtArtista.Text = String.Empty
        Me.PicmostrarImagen.Text = String.Empty
        Me.updateAlbum.Enabled = False
        Me.deleteAlbum.Enabled = False
        Me.txtIdAlbum.Enabled = True

    End Sub

    '
    '
    'CANCIONES
    '
    '
    Private c As Cancion

    Private Sub lstCanciones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCanciones.SelectedIndexChanged
        Me.actualizarCancionboton.Enabled = True   'Button5 es Actualizar_cancion
        Me.borrarcancionboton.Enabled = True   'Button6 es Borrar_cancion
        Me.txtIdCancion.Enabled = True
        Me.txtNombreCancion.Enabled = True
        Me.txtAlbum.Enabled = True
        Me.txtDuracion.Enabled = True

        If Not Me.lstCanciones.SelectedItem Is Nothing Then
            Me.c = New Cancion(Me.lstCanciones.SelectedItem.ToString)
            Try
                Me.c.LeerCancion()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            Me.txtIdCancion.Text = Me.c.IdCancion.ToString
            Me.txtNombreCancion.Text = Me.c.NombreCancion.ToString
            Me.txtAlbum.Text = Me.c.Album.ToString
            Me.txtDuracion.Text = Me.c.Duracion.ToString

        End If
    End Sub

    Private Sub txtNombreCancion_TextChanged(sender As Object, e As EventArgs) Handles txtNombreCancion.TextChanged

    End Sub
    Private Sub txtIdCancion_TextChanged(sender As Object, e As EventArgs) Handles txtIdCancion.TextChanged

    End Sub
    Private Sub txtDuracion_TextChanged(sender As Object, e As EventArgs) Handles txtDuracion.TextChanged

    End Sub
    Private Sub txtAlbum_TextChanged(sender As Object, e As EventArgs) Handles txtAlbum.TextChanged

    End Sub
    Private Sub lblNombreCancion_Click(sender As Object, e As EventArgs) Handles lblNombreCancion.Click

    End Sub
    Private Sub lblIdCancion_Click(sender As Object, e As EventArgs) Handles lblIdCancion.Click

    End Sub
    Private Sub lblDuracion_Click(sender As Object, e As EventArgs) Handles lblDuracion.Click

    End Sub
    Private Sub lblAlbum_Click(sender As Object, e As EventArgs) Handles lblAlbum.Click

    End Sub


    Private Sub InsertarCancion_Click(sender As Object, e As EventArgs) Handles insertarcancionboton.Click
        If txtIdCancion.Text <> String.Empty And txtNombreCancion.Text <> String.Empty And txtAlbum.Text <> String.Empty And txtDuracion.Text <> String.Empty Then

            c = New Cancion
            c.IdCancion = txtIdCancion.Text
            c.NombreCancion = txtNombreCancion.Text
            c.Album = txtAlbum.Text
            c.Duracion = txtDuracion.Text

            Try
                If c.InsertarCancion() <> 1 Then
                    MessageBox.Show("INSERT return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            Me.lstCanciones.Items.Add(c.IdCancion)
        End If
    End Sub
    Private Sub Borrar_cancion_Click(sender As Object, e As EventArgs) Handles borrarcancionboton.Click
        If Not Me.c Is Nothing Then
            If MessageBox.Show("¿Estás seguro que quieres borrar " & Me.c.IdCancion & "?", "Por favor, confirma", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    If Me.c.BorrarCancion <> 1 Then
                        MessageBox.Show("DELETE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End Try
                Me.lstCanciones.Items.Remove(c.IdCancion)
            End If
            Me.limpiarCancionboton.PerformClick()
        End If
    End Sub
    Private Sub Actualizar_cancion_Click(sender As Object, e As EventArgs) Handles actualizarCancionboton.Click
        If Not c Is Nothing Then

            c.IdCancion = txtIdCancion.Text
            c.NombreCancion = txtNombreCancion.Text
            c.Album = txtAlbum.Text
            c.Duracion = txtDuracion.Text

            Try
                If c.ActualizarCancion() <> 1 Then
                    MessageBox.Show("UPDATE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            MessageBox.Show(c.NombreCancion & " actualizado correctamente!")
        End If
    End Sub
    Private Sub Limpiar_cancion_Click(sender As Object, e As EventArgs) Handles limpiarCancionboton.Click
        txtIdCancion.Text = String.Empty
        txtNombreCancion.Text = String.Empty
        txtAlbum.Text = String.Empty
        txtDuracion.Text = String.Empty
        borrarcancionboton.Enabled = False
        actualizarCancionboton.Enabled = False
        txtIdCancion.Enabled = True
    End Sub

    Private Sub txtSelectCancionDB_TextChanged(sender As Object, e As EventArgs)

    End Sub
    '
    '
    'ARTISTAS
    '
    '
    Private at As Artista


    Private Sub LstArtistas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstArtistas.SelectedIndexChanged
        Me.updateArtist.Enabled = True
        Me.deleteArtist.Enabled = True
        Me.txtArtistID.Enabled = True
        Me.txtArtistName.Enabled = True
        Me.txtArtistCountry.Enabled = True
        Me.imageArtist.Enabled = True

        If Not Me.lstArtistas.SelectedItem Is Nothing Then
            Me.at = New Artista(Me.lstArtistas.SelectedItem.ToString)
            Try
                Me.at.LeerArtistas()
                Me.a.LeerTodosporArtistas(ofdRuta.FileName, at.IdArtista)

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            For Each aAux In Me.a.AlbDAO.Album
                Me.lstAlbumes.Items.Add(aAux.IdAlbum)

            Next

            Me.txtArtistID.Text = Me.at.IdArtista.ToString
            Me.txtArtistName.Text = Me.at.Nombre.ToString
            Me.txtArtistCountry.Text = Me.at.Pais.ToString
            If Me.at.Imagen Is Nothing Then
                'SI la imagen llega vacia entonces -> mostrar imagen generica 
                Me.imageArtist.Image = Image.FromFile(Environment.CurrentDirectory & "\Imagenes\Artistas\generica.jpg")
            Else
                'SI NO -> la imagen del artista
                Me.imageArtist.Image = Image.FromFile(Environment.CurrentDirectory & "\Imagenes\Artistas\" & Me.at.Imagen.ToString)


            End If
        End If
    End Sub

    Private Sub updateArtist_Click(sender As Object, e As EventArgs) Handles updateArtist.Click
        If Not at Is Nothing Then
            at.IdArtista = txtArtistID.Text
            at.Nombre = txtArtistName.Text
            at.Pais = txtArtistCountry.Text
            at.Imagen = imageArtist.Text
            Try
                If at.ActualizarArtista() <> 1 Then
                    MessageBox.Show("UPDATE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            MessageBox.Show(at.Nombre & " actualizado correctamente!")
        End If
    End Sub

    Private Sub deleteArtist_Click(sender As Object, e As EventArgs) Handles deleteArtist.Click
        If Not Me.at Is Nothing Then
            If MessageBox.Show("¿Estás seguro que quieres borrar " & Me.at.IdArtista & "?", "Por favor, confirma", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    If Me.at.BorrarArtista <> 1 Then
                        MessageBox.Show("DELETE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End Try
                Me.lstArtistas.Items.Remove(at.IdArtista)
            End If
            Me.cleanArtist.PerformClick()
        End If
    End Sub

    Private Sub cleanArtist_Click(sender As Object, e As EventArgs) Handles cleanArtist.Click

        Me.txtArtistID.Text = String.Empty
        Me.txtArtistName.Text = String.Empty
        Me.txtArtistCountry.Text = String.Empty
        Me.imageArtist.Text = String.Empty
        Me.updateUserButton.Enabled = False
        Me.deleterUserButton.Enabled = False
        Me.txtArtistID.Enabled = True
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblNameArtist.Click

    End Sub

    Private Sub txtArtistName_TextChanged(sender As Object, e As EventArgs) Handles txtArtistName.TextChanged

    End Sub

    Private Sub imageArtist_Click(sender As Object, e As EventArgs) Handles imageArtist.Click

    End Sub
    Private Sub txtselectArtista_TextChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub insertArtist_Click(sender As Object, e As EventArgs) Handles insertArtist.Click
        If Me.txtArtistID.Text <> String.Empty And Me.txtArtistName.Text <> String.Empty And Me.txtArtistCountry.Text <> String.Empty And Me.imageArtist.Text <> String.Empty Then

            at = New Artista
            at.IdArtista = txtArtistID.Text
            at.Nombre = txtArtistName.Text
            at.Pais = txtArtistCountry.Text
            at.Imagen = imageArtist.Text


            Try
                If at.InsertarArtista() <> 1 Then
                    MessageBox.Show("INSERT return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            Me.lstArtistas.Items.Add(at.IdArtista)
        End If
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs)

    End Sub
    Private Sub lbl_art_Click(sender As Object, e As EventArgs) Handles lbl_art.Click

    End Sub

    Private Sub lbl_albArt_Click(sender As Object, e As EventArgs) Handles lbl_albArt.Click

    End Sub

    Private Sub lbl_cancAlb_Click(sender As Object, e As EventArgs) Handles lbl_cancAlb.Click

    End Sub

    Private Sub lblImageArtist_Click(sender As Object, e As EventArgs) Handles lblImageArtist.Click

    End Sub
    '
    '
    '
    'CONSULTA 1
    '
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim atAux As Artista
        Dim artista As Artista = New Artista
        Try
            lstC1.Items.Clear()
            Me.at.ArtistasFiltradosPorPais(ofdRuta.FileName)
            For Each atAux In artista.ArtistasFiltradosPorPais(ofdRuta.FileName)
                lstC1.Items.Add(atAux.IdArtista)
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try

    End Sub

    Private Sub lstC1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstC1.SelectedIndexChanged
        If Not Me.lstC1.SelectedItem Is Nothing Then
            Me.at = New Artista(Me.lstC1.SelectedItem.ToString)
            Try
                Me.at.ArtistasFiltradosPorPais(ofdRuta.FileName)
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
        End If
    End Sub

    '
    'CONSULTA 2
    '
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If Not Me.ListBox1.SelectedItem Is Nothing Then
            Me.c = New Cancion(Me.ListBox1.SelectedItem.ToString)
            Try
                Me.c.CancionesOrdenadas(ofdRuta.FileName)
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cAux As Cancion
        Dim cancion As Cancion = New Cancion
        Try
            ListBox1.Items.Clear()
            Me.c.CancionesOrdenadas(ofdRuta.FileName)
            For Each cAux In cancion.CancionesOrdenadas(ofdRuta.FileName)
                ListBox1.Items.Add(cAux.IdCancion)
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try

    End Sub


    '
    'CONSULTA 3
    'Esta consulta se encuentra en la Base de Datos, pero no esta implementada en Visual (por falta de tiempo)
    '
    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub


    '
    'CONSULTA 4 
    '
    Private Sub ListBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox3.SelectedIndexChanged
        If Not Me.ListBox3.SelectedItem Is Nothing Then
            Me.u = New Usuario(Me.ListBox3.SelectedItem.ToString)
            Try
                Me.u.OrdenadoPorTiempo()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim uAux As Usuario
        Dim usuario As Usuario = New Usuario
        Try
            ListBox3.Items.Clear()
            Me.u.OrdenadoPorTiempo(ofdRuta.FileName)
            For Each uAux In usuario.OrdenadoPorTiempo(ofdRuta.FileName)
                ListBox3.Items.Add(uAux.Email)
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        connectButton.Enabled = False
    End Sub

    '
    'CONSULTA 5
    '
    Private Sub ListBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox4.SelectedIndexChanged
        If Not Me.ListBox4.SelectedItem Is Nothing Then
            Me.u = New Usuario(Me.ListBox4.SelectedItem.ToString)
            Try
                Me.u.TiempoArtistaFavorito()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim uAux As Usuario
        Dim usuario As Usuario = New Usuario
        Try
            ListBox4.Items.Clear()
            Me.u.TiempoArtistaFavorito(ofdRuta.FileName)
            For Each uAux In usuario.TiempoArtistaFavorito(ofdRuta.FileName)
                ListBox4.Items.Add(uAux.Email)
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
    End Sub

End Class
