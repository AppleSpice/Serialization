﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml; // using xml reader
using System.Xml.Serialization; // used to create the XML Serialization
using System.IO; // This is needed for the TextWriter


namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();

            //emp.ID = 123;
            //emp.Name = "Gaven";
            //emp.SSNumber = 123456789;
            //emp.EntryDate = DateTime.Now;
            //emp.JobRole = "Candy";

            Console.WriteLine($"Employee ID: {emp.ID} \nEmployee Name: {emp.Name} \nEmployee SS# {emp.SSNumber} \nDate Created: {emp.EntryDate}");


            string FilePath = "C:/Temp/";
            string FileName = "part2.xml";

            //TextWriter writer = new StreamWriter(FilePath + FileName);

            //XmlSerializer ser = new XmlSerializer(typeof(Employee));

            //ser.Serialize(writer, emp);
            //writer.Close();

            XmlSerializer des = new XmlSerializer(typeof(Employee));
            using (XmlReader reader = XmlReader.Create(FilePath + FileName))
            {
                emp = (Employee)des.Deserialize(reader);
                Console.WriteLine($"Employee ID: {emp.ID} \nEmployee Name: {emp.Name} \nEmployee SS# {emp.SSNumber} \nDate Created: {emp.EntryDate}");
            }

            Console.ReadLine();
        }
    }
}
