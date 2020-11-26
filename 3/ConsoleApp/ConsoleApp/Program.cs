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
            int a = program.LengthOfLongestSubstring(" ");
            Console.WriteLine(a);
            Console.ReadLine();
        }

        public int LengthOfLongestSubstring(string s)
        {
            Dictionary<int, int> tempDict = new Dictionary<int, int>();
            char[] sArray=s.ToCharArray();
            if (sArray.Length == 0)
            {
                return 0;
            }
            for(int i = 0; i < sArray.Length; i++)
            {
                int length=GetCount(sArray, i);
                tempDict.Add(i, length);
            }
          

            return tempDict.Values.Max();
        }
        public int GetCount(char[] sArray,int num)
        {
            List<char> temp = new List<char>();
            for(int i = num; i < sArray.Length; i++)
            {
                if (!temp.Contains(sArray[i]))
                {
                    temp.Add(sArray[i]);
                }
                else
                {
                    return temp.Count;
                }
            }
            return temp.Count;
        }
    }
}
