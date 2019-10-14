using System;
using System.Collections.Generic;
using System.Text;

namespace Party_Cost
{
   
    public class Attendees
    {
        public int simpleInch { get; set; }
        public int simplePrice { get; set; }
        public int fancyCakeInch { get; set; }
        public int fancyCakePrice { get; set; }

        public Attendees(int SimpleInch, int SimplePrice, int FancyCakeInch, int FancyCakePrice)
        {
            simpleInch = SimpleInch;
            simplePrice = SimplePrice;
            fancyCakeInch = FancyCakeInch;
            fancyCakePrice = FancyCakePrice;
        }

        public void SimpleTurnUp()
        {
            Console.WriteLine();
            
            Console.WriteLine("Please Input What Cake Size(Inches) You Need?!! " + "\n" + "From (1-8)");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num < 1 || num > 8)
            {
                Console.WriteLine("Please Choose another Size");
            }
            else
            {
                Console.WriteLine();

                Console.WriteLine("Please Input Number Of Attendees : ");

                int number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("==================================");

                if (number <= 4)
                {
                    Console.WriteLine("The Cake Size = " + num + " inches");
                    Console.WriteLine("==================================");
                    Console.WriteLine("Cake Price For This Size = " + "$" + simplePrice);
                    Console.WriteLine("==================================");
                }
                else
                {
                    Console.WriteLine("The Cake Size = " + num + " inches");
                    Console.WriteLine("==================================");
                    Console.WriteLine("Cake Price For This Size = " + "$" + fancyCakePrice);
                    Console.WriteLine("==================================");
                }

                //Console.WriteLine("========================================================");
                //Console.WriteLine(" ! Please Note All Prices Remains Same for Each Category");
                //Console.WriteLine("========================================================");
            }

        }

        public void FancyTurnUp()
        {
            Console.WriteLine();

            Console.WriteLine("Please Input What Cake Size(Inches) You Need?!! " + "\n" + "From (9-16)");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num < 9 || num > 16)
            {
                Console.WriteLine("Choose another Size");
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("Please Input Number Of Attendees : ");

            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("==================================");

            if (number >= 5)
            {
                Console.WriteLine("The Cake Size = " + num + " inches");
                Console.WriteLine("==================================");
                Console.WriteLine("Cake Price For This Size = " + "$" + fancyCakePrice);
                Console.WriteLine("==================================");
            }
            else
            {
                Console.WriteLine("The Cake Size = " + num + " inches");
                Console.WriteLine("==================================");
                Console.WriteLine("Cake Price For This Size = " + "$" + simplePrice);
                Console.WriteLine("==================================");
            }

            //Console.WriteLine("========================================================");
            //Console.WriteLine(" ! Please Note All Prices Remains Same for Each Category");
            //Console.WriteLine("========================================================");

        }

    }
}
