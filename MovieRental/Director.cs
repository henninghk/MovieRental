using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRental
{
   public class Director
   {
       public string Name;

       public Director(string name)
       {
           Name = name;
       }

       public string DirName()
       {

           return "\n Direktør: " + Name;
       }
   }
}
