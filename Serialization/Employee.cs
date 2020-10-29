using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Serialization
{
    [Serializable]
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double SSNumber { get; set; }
        public DateTime EntryDate { get; set; } //using DateTime methos. Predifined method in .NET Freamwork
    }
}
