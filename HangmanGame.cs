namespace FinalProjectC
{
    internal class HangmanGame

    {
        public void Play()
        {
            string[] words = { "apple", "banana", "orange", "grape", "peach" };
            Random random = new Random();
            string word = words[random.Next(words.Length)];

            string guess = "";
            int tries = 3;

            Console.WriteLine("Welcome to Hangman!");

            while (tries > 0)
            {
                Console.Write("\nWord: ");
                foreach (char c in word)
                {
                    if (guess.Contains(c))
                        Console.Write(c + " ");
                    else
                        Console.Write("_ ");
                }

                Console.Write("\nGuess a letter: ");
                char letter = Console.ReadLine().ToLower()[0];

                if (word.Contains(letter))
                {
                    guess += letter;
                    Console.WriteLine("Correct!");
                }
                else
                {
                    tries--;
                    Console.WriteLine($"Wrong! Tries left: {tries}");
                }

                bool allFound = true;
                foreach (char c in word)
                    if (!guess.Contains(c))
                        allFound = false;

                if (allFound)
                {
                    Console.WriteLine($"\nYou win! The word was {word}");
                    break;
                }
            }

            if (tries == 0)
                Console.WriteLine($"\nYou lose! The word was {word}");
        }
    }
}