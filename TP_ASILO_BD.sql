--TABLA CENTROS
CREATE TABLE AS_CENTRO (
	ID_CENTRO NUMBER(5) NOT NULL PRIMARY KEY, 
	NOMBRE VARCHAR2(25),
	TELEFONO VARCHAR2(20),
	DIRECCION VARCHAR2(50));

--TABLA ACTIVIDADES
CREATE TABLE AS_ACTIVIDAD (
	ID_ACTIVIDAD NUMBER(5) NOT NULL PRIMARY KEY,
	NOMBRE VARCHAR2(20),
	DESCRIPCION VARCHAR2(50));

--TABLA APOYOS
CREATE TABLE AS_APOYO(
	ID_APOYO NUMBER(5) NOT NULL PRIMARY KEY,
	NOMBRE VARCHAR2(30),
	DESCRIPCION VARCHAR2(50));

--TIPO DE EMPLEADO
CREATE TABLE AS_TIPO_EMPLEADO (
	ID_TIPO_EMPLEADO NUMBER(5) NOT NULL PRIMARY KEY,
	TIPO_EMPLEADO VARCHAR2(20));
	
--TIPO DE USUARIO
CREATE TABLE AS_TIPO_USUARIO (
	ID_TIPO_USUARIO NUMBER(5) NOT NULL PRIMARY KEY,
	TIPO_USUARIO VARCHAR2(20));

--TABLA NACIONALIDAD
CREATE TABLE AS_NACIONALIDAD (
	ID_NACIONALIDAD NUMBER(5) NOT NULL PRIMARY KEY, 
	NACIONALIDAD VARCHAR2(20));
	
--TABAL SEXO
CREATE TABLE AS_SEXO (
	ID_SEXO NUMBER(5) NOT NULL PRIMARY KEY,
	SEXO VARCHAR2(20));

--TABLA TURNO
CREATE TABLE AS_TURNO (
	ID_TURNO NUMBER(5) NOT NULL PRIMARY KEY,
	TURNO VARCHAR2(20));

--TABLA ESTADO CIVIL
CREATE TABLE AS_ESTADO_CIVIL (
	ID_ESTADO_CIVIL NUMBER(5) NOT NULL PRIMARY KEY, 
	ESTADO_CIVIL VARCHAR2(20));

--TABLA PARENTESCO
CREATE TABLE AS_PARENTESCO_CONTACTO (
	ID_PARENTESCO NUMBER(5) NOT NULL PRIMARY KEY,
	PARENTESCO VARCHAR2(20));
	
--TABLA EMPLEADO
CREATE TABLE AS_EMPLEADO (
	ID_EMPLEADO NUMBER(5) NOT NULL PRIMARY KEY,
	NOMBRE VARCHAR2(20),
	APELLIDO_P VARCHAR2(20),
	APELLIDO_M VARCHAR2(20),
	ID_ESTADO_CIVIL NUMBER(5),
	ID_SEXO NUMBER(5),
	ID_NACIONALIDAD NUMBER(5),
	ID_TURNO NUMBER(5),
	DOMICILIO VARCHAR2(50),
	ID_TIPO_EMPLEADO NUMBER(5),
	ID_CENTRO NUMBER(5),
	CONSTRAINT FK_IS_SEXO FOREIGN KEY(ID_SEXO) REFERENCES AS_SEXO(ID_SEXO),
	CONSTRAINT FK_ID_ESTADO_CIVIL FOREIGN KEY(ID_ESTADO_CIVIL) REFERENCES AS_ESTADO_CIVIL(ID_ESTADO_CIVIL),
	CONSTRAINT FK_ID_NACIONALIDAD FOREIGN KEY(ID_NACIONALIDAD) REFERENCES AS_NACIONALIDAD(ID_NACIONALIDAD),
	CONSTRAINT FK_ID_TURNO FOREIGN KEY(ID_TURNO) REFERENCES AS_TURNO(ID_TURNO),
	CONSTRAINT FK_ID_TIPO_EMPLEADO FOREIGN KEY(ID_TIPO_EMPLEADO) REFERENCES AS_TIPO_EMPLEADO(ID_TIPO_EMPLEADO),
	CONSTRAINT FK_ID_CENTRO FOREIGN KEY(ID_CENTRO) REFERENCES AS_CENTRO(ID_CENTRO));
	
--TABLA USUSARIO
CREATE TABLE AS_USUARIO (
	ID_USUARIO NUMBER(5) NOT NULL PRIMARY KEY,
	ID_EMPLEADO NUMBER(5),
	ID_TIPO_USUARIO NUMBER(5),
	PASSWORD VARCHAR2(20),
	CONSTRAINT FK_ID_EMPLEADO FOREIGN KEY(ID_EMPLEADO) REFERENCES AS_EMPLEADO(ID_EMPLEADO),
	CONSTRAINT FK_ID_TIPO_USUARIO FOREIGN KEY(ID_TIPO_USUARIO) REFERENCES AS_TIPO_USUARIO(ID_TIPO_USUARIO));
	
--TABLA CONTACTO
CREATE TABLE AS_CONTACTO (
	ID_CONTACTO NUMBER(5) NOT NULL PRIMARY KEY,
	NOMBRE VARCHAR2(20),
	APELLIDO_P VARCHAR2(20),
	APELLIDO_M VARCHAR2(20),
	ID_SEXO NUMBER(5),
	TELEFONO VARCHAR2(10), 
	ID_PARENTESCO NUMBER(5),
	CONSTRAINT FK_ID_SEXO_CONTACTO FOREIGN KEY(ID_SEXO) REFERENCES AS_SEXO(ID_SEXO),
	CONSTRAINT FK_ID_PARENTESCO FOREIGN KEY(ID_PARENTESCO) REFERENCES AS_PARENTESCO_CONTACTO(ID_PARENTESCO));
	
--TABLA ADULTO
CREATE TABLE AS_ADULTO (
	ID_ADULTO NUMBER(5) NOT NULL PRIMARY KEY,
	NOMBRE VARCHAR2(20),
	APELLIDO_P VARCHAR2(20),
	APELLIDO_M VARCHAR2(20),
	ID_SEXO NUMBER(5),
	EDAD NUMBER(3),
	ID_CONTACTO NUMBER(5),
	ID_CENTRO NUMBER(5),
	CONSTRAINT FK_ID_SEXO_ADULTO FOREIGN KEY(ID_SEXO) REFERENCES AS_SEXO(ID_SEXO),
	CONSTRAINT FK_ID_CONTACTO FOREIGN KEY(ID_CONTACTO) REFERENCES AS_CONTACTO(ID_CONTACTO),
	CONSTRAINT FK_ID_CENTRO_ADULTO FOREIGN KEY(ID_CENTRO) REFERENCES AS_CENTRO(ID_CENTRO));
	
