
using FinalProjectC;
using HangMan;

namespace BookApp
{


    class Program
    {
        static void Main()
        {
            BookManager manager = new BookManager();
            manager.Run();


            HangmanGame game = new HangmanGame();
            game.Play();

        }
    }
}

