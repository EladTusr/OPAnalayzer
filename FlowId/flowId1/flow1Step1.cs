using System;
using System.Collections.Generic;
using System.Text;

namespace OPAnalyzer1
{
    public static class flow1Step1
    {
        public static List<string>execute(List<string> outputlist)
        {
            foreach (string str in outputlist)
            {
                if (str.Length < 5)
                    outputlist.Remove(str);
            }

            return outputlist;
        }
    }
}