using System;

namespace Bookshelf.Database.Entities
{
    internal class UserEntity
    {
        public Guid Id { get; init; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public Role Role { get; set; } = Role.None;
        public DateTime CreatedAt { get; init; }
        public DateTime UpdatedAt { get; init; }
    }

    internal enum Role
    {
        None,
        Admin,
        Staff,
        User,
        Visitor
    }
}
