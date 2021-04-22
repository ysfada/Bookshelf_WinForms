CREATE TABLE [dbo].[User]
(
	[Id] UNIQUEIDENTIFIER NOT NULL 
        CONSTRAINT [PK_User_Id] PRIMARY KEY (Id)
        CONSTRAINT [DF_User_Id] DEFAULT NEWID(),
    [Username] NVARCHAR(16) NOT NULL ,
    [Email] NVARCHAR(320) NOT NULL,
    [Password] VARCHAR(128) NOT NULL,
    [FirstName] NVARCHAR(32) NULL,
    [LastName] NVARCHAR(32) NULL,
    [Phone] VARCHAR(15) NULL,
    [Address] NVARCHAR(128) NULL,
    [Role] VARCHAR(16) NOT NULL
        CONSTRAINT [DF_User_Role] DEFAULT 'None'
        CONSTRAINT [CHK_User_Role] CHECK ([Role] IN('None', 'Admin', 'Staff', 'User')),
    --[RoleId] UNIQUEIDENTIFIER NOT NULL
    --    CONSTRAINT [FK_User_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [Role]([Id]),
    [CreatedAt] DATETIME NOT NULL
        CONSTRAINT [DF_User_CreatedAt] DEFAULT GETDATE(),
    [UpdatedAt] DATETIME NULL,
)

GO

CREATE UNIQUE INDEX [UIX_User_Username]
ON [dbo].[User]([Username])

GO

CREATE UNIQUE INDEX [UIX_User_Email]
ON [dbo].[User]([Email])

GO

CREATE UNIQUE INDEX [UIX_User_Phone_NullAllowed]
ON [dbo].[User]([Phone])
WHERE [Phone] IS NOT NULL;

GO

CREATE INDEX [IX_User_Username] ON [dbo].[User] ([Username])

GO

CREATE INDEX [IX_User_FirstName_LastName] ON [dbo].[User] ([FirstName], [LastName])

GO

CREATE INDEX [IX_User_Phone] ON [dbo].[User] ([Phone])

GO

CREATE INDEX [IX_User_Role] ON [dbo].[User] ([Role])

GO

--CREATE INDEX [IX_User_RoleId] ON [dbo].[User] ([RoleId])

--GO

CREATE TRIGGER [dbo].[TR_User_ForUpdate]
    ON [dbo].[User]
    FOR UPDATE
    AS
    BEGIN
        UPDATE [dbo].[User]
        SET [UpdatedAt] = GETDATE()
        WHERE [Id] IN (SELECT [Id] FROM Inserted)
    END

GO
