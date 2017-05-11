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
        static void Main(string[] args)
        {
            restClient client = new restClient();
            User user = new User();          
            Console.WriteLine("Create User status Code {0}", client.submitUser(user));
            Console.ReadKey();

        }
    }
}
