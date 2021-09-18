using System;
using System.Collections.Generic;
using System.Text;

namespace OPAnalyzer1
{
    public static class flow1Step2
        {
            public static List<string> execute(List<string> outputlist)
            {
                foreach (string str in outputlist)
                {
                str.Replace(" ", "");
                }

                return outputlist;
            }
        }
}
