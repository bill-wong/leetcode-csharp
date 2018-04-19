﻿namespace LeetCode.String
{
    /// <summary>
    /// https://leetcode.com/problems/find-the-difference/description/
    /// Given two strings s and t which consist of only lowercase letters.
    /// String t is generated by random shuffling string s and then add one more letter at a random position.
    /// Find the letter that was added in t.
    /// </summary>
    public class FindTheDifference
    {
        public char FindDifference(string s, string t)
        {
            var sChars = s.ToCharArray();
            var tChars = t.ToCharArray();

            int charCode = tChars[tChars.Length - 1];

            for (var i = 0; i < sChars.Length; i++)
            {
                charCode -= sChars[i];
                charCode += tChars[i];
            }

            return (char) charCode;
        }
    }
}