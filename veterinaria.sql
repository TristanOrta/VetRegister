-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 16-05-2018 a las 14:25:14
-- Versión del servidor: 10.1.21-MariaDB
-- Versión de PHP: 5.6.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `veterinaria`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cita`
--

CREATE TABLE `cita` (
  `ID_cita` int(11) NOT NULL,
  `fecha` date NOT NULL,
  `ID_perro` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `especialidad`
--

CREATE TABLE `especialidad` (
  `id` int(11) NOT NULL,
  `descripcion` varchar(100) NOT NULL,
  `desc_corta` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `especialidad`
--

INSERT INTO `especialidad` (`id`, `descripcion`, `desc_corta`) VALUES
(1, '', 'psicologia'),
(2, '', 'cardiologo'),
(3, '', 'Endocrinología'),
(4, '', 'Nefrología'),
(5, '', 'Infectología'),
(666, '', 'prueba'),
(668, 'corazon ', 'cardiologo2'),
(669, ' ', 'cardiologos'),
(670, ' ', 'farma'),
(671, ' ', 'rede'),
(672, ' ', 'holo'),
(674, ' ', 'veterinario'),
(675, ' ', 'ingenieria en sistemas'),
(676, 'egresado del itslp ', 'ingenieria mecanica '),
(677, 'Especialista en toxicos  ', 'Famagologo'),
(678, 'xxx ', 'holos'),
(679, 'dede ', 'Maria'),
(680, 'x ', 'xxxxxx'),
(681, ' ', '121'),
(682, 'wew ', 'ewe'),
(683, 'wew ', 'ew'),
(684, 'zz ', 'zz'),
(685, 'es buena callandose ', 'Jugar basquetbol'),
(686, 'Ciencias naturales ', 'Naturista'),
(687, ' ', 'khkh'),
(688, 'h ', 'aaaaaaaaa'),
(689, ' ', 'biologo'),
(690, '1 ', '12121'),
(691, '121 ', '1222'),
(692, ' ', '1212121212'),
(693, '111111 ', '1111111'),
(694, ' ', '2222222222'),
(695, ' ', '333333'),
(696, ' ', 'azazazazaz'),
(697, 'lo que sea ', 'alpin'),
(698, 'sin descripcion ', '-sin especialidad-');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `humano`
--

CREATE TABLE `humano` (
  `id_humano` int(10) NOT NULL,
  `nombre` varchar(10) NOT NULL,
  `direccion` varchar(10) NOT NULL,
  `num_direccion` int(100) NOT NULL,
  `Coloia` varchar(25) DEFAULT NULL,
  `telefono` varchar(10) NOT NULL,
  `celular` varchar(10) NOT NULL,
  `Nota` varchar(25) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `humano`
--

INSERT INTO `humano` (`id_humano`, `nombre`, `direccion`, `num_direccion`, `Coloia`, `telefono`, `celular`, `Nota`) VALUES
(1, 'oscar', 'priv conte', 120, 'progreso', '7083807', '4441788814', 'es buen pedo'),
(3, 'nestor', 'himno', 32234, 'la himno ', '34234erer', '4234444444', 'es chido'),
(4, 'nestor', 'himno', 32234, 'la himno ', '34234erer', '4234444444', 'es chido'),
(5, 'sdf', '44fdg', 455, 'fdy', 'dfy', 'dfydy', 'dyfydfy'),
(7, ' ', ' ', 0, ' ', ' ', ' ', ' '),
(8, ' ', ' ', 0, ' ', ' ', ' ', ' '),
(9, ' ', ' ', 0, ' ', ' ', ' ', ''),
(12, '22', '2', 3, '3', '', '', ''),
(14, '435', '345', 345, '435', '345', '345', '34535'),
(16, '4353434', '3453453', 34534, '345345', '435', '', ''),
(17, 'sdf', '435', 45, '345', '345', '34534', ''),
(18, 'popo camac', 'verga ', 2000, 'pito', '667', '', 'esta bien pendejo estudia'),
(19, '3e', '13424', 1324124, '1234', '1234', '', ''),
(20, 'pepe', '3', 3434, '34', '4435', '3443', '3444'),
(21, '3234', '2342', 3242, '2342', '234', '234', '234'),
(22, 'wer', 'er', 234, '324', '324', '324', ''),
(23, 'fernando t', 'privada co', 120, 'progreso', '12314', '4245345', 'es chdo'),
(25, 'NESTOR', 'himno naci', 850, 'independecia', '812345', '444444444', ''),
(26, 'WRT', 'AMATISTA', 344, 'VALLE DORADO', '   -', '   -   -', ''),
(27, 'RHTH', 'AMATISTA', 0, 'VALLE DORADO', '444-4444', '444-444-44', 'dghgjf'),
(28, 'FSSFFS', 'ALEJANDRIN', 0, 'VALLE DORADO', '   -', '   -   -', ''),
(29, 'SFSFSF', 'ALEJANDRIN', 0, 'PROGRESO', '   -', '   -   -', '');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `intento`
--

CREATE TABLE `intento` (
  `id` int(10) NOT NULL,
  `no` int(11) NOT NULL,
  `tiempo_inicial` float NOT NULL,
  `tiempo_final` float NOT NULL,
  `diferencia` float NOT NULL,
  `ok_nok` tinyint(1) NOT NULL,
  `id_prueba` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `localizacion`
--

CREATE TABLE `localizacion` (
  `id_localizacion` int(11) NOT NULL,
  `colonia` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `localizacion`
--

INSERT INTO `localizacion` (`id_localizacion`, `colonia`) VALUES
(1, 'VALLE DORADO'),
(6, 'PROGRESO'),
(8, 'SAN LUIS');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `localizacion2`
--

CREATE TABLE `localizacion2` (
  `id_localizacion2` int(11) NOT NULL,
  `calle` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `localizacion2`
--

INSERT INTO `localizacion2` (`id_localizacion2`, `calle`) VALUES
(1, 'AMATISTA'),
(4, 'CORAL'),
(5, 'ALEJANDRINA'),
(6, 'GRANATE');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `medico`
--

CREATE TABLE `medico` (
  `id` int(11) NOT NULL,
  `nombre` varchar(40) NOT NULL,
  `fecha_nac` date NOT NULL,
  `direccion` varchar(40) NOT NULL,
  `telefono_movil` varchar(10) NOT NULL,
  `telefono_fijo` varchar(10) NOT NULL,
  `correo` varchar(30) NOT NULL,
  `ced_prof` varchar(20) NOT NULL,
  `usuario` varchar(25) NOT NULL,
  `password` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `medico`
--

INSERT INTO `medico` (`id`, `nombre`, `fecha_nac`, `direccion`, `telefono_movil`, `telefono_fijo`, `correo`, `ced_prof`, `usuario`, `password`) VALUES
(35, 'Marcos', '2017-02-01', 'kus #123', '123123', '1231234', 'a@d.com', 'akjbjk', '121', '121');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `medico_especialidad`
--

CREATE TABLE `medico_especialidad` (
  `id_ced_prof` varchar(20) NOT NULL,
  `id_especialidad` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `medico_especialidad`
--

INSERT INTO `medico_especialidad` (`id_ced_prof`, `id_especialidad`) VALUES
('akjbjk', 697);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `paciente`
--

CREATE TABLE `paciente` (
  `id` int(11) NOT NULL,
  `nombre` varchar(30) NOT NULL,
  `sexo` char(1) NOT NULL,
  `telefono_fijo` varchar(10) NOT NULL,
  `telefono_movil` varchar(10) NOT NULL,
  `ocupacion` varchar(20) NOT NULL,
  `direccion` varchar(70) NOT NULL,
  `fecha_nac` date NOT NULL,
  `estatura` float NOT NULL,
  `peso` float NOT NULL,
  `estado_civil` varchar(20) NOT NULL,
  `Extremidad_pred` varchar(20) NOT NULL,
  `correo` varchar(30) NOT NULL,
  `naci` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `paciente`
--

INSERT INTO `paciente` (`id`, `nombre`, `sexo`, `telefono_fijo`, `telefono_movil`, `ocupacion`, `direccion`, `fecha_nac`, `estatura`, `peso`, `estado_civil`, `Extremidad_pred`, `correo`, `naci`) VALUES
(1, '123', 'M', '123', '123', '123', '123', '2017-02-01', 123, 123, 'Soltero/a', 'Diestro/a', '123', '123'),
(3, 'Juan ', 'M', '099877654', '123456778', 'Estudiante', 'carillo 250 col.popular', '2014-06-11', 2.2, 27, 'Soltero/a', 'Diestro/a', 'juanito@gmail.com', 'Mexicana'),
(25, 'nestor', 'M', '123', '123', 'estudiante', 'justo', '2017-02-01', 2.3, 28.7, 'Viudo/a', 'Diestro/a', 'nesto', 'mex'),
(26, 'Ana Isabel', 'F', '121212', '121212', 'Ama de casa', 'florencia #211', '1995-07-12', 1.63, 56.8, 'Soltero/a', 'Zurdo/a', 'ali@gmail.com', 'Mexicana');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `perro`
--

CREATE TABLE `perro` (
  `ID_perro` int(11) NOT NULL,
  `nombre` varchar(10) NOT NULL,
  `raza` varchar(20) NOT NULL,
  `id_humano` int(10) NOT NULL,
  `sexo` enum('Macho','Hembra') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `perro`
--

INSERT INTO `perro` (`ID_perro`, `nombre`, `raza`, `id_humano`, `sexo`) VALUES
(3, 'hitler', '', 17, ''),
(4, 'hitler', '', 17, ''),
(5, 'hitler2', '', 17, ''),
(6, 'hilter5', '', 17, ''),
(7, 'el muerto', '', 18, ''),
(8, 'ded', 'Pastor Ale', 19, 'Macho'),
(9, 'puchi', 'Pastor Ing', 20, 'Hembra'),
(10, '324', 'Pastor Ing', 21, ''),
(11, '234234', 'Pastor Ale', 21, 'Hembra'),
(12, '234', 'Pastor Bel', 22, ''),
(13, 'dsdd', 'Pastor Ale', 22, ''),
(14, 'holo', 'Pastor Bel', 22, ''),
(15, 'asassasaas', 'Pastor Ing', 22, ''),
(16, 'lana', 'Pastor Aleman', 23, ''),
(18, 'BOSIE', '', 25, ''),
(19, 'COCO', 'PASTOR BELGA', 26, ''),
(20, 'YTUYU', 'PASTOR ALEMAN', 27, 'Hembra'),
(21, 'SFSFFSFSFS', 'CHIHUAHUA', 28, 'Macho'),
(22, 'SF', 'PASTOR ALEMAN', 29, 'Macho');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `prueba`
--

CREATE TABLE `prueba` (
  `id` int(10) NOT NULL,
  `id_medico` int(11) NOT NULL,
  `id_paciente` int(11) NOT NULL,
  `tiempo_total` float NOT NULL,
  `intentos_ok` int(11) NOT NULL,
  `intentos_nok` int(11) NOT NULL,
  `fecha_hora` datetime NOT NULL,
  `id_tipoprueba` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `razas`
--

CREATE TABLE `razas` (
  `id_raza` int(11) NOT NULL,
  `raza` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `razas`
--

INSERT INTO `razas` (`id_raza`, `raza`) VALUES
(1, 'PASTOR ALEMAN'),
(2, 'PASTOR INGLES'),
(3, 'PASTOR BELGA'),
(4, 'MALTES'),
(5, 'BOXER'),
(6, 'DOBERMAN'),
(7, 'CHIHUAHUA'),
(8, 'PUG'),
(10, 'LABRADOR'),
(11, 'GOLDEN'),
(12, 'SAN BERNARDO'),
(13, 'EFRHR');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipo_prueba`
--

