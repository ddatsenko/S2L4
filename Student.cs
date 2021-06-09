using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace LabWork4
{
    public class Student
    {
        private string fname;
        private string lname;
        private int enryear;

        public string FirstName
        {
            get { return fname; }
            set { fname = value; }
        }
        public string LastName
        {
            get { return lname; }
            set { lname = value; }
        }
        public int EnrollmentYear
        {
            get { return enryear; }
            set { enryear = value; }
        }

        public Student ()
        {

        }
        public Student (string fn, string ln, int ey) {
            FirstName = fn;
            LastName = ln;
            EnrollmentYear = ey;
        }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            if (reader.MoveToContent() == XmlNodeType.Element && reader.LocalName == "Student")
            {
                fname = reader["FirstName"];
                lname = reader["LastName"];
                reader.Read();
                if (reader.MoveToContent() == XmlNodeType.Element && reader.LocalName == "EnrollmentYear")
                {
                    enryear = int.Parse(reader.ReadElementContentAsString());
                }
                reader.Read();
            }
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteAttributeString("FirstName", FirstName);
            writer.WriteAttributeString("LastName", LastName);
            writer.WriteElementString("EnrollmentYear", EnrollmentYear.ToString());
        }
    }
}
