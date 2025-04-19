using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibararySystem
{
   public  class Libararian:User
    {
        public int EmployeeNumber { get; set; } 

        public Libararian(string name)
        {
            this.Name = name;   
        }

        public void AddBook(Book NewBook , Libarary libarary )
        {
            //AddLogic
            libarary.Add(NewBook);
          
        }
        public void RemoveBook(Book NewBook, Libarary libarary)
        {
            //AddLogic
            libarary.Remove(NewBook);   

        }
    }
}
