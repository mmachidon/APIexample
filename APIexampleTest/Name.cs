using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace APIexampleTest
{
    public class Name
    {
        public string ar { get; set; }
        public string ca { get; set; }
        public string de { get; set; }
        public string en { get; set; }
        public string es { get; set; }
        public string fr { get; set; }
        public string id { get; set; }
        public string it { get; set; }
        public string ja { get; set; }
        public string ko { get; set; }
        public string pt { get; set; }
        [JsonProperty("pt-BR")]
        public string pt_BR { get; set; }
        public string ru { get; set; }
        public string sk { get; set; }
        public string tr { get; set; }
        public string vi { get; set; }
        [JsonProperty("zh-CN")]
        public string zh_CN { get; set; }
        [JsonProperty("zh-HK")]
        public string zh_HK { get; set; }
    }
}
