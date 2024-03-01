using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        /*
         * This class should test the Game and the Die class.
         * Create a Game object, call the methods and compare their output to expected output.
         * Create a Die object and call its method.
         * Use debug.assert() to make the comparisons and tests.
         */

        //Method
        public static void DieTest()//TestDie method
        {
            Die die = new Die();
            int outcome = die.Roll(); //creates a die to be tested

            Debug.Assert(outcome < 1 || outcome >= 7, "Die test failed");// compares the output of the DieTEst
            
            
            
        }

        public static void GameTest()//GameTest method
        { //CREATES TWO GAMES AND COMPARES THEIR METHODS
            Game game = new Game();
            Console.WriteLine("Test 1");
            string test1 = game.PLay(); //Game 1
            Console.WriteLine(" ");
            Console.WriteLine("Test 2");
            string test2 = game.PLay();//Game 2

            Debug.Assert(test1 == test2, "Game test Failed");
        }
    }
}
