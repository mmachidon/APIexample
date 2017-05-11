using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace APIexampleTest
{
    public class Id
    {
        [JsonProperty("Id")]
        public string Idvalue { get; set; }
        [JsonProperty("Keys")]
        public object Keys { get; set; }
        [JsonProperty("ObjectTypeId")]
        public int ObjectTypeId { get; set; }
    }
}
