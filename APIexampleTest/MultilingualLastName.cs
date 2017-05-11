using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace APIexampleTest
{
    public class MultilingualLastName
    {
        public string en { get; set; }
        [JsonProperty("zh-HK")]
        public string zh_HK { get; set; }
    }
}
