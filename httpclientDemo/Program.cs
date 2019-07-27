using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace httpclientDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("In main before call to GetData!");
            GetData();
            Console.WriteLine("Back in main after call to GetData!");
            Console.ReadKey();
        }

        static async void GetData()
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = null;
            response = await httpClient.GetAsync("http://services.odata.org/Northwind/Northwind.svc/Regions");
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Response Status Code and Reason Phrase: " + response.StatusCode + " " + response.ReasonPhrase);
                string responseBodyAsText = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine("Received payload of " + responseBodyAsText.Length + " characters");
                Console.WriteLine(responseBodyAsText);
            }
        }
    }
}
