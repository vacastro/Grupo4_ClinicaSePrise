
DELIMITER //

CREATE PROCEDURE InsertarTurno(
    IN p_fecha DATE,
    IN p_hora TIME,
    IN p_especialidad VARCHAR(255),
    IN p_pacienteId INT,
    IN p_sobreturno BOOLEAN
)
BEGIN
    INSERT INTO turno (fecha, hora, especialidad, pacienteId, sobreturno)
    VALUES (p_fecha, p_hora, p_especialidad, p_pacienteId, p_sobreturno);
END //

DELIMITER ;