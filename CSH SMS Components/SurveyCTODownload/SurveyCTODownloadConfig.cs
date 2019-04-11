using System;
using System.Collections.Generic;
using System.Text;
using Utils;

namespace SurveyCTODownload
{
    public class SurveyCTODownloadConfig
    {       
        [ConfigPromptName(Prompt = @"Survey CTO Username")]
        public string SurveyCtoUserName { get; set; }
        [ConfigPromptName(Prompt = @"Survey CTO Password")]
        public string SurveyCtoPassword { get; set; }
    }
}
