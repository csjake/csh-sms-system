using System;
using System.Collections.Generic;
using System.Text;
using Utils;

namespace SurveyCTODownload
{
    public class SurveyCTODownloadConfig
    {
        [ConfigPromptName(Prompt = @"List of FormIds e.g. [""id1"", ""id2""]")]
        public List<string> FormIds { get; set; }
        [ConfigPromptName(Prompt = @"Survey CTO Username")]
        public string SurveyCtoUserName { get; set; }
        [ConfigPromptName(Prompt = @"Survey CTO Password")]
        public string SurveyCtoPassword { get; set; }
    }
}
