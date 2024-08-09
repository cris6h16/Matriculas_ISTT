-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 01, 2024 at 08:07 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `matricula`
create database `matricula`;
 use `matricula`;
--

DELIMITER $$
--
-- Procedures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `cambiarEstadoPorCedula` (IN `cedula_param` VARCHAR(10), IN `activo_param` BOOLEAN)   BEGIN  
    UPDATE usuario 
    SET activo = activo_param 
    WHERE cedula = cedula_param;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `crearUsuario` (IN `nombres_param` VARCHAR(50), IN `apellidos_param` VARCHAR(50), IN `cedula_param` VARCHAR(20), IN `contrasena_param` VARCHAR(255), IN `sexo_param` CHAR(1), IN `nacimiento_param` DATE, IN `direccion_param` VARCHAR(100), IN `foto_param` MEDIUMBLOB, IN `activo_param` BOOLEAN, IN `rol_param` VARCHAR(50))   BEGIN
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
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `existePorCedula` (IN `cedula_param` VARCHAR(20))   BEGIN
    DECLARE existe INT DEFAULT 0;

    -- Cuenta el número de registros con la cédula proporcionada
    SELECT COUNT(id) INTO existe
    FROM vistaUsuariosCamposEnOrden
    WHERE cedula = cedula_param;
    
    -- Devuelve la cantidad de registros encontrados (1 si existe, 0 si no)
    SELECT existe;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `existePorId` (IN `id_param` INT)   BEGIN
    DECLARE existe INT DEFAULT 0;

    SELECT COUNT(id) INTO existe
    FROM usuario
    WHERE id = id_param;
    
    SELECT existe;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `listarTipoDeUsuario` (IN `rol_param` VARCHAR(50))   BEGIN  
    SELECT *
    FROM vistaUsuariosCamposEnOrden
    WHERE LOWER(rol) = LOWER(rol_param);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `traerPorCedula` (IN `cedula_param` VARCHAR(50))   BEGIN
    SELECT *
    FROM vistaUsuariosCamposEnOrden
    WHERE cedula = cedula_param;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `traerPorCedulaYContrasena` (IN `cedula_param` VARCHAR(50), IN `contrasena_param` VARCHAR(50))   BEGIN
    SELECT *
    FROM vistaUsuariosCamposEnOrden 
    WHERE cedula = cedula_param 
      AND contrasena = contrasena_param;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `traerPorId` (IN `id_param` INT)   BEGIN
    SELECT *
    FROM vistaUsuariosCamposEnOrden
    WHERE id = id_param;
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `asignatura`
--

