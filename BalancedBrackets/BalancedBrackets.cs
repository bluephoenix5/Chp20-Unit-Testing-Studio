using System;
using System.Collections.Generic;
using System.Linq;

namespace BalancedBracketsNS
{
    public class BalancedBrackets
    {
        /**
         * The function BalancedBrackets should return true if and only if
         * the input string has a set of "balanced" brackets.
         *
         * That is, whether it consists entirely of pairs of opening/closing
         * brackets (in that order), none of which mis-nest. We consider a bracket
         * to be square-brackets: [ or ].
         *
         * The string may contain non-bracket characters as well.
         *
         * These strings have balanced brackets:
         *  "[LaunchCode]", "Launch[Code]", "[]LaunchCode", "", "[]"
         *
         * While these do not:
         *   "[LaunchCode", "Launch]Code[", "[", "]["
         *
         * parameter str - to be validated
         * returns true if balanced, false otherwise
        */
        //private static bool isMatchingPair(char v1, char v2)
        //{
        //    throw new NotImplementedException();
        //}

        public static bool HasBalancedBrackets(String str)
        {
            Dictionary<char, char> fullbrackets = new Dictionary<char, char>()
            {
                { '[', ']' }
            };

            Stack<char> brackets = new Stack<char>();

            try
            {
                foreach (char i in str)
                {
                    if (fullbrackets.Keys.Contains(i))
                    {
                        brackets.Push(i);
                    }
                    else
                        if (fullbrackets.Values.Contains(i))
                    {
                        if (i == fullbrackets[brackets.First()])
                        {
                            brackets.Pop();
                        }
                        
                    }
                }
            }
            
            catch
            {
                return false;
            }

            return brackets.Count() == 0;
            
                
            
            //int brackets = 0;
            //foreach (char ch in str.ToCharArray())
            //{
            //    if (ch == '[')
            //    {
            //        brackets++;
            //    }
            //    else if (ch == ']')
            //    {
            //        brackets--;
            //    }
            //}
            //return brackets == 0;
        }

        
    }
}
