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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Base feature type that all features inherit from, this type is never usable directly, but is used in arrays to represent a collection of different feature types (e.g. Rectangle, Circle, etc.), the \&quot;Type\&quot; json field is used to discriminate the type
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(Rectangle), "Rectangle")]
    [JsonSubtypes.KnownSubType(typeof(FaceCircle), "FaceCircle")]
    [JsonSubtypes.KnownSubType(typeof(TeeShape), "TeeShape")]
    [JsonSubtypes.KnownSubType(typeof(Circle), "Circle")]
    [JsonSubtypes.KnownSubType(typeof(Hinge), "Hinge")]
    [JsonSubtypes.KnownSubType(typeof(FaceRectangle), "FaceRectangle")]
    public partial class AbstractFeature :  IEquatable<AbstractFeature>, IValidatableObject
    {
        /// <summary>
        /// The side of the door this feature is placed on
        /// </summary>
        /// <value>The side of the door this feature is placed on</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DoorSideEnum
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
            Lock = 2,
            
            /// <summary>
            /// Enum Top for value: Top
            /// </summary>
            [EnumMember(Value = "Top")]
            Top = 3,
            
            /// <summary>
            /// Enum Bottom for value: Bottom
            /// </summary>
            [EnumMember(Value = "Bottom")]
            Bottom = 4,
            
            /// <summary>
            /// Enum Face for value: Face
            /// </summary>
            [EnumMember(Value = "Face")]
            Face = 5,
            
            /// <summary>
            /// Enum HingeJamb for value: HingeJamb
            /// </summary>
            [EnumMember(Value = "HingeJamb")]
            HingeJamb = 6,
            
            /// <summary>
            /// Enum LockJamb for value: LockJamb
            /// </summary>
            [EnumMember(Value = "LockJamb")]
            LockJamb = 7
        }

        /// <summary>
        /// The side of the door this feature is placed on
        /// </summary>
        /// <value>The side of the door this feature is placed on</value>
        [DataMember(Name="DoorSide", EmitDefaultValue=false)]
        public DoorSideEnum? DoorSide { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractFeature" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AbstractFeature() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractFeature" /> class.
        /// </summary>
        /// <param name="Name">Name of the feature.</param>
        /// <param name="Description">Short description of the feature.</param>
        /// <param name="TLocation">T-axis location of the feature relative to parent feature or feauture group location.</param>
        /// <param name="WLocation">W-axis location of the feature relative to parent feature or feature group location.</param>
        /// <param name="LLocation">L-axis location of the feature relative to parent feature or feature group location.</param>
        /// <param name="DoorSide">The side of the door this feature is placed on.</param>
        /// <param name="Children">Child features for this feature.</param>
        /// <param name="Type">Type discriminator to disambiguate the feature type object, must be the same as the feature type name, see feature types: \&quot;Circle\&quot;, \&quot;Rectangle\&quot;, \&quot;Hinge\&quot;, \&quot;TeeShape\&quot;, \&quot;FaceRectangle\&quot;, \&quot;FaceCircle\&quot; (required) (default to &quot;Circle&quot;).</param>
        public AbstractFeature(string Name = default(string), string Description = default(string), string TLocation = default(string), string WLocation = default(string), string LLocation = default(string), DoorSideEnum? DoorSide = default(DoorSideEnum?), List<AbstractFeature> Children = default(List<AbstractFeature>), string Type = "Circle")
        {
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for AbstractFeature and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            this.Name = Name;
            this.Description = Description;
            this.TLocation = TLocation;
            this.WLocation = WLocation;
            this.LLocation = LLocation;
            this.DoorSide = DoorSide;
            this.Children = Children;
        }
        
        /// <summary>
        /// Name of the feature
        /// </summary>
        /// <value>Name of the feature</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Short description of the feature
        /// </summary>
        /// <value>Short description of the feature</value>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// T-axis location of the feature relative to parent feature or feauture group location
        /// </summary>
        /// <value>T-axis location of the feature relative to parent feature or feauture group location</value>
        [DataMember(Name="TLocation", EmitDefaultValue=false)]
        public string TLocation { get; set; }

        /// <summary>
        /// W-axis location of the feature relative to parent feature or feature group location
        /// </summary>
        /// <value>W-axis location of the feature relative to parent feature or feature group location</value>
        [DataMember(Name="WLocation", EmitDefaultValue=false)]
        public string WLocation { get; set; }

        /// <summary>
        /// L-axis location of the feature relative to parent feature or feature group location
        /// </summary>
        /// <value>L-axis location of the feature relative to parent feature or feature group location</value>
        [DataMember(Name="LLocation", EmitDefaultValue=false)]
        public string LLocation { get; set; }


        /// <summary>
        /// Child features for this feature
        /// </summary>
        /// <value>Child features for this feature</value>
        [DataMember(Name="Children", EmitDefaultValue=false)]
        public List<AbstractFeature> Children { get; set; }

        /// <summary>
        /// Type discriminator to disambiguate the feature type object, must be the same as the feature type name, see feature types: \&quot;Circle\&quot;, \&quot;Rectangle\&quot;, \&quot;Hinge\&quot;, \&quot;TeeShape\&quot;, \&quot;FaceRectangle\&quot;, \&quot;FaceCircle\&quot;
        /// </summary>
        /// <value>Type discriminator to disambiguate the feature type object, must be the same as the feature type name, see feature types: \&quot;Circle\&quot;, \&quot;Rectangle\&quot;, \&quot;Hinge\&quot;, \&quot;TeeShape\&quot;, \&quot;FaceRectangle\&quot;, \&quot;FaceCircle\&quot;</value>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AbstractFeature {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  TLocation: ").Append(TLocation).Append("\n");
            sb.Append("  WLocation: ").Append(WLocation).Append("\n");
            sb.Append("  LLocation: ").Append(LLocation).Append("\n");
            sb.Append("  DoorSide: ").Append(DoorSide).Append("\n");
            sb.Append("  Children: ").Append(Children).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as AbstractFeature);
        }

        /// <summary>
        /// Returns true if AbstractFeature instances are equal
        /// </summary>
        /// <param name="input">Instance of AbstractFeature to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AbstractFeature input)
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
                    this.TLocation == input.TLocation ||
                    (this.TLocation != null &&
                    this.TLocation.Equals(input.TLocation))
                ) && 
                (
                    this.WLocation == input.WLocation ||
                    (this.WLocation != null &&
                    this.WLocation.Equals(input.WLocation))
                ) && 
                (
                    this.LLocation == input.LLocation ||
                    (this.LLocation != null &&
                    this.LLocation.Equals(input.LLocation))
                ) && 
                (
                    this.DoorSide == input.DoorSide ||
                    (this.DoorSide != null &&
                    this.DoorSide.Equals(input.DoorSide))
                ) && 
                (
                    this.Children == input.Children ||
                    this.Children != null &&
                    this.Children.SequenceEqual(input.Children)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.TLocation != null)
                    hashCode = hashCode * 59 + this.TLocation.GetHashCode();
                if (this.WLocation != null)
                    hashCode = hashCode * 59 + this.WLocation.GetHashCode();
                if (this.LLocation != null)
                    hashCode = hashCode * 59 + this.LLocation.GetHashCode();
                if (this.DoorSide != null)
                    hashCode = hashCode * 59 + this.DoorSide.GetHashCode();
                if (this.Children != null)
                    hashCode = hashCode * 59 + this.Children.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}