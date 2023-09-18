using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bibalala.Models
{
	public static class JsonUtils
	{
        public static string Get(this JObject json, string path)
        {
            var token = json.SelectToken(path);
            if (token == null) return null;
            return token.ToString();
        }

        public static T Get<T>(this JObject json, string path)
        {
            var token = json.SelectToken(path);
            if (token == null) return default;
            return (T)Convert.ChangeType(token.ToString(), typeof(T));

        }
    }
}