--TABLA CENTRO ACTIVIDADES
CREATE TABLE AS_CENTRO_ACTIVIDAD(
	ID_CENTRO NUMBER(5),
	ID_ACTIVIDAD NUMBER(5),
	DESCRIPCION VARCHAR2(50),
	CONSTRAINT FK_ID_CENTRO_ACTIVIDAD FOREIGN KEY(ID_CENTRO) REFERENCES AS_CENTRO(ID_CENTRO),
	CONSTRAINT FK_ID_ACTIVIDAD FOREIGN KEY(ID_ACTIVIDAD) REFERENCES AS_ACTIVIDAD(ID_ACTIVIDAD));
	
--TABLA ADULTO APOYO
CREATE TABLE AS_ADULTO_APOYO (
	ID_ADULTO NUMBER(5),
	ID_APOYO NUMBER(5),
	DESCRIPCION VARCHAR2(50),
	CONSTRAINT FK_ID_ADULTO FOREIGN KEY(ID_ADULTO) REFERENCES AS_ADULTO(ID_ADULTO),
	CONSTRAINT FK_ID_APOYO FOREIGN KEY(ID_APOYO) REFERENCES AS_APOYO(ID_APOYO));

--TABLA ADULTO ACTIVIDAD
CREATE TABLE AS_ADULTO_ACTIVIDAD (
	ID_ADULTO NUMBER(5),
	ID_ACTIVIDAD NUMBER(5),
	DESCRIPCION VARCHAR2(50),
	CONSTRAINT FK_ID_ADULTO_ACTIVIDAD FOREIGN KEY(ID_ADULTO) REFERENCES AS_ADULTO(ID_ADULTO),
	CONSTRAINT FK_ID_ACTIVIDAD_ACTIVIDAD FOREIGN KEY(ID_ACTIVIDAD) REFERENCES AS_ACTIVIDAD(ID_ACTIVIDAD));

--DATOS DE LA TABLA TURNO
INSERT INTO AS_TURNO VALUES(1, 'MATUTINO');
INSERT INTO AS_TURNO VALUES(2, 'VESPERTINO');
INSERT INTO AS_TURNO VALUES(3, 'NOCTURNO');

--DATOS DE LA TABLA TIPO USUARIO
INSERT INTO AS_TIPO_USUARIO VALUES(1,'ADMINISTRADOR');
INSERT INTO AS_TIPO_USUARIO VALUES(2,'EMPLEADO');

--DATOS DE LA TABLA PARENTESCO
INSERT INTO AS_PARENTESCO_CONTACTO VALUES(1, 'HIJO/A');
INSERT INTO AS_PARENTESCO_CONTACTO VALUES(2, 'HERMANO/A');
INSERT INTO AS_PARENTESCO_CONTACTO VALUES(3, 'PRIMO/A');
INSERT INTO AS_PARENTESCO_CONTACTO VALUES(4, 'SOBRINO/A');
INSERT INTO AS_PARENTESCO_CONTACTO VALUES(5, 'NIETO');
INSERT INTO AS_PARENTESCO_CONTACTO VALUES(6, 'NURERA/YERNO');
INSERT INTO AS_PARENTESCO_CONTACTO VALUES(7, 'AMIGO');

--DATOS DE LA TABLA NACIONALIDAD
INSERT INTO AS_NACIONALIDAD VALUES(1, 'MEXICANA');
INSERT INTO AS_NACIONALIDAD VALUES(2, 'EXTRANJERA');

--DATOS DE LA TABLA ESTADO CIVIL
INSERT INTO AS_ESTADO_CIVIL VALUES(1, 'SOLTERO/A');
INSERT INTO AS_ESTADO_CIVIL VALUES(2, 'COMPROMETIDO/A');
INSERT INTO AS_ESTADO_CIVIL VALUES(3, 'CASADO/A');
INSERT INTO AS_ESTADO_CIVIL VALUES(4, 'DIVORCIADO/A');
INSERT INTO AS_ESTADO_CIVIL VALUES(5, 'VIUDO/A');

--DATOS DE LA TABLA SEXO
INSERT INTO AS_SEXO VALUES(1,'MASCULINO');
INSERT INTO AS_SEXO VALUES(2,'FEMENINO');

--DATOS DE LA TABLA TIPO DE EMPLEADOS
INSERT INTO AS_TIPO_EMPLEADO VALUES(1, 'JEFE');
INSERT INTO AS_TIPO_EMPLEADO VALUES(2, 'SECRETARIA');
INSERT INTO AS_TIPO_EMPLEADO VALUES(3, 'ENFERMERO');
INSERT INTO AS_TIPO_EMPLEADO VALUES(4, 'PSIC�LOGO');
INSERT INTO AS_TIPO_EMPLEADO VALUES(5, 'MAESTRO');
INSERT INTO AS_TIPO_EMPLEADO VALUES(6, 'RECEPSIONISTA');

--DATOS DE LA TABLA CENTRO
INSERT INTO AS_CENTRO VALUES(1, 'CASA DE RETIRO GUADALUPE', '83549272', 'SAN LUIS 302, GUADALUP');
INSERT INTO AS_CENTRO VALUES(2, 'CASA DE RETIRO MONTERREY', '30606499', 'AV. LOS LEONES 257, MONTERREY');

--DATOS DE LA TABLA EMPLEADOS
INSERT INTO AS_EMPLEADO VALUES(1, 'BRANDON', 'MARTINEZ', 'ALANIS', 1, 1, 1, 1, 'AV. SANTO 459', 1, 1);
INSERT INTO AS_EMPLEADO VALUES(2, 'FABI�N', 'CA�ARDO', 'MU�OZ', 2, 1, 1, 2, 'AV. SANTO 459', 5, 2);
INSERT INTO AS_EMPLEADO VALUES(3, 'ALINA', 'RUIZ', 'DIAZ', 1, 2, 1, 2, 'AV. SANTO 459', 2, 1);

--DATOS DE LA TABLA CONTACTOS
INSERT INTO AS_CONTACTO VALUES(1,'ADAN','GALLEGO','LORENZO',1,'69331040',1);
INSERT INTO AS_CONTACTO VALUES(2,'GUSTAVO','GOMEZ','SALAZAR',1,'69778900',5);

--DATOS DE LA TABLA ADULTOS
INSERT INTO AS_ADULTO VALUES(1, 'TALIA', 'GALLEGO', 'SUA�A', 2, 75, 1, 1);
INSERT INTO AS_ADULTO VALUES(2, 'ALFREDO', 'CORNELIO', 'GOMEZ', 2, 72, 2, 2);

