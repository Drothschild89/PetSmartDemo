using System;
using Xunit;
using Newtonsoft.Json;

namespace PetSmartDemo.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestJsonSerialization()
        {
            var data = new { Message = "Hello, Harness CI!" };
            string json = JsonConvert.SerializeObject(data);
            Assert.Contains("Hello, Harness CI!", json);
        }
    }
}