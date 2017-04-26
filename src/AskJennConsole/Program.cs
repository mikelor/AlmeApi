using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Net.Http.Headers;
using System.Net.Http;
using Newtonsoft.Json;
using System.Diagnostics;
using AlmeApiSdk;
using AlmeApiSdk.Models.Conversation.Converse;

namespace AskJennConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Run(args[0]).Wait();
        }

        private static async Task Run(string question)
        {
       
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            var almeClient = new AlmeClient(new Uri("https://askjenn.alaskaair.com/"));

            // Setup the request
            ConverseRequest req = new ConverseRequest();
            req.channel = "Console";
            req.origin = "Typed";
            req.parameters = new ConverseRequestParameters();
            req.question = question;

            // Call the Converse endpoint
            var res = await almeClient.ConverseAsync(req);
            stopWatch.Stop();

            // Write the response out to the console
            Console.WriteLine(res.text);
            
            Console.WriteLine();
            Console.WriteLine(string.Format("Time to Answer: {0}", stopWatch.Elapsed));
            Console.WriteLine(JsonConvert.SerializeObject(res));

        }
                    
    }
}
