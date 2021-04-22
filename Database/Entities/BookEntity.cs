using System;

namespace Bookshelf.Database.Entities
{
    internal class BookEntity
    {
        public Guid Id { get; init; }
        public string BookName { get; set; }
        public string Pages { get; set; }
        public string PublishedAt { get; set; }
        public string Edition { get; set; }
        public string Author { get; set; }
        public Genre Genre { get; set; } = Genre.Other;
        public bool Borrowed { get; set; }
        public DateTime CreatedAt { get; init; }
        public DateTime UpdatedAt { get; init; }
    }

    internal enum Genre
    {
        Other,
        Literature,
        Education,
        Politics,
        Philosophy,
        Psychology,
        History,
        Hobby
    }
}
