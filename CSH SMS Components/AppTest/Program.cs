using System;
using TelerivetDownload;

namespace AppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            testTelerivet();
            //var conf = Utils.ConfigUtils.LoadOrPrompt<SurveyCTODownload.SurveyCTODownloadConfig>();
            
            //Console.ReadLine();
        }

        static void testTelerivet()
        {
            var conf = Utils.ConfigUtils.LoadOrPrompt<TelerivetDownload.TelerivetApiConfig>();
            ContactDownloader.Test(conf);
            Console.ReadLine();
        }
    }
}
