--------------------------------------------------------
-- Archivo creado  - s�bado-febrero-12-2022   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Table CATEGORIAS
--------------------------------------------------------

  CREATE TABLE "C##COLEGIO"."CATEGORIAS" 
   (	"ID" NUMBER GENERATED ALWAYS AS IDENTITY MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE  NOKEEP  NOSCALE , 
	"NOMBRE" VARCHAR2(50 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table CURSOS
--------------------------------------------------------

  CREATE TABLE "C##COLEGIO"."CURSOS" 
   (	"ID" NUMBER GENERATED ALWAYS AS IDENTITY MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE  NOKEEP  NOSCALE , 
	"NOMBRE" VARCHAR2(50 BYTE), 
	"DESCRIPCION" VARCHAR2(200 BYTE), 
	"CATEGORIA" NUMBER, 
	"VALOR" NUMBER, 
	"DURACION" NUMBER, 
	"UNIDADTIEMPO" NUMBER
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table ESTADOCIVIL
--------------------------------------------------------

  CREATE TABLE "C##COLEGIO"."ESTADOCIVIL" 
   (	"ID" NUMBER(*,0) GENERATED ALWAYS AS IDENTITY MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE  NOKEEP  NOSCALE , 
	"NOMBRE" VARCHAR2(50 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table ESTADOMATRICULA
--------------------------------------------------------

  CREATE TABLE "C##COLEGIO"."ESTADOMATRICULA" 
   (	"ID" NUMBER GENERATED ALWAYS AS IDENTITY MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE  NOKEEP  NOSCALE , 
	"NOMBRE" VARCHAR2(50 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table JORNADAS
--------------------------------------------------------

  CREATE TABLE "C##COLEGIO"."JORNADAS" 
   (	"ID" NUMBER GENERATED ALWAYS AS IDENTITY MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE  NOKEEP  NOSCALE , 
	"NOMBRE" VARCHAR2(50 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table MATRICULAS
--------------------------------------------------------

  CREATE TABLE "C##COLEGIO"."MATRICULAS" 
   (	"ID" NUMBER GENERATED ALWAYS AS IDENTITY MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE  NOKEEP  NOSCALE , 
	"CODIGO" VARCHAR2(20 BYTE), 
	"CURSO" NUMBER, 
	"JORNADA" NUMBER, 
	"ESTUDIANTE" NUMBER, 
	"VALOR" NUMBER, 
	"FECHAINICIO" DATE, 
	"FECHAFIN" DATE, 
	"ESTADOMATRICULA" NUMBER, 
	"DESCRIPCION" VARCHAR2(200 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table PERFILES
--------------------------------------------------------

  CREATE TABLE "C##COLEGIO"."PERFILES" 
   (	"ID" NUMBER(*,0) GENERATED ALWAYS AS IDENTITY MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE  NOKEEP  NOSCALE , 
	"NOMBRE" VARCHAR2(50 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table PERSONAS
--------------------------------------------------------

  CREATE TABLE "C##COLEGIO"."PERSONAS" 
   (	"ID" NUMBER(*,0) GENERATED ALWAYS AS IDENTITY MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE  NOKEEP  NOSCALE , 
	"NOMBRE" VARCHAR2(50 BYTE), 
	"APELLIDO" VARCHAR2(50 BYTE), 
	"DIRECCION" VARCHAR2(50 BYTE), 
	"TELEFONO" VARCHAR2(50 BYTE), 
	"IDENTIFICACION" VARCHAR2(50 BYTE), 
	"EMAIL" VARCHAR2(50 BYTE), 
	"FECHANACIMIENTO" DATE, 
	"ESTADOCIVIL" NUMBER(*,0), 
	"SEXO" NUMBER(*,0)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table SEXO
--------------------------------------------------------

  CREATE TABLE "C##COLEGIO"."SEXO" 
   (	"ID" NUMBER(*,0) GENERATED ALWAYS AS IDENTITY MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE  NOKEEP  NOSCALE , 
	"NOMBRE" VARCHAR2(50 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table UNIDADTIEMPO
--------------------------------------------------------

  CREATE TABLE "C##COLEGIO"."UNIDADTIEMPO" 
   (	"ID" NUMBER GENERATED ALWAYS AS IDENTITY MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE  NOKEEP  NOSCALE , 
	"NOMBRE" VARCHAR2(50 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table USUARIOS
--------------------------------------------------------

  CREATE TABLE "C##COLEGIO"."USUARIOS" 
   (	"IDPERSONA" NUMBER(*,0), 
	"USUARIO" VARCHAR2(50 BYTE), 
	"PWD" VARCHAR2(200 BYTE), 
	"PERFIL" NUMBER
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for View VWUSUARIOS
--------------------------------------------------------

  CREATE OR REPLACE FORCE EDITIONABLE VIEW "C##COLEGIO"."VWUSUARIOS" ("ID", "IDENTIFICACION", "NOMBRE", "APELLIDO", "ESTADOCIVIL", "FECHANACIMIENTO", "DIRECCION", "TELEFONO", "SEXO", "EMAIL", "USUARIO", "PWD", "PERFIL") AS 
  SELECT P.ID,P.IDENTIFICACION,P.NOMBRE,P.APELLIDO,p.estadocivil,p.fechanacimiento,
P.direccion,P.TELEFONO,p.sexo, P.email,U.usuario,U.pwd,u.perfil 
    FROM personas P INNER JOIN usuarios U ON P.id=U.IDPERSONA
;
REM INSERTING into C##COLEGIO.CATEGORIAS
SET DEFINE OFF;
Insert into C##COLEGIO.CATEGORIAS (ID,NOMBRE) values ('1','Pre-escolar');
Insert into C##COLEGIO.CATEGORIAS (ID,NOMBRE) values ('2','Educacion basica');
Insert into C##COLEGIO.CATEGORIAS (ID,NOMBRE) values ('3','Educacion media');
Insert into C##COLEGIO.CATEGORIAS (ID,NOMBRE) values ('4','Tecninca');
Insert into C##COLEGIO.CATEGORIAS (ID,NOMBRE) values ('5','Tecnologica');
REM INSERTING into C##COLEGIO.CURSOS
SET DEFINE OFF;
Insert into C##COLEGIO.CURSOS (ID,NOMBRE,DESCRIPCION,CATEGORIA,VALOR,DURACION,UNIDADTIEMPO) values ('5','ingles conversacional',null,'5','500000','2','3');
Insert into C##COLEGIO.CURSOS (ID,NOMBRE,DESCRIPCION,CATEGORIA,VALOR,DURACION,UNIDADTIEMPO) values ('3','Analisis y programacion de computadores',null,'5','600000','2','3');
Insert into C##COLEGIO.CURSOS (ID,NOMBRE,DESCRIPCION,CATEGORIA,VALOR,DURACION,UNIDADTIEMPO) values ('4','Contabilidad basica',null,'4','100000','4','2');
REM INSERTING into C##COLEGIO.ESTADOCIVIL
SET DEFINE OFF;
Insert into C##COLEGIO.ESTADOCIVIL (ID,NOMBRE) values ('1','Soltero');
Insert into C##COLEGIO.ESTADOCIVIL (ID,NOMBRE) values ('2','Casado');
Insert into C##COLEGIO.ESTADOCIVIL (ID,NOMBRE) values ('3','Divociado');
Insert into C##COLEGIO.ESTADOCIVIL (ID,NOMBRE) values ('4','Viudo');
REM INSERTING into C##COLEGIO.ESTADOMATRICULA
SET DEFINE OFF;
Insert into C##COLEGIO.ESTADOMATRICULA (ID,NOMBRE) values ('1','Activo');
Insert into C##COLEGIO.ESTADOMATRICULA (ID,NOMBRE) values ('2','Suspendido');
Insert into C##COLEGIO.ESTADOMATRICULA (ID,NOMBRE) values ('3','Anulado');
Insert into C##COLEGIO.ESTADOMATRICULA (ID,NOMBRE) values ('4','Aprobado');
Insert into C##COLEGIO.ESTADOMATRICULA (ID,NOMBRE) values ('5','Reprobado');
REM INSERTING into C##COLEGIO.JORNADAS
SET DEFINE OFF;
Insert into C##COLEGIO.JORNADAS (ID,NOMBRE) values ('1','ma�ana');
Insert into C##COLEGIO.JORNADAS (ID,NOMBRE) values ('2','tarde');
Insert into C##COLEGIO.JORNADAS (ID,NOMBRE) values ('3','noche');
Insert into C##COLEGIO.JORNADAS (ID,NOMBRE) values ('4','sabados');
Insert into C##COLEGIO.JORNADAS (ID,NOMBRE) values ('5','Domingos');
REM INSERTING into C##COLEGIO.MATRICULAS
SET DEFINE OFF;
Insert into C##COLEGIO.MATRICULAS (ID,CODIGO,CURSO,JORNADA,ESTUDIANTE,VALOR,FECHAINICIO,FECHAFIN,ESTADOMATRICULA,DESCRIPCION) values ('4','001','5','1','42','30000',to_date('11/02/22','DD/MM/RR'),to_date('11/02/22','DD/MM/RR'),'1',null);
REM INSERTING into C##COLEGIO.PERFILES
SET DEFINE OFF;
Insert into C##COLEGIO.PERFILES (ID,NOMBRE) values ('12','Administrador');
Insert into C##COLEGIO.PERFILES (ID,NOMBRE) values ('13','Docente');
Insert into C##COLEGIO.PERFILES (ID,NOMBRE) values ('14','Estudiante');
REM INSERTING into C##COLEGIO.PERSONAS
SET DEFINE OFF;
Insert into C##COLEGIO.PERSONAS (ID,NOMBRE,APELLIDO,DIRECCION,TELEFONO,IDENTIFICACION,EMAIL,FECHANACIMIENTO,ESTADOCIVIL,SEXO) values ('41','jesus','mora','calle 45b #20-99','3014394578','72285908','jmora061483@gmail.com',to_date('14/06/83','DD/MM/RR'),'1','1');
Insert into C##COLEGIO.PERSONAS (ID,NOMBRE,APELLIDO,DIRECCION,TELEFONO,IDENTIFICACION,EMAIL,FECHANACIMIENTO,ESTADOCIVIL,SEXO) values ('42','antonella','arteta','calle 45b #20-107','3014394578','1112','jjjj',to_date('09/11/15','DD/MM/RR'),'1','2');
Insert into C##COLEGIO.PERSONAS (ID,NOMBRE,APELLIDO,DIRECCION,TELEFONO,IDENTIFICACION,EMAIL,FECHANACIMIENTO,ESTADOCIVIL,SEXO) values ('43','deivis','cardona','soledad','122222','113','jjjj',to_date('22/12/15','DD/MM/RR'),'1','1');
Insert into C##COLEGIO.PERSONAS (ID,NOMBRE,APELLIDO,DIRECCION,TELEFONO,IDENTIFICACION,EMAIL,FECHANACIMIENTO,ESTADOCIVIL,SEXO) values ('24','marta','narvaez','calle 45b #20-99','3017816510','32675171','martan1962@hotmail.com',to_date('23/03/62','DD/MM/RR'),'2','2');
REM INSERTING into C##COLEGIO.SEXO
SET DEFINE OFF;
Insert into C##COLEGIO.SEXO (ID,NOMBRE) values ('1','Masculino');
Insert into C##COLEGIO.SEXO (ID,NOMBRE) values ('2','Femenino');
REM INSERTING into C##COLEGIO.UNIDADTIEMPO
SET DEFINE OFF;
Insert into C##COLEGIO.UNIDADTIEMPO (ID,NOMBRE) values ('1','Dia');
Insert into C##COLEGIO.UNIDADTIEMPO (ID,NOMBRE) values ('2','Mes');
Insert into C##COLEGIO.UNIDADTIEMPO (ID,NOMBRE) values ('3','A�o');
REM INSERTING into C##COLEGIO.USUARIOS
SET DEFINE OFF;
Insert into C##COLEGIO.USUARIOS (IDPERSONA,USUARIO,PWD,PERFIL) values ('41','jmora','123','12');
Insert into C##COLEGIO.USUARIOS (IDPERSONA,USUARIO,PWD,PERFIL) values ('42','anto','123','14');
Insert into C##COLEGIO.USUARIOS (IDPERSONA,USUARIO,PWD,PERFIL) values ('43','devis','123','14');
Insert into C##COLEGIO.USUARIOS (IDPERSONA,USUARIO,PWD,PERFIL) values ('24','martan','123','13');
--------------------------------------------------------
--  DDL for Index CATEGORIAS_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "C##COLEGIO"."CATEGORIAS_PK" ON "C##COLEGIO"."CATEGORIAS" ("ID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index CURSO_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "C##COLEGIO"."CURSO_PK" ON "C##COLEGIO"."CURSOS" ("ID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index ESTADOCIVIL_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "C##COLEGIO"."ESTADOCIVIL_PK" ON "C##COLEGIO"."ESTADOCIVIL" ("ID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index ESTADOMATRICULA_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "C##COLEGIO"."ESTADOMATRICULA_PK" ON "C##COLEGIO"."ESTADOMATRICULA" ("ID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index JORNADA_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "C##COLEGIO"."JORNADA_PK" ON "C##COLEGIO"."JORNADAS" ("ID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index MATRICULA_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "C##COLEGIO"."MATRICULA_PK" ON "C##COLEGIO"."MATRICULAS" ("ID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index PERFILES_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "C##COLEGIO"."PERFILES_PK" ON "C##COLEGIO"."PERFILES" ("ID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index PERSONAS_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "C##COLEGIO"."PERSONAS_PK" ON "C##COLEGIO"."PERSONAS" ("ID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index SEXO_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "C##COLEGIO"."SEXO_PK" ON "C##COLEGIO"."SEXO" ("ID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index UNIDADTIEMPO_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "C##COLEGIO"."UNIDADTIEMPO_PK" ON "C##COLEGIO"."UNIDADTIEMPO" ("ID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index USUARIOS_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "C##COLEGIO"."USUARIOS_PK" ON "C##COLEGIO"."USUARIOS" ("USUARIO") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Procedure ACTUALIZARCURSO
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "C##COLEGIO"."ACTUALIZARCURSO" (P_ID IN cursos.id%TYPE ,
                                            P_NOMBRE IN cursos.nombre%TYPE,
                                            P_DESCRIPCION IN cursos.descripcion%TYPE,
                                            P_CATEGORIA IN cursos.categoria%TYPE,
                                            p_valor in cursos.valor%TYPE,
                                            p_duracion in cursos.duracion%TYPE,
                                            p_unidadtiempo in cursos.unidadtiempo%TYPE)IS
BEGIN 
UPDATE  CURSOS SET categoria=P_CATEGORIA, 
NOMBRE=P_NOMBRE,
DESCRIPCION=P_DESCRIPCION,
valor=p_valor,
duracion=p_duracion,
unidadtiempo=p_unidadtiempo
WHERE ID= P_ID;
END;

/
--------------------------------------------------------
--  DDL for Procedure ACTUALIZARUSUARIO
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "C##COLEGIO"."ACTUALIZARUSUARIO" (P_ID IN personas.id%TYPE,                                               
                                              P_IDENTIFICACION IN personas.identificacion%TYPE,
                                              P_NOMBRE IN personas.nombre%TYPE,
                                              P_APELLIDO IN personas.apellido%TYPE,   
                                              P_EstadoCivil in personas.estadocivil%TYPE,
                                              P_FECHANACIMIENTO IN personas.fechanacimiento%TYPE,
                                              P_DIRECCION IN personas.direccion%TYPE,
                                              P_TELEFONO IN personas.telefono%TYPE,
                                              P_SEXO IN personas.sexo%TYPE,
                                              P_EMAIL IN personas.email%TYPE,
                                              P_USUARIO IN usuarios.usuario%type,
                                              P_pwd in USUARIOS.pwd%type,
                                              P_Perfil in usuarios.perfil%TYPE
                                              )IS
BEGIN
UPDATE  PERSONAS SET identificacion=P_IDENTIFICACION, estadocivil=P_EstadoCivil, nombre=P_NOMBRE,apellido=P_APELLIDO,fechanacimiento=P_FECHANACIMIENTO, sexo=P_SEXO, direccion=P_DIRECCION,telefono=P_TELEFONO,email=P_EMAIL WHERE id=P_ID;
UPDATE usuarios SET pwd=P_PWD,perfil=P_Perfil WHERE usuario=P_USUARIO;
end;

/
--------------------------------------------------------
--  DDL for Procedure INSERTARCURSO
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "C##COLEGIO"."INSERTARCURSO" (P_NOMBRE IN cursos.nombre%TYPE,
                                          P_DESCRIPCION IN cursos.descripcion%TYPE,
                                          P_CATEGORIA IN cursos.categoria%TYPE,
                                          p_valor in cursos.valor%TYPE,
                                          p_duracion in cursos.duracion%TYPE,
                                          p_unidadtiempo in cursos.unidadtiempo%TYPE )IS
BEGIN 
    INSERT INTO CURSOS (categoria, NOMBRE,DESCRIPCION ,valor,duracion,unidadtiempo)VALUES(P_CATEGORIA, P_NOMBRE,P_DESCRIPCION,p_valor,p_duracion,p_unidadtiempo);
END;

/
--------------------------------------------------------
--  DDL for Procedure INSERTARMATRICULA
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "C##COLEGIO"."INSERTARMATRICULA" (P_CODIGO in matriculas.codigo%TYPE,
                                               P_CURSO in matriculas.curso%TYPE,
                                               P_JORNADA in matriculas.jornada%TYPE,
                                               P_ESTUDIANTE in matriculas.estudiante%TYPE,
                                               P_VALOR in matriculas.valor%TYPE,
                                               P_FECHAINICIO in matriculas.fechainicio%TYPE,
                                               P_FECHAFIN in matriculas.fechafin%TYPE,
                                               P_DESCRIPCION in matriculas.descripcion%TYPE)is
cont number;
begin
    select count(*) into cont from matriculas where estadomatricula<>3 and estudiante=p_estudiante and( jornada=p_jornada or curso=p_curso);
    if(cont>0) then
      RAISE_APPLICATION_ERROR(-20000, 'Error al insertarmatricula ');
      return;
    END IF; 
    insert into matriculas(CODIGO,CURSO,JORNADA,ESTUDIANTE,VALOR,FECHAINICIO,FECHAFIN,ESTADOMATRICULA,DESCRIPCION)
    VALUES(P_codigo,P_curso,P_jornada,P_estudiante,P_valor,P_fechainicio,P_fechafin,1,P_descripcion);
end;

/
--------------------------------------------------------
--  DDL for Procedure INSERTARUSUARIO
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "C##COLEGIO"."INSERTARUSUARIO" (P_IDENTIFICACION IN personas.identificacion%TYPE,
                                            P_NOMBRE IN personas.nombre%TYPE,
                                            P_APELLIDO IN personas.apellido%TYPE,  
                                            P_EstadoCivil in personas.estadocivil%TYPE,
                                            P_FECHANACIMIENTO IN personas.fechanacimiento%TYPE,
                                            P_DIRECCION IN personas.direccion%TYPE,
                                            P_TELEFONO IN personas.telefono%TYPE,
                                            P_SEXO IN personas.sexo%TYPE,
                                            P_EMAIL IN personas.email%TYPE,
                                            P_USUARIO IN usuarios.usuario%type,
                                            P_pwd in USUARIOS.pwd%type,
                                            P_Perfil in usuarios.perfil%type
                                            )IS
P_ID personas.id%TYPE;
p_countUsuario iNT;
begin
    select Count(*) into p_countUsuario from usuarios WHERE usuario =P_USUARIO;
    if p_countUsuario>0 then
        RAISE_APPLICATION_ERROR(-20000, 'el usuario no encuentra disponible');
        return;
    END IF; 
    INSERT INTO PERSONAS (identificacion, nombre,apellido,estadocivil, fechanacimiento, direccion,telefono,sexo ,email)VALUES(P_IDENTIFICACION,P_NOMBRE,P_APELLIDO,P_EstadoCivil, P_FECHANACIMIENTO, P_DIRECCION,P_TELEFONO,P_SEXO, P_EMAIL);
    select max(id) into P_ID from personas;
    insert into usuarios(idpersona,usuario,pwd,perfil)VALUES(P_id,P_usuario,p_pwd,P_Perfil);
end;

/
--------------------------------------------------------
--  DDL for Procedure LISTARCURSOS
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "C##COLEGIO"."LISTARCURSOS" (CURSOS OUT SYS_REFCURSOR)IS
BEGIN 
 OPEN CURSOS FOR SELECT ID, CATEGORIA ,NOMBRE, DESCRIPCION ,valor,duracion,unidadtiempo FROM cursos;
END;

/
--------------------------------------------------------
--  DDL for Procedure LISTARUSUARIOS
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "C##COLEGIO"."LISTARUSUARIOS" (CURSOR_USUARIOS OUT SYS_REFCURSOR)
AS
BEGIN
 OPEN CURSOR_USUARIOS FOR  SELECT ID,IDENTIFICACION,NOMBRE,APELLIDO,estadocivil,fechanacimiento,
 direccion,TELEFONO,sexo, email,usuario,pwd,perfil FROM  vwusuarios;
END ;

/
--------------------------------------------------------
--  Constraints for Table USUARIOS
--------------------------------------------------------

  ALTER TABLE "C##COLEGIO"."USUARIOS" MODIFY ("IDPERSONA" NOT NULL ENABLE);
  ALTER TABLE "C##COLEGIO"."USUARIOS" MODIFY ("USUARIO" NOT NULL ENABLE);
  ALTER TABLE "C##COLEGIO"."USUARIOS" MODIFY ("PWD" NOT NULL ENABLE);
  ALTER TABLE "C##COLEGIO"."USUARIOS" ADD CONSTRAINT "USUARIOS_PK" PRIMARY KEY ("USUARIO")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;
  ALTER TABLE "C##COLEGIO"."USUARIOS" MODIFY ("PERFIL" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table JORNADAS
--------------------------------------------------------

  ALTER TABLE "C##COLEGIO"."JORNADAS" MODIFY ("ID" NOT NULL ENABLE);
  ALTER TABLE "C##COLEGIO"."JORNADAS" MODIFY ("NOMBRE" NOT NULL ENABLE);
  ALTER TABLE "C##COLEGIO"."JORNADAS" ADD CONSTRAINT "JORNADA_PK" PRIMARY KEY ("ID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;
--------------------------------------------------------
--  Constraints for Table CATEGORIAS
--------------------------------------------------------

  ALTER TABLE "C##COLEGIO"."CATEGORIAS" MODIFY ("ID" NOT NULL ENABLE);
  ALTER TABLE "C##COLEGIO"."CATEGORIAS" MODIFY ("NOMBRE" NOT NULL ENABLE);
  ALTER TABLE "C##COLEGIO"."CATEGORIAS" ADD CONSTRAINT "CATEGORIAS_PK" PRIMARY KEY ("ID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;
--------------------------------------------------------
--  Constraints for Table SEXO
--------------------------------------------------------

  ALTER TABLE "C##COLEGIO"."SEXO" MODIFY ("ID" NOT NULL ENABLE);
  ALTER TABLE "C##COLEGIO"."SEXO" MODIFY ("NOMBRE" NOT NULL ENABLE);
  ALTER TABLE "C##COLEGIO"."SEXO" ADD CONSTRAINT "SEXO_PK" PRIMARY KEY ("ID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;
--------------------------------------------------------
--  Constraints for Table CURSOS
--------------------------------------------------------

  ALTER TABLE "C##COLEGIO"."CURSOS" MODIFY ("ID" NOT NULL ENABLE);
  ALTER TABLE "C##COLEGIO"."CURSOS" MODIFY ("NOMBRE" NOT NULL ENABLE);
  ALTER TABLE "C##COLEGIO"."CURSOS" ADD CONSTRAINT "CURSO_PK" PRIMARY KEY ("ID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;
  ALTER TABLE "C##COLEGIO"."CURSOS" MODIFY ("CATEGORIA" NOT NULL ENABLE);
  ALTER TABLE "C##COLEGIO"."CURSOS" MODIFY ("VALOR" NOT NULL ENABLE);
  ALTER TABLE "C##COLEGIO"."CURSOS" MODIFY ("DURACION" NOT NULL ENABLE);
  ALTER TABLE "C##COLEGIO"."CURSOS" MODIFY ("UNIDADTIEMPO" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table ESTADOCIVIL
--------------------------------------------------------

  ALTER TABLE "C##COLEGIO"."ESTADOCIVIL" MODIFY ("ID" NOT NULL ENABLE);
  ALTER TABLE "C##COLEGIO"."ESTADOCIVIL" MODIFY ("NOMBRE" NOT NULL ENABLE);
  ALTER TABLE "C##COLEGIO"."ESTADOCIVIL" ADD CONSTRAINT "ESTADOCIVIL_PK" PRIMARY KEY ("ID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;
--------------------------------------------------------
--  Constraints for Table MATRICULAS
--------------------------------------------------------

  ALTER TABLE "C##COLEGIO"."MATRICULAS" MODIFY ("ID" NOT NULL ENABLE);
  ALTER TABLE "C##COLEGIO"."MATRICULAS" MODIFY ("CODIGO" NOT NULL ENABLE);
  ALTER TABLE "C##COLEGIO"."MATRICULAS" MODIFY ("CURSO" NOT NULL ENABLE);
  ALTER TABLE "C##COLEGIO"."MATRICULAS" MODIFY ("JORNADA" NOT NULL ENABLE);
  ALTER TABLE "C##COLEGIO"."MATRICULAS" MODIFY ("ESTUDIANTE" NOT NULL ENABLE);
  ALTER TABLE "C##COLEGIO"."MATRICULAS" MODIFY ("VALOR" NOT NULL ENABLE);
  ALTER TABLE "C##COLEGIO"."MATRICULAS" MODIFY ("FECHAINICIO" NOT NULL ENABLE);
  ALTER TABLE "C##COLEGIO"."MATRICULAS" MODIFY ("FECHAFIN" NOT NULL ENABLE);
  ALTER TABLE "C##COLEGIO"."MATRICULAS" MODIFY ("ESTADOMATRICULA" NOT NULL ENABLE);
  ALTER TABLE "C##COLEGIO"."MATRICULAS" ADD CONSTRAINT "MATRICULA_PK" PRIMARY KEY ("ID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;
--------------------------------------------------------
--  Constraints for Table PERFILES
--------------------------------------------------------

  ALTER TABLE "C##COLEGIO"."PERFILES" MODIFY ("ID" NOT NULL ENABLE);
  ALTER TABLE "C##COLEGIO"."PERFILES" MODIFY ("NOMBRE" NOT NULL ENABLE);
  ALTER TABLE "C##COLEGIO"."PERFILES" ADD CONSTRAINT "PERFILES_PK" PRIMARY KEY ("ID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;
--------------------------------------------------------
--  Constraints for Table UNIDADTIEMPO
--------------------------------------------------------

  ALTER TABLE "C##COLEGIO"."UNIDADTIEMPO" MODIFY ("ID" NOT NULL ENABLE);
  ALTER TABLE "C##COLEGIO"."UNIDADTIEMPO" MODIFY ("NOMBRE" NOT NULL ENABLE);
  ALTER TABLE "C##COLEGIO"."UNIDADTIEMPO" ADD CONSTRAINT "UNIDADTIEMPO_PK" PRIMARY KEY ("ID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;
--------------------------------------------------------
--  Constraints for Table ESTADOMATRICULA
--------------------------------------------------------

  ALTER TABLE "C##COLEGIO"."ESTADOMATRICULA" MODIFY ("ID" NOT NULL ENABLE);
  ALTER TABLE "C##COLEGIO"."ESTADOMATRICULA" MODIFY ("NOMBRE" NOT NULL ENABLE);
  ALTER TABLE "C##COLEGIO"."ESTADOMATRICULA" ADD CONSTRAINT "ESTADOMATRICULA_PK" PRIMARY KEY ("ID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;
--------------------------------------------------------
--  Constraints for Table PERSONAS
--------------------------------------------------------

  ALTER TABLE "C##COLEGIO"."PERSONAS" MODIFY ("ID" NOT NULL ENABLE);
  ALTER TABLE "C##COLEGIO"."PERSONAS" MODIFY ("NOMBRE" NOT NULL ENABLE);
  ALTER TABLE "C##COLEGIO"."PERSONAS" MODIFY ("APELLIDO" NOT NULL ENABLE);
  ALTER TABLE "C##COLEGIO"."PERSONAS" MODIFY ("EMAIL" NOT NULL ENABLE);
  ALTER TABLE "C##COLEGIO"."PERSONAS" MODIFY ("DIRECCION" NOT NULL ENABLE);
  ALTER TABLE "C##COLEGIO"."PERSONAS" MODIFY ("TELEFONO" NOT NULL ENABLE);
  ALTER TABLE "C##COLEGIO"."PERSONAS" MODIFY ("IDENTIFICACION" NOT NULL ENABLE);
  ALTER TABLE "C##COLEGIO"."PERSONAS" ADD CONSTRAINT "PERSONAS_PK" PRIMARY KEY ("ID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;
  ALTER TABLE "C##COLEGIO"."PERSONAS" MODIFY ("FECHANACIMIENTO" NOT NULL ENABLE);
  ALTER TABLE "C##COLEGIO"."PERSONAS" MODIFY ("ESTADOCIVIL" NOT NULL ENABLE);
  ALTER TABLE "C##COLEGIO"."PERSONAS" MODIFY ("SEXO" NOT NULL ENABLE);
--------------------------------------------------------
--  Ref Constraints for Table CURSOS
--------------------------------------------------------

  ALTER TABLE "C##COLEGIO"."CURSOS" ADD FOREIGN KEY ("CATEGORIA")
	  REFERENCES "C##COLEGIO"."CATEGORIAS" ("ID") ENABLE;
  ALTER TABLE "C##COLEGIO"."CURSOS" ADD FOREIGN KEY ("UNIDADTIEMPO")
	  REFERENCES "C##COLEGIO"."UNIDADTIEMPO" ("ID") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table MATRICULAS
--------------------------------------------------------

  ALTER TABLE "C##COLEGIO"."MATRICULAS" ADD FOREIGN KEY ("ESTADOMATRICULA")
	  REFERENCES "C##COLEGIO"."ESTADOMATRICULA" ("ID") ENABLE;
  ALTER TABLE "C##COLEGIO"."MATRICULAS" ADD FOREIGN KEY ("ESTUDIANTE")
	  REFERENCES "C##COLEGIO"."PERSONAS" ("ID") ENABLE;
  ALTER TABLE "C##COLEGIO"."MATRICULAS" ADD FOREIGN KEY ("JORNADA")
	  REFERENCES "C##COLEGIO"."JORNADAS" ("ID") ENABLE;
  ALTER TABLE "C##COLEGIO"."MATRICULAS" ADD FOREIGN KEY ("CURSO")
	  REFERENCES "C##COLEGIO"."CURSOS" ("ID") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table PERSONAS
--------------------------------------------------------

  ALTER TABLE "C##COLEGIO"."PERSONAS" ADD FOREIGN KEY ("SEXO")
	  REFERENCES "C##COLEGIO"."SEXO" ("ID") ENABLE;
  ALTER TABLE "C##COLEGIO"."PERSONAS" ADD FOREIGN KEY ("ESTADOCIVIL")
	  REFERENCES "C##COLEGIO"."ESTADOCIVIL" ("ID") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table USUARIOS
--------------------------------------------------------

  ALTER TABLE "C##COLEGIO"."USUARIOS" ADD FOREIGN KEY ("IDPERSONA")
	  REFERENCES "C##COLEGIO"."PERSONAS" ("ID") ENABLE;
  ALTER TABLE "C##COLEGIO"."USUARIOS" ADD FOREIGN KEY ("PERFIL")
	  REFERENCES "C##COLEGIO"."PERFILES" ("ID") ENABLE;
