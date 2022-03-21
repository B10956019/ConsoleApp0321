using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleApp0321
{
    class Program
    {
        /*Car myCar = new Car();
           myCar.StartEngin();
           myCar.showInfo();
           Console.WriteLine("請輸入新顏色:");
           string i = Console.ReadLine();
           myCar.changeColor(i);*/
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            
            bool play = true;
            while (play)
            {
                Random random = new Random();
                int ans = random.Next(1, 100);
                //Console.WriteLine(ans);
                int min = 1, max = 100;
                for (int i = 5; i >0; i--)
                {
                    Console.WriteLine("請輸入" + min + "~" + max+" 剩餘次數:"+i);
                    int user = Convert.ToInt32(Console.ReadLine());
                    if(user <ans && user > min)
                    {
                        min = user;
                    }
                    else if (user > ans && user < max)
                    {
                        max = user;
                    }
                    else if(user == ans)
                    {
                        Console.WriteLine("猜對了!!");
                        Console.WriteLine("答案是:" + ans);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("請輸入" + min + "~" + max+"的範圍喔");
                    }
                    if (user != ans && i == 1)
                    {
                        Console.WriteLine("失敗..");
                        Console.WriteLine("答案是:"+ans);
                        break;
                    }

                }

                Console.WriteLine("是否繼續遊玩 1繼續0結束");
                int end = Convert.ToInt32(Console.ReadLine());
                if (end == 1)
                {
                    play = true;
                }
                else
                {
                    play = false;
                }
            }
            //await HttpMain();
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
