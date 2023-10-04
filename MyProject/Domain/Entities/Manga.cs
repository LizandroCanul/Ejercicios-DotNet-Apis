using System;

namespace Myproject.Domain.Entities
{
    public class Manga
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PublicationDate { get; set; }
    }
}
