using Bookshelf.Database.Entities;
using Bookshelf.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Bookshelf.Database.Repositories
{
    internal static class BookRepository
    {
        internal static async Task<BookEntity> CreateAsync(BookEntity book)
        {
            //await Task.Delay(3000);
            await using var connection = Database.CreateConnection();

            const string cmdText = @"
                INSERT INTO [dbo].[Book]
                ([BookName], [Pages], [PublishedAt], [Edition], [Author], [Genre], [Borrowed])
                OUTPUT Inserted.[Id], Inserted.[BookName], Inserted.[Pages], [Inserted].[PublishedAt], [Inserted].[Edition], [Inserted].[Author], [Inserted].[Genre], [Inserted].[Borrowed]
                VALUES (@bookName, @pages, @publishedAt, @edition, @author, @genre, @borrowed);";

            var command = new SqlCommand(cmdText, connection);
            command.Parameters.Add("@bookName", SqlDbType.NVarChar, 32).Value = book.BookName;
            command.Parameters.Add("@pages", SqlDbType.VarChar, 5).Value =
                (book.Pages.IsNullOrEmpty()) ? DBNull.Value : (object) book.Pages;
            command.Parameters.Add("@publishedAt", SqlDbType.VarChar, 4).Value =
                (book.PublishedAt.IsNullOrEmpty()) ? DBNull.Value : (object) book.PublishedAt;
            command.Parameters.Add("@edition", SqlDbType.VarChar, 3).Value =
                (book.Edition.IsNullOrEmpty()) ? DBNull.Value : (object) book.Edition;
            command.Parameters.Add("@author", SqlDbType.NVarChar, 32).Value = book.Author;
            command.Parameters.Add("@genre", SqlDbType.VarChar, 16).Value = book.Genre;
            command.Parameters.Add("@borrowed", SqlDbType.Bit).Value = Convert.ToInt32(book.Borrowed);

            await command.Connection.OpenAsync();
            var reader = await command.ExecuteReaderAsync();
            if (!reader.Read()) return null;

            var newBook = new BookEntity()
            {
                Id = reader.GetGuid(0),
                BookName = reader.GetString(1),
                Pages = reader.GetStringSafe(2),
                PublishedAt = reader.GetStringSafe(3),
                Edition = reader.GetStringSafe(4),
                Author = reader.GetString(5),
                Genre = reader.GetString(6).ToGenre(),
                Borrowed = reader.GetBoolean(7)
            };

            return newBook;
        }

        internal static async Task<BookEntity> EditAsync(BookEntity book)
        {
            //await Task.Delay(3000);
            await using var connection = Database.CreateConnection();

            const string cmdText = @"
                BEGIN TRANSACTION [BookEntity_EditAsync]
                    BEGIN TRY
                        DECLARE @bookTableVariable TABLE (
                            [Id] UNIQUEIDENTIFIER NOT NULL,
                            [BookName] NVARCHAR(32) NOT NULL,
                            [Pages] VARCHAR(5) NULL,
                            [PublishedAt] VARCHAR(4) NULL,
                            [Edition] VARCHAR(3) NULL,
                            [Author] NVARCHAR(32) NOT NULL,
                            [Genre] VARCHAR(16) NOT NULL,
                            [Borrowed] BIT NOT NULL
                        );

                        UPDATE TOP (1) [dbo].[Book]
                        SET [BookName]=@bookName, [Pages]=@pages, [PublishedAt]=@publishedAt, [Edition]=@edition, [Author]=@author, [Genre]=@genre, [Borrowed]=@borrowed
                        OUTPUT Inserted.[Id], Inserted.[BookName], Inserted.[Pages], [Inserted].[PublishedAt], [Inserted].[Edition], [Inserted].[Author], [Inserted].[Genre], [Inserted].[Borrowed]
                        INTO @bookTableVariable
                        WHERE [Id]=@id;

                        SELECT * FROM @bookTableVariable;

                        COMMIT TRANSACTION [BookEntity_EditAsync]
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
            command.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = book.Id;
            command.Parameters.Add("@bookName", SqlDbType.NVarChar, 32).Value = book.BookName;
            command.Parameters.Add("@pages", SqlDbType.VarChar, 5).Value =
                (book.Pages.IsNullOrEmpty()) ? DBNull.Value : (object) book.Pages;
            command.Parameters.Add("@publishedAt", SqlDbType.VarChar, 4).Value =
                (book.PublishedAt.IsNullOrEmpty()) ? DBNull.Value : (object) book.PublishedAt;
            command.Parameters.Add("@edition", SqlDbType.VarChar, 3).Value =
                (book.Edition.IsNullOrEmpty()) ? DBNull.Value : (object) book.Edition;
            command.Parameters.Add("@author", SqlDbType.NVarChar, 32).Value = book.Author;
            command.Parameters.Add("@genre", SqlDbType.VarChar, 16).Value = book.Genre;
            command.Parameters.Add("@borrowed", SqlDbType.Bit).Value = Convert.ToInt32(book.Borrowed);

            await command.Connection.OpenAsync();
            var reader = await command.ExecuteReaderAsync();
            if (!reader.Read()) return null;

            var editedBook = new BookEntity()
            {
                Id = reader.GetGuid(0),
                BookName = reader.GetString(1),
                Pages = reader.GetStringSafe(2),
                PublishedAt = reader.GetStringSafe(3),
                Edition = reader.GetStringSafe(4),
                Author = reader.GetString(5),
                Genre = reader.GetString(6).ToGenre(),
                Borrowed = reader.GetBoolean(7)
            };

            return editedBook;
        }

        internal static async Task<BookEntity> DeleteAsync(Guid id)
        {
            //await Task.Delay(3000);
            await using var connection = Database.CreateConnection();

            const string cmdText = @"
                DECLARE @bookTableVariable TABLE (
                    [Id] UNIQUEIDENTIFIER NOT NULL,
                    [BookName] NVARCHAR(32) NOT NULL,
                    [Pages] VARCHAR(5) NULL,
                    [PublishedAt] VARCHAR(4) NULL,
                    [Edition] VARCHAR(3) NULL,
                    [Author] NVARCHAR(32) NOT NULL,
                    [Genre] VARCHAR(16) NOT NULL,
                    [Borrowed] BIT NOT NULL
                );

                DELETE TOP (1)
                FROM [dbo].[Book]
                OUTPUT [Deleted].[Id], [Deleted].[BookName], [Deleted].[Pages], [Deleted].[PublishedAt], [Deleted].[Edition], [Deleted].[Author], [Deleted].[Genre], [Deleted].[Borrowed]
                WHERE [Id]=@id;";

            var command = new SqlCommand(cmdText, connection);
            command.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = id;

            await command.Connection.OpenAsync();
            var reader = await command.ExecuteReaderAsync();
            if (!reader.Read()) return null;

            var deletedBook = new BookEntity()
            {
                Id = reader.GetGuid(0),
                BookName = reader.GetString(1),
                Pages = reader.GetStringSafe(2),
                PublishedAt = reader.GetStringSafe(3),
                Edition = reader.GetStringSafe(4),
                Author = reader.GetString(5),
                Genre = reader.GetString(6).ToGenre(),
                Borrowed = reader.GetBoolean(7)
            };

            return deletedBook;
        }

        /// <summary>
        /// Search books that Id, BookName or Author columns contains parameter 'text'
        /// </summary>
        /// <param name="text"></param>
        /// <param name="orderAsc"></param>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="getAll"></param>
        /// <param name="availableOnly"></param>
        /// <returns></returns>
        internal static async Task<List<BookEntity>> SearchAsync(string text, bool orderAsc, int page, int limit,
            bool getAll = true, bool availableOnly = false)
        {
            //await Task.Delay(3000);
            await using var connection = Database.CreateConnection();

            var cmdText = @$"
                SELECT [Id], [BookName], [Pages], [PublishedAt], [Edition], [Author], [Genre], [Borrowed]
                FROM [dbo].[Book]
                WHERE ([Id] LIKE @text OR [BookName] LIKE @text OR [Author] LIKE @text) {(getAll ? string.Empty : (availableOnly ? "AND [Borrowed]=0" : "AND [Borrowed]=1"))}
                ORDER BY [BookName] {(orderAsc ? "ASC" : "DESC")}
                OFFSET (@page-1)*@limit ROWS FETCH NEXT @limit ROWS ONLY;";

            var command = new SqlCommand(cmdText, connection);
            command.Parameters.Add("@text", SqlDbType.NVarChar, 36).Value = $"%{text}%";
            command.Parameters.Add("@limit", SqlDbType.Int).Value = limit;
            command.Parameters.Add("@page", SqlDbType.Int).Value = page;

            await command.Connection.OpenAsync();
            var reader = await command.ExecuteReaderAsync();

            var books = new List<BookEntity>();
            while (reader.Read())
            {
                var book = new BookEntity()
                {
                    Id = reader.GetGuid(0),
                    BookName = reader.GetString(1),
                    Pages = reader.GetStringSafe(2),
                    PublishedAt = reader.GetStringSafe(3),
                    Edition = reader.GetStringSafe(4),
                    Author = reader.GetString(5),
                    Genre = reader.GetString(6).ToGenre(),
                    Borrowed = reader.GetBoolean(7)
                };

                books.Add(book);
            }

            return books;
        }
    }
}