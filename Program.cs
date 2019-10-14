using System;
using System.Collections.Generic;

namespace Party_Cost
{
    public class Program
    {
        
        public void TabControl()
        {
            Console.WriteLine("Please Select An Option : " + "\n" + "1. A Simple Decoration" + "\n" + "2. A Fancy Decoration");

            int number = Convert.ToInt32(Console.ReadLine());

            if (number == 1)
            {
                Simple_Decoration SimpleCost = new Simple_Decoration(7.50, 30);
                
                Console.WriteLine("==================================");

                Console.WriteLine("EVENT COST ESTIMATE APPLICATION");

                Console.WriteLine("==================================");

                Console.WriteLine();

                Console.WriteLine("SIMPLE DECORATION OPTION");

                Console.WriteLine();

                Console.WriteLine("==================================");

                Console.WriteLine("The Head Cost Per Person = " + "$" + SimpleCost.headCost);

                Console.WriteLine("===========================================");

                Console.WriteLine("One Time Decoration Fee Per Person = " + "$" + SimpleCost.decorationFee);

                Console.WriteLine("===========================================");

                Attendees attendance = new Attendees(8, 40, 16, 75);

                attendance.SimpleTurnUp();

                SimpleCakeDesign decoration = new SimpleCakeDesign(25);
                decoration.GetSimpleData();
                //decoration.SimpleDecoration();
            }
            else if (number == 2)
            {
                Fancy_Decoration FancyCost = new Fancy_Decoration(15, 50);

                Console.WriteLine("==================================");

                Console.WriteLine("BIRTHDAY COST ESTIMATE APPLICATION");

                Console.WriteLine("==================================");

                Console.WriteLine();

                Console.WriteLine("FANCY DECORATION OPTION");

                Console.WriteLine();

                Console.WriteLine("==================================");

                Console.WriteLine("The Head Cost Per Person = " + "$" + FancyCost.fancyCost);

                Console.WriteLine("===========================================");

                Console.WriteLine("One Time Decoration Fee Per Person = " + "$" + FancyCost.fancydecorationFee);

                Console.WriteLine("==========================================");

                Attendees attendance = new Attendees(8, 40, 16, 75);

                attendance.FancyTurnUp();

                Console.WriteLine("===============================");

                Console.WriteLine();

                FancyCakeDesign fdecoration = new FancyCakeDesign(25);
                fdecoration.GetFancyData();
               // fdecoration.FancyDecoration();
            }
            else if(number < 1 || number > 2)
            {
                Console.WriteLine("Incorrect Input Format!!");
            }
        }

        static void Main(string[] args)
        {
            Program controlpanel = new Program();
            controlpanel.TabControl();


        }
    }
}
