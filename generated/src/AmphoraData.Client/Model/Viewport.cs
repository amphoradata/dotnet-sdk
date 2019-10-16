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
    /// Viewport
    /// </summary>
    [DataContract]
    public partial class Viewport :  IEquatable<Viewport>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Viewport" /> class.
        /// </summary>
        /// <param name="topLeftPoint">topLeftPoint.</param>
        /// <param name="btmRightPoint">btmRightPoint.</param>
        public Viewport(Position topLeftPoint = default(Position), Position btmRightPoint = default(Position))
        {
            this.TopLeftPoint = topLeftPoint;
            this.BtmRightPoint = btmRightPoint;
        }
        
        /// <summary>
        /// Gets or Sets TopLeftPoint
        /// </summary>
        [DataMember(Name="topLeftPoint", EmitDefaultValue=false)]
        public Position TopLeftPoint { get; set; }

        /// <summary>
        /// Gets or Sets BtmRightPoint
        /// </summary>
        [DataMember(Name="btmRightPoint", EmitDefaultValue=false)]
        public Position BtmRightPoint { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Viewport {\n");
            sb.Append("  TopLeftPoint: ").Append(TopLeftPoint).Append("\n");
            sb.Append("  BtmRightPoint: ").Append(BtmRightPoint).Append("\n");
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
            return this.Equals(input as Viewport);
        }

        /// <summary>
        /// Returns true if Viewport instances are equal
        /// </summary>
        /// <param name="input">Instance of Viewport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Viewport input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TopLeftPoint == input.TopLeftPoint ||
                    (this.TopLeftPoint != null &&
                    this.TopLeftPoint.Equals(input.TopLeftPoint))
                ) && 
                (
                    this.BtmRightPoint == input.BtmRightPoint ||
                    (this.BtmRightPoint != null &&
                    this.BtmRightPoint.Equals(input.BtmRightPoint))
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
                if (this.TopLeftPoint != null)
                    hashCode = hashCode * 59 + this.TopLeftPoint.GetHashCode();
                if (this.BtmRightPoint != null)
                    hashCode = hashCode * 59 + this.BtmRightPoint.GetHashCode();
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