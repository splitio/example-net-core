using Splitio.Services.Client.Classes;
using Splitio.Services.Client.Interfaces;
using System;


namespace ExampleNetCore
{

    public class MyAppData
    {
        private ISplitClient sdk;
        public ISplitClient Sdk { get { return sdk; } }


        public MyAppData()
        {
            String apikey = "<your API KEY here>";

            var configurations = new ConfigurationOptions();
            configurations.FeaturesRefreshRate = 20;
            configurations.SegmentsRefreshRate = 20;

            configurations.ReadTimeout = 20000;
            configurations.ConnectionTimeout = 20000;

            var factory = new SplitFactory(apikey, configurations);
            sdk = factory.Client();
        }

    }
}