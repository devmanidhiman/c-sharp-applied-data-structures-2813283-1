﻿// Example file for C# Applied Data Structures by Joe Marini
// Programming Challenge

using System;
using System.Collections.Generic;

namespace Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] TestStatements = {
                "print('Hello World')",
                "if a(b[x]) == b(a[x])",
                "function t(x) { print('t(x)')}",
                "print 'Hello World')",
                "f(x) = g(x[2)",
                "{{[[(())]]}",
                "}"
            };

            foreach (string TestStr in TestStatements) {
                bool Result = CheckBalanced(TestStr);

                Console.WriteLine($"Statement '{TestStr}' {(Result ? "is" : "is not")} balanced.");
            }
        }

        // TODO: Implement the CheckBalanced method
        static bool CheckBalanced(string TestStatement) {
            Stack<char> charStack = new Stack<char>();
            foreach (char ch in TestStatement) {
                if (ch == '{' || ch == '[' || ch == '(')
                {
                    charStack.Push(ch);
                }

                if (ch == '}' || ch == ']' || ch == ')' ) {
                    if (charStack.Count == 0) { return false; }
                    char testChar = charStack.Pop();
                    if (ch == ')' && testChar != '(') { return false; }
                    if (ch == '}' && testChar != '{') { return false; }
                    if (ch == ']' && testChar != '[') { return false; }
                }
            }
            if (charStack.Count > 0) {return false; }
            
            return true;
        }
    }
}