--DATO DE UDSUARIO
INSERT INTO AS_USUARIO VALUES(24998, 1, 1, 'BOMA98');

--DATOS DE LA TABALA ACTIVIDADES
INSERT INTO AS_ACTIVIDAD VALUES(1, 'BINGO', '');
INSERT INTO AS_ACTIVIDAD VALUES(2, 'DANZA', '');
INSERT INTO AS_ACTIVIDAD VALUES(3, 'DOMIN�', '');
INSERT INTO AS_ACTIVIDAD VALUES(4, 'PINTAR', '');

--DATOS DE LA TABLA APOYOS
INSERT INTO AS_APOYO VALUES(1,'SERVICIO MEDICO','');
INSERT INTO AS_APOYO VALUES(2,'ATENCION PSICO-SOCIAL','');
INSERT INTO AS_APOYO VALUES(3,'TRANSPORTE DE LOS RESIDENTES','');
INSERT INTO AS_APOYO VALUES(4,'ADMINISTRACION DE F�RMACOS','');

--STORED PROCEDURE LOGIN
CREATE OR REPLACE PROCEDURE spBuscarUsuarioContrase�a(c_cursor OUT SYS_REFCURSOR, p_usuario IN NUMBER, p_password IN VARCHAR2)
IS 
BEGIN
	OPEN c_cursor FOR SELECT ASU.ID_USUARIO, ASE.NOMBRE, ASTE.TIPO_USUARIO, ASU.PASSWORD
	FROM AS_USUARIO ASU INNER JOIN AS_EMPLEADO ASE ON ASU.ID_EMPLEADO = ASE.ID_EMPLEADO
	INNER JOIN AS_TIPO_USUARIO ASTE ON ASU.ID_TIPO_USUARIO = ASTE.ID_TIPO_USUARIO
	WHERE ASU.ID_USUARIO = p_usuario AND ASU.PASSWORD = p_password;
END;

--STORED PROCEDURE ESTADO CIVIL
CREATE OR REPLACE PROCEDURE spDatosEstadoCivil(c_cursor OUT SYS_REFCURSOR)
IS
BEGIN
	OPEN c_cursor FOR SELECT * FROM AS_ESTADO_CIVIL;
END;

--STORED PROCEDURE SEXO
CREATE OR REPLACE PROCEDURE spDatosSexo(c_cursor OUT SYS_REFCURSOR)
IS
BEGIN
	OPEN c_cursor FOR SELECT * FROM AS_SEXO;
END;

--STORED PROCEDURE NACIONALIDAD
CREATE OR REPLACE PROCEDURE spDatosNacionalidad(c_cursor OUT SYS_REFCURSOR)
IS
BEGIN
	OPEN c_cursor FOR SELECT * FROM AS_NACIONALIDAD;
END;

--STORED PROCEDURE TURNO
CREATE OR REPLACE PROCEDURE spDatosTurno(c_cursor OUT SYS_REFCURSOR)
IS
BEGIN
	OPEN c_cursor FOR SELECT * FROM AS_TURNO;
END;

--STORED PROCEDURE PARENTESCO
CREATE OR REPLACE PROCEDURE spDatosParentesco(c_cursor OUT SYS_REFCURSOR)
IS
BEGIN
	OPEN c_cursor FOR SELECT * FROM AS_PARENTESCO_CONTACTO;
END;

--STORED PROCEDURE TIPO DE EMPLEADO
CREATE OR REPLACE PROCEDURE spBuscarTipoEmp(c_cursor OUT SYS_REFCURSOR,p_idTipoEmp IN NUMBER)
IS
BEGIN
	OPEN c_cursor FOR SELECT * FROM AS_TIPO_EMPLEADO WHERE ID_TIPO_EMPLEADO=p_idTipoEmp;
END;

CREATE OR REPLACE PROCEDURE spAgregarTipoEmp(p_idTipoEmp IN NUMBER,p_Tipo IN VARCHAR2)
IS
BEGIN
	INSERT INTO AS_TIPO_EMPLEADO VALUES (p_idTipoEmp,p_Tipo);
END;

CREATE OR REPLACE PROCEDURE spModificarTipoEmp(p_Tipo IN VARCHAR2,p_idTipoEmp IN NUMBER)
IS
BEGIN
	UPDATE AS_TIPO_EMPLEADO SET TIPO_EMPLEADO=p_Tipo WHERE ID_TIPO_EMPLEADO=p_idTipoEmp;
END;

CREATE OR REPLACE PROCEDURE spBorrarTipoEmp(p_idTipoEmp IN NUMBER)
IS
BEGIN
	DELETE AS_TIPO_EMPLEADO WHERE ID_TIPO_EMPLEADO=p_idTipoEmp;
END;

CREATE OR REPLACE PROCEDURE spDatosTipoEmp(c_cursor OUT SYS_REFCURSOR)
IS
BEGIN
	OPEN c_cursor FOR SELECT * FROM AS_TIPO_EMPLEADO;
END;

--STORED PROCEDURE CENTRO
CREATE OR REPLACE PROCEDURE spBuscarCentro(c_cursor OUT SYS_REFCURSOR,p_idCentro IN NUMBER)
IS
BEGIN
	OPEN c_cursor FOR SELECT * FROM AS_CENTRO WHERE ID_CENTRO=p_idCentro;
END;

CREATE OR REPLACE PROCEDURE spAgregarCentro(p_idCentro IN NUMBER,p_nombre IN VARCHAR,p_telefono IN VARCHAR,p_direccion IN VARCHAR)
IS
BEGIN
	INSERT INTO AS_CENTRO VALUES (p_idCentro,p_nombre,p_telefono,p_direccion);
END;

CREATE OR REPLACE PROCEDURE spModificarCentro(p_nombre IN VARCHAR,p_telefono IN VARCHAR,p_direccion IN VARCHAR,p_idCentro IN NUMBER)
IS
BEGIN
	UPDATE AS_CENTRO SET NOMBRE=p_nombre,TELEFONO=p_telefono,DIRECCION=p_direccion WHERE ID_CENTRO=p_idCentro;
END;

CREATE OR REPLACE PROCEDURE spBorrarCentro(p_idCentro IN NUMBER)
IS
BEGIN
	DELETE AS_CENTRO WHERE ID_CENTRO=p_idCentro;
END;

CREATE OR REPLACE PROCEDURE spBuscarTodosCentros(c_cursor OUT SYS_REFCURSOR)
IS
BEGIN
	OPEN c_cursor FOR SELECT * FROM AS_CENTRO;
