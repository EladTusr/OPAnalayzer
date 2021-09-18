using System;
using System.Collections.Generic;
using System.Text;

namespace OPAnalyzer1
{
    public static class flowId3main
    {
        public static List<string> flow3Exucuter(List<string> outputlist)
        {
            Console.WriteLine("Step 1: Remove Capital letters, Description: cahnge all upper case letters to lower case\n Step2: Change order, Description: the items will be changed from end to begining");
            outputlist = flowI3Step1.execute(outputlist);
            outputlist = flow3Step2.execute(outputlist);
            return outputlist;
        }
    }
}
