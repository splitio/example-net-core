## Example Demo MVC application to show Split .NET Core SDK

This is a single page that shows how to set up the .NET Core SDK. Follow the instructions below to make the changes 
needed using the information obtained from Split UI.

### Get started

 * Log in to Split console, go to the "Admin Tab" and copy an API token of type "Browser"
 * [Create a Split](CREATESPLIT.md) and assign its name to the variable `featureName` in DefaultController.cs
 * Run your application, open your browser and you should see the treatment for the feature specified.
 
 You can also set a value for `featureName` and `userKey`, using url parameters as follows:
 
 `http://localhost:3954/Default?featureName=test-net&userKey=test-id`