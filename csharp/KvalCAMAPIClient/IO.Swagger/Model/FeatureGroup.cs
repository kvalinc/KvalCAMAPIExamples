/* 
 * KvalCAM API
 *
 * KvalCAM interactive API documentation  Additional documentation is available here: https://docs.kvalinc.com/display/CAM/API  Examples are available on github here: https://github.com/kvalinc/KvalCAMAPIExamples
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// FeatureGroup representing a set of anchor locations and tree of features
    /// </summary>
    [DataContract]
    public partial class FeatureGroup :  IEquatable<FeatureGroup>, IValidatableObject
    {
        /// <summary>
        /// T door reference for all child feature locations
        /// </summary>
        /// <value>T door reference for all child feature locations</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TDoorReferenceEnum
        {
            
            /// <summary>
            /// Enum KeySide for value: KeySide
            /// </summary>
            [EnumMember(Value = "KeySide")]
            KeySide = 1,
            
            /// <summary>
            /// Enum OppositeKeySide for value: OppositeKeySide
            /// </summary>
            [EnumMember(Value = "OppositeKeySide")]
            OppositeKeySide = 2,
            
            /// <summary>
            /// Enum HingePivot for value: HingePivot
            /// </summary>
            [EnumMember(Value = "HingePivot")]
            HingePivot = 3,
            
            /// <summary>
            /// Enum OppositeHingePivot for value: OppositeHingePivot
            /// </summary>
            [EnumMember(Value = "OppositeHingePivot")]
            OppositeHingePivot = 4
        }

        /// <summary>
        /// T door reference for all child feature locations
        /// </summary>
        /// <value>T door reference for all child feature locations</value>
        [DataMember(Name="TDoorReference", EmitDefaultValue=false)]
        public TDoorReferenceEnum? TDoorReference { get; set; }
        /// <summary>
        /// W door reference for all child feature locations
        /// </summary>
        /// <value>W door reference for all child feature locations</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum WDoorReferenceEnum
        {
            
            /// <summary>
            /// Enum Hinge for value: Hinge
            /// </summary>
            [EnumMember(Value = "Hinge")]
            Hinge = 1,
            
            /// <summary>
            /// Enum Lock for value: Lock
            /// </summary>
            [EnumMember(Value = "Lock")]
            Lock = 2
        }

        /// <summary>
        /// W door reference for all child feature locations
        /// </summary>
        /// <value>W door reference for all child feature locations</value>
        [DataMember(Name="WDoorReference", EmitDefaultValue=false)]
        public WDoorReferenceEnum? WDoorReference { get; set; }
        /// <summary>
        /// L door reference for all child feature locations
        /// </summary>
        /// <value>L door reference for all child feature locations</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LDoorReferenceEnum
        {
            
            /// <summary>
            /// Enum Top for value: Top
            /// </summary>
            [EnumMember(Value = "Top")]
            Top = 1,
            
            /// <summary>
            /// Enum Bottom for value: Bottom
            /// </summary>
            [EnumMember(Value = "Bottom")]
            Bottom = 2
        }

        /// <summary>
        /// L door reference for all child feature locations
        /// </summary>
        /// <value>L door reference for all child feature locations</value>
        [DataMember(Name="LDoorReference", EmitDefaultValue=false)]
        public LDoorReferenceEnum? LDoorReference { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureGroup" /> class.
        /// </summary>
        /// <param name="Name">Name of the feature group.</param>
        /// <param name="Description">Description of the feature group.</param>
        /// <param name="Id">Unique library id of the feature group.</param>
        /// <param name="Locations">Anchor locations for this feature group.</param>
        /// <param name="TDoorReference">T door reference for all child feature locations.</param>
        /// <param name="WDoorReference">W door reference for all child feature locations.</param>
        /// <param name="LDoorReference">L door reference for all child feature locations.</param>
        /// <param name="Children">Child features of the feature group.</param>
        public FeatureGroup(string Name = default(string), string Description = default(string), Guid? Id = default(Guid?), List<LWTLocation> Locations = default(List<LWTLocation>), TDoorReferenceEnum? TDoorReference = default(TDoorReferenceEnum?), WDoorReferenceEnum? WDoorReference = default(WDoorReferenceEnum?), LDoorReferenceEnum? LDoorReference = default(LDoorReferenceEnum?), List<AbstractFeature> Children = default(List<AbstractFeature>))
        {
            this.Name = Name;
            this.Description = Description;
            this.Id = Id;
            this.Locations = Locations;
            this.TDoorReference = TDoorReference;
            this.WDoorReference = WDoorReference;
            this.LDoorReference = LDoorReference;
            this.Children = Children;
        }
        
        /// <summary>
        /// Name of the feature group
        /// </summary>
        /// <value>Name of the feature group</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Description of the feature group
        /// </summary>
        /// <value>Description of the feature group</value>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Unique library id of the feature group
        /// </summary>
        /// <value>Unique library id of the feature group</value>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }

        /// <summary>
        /// Anchor locations for this feature group
        /// </summary>
        /// <value>Anchor locations for this feature group</value>
        [DataMember(Name="Locations", EmitDefaultValue=false)]
        public List<LWTLocation> Locations { get; set; }




        /// <summary>
        /// Child features of the feature group
        /// </summary>
        /// <value>Child features of the feature group</value>
        [DataMember(Name="Children", EmitDefaultValue=false)]
        public List<AbstractFeature> Children { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FeatureGroup {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Locations: ").Append(Locations).Append("\n");
            sb.Append("  TDoorReference: ").Append(TDoorReference).Append("\n");
            sb.Append("  WDoorReference: ").Append(WDoorReference).Append("\n");
            sb.Append("  LDoorReference: ").Append(LDoorReference).Append("\n");
            sb.Append("  Children: ").Append(Children).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as FeatureGroup);
        }

        /// <summary>
        /// Returns true if FeatureGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of FeatureGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FeatureGroup input)
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Locations == input.Locations ||
                    this.Locations != null &&
                    this.Locations.SequenceEqual(input.Locations)
                ) && 
                (
                    this.TDoorReference == input.TDoorReference ||
                    (this.TDoorReference != null &&
                    this.TDoorReference.Equals(input.TDoorReference))
                ) && 
                (
                    this.WDoorReference == input.WDoorReference ||
                    (this.WDoorReference != null &&
                    this.WDoorReference.Equals(input.WDoorReference))
                ) && 
                (
                    this.LDoorReference == input.LDoorReference ||
                    (this.LDoorReference != null &&
                    this.LDoorReference.Equals(input.LDoorReference))
                ) && 
                (
                    this.Children == input.Children ||
                    this.Children != null &&
                    this.Children.SequenceEqual(input.Children)
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Locations != null)
                    hashCode = hashCode * 59 + this.Locations.GetHashCode();
                if (this.TDoorReference != null)
                    hashCode = hashCode * 59 + this.TDoorReference.GetHashCode();
                if (this.WDoorReference != null)
                    hashCode = hashCode * 59 + this.WDoorReference.GetHashCode();
                if (this.LDoorReference != null)
                    hashCode = hashCode * 59 + this.LDoorReference.GetHashCode();
                if (this.Children != null)
                    hashCode = hashCode * 59 + this.Children.GetHashCode();
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