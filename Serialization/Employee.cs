using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Serialization
{
    //[Serializable]
    [XmlRoot("New Employees", Namespace = "www.nerdinc.ninja")]
    public class Employee
    {
        [XmlAttribute("Employee ID")]
        public int ID { get; set; }
        [XmlAttribute("Full Name")]
        public string Name { get; set; }
        [XmlAttribute("Social Security Number")]
        public double SSNumber { get; set; }
        [XmlAttribute("Today's Date")]
        public DateTime EntryDate { get; set; } //using DateTime methos. Predifined method in .NET Freamwork
        [XmlIgnore]
        public string JobRole { get; set; }
    }
}
