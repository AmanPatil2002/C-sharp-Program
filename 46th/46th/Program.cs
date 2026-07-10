
using System;

namespace _46th
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<Player> players = new List<Player>();

            Player player1 = new Player("Aman");
            Player player2 = new Player("Nida");
            Player player3 = new Player("Musa");

            players.Add(player1);
            players.Add(player2);
            players.Add(player3);

            foreach (Player player in players)
            {
                Console.WriteLine(player);
            }
            
            Console.ReadKey();
        }
    }
    class Player
    {
        public String username;

        public Player(String username)
        {
            this.username = username;
        }
        public override string ToString()
        {
            return username;
        }
    }
}