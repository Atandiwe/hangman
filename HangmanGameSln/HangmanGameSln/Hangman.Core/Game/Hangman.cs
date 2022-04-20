using System;
using HangmanRenderer.Renderer;

namespace Hangman.Core.Game
{
    public class HangmanGame
    {
        private GallowsRenderer _renderer;
        private int [] _stickmanBody = new int[6];


        public HangmanGame()
        {
            _renderer = new GallowsRenderer();
           
        }
        private bool StickMan(int body)
        {
            if (body == 0)
            {
                _renderer.Render(5, 5, 6);
            }
            else if (body == 1)
            {
                _renderer.Render(5, 5, 5);
            }
            else if (body == 2)
            {
                _renderer.Render(5, 5, 4);
            }
            else if (body == 3)
            {
                _renderer.Render(5, 5, 3);
            }
            else if (body==4)
            {
                _renderer.Render(5, 5, 2);

            }
            else if(body==5)
            {
                _renderer.Render(5, 5, 1);
            }
            else if(body == 6)
            {
                _renderer.Render(5, 5, 0);
            }
        }  


        public void Run()
        {
            _renderer.Render(5, 5, 6);

            string[] wordList = new string[20] { "dogma", "xenophobia", "malevolence","nepotism","cupidity","bombastic","nostalgia","pandemic","flourish","utopia",
              "dystopia","energy","aura","solar","constellation","infinity","galaxy","mutants","dragon","equivalence"};
            Random randomWords = new Random();
            var letter = randomWords.Next(0, 19);
            string guessWord = wordList[letter];
            char[] attempt = new char[guessWord.Length];
            for (int i = 0; i < guessWord.Length; i++)
            {
                attempt[i] = '_';
            }
            while (true)
            {

                Console.SetCursorPosition(0, 13);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Your current guess: ");
                Console.WriteLine(attempt);

                Console.SetCursorPosition(0, 15);

                Console.ForegroundColor = ConsoleColor.Green;

                Console.Write("What is your next guess: ");
                var nextGuess = char.Parse( Console.ReadLine());

                for(int a=0; a<guessWord.Length; a++)
                {
                    if (nextGuess == guessWord[a])
                    {
                        attempt[a] = nextGuess;
                    }
                }
            }
            
        }

    }
}
