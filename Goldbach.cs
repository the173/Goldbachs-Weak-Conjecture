using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DProgrammer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a series of odd numbers, with spaces in between each index");
            string[] stringinputs = Console.ReadLine().Split(' ');
            int[] intinputs = Array.ConvertAll(stringinputs, s => int.Parse(s));
            for (int i = 0; i < intinputs.Length; i++)
            {
                List<int> primelist = PrimesList(intinputs[i]);
                List<int> sum = SumofThree(intinputs[i], primelist);
                Console.WriteLine("{0} + {1} + {2} = {3}", sum[0], sum[1], sum[2], intinputs[i]);
            }
            Console.ReadLine();
        }
        static List<int> PrimesList(int oddtarget)
        {
            List<int> ListofPrimes = new List<int>();
            ListofPrimes.Add(2);
            for(int i = 3; i < oddtarget; i++)
            {
                for(int j = 2; j <i; j++)
                {
                    if (i%j == 0)
                    {
                        break;
                    }
                    if (j == i-1)
                    {
                        ListofPrimes.Add(i);
                    }
                }
            }
            return ListofPrimes;
        }
        static List<int> SumofThree(int target, List<int> inputlist)
        {
            List<int> sum = new List<int>();

            for(int i = 0; i <= inputlist.Count; i++)
            {
                for(int j = 0 ; j< inputlist.Count; j++)
                {
                    for (int k = 0; k < inputlist.Count; k++)
                    {
                        if (inputlist[i] + inputlist[j] + inputlist[k] == target)
                        {
                            sum.Add(inputlist[i]);
                            sum.Add(inputlist[j]);
                            sum.Add(inputlist[k]);
                            return sum;
                        }
                    }
                }
            }
            return sum;
        }
    }
}
