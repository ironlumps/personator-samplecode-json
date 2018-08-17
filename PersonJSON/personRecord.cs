using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace PersonJSON
{

    public class Rootobject
    {
        public Record[] Records { get; set; }
        public string TotalRecords { get; set; }
        public string TransmissionReference { get; set; }
        public string TransmissionResults { get; set; }
        public string Version { get; set; }
    }

    public class Record
    {
        public string AddressDeliveryInstallation { get; set; }
        public string AddressExtras { get; set; }
        public string AddressHouseNumber { get; set; }
        public string AddressKey { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLockBox { get; set; }
        public string AddressPostDirection { get; set; }
        public string AddressPreDirection { get; set; }
        public string AddressPrivateMailboxName { get; set; }
        public string AddressPrivateMailboxRange { get; set; }
        public string AddressRouteService { get; set; }
        public string AddressStreetName { get; set; }
        public string AddressStreetSuffix { get; set; }
        public string AddressSuiteName { get; set; }
        public string AddressSuiteNumber { get; set; }
        public string AddressTypeCode { get; set; }
        public string AreaCode { get; set; }
        public string CBSACode { get; set; }
        public string CBSADivisionCode { get; set; }
        public string CBSADivisionLevel { get; set; }
        public string CBSADivisionTitle { get; set; }
        public string CBSALevel { get; set; }
        public string CBSATitle { get; set; }
        public string CarrierRoute { get; set; }
        public string CensusBlock { get; set; }
        public string CensusKey { get; set; }
        public string CensusTract { get; set; }
        public string ChildrenAgeRange { get; set; }
        public string City { get; set; }
        public string CityAbbreviation { get; set; }
        public string CompanyName { get; set; }
        public string CongressionalDistrict { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public string CountyFIPS { get; set; }
        public string CountyName { get; set; }
        public string CountySubdivisionCode { get; set; }
        public string CountySubdivisionName { get; set; }
        public string CreditCardUser { get; set; }
        public string DateOfBirth { get; set; }
        public string DateOfDeath { get; set; }
        public string DeliveryIndicator { get; set; }
        public string DeliveryPointCheckDigit { get; set; }
        public string DeliveryPointCode { get; set; }
        public string DemographicsGender { get; set; }
        public string DemographicsResults { get; set; }
        public string DistanceAddressToIP { get; set; }
        public string DomainName { get; set; }
        public string Education { get; set; }
        public string ElementarySchoolDistrictCode { get; set; }
        public string ElementarySchoolDistrictName { get; set; }
        public string EmailAddress { get; set; }
        public string Gender { get; set; }
        public string Gender2 { get; set; }
        public string HouseholdIncome { get; set; }
        public string HouseholdSize { get; set; }
        public string IPAddress { get; set; }
        public string IPCity { get; set; }
        public string IPConnectionSpeed { get; set; }
        public string IPConnectionType { get; set; }
        public string IPContinent { get; set; }
        public string IPCountryAbbreviation { get; set; }
        public string IPCountryName { get; set; }
        public string IPDomainName { get; set; }
        public string IPISPName { get; set; }
        public string IPLatitude { get; set; }
        public string IPLongitude { get; set; }
        public string IPPostalCode { get; set; }
        public string IPProxyDescription { get; set; }
        public string IPProxyType { get; set; }
        public string IPRegion { get; set; }
        public string IPUTC { get; set; }
        public string Latitude { get; set; }
        public string LengthOfResidence { get; set; }
        public string Longitude { get; set; }
        public string MailboxName { get; set; }
        public string MaritalStatus { get; set; }
        public string MelissaAddressKey { get; set; }
        public string MelissaAddressKeyBase { get; set; }
        public string MoveDate { get; set; }
        public string NameFirst { get; set; }
        public string NameFirst2 { get; set; }
        public string NameFull { get; set; }
        public string NameLast { get; set; }
        public string NameLast2 { get; set; }
        public string NameMiddle { get; set; }
        public string NameMiddle2 { get; set; }
        public string NamePrefix { get; set; }
        public string NamePrefix2 { get; set; }
        public string NameSuffix { get; set; }
        public string NameSuffix2 { get; set; }
        public string NewAreaCode { get; set; }
        public string Occupation { get; set; }
        public string OwnRent { get; set; }
        public string PhoneCountryCode { get; set; }
        public string PhoneCountryName { get; set; }
        public string PhoneExtension { get; set; }
        public string PhoneNumber { get; set; }
        public string PhonePrefix { get; set; }
        public string PhoneSuffix { get; set; }
        public string PlaceCode { get; set; }
        public string PlaceName { get; set; }
        public string Plus4 { get; set; }
        public string PoliticalParty { get; set; }
        public string PostalCode { get; set; }
        public string PresenceOfChildren { get; set; }
        public string PresenceOfSenior { get; set; }
        public string PrivateMailBox { get; set; }
        public string RecordExtras { get; set; }
        public string RecordID { get; set; }
        public string Reserved { get; set; }
        public string Results { get; set; }
        public string Salutation { get; set; }
        public string SecondarySchoolDistrictCode { get; set; }
        public string SecondarySchoolDistrictName { get; set; }
        public string State { get; set; }
        public string StateDistrictLower { get; set; }
        public string StateDistrictUpper { get; set; }
        public string StateName { get; set; }
        public string Suite { get; set; }
        public string TopLevelDomain { get; set; }
        public string TypeOfVehicles { get; set; }
        public string UTC { get; set; }
        public string UnifiedSchoolDistrictCode { get; set; }
        public string UnifiedSchoolDistrictName { get; set; }
        public string UrbanizationName { get; set; }

       public override string ToString()
        {
            return "Full Name: " + NameFull + Environment.NewLine +
                "Address 1: " + AddressLine1 + Environment.NewLine +
                "Company: " + CompanyName + Environment.NewLine +
                "City: " + City + Environment.NewLine +
                "Zip Code: " + PostalCode + Environment.NewLine +
                "State: " + State + Environment.NewLine +
                "Country; " + CountryName + Environment.NewLine +
                "Email: " + EmailAddress + Environment.NewLine +
                "Phone: " + PhoneNumber + Environment.NewLine;

    }
    }

  
}
