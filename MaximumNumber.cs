using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumProblemUsingGenerics
{
    public class MaximumNumber
    {
        public static void MaximumString()
        {
            string text;
            string[] stringList;
            int ni = 0, len, max = 0;


            Console.Write("Enter a string :");
            text = Console.ReadLine();
            stringList = text.Split(' ');
            len = stringList.Length;

            for (int i = 0; i < len; i++)
            {
                if (stringList[i].Length > max)
                {
                    max = stringList[i].Length;
                    ni = i;
                }
            }

            Console.WriteLine("Longest string:{0} \nCount of longest string:{1}", stringList[ni], max);
            Console.ReadLine();
        }
    }
}
