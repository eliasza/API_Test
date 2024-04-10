CREATE TABLE [dbo].[Usuarios]
(
	[Id] [int] IDENTITY(1,1) PRIMARY KEY,
    [Nome] [varchar](100) NOT NULL,
    [Email] [varchar](150) NOT NULL,
    [Senha] [varchar](60) NOT NULL,
    [Ativo] [bit] NOT NULL
)
