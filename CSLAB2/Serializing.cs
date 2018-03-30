using System;
using System.Xml;
using System.Xml.XPath;
using System.Collections.Generic;

namespace ForTest
{
    public class Serializing
    {
        public static void SerializeIn(DateTime date1, DateTime date2)
        {
            List<DateTime> allDates = new List<DateTime>();
            for (DateTime date = date1; date <= date2; date = date.AddDays(1))
            {
                allDates.Add(date);
            }

            string path = @"C:\Users\skoch\source\repos\CSLAB2\Lab2.xml";
            var xml = new XmlDocument();
            XmlElement root = xml.CreateElement("AllYears");
            xml.AppendChild(root);

            XmlElement year = xml.CreateElement("Year");
            year.SetAttribute("Number", Convert.ToString(allDates[0].Year));
            root.AppendChild(year);

            XmlElement month = xml.CreateElement("Month");
            month.SetAttribute("Number", Convert.ToString(allDates[0].Month));
            year.AppendChild(month);

            XmlElement day = xml.CreateElement("Day");
            day.SetAttribute("Number", Convert.ToString(allDates[0].Day));
            month.AppendChild(day);

            for (int i = 1; i < (allDates.Count - 1); i++)
            {
                if (allDates[i].Year != Convert.ToInt32(year.GetAttribute("Number")))
                {
                    year = xml.CreateElement("Year");
                    year.SetAttribute("Number", Convert.ToString(allDates[i].Year));
                    root.AppendChild(year);
                }
                if (allDates[i].Month != Convert.ToInt32(month.GetAttribute("Number")))
                {
                    month = xml.CreateElement("Month");
                    month.SetAttribute("Number", Convert.ToString(allDates[i].Month));
                    year.AppendChild(month);
                }
                if (allDates[i].Day != Convert.ToInt32(day.GetAttribute("Number")))
                {
                    day = xml.CreateElement("Day");
                    day.SetAttribute("Number", Convert.ToString(allDates[i].Day));
                    month.AppendChild(day);
                }
            }
            xml.Save(path);

        }
        public static bool SerializeFrom()
        {
            Console.Clear();
            XPathDocument doc = new XPathDocument(@"C:\Users\skoch\source\repos\CSLAB2\Lab2.xml");
            XPathNavigator navigator = doc.CreateNavigator();
            XPathNodeIterator nodes = navigator.Select("//Day");
            int count = 0;
            while (nodes.MoveNext())
            {
                count++;
            }
            Console.WriteLine("The difference between days from the last query is {0} day(s)", count);
            return true;
        }
    }
}