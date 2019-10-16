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
    /// Invitation
    /// </summary>
    [DataContract]
    public partial class Invitation :  IEquatable<Invitation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Invitation" /> class.
        /// </summary>
        /// <param name="targetEmail">targetEmail.</param>
        public Invitation(string targetEmail = default(string))
        {
            this.TargetEmail = targetEmail;
        }
        
        /// <summary>
        /// Gets or Sets TargetEmail
        /// </summary>
        [DataMember(Name="targetEmail", EmitDefaultValue=false)]
        public string TargetEmail { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Invitation {\n");
            sb.Append("  TargetEmail: ").Append(TargetEmail).Append("\n");
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
            return this.Equals(input as Invitation);
        }

        /// <summary>
        /// Returns true if Invitation instances are equal
        /// </summary>
        /// <param name="input">Instance of Invitation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Invitation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TargetEmail == input.TargetEmail ||
                    (this.TargetEmail != null &&
                    this.TargetEmail.Equals(input.TargetEmail))
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
                if (this.TargetEmail != null)
                    hashCode = hashCode * 59 + this.TargetEmail.GetHashCode();
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