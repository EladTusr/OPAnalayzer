using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;

namespace OPAnalyzer1
{
    /*
     * This class will recive the data as aTask<List<string>> type and will convert it to the requested data type
     */
    public static class GITGetter 
    {
         public static Task<List<string>> output_task_list;

        public static List<string> getInfo (List<string> outputlist, HttpClient APIClient)
        {
            output_task_list = GITProcessor.LoadGitData(APIClient);
            outputlist = output_task_list.Result;
            return outputlist;
            
        }
    }
} 
