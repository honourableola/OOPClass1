using System;
using System.Collections.Generic;
using System.Text;

namespace OOPClass1
{
    public class ManagerRepository
    {
        public List<Manager> Managers = new List<Manager>();

        public void CreateManager(string name, int age, int yearsOfExperirnce, string clubName, string nationality)
        {
            var managerExist = GetManagerByName(name);
            if (managerExist != null)
            {
                Console.WriteLine($"{name} already exist");
            }
            else
            {
                var manager = new Manager(name, age, yearsOfExperirnce, clubName, nationality);
                Managers.Add(manager);
            }
            
        }

        public void GetAllManagers()
        {
            foreach (var manager in Managers)
            {
                Console.WriteLine($"Name: {manager.GetName()} Age: {manager.GetAge()} Years of Experirence: {manager.GetYearsOfExperience()} Club: {manager.GetClubName()} Country: {manager.GetNationality()}");
            }
        }

        public Manager GetManagerByName(string name)
        {
            var manager = Managers.Find(m => m.GetName() == name);
            return manager;
        }

        // This method displays the manager searched for

        public void ShowManager(string name)
        {

            var manager = GetManagerByName(name);
            if (manager != null)
            {
                Console.WriteLine($"Name: {manager.GetName()} Age: {manager.GetAge()} Years of Experirence: {manager.GetYearsOfExperience()} Club: {manager.GetClubName()} Country: {manager.GetNationality()}");
            }
            Console.WriteLine($"{name} not found");

        }

        public void DeleteManager(string name)
        {
            var manager = GetManagerByName(name);
            Managers.Remove(manager);
        }

        public void DeleteAllManagers()
        {
            //var managers = Managers.FindAll();
            //Managers.RemoveAll(managers);
            /*foreach (var manager in Managers)
            {
                Managers.Remove(manager);
            }*/
        }

        public void EditManager(string name, int age, int yearsOfExperience, string clubName)
        {
            var manager = GetManagerByName(name);
            if (manager != null)
            {
                manager.SetAge(age);
                manager.setYearsOfExperience(yearsOfExperience);
                manager.SetClubName(clubName);
            }
            Console.WriteLine("No record found");
        }

    }
}
