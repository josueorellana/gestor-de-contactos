CREATE TABLE [dbo].[Usuarios] (
    [Iddeusuario]               INT          IDENTITY (1, 1) NOT NULL DEFAULT 0,
    [Nombres]          CHAR (25)    NOT NULL,
    [Apellidos]        CHAR (25)    NOT NULL,
    [Correo]           CHAR (40)    NOT NULL,
    [Numerodetelefono] NUMERIC (30) NOT NULL,
    [Password]         CHAR (30)    NOT NULL,
    PRIMARY KEY CLUSTERED ([Iddeusuario] ASC)
);

