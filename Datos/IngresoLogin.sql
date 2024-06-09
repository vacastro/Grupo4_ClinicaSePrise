delimiter // 
/* creacion del procedimiento almacenado para acceder desde el sistema */ 
drop procedure if exists IngresoLogin //
create procedure IngresoLogin(in Usu varchar(20),in Pass varchar(15))

begin  
  select NombreRol
	from usuario u inner join roles r on u.RolUsu = r.RolUsu
		where NombreUsu = Usu and PassUsu = Pass
			and Activo = 1; 
end 
//

/*prueba */
/*call IngresoLogin('adm', '1234') // */