namespace CSharp_Practice.CodingQuestions.Collections
{
    public class Book
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int BookID { get; set; }

        public Book(int id, string name, string author, int bookID)
        {
            ID = id;
            Name = name;
            Author = author;
            BookID = bookID;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Author: {Author}, BookID: {BookID}";
        }
    }
}