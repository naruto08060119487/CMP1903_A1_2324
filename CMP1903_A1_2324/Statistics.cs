using System;
using System.IO;
using System.Runtime.InteropServices;

namespace CMP1903_A1_2324
{
    /// <summary>
    /// class for handling and displaying game statistics
    /// </summary>
    public class Statistics
    {
        /// <summary>
        /// this display's the statistics of a game played, and saves the statistics to a file so can be viewed later also handles the concept of asking if a user wants to check scores after a match has been played
        /// </summary>
        /// <param name="player1ThreeOfaKind"></param>
        /// <param name="player1FourOfaKind"></param>
        /// <param name="player1FiveOfaKind"></param>
        /// <param name="player2ThreeOfaKind"></param>
        /// <param name="player2FourOfaKind"></param>
        /// <param name="player2FiveOfaKind"></param>
        public void RecordGame(int player1ThreeOfaKind, int player1FourOfaKind, int player1FiveOfaKind, int player2ThreeOfaKind, int player2FourOfaKind, int player2FiveOfaKind)
        {
           
            bool verify = true;
            while (verify)
            {
                Console.WriteLine("Check Scores");
                Console.WriteLine("1. ThreeOrMore");
                Console.WriteLine("2. none");
                string answer = Console.ReadLine();
                if (answer == "1" || answer== "ThreeOrMore".ToLower() )
                {
                    Console.WriteLine("Player 1");//displays the game statistics
                    Console.WriteLine($"Three Of A Kind {player1ThreeOfaKind}");
                    Console.WriteLine($"Four Of A Kind {player1FourOfaKind}");
                    Console.WriteLine($"Five Of A Kind {player1FiveOfaKind}");

                    Console.WriteLine("");
                    Console.WriteLine($"Player 2");
                    Console.WriteLine($"Three Of A Kind {player2ThreeOfaKind}");
                    Console.WriteLine($"Four Of A Kind {player2FourOfaKind}");
                    Console.WriteLine($"Five Of A Kind {player2FiveOfaKind}");

                   
                    
                    string fileName = "highscore.txt";
                    string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
                    string filePath = Path.Combine(projectDirectory, fileName);
                    Console.WriteLine(filePath);
                    if (File.Exists(filePath)) //this verifies if the file exists before attempting to write to it
                    {
                        using (StreamWriter write = new StreamWriter(filePath, true)) //storing the match results in a .txt file
                        {
                            write.WriteLine("=================================");
                            write.WriteLine($"Player 1");
                            write.WriteLine($"Three Of A Kind {player1ThreeOfaKind}");
                            write.WriteLine($"Four Of A Kind {player1FourOfaKind}");
                            write.WriteLine($"Five Of A Kind {player1FiveOfaKind}");
                            write.WriteLine("");
                            write.WriteLine($"Player 2");
                            write.WriteLine($"Three Of A Kind {player2ThreeOfaKind}");
                            write.WriteLine($"Four Of A Kind {player2FourOfaKind}");
                            write.WriteLine($"Five Of A Kind {player2FiveOfaKind}");
                            write.WriteLine("=====================================");

                        }
                        
                    }

                    else //prints an error message to show file does not exist
                    {
                        Console.WriteLine("no file to store game");
                    }
                    
                    

                    verify = false;
                    
                }
                else if (answer == "2")
                {
                    string fileName = "highscore.txt";
                    
                    string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
                    
                    string filePath = Path.Combine(projectDirectory, fileName);
                    
                    Console.WriteLine(filePath);
                    
                    if (File.Exists(filePath)) //this verifies if the file exists before attempting to write to it
                    {
                        using (StreamWriter write = new StreamWriter(filePath, true)) //storing the match results in a .txt file
                        {
                            write.WriteLine("=====================================");
                            write.WriteLine($"Player 1");
                            write.WriteLine($"Three Of A Kind {player1ThreeOfaKind}");
                            write.WriteLine($"Four Of A Kind {player1FourOfaKind}");
                            write.WriteLine($"Five Of A Kind {player1FiveOfaKind}");
                            write.WriteLine("");
                            write.WriteLine($"Player 2");
                            write.WriteLine($"Three Of A Kind {player2ThreeOfaKind}");
                            write.WriteLine($"Four Of A Kind {player2FourOfaKind}");
                            write.WriteLine($"Five Of A Kind {player2FiveOfaKind}");
                            write.WriteLine("=====================================");

                        }
                    }
                    else //prints an error message to show file does not exist
                    {
                        Console.WriteLine("no file to store game");
                    }
                    Console.WriteLine("thanks for playing");
                    
                    verify = false;
                }
                else
                {
                    Console.WriteLine("Invalid entry please pick between 1 or 2");
                }
            }
        }

