namespace PublicationApi.Models
{
    public class PublicationAuthor
    {
        public Guid Id { get; set; }
        public int PublicationId { get; set; }
        public Publication Publication { get; set; }

        public Guid AuthorId { get; set; }
        public Author Author { get; set; }

        public int AuthorOrder { get; set; } // e.g. 1 = first author
    }


}
