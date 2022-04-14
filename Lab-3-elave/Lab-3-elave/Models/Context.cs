using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3_elave.Models
{
    class Context
    {

        public string[] StrArr { get; set; } = { "Laman", "Rufat", "Matin" };


        public bool Check(string search) {
            foreach (var item in StrArr)
            {
                if (item.ToLower().Contains(search.ToLower()))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