        /// <summary>
        /// displays the tries attempted until a sum of seven was gotten from the sevensout class
        /// </summary>
        /// <param name="triesUntilSeven"></param>
       public void TriesUntilSeven(int triesUntilSeven)
        {
            bool sammy = true;
            while (sammy)
            {
                Console.WriteLine("Check Tries Until 7?");
                Console.WriteLine("yes");
                Console.WriteLine("no");
                string sam = Console.ReadLine();
                if (sam == "yes".ToUpper() || sam == "1".ToLower())
                {
                    Console.WriteLine($"Tries Until 7 : {triesUntilSeven}");
                    sammy = false;
                }
                else if (sam == "no" || sam=="2")
                {
                    Console.WriteLine("exiting");
                    sammy = false;
                }
                else
                {
                    Console.WriteLine("invalid");
                }
            }
        }
       /// <summary>
       /// writes the tries taken until a sum of seven and the total points gotten was gotten in a txt file scoreBoard and HighestTotalGotten
       /// </summary>
       /// <param name="triesUntilSeven"></param>
       /// <param name="total"></param>
        public void HighScore(int triesUntilSeven, int total)
        {
            string fileName = "scoreBoard.txt";
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            string filePath = Path.Combine(projectDirectory, fileName);
            Console.WriteLine(filePath);
            if (File.Exists(filePath))//this verifies if the file exists before attempting to write to it
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine($"number of Tries until Seven {triesUntilSeven}");
                }
            }
            else //prints an error message to show file does not exist
            {
                Console.WriteLine("no file to store game stats");
            }
            
            

            string fileForTotalNumbers = "HighestTotalGotten.txt";
            string projectLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            string fileLocation = Path.Combine(projectLocation, fileName);
            Console.WriteLine(fileLocation);
            if (File.Exists(fileLocation))//this verifies if the file exists before attempting to write to it
            {
                using (StreamWriter write = new StreamWriter(fileLocation, true))
                {
                    write.WriteLine($"Highest Total Accumulated {total}");
                }
            }
            else //prints an error message to show file does not exist
            {
                Console.WriteLine("no file to store game statistics");
            }
           
        }
        
        /// <summary>
        /// this reads and prints out the tries until seven was gotten
        /// </summary>
        public void ReadTriesUntilSeven()
        {
            string fileName = "scoreBoard.txt";
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;  // Get the parent directory of the current directory, which should be the project directory.
            
            string filePath = Path.Combine(projectDirectory, fileName); // Combine the project directory path with the file name to get the full file path.
            if (File.Exists(filePath))//this verifies if the file exists before attempting to write to it
            {
                using (StreamReader readTotal = new StreamReader(filePath))
                {
                    string reading = readTotal.ReadToEnd();
                    Console.WriteLine(reading);
                }
            }
            else //prints an error message to show file does not exist
            {
                Console.WriteLine("game statistics not available");
            }
            
            
        }

        /// <summary>
        /// this reads and prints out the totals from the txt file
        /// </summary>
        public void ReadHighScore()
        {
            string fileName = "HighestTotalGotten.txt";
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;  // Get the parent directory of the current directory, which should be the project directory.
            
            string filePath = Path.Combine(projectDirectory, fileName);// Combine the project directory path with the file name to get the full file path.

            if (File.Exists(filePath))//this verifies if the file exists before attempting to write to it
            {
                using (StreamReader readTotal = new StreamReader(filePath))
                {
                    string read = readTotal.ReadToEnd();
                    Console.WriteLine(read);
                }
            }
            else //prints an error message to show file does not exist
            {
                Console.WriteLine("game statistics not available");
            }
            
        }
        

        /// <summary>
        /// this reads out the information written from the three or more class three or more 
        /// </summary>
        public void ReadScoreLogThreeOrMore()//this verifies if the file exists before attempting to write to it
        {
            Console.WriteLine("loading previous game statistics");
            string fileName = "highscore.txt";
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;  // Get the parent directory of the current directory, which should be the project directory.
            
            string filePath = Path.Combine(projectDirectory, fileName);// Combine the project directory path with the file name to get the full file path.

            if (File.Exists(filePath))
            {
                using (StreamReader read = new StreamReader(filePath))
                {
                    string line = read.ReadToEnd();
                    Console.WriteLine(line);
                }
            }
            else //prints an error message to show file does not exist
            {
                Console.WriteLine("game statistics not available");
            }
            
        }
        
    }
}