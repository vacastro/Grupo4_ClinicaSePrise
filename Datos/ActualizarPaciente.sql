DELIMITER //

CREATE PROCEDURE ActualizarPaciente(
    IN pPacienteId INT,
    IN pNombre VARCHAR(40),
    IN pApellido VARCHAR(40),
    IN pFecNacimiento DATE,
    IN pDomicilio VARCHAR(40),
    IN pEmail VARCHAR(40),
    IN pTelefono VARCHAR(20),
    IN pDni BIGINT
)
BEGIN
    UPDATE paciente
    SET nombre = pNombre,
        apellido = pApellido,
        fecNacimiento = pFecNacimiento,
        domicilio = pDomicilio,
        email = pEmail,
        telefono = pTelefono,
        dni = pDni
    WHERE pacienteId = pPacienteId;
END //

DELIMITER ;
