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


