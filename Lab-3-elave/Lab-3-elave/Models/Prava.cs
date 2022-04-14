using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3_elave.Models
{
    class Prava
    {
        public int Result = 0;

        public void ChekUser(User user)
        {

            if (user.Age>=18)
            {
                Console.WriteLine($"{user.Name} {user.SurName} tebrikler");

             }
            else
            {
                Result = 18 - user.Age;
                Console.WriteLine($"get {Result} ilden sonra gel");
            }
        }

       
    }
}
