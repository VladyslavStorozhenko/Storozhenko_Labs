using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.XPath;

namespace BasicKnowledgeHomeworks
{
    public class BasicKnowledgeHomeworks
    {

        static public List<object> GetIntegerFromList(List<object> list)
        {
            List<object> result = new List<object>();
            foreach (object element in list)
            {
                if (element.GetType() == typeof(int))
                {
                    result.Add(element);
                }
            }
            return result;
        }

        static public char first_non_repeating_letter(string input)
        {
            foreach (char ch in input)
            {
                int freq = input.ToLower().Count(f => (f == Char.ToLower(ch)));
                if (freq == 1)
                {
                    return ch;
                }
            }

            return ' ';
        }

        static public int DigitSum(int num)
        {
            int sum = 0;
            while (num >= 1)
            {
                sum += num % 10;
                num = num / 10;
            }

            if (sum > 9)
            {
                sum = DigitSum(sum);
            }

            return sum;
        }

        static public int CountPairs(int[] array, int target)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] + array[j] == target)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        static public string SortFriends(string friends)
        {
            string res = "";
            if (friends == "")
            {
                return res;
            }
            string[] friends_list = friends.ToUpper().Split(";");
            friends_list = friends_list.OrderBy(f => f.Split(":")[1]).ThenBy(f => f.Split(":")[0]).ToArray();
            foreach (string pair in friends_list)
            {
                string[] separate_name = pair.Split(":");
                res += "(" + separate_name[1] + ", " + separate_name[0] + ")";
            }
            return res;
        }
    }
}