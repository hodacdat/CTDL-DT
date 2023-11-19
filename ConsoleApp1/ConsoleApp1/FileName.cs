using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using System.Text;

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

    //public static List<string> AutoComplete(string s, List<string> l1)
    //{
    //    List<string> list = new List<string>();
    //    int n = s.Length;
    //    bool flag;
    //    foreach (string s2 in l1)
    //    {
    //         flag = true;
    //        for (int i = 0; i < n; i++)
    //        {
    //            if (s2[i] != s[i])
    //            {
    //                flag = false;
    //                break;
    //            } 
    //        }
    //            if (flag)
    //        {
    //            list.Add(s2);
    //        }
    //    }

    //    //c2
    //    foreach (string s2 in l1)
    //    {
    //        if (s2.Length < n)
    //            continue;

    //        if (s2.Substring(0, n) == s)
    //        {
    //            list.Add(s2);
    //        }
    //    }

    //    return list;
    //}

    //add sum of 2 linked list and store reverse number to linkedlist (2. Add Two Numbers leetcode)
    // Definition for singly-linked list.
    //public class ListNode
    //{
    //    public int val;
    //    public ListNode next;
    //    public ListNode(int val = 0, ListNode next = null)
    //    {
    //        this.val = val;
    //        this.next = next;
    //    }
    //}
    //public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    //{
    //    //Stack<int> stack = new Stack<int>();
    //    //ListNode n;
    //    //StringBuilder stringBuilder = new StringBuilder();
    //    //BigInteger sum, converted, converted2;

    //    //do
    //    //{
    //    //    stack.Push(l1.val);
    //    //    l1 = l1.next;
    //    //} while (l1 != null);
    //    //while (stack.Count > 0)
    //    //{
    //    //    stringBuilder.Append(stack.Pop());
    //    //}
    //    //converted = BigInteger.Parse(stringBuilder.ToString());

    //    //stringBuilder.Clear();
    //    //stack.Clear();
    //    //do
    //    //{
    //    //    stack.Push(l2.val);
    //    //    l2 = l2.next;
    //    //} while (l2 != null);

    //    //while (stack.Count > 0)
    //    //{
    //    //    stringBuilder.Append(stack.Pop());
    //    //}
    //    //converted2 = BigInteger.Parse(stringBuilder.ToString());

    //    //sum = converted + converted2;
    //    //stringBuilder.Clear();
    //    //stack.Clear();
    //    //stringBuilder.Append(sum);

    //    //ListNode head3 = null;
    //    //ListNode tail = null;
    //    //for (int i = 0; i < stringBuilder.Length; i++)
    //    //{
    //    //    int num = int.Parse(stringBuilder[i].ToString());
    //    //    stack.Push(num);

    //    //}

    //    //while (stack.Count > 0)
    //    //{
    //    //    n = new ListNode(stack.Pop());
    //    //    if (head3 == null)
    //    //    {
    //    //        head3 = n;
    //    //        tail = n;
    //    //    }
    //    //    else
    //    //    {
    //    //        //Console.WriteLine(tail.val);
    //    //        tail.next = n;
    //    //        tail = n;
    //    //    }
    //    //}

    //    ////while (head3 != null)
    //    ////{
    //    ////    Console.WriteLine(head3.val);
    //    ////    head3 = head3.next;
    //    ////}

    //    //return head3;


    //    //c2

    //    ListNode dummyHead = new ListNode(0);
    //    ListNode current = dummyHead;
    //    int carry = 0;

    //    while (l1 != null || l2 != null || carry != 0)
    //    {
    //        int sum = carry;

    //        if (l1 != null)
    //        {
    //            sum += l1.val;
    //            l1 = l1.next;
    //        }

    //        if (l2 != null)
    //        {
    //            sum += l2.val;
    //            l2 = l2.next;
    //        }

    //        carry = sum / 10;
    //        int digit = sum % 10;

    //        current.next = new ListNode(digit);
    //        current = current.next;
    //    }

    //    return dummyHead.next;
    //}


    /// <summary>
    /// Add sum of all sub string have odd-length
    /// </summary>
    /// <param name="args"></param>
    /// 
    // check array has odd-length
    //public List<List<int>> getAllOddLengthsArr(int[] array)
    //{
    //    List<List<int>> result = new List<List<int>>();

    //    for (int length = 1; length <= array.Length; length += 2)
    //    {
    //        for (int start = 0; start + length <= array.Length; start++)
    //        {
    //            List<int> subArray = new List<int>();
    //            for (int i = start; i < start + length; i++)
    //            {
    //                subArray.Add(array[i]);
    //            }
    //            result.Add(subArray);
    //        }
    //    }
    //    return result;
    //}

    //public int SumOddLengthSubarrays(int[] arr)
    //{
    //    int sum = 0;
    //    List<List<int>> list = getAllOddLengthsArr(arr);
    //    foreach (List<int> list2 in list)
    //    {
    //        foreach (var item in list2)
    //        {
    //            sum += item;
    //        };

    //    }
    //    return sum;
    //}


    /*
     You are given a 1-indexed integer array nums of length n.
    An element nums[i] of nums is called special if i divides n, i.e. n % i == 0.
    Return the sum of the squares of all special elements of nums.

    Example 1:

    Input: nums = [1,2,3,4]
    Output: 21
    Explanation: There are exactly 3 special elements in nums: 
    nums[1] since 1 divides 4, nums[2] since 2 divides 4, and nums[4] since 4 divides 4. 
    Hence, the sum of the squares of all special elements of nums is
    nums[1] * nums[1] + nums[2] * nums[2] + nums[4] * nums[4] = 1 * 1 + 2 * 2 + 4 * 4 = 21.  
     */

    public int SumOfSquares(int[] nums)
    {
        int sum = 0;
        int lenght = nums.Length;
        for (int i = 1; i <= nums.Length; i++)
        {
            if (lenght % i == 0)
            {
                sum += (nums[i - 1] * nums[i - 1]);
            }
        }

        return sum;
    }

    /*
    Given a non-negative integer c, decide whether there're two integers a and b such that a2 + b2 = c.
     
    Example 1:
    Input: c = 5
    Output: true
    Explanation: 1 * 1 + 2 * 2 = 5
    
    Example 2:
    Input: c = 3
    Output: false
    */

    public bool JudgeSquareSum(int c)
    {
        long left = 0, right = (long)Math.Sqrt(c);
        while (left <= right)
        {
            long temp = left * left + right * right;
            if (temp == c) return true;
            if (temp > c) right--;
            else left++;
        }
        return false;
    }


    /// <summary>
    /// Sorting Algorithm
    /// </summary>
    /// <param name="args"></param>
    /// 

    //insert sort
    public void insertSort(int[] a)
    {
        int i, j, last;
        for (i = 1; i < a.Length; i++)
        {
            last = a[i];
            j = i;
            while ((j > 0) && (a[j - 1] > last))
            {
                a[j] = a[j - 1];
                j = j - 1;
            }
            a[j] = last;
        } // end for
    } // end of isort

    //selection sort 

    public void selectionSort(int[] nums)
    {
        int i, j, min, temp;
        for (i = 0; i < nums.Length - 1; i++)
        {
            min = i;
            for (j = i + 1; j < nums.Length; j++)
            {
                if (nums[j] < nums[min]) min = j;
            }
            temp = nums[i];
            nums[i] = nums[min];
            nums[min] = temp;
        }
    }

    //merge sort

    //bubble sort
    public void bubbleSort(int[] a, int n)
    {
        int i, j, temp;
        for (i = (n - 1); i >= 0; i--)
        {
            for (j = 1; j <= i; j++)
            {
                if (a[j - 1] > a[j])
                {
                    //swap(a[j - 1], a[j]);
                    temp = a[j];
                    a[j] = a[j - 1];
                    a[j - 1] = temp;
                }
            }
        }
    }

    /// <summary>
    /// Searching Algorithm
    /// </summary>
    /// <param name="args"></param>
    /// 

    //linear search

    //binary search


    /// <summary>
    /// sakamoto Algorithm check day of week
    /// </summary>
    /// <param name="args"></param>
    ///
    public static int down(int y, int m, int d)
    {
        int[] t = { 0, 3, 2, 5, 0, 3, 5, 1, 4, 6, 2, 4 };
        y -= (m < 3) ? 1 : 0;
        return (y + y / 4 - y / 100 + y / 400 + t[m - 1] + d) % 7 + 1;
    }


    /// <summary>
    /// the string "AAAABBBCCDAA" would be encoded as "4A3B2C1D2A".
    /// </summary>
    /// <param name="args"></param>
    /// 
    public static void Encode(string s)
    {
        int indexnew = 0;
        int count = 0;
        int i = 0;
        while (i < s.Length)
        {
            count = 0;
            while (indexnew < s.Length && s[i] == s[indexnew])
            {
                count++;
                indexnew++;
            }
            Console.Write(count);
            Console.Write(s[i]);
            i = indexnew;
        }
    }
    static void Main(string[] args)
    {
        Solution s = new Solution();

        //Console.WriteLine(
        //SingleNumber(new[] { 1, 2, 2, 3, 3, 4, 5 })
        //    );

        //string a = "abc";
        //Console.WriteLine(a[1]);

        //automative complete word
        //List<string> l = new List<string>();
        //l = AutoComplete("de", new List<string> { "dog", "deer", "dean" });
        //foreach (var item in l)
        //{
        //    Console.Write(item + " ");
        //}

        //add sum of 2 linked list and store reverse number to linkedlist (2. Add Two Numbers leetcode)

        //ListNode head = new ListNode(9);
        //ListNode node2 = new ListNode(4);
        //ListNode node3 = new ListNode(3);

        //ListNode head4 = new ListNode(9);
        //ListNode node5 = new ListNode(9);
        //ListNode node6 = new ListNode(9);

        ////head.next = node2;
        ////node2.next = node3;

        //head4.next = node5;
        //node5.next = node6;

        //ListNode result = new ListNode();
        //result = s.AddTwoNumbers(head, head4);

        //while (result != null)
        //{
        //    Console.Write(result.val);
        //    result = result.next;
        //}

        //find all odd number of length
        //int[] arr = { 1, 2, 3, 4, 5 };

        //s.SumOddLengthSubarrays(arr);

        // sum of specialNUmber^2

        //Console.WriteLine(s.SumOfSquares(new int[] { 1, 2, 3, 4 }));
        //long c = (long)Math.Sqrt(2147483645);
        //Console.WriteLine(c);
        //Console.WriteLine(s.JudgeSquareSum(2147483645));

        //Console.WriteLine(down(2023, 11, 18));

        Encode("AAAABBBCCDAA");
    }
}