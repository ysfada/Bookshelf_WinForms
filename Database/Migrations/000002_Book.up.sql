CREATE TABLE [dbo].[Book]
(
	[Id] UNIQUEIDENTIFIER NOT NULL
        CONSTRAINT [PK_Book_Id] PRIMARY KEY (Id)
        CONSTRAINT [DF_Book_Id] DEFAULT(NEWID()),
    [BookName] NVARCHAR(64) NOT NULL,
    [Pages] VARCHAR(5) NULL,
    [PublishedAt] VARCHAR(4) NULL,
    [Edition] VARCHAR(3) NULL,
    [Author] NVARCHAR(64) NOT NULL,
    --[AuthorId] UNIQUEIDENTIFIER NOT NULL
        --CONSTRAINT [FK_Book_AuthorId] FOREIGN KEY ([AuthorId]) REFERENCES [Author]([Id]),
    [Genre] VARCHAR(16) NOT NULL
        CONSTRAINT [DF_Book_Genre] DEFAULT('Other')
        CONSTRAINT [CHK_Book_Genre] CHECK ([Genre] IN('Other', 'Literature', 'Education', 'Politics', 'Philosophy', 'Psychology', 'History', 'Hobby')),
        --CONSTRAINT [FK_Book_GenreId] FOREIGN KEY ([GenreId]) REFERENCES [Genre]([Id]),
    --[GenreId] UNIQUEIDENTIFIER NOT NULL,
    [Borrowed] BIT NOT NULL DEFAULT 0,
    [CreatedAt] DATETIME NOT NULL
        CONSTRAINT [DF_Book_CreatedAt] DEFAULT(GETDATE()), 
    [UpdatedAt] DATETIME NULL, 
)

GO

CREATE INDEX [IX_Book_BookName] ON [dbo].[Book] ([BookName])

GO

CREATE INDEX [IX_Book_AuthorId] ON [dbo].[Book] ([Author])

GO

--CREATE INDEX [IX_Book_AuthorId] ON [dbo].[Book] ([AuthorId])

--GO

CREATE INDEX [IX_Book_GenreId] ON [dbo].[Book] ([Genre])

GO

--CREATE INDEX [IX_Book_GenreId] ON [dbo].[Book] ([GenreId])

--GO

CREATE INDEX [IX_Book_Borrowed] ON [dbo].[Book] ([Borrowed])

GO

CREATE TRIGGER [dbo].[TR_Book_ForUpdate]
    ON [dbo].[Book]
    FOR UPDATE
    AS
    BEGIN
        UPDATE [dbo].[Book]
        SET [UpdatedAt] = GETDATE()
        WHERE [Id] IN (SELECT [Id] FROM Inserted)
    END

GO
