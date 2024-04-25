using System;
using System.Collections.Generic;
using System.Diagnostics;
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
         */
        public void GameTest() //GameTest method
        {
            Statistics stats = new Statistics();
            //CREATES A GAME OBJECT 
            ThreeOrMore threeOrMore = new ThreeOrMore();
            int s = threeOrMore.ThreeOrMoreGame(stats);
            Console.WriteLine("");
            Console.WriteLine("testing three or more class");
            Console.WriteLine("");
            Debug.Assert(s == 20 || s >= 20, "Three or More test passed");

            int comp = threeOrMore.ThreeOrMoreGameComputer(stats);
            Console.WriteLine("");
            Console.WriteLine("testing three or more class");
            Console.WriteLine("");
            Debug.Assert(comp == 20 || comp >= 20, "Three or More test passed");

            /* Create a Die object and call its method.
             * Use debug.assert() to make the comparisons and tests.*/


            //Method


            Die die = new Die();
            int outcome = die.Roll(); //creates a die to be tested

            Debug.Assert(outcome >= 1 && outcome <= 6, "Die test failed");// compares the output of the DieTEst
        }

        public void TestSevenout()
        {
            Statistics stats = new Statistics();
            SevensOut sevensOut = new SevensOut();
            int seven = sevensOut.SevensOutClass(stats);
            Console.WriteLine("");
            Console.WriteLine("testing sevens out class");
            Console.WriteLine("");
            Debug.Assert(seven == 7, "sevens out class passed");
            Game game = new Game();
        }

        
            
            
            
        

        
    }
}
