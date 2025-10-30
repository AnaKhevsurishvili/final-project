namespace HangMan
{
    internal class Book
    {
        public string Title;
        public string Author;
        public int Year;

        public Book(string title, string author, int year)
        {
            Title = title; 
            Author = author;
            Year = year;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, Year: {Year}");
        }


    }
}