END;

--STORED PROCEDURE ACTIVIDADES
CREATE OR REPLACE PROCEDURE spBuscarActividad(c_cursor OUT SYS_REFCURSOR,p_idActividad IN NUMBER)
IS
BEGIN
	OPEN c_cursor FOR SELECT * FROM AS_ACTIVIDAD WHERE ID_ACTIVIDAD = p_idActividad;
END;

CREATE OR REPLACE PROCEDURE spAgregarActividad(p_idActividad IN NUMBER, p_nombre IN VARCHAR2, p_descripcion IN VARCHAR2)
IS
BEGIN
	INSERT INTO AS_ACTIVIDAD VALUES(p_idActividad, p_nombre, p_descripcion);
END;

CREATE OR REPLACE PROCEDURE spModificarActividad(p_idActividad IN NUMBER, p_nombre IN VARCHAR2, p_descripcion IN VARCHAR2)
IS
BEGIN
	UPDATE AS_ACTIVIDAD SET NOMBRE = p_nombre, DESCRIPCION = p_descripcion WHERE ID_ACTIVIDAD = p_idActividad;
END;

CREATE OR REPLACE PROCEDURE spBorrarActividad(p_idActividad IN NUMBER)
IS
BEGIN
	DELETE FROM AS_ACTIVIDAD WHERE ID_ACTIVIDAD = p_idActividad;
END;

CREATE OR REPLACE PROCEDURE spBuscarTodasActividades(c_cursor OUT SYS_REFCURSOR)
IS
BEGIN
	OPEN c_cursor FOR SELECT * FROM AS_ACTIVIDAD;
END;

--STORED PROCEDURE ACTIVIDADES CENTRO
CREATE OR REPLACE PROCEDURE spBuscarActividadCentro(c_cursor OUT SYS_REFCURSOR, p_idCentro IN NUMBER)
IS
BEGIN
	OPEN c_cursor FOR SELECT ASCA.ID_CENTRO, ASCE.NOMBRE, ASA.ID_ACTIVIDAD, ASA.NOMBRE AS NOMBRE_ACTIVIDAD,ASCA.DESCRIPCION
	FROM AS_CENTRO_ACTIVIDAD ASCA INNER JOIN AS_CENTRO ASCE ON ASCA.ID_CENTRO = ASCE.ID_CENTRO
	INNER JOIN AS_ACTIVIDAD ASA ON ASCA.ID_ACTIVIDAD = ASA.ID_ACTIVIDAD
	WHERE ASCA.ID_CENTRO = p_idCentro;
END;

CREATE OR REPLACE PROCEDURE spBuscarActividadCentro2(c_cursor OUT SYS_REFCURSOR, p_idCentro IN NUMBER, p_idActividad IN NUMBER)
IS
BEGIN
	OPEN c_cursor FOR SELECT * FROM AS_CENTRO_ACTIVIDAD
	WHERE ID_CENTRO = p_idCentro AND ID_ACTIVIDAD = p_idActividad;
END;

CREATE OR REPLACE PROCEDURE spAgregarActividadCentro(p_idCentro IN NUMBER, p_idActividad IN NUMBER, p_Descripcion IN VARCHAR2)
IS
BEGIN
	INSERT INTO AS_CENTRO_ACTIVIDAD VALUES (p_idCentro, p_idActividad, p_Descripcion);
END;

CREATE OR REPLACE PROCEDURE spModificarActividadCentro(p_idCentro IN NUMBER, p_idActividad IN NUMBER, p_Descripcion IN VARCHAR2)
IS
BEGIN
	UPDATE AS_CENTRO_ACTIVIDAD SET ID_ACTIVIDAD = p_idActividad, DESCRIPCION = p_Descripcion WHERE ID_CENTRO = p_idCentro AND ID_ACTIVIDAD = p_idActividad;
END;

CREATE OR REPLACE PROCEDURE spBorrarActividadCentro(p_idCentro IN NUMBER, p_idActividad IN NUMBER)
IS
BEGIN
	DELETE FROM AS_CENTRO_ACTIVIDAD WHERE ID_CENTRO = p_idCentro AND ID_ACTIVIDAD = p_idActividad;
END;

CREATE OR REPLACE PROCEDURE spDatosActividadCentro(c_cursor OUT SYS_REFCURSOR)
IS
BEGIN
	OPEN c_cursor FOR SELECT ASCA.ID_CENTRO, ASCE.NOMBRE, ASA.ID_ACTIVIDAD, ASA.NOMBRE AS NOMBRE_ACTIVIDAD,ASCA.DESCRIPCION
	FROM AS_CENTRO_ACTIVIDAD ASCA INNER JOIN AS_CENTRO ASCE ON ASCA.ID_CENTRO = ASCE.ID_CENTRO
	INNER JOIN AS_ACTIVIDAD ASA ON ASCA.ID_ACTIVIDAD = ASA.ID_ACTIVIDAD;
END;

--STORED PROCEDURE ACTIVIDAD ADULTO
CREATE OR REPLACE PROCEDURE spBuscarActividadAdulto(c_cursor OUT SYS_REFCURSOR, p_idAdulto IN NUMBER)
IS
BEGIN
	OPEN c_cursor FOR SELECT ASA.ID_ADULTO, ASA.NOMBRE, ASA.APELLIDO_P, ASA.APELLIDO_M, ASAC.ID_ACTIVIDAD, ASAC.NOMBRE, ASAA.DESCRIPCION
	FROM AS_ADULTO_ACTIVIDAD ASAA INNER JOIN AS_ADULTO ASA ON ASAA.ID_ADULTO = ASA.ID_ADULTO
	INNER JOIN AS_ACTIVIDAD ASAC ON ASAA.ID_ACTIVIDAD = ASAC.ID_ACTIVIDAD
	WHERE ASAA.ID_ADULTO = p_idAdulto;
END;

CREATE OR REPLACE PROCEDURE spBuscarActividadAdulto2(c_cursor OUT SYS_REFCURSOR, p_idAdulto IN NUMBER, p_idActividad IN NUMBER)
IS
BEGIN
	OPEN c_cursor FOR SELECT * FROM AS_ADULTO_ACTIVIDAD WHERE ID_ADULTO = p_idAdulto AND ID_ACTIVIDAD = p_idActividad;
END;

CREATE OR REPLACE PROCEDURE spAgregarActividadAdulto(p_idAdulto IN NUMBER, p_idActividad IN NUMBER, p_Descripcion IN VARCHAR2)
IS
BEGIN
	INSERT INTO AS_ADULTO_ACTIVIDAD VALUES(p_idAdulto, p_idActividad, p_Descripcion);
