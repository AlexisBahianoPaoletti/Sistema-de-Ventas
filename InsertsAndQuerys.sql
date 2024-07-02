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

--CREATE PROC SP_ELIMINARUSUARIO(
--@IdUsuario int,
--@Respuesta bit output,
--@Mensaje varchar(500) output
--)
--as
--begin
--	set @Respuesta = 0
--	set @Mensaje = ''
--	declare @pasoreglas bit = 1

--	if exists (select * from COMPRA c
--	inner join USUARIO u on u.IdUsuario = c.IdUsuario
--	where u.IdUsuario = @IdUsuario
--	)
--	begin
--		set @pasoreglas = 0
--		set @Respuesta = 0
--		set @Mensaje = @Mensaje + 'No se puede eliminar porque el usuario se encuentra relacionado a una compra\n'
--	end

--	if exists (select * from VENTA v
--	inner join USUARIO u on u.IdUsuario = v.IdUsuario
--	where u.IdUsuario = @IdUsuario
--	)
--	begin
--		set @pasoreglas = 0
--		set @Respuesta = 0
--		set @Mensaje = @Mensaje + 'No se puede eliminar porque el usuario se encuentra relacionado a una venta\n'
--	end

--	if(@pasoreglas = 1)
--	begin
--		delete from USUARIO where IdUsuario = @IdUsuario
--		set @Respuesta = 1
--	end
--end

--GO

--CREATE PROC SP_RegistrarCategoria(
--@Descripcion varchar(50),
--@Estado bit,
--@Resultado int output,
--@Mensaje varchar(500) output
--)as
--begin
--	SET @Resultado = 0
--	IF NOT EXISTS (select * from CATEGORIA where Descripcion = @Descripcion)
--	begin
--		insert into CATEGORIA(Descripcion,Estado) values (@Descripcion,@Estado)
--		set @Resultado = SCOPE_IDENTITY()
--	end
--	ELSE
--		set @Mensaje = 'No se puede repetir la descripción de una categoría.'
--end

--GO

--CREATE PROC SP_EditarCategoria(
--@IdCategoria int,
--@Descripcion varchar(50),
--@Estado bit,
--@Resultado bit output,
--@Mensaje varchar(500) output
--)as
--begin
--	SET @Resultado = 1
--	IF NOT EXISTS (select * from CATEGORIA where Descripcion = @Descripcion and IdCategoria != @IdCategoria)
--		Update CATEGORIA set Descripcion = @Descripcion, Estado = @Estado where IdCategoria = @IdCategoria
--	ELSE
--	begin
--		set @Resultado = 0
--		set @Mensaje = 'No se puede repetir la descripción de una categoría.'
--	end
--end

--GO

--CREATE PROC SP_EliminarCategoria(
--@IdCategoria int,
--@Resultado bit output,
--@Mensaje varchar(500) output
--)as
--begin
--	SET @Resultado = 1
--	IF NOT EXISTS (
--	select * from CATEGORIA c inner join PRODUCTO p on p.IdCategoria = c.IdCategoria
--	where c.IdCategoria = @IdCategoria)
--	begin
--		Delete Top(1) from CATEGORIA where IdCategoria = @IdCategoria
--	end		
--	ELSE
--	begin
--		set @Resultado = 0
--		set @Mensaje = 'No se puede eliminar la categoría porque se encuentra relacionada a un producto.'
--	end
--end

--GO

--CREATE PROC SP_RegistrarProducto(
--@Codigo varchar(20),
--@Nombre varchar(30),
--@Descripcion varchar(30),
--@IdCategoria int,
--@Estado bit,
--@Resultado int output,
--@Mensaje varchar(500) output
--)as
--begin
--	Set @Resultado = 0
--	If Not Exists (select * from PRODUCTO where Codigo = @Codigo)
--	begin
--		insert into PRODUCTO(Codigo,Nombre,Descripcion,IdCategoria,Estado) values (@Codigo,@Nombre,@Descripcion,@IdCategoria,@Estado)
--		set @Resultado = SCOPE_IDENTITY()
--	end
--	Else
--		set @Mensaje = 'Ya existe un producto con el mismo código'

--end

--Go

--CREATE PROC SP_EditarProducto(
--@IdProducto int,
--@Codigo varchar(20),
--@Nombre varchar(30),
--@Descripcion varchar(30),
--@IdCategoria int,
--@Estado bit,
--@Resultado bit output,
--@Mensaje varchar(500) output
--)as
--begin
--	Set @Resultado = 1
--	If Not Exists (select * from PRODUCTO where Codigo = @Codigo and IdProducto != @IdProducto)
--		update PRODUCTO set
--		Codigo = @Codigo,
--		Nombre = @Nombre,
--		Descripcion = @Descripcion,
--		IdCategoria = @IdCategoria,
--		Estado = @Estado
--		where IdProducto = @IdProducto
--	Else
--	begin
--		set @Resultado = 0
--		set @Mensaje = 'Ya existe un producto con el mismo código'
--	end
--end

--GO

--CREATE PROC SP_EliminarProducto(
--@IdProducto int,
--@Respuesta bit output,
--@Mensaje varchar(500) output
--)as
--begin
--	set @Respuesta = 0
--	set @Mensaje = ''
--	declare @pasoreglas bit = 1

--	If Exists (select * from DETALLE_COMPRA dc
--	inner join PRODUCTO p on p.IdProducto = dc.IdProducto
--	where p.IdProducto = @IdProducto)
--	begin
--		set @pasoreglas = 0
--		set @Respuesta = 0
--		set @Mensaje = @Mensaje + 'No se puede eliminar el producto porque se encuentra relacionado a una compra\n'
--	end

