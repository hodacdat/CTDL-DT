using System;
using System.Collections.Generic;
using System.IO;
public class Solution
{
    ////using XOR operator to find number that appear 1 time
    //public static int SingleNumber(int[] nums)
    //{
    //    var singleNumber = 0;
    //    foreach (var num in nums)
    //    {
    //        singleNumber ^= num;
    //    }
    //    return singleNumber;
    //}

    public static List<string> AutoComplete(string s, List<string> l1)
    {
        List<string> list = new List<string>();
        int n = s.Length;
        bool flag;
        foreach (string s2 in l1)
        {
             flag = true;
            for (int i = 0; i < n; i++)
            {
                if (s2[i] != s[i])
                {
                    flag = false;
                    break;
                } 
            }
                if (flag)
            {
                list.Add(s2);
            }
        }


        return list;
    }

    static void Main(string[] args)
    {
        //Console.WriteLine(
        //SingleNumber(new[] { 1, 2, 2, 3, 3, 4, 5 })
        //    );

        //string a = "abc";
        //Console.WriteLine(a[1]);

        //automative complete word
        List<string> l = new List<string>();
        l = AutoComplete("de", new List<string> { "dog", "deer", "dean" });
        foreach (var item in l)
        {
            Console.Write(item + " ");
        }
    }
}