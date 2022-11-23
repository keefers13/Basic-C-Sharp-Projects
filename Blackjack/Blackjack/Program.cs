using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Data;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Gand Hotel and Casino. Lets start by telling me your name.");
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would you like to join a game of Blackjack right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "y" || answer == "ya")
            {
                //creating a player with these two values instantiated
                Player player = new Player(playerName, bank);
                //creating a game
                Game game = new BlackjackGame();
                // adding player to the game using overloaded operators.
                game += player;
                player.isActivelyPlaying = true;
                //making sure the game continues while the player plays and has money
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        //making sure most things happen inside the Play() method
                        game.Play();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("an error occured. Please contact your System Administrator.");
                        UpdateDb(ex);
                        return;
                    }
                    
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino, Bye for now.");
            Console.ReadLine();
        }
        private static void UpdateDb(Exception ex)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BlackjackDataBase
                                      ;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServer
                                       Certificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string queryString = @"INSERT INTO Exceptions (Exception Message, Time Stamp) VALUES
                                    (@Exception Message, @Time Stamp)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@Exeption Message", SqlDbType.VarChar);
                command.Parameters.Add("@Time Stamp", SqlDbType.DateTime);

                command.Parameters["@Exception Message"].Value = ex.Message;
                command.Parameters["@Time Stamp"].Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

            }
        }
    }
}
