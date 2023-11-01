using System;
using System.Text;
using System.Collections.Generic;

public class StringHelper
{
    private string value;

    public StringHelper (string value)
    {
        this.value = value;
    }

    public string Concat ( string s)
    {
        StringBuilder stringBuilder = new StringBuilder (value);
        stringBuilder.Append (s);
        return stringBuilder.ToString ();
    }

    public string SubString (int startInd,  int endInd)
    {
        if (startInd < 0 || endInd > value.Length || startInd > endInd)
        {
            throw new ArgumentException("Invalid start or end index");
        }

        StringBuilder result = new StringBuilder ();
        for (int i = startInd; i < endInd; i++)
        {
            result.Append(value[i]);
        }
        return result.ToString ();
    }

    public string Distinct()
    {
        HashSet<char> result = new HashSet<char> (value);
        
        StringBuilder stringBuilder = new StringBuilder ();
        foreach (char c in result)
        {
            stringBuilder.Append (c);
        }
        return stringBuilder.ToString ();
    }

    public bool Contain(string str)
    {
        if(str.Length > value.Length)
        {
            return false;
        }

        for (int i = 0; i <= value.Length - str.Length; i++)
        {
            bool found = true;

            for (int j = 0; j < str.Length; j++)
            {
                if (value[i+j] != str[j])
                {
                    found = false;
                    break;
                }
            }

            if (found)
            {
                return true;
            }
        }
        return false;
    }
}