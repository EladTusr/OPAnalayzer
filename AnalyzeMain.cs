using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Net;

namespace OPAnalyzer1
{
    public static class AnalyzeMain
    {
        public static List<string> Analyze(string datasourceName, long flowID)
        {
            HttpClient client = InstancesFactory.CreateHttpClient();
            ClientHelper.InitializClient(client);
            List<string> output = InstancesFactory.CreateStringList();
            output = Analyzer.analyzeProcess("Stackoverflow", output, client);
            output.ForEach(Console.WriteLine);
            output = FlowIdExecuter.execute(output, flowID);
            output.ForEach(Console.WriteLine);
            ClientHelper.DeleteClient(client);
            Console.ReadLine();

            return output;
        }
    }
}
