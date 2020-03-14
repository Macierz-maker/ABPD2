using System.Xml.Serialization;
using Microsoft.VisualBasic.CompilerServices;

namespace zadanie_1
{
    public class Studies
    {
        [XmlElement(elementName:"major")]
        public string Major { get; set; }

        [XmlElement(elementName:"mode")]
        public string Mode { get; set; }

        public override string ToString()
        {
            return $"{Major} {Mode}";
        }
    }
}