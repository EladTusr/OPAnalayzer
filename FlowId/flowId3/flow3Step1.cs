using System;
using System.Collections.Generic;
using System.Text;

namespace OPAnalyzer1
{
    public static class flowI3Step1
    {
        public static List<string> execute(List<string> outputlist)
        {
            foreach (string str in outputlist)
            {
                str.ToLower();
            }

            return outputlist;
        }
    }
}