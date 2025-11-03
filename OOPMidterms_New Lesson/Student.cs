using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace OOPMidterms_New_Lesson
{
    internal class Student
    {
        private int _ID = 0;
        private string[] _Name = new string[2];
        private int _Age = 0;
        private char _Gender = (char)32; 
        private Random _rnd = new Random();

        public Student() 
        {
            Console.WriteLine("Blank constructir Initialized");
        }

        public Student(string FName, string LName, int age, char gender) 
        {
            _ID = _rnd.Next(1000000);
            _Name[0] = LName;
            _Name[1] = FName;
            _Age = age;
            _Gender = gender;

            Console.WriteLine($"Profile for student {LName} created ID is {_ID}");
        }

        public Student(int ID, string FName, string LName, int age, char gender)
        {
            _ID = ID;
            _Name[0] = LName;
            _Name[1] = FName;
            _Age = age;
            _Gender = gender;

            Console.WriteLine($"Profile for student {LName} recreated. ID is {_ID}");
        }

        public string GetFullName() 
        {
            return _Name[0] + ", " + _Name[1];
        }

        public string GetGender() 
        {
            switch (_Gender) 
            {
                case 'M':
                case 'm':
                    return "Male";
                case 'F':
                case 'f':
                    return "Female";
                case 'O':
                case 'o':
                    return "Others";
                case 'U':
                case 'u':
                    return "Undisclosed";
                default:
                    return "Unknown";
            }
        }

        public string GetID() 
        {
            string temp = _ID + "";

            while (temp.Length < 6)
                temp = "0" + temp; 

            return temp;
        }

        public int GetAge() 
        {
            return _Age; 
        }

    }
}
