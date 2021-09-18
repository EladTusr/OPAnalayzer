using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net;


namespace OPAnalyzer1
{
     /*
      * This class will read the data from the github Api.
      * the read will be in string format which means the whole site's data as one string.
      * after the data has been obtaned, It will be sent to several methods so it will be returned in the reqested format
      */
    public class GITProcessor
    {
        public static async Task<List<string>>  LoadGitData(HttpClient APIClient)
        {
            using (HttpResponseMessage response = await APIClient.GetAsync(""))
            {
                if (response.IsSuccessStatusCode)
                {   
                    string my_str = await response.Content.ReadAsStringAsync();
                    string[] my_array = my_str.Split("message\":");
                    my_array = MyArrayHelper.removeTheRest("\",", my_array);
                    my_array = MyArrayHelper.removeFirstCell(my_array);
                    my_array = MyArrayHelper.removeApostrophes(my_array);
                    List<string> outputList = MyArrayHelper.moveToList(my_array);
                    return outputList;

                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
