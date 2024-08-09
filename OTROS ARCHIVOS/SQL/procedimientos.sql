-- -----------------------------------------------------------
-- ----------- PROCEDIMIENTOS ALMACENADOS --------------------
-- -----------------------------------------------------------

DROP PROCEDURE IF EXISTS `crearUsuario`;
DROP PROCEDURE IF EXISTS `actualizarUsuario`;
DROP PROCEDURE IF EXISTS `eliminarPorCedula`;
DROP PROCEDURE IF EXISTS `existePorCedula`;
DROP PROCEDURE IF EXISTS `existePorId`;
DROP PROCEDURE IF EXISTS `traerPorCedulaYContrasena`;
DROP PROCEDURE IF EXISTS `traerPorCedula`;
DROP PROCEDURE IF EXISTS `traerPorId`;
DROP PROCEDURE IF EXISTS `cambiarEstadoPorCedula`;
DROP PROCEDURE IF EXISTS `cambiarEstadoPorCedula`;
DROP PROCEDURE IF EXISTS `listarTipoDeUsuario`;
DROP VIEW IF EXISTS `vistaUsuariosCamposEnOrden`;

-- Procedimiento Almacenado para crear un nuevo usuario

DELIMITER $$
CREATE PROCEDURE `crearUsuario`(
    IN `nombres_param` VARCHAR(50), 
    IN `apellidos_param` VARCHAR(50),
    IN `cedula_param` VARCHAR(20),
    IN `contrasena_param` VARCHAR(255),
    IN `sexo_param` CHAR(1),
    IN `nacimiento_param` DATE,
    IN `direccion_param` VARCHAR(100),
    IN `foto_param` MEDIUMBLOB,
    IN `activo_param` BOOLEAN,
    IN `rol_param` VARCHAR(50)
)
BEGIN
    INSERT INTO usuario ( 
        nombres,
        apellidos,
        cedula,
        contrasena,
        sexo,
        nacimiento,
        direccion,
        foto,
        activo,
        rol
    )
    VALUES( 
        nombres_param,
        apellidos_param,
        cedula_param,
        contrasena_param,
        sexo_param,
        nacimiento_param,
        direccion_param,
        foto_param,
        activo_param,
        rol_param
    );
END $$
DELIMITER ;


-- Procedimiento Almacenado para actualizar ususario por cedula

DELIMITER $$
CREATE PROCEDURE `actualizarUsuario`(
    IN `id_param` VARCHAR(255),
    IN `nombres_param` VARCHAR(255),
    IN `apellidos_param` VARCHAR(255),
    IN `cedula_param` VARCHAR(10),
    IN `contrasena_param` TEXT,
    IN `sexo_param` VARCHAR(1),
    IN `nacimiento_param` DATE,
    IN `direccion_param` VARCHAR(255),
    IN `foto_param` LONGBLOB,
    IN `activo_param` TINYINT(1),
    IN `rol_param` VARCHAR(20)
)
BEGIN
    UPDATE `usuario`
    SET 
        `nombres` = nombres_param,
        `apellidos` = apellidos_param,
        `cedula` = cedula_param,
        `contrasena` = contrasena_param,
        `sexo` = sexo_param,
        `nacimiento` = nacimiento_param,
        `direccion` = direccion_param,
        `foto` = foto_param,
        `activo` = activo_param,
        `rol` = rol_param
    WHERE `id` = id_param;
END$$

DELIMITER ;

-- Procedimiento para eliminar usuario

DELIMITER $$

CREATE PROCEDURE eliminarPorCedula(IN cedula_param VARCHAR(10))
BEGIN
    DELETE FROM usuario
    WHERE cedula = cedula_param;
END $$

DELIMITER ;


-- Procedimiento Almacenado para verificar existencia de usuario por cédula

DELIMITER $$
CREATE PROCEDURE `existePorCedula`(
    IN `cedula_param` VARCHAR(20)
)
BEGIN
    DECLARE existe INT DEFAULT 0;

    -- Cuenta el número de registros con la cédula proporcionada
    SELECT COUNT(id) INTO existe
    FROM vistaUsuariosCamposEnOrden
    WHERE cedula = cedula_param;
    
    -- Devuelve la cantidad de registros encontrados (1 si existe, 0 si no)
    SELECT existe;
END $$
DELIMITER ;





-- Procedimiento Almacenado para verificar existencia de usuario por ID

DELIMITER $$
CREATE PROCEDURE `existePorId`(
    IN `id_param` INT
)
BEGIN
    DECLARE existe INT DEFAULT 0;

    SELECT COUNT(id) INTO existe
    FROM usuario
    WHERE id = id_param;
    
    SELECT existe;
END $$
DELIMITER ;





-- Procedimiento Almacenado para traer usuario por cédula y contraseña

DELIMITER $$
CREATE PROCEDURE traerPorCedulaYContrasena(
    IN cedula_param VARCHAR(50), 
    IN contrasena_param VARCHAR(50)
)
BEGIN
    SELECT *
    FROM vistaUsuariosCamposEnOrden 
    WHERE cedula = cedula_param 
      AND contrasena = contrasena_param;
END $$
DELIMITER ;


-- Procedimiento Almacenado para traer usuario por cédula

DELIMITER $$
CREATE PROCEDURE traerPorCedula(
    IN cedula_param VARCHAR(50)
)
BEGIN
    SELECT *
    FROM vistaUsuariosCamposEnOrden
    WHERE cedula = cedula_param;
END $$
DELIMITER ;


-- Procedimiento Almacenado para traer usuario por ID

DELIMITER $$
CREATE PROCEDURE traerPorId(
    IN id_param INT
)
BEGIN
    SELECT *
    FROM vistaUsuariosCamposEnOrden
    WHERE id = id_param;
END $$
DELIMITER ;


-- Procedimiento Almacenado para listar usuarios por tipo de rol
DELIMITER $$
CREATE PROCEDURE `listarTipoDeUsuario` (IN `rol_param` VARCHAR(50))   
BEGIN  
    SELECT *
    FROM vistaUsuariosCamposEnOrden
    WHERE LOWER(rol) = LOWER(rol_param);
END$$




-- Procedimiento para canbiar de estado a un ususario: activo o inactivo

DELIMITER $$
CREATE PROCEDURE cambiarEstadoPorCedula(
    IN cedula_param VARCHAR(10),
    IN activo_param BOOLEAN
)
BEGIN  
    UPDATE usuario SET activo = activo_param WHERE usuario.cedula = cedula_param;
END $$
DELIMITER ;

-- -----------------------------------------------------------
-- ----------- VISTAS ----------------------------------------
-- -----------------------------------------------------------

-- Vista para traer usuarios con los campos en orden
CREATE VIEW vistaUsuariosCamposEnOrden AS
SELECT 
    u.id, 
    u.nombres, 
    u.apellidos, 
    u.cedula, 
    u.rol, 
    u.contrasena,
    u.sexo,
    u.nacimiento,
    u.direccion,
    u.foto,
    u.activo
FROM usuario u;





