using System;

namespace Bookshelf.Database.Entities
{
    internal class BookIssueEntity
    {
        public Guid Id { get; init; }
        public Guid UserId { get; set; }
        public UserEntity User { get; init; }
        public Guid BookId { get; set; }
        public BookEntity Book { get; init; }
        public Guid IssuerId { get; set; }
        public UserEntity Issuer { get; set; }
        public Guid ReceiverId { get; set; }
        public UserEntity Receiver { get; set; }
        public DateTime IssuedAt { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime ReturnedAt { get; set; }
        public bool Returned { get; set; }
        public DateTime CreatedAt { get; init; }
        public DateTime UpdatedAt { get; init; }
    }
}
