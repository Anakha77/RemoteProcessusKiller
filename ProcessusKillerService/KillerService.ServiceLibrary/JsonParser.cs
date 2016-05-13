using System.IO;
using System.Runtime.Serialization.Json;
using KillerService.Model;

namespace KillerService.ServiceLibrary
{
    public static class JsonParser
    {
        public static string Serialize(object obj)
        {
            using (var memStream = new MemoryStream())
            {
                var serializer = new DataContractJsonSerializer(obj.GetType());
                serializer.WriteObject(memStream, obj);
                memStream.Position = 0;
                using (var reader = new StreamReader(memStream))
                {
                    return reader.ReadToEnd();
                }
            }
        }

        public static void Deserialize(string json, out object obj)
        {
            using (var memStream = new MemoryStream())
            {
                using (var writer = new StreamWriter(memStream))
                {
                    writer.Write(json);
                    memStream.Position = 0;
                    var serializer = new DataContractJsonSerializer(typeof(ProcessusModel[]));
                    obj = serializer.ReadObject(memStream);
                }
            }
        }
    }
}
