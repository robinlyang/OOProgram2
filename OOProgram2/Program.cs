using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOProgram2
{//locations for classes
    //1. above other classes
    class Time
    {
        public int hour, minute, second;
    }
    class Worker
    {
        public string name;
        public double salary;
    }
    class Program
    {
        //2. inside other classes (worst option)
        class TimeTwo
        {
            public int hour, minute, second;
        }
        static void Main(string[] args)
        {
            Time t = new Time();
            TimeTwo t2 = new TimeTwo();
            TimeThree t3 = new TimeThree();
            TimeFour.TimeFour t4 = new TimeFour.TimeFour();
        }
    }
    //3. put in own file in solution (better option)
    //4. put in a DLL (best option)
}
