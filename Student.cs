using System;
using System.Collections.Generic;
using System.Text;

namespace OOPClass1
{
    public class Student
    {
        private string FirstName;
        private string LastName;
        private string PhoneNumber;
        private string MatricNumber;
        private int Age;
        private string Address;
        
        public Student (string firstName, string lastName, string phoneNumber, string matricNumber, int age, string address)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumber;
            this.MatricNumber = matricNumber;
            this.Age = age;
            this.Address = address;
        }

        public string GetFirstName()
        {
            return FirstName;
        }

        public void SetFirstName( string firstName)
        {
            FirstName = firstName;
        }

        public string GetLastName()
        {
            return LastName;
        }

        public void SetLastName(string lastName)
        {
           LastName = lastName;
        }

        public string GetPhoneNumber()
        {
            return PhoneNumber;
        }

        public void SetPhoneNumber(string phoneNumber)
        {
            PhoneNumber = phoneNumber;
        }

        public string GetMatricNumber()
        {
            return MatricNumber;
        }

        public void SetMatricNumber(string matricNumber)
        {
            MatricNumber = matricNumber;
        }

        public int GetAge()
        {
            return Age;
        }

        public void SetAge(int age)
        {
            Age = age;
        }

        public string GetAddress()
        {
            return Address;
        }

        public void SetAddress(string address)
        {
            Address = address;
        }


    }
}
