using System;
using System.Collections.Generic;
using System.Text;

namespace OOPClass1
{
    public class Player
    {
        private string Name;
        private int Age;
        private int JerseyNumber;
        private string ClubName;
        private string Position;
        private string Nationality;

        public Player(string name, int age, int jerseyNumber, string clubName, string position, string nationality)
        {
            Name = name;
            Age = age;
            JerseyNumber = jerseyNumber;
            ClubName = clubName;
            Position = position;
            Nationality = nationality;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public int GetAge()
        {
            return Age;
        }

        public void SetAge(int age)
        {
            Age = age;
        }

        public int GetJerseyNumber()
        {
            return JerseyNumber;
        }

        public void SetJerseyNumber(int jerseyNumber)
        {
            JerseyNumber = jerseyNumber;
        }

        public string GetClubName()
        {
            return ClubName;
        }

        public void SetClubName(string clubName)
        {
            ClubName = clubName;
                
        }

        public string GetPosition()
        {
            return Position;
        }

        public void SetPosition(string position)
        {
            Position = position;

        }

        public string GetNationality()
        {
            return Nationality;
        }

        public void SetNationality(string nationality)
        {
            Nationality = nationality;
        }

    }
}
