Imports MySql.Data.MySqlClient
Imports Capa_Entidades
Imports System.Drawing
Imports System.IO

Public Class Dato_Usuario
    Public Sub cambiarEstadoPorCedula(cedula As String, activo As Boolean)

        ' Conexión a la base de datos
        Using conn As New MySqlConnection(InformacionDeConexion.direccionDeConexion)
            ' Comando para ejecutar el procedimiento almacenado
            Using cmd As New MySqlCommand("cambiarEstadoPorCedula", conn)
                cmd.CommandType = CommandType.StoredProcedure
                ' Agregar parámetros al procedimiento almacenado
                cmd.Parameters.AddWithValue("cedula_param", cedula)
                cmd.Parameters.AddWithValue("activo_param", activo)
                conn.Open()
                ' Ejecutar el comando
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub



    Public Function traerPorCedulaYContrasena(cedula As String, contrasena As String) As Entidad_Usuario
        Dim usuario As Entidad_Usuario = Nothing

        ' Conexión a la base de datos
        Using conn As New MySqlConnection(InformacionDeConexion.direccionDeConexion)
            ' Comando para ejecutar el procedimiento almacenado
            Using cmd As New MySqlCommand("traerPorCedulaYContrasena", conn)
                cmd.CommandType = CommandType.StoredProcedure
                ' Agregando parámetros al procedimiento almacenado
                cmd.Parameters.AddWithValue("cedula_param", cedula)
                cmd.Parameters.AddWithValue("contrasena_param", contrasena)
                conn.Open()
                ' Ejecución del comando y lectura del resultado
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        ' Mapeo de los datos del lector a la entidad
                        Dim id As Integer = reader.GetInt32(0)
                        Dim nombres As String = reader.GetString(1)
                        Dim apellidos As String = reader.GetString(2)
                        Dim rol As String = reader.GetString(4)
                        Dim cedulaR As String = reader.GetString(3)
                        Dim contrasenaR As String = reader.GetString(5)
                        Dim sexo As Char = reader.GetChar(6)
                        Dim nacimiento As Date = reader.GetDateTime(7)
                        Dim direccion As String = reader.GetString(8)
                        Dim foto As Byte() = CType(reader("foto"), Byte())
                        Dim activo As Boolean = reader.GetBoolean(10)


                        Dim eRol As ERoles = CType([Enum].Parse(GetType(ERoles), rol), ERoles)

                        usuario = New Entidad_Usuario(id, nombres, apellidos, cedulaR, eRol, contrasenaR, sexo, nacimiento, direccion, ByteArrayToImage(foto), activo)

                    End If
                End Using
            End Using
        End Using

        Return usuario
    End Function


    Public Function traerPorCedula(cedula As String) As Entidad_Usuario
        Dim usuario As Entidad_Usuario = Nothing
        Dim query As String = "SELECT * FROM vistaUsuariosCamposEnOrden WHERE cedula = @cedula"

        ' Conexión a la base de datos
        Using conn As New MySqlConnection(InformacionDeConexion.direccionDeConexion)
            ' Comando para ejecutar la consulta
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@cedula", cedula)
                conn.Open()
                ' Ejecución del comando y lectura del resultado
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        ' Mapeo de los datos del lector a la entidad
                        Dim id As Integer = reader.GetInt32(0)
                        Dim nombres As String = reader.GetString(1)
                        Dim apellidos As String = reader.GetString(2)
                        Dim rol As String = reader.GetString(4)
                        Dim cedulaR As String = reader.GetString(3)
                        Dim contrasenaR As String = reader.GetString(5)
                        Dim sexo As Char = reader.GetChar(6)
                        Dim nacimiento As Date = reader.GetDateTime(7)
                        Dim direccion As String = reader.GetString(8)
                        Dim foto As Byte() = CType(reader("foto"), Byte())
                        Dim activo As Boolean = reader.GetBoolean(10)

                        Dim eRol As ERoles = CType([Enum].Parse(GetType(ERoles), rol), ERoles)

                        usuario = New Entidad_Usuario(id, nombres, apellidos, cedulaR, eRol, contrasenaR, sexo, nacimiento, direccion, ByteArrayToImage(foto), activo)
                    End If
                End Using
            End Using
        End Using

        Return usuario
    End Function



    Public Function traerPorId(id As Integer) As Entidad_Usuario
        Dim usuario As Entidad_Usuario = Nothing
        Dim query As String = "SELECT * FROM vistaUsuariosCamposEnOrden WHERE id = @id"

        ' Conexión a la base de datos
        Using conn As New MySqlConnection(InformacionDeConexion.direccionDeConexion)
            ' Comando para ejecutar la consulta
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", id)
                conn.Open()
                ' Ejecución del comando y lectura del resultado
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        ' Mapeo de los datos del lector a la entidad
                        Dim idR As Integer = reader.GetInt32(0)
                        Dim nombres As String = reader.GetString(1)
                        Dim apellidos As String = reader.GetString(2)
                        Dim rol As String = reader.GetString(4)
                        Dim cedula As String = reader.GetString(3)
                        Dim contrasena As String = reader.GetString(5)
                        Dim sexo As Char = reader.GetChar(6)
                        Dim nacimiento As Date = reader.GetDateTime(7)
                        Dim direccion As String = reader.GetString(8)
                        Dim foto As Byte() = CType(reader("foto"), Byte())
                        Dim activo As Boolean = reader.GetBoolean(10)

                        Dim eRol As ERoles = CType([Enum].Parse(GetType(ERoles), rol), ERoles)

                        usuario = New Entidad_Usuario(idR, nombres, apellidos, cedula, eRol, contrasena, sexo, nacimiento, direccion, ByteArrayToImage(foto), activo)
                    End If
                End Using
            End Using
        End Using

        Return usuario
    End Function

    Public Function crear(usuario As Entidad_Usuario) As Boolean
        Dim creado As Boolean = False

        ' Conexión a la base de datos
        Using conn As New MySqlConnection(InformacionDeConexion.direccionDeConexion)
            ' Comando para ejecutar el procedimiento almacenado
            Using cmd As New MySqlCommand("crearUsuario", conn)
                cmd.CommandType = CommandType.StoredProcedure
                ' Agregando parámetros al procedimiento almacenado
                cmd.Parameters.AddWithValue("nombres_param", usuario.Nombres)
                cmd.Parameters.AddWithValue("apellidos_param", usuario.Apellidos)
                cmd.Parameters.AddWithValue("cedula_param", usuario.Cedula)
                cmd.Parameters.AddWithValue("contrasena_param", usuario.Contrasena)
                cmd.Parameters.AddWithValue("sexo_param", usuario.Sexo)
                cmd.Parameters.AddWithValue("nacimiento_param", usuario.Nacimiento)
                cmd.Parameters.AddWithValue("direccion_param", usuario.Direccion)
                cmd.Parameters.AddWithValue("foto_param", ImageToByteArray(usuario.Foto))
                cmd.Parameters.AddWithValue("activo_param", usuario.Activo)
                cmd.Parameters.AddWithValue("rol_param", usuario.Rol.ToString())
                conn.Open()

                ' Ejecuta el comando y verifica si se creó correctamente
                creado = (cmd.ExecuteNonQuery() > 0)
            End Using
        End Using

        Return creado
    End Function

    Public Sub actualizar(usuario As Entidad_Usuario)


        ' Conexión a la base de datos
        Using conn As New MySqlConnection(InformacionDeConexion.direccionDeConexion)
            ' Comando para ejecutar el procedimiento almacenado
            Using cmd As New MySqlCommand("actualizarUsuario", conn)
                cmd.CommandType = CommandType.StoredProcedure
                ' Agregando parámetros al procedimiento almacenado
                cmd.Parameters.AddWithValue("nombres_param", usuario.Nombres)
                cmd.Parameters.AddWithValue("apellidos_param", usuario.Apellidos)
                cmd.Parameters.AddWithValue("cedula_param", usuario.Cedula)
                cmd.Parameters.AddWithValue("contrasena_param", usuario.Contrasena)
                cmd.Parameters.AddWithValue("sexo_param", usuario.Sexo)
                cmd.Parameters.AddWithValue("nacimiento_param", usuario.Nacimiento)
                cmd.Parameters.AddWithValue("direccion_param", usuario.Direccion)
                cmd.Parameters.AddWithValue("foto_param", ImageToByteArray(usuario.Foto))
                cmd.Parameters.AddWithValue("activo_param", usuario.Activo)
                cmd.Parameters.AddWithValue("rol_param", usuario.Rol.ToString())
                conn.Open()

                ' Ejecuta el comando
                cmd.ExecuteNonQuery()
            End Using
        End Using

    End Sub

    '
    Public Function existePorCedula(cedula As String) As Boolean
        Dim existe As Boolean = False

        ' Conexión a la base de datos
        Using conn As New MySqlConnection(InformacionDeConexion.direccionDeConexion)
            ' Comando para ejecutar el procedimiento almacenado
            Using cmd As New MySqlCommand("existePorCedula", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("cedula_param", cedula)
                conn.Open()
                ' Ejecuta el comando y obtiene el resultado
                existe = (CInt(cmd.ExecuteScalar()) > 0)
            End Using
        End Using

        Return existe
    End Function

    Public Function existePorId(id As Integer) As Boolean
        Dim existe As Boolean = False

        ' Conexión a la base de datos
        Using conn As New MySqlConnection(InformacionDeConexion.direccionDeConexion)
            ' Comando para ejecutar el procedimiento almacenado
            Using cmd As New MySqlCommand("existePorId", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("id_param", id)
                conn.Open()
                ' Ejecuta el comando y obtiene el resultado
                existe = (CInt(cmd.ExecuteScalar()) > 0)
            End Using
        End Using

        Return existe
    End Function



    Public Function listarTipoDeUsuario(eRol As ERoles) As HashSet(Of Entidad_Usuario)
        Dim usuarios As New HashSet(Of Entidad_Usuario)
        Dim query As String = "SELECT * FROM vistaUsuariosCamposEnOrden WHERE LOWER(rol) = @rol"

        ' Conexión a la base de datos
        Using conn As New MySqlConnection(InformacionDeConexion.direccionDeConexion)
            ' Comando para ejecutar la consulta
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@rol", eRol.ToString().ToLower())
                conn.Open()
                ' Ejecución del comando y lectura de resultados
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        ' Mapeo de los datos del lector a la entidad
                        Dim id As Integer = reader.GetInt32(0)
                        Dim nombres As String = reader.GetString(1)
                        Dim apellidos As String = reader.GetString(2)
                        Dim cedula As String = reader.GetString(3)
                        Dim rol As String = reader.GetString(4)
                        Dim contrasena As String = reader.GetString(5)
                        Dim sexo As Char = reader.GetChar(6)
                        Dim nacimiento As Date = reader.GetDateTime(7)
                        Dim direccion As String = reader.GetString(8)
                        Dim foto As Byte() = CType(reader("foto"), Byte())
                        Dim activo As Boolean = reader.GetBoolean(10)

                        Dim usuario As New Entidad_Usuario(
                            id,
                            nombres,
                            apellidos,
                            cedula,
                            eRol,
                            contrasena,
                            sexo,
                            nacimiento,
                            direccion,
                            ByteArrayToImage(foto),
                            activo
                            )
                        usuarios.Add(usuario)
                    End While
                End Using
            End Using
        End Using

        Return usuarios
    End Function

    Public Function listarTodos() As List(Of Entidad_Usuario)
        Dim usuarios As New List(Of Entidad_Usuario)
        Dim query As String = "SELECT * FROM vistaUsuariosCamposEnOrden"

        ' Conexión a la base de datos
        Using conn As New MySqlConnection(InformacionDeConexion.direccionDeConexion)
            ' Comando para ejecutar la consulta
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                ' Ejecución del comando y lectura de resultados
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        ' Mapeo de los datos del lector a la entidad
                        Dim id As Integer = reader.GetInt32(0)
                        Dim nombres As String = reader.GetString(1)
                        Dim apellidos As String = reader.GetString(2)
                        Dim cedula As String = reader.GetString(3)
                        Dim rol As String = reader.GetString(4)
                        Dim contrasena As String = reader.GetString(5)
                        Dim sexo As Char = reader.GetChar(6)
                        Dim nacimiento As Date = reader.GetDateTime(7)
                        Dim direccion As String = reader.GetString(8)
                        Dim foto As Byte() = CType(reader("foto"), Byte())
                        Dim activo As Boolean = reader.GetBoolean(10)

                        Dim eRol As ERoles = CType([Enum].Parse(GetType(ERoles), rol), ERoles)

                        Dim usuario As New Entidad_Usuario(
                            id,
                            nombres,
                            apellidos,
                            cedula,
                            eRol,
                            contrasena,
                            sexo,
                            nacimiento,
                            direccion,
                            ByteArrayToImage(foto),
                            activo
                            )
                        usuarios.Add(usuario)
                    End While
                End Using
            End Using
        End Using

        Return usuarios
    End Function

    Public Function listarTodosDataSet() As DataSet
        Dim ds As New DataSet()

        Using cnn As New MySqlConnection(InformacionDeConexion.direccionDeConexion)
            cnn.Open()
            Try
                Dim cmd As New MySqlCommand("SELECT * FROM vistaUsuariosCamposEnOrden", cnn)
                Dim adapter As New MySqlDataAdapter(cmd)
                adapter.Fill(ds, "estudiantes")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using


        Return ds

    End Function

    Public Function listarActivosDataSet() As DataSet
        Dim ds As New DataSet()

        Using cnn As New MySqlConnection(InformacionDeConexion.direccionDeConexion)
            cnn.Open()
            Try
                Dim cmd As New MySqlCommand("SELECT * FROM vistaUsuariosCamposEnOrden where activo = TRUE", cnn)
                Dim adapter As New MySqlDataAdapter(cmd)
                adapter.Fill(ds, "estudiantes")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using


        Return ds
    End Function

    Public Function listarInactivosDataSet() As DataSet
        Dim ds As New DataSet()

        Using cnn As New MySqlConnection(InformacionDeConexion.direccionDeConexion)
            cnn.Open()
            Try
                Dim cmd As New MySqlCommand("SELECT * FROM vistaUsuariosCamposEnOrden where activo = FALSE", cnn)
                Dim adapter As New MySqlDataAdapter(cmd)
                adapter.Fill(ds, "estudiantes")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using


        Return ds
    End Function

    Public Function ByteArrayToImage(byteArray As Byte()) As Image
        If byteArray.Length <= 2 Then
            Return Nothing
        End If

        Using ms As New MemoryStream(byteArray)
            Return Image.FromStream(ms)
        End Using
    End Function

    Public Function ImageToByteArray(image As Image) As Byte()
        Using ms As New MemoryStream()
            image.Save(ms, image.RawFormat)
            Return ms.ToArray()
        End Using
    End Function


End Class