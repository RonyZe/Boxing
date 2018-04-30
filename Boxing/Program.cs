using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();
            list.Add(1);
            list.Add("Gh");
            list.Add(DateTime.Today);

//            var num = (int) list[1];

            var num1=new List<int>();

            num1.Add(12);
            var str=new List<string>();
            str.Add("£$$$");

            foreach (var awen in str)
            {
                Console.WriteLine(awen);
            }
            Console.ReadLine();

        }
    }
}