END;

CREATE OR REPLACE PROCEDURE spModificarActividadAdulto(p_idAdulto IN NUMBER, p_idActividad IN NUMBER, p_Descripcion IN VARCHAR2)
IS
BEGIN
	UPDATE AS_ADULTO_ACTIVIDAD SET DESCRIPCION = p_Descripcion WHERE ID_ADULTO = p_idAdulto AND ID_ACTIVIDAD = p_idActividad;
END;

CREATE OR REPLACE PROCEDURE spBorrarActividadAdulto(p_idAdulto IN NUMBER, p_idActividad IN NUMBER)
IS
BEGIN
	DELETE FROM AS_ADULTO_ACTIVIDAD WHERE ID_ADULTO = p_idAdulto AND ID_ACTIVIDAD = p_idActividad;
END;

CREATE OR REPLACE PROCEDURE spDatosActividadAdulto(c_cursor OUT SYS_REFCURSOR)
IS
BEGIN
	OPEN c_cursor FOR SELECT ASA.ID_ADULTO, ASA.NOMBRE, ASA.APELLIDO_P, ASA.APELLIDO_M, ASAC.ID_ACTIVIDAD, ASAC.NOMBRE, ASAA.DESCRIPCION 
	FROM AS_ADULTO_ACTIVIDAD ASAA INNER JOIN AS_ADULTO ASA ON ASAA.ID_ADULTO = ASA.ID_ADULTO
	INNER JOIN AS_ACTIVIDAD ASAC ON ASAA.ID_ACTIVIDAD = ASAC.ID_ACTIVIDAD;
END;

--STORED PROCEDURE APOYOS
CREATE OR REPLACE PROCEDURE spBuscarApoyo(c_cursor OUT SYS_REFCURSOR, p_idApoyo IN NUMBER)
IS
BEGIN
	OPEN c_cursor FOR SELECT * FROM AS_APOYO WHERE ID_APOYO = p_idApoyo;
END;

CREATE OR REPLACE PROCEDURE spAgregarApoyo(p_idApoyo IN NUMBER, p_nombre IN VARCHAR2, p_descripcion IN VARCHAR2)
IS
BEGIN
	INSERT INTO AS_APOYO VALUES(p_idApoyo, p_nombre, p_descripcion);
END;

CREATE OR REPLACE PROCEDURE spModificarApoyo(p_idApoyo IN NUMBER, p_nombre IN VARCHAR2, p_descripcion IN VARCHAR2)
IS
BEGIN
	UPDATE AS_APOYO SET NOMBRE = p_nombre, DESCRIPCION = p_descripcion WHERE ID_APOYO = p_idApoyo;
END;

CREATE OR REPLACE PROCEDURE spBorrarApoyo(p_idApoyo IN NUMBER)
IS
BEGIN
	DELETE FROM AS_APOYO WHERE ID_APOYO = p_idApoyo;
END;

CREATE OR REPLACE PROCEDURE spBuscarTodosApoyos(c_cursor OUT SYS_REFCURSOR)
IS
BEGIN
	OPEN c_cursor FOR SELECT * FROM AS_APOYO;
END;

--STORED PROCEDURE ADULTO APOYO
CREATE OR REPLACE PROCEDURE spBuscarAdultoApoyo(c_cursor OUT SYS_REFCURSOR, p_idAdulto IN NUMBER)
IS
BEGIN
	OPEN c_cursor FOR SELECT ASA.ID_ADULTO, ASA.NOMBRE, ASA.APELLIDO_P, ASA.APELLIDO_M, ASP.ID_APOYO, ASP.NOMBRE, ASDA.DESCRIPCION
	FROM AS_ADULTO_APOYO ASDA INNER JOIN AS_ADULTO ASA ON ASDA.ID_ADULTO = ASA.ID_ADULTO
	INNER JOIN AS_APOYO ASP ON ASDA.ID_APOYO = ASP.ID_APOYO
	WHERE ASDA.ID_ADULTO = p_idAdulto;
END;

CREATE OR REPLACE PROCEDURE spBuscarAdultoApoyo2(c_cursor OUT SYS_REFCURSOR, p_idAdulto IN NUMBER, p_idApoyo IN NUMBER)
IS
BEGIN
	OPEN c_cursor FOR SELECT * FROM AS_ADULTO_APOYO
	WHERE ID_ADULTO = p_idAdulto AND ID_APOYO = p_idApoyo;
END;

CREATE OR REPLACE PROCEDURE spAgregarAdultoApoyo(p_idAdulto IN NUMBER, p_idApoyo IN NUMBER, p_Descripcion IN VARCHAR2)
IS
BEGIN
	INSERT INTO AS_ADULTO_APOYO VALUES (p_idAdulto, p_idApoyo, p_Descripcion);
END;

CREATE OR REPLACE PROCEDURE spModificarAdultoApoyo(p_idAdulto IN NUMBER, p_idApoyo IN NUMBER, p_Descripcion IN VARCHAR2)
IS
BEGIN
	UPDATE AS_ADULTO_APOYO SET ID_APOYO = p_idAdulto, DESCRIPCION = p_descripcion WHERE ID_ADULTO = p_idAdulto;
END;

CREATE OR REPLACE PROCEDURE spBorrarAdultoApoyo(p_idAdulto IN NUMBER, p_idApoyo IN NUMBER)
IS
BEGIN
	DELETE FROM AS_ADULTO_APOYO WHERE ID_ADULTO = p_idAdulto AND ID_APOYO = p_idApoyo;
END;

CREATE OR REPLACE PROCEDURE spDatosAdultoApoyos(c_cursor OUT SYS_REFCURSOR)
IS
BEGIN
	OPEN c_cursor FOR SELECT ASA.ID_ADULTO, ASA.NOMBRE, ASA.APELLIDO_P, ASA.APELLIDO_M, ASP.ID_APOYO, ASP.NOMBRE, ASDA.DESCRIPCION
	FROM AS_ADULTO_APOYO ASDA INNER JOIN AS_ADULTO ASA ON ASDA.ID_ADULTO = ASA.ID_ADULTO
	INNER JOIN AS_APOYO ASP ON ASDA.ID_APOYO = ASP.ID_APOYO;
END;

