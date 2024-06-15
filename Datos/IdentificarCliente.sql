
delimiter // 
/* Creación del procedimiento almacenado para verificar si existe paciente */ 
DROP PROCEDURE IF EXISTS IdentificarPaciente //
CREATE PROCEDURE IdentificarPaciente(
    IN pacienteDni BIGINT, 
    OUT pPacienteId INT,
    OUT pNombre VARCHAR(40),
    OUT pApellido VARCHAR(40),
    OUT pFecNacimiento DATE,
    OUT pDomicilio VARCHAR(40),
    OUT pEmail VARCHAR(40),
    OUT pTelefono VARCHAR(20),
    OUT pDni BIGINT
)
BEGIN  
    SET pPacienteId = (SELECT pacienteId FROM paciente WHERE dni = pacienteDni);
    SET pNombre = (SELECT nombre FROM paciente WHERE dni = pacienteDni);
    SET pApellido = (SELECT apellido FROM paciente WHERE dni = pacienteDni);
    SET pFecNacimiento = (SELECT fecNacimiento FROM paciente WHERE dni = pacienteDni);
    SET pDomicilio = (SELECT domicilio FROM paciente WHERE dni = pacienteDni);
    SET pEmail = (SELECT email FROM paciente WHERE dni = pacienteDni);
    SET pTelefono = (SELECT telefono FROM paciente WHERE dni = pacienteDni);
    SET pDni = (SELECT dni FROM paciente WHERE dni = pacienteDni);
END //
delimiter ;

-- Prueba del procedimiento almacenado
CALL IdentificarPaciente(33495009, 
    @pPacienteId,
    @pNombre,
    @pApellido,
    @pFecNacimiento,
    @pDomicilio,
    @pEmail,
    @pTelefono,
    @pDni
);

SELECT 
    @pPacienteId AS 'ID del Paciente',
    @pNombre AS 'Nombre del Paciente',
    @pApellido AS 'Apellido del Paciente',
    @pFecNacimiento AS 'Fecha de Nacimiento del Paciente',
    @pDomicilio AS 'Domicilio del Paciente',
    @pEmail AS 'Email del Paciente',
    @pTelefono AS 'Teléfono del Paciente',
    @pDni AS 'DNI del Paciente';
