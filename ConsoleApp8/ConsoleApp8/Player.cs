using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Player
    {
        string name;
        int turnScore,totalScore;
        int turns;
        int pageNumber;
        Random random;
        static int target; 
        static bool flag;
        public Player(string playerName) {
            random= new Random();
            turnScore = 0;
            totalScore = 0;
            turns = 1;
            pageNumber = 1;
            Name = playerName; 
            flag = false;       
        }
        public string Name { 
        set { name = value; }
            get { return name; }    
        }
        public int Turns { 
            get { return turns; }
        }

        public int TotalScore { 
            get {  return totalScore; } 
        }
        public static void ComparePerformance(Player playerOne,Player playerTwo)
        {
            if (playerOne.TotalScore > playerTwo.TotalScore)
            {
                Console.WriteLine("Player one won!");
            }
            else if (playerOne.TotalScore < playerTwo.TotalScore)
            {
                Console.WriteLine("Player two won!");
            }
            else if (playerOne.Turns < playerTwo.Turns)
            {
                Console.WriteLine("Player one won!");
            }
            else if (playerOne.Turns > playerTwo.Turns) { Console.WriteLine("Player two won!"); }
            else { Console.WriteLine("It's a tie!"); }
        }
        public void PlayCricket() {
            Console.WriteLine(name);
            
            while (pageNumber % 10 != 0) {
                Console.WriteLine("Turn " + turns + ":");
                pageNumber = random.Next(0, 300);
                if (pageNumber % 10 != 0 )
                {
                    Console.WriteLine("You flipped to: " + pageNumber);
                    turnScore = pageNumber % 7;
                    totalScore = totalScore + turnScore;
                    Console.WriteLine("Turn Score: " + turnScore);
                    Console.WriteLine("Total Score: " + totalScore);
                    if (flag == true && target < totalScore)
                        break;

                    turns++;
                }
                else {
                    Console.WriteLine("Oops! you flipped 0");
                    Console.WriteLine("Your palyed total " + turns + " turns and scored " + totalScore + "runs.");
                    target = totalScore;
                }
                
            }
            flag = true;
            Console.WriteLine();
            
            

        }

    }
}
