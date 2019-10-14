using System;
using System.Collections.Generic;
using System.Text;

namespace Party_Cost
{
    public class Simple_Decoration
    {
        public double headCost { get; set; }
        public int decorationFee { get; set; }
           
        public Simple_Decoration(double Headcost, int Decofee)
        {
            headCost = Headcost;
            decorationFee = Decofee;           
        }

    }
    
}
