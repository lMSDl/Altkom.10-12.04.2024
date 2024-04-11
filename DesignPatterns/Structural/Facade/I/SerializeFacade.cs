using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._10_12._04._2024.DesignPatterns.Structural.Facade.I
{
    internal static class SerializeFacade
    {
        static JsonSerializerSettings _settings = new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore,
            DefaultValueHandling = DefaultValueHandling.Ignore,
            PreserveReferencesHandling = PreserveReferencesHandling.Objects,
            DateFormatString = "yy MM d"
        };

        public static string Serialize<T>(T obj)
        {
            return JsonConvert.SerializeObject(obj, _settings);
        }
    }
}
