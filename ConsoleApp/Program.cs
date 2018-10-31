using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:57616/api/");
                //HTTP GET
                var responseTask = client.GetAsync("values");
                responseTask.Wait();

                var result = responseTask.Result;
                
            }
            Console.ReadLine();
        }
    }
}
