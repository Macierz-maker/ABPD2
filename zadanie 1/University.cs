using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace zadanie_1
{
    [XmlRoot(ElementName = "uczelnia")]
    public class University
    {
        [XmlArray(elementName:"studenci")]
        public List<Student> Students { get; set; }
        
        [XmlAttribute]
        public DateTime CreatedAt { get; set; }

        [XmlAttribute]
        public string Author { get; set; }
    }
}