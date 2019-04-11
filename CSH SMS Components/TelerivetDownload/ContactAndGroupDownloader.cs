//using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using Telerivet.Client;
using ChoETL;
using Utils;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Microsoft.EntityFrameworkCore;
using MasterDatabase;

namespace TelerivetDownload
{
   
    public class ContactAndGroupDownloader
    {       
        public static void DownloadV2(TelerivetApiConfig conf)
        {
            TelerivetAPI tr = new TelerivetAPI(conf.TelerivetAPIKey);
            Project project = tr.InitProjectById("PJa76127e2eb4dcc83");

            var result = (from c in project.QueryContacts().AllAsync().Result select new MasterDatabase.TelerivetContact {
                Id = c.Id,
                SendBlocked = c.SendBlocked,
                TimeCreated = DateTimeUnixTimeStampConverter.ToDateTime(c.TimeCreated),
                LastContacted = DateTimeUnixTimeStampConverter.ToDateTime(c.LastOutgoingMessageTime.GetValueOrDefault()),
                LastHeardFrom = DateTimeUnixTimeStampConverter.ToDateTime(c.LastIncomingMessageTime.GetValueOrDefault()),
                OutgoingMessageCount = c.OutgoingMessageCount,
                IncomingMessageCount = c.IncomingMessageCount,
                PhoneNumber = c.PhoneNumber,
                Name = c.Name,
                ProjectId = c.ProjectId,                
                GroupIds = c.GroupIds.ToString(),
                MotherName = c.Vars.Get("mother_name")?.ToString(),
                ChildName = c.Vars.Get("child_name")?.ToString(),
                MmrBaseDate = DateTimeTelerivetTimeStringConverter.ToDateTimeNullable(c.Vars.Get("mmr_base_date")?.ToString()),
                PentaBaseDate = DateTimeTelerivetTimeStringConverter.ToDateTimeNullable(c.Vars.Get("penta_base_date")?.ToString()),
                PrenatalBaseDate = DateTimeTelerivetTimeStringConverter.ToDateTimeNullable(c.Vars.Get("prenatal_base_date")?.ToString()),
                SourceDate = DateTimeTelerivetTimeStringConverter.ToDateTime(c.Vars.Get("source_date").ToString()),
                SourceType = c.Vars.Get("source_type").ToString(),
                SourceKey = c.Vars.Get("source_key").ToString(),
            }).ToList();

            var trGroups = (from g in project.QueryGroups().AllAsync().Result select new MasterDatabase.TelerivetGroup { Id = g.Id, Name = g.Name });

            var db = MasterDatabaseContext.CreateDevDB();
            db.Database.ExecuteSqlCommand("Delete From TelerivetGroups;");
            db.TelerivetGroups.AddRange(trGroups);
            db.Database.ExecuteSqlCommand("Delete From TelerivetContacts;");
            db.TelerivetContacts.AddRange(result);
            db.SaveChanges();
                        
            Console.WriteLine("test");         
        }

