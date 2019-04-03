using System;
using System.Collections.Generic;
using System.Text;

namespace Utils
{
    [AttributeUsage(System.AttributeTargets.Property |
                       System.AttributeTargets.Field)]
    public class ConfigPromptName : Attribute
    {
        public string Prompt { get; set; }        
    }    
}