CREATE TABLE `asignatura` (
  `id` int(11) NOT NULL,
  `nombre` varchar(80) NOT NULL,
  `descripcion` varchar(255) DEFAULT NULL,
  `nivel` tinyint(4) DEFAULT NULL,
  `id_carrera` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `carrera`
--

CREATE TABLE `carrera` (
  `id` int(11) NOT NULL,
  `nombre` varchar(255) DEFAULT NULL,
  `duracion_en_semestres` tinyint(4) DEFAULT NULL,
  `modalidad` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `distribuir`
--

CREATE TABLE `distribuir` (
  `id` int(11) NOT NULL,
  `id_usuario` int(11) NOT NULL,
  `id_periodo_academico` int(11) NOT NULL,
  `id_asignatura` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `matricula_a_asignatura`
--

CREATE TABLE `matricula_a_asignatura` (
  `id` int(11) NOT NULL,
  `id_usuario` int(11) NOT NULL,
  `id_asignatura` int(11) NOT NULL,
  `id_periodo_academico` int(11) NOT NULL,
  `tipo_de_matricula` varchar(50) NOT NULL,
  `modalidad` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `periodo_academico`
--

CREATE TABLE `periodo_academico` (
  `id` int(11) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `fecha_inicio` date NOT NULL,
  `fecha_fin` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `usuario`
--

CREATE TABLE `usuario` (
  `id` int(11) NOT NULL,
  `nombres` varchar(255) NOT NULL,
  `apellidos` varchar(255) NOT NULL,
  `cedula` varchar(10) NOT NULL,
  `contrasena` text NOT NULL,
  `sexo` varchar(1) NOT NULL,
  `nacimiento` date NOT NULL,
  `rol` varchar(20) NOT NULL,
  `direccion` varchar(255) NOT NULL,
  `foto` longblob NOT NULL,
  `activo` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `usuario`
--

INSERT INTO `usuario` (`id`, `nombres`, `apellidos`, `cedula`, `contrasena`, `sexo`, `nacimiento`, `rol`, `direccion`, `foto`, `activo`) VALUES
(1, '0000000000', '0000000000', '0000000000', '0000000000', 'M', '2004-04-15', 'Administrador', '0000000000', 0x89504e470d0a1a0a0000000d49484452000000ed000000d508030000008cba877d0000000467414d410000b18f0bfc6105000000c0504c544500aef0ffffffcfcfcfcccccccbcbcbcececec8c8c8f2f2f2dddddddededef5f5f500adf1dadadafcfcfcd3d3d3f1f1f15fb8e700aaf0e4e4e4d3cdc900a7efe1dbd770bae137b1eafdf9f6fffffb1aafee41b4ead1cdcac0dff193c0d95ec0f39cd0eec6cccfe4ddd9bcc9d169bce8abc7d8d7effe8fcdefa0c3d77cc3eacee6f44eb4e673c5f26cb9e17dbcdebccfdaeaf3f8b8def683c2e3c6dceaa9cde096ccecc7d4dadae9f2a6d2e9d3e2ea9bc7e195bed354afdbb5c3c999d4f5b7d4e715710fe30000111349444154785edd9d6963da381785599b0401413584cd49930093852621e9b4c94ca76fffffbf7aefbd92c08b6ccbb6e4c173bf3cc3148c4f748f8f57d16842755aad7684dd04b6341cb45bada19edd20e7abcdd5f3c3faeb72d16834a6dbafa3a7e79f2f83667326ffbd07ec97e009f0348167c0f376356a7d6ff8c7f5a8c138c302ad58f4df9c2fd61f2bdf375193c58ad402f52ae598fa3fb70dce95ca4891e2a70dbccf5455120dd57e6a773e113b92ed4e2781f4d780f791fa3ddbfbd7f4570870d89c3fae614ca5b4a462bcf1b09bfb6d783ffc95607941f66039a40a5e0b465febffff09bc26b5f05ab0d1510ae3140ae3d42b3e30a878f6bcc8942a8a8da78fa810ff42071e14e4a7501864039a9154403716e96224ad9dd6b3f3eb0697620c8af1e9e3ac6bd6b53aaaae8d527431d29a5a4558aa523d79cda3150bf4be78c6eaa23450db6eb7a557f7141d1ba7e8e0769bd4c7293b58d15b4d736ac5627cd49ec0c70f9e8d7ad38c07af0629b652f63d3b6cde8da5809cc5d86fcf8e77c39e453aca5bffa5c8c0cae2db6ea1fcd575b1a283bced28cf7a57861b627db1c506bbd954a5a2a15af05e49cfb649bda2b72e3eb0a2f8dfb018538ff63a7192ca181de4addffa52666045f127af1679ebdf2cca8b05b923a3ee0d925469e8246f8567fd55c3865830efd254a5a281da6eb72b3ab7db159dbaa7f46c577ab62b3d1a27a956fc2557b67cb1e51c5474ba6d529383a4b2d3955e3d10d4c27fa1e76c79762557d546b1a97fdc797b2357d44eb1a5476b0f5d68425d172bdacb5ba0cc59dfca06ea506c9427770dd5c63dbba7500fe64ea0502be94ded8a852df31b2cd6c4ab4182479577433ccf95b7a43c40521ca0775776a7225efca76fe4511d49698816f3d6bfb22f169a79d5a2b597dd9a4652a5a1d5bc159eedb456b6db980a36cc16d5820585da0395571585da0ccf767ceba615c52e684b15f1661a49a58636f3f6da451f638dbff9e65e0dd261deee5c896d34167e7617933a20a9d2d04adeca2e6eb52623377d8cc5df7cab6acb7ab6ebdfbb1b5ab0ee8d5005df974552a721a9b596b78e3651a2d883b1578324a5215acadb5797430b1baa5d56172349958656f2567916f3d6f2fe71b4d857bc0e68412d58b1a46781976e87163654e7ed8847d5eb0085ba38855aa495bcf5a672a59c15381714c1f7913243bac9dbe6caf5d042e6e2790ce8465293405d172b061328b7dabd6791f327b7aec5e297f6d496f12ca8956be4b2d81a55257b56a8cdf2ae85bc6d6fdc3732c85567cccd3c8b24a5215ac85bffd97d23432b5f651ef989714cea624aa0fc6a439e057a788b8cf3621796d4924a388e5124751a92ba08e1f8a7822d32d622f5fca34e25b12bd5122de4ade3bd4655e31d5ecf2585867492b77755d81633286bef31717c81c10432561bf52c72598d5a766749adc6a35192ba08c5358279358d8c4706ea7e1b0d49958607cf22cbe7ad9b538d9a6274360ebe97141a901487583a6fdd9eb50816c733b9495d8c24551a8a2e46e650abf32ca8bdaa6a6cf90b7c5d79b5a426e05145521365577000a4b3e6fe5b656aff84ef038f8a6b0701922a0da56715512dfc177ab078de56a8b66dee59a48bbcb5704b8959b1ef19e795755dac28ba59a9cdf0ae3ce2d379b73ab56f76d4426f939a00494d02f79e2556a7f6da37f7ac62d8bba5f3d6ab68570ad4dec1d7997a16498a432c9db755ab955dab23a9d25074b14aa0a8da88eabd6715a55a416f5bdd560abeaebc5a5201bdad482a343c7835c00ac796d4c2f7923a4973cf22cbe76d950964ee59a48bbc5d57a5967fb8cedb74cf129d5d938f16ff6d296f87435203141e8d537875283d1b64756abfb586d2b382274052a321a983f787593a6f3b3f2b53fb03beced4b348521e62e9bcade6dc3996389a975dab23a9d25074b14aa0a85ac9986715a55ac99baab652530b6ac192dde660203caae710081e4de0a49293e730b4eb4973d0ec9177054f81271a9e018557a31479ab9e5a3c507835e9a945f59422f16b3583cb3f66f07d348e868c3f01553e6fabda28f3f7b42e2675c0f46e8ee4adbca269ea59e27b356a59a2ca1c6ac17a899e6d496f6650ae8edb625fd0ab43e9d9a1f46822f5de0d3cb558c4b348cfe16d7087626fe21a1f7caf29695c432c9db79d5635e75879f67dcae95d4c097450bbf76c4eefb62a49dc69f673b9066ac17acaa3519a781639a9e030883d936707d2b303e9512dc1a303f0aa86326fcb79d7c92df6e11aef60fce0fb681c0de9246f9b4d5fae92bb6223f89ab42e2675c0f46e966ae5dd7f85f216d45eb86e65715544aa4a63865ab05e19cf0ade386e6536bd85ef29e759a46696807c9e157c703bb8fc32ef3e3292c635440b798be7317a4e07974d2d7431251088897ab688779d0e2ebfb4a516ac17f4acb957c3ec3954cbb673f22ce6adb16761b5e28ce46d61ef0e1dde35c557e65e0dd24dde8a7b6b9c5d33e06f5e7617933a607a370bb5f1bbed853ab33b7691c3a6abc79fd87426efc8cdba631729d425deb10bd6cb9faf3ace3fdcc8e5ef3d587c1fbee604789ac0332079339529b3f2e4c95ba49beb5ffc59dccd09df939734ae215aca5bf26ecbc173326c6b3e0393e8da24cf52028125a39e2decdd5dc16987928b1d9e582ceb597a42067a3ae441f5da8480109bdfac5bf7332c36cbb3e6de4dc8db98779567d3bdeb593ed2652b1a37587e5ed2b8c6682f6f89deb34db97c936b9e299d67156de72da8054eaeed7997dfcbe76e61b9425559ef62de6a3d5894cdefb646977f83c5a167316fcb7b1669300b9e69deaad9efdeecc8e562fe30586ebf20695c43b499b7cabb363655acf192cbb348d1b5499eb59eb700f2ee7be929a6d8f426e259c58047a314ea923cbbcf5be869234f1a90f6699be7251f2ce76bf4a25dcf2233f276ef5de5d904efb67df99ac6f953d77f2ad1cd8c5d79d427b0bc3e70e6abb96ab2bdaa48e31aa38dbc6d7aedcde6f5e31aef4f531e9e3c169ee3902f56c1191fdeaf3fae36b4c5b2f53c50d1bc6df993c1ebc3968b6a80d79477e108f0615c442fe3d773f018a980e54cfe1873ce381fb3eddd65c7935baea2de2d95b7939be705ac8b12c516abbef21a70fed734f7f8323e3a9fabe359e0e470c70e48e6cbabfebca8679105669d955ef5bdfb2f7ba1a218fb03ff9dc61d386cbe2e72d9978d977f795d39072bcd3afbbfc8e739fb67657cbc4be31a62e1bcf5ee7523c73fbcbd77a9ab41afe9f832fee5913e476b4b7c88ffb118dfd25d62a1f7098aae4df26c99bcdd25cc2acb9f7ca116de879c7bf75b13bd8cf1f50ade1fc8577fb8d47e071b3f0cc8a34265b6679165f2767e9db80582fd8209bc2de8bd1fd7d3c34cf6ba024b6eff1e4ed08b87cf4d3689fb28ac713983f79979f5c0cfa679bb9f7596f82b6dba60c65ebda077a17c6f75b5c659ede3ab8fdb9ec5fafe06132638bb7bbf993ac9dc780defcbe7596491bcbdcc684dbebdf169adc12b92d0ddf3ddebc57681eae8570b0417a3ebcb1dec3d50f7073ce865cdbfcc16bbe0fb893acf2a16cedbec2358d819a2b182f7935a45dff35abbf7f7c79f5757f797efefef379e177cdfdeb3be7f91e975c61f75e79985ba380be6ed5cb39d8c17ce4e1ff46e84fd3e5ebb49faf7d995d15105ff7362ee59c1dc79fb8f8958fcd36f571ebc3de845237630dae442326afc0ae3099febc3e7ccbc9b376f8d46960a768bde61edc133a42283ca7b3363ad50e3f0954ed1b5499e8de6ad628a77739d8661e3ede5dc97aae0f359ec37671ff976bec621ef0a757a16c8dbf965ce536c8c379e579348fe267032d93cc0665a7ed2b0389e6f36f36ceebcfd95eb0f2f8af1e5f52f7f7fbcaa6507fefdf1ce7c1ff3506c019f37f32c324fdece8bdd650ed1ba185dedf09773e45e25784892ee5d1c6c9eb7f0a6fc5aa1f883f02c2e47e759c5f4bcd579b7c414bab837f1e5edeafe0555ce3d91b373ef6673fff1b01ceb76b24c6bfc489ea5314df02c3277debe973c2f4e3b508cb3e5d7ed6834fa3a9ad2ee5419a5a27a669e459ae7adb5a9a071bf114bbe2c5b72565a23ef1ae7ad9bd9916d94782a2ad3b3b9f2b69a59a48a144ea246fbd8429d9ef9f27666e97a878b1abf9b78364fdefa473bb430b84bcf6ede1eaf6bb1d8ca6ede1ef3d082da91380f99e25da9b6d7eb0d867df026128aa85eef59d94443c58aff381bf4a45791fd3d3f876898b7954d0550acf8ff74f72fd3b8866896b7153dbc56a24ed47c61899e35cf5bc7b796972ffedb17fbcafbd9bf23de9579dbeff7a537b5c47348fdd9d10f2ddb4e0e5ed57b166994b7953d1a5fbcc6036b795bd9e42cc58b5f63d76679d7246f67d66f5fb45f6c19c85bc5a4bc4df6eca037ab68ead172353e476ff6c1b370bc7b20781689de051ae46d75b30c9529cdf3b934ae219ae4ad5cde7117db7aa26bcbe5ad5fd9f41de58aa95fc649f16e346fd1ab01cf0227954c7d5dbef8467a34ead900a3791bf12cf2c8f79155b1bbe0be328d678cd979ebf6113d7b854fd294cf5be7bfaa61abf84e79547956519bb707af06383bfa230255fc37acee19ac367954c77e66debaff0d115b257f8ba454defa756964da794cf1ac51ded6246db1f81cd4453dab18ca5bf22820ca59651306972ffe38036f2a8fea9895b75e45b347d928d8552e99b7d54dc559bed8931ff3aca259ded66723859b292fecd5000f79db839e26af6af85223b50d3649f12c322b6f6bb3278535deedf336ee596456de3af8015f77c51f533c6b92b7ce67a0b159fc43eb594591b7499e05ce9cfe62a4ed620fb364cf2233f2f6b8afed458b6df7cf1cd078c69891b7ae2717b25cd38c7353e9795bd5af58d9aa854fea025e5524b59d8cbcfdb34eb685081a267b169991b7b538717ea871af54de5636f1b59de28fbafba68cf3b6563b17a0f635762d28c0acbc9d553661bd9de21fc99e45a6e76d3d2e011d8a3dab7b1e693ca3eca4e76d7d4ec1896217b7b0da45f3f6786f6ed4175b93da8057154df2f6b6766a933d8b4ccfdb82f7d6ff6bc5d6ea5a50dcb3c8f4bc7539939f8b624bddb520d3bcb53f6194db628b59c0ab5166e5edf1df03172e500bab9decddf4bcadd921101c04e1363996b7e459646adeb6eba9d63c6fc3deadd1452051426dc0ab8a26795babb3c95474fd16565fefddf4bcadd5d964aa73f068286ff79e45a6e76dedd4b2cf9afb94cdf2b65d47b549f75e00b3f2b6866a61b5f59e45a6e66de7c81f9e88170b9d4f0e7916999ab7d5fd26b5ad22b545f3b676096494b7a7d2ab51fea89f5a58ed73587fe1d528d3f3d6d57cd7ae0a8e0ac0b3d4cd31cf22d3f3762e97529762a3e2c7b74007f33fbb2cf690717c7b7a7adaef9d9c805735acdbf964f65d78f4447a35cad4bcfde4d7e44e6c557c83e3d8d37a16999ab79de37eec365e7c45aa12bd9b9eb7ddffdaf5db13bd674f8127fdd37a9d5066a35bf0e80978f454cfacfba56a732f36167f25cf16cddbbadd1d3648f1ac41de369b35528b3f75a6f3ac62386fa557439c3dd5a795f947efe41c569b3caa657adeb6dbdd1a9d4067bef06cd1bc45d6e66e3876e1c73dab6894b7ff8de7818087bc3d819e26af6a39ab49e4b2075cdfcfb0dae4512d83791bf5ac606d9ed1bc519e2d9eb7c07a3c5ac09ec55e63a2678df216588b9de585f8d5249d671545de9e424f93471378fbf7f1cbe5dfce323c8bccca5be2f1f732ff0eaba93c5b266fa1da3772a1c75a6c897785e93cab689ab7487f75d483cb16727b9ce6d943de9e9d098f26f2f6f731df6fc27e9c096f2aef26313b6fe10dc8233e67c3f037ad039e4dca5bd82667e7ada077b4d784d80bac5ef9f91cc3def5ee8fd2bb6c4167ded0b319de6d83da33f4e6f9b9f06898670142efdffe38c273e9fccb2978f61cbd6940a3bc55deed8c8eac9bd9389ab38a623c0be5ad62dbdb1499d2d95531bea45f75283e7f72d4bb42ed9ebeffb82c3f07b095627cb491bf280aeb97ed59ca5bb0648a57e3eccdbe3d4ff1178afecde29c4fdf3ecf6075c093b45ea954ef3b33ce5b208defa76ed76fee2eaf2f46ff5aadef5e1fcf3df59b6e71cf2275797bd6fc3f50ec430e053a06f30000000049454e44ae426082, 1)
;

-- --------------------------------------------------------

--
-- Stand-in structure for view `vistausuarioscamposenorden`
-- (See below for the actual view)
--
CREATE TABLE `vistausuarioscamposenorden` (
`id` int(11)
,`nombres` varchar(255)
,`apellidos` varchar(255)
,`cedula` varchar(10)
,`rol` varchar(20)
,`contrasena` text
,`sexo` varchar(1)
,`nacimiento` date
,`direccion` varchar(255)
,`foto` longblob
,`activo` tinyint(1)
);

-- --------------------------------------------------------

--
-- Structure for view `vistausuarioscamposenorden`
--
DROP TABLE IF EXISTS `vistausuarioscamposenorden`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vistausuarioscamposenorden`  AS SELECT `u`.`id` AS `id`, `u`.`nombres` AS `nombres`, `u`.`apellidos` AS `apellidos`, `u`.`cedula` AS `cedula`, `u`.`rol` AS `rol`, `u`.`contrasena` AS `contrasena`, `u`.`sexo` AS `sexo`, `u`.`nacimiento` AS `nacimiento`, `u`.`direccion` AS `direccion`, `u`.`foto` AS `foto`, `u`.`activo` AS `activo` FROM `usuario` AS `u` ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `asignatura`
--
ALTER TABLE `asignatura`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id_UNIQUE` (`id`),
  ADD KEY `fk_asignatura_carrera_idx` (`id_carrera`);

--
-- Indexes for table `carrera`
--
ALTER TABLE `carrera`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id_UNIQUE` (`id`);

--
-- Indexes for table `distribuir`
--
ALTER TABLE `distribuir`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id_UNIQUE` (`id`),
  ADD KEY `fk_distribuir_usuarios1_idx` (`id_usuario`),
  ADD KEY `fk_distribuir_periodo_academico1_idx` (`id_periodo_academico`),
  ADD KEY `fk_distribuir_asignatura1_idx` (`id_asignatura`);

--
-- Indexes for table `matricula_a_asignatura`
--
ALTER TABLE `matricula_a_asignatura`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id_UNIQUE` (`id`),
  ADD KEY `fk_matricula_a_asignatura_usuario1_idx` (`id_usuario`),
  ADD KEY `fk_matricula_a_asignatura_asignatura1_idx` (`id_asignatura`),
  ADD KEY `fk_matricula_a_asignatura_periodo_academico1_idx` (`id_periodo_academico`);

--
-- Indexes for table `periodo_academico`
--
ALTER TABLE `periodo_academico`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id_UNIQUE` (`id`);

--
-- Indexes for table `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id_UNIQUE` (`id`),
  ADD UNIQUE KEY `cedula_UNIQUE` (`cedula`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `asignatura`
--
ALTER TABLE `asignatura`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `carrera`
--
ALTER TABLE `carrera`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `distribuir`
--
ALTER TABLE `distribuir`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `matricula_a_asignatura`
--
ALTER TABLE `matricula_a_asignatura`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `periodo_academico`
--
ALTER TABLE `periodo_academico`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `usuario`
--
ALTER TABLE `usuario`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `asignatura`
--
ALTER TABLE `asignatura`
  ADD CONSTRAINT `fk_asignatura_carrera` FOREIGN KEY (`id_carrera`) REFERENCES `carrera` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `distribuir`
--
ALTER TABLE `distribuir`
  ADD CONSTRAINT `fk_distribuir_asignatura1` FOREIGN KEY (`id_asignatura`) REFERENCES `asignatura` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_distribuir_periodo_academico1` FOREIGN KEY (`id_periodo_academico`) REFERENCES `periodo_academico` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_distribuir_usuarios1` FOREIGN KEY (`id_usuario`) REFERENCES `usuario` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `matricula_a_asignatura`
--
ALTER TABLE `matricula_a_asignatura`
  ADD CONSTRAINT `fk_matricula_a_asignatura_asignatura1` FOREIGN KEY (`id_asignatura`) REFERENCES `asignatura` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_matricula_a_asignatura_periodo_academico1` FOREIGN KEY (`id_periodo_academico`) REFERENCES `periodo_academico` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_matricula_a_asignatura_usuario1` FOREIGN KEY (`id_usuario`) REFERENCES `usuario` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
