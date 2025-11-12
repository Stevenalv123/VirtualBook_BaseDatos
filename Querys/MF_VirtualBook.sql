USE master;
GO

CREATE DATABASE Db_VirtualBook;
GO

USE Db_VirtualBook;
GO

CREATE TABLE Rol (
    IdRol INT IDENTITY(1,1),
    NombreRol NVARCHAR(30) NOT NULL,

    CONSTRAINT PK_Rol PRIMARY KEY (IdRol)
);

INSERT INTO Rol (NombreRol) VALUES ('Administrador'),
                                   ('Docente'),
                                   ('Estudiante');

CREATE TABLE Usuario (
    IdUsuario INT IDENTITY(1,1),
    Nombres VARCHAR(50) NOT NULL,
    Apellidos VARCHAR(50) NOT NULL,
    Correo_Electronico VARCHAR(100) NOT NULL,
	Contrasena VARBINARY(32) NOT NULL,
    FotoPerfil NVARCHAR(MAX) NULL,
    IdRol INT NOT NULL FOREIGN KEY REFERENCES Rol(IdRol),
    FechaNacimiento DATETIME,
    Genero VARCHAR(10) CHECK (Genero IN ('Masculino', 'Femenino')),

	CONSTRAINT UQ_Correo_Usuario UNIQUE (Correo_Electronico),
    CONSTRAINT PK_Usuario PRIMARY KEY (IdUsuario)
);

CREATE TABLE Autor (
    IdAutor INT IDENTITY(1,1),
    NombreAutor VARCHAR(50) NOT NULL,
	Biografia VARCHAR(200),
	FechaNacimiento Date,
	Nacionalidad VARCHAR(30)

    CONSTRAINT PK_Autor PRIMARY KEY (IdAutor)
);

CREATE TABLE Categoria (
    IdCategoria INT IDENTITY(1,1),
    NombreCategoria VARCHAR(50) NOT NULL,

    CONSTRAINT PK_Categoria PRIMARY KEY (IdCategoria)
);

INSERT INTO Categoria (NombreCategoria)
VALUES 
('Matemáticas'),
('Física'),
('Química'),
('Biología'),
('Historia'),
('Literatura'),
('Informática'),
('Economía'),
('Psicología'),
('Filosofía'),
('Arte'),
('Ingeniería'),
('Medicina'),
('Derecho'),
('Idiomas');

CREATE TABLE Formato (
    IdFormato INT IDENTITY(1,1) PRIMARY KEY,
    NombreFormato VARCHAR(20) UNIQUE NOT NULL
);

CREATE TABLE Idioma (
	IdIdioma INT IDENTITY(1,1) PRIMARY KEY,
	NombreIdioma VARCHAR(100) UNIQUE NOT NULL
);

CREATE TABLE Libro (
    IdLibro INT IDENTITY(1,1),
    Titulo VARCHAR(100) NOT NULL,
    IdPublicador INT NOT NULL,
    IdCategoria INT NOT NULL,
    IdFormato INT NOT NULL,
    ArchivoPDF NVARCHAR(300) NOT NULL,
    Portada NVARCHAR(300) NOT NULL,
    IdIdioma INT,
    NumeroPaginas INT CHECK (NumeroPaginas > 0),
    FechaPublicacion DATETIME DEFAULT GETDATE() NOT NULL,
    Descripcion NVARCHAR(MAX),
	Descargas INT NOT NULL CHECK (Descargas > 0),

    CONSTRAINT PK_Libro PRIMARY KEY (IdLibro),
    CONSTRAINT FK_Publicador_Libro FOREIGN KEY (IdPublicador) REFERENCES Usuario(IdUsuario),
    CONSTRAINT FK_Categoria_Libro FOREIGN KEY (IdCategoria) REFERENCES Categoria(IdCategoria),
	CONSTRAINT FK_Formato_Libro FOREIGN KEY (IdFormato) REFERENCES Formato(IdFormato),
	CONSTRAINT FK_Idioma_Libro FOREIGN KEY (IdIdioma) REFERENCES Idioma(IdIdioma)
);

CREATE TABLE Libro_Autor (
    IdAutor INT NOT NULL,
    IdLibro INT NOT NULL,

    CONSTRAINT PK_LibroAutor PRIMARY KEY (IdAutor, IdLibro),
    CONSTRAINT FK_Autor FOREIGN KEY (IdAutor) REFERENCES Autor(IdAutor),
    CONSTRAINT FK_Libro FOREIGN KEY (IdLibro) REFERENCES Libro(IdLibro)
);

CREATE TABLE Favoritos (
    IdUsuario INT NOT NULL,
    IdLibro INT NOT NULL,

    CONSTRAINT PK_Favorito PRIMARY KEY (IdUsuario, IdLibro),
    CONSTRAINT FK_Usuario_Favorito FOREIGN KEY (IdUsuario) REFERENCES Usuario(IdUsuario),
    CONSTRAINT FK_Libro_Favorito FOREIGN KEY (IdLibro) REFERENCES Libro(IdLibro),
    CONSTRAINT UQ_Favoritos UNIQUE (IdUsuario, IdLibro)
);

CREATE TABLE Reseña (
    IdUsuario INT NOT NULL,
    IdLibro INT NOT NULL,
    Calificacion INT CHECK (Calificacion BETWEEN 1 AND 5) NOT NULL,
    Comentario NVARCHAR(MAX),
    FechaReseña DATETIME DEFAULT GETDATE() NOT NULL,

    CONSTRAINT PK_Reseña PRIMARY KEY (IdUsuario, IdLibro),
    CONSTRAINT FK_Usuario_Reseña FOREIGN KEY (IdUsuario) REFERENCES Usuario(IdUsuario),
    CONSTRAINT FK_Libro_Reseña FOREIGN KEY (IdLibro) REFERENCES Libro(IdLibro),
    CONSTRAINT UQ_Reseña UNIQUE (IdUsuario, IdLibro)
);

CREATE TABLE Seguimiento (
    IdSeguimiento INT IDENTITY(1,1),
    IdSeguidor INT NOT NULL,
    IdSeguido INT NOT NULL,
    FechaSeguimiento DATETIME DEFAULT GETDATE() NOT NULL,
    
    CONSTRAINT PK_Seguimiento PRIMARY KEY (IdSeguimiento),
    CONSTRAINT FK_Seguidor FOREIGN KEY (IdSeguidor) REFERENCES Usuario(IdUsuario),
    CONSTRAINT FK_Seguido FOREIGN KEY (IdSeguido) REFERENCES Usuario(IdUsuario),
    CONSTRAINT UQ_Seguimiento UNIQUE (IdSeguidor, IdSeguido)
);

CREATE TABLE Notificacion (
    IdNotificacion INT IDENTITY(1,1),
    IdUsuario INT NOT NULL,
    IdLibro INT,
    FechaNotificacion DATETIME DEFAULT GETDATE() NOT NULL,
    Leido BIT DEFAULT 0 NOT NULL,
    TipoNotificacion VARCHAR(50) CHECK (TipoNotificacion IN ('NuevoLibro', 'ReseñaRecibida', 'SeguidorNuevo', 'Comentario')),

    CONSTRAINT PK_Notificacion PRIMARY KEY (IdNotificacion),
    CONSTRAINT FK_Notificacion_Usuario FOREIGN KEY (IdUsuario) REFERENCES Usuario(IdUsuario),
    CONSTRAINT FK_Notificacion_Libro FOREIGN KEY (IdLibro) REFERENCES Libro(IdLibro)
);
