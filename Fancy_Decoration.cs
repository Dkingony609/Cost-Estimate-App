using System;
using System.Collections.Generic;
using System.Text;

namespace Party_Cost
{
    public class Fancy_Decoration
    {
        public int fancyCost { get; set; }
        public int fancydecorationFee { get; set; }
       
        public Fancy_Decoration(int FancyCost, int FancyDecoFee)
        {
            fancyCost = FancyCost;
            fancydecorationFee = FancyDecoFee;
        }
        
    }
}
