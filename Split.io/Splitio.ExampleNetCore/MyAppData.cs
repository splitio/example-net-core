using Splitio.Services.Client.Classes;
using Splitio.Services.Client.Interfaces;

namespace ExampleNetCore
{
    public class MyAppData
    {
        public ISplitClient Sdk { get; }

        public MyAppData()
        {            
            var apikey = "<your API KEY here>";            
            var configurations = new ConfigurationOptions
            {
                FeaturesRefreshRate = 20,
                SegmentsRefreshRate = 20,
                ReadTimeout = 20000,
                ConnectionTimeout = 20000
            };

            var factory = new SplitFactory(apikey, configurations);
            Sdk = factory.Client();
        }
    }
}