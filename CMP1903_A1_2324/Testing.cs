using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        /*
         * This class should test the Game and the Die class.
         * Create a Game object, call the methods and compare their output to expected output.
         */
        /// <summary>
        /// creates an instance of the sevens out and three or more class game, and uses debug.assert to test the game and the stats class as an argument
        /// </summary>
        public void GameTest() //GameTest method
        {
            Game game = new Game();
            Statistics stats = new Statistics(); //instance of the statistics class
            SevensOut sevensOut = new SevensOut(); //instance of the sevensout
            ThreeOrMore threeOrMore = new ThreeOrMore(); //instance of the three or more

            //placed the class in a while loop to handle input errors
            bool test = true;
            while (test)
            {
                Console.WriteLine("1. test three or more");
                Console.WriteLine("2. test sevens out");
                Console.WriteLine("3. Test Game");
                string comp = Console.ReadLine();
                switch (comp) //used switch instead of ifs and else ifs
                {
                    case "1" :
                        Debug.Assert(threeOrMore.ThreeOrMoreGame(stats) >=20, "THREE OR MORE CLASS test passed"); // tests the three or more
                        break;
                    case "2":
                        Debug.Assert(sevensOut.SevensOutClass(stats) > 7 || sevensOut.SevensOutClass(stats) < 7, "sevens out class test  failed"); //tests the sevens out class
                        break;
                    case "3":
                        Debug.Assert(game.PLay() == game.PLay(), "game test failed"); //checks the game
                        break;
                    default:
                        Console.WriteLine("invalid entry pick between 1 or 2");
                        continue;
                }

                test = false;

            }
            //CREATES A GAME OBJECT 


            //within 3 - 18

            /* Create a Die object and call its method.
             * Use debug.assert() to make the comparisons and tests.*/


            //Method


            Die die = new Die();
            int outcome = die.Roll(); //creates a die to be tested

            Debug.Assert(outcome >= 1 && outcome <= 6, "Die test failed");// compares the output of the DieTEst
        } 
            
            
            
        

        
    }
}
