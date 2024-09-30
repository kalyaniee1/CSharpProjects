using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    
    internal class NumberGuesser
    {
        int guess, attempt;
        string choice;
        bool keepPlaying;
        int inputString;
        int randomNumber; Random random = new Random();
        public NumberGuesser()
        {
            guess = 0;
            attempt = 0;
            keepPlaying = true;
            inputString = 1;
            
            randomNumber = random.Next(1, 11);

        }
        public void TakeInput() {
            Console.WriteLine("Guess the number:");
            guess = Convert.ToInt16(Console.ReadLine());
        }

        public bool PlayAgain() { 
        
        }
        public void PlayGame()
        {
            
                while (keepPlaying)
                {
                    TakeInput();
                    if (guess == randomNumber)
                    {
                        Console.WriteLine("Huraayy..you guesed it right!!");
                        Console.WriteLine("You guessed it right in " + attempt + " attempts.");
                        
                        break;
                    //keepPlaying = false;
                    }
                    else if (guess < randomNumber)
                    {
                        Console.WriteLine("too small");
                        attempt++;
                        //TakeInput();
                    }
                    else if (guess > randomNumber)
                    {
                        Console.WriteLine("too large");
                        attempt++;
                        //TakeInput();
                    }
                    if (attempt == 5)
                    {
                        Console.WriteLine("You ran out of attempts. Do you want to start a new game?"+"\n 0.No \n 1.Yes");
                        keepPlaying = Convert.ToBoolean(Console.ReadLine());
                    if (keepPlaying)
                        attempt = 0;
                    }
                }
               
            }
        
    }
}
