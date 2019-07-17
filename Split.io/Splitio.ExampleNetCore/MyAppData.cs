using Splitio.Services.Client.Classes;
using Splitio.Services.Client.Interfaces;

namespace ExampleNetCore
{
    public class MyAppData
    {
        private ISplitClient _sdk;
        public ISplitClient Sdk { get { return _sdk; } }

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
            _sdk = factory.Client();
        }
    }
}