using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>();

            /*
            Player player1 = new Player("Alisson");
            Player player2 = new Player("Van Dijk")
            Player player3 = new Player("Konate");

            players.Add(player1);
            players.Add(player2);
            Players.Add(player3);
            */

            players.Add(new Player("Salah"));
            players.Add(new Player("Isak"));
            players.Add(new Player("Ekitike"));
            players.Add(new Player("Gakpo"));
            players.Add(new Player("Wirtz"));
            players.Add(new Player("Szoboszlai"));
            players.Add(new Player("Gravenberch"));
            players.Add(new Player("Kerkez"));
            players.Add(new Player("Frimpong"))

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