        public static void DownloadV1(TelerivetApiConfig conf)
        {
            TelerivetAPI tr = new TelerivetAPI(conf.TelerivetAPIKey);
            Project project = tr.InitProjectById("PJedf9c2a646a87abc");

            var result = (from c in project.QueryContacts().AllAsync().Result
                          select new MasterDatabase.TelerivetContactV1
                          {
                              Id = c.Id,
                              SendBlocked = c.SendBlocked,
                              TimeCreated = DateTimeUnixTimeStampConverter.ToDateTime(c.TimeCreated),
                              LastContacted = DateTimeUnixTimeStampConverter.ToDateTime(c.LastOutgoingMessageTime.GetValueOrDefault()),
                              LastHeardFrom = DateTimeUnixTimeStampConverter.ToDateTime(c.LastIncomingMessageTime.GetValueOrDefault()),
                              OutgoingMessageCount = c.OutgoingMessageCount,
                              IncomingMessageCount = c.IncomingMessageCount,
                              PhoneNumber = c.PhoneNumber,
                              Name = c.Name,
                              ProjectId = c.ProjectId,
                              GroupIds = c.GroupIds.ToString(),
                              org_sign_up = c.Vars.Get("org_sign_up").ToString(),
                              method_of_sign_up = c.Vars.Get("method_of_sign_up").ToString(),
                              delay_in_days = StringLongConverter.ConvertToLong(c.Vars.Get("delay_in_days").ToString()),
                              hospital_registration_no_ = c.Vars.Get("hospital_registration_no_").ToString(),
                              pregnant_ = c.Vars.Get("pregnant_").ToString(),
                              eligible_child_ = c.Vars.Get("eligible_child_").ToString(),
                              name_of_surveyor = c.Vars.Get("name_of_surveyor").ToString(),
                              name_of_supervisor = c.Vars.Get("name_of_supervisor").ToString(),
                              division = c.Vars.Get("division").ToString(),
                              district = c.Vars.Get("district").ToString(),
                              standard_10_weeks = c.Vars.Get("standard_10_weeks").ToString(),
                              standard_14_weeks = c.Vars.Get("standard_14_weeks").ToString(),
                              standard_16_months = c.Vars.Get("standard_16_months").ToString(),
                              standard_5_years = c.Vars.Get("standard_5_years").ToString(),
                              standard_6_weeks = c.Vars.Get("standard_6_weeks").ToString(),
                              standard_9_months = c.Vars.Get("standard_9_months").ToString(),
                              state = c.Vars.Get("state").ToString(),
                              location = c.Vars.Get("location").ToString(),
                              city = c.Vars.Get("city").ToString(),
                              enrol_ = c.Vars.Get("enrol_").ToString(),
                              age_in_weeks = Utils.StringLongConverter.ConvertToLong(c.Vars.Get("age_in_weeks").ToString()),
                              caregiver_s_name = c.Vars.Get("caregiver_s_name").ToString(),
                              caregiver_s_relationship = c.Vars.Get("caregiver_s_relationship").ToString(),
                              mother_s_first = c.Vars.Get("mother_s_first").ToString(),
                              owner_of_primary_mobile = c.Vars.Get("owner_of_primary_mobile").ToString(),
                              alternative_phone_number = c.Vars.Get("alternative_phone_number").ToString(),
                              owner_of_alternate_mobile = c.Vars.Get("owner_of_alternate_mobile").ToString(),
                              language_preference = c.Vars.Get("language_preference").ToString(),
                              mobile_verified_ = c.Vars.Get("mobile_verified_").ToString(),
                              ni_status = c.Vars.Get("ni_status").ToString(),
                              vaccination_card_ = c.Vars.Get("vaccination_card_").ToString(),
                              ni_number_type = c.Vars.Get("ni_number_type").ToString(),
                              ni_network_name = c.Vars.Get("ni_network_name").ToString(),
                              ni_network_code = c.Vars.Get("ni_network_code").ToString(),
                              ni_country_code = c.Vars.Get("ni_country_code").ToString(),
                              birth_location = c.Vars.Get("birth_location").ToString(),
                              mother_education = c.Vars.Get("mother_education").ToString(),
                              other_reminders_ = c.Vars.Get("other_reminders_").ToString(),
                              income = c.Vars.Get("income").ToString(),
                              children = c.Vars.Get("children").ToString(),
                              vaccination_location = c.Vars.Get("vaccination_location").ToString(),
                              literacy = c.Vars.Get("literacy").ToString(),
                              notes = c.Vars.Get("notes").ToString(),
                              data_format = c.Vars.Get("data_format").ToString(),
                              hospital_name = c.Vars.Get("hospital_name").ToString(),
                              phone_number = c.Vars.Get("phone_number").ToString(),
                              date_uploaded = DateTimeTelerivetTimeStringConverter.ToDateTimeNullable(c.Vars.Get("date_uploaded")?.ToString()),
                              functional_dob = DateTimeTelerivetTimeStringConverter.ToDateTimeNullable(c.Vars.Get("functional_dob")?.ToString()),
                              date_of_sign_up = DateTimeTelerivetTimeStringConverter.ToDateTimeNullable(c.Vars.Get("date_of_sign_up")?.ToString()),
                              date_of_birth = DateTimeTelerivetTimeStringConverter.ToDateTimeNullable(c.Vars.Get("date_of_birth")?.ToString()),
                              ni_time = DateTimeTelerivetTimeStringConverter.ToDateTimeNullable(c.Vars.Get("ni_time")?.ToString()),
                              vaccination_card_dob = DateTimeTelerivetTimeStringConverter.ToDateTimeNullable(c.Vars.Get("vaccination_card_dob")?.ToString()),
                              penta1_date = DateTimeTelerivetTimeStringConverter.ToDateTimeNullable(c.Vars.Get("penta1_date")?.ToString()),
                              penta2_date = DateTimeTelerivetTimeStringConverter.ToDateTimeNullable(c.Vars.Get("penta2_date")?.ToString()),
                              penta3_date = DateTimeTelerivetTimeStringConverter.ToDateTimeNullable(c.Vars.Get("penta3_date")?.ToString()),
                              mmr1_date = DateTimeTelerivetTimeStringConverter.ToDateTimeNullable(c.Vars.Get("mmr1_date")?.ToString()),
                          }).ToList();

            var trGroups = (from g in project.QueryGroups().AllAsync().Result select new MasterDatabase.TelerivetGroupV1 { Id = g.Id, Name = g.Name });

            var db = MasterDatabaseContext.CreateDevDB();
            db.Database.ExecuteSqlCommand("Delete From TelerivetGroupV1s;");
            db.TelerivetGroupV1s.AddRange(trGroups);
            db.Database.ExecuteSqlCommand("Delete From TelerivetContactV1s;");
            db.TelerivetContactV1s.AddRange(result);
            db.SaveChanges();
        }
    }
}
