using ExerciseSolution.Media;

namespace ExerciseSolution
{
    public class Library
    {
        private Book[] books;
        private int bookCount;

        
        public Library()
        {
            bookCount = 0;
            books = new Book[500];
        }

        
        public Book[] Search(string searchQuery)
        {
            // Only search if the search query hast more than 2 characters.
            if(searchQuery.Length < 3)
                return new Book[0];

            // Create a temporary books array to save all found books. We need a counter to do that.
            Book[] tempBooks = new Book[500];
            int tempBooksCounter = 0;
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] == null)
                    continue;
                if (books[i].Search(searchQuery))
                    tempBooks[tempBooksCounter++] = books[i];
            }
            // Create a new array that is only as big as the number of results. Copy all results in it.
            Book[] outputBooks = new Book[tempBooksCounter];
            for(int i = 0; i < tempBooksCounter; i++)
                outputBooks[i] = tempBooks[i];

            return outputBooks;
        }
        
        public void AddNewBook(Book book)
        {
            books[bookCount] = book;
            bookCount++;
        }
    }
}
