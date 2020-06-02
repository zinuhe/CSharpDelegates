using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDelegate
{
    class Program
    {
        public delegate Boolean IsNineDelegate(int value);

        public Boolean IsNiner(int i)
        {
            return i == 9;
        }

        public void ShowMe()
        {
            IsNineDelegate myDelegate = IsNiner;
            Boolean result = PerformCalculation(myDelegate, 3, 6);
            Console.WriteLine(result);
        }

        public Boolean PerformCalculation(IsNineDelegate isNine, int value1, int value2)
        {
            int result = value1 + value2;
            return isNine(result);
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            program.ShowMe();
        }        
    }
}
