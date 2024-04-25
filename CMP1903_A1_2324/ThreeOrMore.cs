using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace CMP1903_A1_2324
{
    public class ThreeOrMore
    {
        /// <summary>
        /// this class creates the three or more game, creates 5 instance of a die in an array and prompts the user to roll the die using 1 or YES, continues the game until a winner is gotten,
        /// sends match statistics to the statistics class and would be displayed from there
        /// the statistics class is instantiated as a parameter so that any changes made in the future would be easily recorded and making the method flexible and reusable
        /// </summary>
        /// <param name="stats"></param>
        internal int ThreeOrMoreGame(Statistics stats) 
        {
            int pointPlayer1 = 0;
            int pointPlayer2 = 0;
            
            //this creates 5 die in an array
            Die[] die1 = new Die[5];
            for (int i = 0; i < die1.Length; i++)
            {
                die1[i] = new Die();
            }
            

            /*Die die2 = new Die();
            Die die3 = new Die();
            Die die4 = new Die();
            Die die5 = new Die();*/
            
            //opens THE three or more game in a while loop
            bool play = true;
            while (play)    
            {
                //here all the variables for holding points are instantiated and would be incremented during the course of the game
                int player1ThreeOfaKind = 0;
                int player1FourOfaKind = 0;
                int player1FiveOfaKind = 0;
                int player2ThreeOfaKind = 0;
                int player2FourOfaKind = 0;
                int player2FiveOfaKind = 0;
                
                
                
                //here the points gained from scoring three,four or five of a kind will be stored
               
                int turn = 0;
                bool stop = true;
                while (stop) //another while loop is used to ensure the game keeps running and to switch between players
                {
                    if (turn == 0) //starts the game at player 1 because (turn) is initialized to zero(0)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("press 1 or type yes to roll the die ");
                        Console.WriteLine("");
                        Console.WriteLine("Roll die player 1");
                        string reply = Console.ReadLine(); //takes input to roll the die

                        if (reply == "1" || reply =="YES".ToLower())
                        {
                            //this rolls 5 die created above
                            int[] roll = new int[5];
                            for (int i = 0; i < die1.Length; i++)
                            {
                                roll[i] = die1[i].Roll();
                            }

                            if (NumberOfAKind(roll, 3))
                            {
                                //increments the threeofakind variable by 1 to know how many times three values were rolled
                                player1ThreeOfaKind++;
                                Console.WriteLine("three of a kind rolled");
                                //this increments the player points by an amount if the requirements are met
                                pointPlayer1 += 3; //increment the player point by three
                            }
                            else if (NumberOfAKind(roll, 4))
                            {
                                //increments the fourofakind variable by 1 to know how many times three values were rolled
                                player1FourOfaKind++;
                                Console.WriteLine("four of a kind rolled");
                                //this increments the player points by an amount if the requirements are met
                                pointPlayer1 += 6; //increment the player point by 6
                            }
                            else if (NumberOfAKind(roll, 5))
                            {
                                //increments the fiveofakind variable by 1 to know how many times three values were rolled
                                player1FiveOfaKind++;
                                Console.WriteLine("five of a kind rolled");
                                //this increments the player points by an amount if the requirements are met
                                pointPlayer1 += 12; //increment the player point by 12

                            }
                            
                            foreach (int values in roll)//this foreach loop prints out the values rolled by a player
                            {
                                Console.WriteLine($"ROlls: {values}");
                            }
                            
                            if (pointPlayer1>=20) //this sets the winning conditions and checks if it's been met
                            {
                                Console.WriteLine($"Player {turn + 1} wins!");
                                Console.WriteLine($"total : {pointPlayer1}");
                                
                                stop = false;
                            }
                            
                        }
                        turn += 1; // this switches between players, so it goes between 0 and 1
                    }
                    
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("press 1 or type yes to roll the die ");
                        Console.WriteLine("");
                        Console.WriteLine("Roll die player 2");
                        string reply = Console.ReadLine();

                        if (reply == "1" || reply =="YES".ToLower())
                        {
                            //this rolls 5 die created above
                            int[] roll = new int[5];
                            for (int i = 0; i < die1.Length; i++)
                            {
                                roll[i] = die1[i].Roll();
                            }

                            if (NumberOfAKind(roll, 3))
                            {
                                //increments the threeofakind variable by 1 to know how many times three values were rolled
                                player2ThreeOfaKind++;
                                Console.WriteLine("three of a kind rolled");
                                //this increments the player points by an amount if the requirements are met
                                
                                pointPlayer2 += 3; //increment the player point by three

                            }
                            else if (NumberOfAKind(roll, 4))
                            {
                                //increments the fourofakind variable by 1 to know how many times three values were rolled
                                player2FourOfaKind++;
                                Console.WriteLine("four of a kind rolled");
                                //this increments the player points by an amount if the requirements are met
                                
                                pointPlayer2 += 6; //increment the player point by 6

                            }
                            else if (NumberOfAKind(roll, 5))
                            {
                                //increments the fiveofakind variable by 1 to know how many times three values were rolled
                                player2FiveOfaKind++;
                                Console.WriteLine("five of a kind rolled");
                                //this increments the player points by an amount if the requirements are met
                                
                                pointPlayer2 += 12; //increment the player point by 12

                            }
                            foreach (int values in roll) //this foreach loop prints out the values rolled by a player
                            {
                                Console.WriteLine($"ROlls: {values}");
                            }
                            if (pointPlayer2>=20) //this sets the winning conditions and checks if it's been met 
                            {
                                Console.WriteLine($"Player {turn + 1} wins!");
                                Console.WriteLine($"total : {pointPlayer2}");
                                break;
                            }
                           
                        }
                        turn %= 1; // returns back to player 1 after a move
                        

                    }
                }

                /*this blocks sends the points scored over to the statistics class which would be displayed there, the ThreeOrMore method already takes the Statistics class as a parameter, having access to its methods,
                 it sends over the game statistics, and can be viewed from there, this uses the record game method to record the game stats*/
                Console.WriteLine("");
                stats.RecordGame(player1ThreeOfaKind, player1FourOfaKind, player1FiveOfaKind,
                    player2ThreeOfaKind, player2FourOfaKind, player2FiveOfaKind);
                Console.WriteLine("");
                
                //here the rematch part, asks they user if they want to play again,
                bool veri = true;
                while (veri)
                {
                    Console.WriteLine("Rematch? (YES) (NO)");
                    string response = Console.ReadLine();
                    if (response=="1" || response =="YES".ToLower())
                    {
                        Console.WriteLine("");
                        Console.WriteLine("restarting game ");
                        Console.WriteLine("");
                        veri = false;
                    }
                    else if (response=="2" || response=="NO".ToLower())
                    {
                        Console.WriteLine("logging out");
                        veri = false;
                        play = false;   

                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                    }
                }

                
            }

            if (pointPlayer1 > pointPlayer2) //here the greater point between both players would be returned
            {
                return pointPlayer1;
            }
            else
            {
                return pointPlayer2;
            }
        }
        
        
        /// <summary>
        /// this uses same logic as the top game, but here, the value for player to is rolled randomly and automatically with the random class
        /// </summary>
        /// <param name="stats"></param>
        internal int ThreeOrMoreGameComputer(Statistics stats)
        {
            int pointPlayer1 = 0;
            int pointPlayer2 = 0;
            
            Die[] die1 = new Die[5];
            for (int i = 0; i < die1.Length; i++)
            {
                die1[i] = new Die();
            }
            
            bool play = true;
            while (play)    
            {
                int player1ThreeOfaKind = 0;
                int player1FourOfaKind = 0;
                int player1FiveOfaKind = 0;
                int player2ThreeOfaKind = 0;
                int player2FourOfaKind = 0;
                int player2FiveOfaKind = 0;
                
                
               
                int turn = 0;
                bool stop = true;
                while (stop)
                {
                    if (turn == 0)
                    {
                        Console.WriteLine("Roll die player 1");
                        string reply = Console.ReadLine();

                        if (reply == "1" || reply =="YES".ToLower())
                        {
                            int[] roll = new int[5];
                            for (int i = 0; i < die1.Length; i++)
                            {
                                roll[i] = die1[i].Roll();
                            }

                            if (NumberOfAKind(roll, 3))
                            {
                                player1ThreeOfaKind++;
                                Console.WriteLine("three of a kind rolled");
                                pointPlayer1 += 3;
                            }
                            else if (NumberOfAKind(roll, 4))
                            {
                                player1FourOfaKind++;
                                Console.WriteLine("four of a kind rolled");
                                pointPlayer1 += 6;
                            }
                            else if (NumberOfAKind(roll, 5))
                            {
                                player1FiveOfaKind++;
                                Console.WriteLine("five of a kind rolled");
                                pointPlayer1 += 12;

                            }
                            
                            foreach (int values in roll)
                            {
                                Console.WriteLine($"Rolls: {values}");
                            }
                            
                            if (pointPlayer1>=20)
                            {
                                Console.WriteLine($"Player {turn + 1} wins!");
                                Console.WriteLine($"total : {pointPlayer1}");
                                stop = false;
                            }
                            
                        }
                        turn += 1;
                    }
                    
                    else
                    {
                        //this makes use of the random.NEXT METHOD FROM THE RANDOM CLASS
                        Random rand = new Random();
                        Console.WriteLine("");
                        Console.WriteLine("computer rolling");
                        Console.WriteLine("");
                        string[] computerReplies = { "1", "YES" };
                        string reply = computerReplies[rand.Next(computerReplies.Length)];

                        if (reply == "1" || reply =="YES")
                        {
                            int[] roll = new int[5];
                            for (int i = 0; i < die1.Length; i++)
                            {
                                roll[i] = die1[i].Roll();
                            }

                            if (NumberOfAKind(roll, 3))
                            {
                                player2ThreeOfaKind++;
                                Console.WriteLine("three of a kind rolled");
                                pointPlayer2 += 3;

                            }
                            else if (NumberOfAKind(roll, 4))
                            {
                                player2FourOfaKind++;
                                Console.WriteLine("four of a kind rolled");
                                pointPlayer2 += 6;

                            }
                            else if (NumberOfAKind(roll, 5))
                            {
                                player2FiveOfaKind++;
                                Console.WriteLine("five of a kind rolled");
                                pointPlayer2 += 12;

                            }
                            foreach (int values in roll)
                            {
                                Console.WriteLine($"Rolls: {values}");
                            }
                            if (pointPlayer2>=20)
                            {
                                Console.WriteLine($"Player {turn + 1} wins!");
                                Console.WriteLine($"total : {pointPlayer1}");
                                break;
                            }
                        }
                        turn %= 1;
                        
                    }
                   
                    
                }

                Console.WriteLine("");
                stats.RecordGame(player1ThreeOfaKind, player1FourOfaKind, player1FiveOfaKind,
                    player2ThreeOfaKind, player2FourOfaKind, player2FiveOfaKind);
                Console.WriteLine("");

                bool veri = true;
                while (veri)
                {
                    Console.WriteLine("Rematch? (YES) (NO)");
                    string response = Console.ReadLine();
                    if (response=="1" || response =="YES".ToLower())
                    {
                        Console.WriteLine("");
                        Console.WriteLine("restarting game ");
                        Console.WriteLine("");
                        veri = false;
                    }
                    else if (response=="2" || response=="NO".ToLower())
                    {
                        Console.WriteLine("logging out");
                        veri = false;
                        play = false;   

                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                    }
                }
                
            }
            if (pointPlayer1 > pointPlayer2) //here the greater point between both players would be returned
            {
                return pointPlayer1;
            }
            else
            {
                return pointPlayer2;
            }

            
        }

        

        /// <summary>
        /// checks if the dice value have three of same value after each roll
        /// </summary>
        /// <param name="roll"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        private bool NumberOfAKind(int[] roll, int n) //this private method takes two argument, an array of integer(roll[]) which are the rolls from the dice, and n the number of values specified to check for
        {
            Dictionary<int, int> count = new Dictionary<int, int>(); // this initializes a dictionary called count, 
            foreach (int value in roll) //this loop iterates over the results of the die roll.
            {
                if (!count.ContainsKey(value))//this checks if the dictionary already contains a current value, and if it's not, it's the first occurence of that value 
                {
                    count[value] = 1;
                }
                else
                {
                    count[value]++; //if it has occured before, it increments the  count of the value in the dictionary by 1
                }
            }

            foreach (int counter in count.Values)//this checks the values stored in the dictionary, if the value equals the argument passed when the function is called, it returns true else it returns false if no value that equal n is found
            {
                if (counter ==n)
                {
                    return true;
                } 
            }

            return false;
        }
        
        
        
    }
    
}