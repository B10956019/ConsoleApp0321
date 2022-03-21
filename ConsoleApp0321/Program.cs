using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleApp0321
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            /*Car myCar = new Car();
            myCar.StartEngin();
            myCar.showInfo();
            Console.WriteLine("請輸入新顏色:");
            string i = Console.ReadLine();
            myCar.changeColor(i);*/
            await HttpMain();
        }
        static readonly HttpClient client = new HttpClient();
        static async Task HttpMain()
        {
            // Call asynchronous network methods in a try/catch block to handle exceptions.
            string url = "https://data.coa.gov.tw/api/v1/CropType/?CropCode=11";
            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                // Above three lines can be replaced with new helper method below
                // string responseBody = await client.GetStringAsync(uri);

                Console.WriteLine(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
        }
    }
}
