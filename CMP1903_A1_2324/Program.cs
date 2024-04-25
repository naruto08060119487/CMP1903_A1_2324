using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Create a Game object and call its methods.
             */
            bool sam = true;
            while (sam)
            {
                Console.WriteLine("1.Play game");
                Console.WriteLine("2.Test Game");
                Console.WriteLine("3.exit");
                string reply = Console.ReadLine();
                switch (reply)
                {
                    case "1":
                        Console.WriteLine("Loading Game");
                        Game dice= new Game();
                        Console.WriteLine("original Game");
                        dice.PLay();//initial games
                        break;
                    
                    case "2":
                        Console.WriteLine("Loading Testing");
                        Console.WriteLine("Which game do you want to test");
                        Console.WriteLine("1.");
                        Testing test = new Testing();
                        //test.TestSevenout();
                        test.GameTest();// testing the game and Die
                        Console.WriteLine(" ");
                        break;
                    case "3":
                        Console.WriteLine("exiting now");
                        sam = false;
                        break;
                    
                    default:
                        Console.WriteLine("invalid response");
                        continue;
                }
            }
           
            
           
            
             /* Create a Testing object to verify the output and operation of the other classes.
             */
           
                
        }
    }
}
