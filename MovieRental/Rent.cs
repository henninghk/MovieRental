using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRental
{
    public class Rent
    {
        public int Price;
        public bool IsAvlible;

        public Rent(int price, bool isAvlible)
        {
            Price = price;
            IsAvlible = isAvlible;
        }

        public string MovieRental()
        {
            string output = null;
            if (IsAvlible == false)
            {
                output = "Filmen er Utleid! kom tilbake om ";
            }
            else
            {
                output = "\n Pris : " + Price;
            }

            return output;
        }
    }
}
