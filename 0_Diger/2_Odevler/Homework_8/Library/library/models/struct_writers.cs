namespace Library.Models
{
    public struct Writer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Writer(string name, string surname)
        {
            Id = 0; 
            Name = name;
            Surname = surname;
        }
    }
}