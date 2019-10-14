using System;
using System.Collections.Generic;
using System.Text;

namespace Party_Cost
{
    public  class Receipt
    {
        public  string Key { get; set; }
        public int Value { get; set; }

        public Receipt(string key,int value)
        {
            this.Key = key;
            Value = value;
        }

    }
}