--	If Exists (select * from DETALLE_VENTA dv
--	inner join PRODUCTO p on p.IdProducto = dv.IdProducto
--	where p.IdProducto = @IdProducto)
--	begin
--		set @pasoreglas = 0
--		set @Respuesta = 0
--		set @Mensaje = @Mensaje + 'No se puede eliminar el producto porque se encuentra relacionado a una venta\n'
--	end

--	If(@pasoreglas = 1)
--	begin
--		delete from PRODUCTO where IdProducto = @IdProducto
--		set @Respuesta = 1
--	end

--end

--GO

--CREATE PROC SP_RegistrarCliente(
--@Documento varchar(50),
--@NombreCompleto varchar(50),
--@Correo varchar(50),
--@Telefono varchar(50),
--@Estado bit,
--@Resultado int output,
--@Mensaje varchar(500) output
--)as
--begin
--	SET @Resultado = 0
--	Declare @IDPERSONA int
--	IF NOT EXISTS (select * from CLIENTE where Documento = @Documento)
--	begin
--		insert into CLIENTE(Documento,NombreCompleto,Correo,Telefono,Estado) 
--		values (@Documento,@NombreCompleto,@Correo,@Telefono,@Estado)
--		set @Resultado = SCOPE_IDENTITY()
--	end
--	ELSE
--		set @Mensaje = 'El número de documento ya existe.'
--end

--GO

--CREATE PROC SP_EditarCliente(
--@IdCliente int,
--@Documento varchar(50),
--@NombreCompleto varchar(50),
--@Correo varchar(50),
--@Telefono varchar(50),
--@Estado bit,
--@Resultado bit output,
--@Mensaje varchar(500) output
--)as
--begin
--	SET @Resultado = 1
--	Declare @IDPERSONA int
--	IF NOT EXISTS (select * from CLIENTE where Documento = @Documento and IdCliente != @IdCliente)
--	begin
--		Update CLIENTE set 
--		Documento = @Documento,
--		NombreCompleto = @NombreCompleto,
--		Correo = @Correo,
--		Telefono = @Telefono,
--		Estado = @Estado 
--		where IdCliente = @IdCliente
--	end
--	ELSE
--	begin
--		set @Resultado = 0
--		set @Mensaje = 'El número de documento ya existe.'
--	end
--end

--GO

--select IdCliente,Documento,NombreCompleto,Correo,Telefono,Estado from CLIENTE

--GO

--CREATE PROC SP_RegistrarProveedor(
--@Documento varchar(50),
--@RazonSocial varchar(50),
--@Correo varchar(50),
--@Telefono varchar(50),
--@Estado bit,
--@Resultado int output,
--@Mensaje varchar(500) output
--)as
--begin
--	SET @Resultado = 0
--	Declare @IDPERSONA int
--	IF NOT EXISTS (select * from PROVEEDOR where Documento = @Documento)
--	begin
--		insert into PROVEEDOR(Documento,RazonSocial,Correo,Telefono,Estado) 
--		values (@Documento,@RazonSocial,@Correo,@Telefono,@Estado)
--		set @Resultado = SCOPE_IDENTITY()
--	end
--	ELSE
--		set @Mensaje = 'El número de documento ya existe.'
--end

--GO

--CREATE PROC SP_EditarProveedor(
--@IdProveedor int,
--@Documento varchar(50),
--@RazonSocial varchar(50),
--@Correo varchar(50),
--@Telefono varchar(50),
--@Estado bit,
--@Resultado bit output,
--@Mensaje varchar(500) output
--)as
--begin
--	SET @Resultado = 1
--	Declare @IDPERSONA int
--	IF NOT EXISTS (select * from PROVEEDOR where Documento = @Documento and IdProveedor != @IdProveedor)
--	begin
--		Update PROVEEDOR set 
--		Documento = @Documento,
--		RazonSocial = @RazonSocial,
--		Correo = @Correo,
--		Telefono = @Telefono,
--		Estado = @Estado 
--		where IdProveedor = @IdProveedor
--	end
--	ELSE
--	begin
--		set @Resultado = 0
--		set @Mensaje = 'El número de documento ya existe.'
--	end
--end

--GO

--CREATE PROC SP_EliminarProveedor(
--@IdProveedor int,
--@Resultado bit output,
--@Mensaje varchar(500) output
--)as
--begin
--	set @Resultado = 1

--	If Not Exists (select * from PROVEEDOR p
--	inner join COMPRA c on p.IdProveedor = c.IdProveedor
--	where p.IdProveedor = @IdProveedor)
--	begin
--		delete top(1) from PROVEEDOR where IdProveedor = @IdProveedor
--	end
--	Else
--	begin
--		set @Resultado = 0
--		set @Mensaje = 'No se puede eliminar el proveedor porque se encuentra relacionado a una compra.'
--	end

--end

--GO

--select IdProveedor,Documento,RazonSocial,Correo,Telefono,Estado from PROVEEDOR

GO

CREATE TABLE DETALLE_VENTA(
IdDetalleVenta int primary key identity,
IdVenta int references VENTA(IdVenta),
IdProducto int references PRODUCTO(IdProducto),
PrecioVenta decimal(10,2),
Cantidad int,
SubTotal decimal(10,2),
FechaRegistro datetime default getdate()
)

--GO

--CREATE TABLE NEGOCIO(
--IdNegocio int primary key,
--Nombre varchar(60),
--RUC varchar(60),
--Direccion varchar(60),
--Logo varbinary(max) NULL
--)

--GO

--Insert into NEGOCIO (IdNegocio,Nombre,RUC,Direccion)
--values (1,'APICULTURA PAB','201100','Salvador María')

--GO

--select * from NEGOCIO 

--GO

