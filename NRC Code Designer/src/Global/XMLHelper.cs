using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NRC_Code_Designer.src.Global
{
    /// <summary>
    /// Helper for xml data.
    /// </summary>
    static class XMLHelper
    {
        /// <summary>
        /// Static method to create an object from desserialization. 
        /// </summary>
        /// <typeparam name="T">Type to create from 
        ///                             desserialization.</typeparam>
        /// <param name="xmlFileName">Xml file full path.</param>
        /// <returns></returns>
        public static T DesSerializeObjectXml<T>(string xmlFileName) where T : class
        {

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

            FileStream ReadFileStream =
                new FileStream(xmlFileName,
                               FileMode.Open,
                               FileAccess.Read,
                               FileShare.Read);

            T genericObject =
                new XmlSerializer(typeof(T)).Deserialize(ReadFileStream) as T;

            ReadFileStream.Close();

            return genericObject;
        }

        /// <summary>
        /// Static method to serialize an object to a xml string.
        /// </summary>
        /// <param name="obj">Object to serialize.</param>
        /// <returns></returns>
        public static string SerializeObject2Xml(object obj)
        {
            XmlSerializer xmloutSerializer = new XmlSerializer(obj.GetType());
            using (var textWriter = new Utf8StringWriter())
            {
                xmloutSerializer.Serialize(textWriter, obj);

                return textWriter.ToString();
            }
        }

        /// <summary>
        /// Class that extends StringWriter to enable Utf8.
        /// </summary>
        private class Utf8StringWriter : StringWriter
        {
            public override Encoding Encoding
            {
                get { return Encoding.UTF8; }
            }
        }
    }
}
