using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
namespace APIexampleTest
{
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

        public User()
        {
            MultilingualFirstName mFirstName = new MultilingualFirstName();
            MultilingualLastName mLastName = new MultilingualLastName();
            Extension extension = new Extension();
            List<string> list = new List<string>();
            Address address = new Address();
            AddressLine addresslLine = new AddressLine();
            Country country = new Country();
            Name name = new Name();
            Id id = new Id();
            id.Idvalue = "10";
            id.ObjectTypeId = 111;

            mFirstName.en = "FN_08May1104s2362";
            mFirstName.zh_HK = "FN_08May1104s2362";
            mLastName.en = "LN_08May1104s2362";
            mLastName.zh_HK = "LN_08May1104s2362";
            extension.Attributes = list;

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

            this.Address = address;
            this.Extension = extension;
            this.Id = id;
            this.MultilingualFirstName = mFirstName;
            this.MultilingualLastName = mLastName;
            this.Username = "eg803t3@8323j2.reedtest";
            this.Email = "eg803t3@8323j2.reedtest";
            this.__type = "User:#ReedExpo.Nova.Framework.Security";
            this.IsNew = false;
            this.IsLockedOut = false;
            this.ActivationId = "00000000-0000-0000-0000-000000000000";
            this.UniqueId = "00000000-0000-0000-0000-000000000001";
        }

        public User(MultilingualFirstName mFirstName, MultilingualLastName mLastName, Extension extension ,
        Address address ,    
        Id id)
        {
            this.Address = address;
            this.Extension = extension;
            this.Id = id;
            this.MultilingualFirstName = mFirstName;
            this.MultilingualLastName = mLastName;
        }
    }
}
    

