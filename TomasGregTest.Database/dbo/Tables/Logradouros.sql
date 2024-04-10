CREATE TABLE [dbo].[Logradouros]
(
	[Id] [int] IDENTITY(1,1) PRIMARY KEY,
    [ClienteId] [int] NOT NULL,
    [Endereco] [varchar](100) NOT NULL,
    [Numero] [varchar](10) NOT NULL,
    [Bairro] [varchar](50) NOT NULL,
    [Cidade] [varchar](50) NOT NULL,
    [Estado] [char](2) NOT NULL,
    [Cep] [char](10) NOT NULL,
    CONSTRAINT fk_cliente_logradouro FOREIGN KEY (ClienteId) REFERENCES Clientes (Id)
)
