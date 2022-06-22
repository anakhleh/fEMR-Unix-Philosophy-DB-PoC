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
    /// InlineResponse2002
    /// </summary>
    [DataContract]
    public partial class InlineResponse2002 :  IEquatable<InlineResponse2002>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2002" /> class.
        /// </summary>
        /// <param name="descriptionColumns">descriptionColumns.</param>
        /// <param name="ids">ids.</param>
        /// <param name="labelColumns">labelColumns.</param>
        /// <param name="listColumns">listColumns.</param>
        /// <param name="listTitle">listTitle.</param>
        /// <param name="orderColumns">orderColumns.</param>
        /// <param name="result">result.</param>
        public InlineResponse2002(Object descriptionColumns = default(Object), List<string> ids = default(List<string>), Object labelColumns = default(Object), List<string> listColumns = default(List<string>), string listTitle = default(string), List<string> orderColumns = default(List<string>), List<SubjectModelApiGetList> result = default(List<SubjectModelApiGetList>))
        {
            this.DescriptionColumns = descriptionColumns;
            this.Ids = ids;
            this.LabelColumns = labelColumns;
            this.ListColumns = listColumns;
            this.ListTitle = listTitle;
            this.OrderColumns = orderColumns;
            this.Result = result;
        }
        
        /// <summary>
        /// Gets or Sets DescriptionColumns
        /// </summary>
        [DataMember(Name="description_columns", EmitDefaultValue=false)]
        public Object DescriptionColumns { get; set; }

        /// <summary>
        /// Gets or Sets Ids
        /// </summary>
        [DataMember(Name="ids", EmitDefaultValue=false)]
        public List<string> Ids { get; set; }

        /// <summary>
        /// Gets or Sets LabelColumns
        /// </summary>
        [DataMember(Name="label_columns", EmitDefaultValue=false)]
        public Object LabelColumns { get; set; }

        /// <summary>
        /// Gets or Sets ListColumns
        /// </summary>
        [DataMember(Name="list_columns", EmitDefaultValue=false)]
        public List<string> ListColumns { get; set; }

        /// <summary>
        /// Gets or Sets ListTitle
        /// </summary>
        [DataMember(Name="list_title", EmitDefaultValue=false)]
        public string ListTitle { get; set; }

        /// <summary>
        /// Gets or Sets OrderColumns
        /// </summary>
        [DataMember(Name="order_columns", EmitDefaultValue=false)]
        public List<string> OrderColumns { get; set; }

        /// <summary>
        /// Gets or Sets Result
        /// </summary>
        [DataMember(Name="result", EmitDefaultValue=false)]
        public List<SubjectModelApiGetList> Result { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2002 {\n");
            sb.Append("  DescriptionColumns: ").Append(DescriptionColumns).Append("\n");
            sb.Append("  Ids: ").Append(Ids).Append("\n");
            sb.Append("  LabelColumns: ").Append(LabelColumns).Append("\n");
            sb.Append("  ListColumns: ").Append(ListColumns).Append("\n");
            sb.Append("  ListTitle: ").Append(ListTitle).Append("\n");
            sb.Append("  OrderColumns: ").Append(OrderColumns).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
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
            return this.Equals(input as InlineResponse2002);
        }

        /// <summary>
        /// Returns true if InlineResponse2002 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse2002 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2002 input)
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
                    this.Ids == input.Ids ||
                    this.Ids != null &&
                    input.Ids != null &&
                    this.Ids.SequenceEqual(input.Ids)
                ) && 
                (
                    this.LabelColumns == input.LabelColumns ||
                    (this.LabelColumns != null &&
                    this.LabelColumns.Equals(input.LabelColumns))
                ) && 
                (
                    this.ListColumns == input.ListColumns ||
                    this.ListColumns != null &&
                    input.ListColumns != null &&
                    this.ListColumns.SequenceEqual(input.ListColumns)
                ) && 
                (
                    this.ListTitle == input.ListTitle ||
                    (this.ListTitle != null &&
                    this.ListTitle.Equals(input.ListTitle))
                ) && 
                (
                    this.OrderColumns == input.OrderColumns ||
                    this.OrderColumns != null &&
                    input.OrderColumns != null &&
                    this.OrderColumns.SequenceEqual(input.OrderColumns)
                ) && 
                (
                    this.Result == input.Result ||
                    this.Result != null &&
                    input.Result != null &&
                    this.Result.SequenceEqual(input.Result)
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
                if (this.Ids != null)
                    hashCode = hashCode * 59 + this.Ids.GetHashCode();
                if (this.LabelColumns != null)
                    hashCode = hashCode * 59 + this.LabelColumns.GetHashCode();
                if (this.ListColumns != null)
                    hashCode = hashCode * 59 + this.ListColumns.GetHashCode();
                if (this.ListTitle != null)
                    hashCode = hashCode * 59 + this.ListTitle.GetHashCode();
                if (this.OrderColumns != null)
                    hashCode = hashCode * 59 + this.OrderColumns.GetHashCode();
                if (this.Result != null)
                    hashCode = hashCode * 59 + this.Result.GetHashCode();
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