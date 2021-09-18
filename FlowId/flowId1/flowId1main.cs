using System;
using System.Collections.Generic;
using System.Text;

namespace OPAnalyzer1
{
    public static class flowId1main
    {
         

        public static List<string>flow1Exucuter(List<string> outputlist)
        {
            Console.WriteLine("Step 1: Remove short items, Description: remove items which contains less than 5 characters\n Step2: Remove spaces, Description: remove spaces from items");
            outputlist = flow1Step1.execute(outputlist);
            outputlist = flow1Step2.execute(outputlist);
            return outputlist;
        }
    }
}
