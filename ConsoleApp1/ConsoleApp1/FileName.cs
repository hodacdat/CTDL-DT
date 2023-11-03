using System;
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
    public bool checkOddLength(int[] array)
    {
        if (array.Length % 2 != 0)
        {
            return true;
        }
        return false;
    }


    static void Main(string[] args)
    {
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

        //Solution s = new Solution();
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


    }
}