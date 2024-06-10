DELIMITER //
CREATE PROCEDURE ObtenerEspecialidadesPorTipo(
    IN tipoEspecialidad VARCHAR(50)
)
BEGIN
    SELECT nombre_especialidad
    FROM especialidades
    WHERE tipo_especialidad = tipoEspecialidad;
END //
DELIMITER ;