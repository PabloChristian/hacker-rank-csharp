using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Result
{
    public static int segment(int x, List<int> space)
    {
        int elementOrder = 1;
        Stack<int> stackList = new Stack<int>();
        stackList.Push(0);

        for (int i = 1; i< space.Count; i++)
        {
            if (i < x)
            {
                if(space[i] < space[stackList.Peek()])
                {
                    stackList.Pop();
                    stackList.Push(i);
                }
            }
            else
            {
                int lastNumber = stackList.Peek();
                
                if(lastNumber >= elementOrder)
                {
                    stackList.Push(space[i] < space[lastNumber] ? i : lastNumber);
                }
                else
                {
                    stackList.Push(i);
                    int j = elementOrder;
                    int listCount = 0;
                    
                    while(listCount++ < x)
                    {
                        if(space[j] < space[stackList.Peek()])
                        {
                            stackList.Pop();
                            stackList.Push(j);
                        }
                        j++;
                    }
                    
                }
                
                elementOrder++;
            }
        }
        
        return stackList.Select(number => space[number]).Max();
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int x = Convert.ToInt32(Console.ReadLine().Trim());

        int spaceCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> space = new List<int>();

        for (int i = 0; i < spaceCount; i++)
        {
            int spaceItem = Convert.ToInt32(Console.ReadLine().Trim());
            space.Add(spaceItem);
        }

        int result = Result.segment(x, space);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