--STORED PROCEDURE EMPLEADO
CREATE OR REPLACE PROCEDURE spBuscarEmpleado(c_cursor OUT SYS_REFCURSOR,p_idEmpleado IN NUMBER)
IS
BEGIN
	OPEN c_cursor FOR SELECT ASEMP.ID_EMPLEADO, ASEMP.NOMBRE, ASEMP.APELLIDO_P, ASEMP.APELLIDO_M, ASE.ESTADO_CIVIL, ASS.SEXO, ASN.NACIONALIDAD, AST.TURNO, ASEMP.DOMICILIO, ASTE.TIPO_EMPLEADO, ASCE.NOMBRE 
	FROM AS_EMPLEADO ASEMP INNER JOIN AS_ESTADO_CIVIL ASE ON ASEMP.ID_ESTADO_CIVIL = ASE.ID_ESTADO_CIVIL
	INNER JOIN AS_SEXO ASS ON ASEMP.ID_SEXO = ASS.ID_SEXO
	INNER JOIN AS_NACIONALIDAD ASN ON ASEMP.ID_NACIONALIDAD = ASN.ID_NACIONALIDAD
	INNER JOIN AS_TURNO AST ON ASEMP.ID_TURNO = AST.ID_TURNO
	INNER JOIN AS_TIPO_EMPLEADO ASTE ON ASEMP.ID_TIPO_EMPLEADO = ASTE.ID_TIPO_EMPLEADO
	INNER JOIN AS_CENTRO ASCE ON ASEMP.ID_CENTRO = ASCE.ID_CENTRO
	WHERE ID_EMPLEADO=p_idEmpleado;
END;

CREATE OR REPLACE PROCEDURE spBuscarEmpleado2(c_cursor OUT SYS_REFCURSOR,p_idEmpleado IN NUMBER)
IS
BEGIN
	OPEN c_cursor FOR SELECT * FROM AS_EMPLEADO WHERE ID_EMPLEADO=p_idEmpleado;
END;

CREATE OR REPLACE PROCEDURE spAgregarEmpleado(p_idEmpleado IN NUMBER,p_nombre IN VARCHAR2,p_apellidoP IN VARCHAR2,p_apellidoM IN VARCHAR2,p_idEstadoC IN NUMBER,p_sexo IN NUMBER,p_idNacionalidad IN NUMBER,p_idTurno IN NUMBER,p_domicilio IN VARCHAR,p_idTipoEmp IN NUMBER,p_idCentro IN NUMBER)
IS
BEGIN
	INSERT INTO AS_EMPLEADO VALUES(p_idEmpleado,p_nombre,p_apellidoP,p_apellidoM,p_idEstadoC,p_sexo,p_idNacionalidad,p_idTurno,p_domicilio,p_idTipoEmp,p_idCentro);
END;

CREATE OR REPLACE PROCEDURE spModificarEmpleado(p_idEmpleado IN NUMBER,p_nombre IN VARCHAR2,p_apellidoP IN VARCHAR2,p_apellidoM IN VARCHAR2,p_idEstadoC IN NUMBER,p_sexo IN NUMBER,p_idNacionalidad IN NUMBER,p_idTurno IN NUMBER,p_domicilio IN VARCHAR,p_idTipoEmp IN NUMBER,p_idCentro IN NUMBER)
IS
BEGIN
	UPDATE AS_EMPLEADO SET NOMBRE=p_nombre,APELLIDO_P=p_apellidoP,APELLIDO_M=p_apellidoM,ID_ESTADO_CIVIL=p_idEstadoC,ID_SEXO=p_sexo,ID_NACIONALIDAD=p_idNacionalidad,ID_TURNO=p_idTurno,DOMICILIO=p_domicilio,ID_TIPO_EMPLEADO=p_idTipoEmp,ID_CENTRO=p_idCentro WHERE ID_EMPLEADO=p_idEmpleado;
END;

CREATE OR REPLACE PROCEDURE spBorrarEmpleado(p_idEmpleado IN NUMBER)
IS
BEGIN
	DELETE FROM AS_EMPLEADO WHERE ID_EMPLEADO=p_idEmpleado;
END;

CREATE OR REPLACE PROCEDURE spDatosEmpleado(c_cursor OUT SYS_REFCURSOR)
IS
BEGIN
	OPEN c_cursor FOR SELECT ASEMP.ID_EMPLEADO, ASEMP.NOMBRE, ASEMP.APELLIDO_P, ASEMP.APELLIDO_M, ASE.ESTADO_CIVIL, ASS.SEXO, ASN.NACIONALIDAD, AST.TURNO, ASEMP.DOMICILIO, ASTE.TIPO_EMPLEADO, ASCE.NOMBRE 
	FROM AS_EMPLEADO ASEMP INNER JOIN AS_ESTADO_CIVIL ASE ON ASEMP.ID_ESTADO_CIVIL = ASE.ID_ESTADO_CIVIL
	INNER JOIN AS_SEXO ASS ON ASEMP.ID_SEXO = ASS.ID_SEXO
	INNER JOIN AS_NACIONALIDAD ASN ON ASEMP.ID_NACIONALIDAD = ASN.ID_NACIONALIDAD
	INNER JOIN AS_TURNO AST ON ASEMP.ID_TURNO = AST.ID_TURNO
	INNER JOIN AS_TIPO_EMPLEADO ASTE ON ASEMP.ID_TIPO_EMPLEADO = ASTE.ID_TIPO_EMPLEADO
	INNER JOIN AS_CENTRO ASCE ON ASEMP.ID_CENTRO = ASCE.ID_CENTRO;
END;

CREATE OR REPLACE PROCEDURE spDatosEmpleado2(c_cursor OUT SYS_REFCURSOR)
IS
BEGIN
	OPEN c_cursor FOR SELECT * FROM AS_EMPLEADO;
END;

--SOTORED PROCEDURE USUARIO
CREATE OR REPLACE PROCEDURE spBuscarUsuario2(c_cursor OUT SYS_REFCURSOR,p_idUsuario IN NUMBER)
IS
BEGIN
	OPEN c_cursor FOR SELECT * FROM AS_USUARIO
	WHERE ID_USUARIO=p_idUsuario;
END;

CREATE OR REPLACE PROCEDURE spBuscarUsuario(c_cursor OUT SYS_REFCURSOR,p_idUsuario IN NUMBER)
IS
BEGIN
	OPEN c_cursor FOR SELECT ASP.ID_USUARIO, ASE.NOMBRE,ASTU.TIPO_USUARIO, ASP.PASSWORD
	FROM AS_USUARIO ASP INNER JOIN AS_EMPLEADO ASE ON ASP.ID_EMPLEADO = ASE.ID_EMPLEADO
	INNER JOIN AS_TIPO_USUARIO ASTU ON ASP.ID_TIPO_USUARIO = ASTU.ID_TIPO_USUARIO
	WHERE ID_USUARIO=p_idUsuario;
END;

