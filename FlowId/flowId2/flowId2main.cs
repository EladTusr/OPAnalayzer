using System;
using System.Collections.Generic;
using System.Text;

namespace OPAnalyzer1
{
    public static class flowId2main
    {
        public static List<string> flow2Exucuter(List<string> outputlist)
        {
            Console.WriteLine("Step 1: Remove long items, Description: remove items which contains more than 50 characters\n Step2: Remove all a's performances, Description: change a to @ in all the items");
            outputlist = flow2Step1.execute(outputlist);
            outputlist = flow2Step2.execute(outputlist);
            return outputlist;
        }
    }
}
