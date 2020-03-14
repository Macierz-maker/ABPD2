using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace zadanie_1
{
    public class Student
    {
        [XmlElement(elementName: "fname")]
        [JsonPropertyName(name: "fname")]
        public string FirstName { get; set; }

        [XmlElement(elementName: "lname")]
        [JsonPropertyName(name: "lname")]
        public string LastName { get; set; }

        [XmlElement(elementName: "studies")]
        [JsonPropertyName(name: "studies")]
        public Studies Studies { get; set; }

        [XmlAttribute(attributeName: "indexNumber")]
        [JsonPropertyName(name: "indexNumber")]
        public string IndexNumber { get; set; }

        [XmlElement(elementName: "birthdate")]
        [JsonPropertyName(name: "birthdate")]
        public string Birthday { get; set; }

        [XmlElement(elementName: "email")]
        [JsonPropertyName(name: "email")]
        public string Email { get; set; }

        [XmlElement(elementName: "mothersName")]
        [JsonPropertyName(name: "mothersName")]
        public string MotherName { get; set; }

        [XmlElement(elementName: "fathersName")]
        [JsonPropertyName(name: "fathersName")]
        public string FatherName { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {Studies} {IndexNumber} {Birthday} {Email} {MotherName} {FatherName}";
        }
    }
}