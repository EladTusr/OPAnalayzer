using System;
using System.Collections.Generic;
using System.Text;

namespace OPAnalyzer1
{
    /*
     * This class will choose which flowId will run based on the parameter
     * if there is no matching flow id the chosen flowId will be number 1
     */
    public static  class FlowIdExecuter
    {
      public static List<string> execute(List<string> outpotlist, long flowID)
        {
            switch (flowID)
            {
                case (1):
                    Console.WriteLine("the chosen flow is 1");
                    outpotlist = flowId1main.flow1Exucuter(outpotlist);
                    break;

                case (2):
                    Console.WriteLine("the chosen flow is 1");
                    outpotlist = flowId2main.flow2Exucuter(outpotlist);
                    break;

                case (3):
                    Console.WriteLine("the chosen flow is 1");
                    outpotlist = flowId3main.flow3Exucuter(outpotlist);
                    break;

                default:
                    Console.WriteLine("no matching flow was found, flow 1 will be executed");
                    outpotlist = flowId1main.flow1Exucuter(outpotlist);
                    break;
            }
            return outpotlist;
        }
    }
}