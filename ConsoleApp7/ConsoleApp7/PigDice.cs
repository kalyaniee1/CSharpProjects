using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class PigDice
    {
        char choice;
        Random random=new Random();
        int dice;
        int turnScore=0;
        int totalScore = 0;
        int turn=1;

        public void PlayGame() {

            while(true)
            {
                Console.WriteLine("Turn" + turn + ":");

                while (totalScore < 20)
                    {
                        Console.WriteLine("Enter 'r' or 'h':");
                        choice = Convert.ToChar(Console.ReadLine());
                        if (choice == 'r')
                        {
                            dice = random.Next(1, 6);
                            Console.WriteLine("You rolled:" + dice);

                            if (dice == 1)
                            {
                                turnScore = 0;
                                turn++;                                
                                Console.WriteLine("Turn over! Your score:" + turnScore);
                                Console.WriteLine("Turn" + turn + ":");
                               
                             }
                            else
                            {
                                turnScore = turnScore  + dice;
                                Console.WriteLine("Your turn score:" + turnScore);                             }
                            }

                        else
                        {
                            totalScore = totalScore + turnScore;
                            Console.WriteLine("Your total Score: " + totalScore); 
                            turn++;
                            turnScore = 0;
                            Console.WriteLine("Turn" + turn + ":");
                            
                        }

                }
                break;
            }

            Console.WriteLine("Congratulations you won in " + turn + "turns:");
        }
    }
}
