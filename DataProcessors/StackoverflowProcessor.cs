using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net;

namespace OPAnalyzer1
{
    /*
     * In this class we will call a method which will read and data from the Stackoverflow Api 
     * the relevant data is represented as StackoverflowTopModel which is a calss that contains onley the relevant path to the title property
     * with the use of the function ReadAsAsync inly the relevant data will be obtained from the API, while tho irelevant data will be ignored.
     * this class will return the data in the orgenized metheod as StackoverflowTopModel.
     */
    public class StackoverflowProcessor
    {
        public static async Task<StackoverflowTopModel> LoadStackoverflowData(HttpClient  APIClient)
        {
            using (HttpResponseMessage response = await APIClient.GetAsync("faq?site=stackoverflow"))
            {
                if (response.IsSuccessStatusCode)
                {
                    StackoverflowTopModel data_model = await response.Content.ReadAsAsync<StackoverflowTopModel>();
                    return data_model;

                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
