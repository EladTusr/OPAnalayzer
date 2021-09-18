using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace OPAnalyzer1
{
    /*
     * This class will recive the data from the Processor as a StackoverflowTopModel item.
     * it will execute manipulations and will rearange it as a List<string> data type.
     */
    public static class StackoverflowGetter 
    {
        public static Task<List<string>> mylist;

        public static async Task<List<string>> gatherInfo(List<string> list, HttpClient clinet)
        {

            var data_model = await StackoverflowProcessor.LoadStackoverflowData(clinet);
            StackoverflowData[] my_array = data_model.Items;
            foreach (StackoverflowData task in my_array)
            {
                string theTitle = task.title;
                list.Add(theTitle);
            }

            return list;
        }
        public static List<string> getInfo(List<string> outputlist, HttpClient clinet)
        {
            mylist = gatherInfo(outputlist, clinet);
            outputlist = mylist.Result;
            return outputlist;
        }
    }
}
