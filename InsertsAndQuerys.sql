--select * from usuario

--insert into rol (Descripcion) values ('Administrador')

--insert into rol (Descripcion) values ('Empleado')

--insert into usuario (Documento,NombreCompleto,Correo,Clave,IdRol,Estado) 
--values ('12345678','ADMIN','ADMIN@gmail.com','Adm123',1,1)

--insert into usuario (Documento,NombreCompleto,Correo,Clave,IdRol,Estado) 
--values ('87654321','EMPLEADO','EMPLEADO@gmail.com','Emp123',2,1)

--select * from rol

--select * from permiso

--insert into Permiso(IdRol,NombreMenu) values 
--(1,'menuusuarios'),
--(1,'menumantenedor'),
--(1,'menuventas'),
--(1,'menucompras'),
--(1,'menuclientes'),
--(1,'menuproveedores'),
--(1,'menureportes'),
--(1,'menuacercade')

--insert into Permiso(IdRol,NombreMenu) values 
--(2,'menuventas'),
--(2,'menucompras'),
--(2,'menuclientes'),
--(2,'menuproveedores'),
--(2,'menuacercade')

--select p.IdRol,p.NombreMenu 
--from PERMISO p inner join ROL r on r.IdRol = p.IdRol 
--inner join USUARIO u on u.IdRol = r.IdRol
--where u.IdUsuario = 1


--select u.IdUsuario,u.Documento,NombreCompleto,
--u.Correo,u.Clave,u.Estado,r.IdRol,r.Descripcion
--from Usuario u inner join Rol r on u.IdRol = r.IdRol 

--CREATE PROC SP_REGISTRARUSUARIO(
--@Documento varchar(50),
--@NobreCompleto varchar(100),
--@Correo varchar(100),
--@Clave varchar(100),
--@IdRol int,
--@Estado bit,
--@IdUsuarioResultado int output,
--@Mensaje varchar(500) output
--)
--as
--begin
--	set @IdUsuarioResultado = 0
--	set @Mensaje = ''

--	if not exists(select * from USUARIO where Documento = @Documento)
--	begin
--		insert into USUARIO(Documento,NombreCompleto,Correo,Clave,IdRol,Estado) values
--		(@Documento,@NobreCompleto,@Correo,@Clave,@IdRol,@Estado)

--		set @IdUsuarioResultado = SCOPE_IDENTITY()	
--	end
--	else
--		set @Mensaje = 'No se puede repetir el documento para más de un usuario.'
--end

--GO

--declare @idusuariogenerado int
--declare @mensaje varchar(500)

--exec SP_REGISTRARUSUARIO '12345678', 'Pruebas', 'test@gmail.com', 'Test123', 2, 1, @idusuariogenerado output, @mensaje output

--select @idusuariogenerado

--select @mensaje

--GO

--CREATE PROC SP_EDITARUSUARIO(
--@IdUsuario int,
--@Documento varchar(50),
--@NobreCompleto varchar(100),
--@Correo varchar(100),
--@Clave varchar(100),
--@IdRol int,
--@Estado bit,
--@Respuesta bit output,
--@Mensaje varchar(500) output
--)
--as
--begin
--	set @Respuesta = 0
--	set @Mensaje = ''

--	if not exists(select * from USUARIO where Documento = @Documento and idusuario !=@IdUsuario)
--	begin
--		update USUARIO set
--		Documento = @Documento,
--		NombreCompleto = @NobreCompleto,
--		Correo = @Correo,
--		Clave = @Clave,
--		IdRol = @IdRol,
--		Estado = @Estado
--		where IdUsuario = @IdUsuario

--		set @Respuesta = 1
--	end
--	else
--		set @Mensaje = 'No se puede repetir el documento para más de un usuario.'
--end

--GO

--declare @respuesta bit
--declare @mensaje varchar(500)

--exec SP_EDITARUSUARIO 2, '12345678', 'Pruebas', 'test@gmail.com', 'Test123', 2, 1, @respuesta output, @mensaje output

--select @respuesta

--select @mensaje

--GO

