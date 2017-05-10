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
    class Program
    {
        static string getToken()
        {
            var client = new RestClient("https://site06.qaw03.rxweb-dev.com/api/v2_3/security/login/AtfAdmin01/apikey");
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
            var token = (string)obj["Data"];
            return token;
        }
        static string createUser(string token, User user)
        {
            string output = JsonConvert.SerializeObject(user);
            Console.WriteLine("[" + output + "]");
            var client1 = new RestClient("https://site06.qaw03.rxweb-dev.com/api/v2_3/users?disallowUpdate=False&sendEmail=True&upsertRegistration=True&contactableByObjectsInList=False&sendRegistrationEmail=True");
            var request1 = new RestRequest(Method.POST);
            request1.AddHeader("cache-control", "no-cache");
            request1.AddHeader("content-type", "application/json");
            request1.AddHeader("accept", "application/json");
            request1.AddHeader("authorization", "Basic YXRmYWRtaW4wMTpUZXN0aW5nMTIz");
            request1.AddHeader("host", "site06.qaw03.rxweb-dev.com");
            request1.AddHeader("x-apikey", token);
            request1.AddHeader("x-lockmode", "Optimistic");
            request1.AddHeader("user-agent", "Reed Exhibitions Nova SDK v3.7.0.0");
            request1.AddHeader("accept-encoding", "gzip,deflate");
            request1.AddParameter("application/json", output, ParameterType.RequestBody);
            IRestResponse response1 = client1.Execute(request1);
            return response1.StatusCode.ToString();
        }
            static void Main(string[] args)
        {
           
            User user = new User();
            user.Username = "eg803t3@8323j2.reedtest";
            user.__type = "User:#ReedExpo.Nova.Framework.Security";
            user.IsNew = false;
            user.IsLockedOut = false; 
            user.ActivationId = "00000000-0000-0000-0000-000000000000";
            user.UniqueId = "00000000-0000-0000-0000-000000000000";

            user.CreatedDate = null;        
            user.Email ="eg803t3@8323j2.reedtest";
            MultilingualFirstName mFirstName= new MultilingualFirstName();
            MultilingualLastName mLastName = new MultilingualLastName();
            mFirstName.en="FN_08May1104s2362";
            mFirstName.zh_HK = "FN_08May1104s2362";
            mLastName.en = "LN_08May1104s2362";
            mLastName.zh_HK = "LN_08May1104s2362";
       
            user.MultilingualFirstName = mFirstName;
            user.MultilingualLastName = mLastName;
            Extension extension = new Extension();
            List<string> list = new List<string>();

            extension.Attributes = list;

            Address address = new Address();
            AddressLine addresslLine = new AddressLine();
            Country country= new Country();
            Name name = new Name();
            Id id= new Id();
            id.Idvalue = "10";
            id.ObjectTypeId = 111;
         
            name.ca = "Antàrtida";
            name.de = "Antarktis";
            country.CallingCode = "672";
            country.DisplayName = "Antarctica";
            country.Iso3Code = "ATA";
            country.IsoCode = "AQ";
            country.Id = id;
            country.Name = name;
            address.Country = country;
            addresslLine.en = "Address Line 1";
            address.IsNew = false;
            address.AddressLine1 = addresslLine;
            address.CountryId = 10;
            address.Extension = extension;
            user.Address = address;
            user.Extension = extension;         
            Console.WriteLine("Create User status Code {0}", createUser(getToken(),user));
            Console.ReadKey();

        }
    }
}
