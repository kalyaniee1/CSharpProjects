using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    
    internal class Program
    {
        Player playerOne,playerTwo;
       
        public Program() {
            
        }
        
        
        static void Main(string[] args)
        {
            Player playerOne = new Player("Player 1");
            playerOne.PlayCricket();
            Player playerTwo = new Player("Player 2");
            playerTwo.PlayCricket();
            Player.ComparePerformance(playerOne,playerTwo);
        }
    }
}
