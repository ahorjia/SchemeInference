using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;

namespace InferSchema
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlReader reader = XmlReader.Create(@"..\..\..\..\..\XML\Sample1.xml");
            XmlSchemaSet schemaSet = new XmlSchemaSet();
            XmlSchemaInference schema = new XmlSchemaInference();

            schemaSet = schema.InferSchema(reader);

            System.Diagnostics.Debug.Assert(schemaSet.Schemas().Count == 1);
            XmlSchema schema = schemaSet.Schemas();
            {
                System.IO.File.WriteAllText(@"..\..\..\..\..\XML\Sample1.xsd", s.ToString());

                s.Write(Console.Out);
            }
        }
    }
}
