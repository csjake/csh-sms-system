using System;
using System.Collections.Generic;
using System.Text;
using Utils;
namespace TelerivetDownload
{
    public class TelerivetApiConfig
    {
        [ConfigPromptName(Prompt = "Telerivet API Key")]
        public string TelerivetAPIKey { get; set; }        
    }
}
