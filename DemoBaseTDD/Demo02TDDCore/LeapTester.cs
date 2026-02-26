using System;
using System.Collections.Generic;
using System.Text;

namespace Demo02TDD.Core
{
    public class LeapTester
    {
        public bool IsLeap(int year)
        {
            // INITIAL
            //throw new NotImplementedException();


            //Green 1
            if (year % 400 == 0)
                return true;
            return false;
        }
    }
}
