using Microsoft.AspNetCore.Mvc;
using Splitio.Services.Client.Classes;

namespace ExampleNetCore.Controllers
{
    public class DefaultController : Controller
    {
        private readonly SelfRefreshingClient _sdk;

        public DefaultController(MyAppData data)
        {
            _sdk = data.Sdk as SelfRefreshingClient;
        }

        [HttpGet("")]
        [HttpGet("default")]
        public ActionResult Index(string featureName, string userKey)
        {
            if (string.IsNullOrEmpty(featureName))
            {
                // CHANGE THIS: Copy and paste the feature name from Split UI
                featureName = "<feature name here>";
            }

            if (string.IsNullOrEmpty(userKey))
            {
                // Change this to represent your user or account id. (usually a dynamic value)
                userKey = "userId-1";
            }

            var result = _sdk.GetTreatment(userKey, featureName);

            var content =  string.Format(@"<html>
                                                <body>
                                                    <p data-tid='test-value'>{0}</p>
                                                </body>
                                           </html>", result);

            return new ContentResult()
            {
                Content = content,
                ContentType = "text/html",
            };

        }
    }
}