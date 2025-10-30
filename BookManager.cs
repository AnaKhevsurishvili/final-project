namespace HangMan
{
    internal class BookManager
    {
        class Book
        {
            public string Title;
            public string Author;
            public int Year;
        }

        private List<Book> books = new List<Book>();

        public void Run()
        {
            while (true)
            {
                ShowMenu();
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddBook();
                        break;
                    case "2":
                        ShowBooks();
                        break;
                    case "3":
                        Exit();
                        return;
                    default:
                        InvalidChoice();
                        break;
                }
            }
        }

        // show menu
        private void ShowMenu()
        {
            Console.WriteLine("\n1. Add Book  2. Show All  3. Exit");
            Console.Write("Choose: ");
        }

        // add book
        private void AddBook()
        {
            Book b = new Book();
            Console.Write("Title: "); b.Title = Console.ReadLine();
            Console.Write("Author: "); b.Author = Console.ReadLine();

            Console.Write("Year: ");
            if (!int.TryParse(Console.ReadLine(), out int year))
                year = 0;
            b.Year = year;

            books.Add(b);
            Console.WriteLine("Book added!");
        }

        // show books
        private void ShowBooks()
        {
            if (books.Count == 0)
                Console.WriteLine("No books added yet.");
            else
            {
                Console.WriteLine("\nBook List:");
                foreach (var b in books)
                    Console.WriteLine($"{b.Title} - {b.Author} ({b.Year})");
            }
        }

        // exit
        private void Exit()
        {
            Console.WriteLine("Goodbye!");
        }

        // wrong choise
        private void InvalidChoice()
        {
            Console.WriteLine("Invalid choice! Try again.");
        }
    }
}
