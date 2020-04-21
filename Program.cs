using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nexmo.Api;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client(creds: new Nexmo.Api.Request.Credentials
            {
                ApiKey = "4c96767f",
                ApiSecret = "hG7DnVSP0ls0LLGp"
            });
            var results = client.SMS.Send(request: new SMS.SMSRequest
            {
                from = "Vonage SMS API",
                to = "923352991998",
                text = "Hello from Vonage"
            });
        }
    }
}
