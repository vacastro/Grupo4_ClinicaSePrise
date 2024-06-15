DELIMITER //

CREATE PROCEDURE InsertarPaciente(
    IN pNombre VARCHAR(40),
    IN pApellido VARCHAR(40),
    IN pFecNacimiento DATE,
    IN pDomicilio VARCHAR(40),
    IN pEmail VARCHAR(40),
    IN pTelefono VARCHAR(20),
    IN pDni BIGINT
)
BEGIN
    INSERT INTO paciente (nombre, apellido, fecNacimiento, domicilio, email, telefono, dni)
    VALUES (pNombre, pApellido, pFecNacimiento, pDomicilio, pEmail, pTelefono, pDni);
END //

DELIMITER ; 