using System;
using System.Collections.Generic;
using System.Linq;

namespace PartitionLabels
{
    //Problem: https://leetcode.com/problems/partition-labels/
    class Program
    {
        static void Main(string[] args)
        {
            string S = "ababcbacadefegdehijhklij";
            IList<int> results = PartitionLabels(S);
            Console.WriteLine(String.Join(" ", new List<int>(results).ConvertAll(i => i.ToString()).ToArray())); ;
        }
        public static IList<int> PartitionLabels(string S)
        {
            List<int> results = new List<int>();
        
            //char c = S[0];
            int i = 0;
            int prevLast = 0;
            int lastIdx = S.LastIndexOf(S[i]);
            int idx;
            while(i < S.Length)
            {
                idx = S.LastIndexOf(S[i]);
                if (idx > lastIdx)
                    lastIdx = idx;//Update partition end. 

                if (i == lastIdx)
                {//Add partition
                    results.Add(lastIdx - prevLast + 1);
                    prevLast = i+1;
                }
                i++;
            }
            return results;
        }
    }
}
