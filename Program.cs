using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace LabWork4
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }

        public static void WriteXML(Research r)
        {
            //Setting up XMLWriter to perform writing into our file
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = "\t";
            settings.ConformanceLevel = ConformanceLevel.Auto;

            //Creating a XMLWriter itslef using specified above settings
            XmlWriter writer = XmlWriter.Create("..\\..\\users.xml", settings);

            //Performing writing
            writer.WriteStartDocument();
            writer.WriteStartElement("Research");
            r.WriteXml(writer);
            writer.WriteEndElement();

            //Saving XML into the file
            writer.Flush();
            writer.Dispose();
        }

        public static void ReadXML(Research r)
        {
            XmlReader reader = XmlReader.Create("..\\..\\users.xml");

            reader.MoveToContent();
            r.ReadXml(reader);
            reader.Dispose();
            WriteXML(r);
        }
    }
}
