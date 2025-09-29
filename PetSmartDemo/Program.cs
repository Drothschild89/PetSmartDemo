using System;
using Newtonsoft.Json;

namespace PetSmartDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new { Message = "Hello, Harness CI!" };
            string json = JsonConvert.SerializeObject(data);
            Console.WriteLine(json);
        }
    }
}