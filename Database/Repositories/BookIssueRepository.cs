using Bookshelf.Database.Entities;
using Bookshelf.Utilities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Bookshelf.Database.Repositories
{
    internal static class BookIssueRepository
    {
        //private const int RowPerPage = 2;

        internal static async Task<BookIssueEntity> GiveBookAsync(BookIssueEntity bookIssue)
        {
            //await Task.Delay(3000);
            await using var connection = Database.CreateConnection();

            const string cmdText = @"
                BEGIN TRANSACTION [BookIssueEntity_GiveBookAsync]
                    BEGIN TRY
                        UPDATE dbo.[Book]
                        SET [Borrowed]=1
                        WHERE [Id]=@bookId

                        DECLARE @bookIssueTableVariable TABLE(
                            [Id]            UNIQUEIDENTIFIER NOT NULL,
                            [UserId]        UNIQUEIDENTIFIER NOT NULL,
                            [BookId]        UNIQUEIDENTIFIER NOT NULL,
                            [IssuerId]      UNIQUEIDENTIFIER NOT NULL,
                            [ReceiverId]    UNIQUEIDENTIFIER NULL,
                            [IssuedAt]      DATETIME NOT NULL,
                            [DueDate]       DATE NOT NULL,
                            [ReturnedAt]    DATETIME NULL,
                            [Returned]      BIT NOT NULL
                        );

                        INSERT INTO [dbo].[BookIssue]
                            ([UserId], [BookId], [IssuerId], [DueDate])
                        OUTPUT Inserted.[Id], Inserted.[UserId], Inserted.[BookId], [Inserted].[IssuerId], [Inserted].[ReceiverId], [Inserted].[IssuedAt], [Inserted].[DueDate], [Inserted].[ReturnedAt], [Inserted].[Returned]
                        INTO @bookIssueTableVariable
                        VALUES (@userId, @bookId, @issuerId, @duaDate);

                        SELECT t.[Id], t.[UserId], usr.[Username], t.[BookId], book.[BookName], t.[IssuerId], issuer.[Username], t.[ReceiverId], receiver.[Username], t.[IssuedAt], t.[DueDate], t.[ReturnedAt], t.[Returned]
                        FROM @bookIssueTableVariable t
                        JOIN [dbo].[Book] book ON book.[Id] = t.[BookId]
                        JOIN [dbo].[User] usr ON usr.[Id] = t.[UserId]
                        JOIN [dbo].[User] issuer ON issuer.[Id] = t.[IssuerId]
                        LEFT OUTER JOIN [dbo].[User] receiver ON receiver.[Id] = t.[ReceiverId];

                        COMMIT TRANSACTION [BookIssueEntity_GiveBookAsync]
                    END TRY
                    BEGIN CATCH
                        DECLARE
                            @ErrorMessage NVARCHAR(max), 
                            @ErrorSeverity INT, 
                            @ErrorState INT;

                        SELECT
                            @ErrorMessage = ERROR_MESSAGE() + ' Line ' + CAST(ERROR_LINE() AS NVARCHAR(5)),
                            @ErrorSeverity = ERROR_SEVERITY(),
                            @ErrorState = ERROR_STATE();

                        if @@TRANCOUNT > 0
                            ROLLBACK TRANSACTION [Tran1]

                        RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
                    END CATCH";

            var command = new SqlCommand(cmdText, connection);
            command.Parameters.Add("@userId", SqlDbType.UniqueIdentifier).Value = bookIssue.UserId;
            command.Parameters.Add("@bookId", SqlDbType.UniqueIdentifier).Value = bookIssue.BookId;
            command.Parameters.Add("@issuerId", SqlDbType.UniqueIdentifier).Value = bookIssue.IssuerId;
            command.Parameters.Add("@duaDate", SqlDbType.Date).Value = bookIssue.DueDate;

            await command.Connection.OpenAsync();
            var reader = await command.ExecuteReaderAsync();
            if (!reader.Read()) return null;

            var newBookIssue = new BookIssueEntity()
            {
                Id = reader.GetGuid(0),
                UserId = reader.GetGuid(1),
                User = new UserEntity() {Username = reader.GetString(2)},
                BookId = reader.GetGuid(3),
                Book = new BookEntity() {BookName = reader.GetString(4)},
                IssuerId = reader.GetGuid(5),
                Issuer = new UserEntity() {Username = reader.GetString(6)},
                ReceiverId = reader.GetGuidSafe(7),
                Receiver = new UserEntity() {Username = reader.GetStringSafe(8)},
                IssuedAt = reader.GetDateTime(9),
                DueDate = reader.GetDateTime(10),
                ReturnedAt = reader.GetDateTimeSafe(11),
                Returned = reader.GetBoolean(12)
            };

            return newBookIssue;
        }

        internal static async Task<BookIssueEntity> TakeBookAsync(Guid bookId, Guid receiverId)
        {
            //await Task.Delay(3000);
            await using var connection = Database.CreateConnection();

            const string cmdText = @"
                BEGIN TRANSACTION [BookIssueEntity_TakeBookAsync]
                    BEGIN TRY
                        UPDATE dbo.[Book]
                        SET [Borrowed]=0
                        WHERE [Id]=@bookId

                        DECLARE @bookIssueId TABLE (
							[Id] UNIQUEIDENTIFIER NOT NULL
						);

                        UPDATE TOP (1) [dbo].[BookIssue]
                        SET [Returned]=1,
                            [ReceiverId]=@receiverId
                        OUTPUT Inserted.[Id]
                        INTO @bookIssueId
                        WHERE [Id]=(
                            SELECT TOP (1) [Id]
                            FROM [dbo].[BookIssue]
                            WHERE [BookId]=@bookId AND [Returned]=0
                        );

                        SELECT TOP (1) bookIssue.[Id], bookIssue.[UserId], usr.[Username], bookIssue.[BookId], book.[BookName], bookIssue.[IssuerId], issuer.[Username], bookIssue.[ReceiverId], receiver.[Username], bookIssue.[IssuedAt], bookIssue.[DueDate], bookIssue.[ReturnedAt], bookIssue.[Returned]
                        FROM [dbo].[BookIssue] bookIssue
                        JOIN [dbo].[Book] book ON book.[Id] = bookIssue.[BookId]
                        JOIN [dbo].[User] usr ON usr.[Id] = bookIssue.[UserId]
                        JOIN [dbo].[User] issuer ON issuer.[Id] = bookIssue.[IssuerId]
                        LEFT OUTER JOIN [dbo].[User] receiver ON receiver.[Id] = bookIssue.[ReceiverId]
		                WHERE bookIssue.[Id]=(SELECT TOP (1) [Id] FROM @bookIssueId);

                        COMMIT TRANSACTION [BookIssueEntity_TakeBookAsync]
                    END TRY
                    BEGIN CATCH
                        DECLARE
                            @ErrorMessage NVARCHAR(max), 
                            @ErrorSeverity INT, 
                            @ErrorState INT;

                        SELECT
                            @ErrorMessage = ERROR_MESSAGE() + ' Line ' + CAST(ERROR_LINE() AS NVARCHAR(5)),
                            @ErrorSeverity = ERROR_SEVERITY(),
                            @ErrorState = ERROR_STATE();

                        if @@TRANCOUNT > 0
                            ROLLBACK TRANSACTION [Tran1]

                        RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
                    END CATCH";

            var command = new SqlCommand(cmdText, connection);
            command.Parameters.Add("@bookId", SqlDbType.UniqueIdentifier).Value = bookId;
            command.Parameters.Add("@receiverId", SqlDbType.UniqueIdentifier).Value = receiverId;

            await command.Connection.OpenAsync();
            var reader = await command.ExecuteReaderAsync();
            if (!reader.Read()) return null;

            var newBookIssue = new BookIssueEntity()
            {
                Id = reader.GetGuid(0),
                UserId = reader.GetGuid(1),
                User = new UserEntity() {Username = reader.GetString(2)},
                BookId = reader.GetGuid(3),
                Book = new BookEntity() {BookName = reader.GetString(4)},
                IssuerId = reader.GetGuid(5),
                Issuer = new UserEntity() {Username = reader.GetString(6)},
                ReceiverId = reader.GetGuidSafe(7),
                Receiver = new UserEntity() {Username = reader.GetStringSafe(8)},
                IssuedAt = reader.GetDateTime(9),
                DueDate = reader.GetDateTime(10),
                ReturnedAt = reader.GetDateTimeSafe(11),
                Returned = reader.GetBoolean(12)
            };

            return newBookIssue;
        }
    }
}