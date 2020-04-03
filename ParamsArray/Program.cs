using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsArray
{
    class Program
    {
        static void doWork()
        {
            Console.WriteLine(Util.Sum(2, 4, 6));

            //int[] _paramArray = new int[5] { 2, 4, 6, 8, 10 };

            //Console.WriteLine($"Sum is : {Util.Sum(_paramArray).ToString()}");
            int m = 0;
            string _answer = "Y";
            string _sentence;
            while (_answer == "Y")
            {
                _sentence = Console.ReadLine();
                Console.WriteLine(_sentence.ToLower());
                Console.WriteLine("Do you need any more help at this time since I am testing a branch so lets see what happens now also at 2:50 pm");
                _answer = Console.ReadLine(); 


            }
               
            



        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
    }
}
