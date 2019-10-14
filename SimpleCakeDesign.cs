using System;
using System.Collections.Generic;
using System.Text;

namespace Party_Cost
{
    public class SimpleCakeDesign
    {
        public int cakeDesignPrice { get; set; }
        public int totalDesignPrice { get; set; }
       
        public SimpleCakeDesign(int CakeDesignPrice)
        {
            cakeDesignPrice = CakeDesignPrice;
        }

        public void GetSimpleData()
        {
            Console.WriteLine();


            Console.WriteLine("Please input What You want written on the cake ");
            Console.WriteLine("Please know that each letter costs $ 25 ");


            string letters = Console.ReadLine();
            Console.WriteLine("===============================");
            string trimletter = letters.Replace(" ", "");
            int letterLength = trimletter.Length;

            if (trimletter.Length <= 16)
            {
                Console.WriteLine("Cake Writing Length of " + letterLength + " letters");

                Console.WriteLine("===============================");

                int totalDesignPrice = trimletter.Length*cakeDesignPrice;
                

                Console.WriteLine("Price for this size of letters = " + "$" + totalDesignPrice);

                //SimpleDecoration();
            }
            else
            {
                Console.WriteLine("PLEASE TRY THE FANCY DECORATION!!");
            }
           
        }

        //public void SimpleDecoration()
        //{

        //    Console.WriteLine(totalDesignPrice);

        //    Console.WriteLine("=====================================");

        //    Console.WriteLine();

        //    Console.WriteLine("The Total Price Of Your Option = " + "$");
        //}

    }
}
