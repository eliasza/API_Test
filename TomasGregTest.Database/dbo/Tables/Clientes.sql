CREATE TABLE [dbo].[Clientes](
    [Id] [int] IDENTITY(1,1) PRIMARY KEY,
    [Nome] [varchar](255) NOT NULL,
    [Email] [varchar](140) UNIQUE NOT NULL,
    [Logotipo] [varchar](100) NOT NULL
) ON [PRIMARY];
