using Bookshelf.Database.Entities;
using Bookshelf.Properties;
using System.Windows.Forms;

namespace Bookshelf.Utilities
{
    internal static class Store
    {
        private static UserEntity _currentUser = new()
        {
            Username = Resource_Localization.RoleVisitor,
            Role = Role.Visitor
        };

        public static UserEntity CurrentUser
        {
            get => _currentUser;
            set => _currentUser = value ?? new UserEntity
            {
                Username = Resource_Localization.RoleVisitor,
                Role = Role.Visitor
            };
        }

        public static Button CurrentButton { get; set; }
    }
}
