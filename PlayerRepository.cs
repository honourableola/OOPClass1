using System;
using System.Collections.Generic;
using System.Text;

namespace OOPClass1
{
    public class PlayerRepository
    {
        public List<Player> Players = new List<Player>();

        public void CreatePlayer(string name, int age, int jerseyNumber, string clubName, string position, string nationality)
        {
            var player = new Player(name, age, jerseyNumber, clubName, position, nationality);
            Players.Add(player);
        }

        public void GetAllPlayers()
        {
            foreach (var player in Players)
            {
                Console.WriteLine($"{player.GetName()} {player.GetAge()} {player.GetJerseyNumber()} {player.GetClubName()} {player.GetPosition()} {player.GetNationality()}");
            }
        }

        public Player GetPlayerByJerseyNumber(int jerseyNumber)
        {
            var player = Players.Find(p => p.GetJerseyNumber() == jerseyNumber);
            return player;
        }

        // A method to just display the player searched for

        public void ShowPlayerSearched(int jerseyNumber)
        {
            var player = GetPlayerByJerseyNumber(jerseyNumber);
            Console.WriteLine($"{player.GetName()} {player.GetAge()} {player.GetJerseyNumber()} {player.GetClubName()} {player.GetPosition()} {player.GetNationality()}");
        }
        public void DeletePlayer(int jerseyNumber)
        {
            var player = GetPlayerByJerseyNumber(jerseyNumber);
            Players.Remove(player);
        }

        public void EditPlayer(int jerseyNumber, int age, string clubName, string position)
        {
            var player = GetPlayerByJerseyNumber(jerseyNumber);
            player.SetAge(age);
            player.SetClubName(clubName);
            player.SetPosition(position);
        }

    }
}
