using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DesignPatternsAlura.Adapter
{
    public class GeradorDeXml
    {
        public String GeraXml(object o)
        {
            XmlSerializer serializer = new XmlSerializer(o.GetType());
            StringWriter writer = new StringWriter();
            serializer.Serialize(writer, o);
            var xml = writer.ToString();


            return writer.ToString();
        }
    }
}
