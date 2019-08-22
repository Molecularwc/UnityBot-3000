using System.IO;
using Newtonsoft.Json;

namespace UnityBot_3000.Storage.Implementations
{
    public class JsonStorage : IDataStorage
    {
        public void StoreObject(object obj, string key)
        {
            var file = $"{key}.json";
            Directory.CreateDirectory(file);
        }

        public T RestoreObject<T>(string key)
        {
            var json = File.ReadAllText($"{key}.json");
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
