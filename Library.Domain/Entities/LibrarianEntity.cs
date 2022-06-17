using System;


namespace Library.Domain.Entities
{
    public class LibrarianEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public List<BookEntity> Books { get; set; }
        public List<AuthorEntity> Authors { get; set; }
        public List<ReaderEntity> Readers { get; set; }

    }
}
