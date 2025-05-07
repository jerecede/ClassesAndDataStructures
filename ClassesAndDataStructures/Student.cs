using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndDataStructures
{
    //public, internal, protected, private
    internal class Student
    {
        ////in js non sono proprieta ma fills, poi set e getter
        //private string _name;
        //private string _surname;
        //private string _gender;
        //private int _yob;

        ////OVERLOADING
        ////in js una funzione è solo il nome della funzione(non si può ripetere),
        ////in cs una funziona è il nome della funzione + input
        //public Student(string name, string surname, int yob)
        //{
        //    _name = name;
        //    _surname = surname;
        //    _gender = "neutral";
        //    _yob = yob;
        //}
        //
        //public Student(string name, string surname, string gender, int yob)
        //{
        //    _name = name;
        //    _surname = surname;
        //    _gender = gender;
        //    _yob = yob;
        //}

        //in cs no fills, ma properties
        public string Name { get; set; } //posso decidere se togliere il set
        public string Surname { get; set; }
        public string Gender { get; set; }

        private int _yob;

        public int Yob
        {
            get => _yob;
            set
            {
                if (value < 1900)
                {
                    _yob = 1900;
                }
                else
                {
                    _yob = value;
                }
            }
        }

        public Student(string name, string surname, int yob)
        {
            Name = name;
            Surname = surname;
            Gender = "neutral";
            Yob = yob;
        }

        public Student(string name, string surname, string gender, int yob)
        {
            Name = name;
            Surname = surname;
            Gender = gender;
            Yob = yob;
        }
    }
}
