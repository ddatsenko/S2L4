using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;

namespace LabWork4
{
    class Customer
    {
        private string compname;
        private string topic;
        private int cost;

        public string CompanyName
        {
            get { return compname; }
            set { compname = value; }
        }
        public string ResearchTopic
        {
            get { return topic; }
            set { topic = value; }
        }
        public int Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        public Customer () {
        }
        public Customer (string cn, string rt, int c)
        {
            CompanyName = cn;
            ResearchTopic = rt;
            Cost = c;
        }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            if (reader.MoveToContent() == XmlNodeType.Element && reader.LocalName == "Customer")
            {
                compname = reader["CompanyName"];
                reader.Read();
                if (reader.MoveToContent() == XmlNodeType.Element && reader.LocalName == "ResearchTopic")
                {
                    topic = reader.ReadElementContentAsString();
                }
                reader.Read();
                if (reader.MoveToContent() == XmlNodeType.Element && reader.LocalName == "Cost")
                {
                    cost = int.Parse(reader.ReadElementContentAsString());
                }
                reader.Read();
            }
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteAttributeString("CompanyName", CompanyName);
            writer.WriteElementString("ResearchTopic", ResearchTopic);
            writer.WriteElementString("Cost",Cost.ToString());
        }
    }
}
