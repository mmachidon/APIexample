using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace APIexampleTest
{
   public class restClient
    {
        string token;
       string getToken()
        {
            Uri uri = new Uri("https://site06.qaw03.rxweb-dev.com/api/v2_3/security/login/AtfAdmin01/apikey");
            RestClient client = new RestClient();
            client.BaseUrl = uri;
            var request = new RestRequest(Method.POST);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("host", "site06.qaw03.rxweb-dev.com");
            request.AddHeader("x-apikey", "00000000-0000-0000-0000-000000000000");
            request.AddHeader("x-lockmode", "Optimistic");
            request.AddHeader("authorization", "Basic QXRmQWRtaW4wMTpUZXN0aW5nMTIz");
            request.AddHeader("accept", "application/json");
            request.AddHeader("content-type", "application/json");
            request.AddHeader("user-agent", "Reed Exhibitions Nova SDK v3.7.0.0");
            request.AddHeader("accept-encoding", "gzip,deflate");
            request.AddParameter("application/json", "\"Testing123\"", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            Console.WriteLine("Get token request {0}", response.StatusCode);
            var obj = JObject.Parse(response.Content);
            token = (string)obj["Data"];
            return token;
        }
       public string submitUser(User user)
        {
            string output = JsonConvert.SerializeObject(user);
            Console.WriteLine("Create user: {0}", output );
            RestClient client = new RestClient();
            Uri uri = new Uri("https://site06.qaw03.rxweb-dev.com/api/v2_3/users?disallowUpdate=False&sendEmail=True&upsertRegistration=True&contactableByObjectsInList=False&sendRegistrationEmail=True");
            client.BaseUrl = uri;
            var request = new RestRequest(Method.POST);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("content-type", "application/json");
            request.AddHeader("accept", "application/json");
            request.AddHeader("authorization", "Basic YXRmYWRtaW4wMTpUZXN0aW5nMTIz");
            request.AddHeader("host", "site06.qaw03.rxweb-dev.com");
            request.AddHeader("x-apikey", getToken());
            request.AddHeader("x-lockmode", "Optimistic");
            request.AddHeader("user-agent", "Reed Exhibitions Nova SDK v3.7.0.0");
            request.AddHeader("accept-encoding", "gzip,deflate");
            request.AddParameter("application/json", "[" + output + "]", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            return response.StatusCode.ToString();
        }
    }
}
