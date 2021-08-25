using System;
using System.Collections.Generic;
using System.Text;

namespace OOPClass1
{
    public class Manager
    {
        private string Name;
        private int Age;     
        private int YearsOfExperience;
        private string ClubName;
        private string Nationality;
        
        public Manager(string name, int age, int yearsOfExperience, string clubName, string nationality)
        {
            Name = name;
            Age = age;
            YearsOfExperience = yearsOfExperience;
            ClubName = clubName;
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

        public int GetYearsOfExperience()
        {
            return YearsOfExperience;
        }

        public void setYearsOfExperience(int yearsOfExoerience)
        {
            YearsOfExperience = yearsOfExoerience;
        }

        public string GetClubName()
        {
            return ClubName;
        }

        public void SetClubName(string clubName)
        {
            ClubName = clubName;
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
