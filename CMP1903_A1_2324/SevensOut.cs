using System;

namespace CMP1903_A1_2324
{
    public class SevensOut
    {
        /// <summary>
        /// this class creates two instance of a die and rolls them, the game continues until a sum of seven is gotten by either player, before a sum of seven is gotten, the other values  
        /// and sends  the game results to the statistics class which can be viewed from there
        /// </summary>
        /// <param name="stats"></param>
        
        internal int SevensOutClass(Statistics stats)
        {    
            
            Die die1 = new Die(); // two died created manually
            Die die2 = new Die();
            
            int total = 0; //this stores the incremented total all through the match
            int triesUntilSeven = 0; //stores the amount of tries it took until a total of seven is gotten

            bool reply = true;
            

            while (reply) //the game is built within a while loop to keep it going
            {
                int turn = 0;
                bool samzy = true;
                while (samzy)
                {
                    if (turn == 0)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Roll die Player 1");
                        string san = Console.ReadLine();

                        if (san == "1" || san == "YES".ToLower())
                        {
                            int roll = die1.Roll(); //rolls the die
                            int roll2 = die2.Roll();

                            int rollValue = roll + roll2;

                            if (rollValue != 7)
                            {
                                total += rollValue;
                                triesUntilSeven++;
                                Console.WriteLine($"Roll1; {roll}, Roll2; {roll2}, Total {total}");
                                turn += 1; //switches player if a sum of seven is not gotten and toggles between 0 and 1
                            }
                            else
                            {
                                triesUntilSeven++; //increments the tries until seven
                                Console.WriteLine($"player {turn + 1} rolled a total of seven");
                                Console.WriteLine($"Roll1; {roll} Roll2; {roll2} SumOfRolls; {rollValue}, Total {total}");
                                Console.WriteLine("");
                                Console.WriteLine($"Tries until seven {triesUntilSeven}");
                                samzy = false;
                                reply = false;
                            }
                    
                        }
                        else if (san == "2" || san == "NO".ToLower())
                        {
                            Console.WriteLine("OK");
                            samzy = false;
                            reply = false;
                        }
                        else
                        {
                            Console.WriteLine("invalid entry, (enter 1 or YES) or (2 or NO)");
                        }
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Roll Die Player 2");
                        string san = Console.ReadLine();

                        if (san == "1" || san == "YES".ToLower())
                        {
                            int roll = die1.Roll();
                            int roll2 = die2.Roll();

                            int rollValue = roll + roll2;

                            if (rollValue != 7)
                            {
                                total += rollValue;
                                triesUntilSeven++;  //increments the tries until seven
                                Console.WriteLine($"Roll1; {roll}, Roll2; {roll2}, Total {total}");
                                turn %= 1;
                            }
                            else 
                            {
                                triesUntilSeven++;
                                Console.WriteLine($"player {turn + 1} rolled a total of seven");
                                Console.WriteLine($"Roll1; {roll} Roll2; {roll2} SumOfRolls; {rollValue}, Total {total}");
                                Console.WriteLine("");
                                Console.WriteLine($"Tries until seven {triesUntilSeven}");
                                samzy = false;
                                reply = false;
                            }
                    
                        }
                        else if (san == "2" || san == "NO".ToLower())
                        {
                            Console.WriteLine("OK");
                            samzy = false;
                            reply = false;
                        }
                        else
                        {
                            Console.WriteLine("invalid entry, (enter 1 or YES) or (2 or NO)");
                        }
                    }
                    
                }
               
                
            }
            Console.WriteLine("");
            stats.TriesUntilSeven(triesUntilSeven);
            stats.HighScore(triesUntilSeven, total);
            return total;
        }
    }
}