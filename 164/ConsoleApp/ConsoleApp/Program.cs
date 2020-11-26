using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program program = new Program();
            int[] nums = new int[] {  };
            int a = program.MaximumGap(nums);
            Console.WriteLine(a);
            Console.ReadLine();
        }
        public int MaximumGap(int[] nums)
        {
            List<int> numLists= nums.ToList().OrderBy(t=>t).ToList();
            int Max = 0;
            for(int i = 0; i < numLists.Count; i++)
            {
                if (i + 1 < numLists.Count && (numLists[i + 1] - numLists[i])>Max)
                {
                    Max = numLists[i + 1] - numLists[i];
                }
            }
            return Max;
        }
    }
}
