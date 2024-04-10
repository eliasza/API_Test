CREATE PROCEDURE [dbo].[spLogradourosDelete]
	@Id INT,
    @ClienteId INT,
    @RowCount INT OUTPUT
AS
BEGIN
    IF EXISTS (SELECT 1 FROM Logradouros WHERE Id = @Id AND ClienteId = @ClienteId)
    BEGIN
        DELETE FROM Logradouros WHERE Id = @Id AND ClienteId = @ClienteId;
        SET @RowCount = @@ROWCOUNT;
    END
    ELSE
    BEGIN
        SET @RowCount = 0;
    END
END;
