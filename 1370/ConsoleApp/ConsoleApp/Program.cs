using System;

using System.Collections.Generic;

using System.Linq;
using System.Text;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            string b=program.SortString1("aaaabbbbcccc");
            Console.WriteLine(b);
            Console.ReadLine();
        }
        public String SortString1(String s)
        {
            StringBuilder builder = new StringBuilder();
            int[] map = new int[26];
            foreach (char c in s.ToCharArray()) map[c - 'a']++;
            bool flag;
            do
            {
                flag = false;
                for (int i = 0; i < 26; i++)
                {
                    if (map[i] > 0)
                    {
                        builder.Append((char)(i + 'a'));
                        map[i]--;
                        flag = true;
                    }
                }
                for (int i = 25; i >= 0; i--)
                {
                    if (map[i] > 0)
                    {
                        builder.Append((char)(i + 'a'));
                        map[i]--;
                        flag = true;
                    }
                }
            } while (flag);
            return builder.ToString();
        }
        public string SortString(string s)
        {
            string result = "";
            char[] chars=s.ToCharArray();
            List<int> indexLists = new List<int>();
            var charLists = chars.OrderBy(t=>t).ToList();
            if (charLists.Count == 0)
            {
                return result;
            }
            while (indexLists.Count() != charLists.Count)
            {
                int minIndex = GetMinIndex(charLists, indexLists);
                if (minIndex != -1)
                {
                    indexLists.Add(minIndex);
                    result += charLists[minIndex];
                    int index = GetMinIndex(charLists, indexLists, charLists[minIndex]);
                    while (index != -1)
                    {
                        indexLists.Add(index);
                        result += charLists[index];
                        index = GetMinIndex(charLists, indexLists, charLists[index]);
                    }
                }
                int maxIndex = GetMaxIndex(charLists, indexLists);
                if (maxIndex != -1)
                {
                    indexLists.Add(maxIndex);
                    result += charLists[maxIndex];
                    int index = GetMaxIndex(charLists, indexLists, charLists[maxIndex]);
                    while (index != -1)
                    {
                        indexLists.Add(index);
                        result += charLists[index];
                        index = GetMaxIndex(charLists, indexLists, charLists[index]);
                    }
                }

            }
                return result;
        }
        public int GetMinIndex(List<char> chars, List<int> ints)
        {

            List<char> temp = new List<char>();
            for (int i = 0; i < chars.Count; i++)
            {
                if (!ints.Contains(i))
                {
                    temp.Add(chars[i]);
                }
            }
            for (int i = 0; i < chars.Count; i++)
            {
                if (!ints.Contains(i))
                {
                    if (chars[i] == temp.Min())
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
       
        public int GetMaxIndex(List<char> chars, List<int> ints)
        {

            List<char> temp = new List<char>();
            for (int i = 0; i < chars.Count; i++)
            {
                if (!ints.Contains(i))
                {
                    temp.Add(chars[i]);
                }
            }
            for (int i = chars.Count - 1; i >= 0; i--)
            {
                if (!ints.Contains(i))
                {
                    if (chars[i] == temp.Max())
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
        public int GetMinIndex(List<char> chars,List<int> ints,char First)
        {
            for(int i = 0; i < chars.Count; i++)
            {
                if (!ints.Contains(i))
                {
                    if (chars[i] > First)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        public int GetMaxIndex(List<char> chars, List<int> ints, char First)
        {
            for (int i = chars.Count-1; i >=0; i--)
            {
                if (!ints.Contains(i))
                {
                    if (chars[i] < First)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
    }
}
