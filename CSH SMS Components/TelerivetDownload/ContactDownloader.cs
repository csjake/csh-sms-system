//using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using Telerivet.Client;
using ChoETL;
using Utils;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TelerivetDownload
{
    public class ContactDownloader
    {
        public static void Test(TelerivetApiConfig conf)
        {
            TelerivetAPI tr = new TelerivetAPI(conf.TelerivetAPIKey);
            Project project = tr.InitProjectById(conf.TelerivetProjectID);

            var result = (from c in project.QueryContacts().AllAsync().Result select new MasterDatabase.TelerivetContact {
                ContactId = c.Id,
                SendBlocked = c.SendBlocked,
                TimeCreated = DateTimeUnixTimeStampConverter.ToDateTime(c.TimeCreated),
                LastContacted = DateTimeUnixTimeStampConverter.ToDateTime(c.LastOutgoingMessageTime.GetValueOrDefault()),
                LastHeardFrom = DateTimeUnixTimeStampConverter.ToDateTime(c.LastIncomingMessageTime.GetValueOrDefault()),
                OutgoingMessageCount = c.OutgoingMessageCount,
                IncomingMessageCount = c.IncomingMessageCount,
                PhoneNumber = c.PhoneNumber,
                Name = c.Name,
                ProjectId = c.ProjectId,
                MotherName = c.Vars.Get("mother_name")?.ToString(),
                ChildName = c.Vars.Get("child_name")?.ToString(),
                MmrBaseDate = DateTimeTelerivetTimeStringConverter.ToDateTimeNullable(c.Vars.Get("mmr_base_date")?.ToString()),
                PentaBaseDate = DateTimeTelerivetTimeStringConverter.ToDateTimeNullable(c.Vars.Get("penta_base_date")?.ToString()),
                PrenatalBaseDate = DateTimeTelerivetTimeStringConverter.ToDateTimeNullable(c.Vars.Get("prenatal_base_date")?.ToString()),
                SourceTime = DateTimeTelerivetTimeStringConverter.ToDateTime(c.Vars.Get("source_date").ToString()),
                SourceType = c.Vars.Get("source_type").ToString(),
                SourceKey = c.Vars.Get("source_key").ToString(),
                GroupIds = c.GroupIds.ToString(),
            }).ToList();

            Console.WriteLine("test");

            //var queryOptions = new
            //{
            //    page_size = 200,
            //    marker = "",
            //};
            //var jOptions = JObject.FromObject(queryOptions)

            //var contacts = project.QueryContacts().AllAsync().Result;
            //Contact c = null;
            //foreach(var contact in contacts)
            //{
            //    //flatten - old version of newtonsoft required by telerivet means we can't use linq
            //    var contactDic = contact.ToDictionary();
            //    var vars = contact.Vars;
            //    contactDic.Remove("Vars");

            //    var varsDic = new Dictionary<string, object>();
            //    foreach (var prop in vars.all().Properties())
            //    {
            //        varsDic.Add(prop.Name, vars.Get(prop.Name));
            //    }                
            //    foreach (var key in varsDic.Keys)
            //    {
            //        contactDic.Add(key, varsDic[key]);
            //    }

            //    var test = JObject.FromObject(contactDic);
            //    Console.Write("test");
            //}

            //var contact = project.GetContactByIdAsync("CT43b36878c28edf68").Result;                        
            

           

            //var filePath = JsonSerializeUtils.SerializeToAppFolder("telerivet-contacts.json", contacts);
            //var csvPath = filePath + ".csv";

            //using (var r = new ChoJSONReader(filePath))
            //{
            //    using (var w = new ChoCSVWriter(csvPath).WithFirstLineHeader())
            //    {
            //        w.Write(r);
            //    }
            //}

            //Console.WriteLine(filePath);
            //System.Diagnostics.Process.Start(csvPath);
            //Console.WriteLine(contacts.Count);
        }
    }
}
