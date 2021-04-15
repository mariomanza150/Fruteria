drop procedure Alta;
drop procedure Baja;
drop procedure Consulta;
drop procedure Modificacion;
GO

create procedure Alta(@id varchar(255), @nombre varchar(255), @cantidad varchar(255), @precio varchar(255), @reabastecimiento varchar(255)) as
begin
	insert into Productos (id, nombre, cantidad, precio, reabastecimiento) values (@id, @nombre, @cantidad, @precio, @reabastecimiento)
end
GO
create procedure Baja(@id varchar(255)) as
begin
	delete from Productos where id=@id
end
GO
create procedure Modificacion(@id varchar(255), @nombre varchar(255), @cantidad varchar(255), @precio varchar(255), @reabastecimiento varchar(255)) as
begin
	update Productos set nombre=@nombre, cantidad=@cantidad, precio=@precio, reabastecimiento=@reabastecimiento where id=@id
end
GO
create procedure Consulta(@id varchar(255)) as
begin
	select * from Productos where id=@id
end