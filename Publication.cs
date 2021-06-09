using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;

namespace LabWork4
{
    class Publication
    {
        private Student student;
        private ScientificAchievements type;

        public Student Student
        {
            get { return student; }
            set { student = value; }
        }

        public ScientificAchievements Type
        {
            get { return type; }
            set { type = value; }
        }

        public Publication()
        {
            Student = new Student();
        }

        public Publication (Student s, ScientificAchievements sa)
        {
            Student = s;
            Type = sa;
        }
        public Publication(string fn, string ln, int ey, ScientificAchievements sa)
        {
            Student = new Student(fn, ln, ey);
            Type = sa;
        }
        public void EditPublication (string fn, string ln, int ey, ScientificAchievements sa)
        {
            Student = new Student(fn, ln, ey);
            Type = sa;
        }


        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            if (reader.MoveToContent() == XmlNodeType.Element && reader.LocalName == "Publication")
            {
                reader.Read();
                student.ReadXml(reader);
                reader.Read();
                if (reader.MoveToContent() == XmlNodeType.Element && reader.LocalName == "Type")
                {
                    Enum.TryParse(reader.ReadElementContentAsString(), out type);
                }
                reader.Read();
            }
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteStartElement("Student");
            Student.WriteXml(writer);
            writer.WriteEndElement();
            writer.WriteElementString("Type", type.ToString());
        }
    }
}
