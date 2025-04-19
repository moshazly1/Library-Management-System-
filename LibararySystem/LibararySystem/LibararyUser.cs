using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibararySystem
{
  public  class LibararyUser : User
    {
        public LibararyCard Card { get; set; }
    

        public LibararyUser(string name)
        {
            this.Name = name;
        }


        public void BorrowBook ( Book borrowdBook ,Libarary libarary)
        {
            //addLogic

            libarary.BorrowBook(borrowdBook);
        }
    }
}
