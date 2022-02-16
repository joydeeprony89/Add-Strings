using System;
using System.Collections.Generic;
using System.Text;

namespace Add_Strings
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }

    public string AddStrings(string num1, string num2)
    {
      Stack<int> s1 = new Stack<int>();
      Stack<int> s2 = new Stack<int>();
      int n = num1.Length;
      int m = num2.Length;

      string str = m > n ? num2 : num1;

      int i = 0;
      while (i < str.Length)
      {
        if (i < n)
          s1.Push(num1[i] - '0');

        if (i < m)
          s2.Push(num2[i] - '0');

        i++;
      }

      int carry = 0;
      StringBuilder builder = new StringBuilder();
      while (s1.Count > 0 || s2.Count > 0)
      {
        int n1 = 0;
        int n2 = 0;
        if (s1.Count > 0)
          n1 = s1.Pop();

        if (s2.Count > 0)
          n2 = s2.Pop();

        int sum = n1 + n2 + carry;
        carry = sum / 10;
        int no = sum % 10;
        builder.Insert(0, no.ToString());
      }

      if (carry > 0)
        builder.Insert(0, carry.ToString());
      return builder.ToString();
    }

    public string AddStrings_WoStack(string num1, string num2)
    {
      int j = num1.Length - 1;
      int k = num2.Length - 1;

      int i = 0, carry = 0;
      StringBuilder builder = new StringBuilder();
      int l = j > k ? j : k;

      while (l >= 0)
      {
        int n1 = 0;
        int n2 = 0;
        if (j >= 0)
        {
          n1 = num1[j] - '0';
          j--;
        }

        if (k >= 0)
        {
          n2 = num2[k] - '0';
          k--;
        }

        int sum = n1 + n2 + carry;
        carry = sum / 10;
        int no = sum % 10;

        builder.Insert(0, no);

        l--;
      }

      if (carry > 0)
        builder.Insert(0, carry);

      return builder.ToString();
    }
  }
}
