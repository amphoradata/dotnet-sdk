/* 
 * AmphoraApi
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * 
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
    /// Poi
    /// </summary>
    [DataContract]
    public partial class Poi :  IEquatable<Poi>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Poi" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="phone">phone.</param>
        /// <param name="categorySet">categorySet.</param>
        /// <param name="categories">categories.</param>
        /// <param name="classifications">classifications.</param>
        public Poi(string name = default(string), string phone = default(string), List<CategorySet> categorySet = default(List<CategorySet>), List<string> categories = default(List<string>), List<Classification> classifications = default(List<Classification>))
        {
            this.Name = name;
            this.Phone = phone;
            this.CategorySet = categorySet;
            this.Categories = categories;
            this.Classifications = classifications;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or Sets CategorySet
        /// </summary>
        [DataMember(Name="categorySet", EmitDefaultValue=false)]
        public List<CategorySet> CategorySet { get; set; }

        /// <summary>
        /// Gets or Sets Categories
        /// </summary>
        [DataMember(Name="categories", EmitDefaultValue=false)]
        public List<string> Categories { get; set; }

        /// <summary>
        /// Gets or Sets Classifications
        /// </summary>
        [DataMember(Name="classifications", EmitDefaultValue=false)]
        public List<Classification> Classifications { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Poi {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  CategorySet: ").Append(CategorySet).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
            sb.Append("  Classifications: ").Append(Classifications).Append("\n");
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
            return this.Equals(input as Poi);
        }

        /// <summary>
        /// Returns true if Poi instances are equal
        /// </summary>
        /// <param name="input">Instance of Poi to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Poi input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.CategorySet == input.CategorySet ||
                    this.CategorySet != null &&
                    input.CategorySet != null &&
                    this.CategorySet.SequenceEqual(input.CategorySet)
                ) && 
                (
                    this.Categories == input.Categories ||
                    this.Categories != null &&
                    input.Categories != null &&
                    this.Categories.SequenceEqual(input.Categories)
                ) && 
                (
                    this.Classifications == input.Classifications ||
                    this.Classifications != null &&
                    input.Classifications != null &&
                    this.Classifications.SequenceEqual(input.Classifications)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.CategorySet != null)
                    hashCode = hashCode * 59 + this.CategorySet.GetHashCode();
                if (this.Categories != null)
                    hashCode = hashCode * 59 + this.Categories.GetHashCode();
                if (this.Classifications != null)
                    hashCode = hashCode * 59 + this.Classifications.GetHashCode();
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
