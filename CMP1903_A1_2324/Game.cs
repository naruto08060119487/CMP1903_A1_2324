using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    public class Game
    {
        //Methods
        /// <summary>
        /// the Game class creates an instance of the sevensOut and ThreeOrMore and statistics class, just like the main menu,
        /// allows of selection of what to play and to view results and game logs
        /// and also ending the program at will
        /// the game class has one method and takes no arguments
        /// </summary>
        public int PLay()
        {
            SevensOut sevensOut = new SevensOut();
            ThreeOrMore threeOrMore = new ThreeOrMore();
            Statistics stats = new Statistics();
            
            
            bool sam = true;
            while (sam)
            {
                Console.WriteLine("What Game Do You Wanna Play");
                Console.WriteLine("1. threeOrMore");
                Console.WriteLine("2. sevensOut");
                Console.WriteLine("3. check High score");
                Console.WriteLine("4. Back to main menu");
                string rep = Console.ReadLine();
                
                if (rep == "1")
                {
                    bool modeChoice = true;
                    while (modeChoice)
                    {
                        try
                        {
                            Console.WriteLine("do you want to play against player or computer?");
                            Console.WriteLine("1. Player");
                            Console.WriteLine("2. computer");
                            string reply = Console.ReadLine();
                            if (reply == "1")
                            {
                                Console.WriteLine("running threeOrMore");
                                Console.WriteLine("");
                                threeOrMore.ThreeOrMoreGame(stats);
                                
                                modeChoice = false;
                                sam = false;
                            }
                            else if (reply == "2")
                            {
                                threeOrMore.ThreeOrMoreGameComputer(stats);
                            }
                            else
                            {
                                Console.WriteLine("invalid input, pick between 1 & 2");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"theres an error{e.Message}");
                            throw;
                        }
                        
                        
                    }
                }
                
                else if (rep == "2")
                {
                    Console.WriteLine("running sevensOut");
                    Console.WriteLine("");
                    sevensOut.SevensOutClass(stats);
                    sam = false;
                }
                else if (rep == "3")
                {
                    bool answ = true;
                    string resp ="";
                    while (answ)
                    {
                        Console.WriteLine("which game statistics do you want to check");
                        Console.WriteLine("1. THREEORMORE");
                        Console.WriteLine("2. SEVENSOUT");
                        Console.WriteLine("3. Go back");
                        resp = Console.ReadLine();
                        if (resp == "1")
                        {
                            stats.ReadScoreLogThreeOrMore();
                            answ = false;
                        }
                        else if (resp == "2")
                        {
                            bool manny = true;
                            while (manny)
                            {
                                Console.WriteLine("1. Check all the totals");
                                Console.WriteLine("2. check all tries until seven");
                                string samz = Console.ReadLine();
                                if (samz == "1")
                                {
                                    stats.ReadHighScore();
                                    manny = false;
                                }
                                else if (samz == "2")
                                {
                                    stats.ReadTriesUntilSeven();
                                    manny = false;
                                }
                                else
                                {
                                    Console.WriteLine("incorrect pick between 1 or 2");
                                }
                            }
                            
                        }
                        else if (resp == "3")
                        {
                            answ = false;
                        }
                        
                    }

                }
                else if (rep == "4")
                {
                    Console.WriteLine("Thanks for playing");
                    break;
                }
                else
                {
                    Console.WriteLine("invalid pick, choose between 1 & 2");
                }
            }

            return 1;
        }

    }

    
}
