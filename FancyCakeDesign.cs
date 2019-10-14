using System;
using System.Collections.Generic;
using System.Text;

namespace Party_Cost
{
    public class FancyCakeDesign
    {
        public int fancyDesignPrice { get; set; }
        public int totalDesignPrice { get; set; }


        public FancyCakeDesign(int FancyDesignPrice)
        {
            fancyDesignPrice = FancyDesignPrice;
        }

        public void GetFancyData()
        {
            
            Console.WriteLine();

            Console.WriteLine("Please input What You want written on the cake ");
            Console.WriteLine("Please know that each letter costs $ 25 ");

            string letters = Console.ReadLine();
            Console.WriteLine("===============================");
            string trimletter = letters.Replace(" ", "");
            int letterLength = letters.Length;

            if (trimletter.Length >= 17)
            {
                Console.WriteLine("Cake Decoration Length : " + letterLength + " letters");

                Console.WriteLine("=================================");

                int totalDesignPrice = trimletter.Length*fancyDesignPrice;

                Console.WriteLine("Price for this size of letters = " + "$" + totalDesignPrice);
                //FancyDecoration();
            }
            else
            {
                Console.WriteLine("PLEASE TRY THE SIMPLE DECORATION!!");

                Console.WriteLine("===============================");
            }

        }

        //public void FancyDecoration()
        //{

        //    Console.WriteLine("Price for this set of characters = " + "$" + fancyDesignPrice);

        //    Console.WriteLine("=====================================");

        //    Console.WriteLine();

        //}

    }
}
