create database Mascota
go

/*DESKTOP-J5HSONP*/
use Mascota
go

CREATE TABLE Tareas(
	id_tarea INTEGER PRIMARY KEY,
	descripcion_tarea VARCHAR(50)

)

CREATE TABLE Personal(
	id_personal INTEGER PRIMARY KEY,
	apellido VARCHAR(50),
	nombre VARCHAR(50),
	dni INTEGER,
	direccion VARCHAR(50),
	email VARCHAR(50),
	telefono VARCHAR(50),
	id_tarea INTEGER,
	FOREIGN KEY (id_tarea) REFERENCES Tareas(id_tarea),
)

CREATE TABLE Tipo_hogar(
	id_tipo_hogar INTEGER PRIMARY KEY,
	descripcion_tipo_hogar VARCHAR(50),
)

CREATE TABLE Hogar(
	id_hogar INTEGER PRIMARY KEY,
	nombre VARCHAR(50),
	direccion VARCHAR(50),
	telefono VARCHAR(50),
	id_personal INTEGER,
	id_tipo_hogar INTEGER,
	FOREIGN KEY (id_personal) REFERENCES Personal(id_personal),
	FOREIGN KEY (id_tipo_hogar) REFERENCES Tipo_hogar(id_tipo_hogar)
)
CREATE TABLE Especie(
	id_especie INTEGER PRIMARY KEY,
	descripcion VARCHAR(50)
)

CREATE TABLE Raza(
	id_raza INTEGER PRIMARY KEY,
	descripcion VARCHAR(50)
)

CREATE TABLE Mascotas(
	id_mascota INTEGER PRIMARY KEY,
	nombre VARCHAR(50),
	sexo VARCHAR(50),
	id_especie INTEGER,
	id_raza INTEGER,
	color VARCHAR(50),
	id_hogar INTEGER,
	FOREIGN KEY (id_especie) REFERENCES Especie(id_especie),
	FOREIGN KEY (id_raza) REFERENCES Raza(id_raza),
	FOREIGN KEY (id_hogar) REFERENCES Hogar(id_hogar)
)

CREATE TABLE Adoptantes(
	id_adoptante INTEGER PRIMARY KEY,
	apellido VARCHAR(50),
	nombre VARCHAR(50),
	dni INTEGER,
	direccion VARCHAR(50),
	email VARCHAR(50),
	telefono VARCHAR(50)
)
CREATE TABLE Usuarios(
	usuario VARCHAR(255) PRIMARY KEY,
	pass VARCHAR(255)
)

CREATE TABLE Adopcion(
	id_adopcion INTEGER PRIMARY KEY,
	id_adoptante INTEGER,
	fecha_adopcion DATE,
	usuario VARCHAR(255),
	FOREIGN KEY (id_adoptante) REFERENCES Adoptantes(id_adoptante),
	FOREIGN KEY (usuario) REFERENCES Usuarios(usuario)
)

CREATE TABLE DetalleAdopcion(
	id_detalle INTEGER PRIMARY KEY,
	id_adopcion INTEGER,
	id_mascota INTEGER,
	FOREIGN KEY (id_adopcion) REFERENCES Adopcion(id_adopcion),
	FOREIGN KEY (id_mascota) REFERENCES Mascotas(id_mascota)
)



INSERT INTO Tareas(id_tarea, descripcion_tarea) VALUES (1, 'Admin')
INSERT INTO Tareas(id_tarea, descripcion_tarea) VALUES (2, 'Ayudante')

INSERT INTO Personal(id_personal, apellido, nombre, dni, direccion, email, telefono, id_tarea) VALUES (1, 'Castillo', 'Claudio', 30123456, 'Junín 123', 'claudio@gmail.com', '3794000111', 1)
INSERT INTO Personal(id_personal, apellido, nombre, dni, direccion, email, telefono, id_tarea) VALUES (2, 'Perez', 'Juan', 33789456, 'Castelli 2514', 'juan@gmail.com', '37947898444', 2)

INSERT INTO Tipo_hogar(id_tipo_hogar, descripcion_tipo_hogar) VALUES (1, 'Refugio')
INSERT INTO Tipo_hogar(id_tipo_hogar, descripcion_tipo_hogar) VALUES (2, 'Transitorio')

INSERT INTO Hogar(id_hogar, nombre, direccion, telefono, id_personal, id_tipo_hogar ) VALUES (1, 'Hogar Mascotas', 'Belgrano 456', '3794555888', 1, 1)
INSERT INTO Hogar(id_hogar, nombre, direccion, telefono, id_personal, id_tipo_hogar ) VALUES (2, 'ONG Mascotas', 'San Martín 1234', '3794589896', 2, 2)

INSERT INTO Especie(id_especie, descripcion) VALUES (1, 'Perro')
INSERT INTO Especie(id_especie, descripcion) VALUES (2, 'Gato')

INSERT INTO Raza(id_raza, descripcion) VALUES (1, 'Caniche')
INSERT INTO Raza(id_raza, descripcion) VALUES (2, 'Bulldog')
INSERT INTO Raza(id_raza, descripcion) VALUES (3, 'Siamés')
INSERT INTO Raza(id_raza, descripcion) VALUES (4, 'Gato Persa')
INSERT INTO Raza(id_raza, descripcion) VALUES (5, 'Perro Mestizo')
INSERT INTO Raza(id_raza, descripcion) VALUES (6, 'Gato Mestizo')

INSERT INTO Mascotas(id_mascota, nombre, sexo, id_especie, id_raza, color, id_hogar) VALUES (1, 'Toby', 'Macho', 1, 1, 'Blanco', 1)
INSERT INTO Mascotas(id_mascota, nombre, sexo, id_especie, id_raza, color, id_hogar) VALUES (2, 'Negro', 'Macho', 2, 3, 'Negro', 2)
INSERT INTO Mascotas(id_mascota, nombre, sexo, id_especie, id_raza, color, id_hogar) VALUES (5, 'Capitan', 'Macho', 2, 5, 'Marron', 2)



INSERT INTO Adoptantes(id_adoptante, apellido, nombre, dni, direccion, email, telefono) VALUES (1, 'Gonzales', 'Maria', 27789456, 'Francia 789', 'maria@gmail.com', 3794999888)
INSERT INTO Adoptantes(id_adoptante, apellido, nombre, dni, direccion, email, telefono) VALUES (2, 'Alarcón', 'Lidia', 35000111, 'Chacabuco 1247', 'lidia@gmail.com', 3794222444)

INSERT INTO Usuarios(usuario, pass) VALUES ('responsable', '1234')
INSERT INTO Usuarios(usuario, pass) VALUES ('ayudante', '123')