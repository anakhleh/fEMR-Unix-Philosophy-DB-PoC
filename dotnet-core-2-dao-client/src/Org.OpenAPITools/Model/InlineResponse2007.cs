/* 
 * Femr Core
 *
 * Femr Core
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
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// InlineResponse2007
    /// </summary>
    [DataContract]
    public partial class InlineResponse2007 :  IEquatable<InlineResponse2007>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2007" /> class.
        /// </summary>
        /// <param name="descriptionColumns">descriptionColumns.</param>
        /// <param name="id">id.</param>
        /// <param name="labelColumns">labelColumns.</param>
        /// <param name="result">result.</param>
        /// <param name="showColumns">showColumns.</param>
        /// <param name="showTitle">showTitle.</param>
        public InlineResponse2007(Object descriptionColumns = default(Object), string id = default(string), Object labelColumns = default(Object), SubjectInfoModelApiGet result = default(SubjectInfoModelApiGet), List<string> showColumns = default(List<string>), string showTitle = default(string))
        {
            this.DescriptionColumns = descriptionColumns;
            this.Id = id;
            this.LabelColumns = labelColumns;
            this.Result = result;
            this.ShowColumns = showColumns;
            this.ShowTitle = showTitle;
        }
        
        /// <summary>
        /// Gets or Sets DescriptionColumns
        /// </summary>
        [DataMember(Name="description_columns", EmitDefaultValue=false)]
        public Object DescriptionColumns { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets LabelColumns
        /// </summary>
        [DataMember(Name="label_columns", EmitDefaultValue=false)]
        public Object LabelColumns { get; set; }

        /// <summary>
        /// Gets or Sets Result
        /// </summary>
        [DataMember(Name="result", EmitDefaultValue=false)]
        public SubjectInfoModelApiGet Result { get; set; }

        /// <summary>
        /// Gets or Sets ShowColumns
        /// </summary>
        [DataMember(Name="show_columns", EmitDefaultValue=false)]
        public List<string> ShowColumns { get; set; }

        /// <summary>
        /// Gets or Sets ShowTitle
        /// </summary>
        [DataMember(Name="show_title", EmitDefaultValue=false)]
        public string ShowTitle { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2007 {\n");
            sb.Append("  DescriptionColumns: ").Append(DescriptionColumns).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LabelColumns: ").Append(LabelColumns).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  ShowColumns: ").Append(ShowColumns).Append("\n");
            sb.Append("  ShowTitle: ").Append(ShowTitle).Append("\n");
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
            return this.Equals(input as InlineResponse2007);
        }

        /// <summary>
        /// Returns true if InlineResponse2007 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse2007 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2007 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DescriptionColumns == input.DescriptionColumns ||
                    (this.DescriptionColumns != null &&
                    this.DescriptionColumns.Equals(input.DescriptionColumns))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.LabelColumns == input.LabelColumns ||
                    (this.LabelColumns != null &&
                    this.LabelColumns.Equals(input.LabelColumns))
                ) && 
                (
                    this.Result == input.Result ||
                    (this.Result != null &&
                    this.Result.Equals(input.Result))
                ) && 
                (
                    this.ShowColumns == input.ShowColumns ||
                    this.ShowColumns != null &&
                    input.ShowColumns != null &&
                    this.ShowColumns.SequenceEqual(input.ShowColumns)
                ) && 
                (
                    this.ShowTitle == input.ShowTitle ||
                    (this.ShowTitle != null &&
                    this.ShowTitle.Equals(input.ShowTitle))
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
                if (this.DescriptionColumns != null)
                    hashCode = hashCode * 59 + this.DescriptionColumns.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LabelColumns != null)
                    hashCode = hashCode * 59 + this.LabelColumns.GetHashCode();
                if (this.Result != null)
                    hashCode = hashCode * 59 + this.Result.GetHashCode();
                if (this.ShowColumns != null)
                    hashCode = hashCode * 59 + this.ShowColumns.GetHashCode();
                if (this.ShowTitle != null)
                    hashCode = hashCode * 59 + this.ShowTitle.GetHashCode();
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