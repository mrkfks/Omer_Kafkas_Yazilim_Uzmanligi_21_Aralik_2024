namespace library.Models
{
    public struct Book
    {
        public int Books_ID { get; set; }
        public string Writers_ID { get; set; }
        public string Title { get; set; }
        public string Publication_Year { get; set; }
        public string ISBN { get; set; } 

        public Book(int books_id, string writers_id, string title, string publication_year, string ISBN)
        {
            Books_ID = books_id;
            Writers_ID = writers_id;
            Title = title;
            Publication_Year = publication_year;
            this.ISBN = ISBN; 
        }
    }
}