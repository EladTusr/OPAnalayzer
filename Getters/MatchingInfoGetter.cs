using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;

namespace OPAnalyzer1
{
    /*
     * This class will choose the right processor to the data based on the parameters
     */
    public static class MatchingInfoGetter
    {
        public static List<string> fetchRightData(string requestParameters, List<string> outputlist, HttpClient APIClient)
        {
            switch (requestParameters)
            {
                case "Stackoverflow":;
                    outputlist = StackoverflowGetter.getInfo(outputlist, APIClient);
                    break;

                case "Github":;
                    outputlist = GITGetter.getInfo(outputlist, APIClient);
                    break;
            }

            return outputlist;
        }
    }
}
