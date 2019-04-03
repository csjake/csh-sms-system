using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Utils
{
    public class JsonSerializeUtils
    {
        public static string SerializeToAppFolder(string fileName, object obj, Formatting formatting = Formatting.None)
        {
            var filePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
            var jstring = JsonConvert.SerializeObject(obj, formatting);
            System.IO.File.WriteAllText(filePath, jstring);
            return filePath;
        }

        //public static Dictionary<string, string> GetNotificationPropertiesFromMessageContent(string messageContent)
        //{
        //    JObject jobject = JObject.Parse(messageContent);
            
        //    return jobject.Descendants()
        //        .Where(j => j.Children().Count() == 0)
        //        .Aggregate(
        //            new Dictionary<string, string>(),
        //            (props, jtoken) =>
        //            {
        //                props.Add(jtoken.Path, jtoken.ToString());
        //                return props;
        //            });
        //}
    }
}
