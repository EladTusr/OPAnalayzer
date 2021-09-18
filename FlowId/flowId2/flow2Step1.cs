using System;
using System.Collections.Generic;
using System.Text;

namespace OPAnalyzer1
{
    public static class flow2Step1
    {
        public static List<string> execute(List<string> outputlist)
        {
            foreach (string str in outputlist)
            {
                if (str.Length > 50)
                    outputlist.Remove(str);
            }

            return outputlist;
        }
    }
}