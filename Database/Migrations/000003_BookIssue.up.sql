CREATE TABLE [dbo].[BookIssue]
(
	[Id] UNIQUEIDENTIFIER NOT NULL
        CONSTRAINT [PK_BookIssue_Id] PRIMARY KEY (Id)
        CONSTRAINT [DF_BookIssue_Id] DEFAULT(NEWID()),
    [UserId] UNIQUEIDENTIFIER NOT NULL
        CONSTRAINT [FK_BookIssue_UserId] FOREIGN KEY ([UserId]) REFERENCES [User]([Id]) ON DELETE CASCADE,
    [BookId] UNIQUEIDENTIFIER NOT NULL
        CONSTRAINT [FK_BookIssue_BookId] FOREIGN KEY ([BookId]) REFERENCES [Book]([Id]) ON DELETE CASCADE,
    [IssuerId] UNIQUEIDENTIFIER NULL
        CONSTRAINT [FK_BookIssue_IssuerId] FOREIGN KEY ([IssuerId]) REFERENCES [User]([Id]) ON DELETE NO ACTION,
    [ReceiverId] UNIQUEIDENTIFIER NULL
        CONSTRAINT [FK_BookIssue_ReceiverId] FOREIGN KEY ([ReceiverId]) REFERENCES [User]([Id]) ON DELETE NO ACTION,
    [IssuedAt] DATETIME NOT NULL
        CONSTRAINT [DF_BookIssue_IssuedAt] DEFAULT(GETDATE()),
    [DueDate] DATE NOT NULL
        CONSTRAINT [DF_BookIssue_DueDate] DEFAULT(CAST(GETDATE() + 10 AS Date)), 
    [ReturnedAt] DATETIME NULL,
    [Returned] BIT NOT NULL
        CONSTRAINT [DF_BookIssue_Returned] DEFAULT(0),
    [CreatedAt] DATETIME NOT NULL
        CONSTRAINT [DF_BookIssue_CreatedAt] DEFAULT(GETDATE()),        
    [UpdatedAt] DATETIME NULL
)

GO

CREATE INDEX [IX_BookIssue_Returned] ON [dbo].[BookIssue] ([Returned])

GO

CREATE INDEX [IX_BookIssue_UserId_BookId] ON [dbo].[BookIssue] ([UserId], [BookId])

GO

CREATE INDEX [IX_BookIssue_IssuerId] ON [dbo].[BookIssue] ([IssuerId])

GO

CREATE INDEX [IX_BookIssue_ReceiverId] ON [dbo].[BookIssue] ([ReceiverId])

GO

CREATE TRIGGER [dbo].[TR_BookIssue_ForUpdate]
    ON [dbo].[BookIssue]
    FOR UPDATE
    AS
    BEGIN
        UPDATE [dbo].[BookIssue]
        SET [UpdatedAt] = GETDATE(),
            [ReturnedAt] = CASE WHEN [Id] IN (
                SELECT i.[Id] FROM Inserted i JOIN deleted d On d.[Id]=i.[Id] WHERE i.[Returned]=1 AND d.[Returned]=0
            ) THEN GETDATE() ELSE [ReturnedAt] END
        WHERE [Id] IN (SELECT [Id] FROM Inserted)
    END

GO
