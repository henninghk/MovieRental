using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRental
{
   public class Actor
   {
       public string Name;
       public int Id;

       public Actor(string name, int id)
       {
           Name = name;
           Id = id;
       }


       public string ActorName()
       {
           
           return "\n Actor: " + Name;
       }
   }
}
