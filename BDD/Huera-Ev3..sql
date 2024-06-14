
--1 Agregar una tabla llamada PERMISOS para almacenar datos de los permisos solicitados por cada empleado en el mes. Por cada hora o fracción se descuenta el 5% del salario básico.
CREATE TABLE PERMISOS (
    id_permiso VARCHAR(10) PRIMARY KEY NULL,
    CEDULAEMP VARCHAR(10) NOT NULL,
    fecha DATE NOT NULL,
    hora_llegada TIME NOT NULL,
    hora_salida TIME NOT NULL,
    horas DECIMAL(5, 2) GENERATED ALWAYS AS ((EXTRACT(EPOCH FROM (hora_salida - hora_llegada)) / 3600)) STORED,
    descuento DECIMAL(10, 2) GENERATED ALWAYS AS ((EXTRACT(EPOCH FROM (hora_salida - hora_llegada)) / 3600) * 0.05) STORED,
    CONSTRAINT fk_empleado_id FOREIGN KEY (CEDULAEMP) REFERENCES EMPLEADOS(cedulaEMP)
);



--2 Relacionar la tabla PERMISOS con la tabla EMPLEADOS para que se actualice los datos en cascada, restringir la eliminación en cascada.
ALTER TABLE PERMISOS
ADD CONSTRAINT f_empleado_ID
FOREIGN KEY (CEDULAEMP) REFERENCES EMPLEADOS(cedulaEMP)
ON UPDATE CASCADE
ON DELETE RESTRICT;



--3 Agregar un campo en la tabla ROLES para el control de los permisos de los empleados.
ALTER TABLE ROLES
ADD COLUMN control_permisos BOOLEAN DEFAULT FALSE;



--4 Actualizar el campo “razonsocial” por “razonsocialsup” y ampliar el tamaño a varchar(100) en la tabla SUPERMERCADOS.
ALTER TABLE SUPERMERCADOS 
RENAME COLUMN razonsocial TO razonsocialsup;

ALTER TABLE SUPERMERCADOS 
ALTER COLUMN razonsocialsup TYPE VARCHAR(100);




--5 Ingresar 2 registros de permisos por cada empleado en el mes de Mayo. Actualizar la tabla ROLES considerando los permisos de los EMPLEADOS y el valor total del ROL
INSERT INTO PERMISOS (ID_PERMISO,CEDULAEMP, fecha, hora_llegada, hora_salida)
VALUES('1','10027251','15-05-2024','09:00','13:00');

INSERT INTO PERMISOS (ID_PERMISO,CEDULAEMP, fecha, hora_llegada, hora_salida)
VALUES('2','10027252','16-05-2024','10:00','16:00');




--6 Obtener los datos del supermercado que menos a facturado a los empleados durante todo el año 2024.

SELECT S.RUCSUP, S.razonsocialsup, SUM(F.VALORFAC) AS total_facturado
FROM SUPERMERCADOS S
JOIN FACTURAS F ON S.RUCSUP = F.RUCSUP
WHERE EXTRACT(YEAR FROM F.fechaFAC) = 2024
GROUP BY S.RUCSUP, S.razonsocialsup
ORDER BY total_facturado ASC
LIMIT 1;

--7 Obtener los datos de los Empleados, incluido el detallecargo y detallediversidad que no tienen facturas en el mes de mayo.

SELECT 
    EMP.CEDULAEMP,
    EMP.APELLIDOSEMP,
    EMP.NOMBRESEMP,
    CONCAT(EMP.APELLIDOSEMP, ' ', EMP.NOMBRESEMP) AS EMPLEADO,
    CAR.detallecar,
    DIV.detallediv
FROM 
    EMPLEADOS EMP
INNER JOIN 
    CARGOS CAR ON EMP.CEDULAEMP = CAR.idCAR
INNER JOIN 
    DIVERSIDADES DIV ON EMP.CODIGODIV = DIV.CODIGODIV
LEFT JOIN 
    FACTURAS FAC ON EMP.CEDULAEMP = FAC.CEDULAEMP AND EXTRACT(MONTH FROM FAC.fechaFAC) = 5 AND EXTRACT(YEAR FROM FAC.fechaFAC) = 2024
WHERE 
    FAC.codigofac IS NULL;

--8 Obtener los datos del Empleado con el número de facturas de cada mes.
SELECT E.*, EXTRACT(MONTH FROM F.fechafac) AS mes, COUNT(F.codigofac) AS numero_facturas
FROM EMPLEADOS E
JOIN FACTURAS F ON E.cedulaemp = F.cedulaemp
GROUP BY E.cedulaemp, mes;


--9 Obtener los datos de los Empleados y el número de facturas por supermercado de cada empleado durante un periodo de tiempo.
SELECT E.*, S.razonsocialsup AS supermercado, COUNT(F.codigofac) AS numero_facturas
FROM EMPLEADOS E
JOIN FACTURAS F ON E.cedulaemp = F.cedulaemp
JOIN SUPERMERCADOS S ON F.rucsup = S.rucsup
WHERE F.fechafac BETWEEN '2024-01-01' AND '2024-8-31'
GROUP BY E.cedulaemp, S.rucsup;

--10 Obtener datos de los empleados, la cantidad de hijos y el valor recibido como bono de menores de edad.

SELECT 
    E.cedulaemp,
    E.apellidosemp,
    E.nombresemp,
    COUNT(H.cedulahij) AS cantidad_hijos,
    R.bonorol
FROM 
    EMPLEADOS E
LEFT JOIN 
    HIJOS H ON E.cedulaemp = H.cedulaemp
LEFT JOIN 
    ROLES R ON E.cedulaemp = R.cedulaemp  
GROUP BY 
    E.cedulaemp, E.apellidosemp, E.nombresemp, R.bonorol;



