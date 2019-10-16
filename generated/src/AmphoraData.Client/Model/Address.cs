/* 
 * Amphora Data Api
 *
 * API for interacting with the Amphora Data platform.
 *
 * The version of the OpenAPI document: 0.0.2
 * Contact: rian@amphoradata.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = AmphoraData.Client.Client.OpenAPIDateConverter;

namespace AmphoraData.Client.Model
{
    /// <summary>
    /// Address
    /// </summary>
    [DataContract]
    public partial class Address :  IEquatable<Address>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Address" /> class.
        /// </summary>
        /// <param name="streetNumber">streetNumber.</param>
        /// <param name="streetName">streetName.</param>
        /// <param name="municipalitySubdivision">municipalitySubdivision.</param>
        /// <param name="municipality">municipality.</param>
        /// <param name="countrySecondarySubdivision">countrySecondarySubdivision.</param>
        /// <param name="countrySubdivision">countrySubdivision.</param>
        /// <param name="postalCode">postalCode.</param>
        /// <param name="countryCode">countryCode.</param>
        /// <param name="country">country.</param>
        /// <param name="countryCodeIso3">countryCodeIso3.</param>
        /// <param name="freeformAddress">freeformAddress.</param>
        /// <param name="localName">localName.</param>
        public Address(string streetNumber = default(string), string streetName = default(string), string municipalitySubdivision = default(string), string municipality = default(string), string countrySecondarySubdivision = default(string), string countrySubdivision = default(string), string postalCode = default(string), string countryCode = default(string), string country = default(string), string countryCodeIso3 = default(string), string freeformAddress = default(string), string localName = default(string))
        {
            this.StreetNumber = streetNumber;
            this.StreetName = streetName;
            this.MunicipalitySubdivision = municipalitySubdivision;
            this.Municipality = municipality;
            this.CountrySecondarySubdivision = countrySecondarySubdivision;
            this.CountrySubdivision = countrySubdivision;
            this.PostalCode = postalCode;
            this.CountryCode = countryCode;
            this.Country = country;
            this.CountryCodeIso3 = countryCodeIso3;
            this.FreeformAddress = freeformAddress;
            this.LocalName = localName;
        }
        
        /// <summary>
        /// Gets or Sets StreetNumber
        /// </summary>
        [DataMember(Name="streetNumber", EmitDefaultValue=false)]
        public string StreetNumber { get; set; }

        /// <summary>
        /// Gets or Sets StreetName
        /// </summary>
        [DataMember(Name="streetName", EmitDefaultValue=false)]
        public string StreetName { get; set; }

        /// <summary>
        /// Gets or Sets MunicipalitySubdivision
        /// </summary>
        [DataMember(Name="municipalitySubdivision", EmitDefaultValue=false)]
        public string MunicipalitySubdivision { get; set; }

        /// <summary>
        /// Gets or Sets Municipality
        /// </summary>
        [DataMember(Name="municipality", EmitDefaultValue=false)]
        public string Municipality { get; set; }

        /// <summary>
        /// Gets or Sets CountrySecondarySubdivision
        /// </summary>
        [DataMember(Name="countrySecondarySubdivision", EmitDefaultValue=false)]
        public string CountrySecondarySubdivision { get; set; }

        /// <summary>
        /// Gets or Sets CountrySubdivision
        /// </summary>
        [DataMember(Name="countrySubdivision", EmitDefaultValue=false)]
        public string CountrySubdivision { get; set; }

        /// <summary>
        /// Gets or Sets PostalCode
        /// </summary>
        [DataMember(Name="postalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or Sets CountryCode
        /// </summary>
        [DataMember(Name="countryCode", EmitDefaultValue=false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or Sets CountryCodeIso3
        /// </summary>
        [DataMember(Name="countryCodeIso3", EmitDefaultValue=false)]
        public string CountryCodeIso3 { get; set; }

        /// <summary>
        /// Gets or Sets FreeformAddress
        /// </summary>
        [DataMember(Name="freeformAddress", EmitDefaultValue=false)]
        public string FreeformAddress { get; set; }

        /// <summary>
        /// Gets or Sets LocalName
        /// </summary>
        [DataMember(Name="localName", EmitDefaultValue=false)]
        public string LocalName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Address {\n");
            sb.Append("  StreetNumber: ").Append(StreetNumber).Append("\n");
            sb.Append("  StreetName: ").Append(StreetName).Append("\n");
            sb.Append("  MunicipalitySubdivision: ").Append(MunicipalitySubdivision).Append("\n");
            sb.Append("  Municipality: ").Append(Municipality).Append("\n");
            sb.Append("  CountrySecondarySubdivision: ").Append(CountrySecondarySubdivision).Append("\n");
            sb.Append("  CountrySubdivision: ").Append(CountrySubdivision).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  CountryCodeIso3: ").Append(CountryCodeIso3).Append("\n");
            sb.Append("  FreeformAddress: ").Append(FreeformAddress).Append("\n");
            sb.Append("  LocalName: ").Append(LocalName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Address);
        }

        /// <summary>
        /// Returns true if Address instances are equal
        /// </summary>
        /// <param name="input">Instance of Address to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Address input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StreetNumber == input.StreetNumber ||
                    (this.StreetNumber != null &&
                    this.StreetNumber.Equals(input.StreetNumber))
                ) && 
                (
                    this.StreetName == input.StreetName ||
                    (this.StreetName != null &&
                    this.StreetName.Equals(input.StreetName))
                ) && 
                (
                    this.MunicipalitySubdivision == input.MunicipalitySubdivision ||
                    (this.MunicipalitySubdivision != null &&
                    this.MunicipalitySubdivision.Equals(input.MunicipalitySubdivision))
                ) && 
                (
                    this.Municipality == input.Municipality ||
                    (this.Municipality != null &&
                    this.Municipality.Equals(input.Municipality))
                ) && 
                (
                    this.CountrySecondarySubdivision == input.CountrySecondarySubdivision ||
                    (this.CountrySecondarySubdivision != null &&
                    this.CountrySecondarySubdivision.Equals(input.CountrySecondarySubdivision))
                ) && 
                (
                    this.CountrySubdivision == input.CountrySubdivision ||
                    (this.CountrySubdivision != null &&
                    this.CountrySubdivision.Equals(input.CountrySubdivision))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.CountryCodeIso3 == input.CountryCodeIso3 ||
                    (this.CountryCodeIso3 != null &&
                    this.CountryCodeIso3.Equals(input.CountryCodeIso3))
                ) && 
                (
                    this.FreeformAddress == input.FreeformAddress ||
                    (this.FreeformAddress != null &&
                    this.FreeformAddress.Equals(input.FreeformAddress))
                ) && 
                (
                    this.LocalName == input.LocalName ||
                    (this.LocalName != null &&
                    this.LocalName.Equals(input.LocalName))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.StreetNumber != null)
                    hashCode = hashCode * 59 + this.StreetNumber.GetHashCode();
                if (this.StreetName != null)
                    hashCode = hashCode * 59 + this.StreetName.GetHashCode();
                if (this.MunicipalitySubdivision != null)
                    hashCode = hashCode * 59 + this.MunicipalitySubdivision.GetHashCode();
                if (this.Municipality != null)
                    hashCode = hashCode * 59 + this.Municipality.GetHashCode();
                if (this.CountrySecondarySubdivision != null)
                    hashCode = hashCode * 59 + this.CountrySecondarySubdivision.GetHashCode();
                if (this.CountrySubdivision != null)
                    hashCode = hashCode * 59 + this.CountrySubdivision.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.CountryCode != null)
                    hashCode = hashCode * 59 + this.CountryCode.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.CountryCodeIso3 != null)
                    hashCode = hashCode * 59 + this.CountryCodeIso3.GetHashCode();
                if (this.FreeformAddress != null)
                    hashCode = hashCode * 59 + this.FreeformAddress.GetHashCode();
                if (this.LocalName != null)
                    hashCode = hashCode * 59 + this.LocalName.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
