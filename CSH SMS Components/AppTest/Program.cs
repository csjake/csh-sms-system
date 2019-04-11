using MasterDatabase;
using Microsoft.EntityFrameworkCore;
using SurveyCTODownload;
using System;
using TelerivetDownload;

namespace AppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //testTelerivet();
            //var optionsBuilder = new DbContextOptionsBuilder<MasterDatabaseContext>();
            //optionsBuilder.UseSqlite(@"DataSource=G:\Team Drives\Reporting_Restricted\CSH\Master\dev.db");
            //var db = new MasterDatabaseContext(optionsBuilder.Options);
            //db.Database.EnsureCreated();                                        
            //var conf = Utils.ConfigUtils.LoadOrPrompt<SurveyCTODownload.SurveyCTODownloadConfig>();
            //try
            //{
            //    var surveys = FormDataDownloader.DownloadPartnerSurvey20190223(conf);

            //} catch (Exception ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //}
            nexmoContactsAdd();
            Console.ReadLine();
        }

        static void testTelerivet()
        {
            var conf = Utils.ConfigUtils.LoadOrPrompt<TelerivetDownload.TelerivetApiConfig>();
            ContactAndGroupDownloader.DownloadV2(conf);
            Console.ReadLine();
        }

        public static void nexmoContactsAdd()
        {
            string[] contactIds = { "CT036140bc0bea14e9", "CTbf7120cc320bfe94", "CT692d4fb727a48838", "CTe7f03ecbe7fa2fdc", "CT0df7fd0c41536146", "CT959c7c7c2f356933", "CT76f6efbe400838d1", "CTf3cd2579a78a282b", "CT9bd1a136b96a3f40", "CT142f7f553c289ae2", "CT6bcda2ccf2a1a3da", "CTedd129b36fcb43a4", "CT36ec76d9a89ff2e2", "CT825850be22e9693b", "CT34fc84f73315e820", "CT1763e2d119124a50", "CTbe6b628934cd0db5", "CTbc7c736bdf03be40", "CTae9930f5781464df", "CT7dd10f3f380e9781", "CT187a8759ba79589f", "CT0d994be10883c00f", "CT146a011c767de25d", "CT90c0d7acc03b53ee", "CTbbeb5d223c54ee8b", "CT209d578fa9d559d7", "CT37715a5149a2a053", "CT2b1e0efe63e9573d", "CT03d985df6d0e266a", "CT301ace06789d92a0", "CT80e85364faa73111", "CTb4bac24806d52fe8", "CTa65d4a180e73f195", "CT86dbf97041e5261f", "CTbcf0156bd46425f7", "CT3f13805f39af20b5" };
            var conf = Utils.ConfigUtils.LoadOrPrompt<TelerivetDownload.TelerivetApiConfig>();
            var groupId = "CG225729c681810083";
            ContactGroupAdd.AddContactsToGroups(conf, contactIds, groupId);
        }
    }
}