CREATE TABLE `tipo_prueba` (
  `id` int(11) NOT NULL,
  `descripcion` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tipo_prueba`
--

INSERT INTO `tipo_prueba` (`id`, `descripcion`) VALUES
(0, 'estándar'),
(1, 'avanzada');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

CREATE TABLE `usuario` (
  `IDUser` int(11) NOT NULL,
  `user` varchar(10) NOT NULL,
  `pass` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`IDUser`, `user`, `pass`) VALUES
(8, '1', '1');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `cita`
--
ALTER TABLE `cita`
  ADD PRIMARY KEY (`ID_cita`),
  ADD KEY `ID_perro` (`ID_perro`);

--
-- Indices de la tabla `especialidad`
--
ALTER TABLE `especialidad`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `desc_corta` (`desc_corta`);

--
-- Indices de la tabla `humano`
--
ALTER TABLE `humano`
  ADD PRIMARY KEY (`id_humano`);

--
-- Indices de la tabla `intento`
--
ALTER TABLE `intento`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_prueba` (`id_prueba`);

--
-- Indices de la tabla `localizacion`
--
ALTER TABLE `localizacion`
  ADD PRIMARY KEY (`id_localizacion`);

--
-- Indices de la tabla `localizacion2`
--
ALTER TABLE `localizacion2`
  ADD PRIMARY KEY (`id_localizacion2`);

--
-- Indices de la tabla `medico`
--
ALTER TABLE `medico`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `ced_prof_3` (`ced_prof`),
  ADD KEY `ced_prof` (`ced_prof`),
  ADD KEY `ced_prof_2` (`ced_prof`);

--
-- Indices de la tabla `medico_especialidad`
--
ALTER TABLE `medico_especialidad`
  ADD KEY `id_medico` (`id_ced_prof`),
  ADD KEY `id_especialidad` (`id_especialidad`),
  ADD KEY `id_medico_2` (`id_ced_prof`),
  ADD KEY `id_medico_3` (`id_ced_prof`,`id_especialidad`);

--
-- Indices de la tabla `paciente`
--
ALTER TABLE `paciente`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `perro`
--
ALTER TABLE `perro`
  ADD PRIMARY KEY (`ID_perro`),
  ADD KEY `id_humano` (`id_humano`);

--
-- Indices de la tabla `prueba`
--
ALTER TABLE `prueba`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_paciente` (`id_paciente`),
  ADD KEY `id_medico` (`id_medico`),
  ADD KEY `id_tipoprueba` (`id_tipoprueba`);

--
-- Indices de la tabla `razas`
--
ALTER TABLE `razas`
  ADD PRIMARY KEY (`id_raza`);

--
-- Indices de la tabla `tipo_prueba`
--
ALTER TABLE `tipo_prueba`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`IDUser`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `cita`
--
ALTER TABLE `cita`
  MODIFY `ID_cita` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `especialidad`
--
ALTER TABLE `especialidad`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=699;
--
-- AUTO_INCREMENT de la tabla `humano`
--
ALTER TABLE `humano`
  MODIFY `id_humano` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;
--
-- AUTO_INCREMENT de la tabla `intento`
--
ALTER TABLE `intento`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `localizacion`
--
ALTER TABLE `localizacion`
  MODIFY `id_localizacion` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
--
-- AUTO_INCREMENT de la tabla `localizacion2`
--
ALTER TABLE `localizacion2`
  MODIFY `id_localizacion2` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT de la tabla `medico`
--
ALTER TABLE `medico`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=36;
--
-- AUTO_INCREMENT de la tabla `paciente`
--
ALTER TABLE `paciente`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;
--
-- AUTO_INCREMENT de la tabla `perro`
--
ALTER TABLE `perro`
  MODIFY `ID_perro` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;
--
-- AUTO_INCREMENT de la tabla `prueba`
--
ALTER TABLE `prueba`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `razas`
--
ALTER TABLE `razas`
  MODIFY `id_raza` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;
--
-- AUTO_INCREMENT de la tabla `usuario`
--
ALTER TABLE `usuario`
  MODIFY `IDUser` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `cita`
--
ALTER TABLE `cita`
  ADD CONSTRAINT `cita_ibfk_1` FOREIGN KEY (`ID_perro`) REFERENCES `perro` (`ID_perro`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `intento`
--
ALTER TABLE `intento`
  ADD CONSTRAINT `intento_ibfk_1` FOREIGN KEY (`id_prueba`) REFERENCES `prueba` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `medico_especialidad`
--
ALTER TABLE `medico_especialidad`
  ADD CONSTRAINT `medico_especialidad_ibfk_1` FOREIGN KEY (`id_especialidad`) REFERENCES `especialidad` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `medico_especialidad_ibfk_2` FOREIGN KEY (`id_ced_prof`) REFERENCES `medico` (`ced_prof`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `perro`
--
ALTER TABLE `perro`
  ADD CONSTRAINT `perro_ibfk_2` FOREIGN KEY (`id_humano`) REFERENCES `humano` (`id_humano`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `prueba`
--
ALTER TABLE `prueba`
  ADD CONSTRAINT `prueba_ibfk_3` FOREIGN KEY (`id_tipoprueba`) REFERENCES `tipo_prueba` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `prueba_ibfk_4` FOREIGN KEY (`id_medico`) REFERENCES `medico` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `prueba_ibfk_5` FOREIGN KEY (`id_paciente`) REFERENCES `paciente` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
