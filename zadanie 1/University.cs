using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Serialization;

namespace zadanie_1
{
    [XmlRoot(ElementName = "uczelnia")]
    public class University
    {
        [XmlArray(elementName:"studenci")]
        [JsonPropertyName(name:"studenci")]
        public List<Student> Students { get; set; }
        
        [XmlAttribute]
        public string CreatedAt { get; set; }

        [XmlAttribute]
        public string Author { get; set; }

        [XmlArray(elementName: "activeStudies")]
        [JsonPropertyName(name:"activeStudies")]
        public List<Studies> ActiveStudies { get; set; }
    }
}