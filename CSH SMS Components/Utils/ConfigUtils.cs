using Newtonsoft.Json;
using System;
using System.Linq;

namespace Utils
{
    public class ConfigUtils
    {
        public static T LoadOrPrompt<T>() where T : class, new()
        {                        
            var configFilePath = System.IO.Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory, 
                typeof(T).Name + ".conf.js");
            return LoadOrPrompt<T>(configFilePath);
        }
        public static T LoadOrPrompt<T>(string filePath) where T : class, new()
        {
            T conf = null;
            while(conf == null)
            {
                if (System.IO.File.Exists(filePath))
                {
                    var jsonConfig = System.IO.File.ReadAllText(filePath);
                    Console.WriteLine("Config loaded from file '" + filePath + "'");
                    Console.WriteLine(jsonConfig);
                    Console.WriteLine("Press Y to accept");
                    if (Console.ReadKey().KeyChar.ToString().ToUpper() == "Y")
                    {
                        conf = JsonConvert.DeserializeObject<T>(System.IO.File.ReadAllText(filePath));
                    }
                    Console.WriteLine();
                }

                if (conf == null)
                {
                    conf = new T();
                    Type t = typeof(T);
                    //property/prompt mapping 
                    var mappings = (from prop in t.GetProperties()
                                    select new {
                                        prop,
                                        attr = (ConfigPromptName)prop.GetCustomAttributes(false).SingleOrDefault(c => c is ConfigPromptName)
                                    }).Where(m => m.attr != null);

                    foreach (var mapping in mappings)
                    {                       
                        Console.Write(mapping.attr.Prompt + ": ");
                        var userValue = Console.ReadLine();

                        bool readSuccess = false;
                        while (readSuccess == false)
                        {                           
                            try
                            {
                                Object value = null;
                                if (mapping.prop.PropertyType.GetInterface("IConvertible") != null)
                                {
                                    value = Convert.ChangeType(userValue, mapping.prop.PropertyType);
                                }
                                else
                                {
                                    value = JsonConvert.DeserializeObject(userValue, mapping.prop.PropertyType);//
                                }
                                mapping.prop.SetValue(conf, value);
                                readSuccess = true;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Error: could not convert " + userValue + " to " + mapping.prop.PropertyType.Name);
                                Console.Write(mapping.attr.Prompt + ": ");
                                userValue = Console.ReadLine();
                            }
                        }
                    }

                    var jstring = JsonConvert.SerializeObject(conf, Formatting.Indented);
                    System.IO.File.WriteAllText(filePath, jstring);
                    conf = null; // this will prompt to verify again
                };
            }
            
            return conf;
        }

        public static T Load<T>(string filePath) where T : class
        {
            var jsonConfig = System.IO.File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<T>(System.IO.File.ReadAllText(filePath));
        }
    }
}
