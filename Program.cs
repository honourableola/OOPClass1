using System;

namespace OOPClass1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*StudentRepository studentRepository = new StudentRepository();
            studentRepository.AddStudent("Yunus", "Olalekan", "07062539241", "QTS/2009/034", 20, "2, Ayeloja street, Oke-Gada Ede");
            studentRepository.AddStudent("Babatunde", "Aleem", "07062539241", "QTS/2009/033", 20, "2, Ayeloja street, Oke-Gada Ede");
            studentRepository.AddStudent("Yunus", "Olalekan", "07062539241", "QTS/2009/034", 20, "2, Ayeloja street, Oke-Gada Ede");

            //studentRepository.GetStudents();
            //studentRepository.ShowStudent("QTS/2009/034");
            //studentRepository.DeleteStudent("QTS/2009/034");
            //studentRepository.EditStudent("QTS/2009/033", "17, Ewenla street, Oko Oba", 34, "08134527843");
            studentRepository.GetStudents();*/

            /*PlayerRepository newplayer = new PlayerRepository();
            newplayer.CreatePlayer("Bukayo Saka", 19, 27, "Arsenal", "Left Wing", "England");
            newplayer.CreatePlayer("Thomas Partey", 25, 8, "Arsenal", "Midfield", "Ghana");
            newplayer.CreatePlayer("Alexander Lacazette", 28, 9, "Arsenal", "Striker", "France");
            //newplayer.ShowPlayerSearched(27);
            //newplayer.DeletePlayer(27);
            newplayer.EditPlayer(27, 78, "chelsea", "Goal Keeper");
            newplayer.GetAllPlayers();*/

            ManagerRepository newManager = new ManagerRepository();
            newManager.CreateManager("Mikel Arteta", 39, 6, "Arsenal", "Spain");
            newManager.CreateManager("Thomas Tuchel", 47, 12, "Chelsea", "Germany");
            newManager.CreateManager("Ole Gunnar SOlksjaer", 48, 15, "Manchester United", "Norway");
            //newManager.DeleteAllManagers();
            newManager.EditManager("Mikel Arteta", 23, 78, "Madrid");
            newManager.GetAllManagers();

            Console.ReadKey();
        }
    }
}
