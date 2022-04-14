using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3_elave.Models
{
    class User
    {
        private string _name;
        private string _surName;
        private int _age;
        public string Name {

            get => _name;
            set
            {
                while (value.Length<3)
                {
                    Console.WriteLine("Name minimum 3 length den ibaret olmalidir");
                    value = Console.ReadLine();
                }
                
                    value = _name;
                
            }
        }

        public string SurName {

            get => _surName;
            set
            {
                while (value.Length < 3)
                {
                    Console.WriteLine("SUrname minimum 3 length den ibaret olmalidir");
                    value = Console.ReadLine();
                }
               
                    value = _surName;
                
            }
        }
        public int Age { get; set; }
        public User(string name, string surname , int age)
        {
            Name = name;
            SurName = surname;
            Age = age;
        }
    }
}
