using System.Text.Json.Serialization;
using System.Xml.Serialization;
using Microsoft.VisualBasic.CompilerServices;

namespace zadanie_1
{
    public class Studies
    {
        [XmlElement(elementName:"name")]
        [JsonPropertyName(name:"name")]
        public string Major { get; set; }

        [XmlElement(elementName:"mode")]
        [JsonPropertyName(name:"mode")]
        public string Mode { get; set; }
        
        public bool ShouldSerializeMode()
        {
            return Mode != null;
        }

        [XmlElement(elementName: "numberOfStudents")]
        public int? NumberOfStudents { get; set; }

        public bool ShouldSerializeNumberOfStudents()
        {
            return NumberOfStudents.HasValue;
        }

        public override string ToString()
        {
            return $"{Major} {Mode}";
        }
    }
}