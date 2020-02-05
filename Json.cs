using Newtonsoft.Json;
using System.IO;

namespace Can_I_do
{
    static class Json
    {
        public static void JsonSerialization(string path, object obj)
        {
            File.WriteAllText(path, JsonConvert.SerializeObject(obj));
        }
        public static void JsonDeserialization<T>(string path, ref T obj)
        {
            obj  = JsonConvert.DeserializeObject<T>(File.ReadAllText(path));
        }
    }
}
