using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;

namespace LabWork4
{
    class Research
    {
        private Customer customer;
        private DateTime date;
        private List<Publication> publications = new List<Publication>();

        public Customer Customer
        {
            get { return customer; }
            set { customer = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public List<Publication> Publications
        {
            get { return publications; }
        }

        public Research ()
        {
            Customer = new Customer();
        }
        public Research (Customer c, DateTime dt)
        {
            Customer = c;
            Date = dt;
        }

        public void AddPublication (Publication p)
        {
            publications.Add(p);
        }
        public void AddPublication(string fn, string ln, int ey, ScientificAchievements sa)
        {
            publications.Add(new Publication(fn, ln, ey, sa));
        }

        public string ToShortString()
        {
            return String.Format("Тема дослідження: {0} \nКількість публікацій: {1}", customer.ResearchTopic, publications.Count().ToString());
        }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            if (reader.MoveToContent() == XmlNodeType.Element && reader.LocalName == "Research")
            {
                reader.Read();
                customer.ReadXml(reader);
                reader.Read();
                if (reader.MoveToContent() == XmlNodeType.Element && reader.LocalName == "Date")
                {
                    date = DateTime.Parse(reader.ReadElementContentAsString());
                }
                if (reader.MoveToContent() == XmlNodeType.Element && reader.LocalName == "Publication")
                {
                    while (reader.MoveToContent() == XmlNodeType.Element && reader.LocalName == "Publication")
                    {
                        Publication p = new Publication();
                        p.ReadXml(reader);
                        publications.Add(p);
                        reader.Read();
                    }
                }
            }
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteStartElement("Customer");
                Customer.WriteXml(writer);
            writer.WriteEndElement();
            writer.WriteElementString("Date", Date.ToString("dd/MM/yyyy"));
                foreach (Publication p in Publications)
                {
                    writer.WriteStartElement("Publication");
                        p.WriteXml(writer);
                    writer.WriteEndElement();
                }
        }
    }
}
