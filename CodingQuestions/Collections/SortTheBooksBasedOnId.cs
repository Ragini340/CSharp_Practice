namespace CSharp_Practice.CodingQuestions.Collections
{
    /*
     Describe the coding exercise where you pull two records (name, bookID, author, id) from a database, add them to a hashmap, then to
     a list, and sort them based on ID.
     */
    public class SortTheBooksBasedOnId
    {
        public static void Main(string[] args)
        {
            var book1 = new Book(2, "C# Programming", "Kudvenkat", 100);
            var book2 = new Book(1, "SQL", "John Smith", 101);

            var bookMap = new Dictionary<int, Book>
            {
              { book1.ID, book1 },
              { book2.ID, book2 }
            };

            var bookList = bookMap.Values.ToList();
            var sortedBooks = bookList.OrderBy(b => b.ID).ToList();

            Console.WriteLine("Sorted books by ID:");
            foreach (var book in sortedBooks)
            {
                Console.WriteLine(book);
            }
        }

    }
}