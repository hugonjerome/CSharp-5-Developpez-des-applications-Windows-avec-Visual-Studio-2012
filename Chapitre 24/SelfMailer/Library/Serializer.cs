using System.IO;
using System.Xml.Serialization;

namespace SelfMailer.Library
{
    public static class Serializer<T> where T : class
    {
        public static void Serialize(T o, string file)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            Stream stream = new FileStream(file, FileMode.Create);
            xmlSerializer.Serialize(stream, o);
            stream.Close();
            stream.Dispose();
        }
        public static T Deserialize(string file)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            Stream stream = new FileStream(file, FileMode.Open);
            T result = xmlSerializer.Deserialize(stream) as T;
            stream.Close();
            stream.Dispose();
            return result;
        }
    }
}
