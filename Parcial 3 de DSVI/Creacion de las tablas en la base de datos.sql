CREATE TABLE JL_CLIENTES(
Id_clientes INT PRIMARY KEY IDENTITY (1,1),
Nombre VARCHAR(20),
Apellido VARCHAR(20)
)

CREATE TABLE JL_USUARIO(
Id_usuario INT PRIMARY KEY IDENTITY(1,1),
Tipo_usuario VARCHAR(20),
Nombre VARCHAR(20),
Apellido VARCHAR(20)
)

CREATE TABLE JL_CASOS(
Id_caso INT PRIMARY KEY IDENTITY(1,1),
Nombre VARCHAR(40),
Descripcion VARCHAR(100),
Tipo_caso VARCHAR(50)
)

CREATE TABLE JL_DOCUMENTOS(
Id_documento INT PRIMARY KEY IDENTITY(1,1),
Id_caso INT,
Tipo_documento VARCHAR(30),
CONSTRAINT Fk_id_caso FOREIGN KEY(Id_caso) REFERENCES JL_CASOS (Id_caso)
)

CREATE TABLE JL_DETALLES_CASOS(
Id_caso INT,
Id_usuario INT,
Id_clientes INT,
Estado_caso VARCHAR(40),
Fecha_inicio DATE,
Fecha_vencimiento DATE,
CONSTRAINT Fk_id_caso_detalles_casos FOREIGN KEY(Id_caso) REFERENCES JL_CASOS (Id_caso),
CONSTRAINT Fk_id_usuario_detalles_casos FOREIGN KEY(Id_usuario) REFERENCES JL_USUARIO (Id_usuario),
CONSTRAINT Fk_id_cliente_detalles_casos FOREIGN KEY(Id_clientes) REFERENCES JL_CLIENTES (Id_clientes)
)

CREATE TABLE JL_ACTIVIDADES(
Id_actividad INT PRIMARY KEY IDENTITY(1,1),
Id_caso INT,
Tipo_actividad VARCHAR(50),
Descripcion VARCHAR(100),
Fecha_actividad DATE,
Alertas VARCHAR(3),
CONSTRAINT Fk_id_caso_actividades FOREIGN KEY(Id_caso) REFERENCES JL_CASOS(Id_caso)
)

INSERT INTO JL_CLIENTES (Nombre, Apellido)
VALUES 
('Carlos', 'Gonzalez'),
('Maria', 'Lopez'),
('Juan', 'Martinez');

INSERT INTO JL_USUARIO (Tipo_usuario, Nombre, Apellido)
VALUES
('Abogado', 'Luis', 'Ramirez'),
('Abogado', 'Ana', 'Torres'),
('Asistente', 'Pedro', 'Santos');


INSERT INTO JL_CASOS (Nombre, Descripcion, Tipo_caso)
VALUES
('Caso Herencia', 'Disputa por herencia familiar', 'Civil'),
('Caso Robo', 'Cliente acusado de robo menor', 'Penal'),
('Divorcio Pérez', 'Divorcio de mutuo acuerdo', 'Familiar');

INSERT INTO JL_DOCUMENTOS (Id_caso, Tipo_documento)
VALUES
(1, 'Demanda'),
(1, 'Poder Notarial'),
(2, 'Declaración policial'),
(3, 'Acuerdo preliminar');

INSERT INTO JL_DETALLES_CASOS 
(Id_caso, Id_usuario, Id_clientes, Estado_caso, Fecha_inicio, Fecha_vencimiento)
VALUES
(1, 1, 1, 'En proceso', '2025-01-10', '2025-04-10'),
(2, 2, 2, 'Pendiente', '2025-02-01', '2025-03-01'),
(3, 1, 3, 'En revisión', '2025-03-05', '2025-06-05');

INSERT INTO JL_ACTIVIDADES 
(Id_caso, Tipo_actividad, Descripcion, Fecha_actividad, Alertas)
VALUES
(1, 'Reunión', 'Reunión inicial con el cliente', '2025-01-12', 'Si'),
(1, 'Audiencia', 'Audiencia preliminar', '2025-02-15', 'No'),
(2, 'Investigación', 'Revisión de pruebas policiales', '2025-02-05', 'Si'),
(3, 'Reunión', 'Reunión con ambas partes para conciliación', '2025-03-10', 'No');

SELECT * FROM JL_CLIENTES;
SELECT * FROM JL_USUARIO;
SELECT * FROM JL_CASOS;
SELECT * FROM JL_DOCUMENTOS;
SELECT * FROM JL_DETALLES_CASOS;
SELECT * FROM JL_ACTIVIDADES;
