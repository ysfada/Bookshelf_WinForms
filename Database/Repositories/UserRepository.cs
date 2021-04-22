using Bookshelf.Database.Entities;
using Bookshelf.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Bookshelf.Database.Repositories
{
    internal static class UserRepository
    {
        internal static UserEntity Create(UserEntity user)
        {
            //Task.Delay(3000).Wait();
            using var connection = Database.CreateConnection();

            user.Password = Hash.Create(user.Password);

            const string cmdText = @"
                INSERT INTO [dbo].[User]
                ([Username], [Email], [Password], [FirstName], [LastName], [Phone], [Address], [Role])
                OUTPUT Inserted.[Id], Inserted.[Username], Inserted.[Email], [Inserted].[FirstName], [Inserted].[LastName], [Inserted].[Phone], [Inserted].[Address], [Inserted].[Role]
                VALUES (@username, @email, @password, @firstName, @lastName, @phone, @address, @role);";

            var command = new SqlCommand(cmdText, connection);
            command.Parameters.Add("@username", SqlDbType.NVarChar, 16).Value = user.Username;
            command.Parameters.Add("@email", SqlDbType.NVarChar, 320).Value = user.Email;
            command.Parameters.Add("@password", SqlDbType.VarChar, 128).Value = user.Password;
            command.Parameters.Add("@firstName", SqlDbType.NVarChar, 16).Value =
                (user.FirstName.IsNullOrEmpty()) ? DBNull.Value : (object) user.FirstName;
            command.Parameters.Add("@lastName", SqlDbType.NVarChar, 16).Value =
                (user.LastName.IsNullOrEmpty()) ? DBNull.Value : (object) user.LastName;
            command.Parameters.Add("@phone", SqlDbType.VarChar, 15).Value =
                (user.Phone.IsNullOrEmpty()) ? DBNull.Value : (object) user.Phone;
            command.Parameters.Add("@address", SqlDbType.NVarChar, 128).Value =
                (user.Address.IsNullOrEmpty()) ? DBNull.Value : (object) user.Address;
            command.Parameters.Add("@role", SqlDbType.VarChar, 16).Value = user.Role.ToString();

            command.Connection.Open();
            var reader = command.ExecuteReader();
            if (!reader.Read()) return null;

            var newUser = new UserEntity()
            {
                Id = reader.GetGuid(0),
                Username = reader.GetString(1),
                Email = reader.GetString(2),
                FirstName = reader.GetStringSafe(3),
                LastName = reader.GetStringSafe(4),
                Phone = reader.GetStringSafe(5),
                Address = reader.GetStringSafe(6),
                Role = reader.GetString(7).ToRole()
            };

            return newUser;
        }

        internal static async Task<UserEntity> CreateAsync(UserEntity user)
        {
            //await Task.Delay(3000);
            await using var connection = Database.CreateConnection();

            user.Password = await Hash.CreateAsync(user.Password);

            const string cmdText = @"
                INSERT INTO [dbo].[User]
                ([Username], [Email], [Password], [FirstName], [LastName], [Phone], [Address], [Role])
                OUTPUT Inserted.[Id], Inserted.[Username], Inserted.[Email], [Inserted].[FirstName], [Inserted].[LastName], [Inserted].[Phone], [Inserted].[Address], [Inserted].[Role]
                VALUES (@username, @email, @password, @firstName, @lastName, @phone, @address, @role);";

            var command = new SqlCommand(cmdText, connection);
            command.Parameters.Add("@username", SqlDbType.NVarChar, 16).Value = user.Username;
            command.Parameters.Add("@email", SqlDbType.NVarChar, 320).Value = user.Email;
            command.Parameters.Add("@password", SqlDbType.VarChar, 128).Value = user.Password;
            command.Parameters.Add("@firstName", SqlDbType.NVarChar, 16).Value =
                (user.FirstName.IsNullOrEmpty()) ? DBNull.Value : (object) user.FirstName;
            command.Parameters.Add("@lastName", SqlDbType.NVarChar, 16).Value =
                (user.LastName.IsNullOrEmpty()) ? DBNull.Value : (object) user.LastName;
            command.Parameters.Add("@phone", SqlDbType.VarChar, 15).Value =
                (user.Phone.IsNullOrEmpty()) ? DBNull.Value : (object) user.Phone;
            command.Parameters.Add("@address", SqlDbType.NVarChar, 128).Value =
                (user.Address.IsNullOrEmpty()) ? DBNull.Value : (object) user.Address;
            command.Parameters.Add("@role", SqlDbType.VarChar, 16).Value = user.Role.ToString();

            await command.Connection.OpenAsync();
            var reader = await command.ExecuteReaderAsync();
            if (!reader.Read()) return null;

            var newUser = new UserEntity()
            {
                Id = reader.GetGuid(0),
                Username = reader.GetString(1),
                Email = reader.GetString(2),
                FirstName = reader.GetStringSafe(3),
                LastName = reader.GetStringSafe(4),
                Phone = reader.GetStringSafe(5),
                Address = reader.GetStringSafe(6),
                Role = reader.GetString(7).ToRole()
            };

            return newUser;
        }

        internal static async Task<UserEntity> EditAsync(UserEntity user)
        {
            //await Task.Delay(3000);
            await using var connection = Database.CreateConnection();

            if (!user.Password.IsNullOrEmpty())
                user.Password = await Hash.CreateAsync(user.Password);

            const string cmdText = @"
                BEGIN TRANSACTION [UserEntity_EditAsync]
                    BEGIN TRY
                        DECLARE @userTableVariable TABLE (
                            [Id] UNIQUEIDENTIFIER NOT NULL,
                            [Username] NVARCHAR(16) NOT NULL,
                            [Email] NVARCHAR(320) NOT NULL,
                            [FirstName] NVARCHAR(32) NULL,
                            [LastName] NVARCHAR(32) NULL,
                            [Phone] VARCHAR(15) NULL,
                            [Address] NVARCHAR(128) NULL,
                            [Role] VARCHAR(16) NOT NULL
                        );

                        UPDATE TOP (1) [dbo].[User]
                        SET [Username]=@username, [Email]=@email, [Password]=ISNULL(@password, [Password]), [FirstName]=@firstName, [LastName]=@lastName, [Phone]=@phone, [Address]=@address, [Role]=@role
                        OUTPUT Inserted.[Id], Inserted.[Username], Inserted.[Email], [Inserted].[FirstName], [Inserted].[LastName], [Inserted].[Phone], [Inserted].[Address], [Inserted].[Role]
                        INTO @userTableVariable
                        WHERE [Id]=@id;

                        SELECT * FROM @userTableVariable;

                        COMMIT TRANSACTION [UserEntity_EditAsync]
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
            command.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = user.Id;
            command.Parameters.Add("@username", SqlDbType.NVarChar, 16).Value = user.Username;
            command.Parameters.Add("@email", SqlDbType.NVarChar, 320).Value = user.Email;
            command.Parameters.Add("@password", SqlDbType.VarChar, 128).Value =
                (user.Password.IsNullOrEmpty()) ? DBNull.Value : (object) user.Password;
            command.Parameters.Add("@firstName", SqlDbType.NVarChar, 32).Value =
                (user.FirstName.IsNullOrEmpty()) ? DBNull.Value : (object) user.FirstName;
            command.Parameters.Add("@lastName", SqlDbType.NVarChar, 32).Value =
                (user.LastName.IsNullOrEmpty()) ? DBNull.Value : (object) user.LastName;
            command.Parameters.Add("@phone", SqlDbType.VarChar, 15).Value =
                (user.Phone.IsNullOrEmpty()) ? DBNull.Value : (object) user.Phone;
            command.Parameters.Add("@Address", SqlDbType.NVarChar, 128).Value =
                (user.Address.IsNullOrEmpty()) ? DBNull.Value : (object) user.Address;
            command.Parameters.Add("@role", SqlDbType.VarChar, 16).Value = user.Role;

            await command.Connection.OpenAsync();
            var reader = await command.ExecuteReaderAsync();
            if (!reader.Read()) return null;

            var editedUser = new UserEntity()
            {
                Id = reader.GetGuid(0),
                Username = reader.GetString(1),
                Email = reader.GetString(2),
                FirstName = reader.GetStringSafe(3),
                LastName = reader.GetStringSafe(4),
                Phone = reader.GetStringSafe(5),
                Address = reader.GetStringSafe(6),
                Role = reader.GetString(7).ToRole()
            };

            return editedUser;
        }

        internal static async Task<UserEntity> DeleteAsync(Guid id)
        {
            //await Task.Delay(3000);
            await using var connection = Database.CreateConnection();

            const string cmdText = @"
                DECLARE @userTableVariable TABLE (
                    [Id] UNIQUEIDENTIFIER NOT NULL,
                    [Username] NVARCHAR(16) NOT NULL,
                    [Email] NVARCHAR(320) NOT NULL,
                    [FirstName] NVARCHAR(32) NULL,
                    [LastName] NVARCHAR(32) NULL,
                    [Phone] VARCHAR(15) NULL,
                    [Address] NVARCHAR(128) NULL,
                    [Role] VARCHAR(16) NOT NULL
                );

                DELETE TOP (1)
                FROM [dbo].[User]
                OUTPUT Deleted.[Id], Deleted.[Username], Deleted.[Email], [Deleted].[FirstName], [Deleted].[LastName], [Deleted].[Phone], [Deleted].[Address], [Deleted].[Role]
                WHERE [Id]=@id;";

            var command = new SqlCommand(cmdText, connection);
            command.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = id;

            await command.Connection.OpenAsync();
            var reader = await command.ExecuteReaderAsync();
            if (!reader.Read()) return null;

            var deletedUser = new UserEntity()
            {
                Id = reader.GetGuid(0),
                Username = reader.GetString(1),
                Email = reader.GetString(2),
                FirstName = reader.GetStringSafe(3),
                LastName = reader.GetStringSafe(4),
                Phone = reader.GetStringSafe(5),
                Address = reader.GetStringSafe(6),
                Role = reader.GetString(7).ToRole()
            };

            return deletedUser;
        }

        /// <summary>
        /// Search books that Id, BookName or Author columns contains parameter 'text'
        /// </summary>
        /// <param name="text"></param>
        /// <param name="orderAsc"></param>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        internal static async Task<List<UserEntity>> SearchAsync(string text, bool orderAsc, int page, int limit)
        {
            //await Task.Delay(3000);
            await using var connection = Database.CreateConnection();

            var cmdText = @$"
                SELECT [Id], [Username], [Email], [FirstName], [LastName], [Phone], [Address], [Role]
                FROM [dbo].[User]
                WHERE [Id] LIKE @text
                    OR [Email] LIKE @text
                    OR [FirstName] LIKE @text
                    OR [LastName] LIKE @text
                    OR [Phone] LIKE @text
                ORDER BY [Username] {(orderAsc ? "ASC" : "DESC")}
                OFFSET (@page-1)*@limit ROWS FETCH NEXT @limit ROWS ONLY;";

            var command = new SqlCommand(cmdText, connection);
            command.Parameters.Add("@text", SqlDbType.NVarChar, 36).Value = $"%{text}%";
            command.Parameters.Add("@limit", SqlDbType.Int).Value = limit;
            command.Parameters.Add("@page", SqlDbType.Int).Value = page;

            await command.Connection.OpenAsync();
            var reader = await command.ExecuteReaderAsync();

            var users = new List<UserEntity>();
            while (reader.Read())
            {
                var user = new UserEntity()
                {
                    Id = reader.GetGuid(0),
                    Username = reader.GetString(1),
                    Email = reader.GetString(2),
                    FirstName = reader.GetStringSafe(3),
                    LastName = reader.GetStringSafe(4),
                    Phone = reader.GetStringSafe(5),
                    Address = reader.GetStringSafe(6),
                    Role = reader.GetString(7).ToRole()
                };

                users.Add(user);
            }

            return users;
        }

        internal static UserEntity Find(Dictionary<string, string> where, bool includePassword = false)
        {
            //Task.Delay(3000).Wait();
            using var connection = Database.CreateConnection();

            var cmdText = $@"
                SELECT TOP 1 [Id], [Username], [Email], {(includePassword ? "[Password]," : string.Empty)} [FirstName], [LastName], [Phone], [Address], [Role]
                FROM [dbo].[User]
                WHERE ";

            var i = 0;
            cmdText = where.Aggregate(cmdText, (current, column) =>
            {
                if (i > 0) current += " AND ";
                i++;

                var (key, _) = column;
                return current + $"[{key}]=@{key.ToLower()}";
            });

            var command = new SqlCommand(cmdText, connection);
            foreach (var (key, value) in where) command.Parameters.AddWithValue($"@{key.ToLower()}", value);

            command.Connection.Open();
            var reader = command.ExecuteReader();
            if (!reader.Read()) return null;

            var user = new UserEntity()
            {
                Id = reader.GetGuid(0),
                Username = reader.GetString(1),
                Email = reader.GetString(2),
                Password = includePassword ? reader.GetStringSafe(3) : string.Empty,
                FirstName = reader.GetStringSafe(includePassword ? 4 : 3),
                LastName = reader.GetStringSafe(includePassword ? 5 : 4),
                Phone = reader.GetStringSafe(includePassword ? 6 : 5),
                Address = reader.GetStringSafe(includePassword ? 7 : 6),
                Role = reader.GetString(includePassword ? 8 : 7).ToRole()
            };

            return user;
        }

        internal static async Task<UserEntity> FindAsync(Dictionary<string, string> where, bool includePassword = false)
        {
            //await Task.Delay(3000);
            await using var connection = Database.CreateConnection();

            var cmdText = $@"
                SELECT TOP 1 [Id], [Username], [Email], {(includePassword ? "[Password]," : string.Empty)} [FirstName], [LastName], [Phone], [Address], [Role]
                FROM [dbo].[User]
                WHERE ";

            var i = 0;
            cmdText = where.Aggregate(cmdText, (current, column) =>
            {
                if (i > 0) current += " AND ";
                i++;

                var (key, _) = column;
                return current + $"[{key}]=@{key.ToLower()}";
            });

            var command = new SqlCommand(cmdText, connection);
            foreach (var (key, value) in where) command.Parameters.AddWithValue($"@{key.ToLower()}", value);

            await command.Connection.OpenAsync();
            var reader = await command.ExecuteReaderAsync();
            if (!reader.Read()) return null;

            var user = new UserEntity()
            {
                Id = reader.GetGuid(0),
                Username = reader.GetString(1),
                Email = reader.GetString(2),
                Password = includePassword ? reader.GetStringSafe(3) : string.Empty,
                FirstName = reader.GetStringSafe(includePassword ? 4 : 3),
                LastName = reader.GetStringSafe(includePassword ? 5 : 4),
                Phone = reader.GetStringSafe(includePassword ? 6 : 5),
                Address = reader.GetStringSafe(includePassword ? 7 : 6),
                Role = reader.GetString(includePassword ? 8 : 7).ToRole()
            };

            return user;
        }

        //internal static List<UserEntity> FindMany(Dictionary<string, string> where)
        //{
        //}
    }
}