CREATE OR REPLACE PROCEDURE spBuscarUsuarioEmp(c_cursor OUT SYS_REFCURSOR,p_idUsuario IN NUMBER)
IS
BEGIN
	OPEN c_cursor FOR SELECT ASP.ID_USUARIO, ASE.NOMBRE,ASTU.TIPO_USUARIO
	FROM AS_USUARIO ASP INNER JOIN AS_EMPLEADO ASE ON ASP.ID_EMPLEADO = ASE.ID_EMPLEADO
	INNER JOIN AS_TIPO_USUARIO ASTU ON ASP.ID_TIPO_USUARIO = ASTU.ID_TIPO_USUARIO
	WHERE ID_USUARIO=p_idUsuario;
END;

CREATE OR REPLACE PROCEDURE spAgregarUsuario(p_idUsuario IN NUMBER,p_idEmpleado IN NUMBER,p_tipoUsuario IN NUMBER,p_password IN VARCHAR2)
IS
BEGIN
	INSERT INTO AS_USUARIO VALUES(p_idUsuario,p_idEmpleado,p_tipoUsuario,p_password);
END;

CREATE OR REPLACE PROCEDURE spModificarUsuario(p_idUsuario IN NUMBER, p_idEmpleado IN NUMBER, p_idTipoUsuario IN NUMBER, p_Password IN VARCHAR2)
IS
BEGIN
	UPDATE AS_USUARIO SET ID_EMPLEADO=p_idEmpleado, ID_TIPO_USUARIO=p_idTipoUsuario,PASSWORD=p_password WHERE ID_USUARIO=p_idUsuario;
END;

CREATE OR REPLACE PROCEDURE spBorrarUsuario(p_idUsuario IN NUMBER)
IS
BEGIN
	DELETE FROM AS_USUARIO WHERE ID_USUARIO=p_idUsuario;
END;

CREATE OR REPLACE PROCEDURE spDatosUsuario(c_cursor OUT SYS_REFCURSOR)
IS
BEGIN
	OPEN c_cursor FOR SELECT ASP.ID_USUARIO, ASE.NOMBRE, ASTU.TIPO_USUARIO, ASP.PASSWORD
	FROM AS_USUARIO ASP INNER JOIN AS_EMPLEADO ASE ON ASP.ID_EMPLEADO = ASE.ID_EMPLEADO
	INNER JOIN AS_TIPO_USUARIO ASTU ON ASP.ID_TIPO_USUARIO = ASTU.ID_TIPO_USUARIO;
END;

CREATE OR REPLACE PROCEDURE spUsuarioEmpleado(c_cursor OUT SYS_REFCURSOR)
IS
BEGIN
	OPEN c_cursor FOR SELECT ID_EMPLEADO, (ID_EMPLEADO || ' - ' || NOMBRE || ' ' || APELLIDO_P) As EMPLEADO FROM AS_EMPLEADO;
END;


CREATE OR REPLACE PROCEDURE spDatosUsuarioEmpleado(c_cursor OUT SYS_REFCURSOR)
IS
BEGIN
	OPEN c_cursor FOR SELECT ASP.ID_USUARIO, ASE.NOMBRE, ASTU.TIPO_USUARIO
	FROM AS_USUARIO ASP INNER JOIN AS_EMPLEADO ASE ON ASP.ID_EMPLEADO = ASE.ID_EMPLEADO
	INNER JOIN AS_TIPO_USUARIO ASTU ON ASP.ID_TIPO_USUARIO = ASTU.ID_TIPO_USUARIO;
END;

CREATE OR REPLACE PROCEDURE spDatosUsuarioEmpleado2(c_cursor OUT SYS_REFCURSOR)
IS
BEGIN
	OPEN c_cursor FOR SELECT * FROM AS_USUARIO;
END;

CREATE OR REPLACE PROCEDURE spBuscarUsuarioEmp(c_cursor OUT SYS_REFCURSOR,p_idEmp IN NUMBER)
IS
BEGIN
	OPEN c_cursor FOR SELECT * FROM AS_USUARIO
	WHERE ID_EMPLEADO=p_idEmp;
END;

--SOTERED PROCEDURE CONTACTO
CREATE OR REPLACE PROCEDURE spAgregarContacto(p_idContacto IN NUMBER, p_Nombre IN VARCHAR2, p_ApellidoP IN VARCHAR2, p_ApellidoM IN VARCHAR2, p_idSexo IN NUMBER, p_Telefono IN VARCHAR2, p_idParentesco IN NUMBER)
IS
BEGIN
	INSERT INTO AS_CONTACTO VALUES(p_idContacto, p_Nombre, p_ApellidoP, p_ApellidoM, p_idSexo, p_Telefono, p_idParentesco);
END;

CREATE OR REPLACE PROCEDURE spModificarContacto(p_idContacto IN NUMBER, p_Nombre IN VARCHAR2, p_ApellidoP IN VARCHAR2, p_ApellidoM IN VARCHAR2, p_idSexo IN NUMBER, p_Telefono IN VARCHAR2, p_idParentesco IN NUMBER)
IS
BEGIN
	UPDATE AS_CONTACTO SET NOMBRE = p_Nombre, APELLIDO_P = p_ApellidoP, APELLIDO_M = p_ApellidoM, ID_SEXO = p_idSexo, TELEFONO = p_Telefono, ID_PARENTESCO = p_idParentesco WHERE ID_CONTACTO = p_idContacto;
END;

CREATE OR REPLACE PROCEDURE spBorrarContacto(p_idContacto IN NUMBER)
IS
BEGIN
	DELETE FROM AS_CONTACTO WHERE ID_CONTACTO = p_idContacto;
END;

CREATE OR REPLACE PROCEDURE spDatosContacto(c_cursor OUT SYS_REFCURSOR)
IS
BEGIN 
	OPEN c_cursor FOR SELECT ASCT.ID_CONTACTO,ASCT.NOMBRE,ASCT.APELLIDO_P,ASCT.APELLIDO_M,ASSE.SEXO,ASCT.TELEFONO,ASPC.PARENTESCO 
	FROM AS_CONTACTO ASCT INNER JOIN AS_SEXO ASSE ON ASCT.ID_SEXO=ASSE.ID_SEXO
	INNER JOIN AS_PARENTESCO_CONTACTO ASPC ON ASCT.ID_PARENTESCO=ASPC.ID_PARENTESCO;
END;

