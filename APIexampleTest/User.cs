using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
namespace APIexampleTest
{
    public class Extension
    {
        public List <string>  Attributes { get; set; }
        public object Categories { get; set; }
        public object Contacts { get; set; }
        public object Images { get; set; }
        public object Packages { get; set; }
        public object Url { get; set; }
        public object Users { get; set; }

    }
     
    public class AddressLine
    {
        public string en { get; set; }
    }

    public class Id
    {
        [JsonProperty("Id")]
        public string Idvalue { get; set; }
        [JsonProperty("Keys")]
        public object Keys { get; set; }
        [JsonProperty("ObjectTypeId")]
        public int ObjectTypeId { get; set; }
    }

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

    public class Country
    {
        public string CallingCode { get; set; }
        public string DisplayName { get; set; }
        public Id Id { get; set; }
        public string Iso3Code { get; set; }
        public string IsoCode { get; set; }
        public Name Name { get; set; }
    }

    public class Address
    {
        public Extension Extension { get; set; }
        public Id Id { get; set; }
        public object __type { get; set; }
        public bool IsNew { get; set; }
        public object Tag { get; set; }
        public AddressLine AddressLine1 { get; set; }
        public AddressLine AddressLine2 { get; set; }
        public AddressLine AddressLine3 { get; set; }
        public object City { get; set; }
        public Country Country { get; set; }
        public int CountryId { get; set; }
        public object PostCode { get; set; }
        public object SubRegion { get; set; }
    }

    public class MultilingualFirstName
    {
        public string en { get; set; }
        [JsonProperty("zh-HK")]
        public string zh_HK { get; set; }
    }

    public class MultilingualLastName
    {
        public string en { get; set; }
        [JsonProperty("zh-HK")]
        public string zh_HK { get; set; }
    }

    public class User
    {

        public string __type { get; set; }
        public Extension Extension { get; set; }
        public Id Id { get; set; }
        public bool IsNew { get; set; }
        public object Tag { get; set; }
        public object ActivationDate { get; set; }
        public string ActivationId { get; set; }
        public Address Address { get; set; }
        public string CreatedDate { get; set; }
        public object Culture { get; set; }
        public string Email { get; set; }
        public object Fax { get; set; }
        public bool IsLockedOut { get; set; }
        public object LockedOutDate { get; set; }
        public object MiddleName { get; set; }
        public object MobilePhoneNumber { get; set; }
        public MultilingualFirstName MultilingualFirstName { get; set; }
        public MultilingualLastName MultilingualLastName { get; set; }
        public object Phone { get; set; }
        public object Prefix { get; set; }
        public string UniqueId { get; set; }
        public string Username { get; set; }
        public object WebsiteUrl { get; set; }
    }
}
    

