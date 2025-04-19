using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibararySystem
{
   public abstract class User
   {
        public string  Name { get; set; }

        public  void DisplayBooks(Libarary libarary)
        {
            libarary.Display();
        }
        

    }
}
