using System.Xml.Serialization;

namespace zadanie_1
{
    public class Student
    {
        [XmlElement(elementName:"fname")]
        public string FirstName { get; set; }

        [XmlElement(elementName:"lname")]
        public string LastName { get; set; }

        [XmlElement(elementName:"studies")]
        public Studies Studies { get; set; }

        [XmlAttribute(attributeName:"indexNumber")]
        public string IndexNumber { get; set; }

        [XmlElement(elementName:"birthdate")]
        public string Birthday { get; set; }

        [XmlElement(elementName:"email")]
        public string Email { get; set; }

        [XmlElement(elementName:"mothersName")]
        public string MotherName { get; set; }

        [XmlElement(elementName:"fathersName")]
        public string FatherName { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {Studies} {IndexNumber} {Birthday} {Email} {MotherName} {FatherName}";
        }
    }
    
}