CREATE OR REPLACE PROCEDURE spBuscarContacto(c_cursor OUT SYS_REFCURSOR,p_idContacto IN NUMBER)
IS
BEGIN 
	OPEN c_cursor FOR SELECT ASCT.ID_CONTACTO,ASCT.NOMBRE,ASCT.APELLIDO_P,ASCT.APELLIDO_M,ASSE.SEXO,ASCT.TELEFONO,ASPC.PARENTESCO 
	FROM AS_CONTACTO ASCT INNER JOIN AS_SEXO ASSE ON ASCT.ID_SEXO=ASSE.ID_SEXO
	INNER JOIN AS_PARENTESCO_CONTACTO ASPC ON ASCT.ID_PARENTESCO=ASPC.ID_PARENTESCO
	WHERE ID_CONTACTO=p_idContacto;
END;

CREATE OR REPLACE PROCEDURE spBuscarContacto2(c_cursor OUT SYS_REFCURSOR, p_idContacto IN NUMBER)
IS
BEGIN
	OPEN c_cursor FOR SELECT * FROM AS_CONTACTO;
END;

--STORED PROCEDURE ADULTO
CREATE OR REPLACE PROCEDURE spBuscarAdulto(c_cursor OUT SYS_REFCURSOR, p_idAdulto IN NUMBER)
IS
BEGIN
	OPEN c_cursor FOR SELECT ASA.ID_ADULTO, ASA.NOMBRE, ASA.APELLIDO_P, ASA.APELLIDO_M, ASS.SEXO, ASA.EDAD, (ASCO.NOMBRE || ' ' || ASCO.APELLIDO_P) As CONTACTO, ASCE.NOMBRE AS CENTRO
	FROM AS_ADULTO ASA INNER JOIN AS_SEXO ASS ON ASA.ID_SEXO = ASS.ID_SEXO
	INNER JOIN AS_CONTACTO ASCO ON ASA.ID_CONTACTO = ASCO.ID_CONTACTO
	INNER JOIN AS_CENTRO ASCE ON ASA.ID_CENTRO = ASCE.ID_CENTRO
	WHERE ASA.ID_ADULTO = p_idAdulto;
END;

CREATE OR REPLACE PROCEDURE spBuscarAdulto2(c_cursor OUT SYS_REFCURSOR, p_idAdulto IN NUMBER)
IS
BEGIN
	OPEN c_cursor FOR SELECT * FROM AS_ADULTO WHERE ID_ADULTO = p_idAdulto;
END;

CREATE OR REPLACE PROCEDURE spAgregarAdulto(p_idAdulto IN NUMBER, p_Nombre IN VARCHAR2, p_ApellidoP IN VARCHAR2, p_ApellidoM IN VARCHAR2, p_idSexo IN NUMBER, p_Edad IN NUMBER, p_idContacto IN NUMBER, p_idCentro IN NUMBER)
IS
BEGIN
	INSERT INTO AS_ADULTO VALUES(p_idAdulto, p_Nombre, p_ApellidoP, p_ApellidoM, p_idSexo, p_Edad, p_idContacto, p_idCentro);
END;

CREATE OR REPLACE PROCEDURE spModificarAdulto(p_idAdulto IN NUMBER, p_Nombre IN VARCHAR2, p_ApellidoP IN VARCHAR2, p_ApellidoM IN VARCHAR2, p_idSexo IN NUMBER, p_Edad IN NUMBER, p_IdContacto IN NUMBER, p_idCentro IN NUMBER)
IS
BEGIN
	UPDATE AS_ADULTO SET NOMBRE=p_Nombre, APELLIDO_P=p_ApellidoP, APELLIDO_M=p_ApellidoM, ID_SEXO=p_idSexo, EDAD=p_Edad, ID_CONTACTO=p_IdContacto, ID_CENTRO=p_idCentro WHERE ID_ADULTO=p_idAdulto;
END;

CREATE OR REPLACE PROCEDURE spBorrarAdulto(p_idAdulto IN NUMBER)
IS
BEGIN
	DELETE FROM AS_ADULTO WHERE ID_ADULTO = p_idAdulto;
END;

CREATE OR REPLACE PROCEDURE spDatosAdulto(c_cursor OUT SYS_REFCURSOR)
IS
BEGIN
	OPEN c_cursor FOR SELECT ASA.ID_ADULTO, ASA.NOMBRE, ASA.APELLIDO_P, ASA.APELLIDO_M, ASS.SEXO, ASA.EDAD, (ASCO.NOMBRE || ' ' || ASCO.APELLIDO_P) As CONTACTO, ASCE.NOMBRE AS CENTRO
	FROM AS_ADULTO ASA INNER JOIN AS_SEXO ASS ON ASA.ID_SEXO = ASS.ID_SEXO
	INNER JOIN AS_CONTACTO ASCO ON ASA.ID_CONTACTO = ASCO.ID_CONTACTO
	INNER JOIN AS_CENTRO ASCE ON ASA.ID_CENTRO = ASCE.ID_CENTRO;
END;

CREATE OR REPLACE PROCEDURE spDatosAdultoContacto(c_cursor OUT SYS_REFCURSOR)
IS
BEGIN
	OPEN c_cursor FOR SELECT ID_CONTACTO, (ID_CONTACTO || ' - ' || NOMBRE || ' ' || APELLIDO_P || ' ' || APELLIDO_M) As CONTACTO FROM AS_CONTACTO;
END;

CREATE OR REPLACE PROCEDURE spDatosAdulto2(c_cursor OUT SYS_REFCURSOR)
IS
BEGIN
	OPEN c_cursor FOR SELECT ID_ADULTO, (ID_ADULTO || ' - ' || NOMBRE || ' ' || APELLIDO_P || ' ' || APELLIDO_M) As ADULTO FROM AS_ADULTO;
END;

CREATE OR REPLACE PROCEDURE spDatosAdulto3(c_cursor OUT SYS_REFCURSOR)
IS
BEGIN
	OPEN c_cursor FOR SELECT * FROM AS_ADULTO;
END;

--ELIMINAR TABLAS
DROP TABLE AS_ADULTO_ACTIVIDAD;
DROP TABLE AS_ADULTO_APOYO;
DROP TABLE AS_CENTRO_ACTIVIDAD;
DROP TABLE AS_ADULTO;
DROP TABLE AS_CONTACTO;
DROP TABLE AS_USUARIO;
DROP TABLE AS_EMPLEADO;
DROP TABLE AS_PARENTESCO_CONTACTO;
DROP TABLE AS_ESTADO_CIVIL;
DROP TABLE AS_TURNO;
DROP TABLE AS_NACIONALIDAD;
DROP TABLE AS_TIPO_EMPLEADO;
DROP TABLE AS_APOYO;
DROP TABLE AS_ACTIVIDAD;
DROP TABLE AS_CENTRO;
DROP TABLE AS_TIPO_USUARIO;
DROP TABLE AS_SEXO;