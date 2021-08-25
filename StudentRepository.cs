using System;
using System.Collections.Generic;
using System.Text;

namespace OOPClass1
{
    public class StudentRepository
    {
        public List<Student> Students = new List<Student>(); // or public List<Student> Students = new ();

        public void AddStudent(string firstName, string lastName, string phoneNumber, string matricNumber, int age, string address)
        {
            var studentExist = FindStudent(matricNumber);
            if (studentExist != null)
            {
                Console.WriteLine($"{matricNumber} already exist");
            }

            else
            {
                var student = new Student(firstName, lastName, phoneNumber, matricNumber, age, address);
                Students.Add(student);
            }
           
            
            
            
            //Console.WriteLine($" First Name: {student.GetFirstName()} Last Name: {student.GetLastName()} Matric Number: {student.GetMatricNumber()} Phone Number: {student.GetPhoneNumber()} Age: {student.GetAge()} Address: {student.GetAddress()}");

        }

        public void GetStudents()
        {
            foreach (var student in Students)
            {
                Console.WriteLine($" First Name: {student.GetFirstName()} Last Name: {student.GetLastName()} Matric Number: {student.GetMatricNumber()} Phone Number: {student.GetPhoneNumber()} Age: {student.GetAge()} Address: {student.GetAddress()}");
            }

        }

        public Student FindStudent(string matricNumber)
        {
            var student = Students.Find(s => s.GetMatricNumber() == matricNumber);
            return student;
        }

        public void ShowStudent(string matricNumber)
        {
            var student = FindStudent(matricNumber);
            if (student != null)
            {
                Console.WriteLine($" First Name: {student.GetFirstName()} Last Name: {student.GetLastName()} Matric Number: {student.GetMatricNumber()} Phone Number: {student.GetPhoneNumber()} Age: {student.GetAge()} Address: {student.GetAddress()}");
            }

            else
            {
                Console.WriteLine($"{matricNumber} not found");
            }
            
        }

        public void DeleteStudent (string matricNumber)
        {
            var student = FindStudent(matricNumber);
            Students.Remove(student);
        }

        public void EditStudent(string matricMunber, string address, int age, string phoneNumber)
        {
            var student = FindStudent(matricMunber);
            student.SetAddress(address);
            student.SetAge(age);
            student.SetPhoneNumber(phoneNumber);
            //Console.WriteLine($" First Name: {student.GetFirstName()} Last Name: {student.GetLastName()} Matric Number: {student.GetMatricNumber()} Phone Number: {student.GetPhoneNumber()} Age: {student.GetAge()} Address: {student.GetAddress()}");
        }
    }


}
