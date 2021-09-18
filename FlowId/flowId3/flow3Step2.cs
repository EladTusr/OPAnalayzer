using System;
using System.Collections.Generic;
using System.Text;

namespace OPAnalyzer1
{
    public static class flow3Step2
    {
        public static string counter_string { get; set; }
        public static List<string> execute(List<string> outputlist)
        {
            for(int i=0; i<(outputlist.Count)/2; i++)
            {
                int temp_place = outputlist.Count - i - 1;
                counter_string = outputlist[temp_place];
                outputlist[temp_place] = outputlist[i];
                outputlist[i] = counter_string;
   
            }

            return outputlist;
        }
    }
}