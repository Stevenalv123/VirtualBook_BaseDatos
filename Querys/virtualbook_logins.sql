use master
go

if not exists (select * from sys.server_principals
	where name = 'virtualbooksystem')
	create login virtualbooksystem with password = 'vb1234';

use Db_VirtualBook
go

SELECT name, sid
FROM sys.database_principals
WHERE sid IN (SELECT sid FROM sys.server_principals WHERE name = 'virtualbooksystem');

create user virtualbooksystemUser for login virtualbooksystem;
go

--Procedimiento almacenado para validar las credenciales del usuario
create procedure sp_ValidarUsuario
	@CorreoUsuario varchar(100),
	@Contrasena nvarchar(64)
as
begin
	set nocount on;

	declare @Hash varbinary(32) = HASHBYTES('SHA2_256', cast(@Contrasena as nvarchar(256)));
	select u.IdUsuario, 
        u.Nombres, 
        u.Apellidos, 
        u.Correo_Electronico, 
        u.FotoPerfil, 
        u.IdRol,
        r.NombreRol,
        u.FechaNacimiento,
        u.Genero 
	from Usuario u
	inner join Rol r on u.IdRol = r.IdRol
	where u.Correo_Electronico = @CorreoUsuario
	and u.Contrasena = @Hash;
end;
go

--Procedimiento almacenado para registrar al usuario
create procedure sp_RegistrarUsuario
	@Nombres varchar(50),
	@Apellidos varchar(50),
	@Correo_Electronico varchar(100),
	@Contrasena nvarchar(64),
	@FotoPerfil nvarchar(max) = null,
	@IdRol int,
	@FechaNacimiento datetime,
	@Genero varchar(10)
as
begin
	set nocount on;
	
	declare @Hash varbinary(32) = Hashbytes('SHA2_256', Cast(@Contrasena as nvarchar(256)));
	insert into Usuario (Nombres, Apellidos, Correo_Electronico, Contrasena, FotoPerfil, IdRol, FechaNacimiento, Genero)
	values (@Nombres, @Apellidos, @Correo_Electronico, @Hash, @FotoPerfil, @IdRol, @FechaNacimiento, @Genero);
end;
go

grant execute on sp_ValidarUsuario to virtualbooksystemUser;
grant execute on sp_RegistrarUsuario to virtualbooksystemUser;
go
