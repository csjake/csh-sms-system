﻿//using Newtonsoft.Json.Linq;
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
                MmrBaseDate = DateTimeTelerivetDateStringConverter.ToDateTimeNullable(c.Vars.Get("mmr_base_date")?.ToString()),
                PentaBaseDate = DateTimeTelerivetDateStringConverter.ToDateTimeNullable(c.Vars.Get("penta_base_date")?.ToString()),
                PrenatalBaseDate = DateTimeTelerivetDateStringConverter.ToDateTimeNullable(c.Vars.Get("prenatal_base_date")?.ToString()),
                SourceDate = DateTimeTelerivetDateStringConverter.ToDateTime(c.Vars.Get("source_date").ToString()),
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
            var tcontacts = project.QueryContacts().AllAsync().Result;
            var result = new List<TelerivetContactV1>();
            foreach(var c in tcontacts)
            {
                var contact = new MasterDatabase.TelerivetContactV1();
                contact.Id = c.Id;
                contact.SendBlocked = c.SendBlocked;
                contact.TimeCreated = DateTimeUnixTimeStampConverter.ToDateTime(c.TimeCreated);
                contact.LastContacted = DateTimeUnixTimeStampConverter.ToDateTime(c.LastOutgoingMessageTime.GetValueOrDefault());
                contact.LastHeardFrom = DateTimeUnixTimeStampConverter.ToDateTime(c.LastIncomingMessageTime.GetValueOrDefault());
                contact.OutgoingMessageCount = c.OutgoingMessageCount;
                contact.IncomingMessageCount = c.IncomingMessageCount;
                contact.PhoneNumber = c.PhoneNumber;
                contact.Name = c.Name;
                contact.ProjectId = c.ProjectId;
                contact.GroupIds = c.GroupIds.ToString();
                contact.org_sign_up = c.Vars.Get("org_sign_up")?.ToString();
                contact.method_of_sign_up = c.Vars.Get("method_of_sign_up")?.ToString();
                contact.delay_in_days = StringLongConverter.ConvertToLong(c.Vars.Get("delay_in_days")?.ToString());
                contact.hospital_registration_no_ = c.Vars.Get("hospital_registration_no_")?.ToString();
                contact.pregnant_ = c.Vars.Get("pregnant_")?.ToString();
                contact.eligible_child_ = c.Vars.Get("eligible_child_")?.ToString();
                contact.name_of_surveyor = c.Vars.Get("name_of_surveyor")?.ToString();
                contact.name_of_supervisor = c.Vars.Get("name_of_supervisor")?.ToString();
                contact.division = c.Vars.Get("division")?.ToString();
                contact.district = c.Vars.Get("district")?.ToString();
                contact.standard_10_weeks = c.Vars.Get("standard_10_weeks")?.ToString();
                contact.standard_14_weeks = c.Vars.Get("standard_14_weeks")?.ToString();
                contact.standard_16_months = c.Vars.Get("standard_16_months")?.ToString();
                contact.standard_5_years = c.Vars.Get("standard_5_years")?.ToString();
                contact.standard_6_weeks = c.Vars.Get("standard_6_weeks")?.ToString();
                contact.standard_9_months = c.Vars.Get("standard_9_months")?.ToString();
                contact.state = c.Vars.Get("state")?.ToString();
                contact.location = c.Vars.Get("location")?.ToString();
                contact.city = c.Vars.Get("city")?.ToString();
                contact.enrol_ = c.Vars.Get("enrol_")?.ToString();
                contact.age_in_weeks = Utils.StringLongConverter.ConvertToLong(c.Vars.Get("age_in_weeks")?.ToString());
                contact.caregiver_s_name = c.Vars.Get("caregiver_s_name")?.ToString();
                contact.caregiver_s_relationship = c.Vars.Get("caregiver_s_relationship")?.ToString();
                contact.mother_s_first = c.Vars.Get("mother_s_first")?.ToString();
                contact.owner_of_primary_mobile = c.Vars.Get("owner_of_primary_mobile")?.ToString();
                contact.alternative_phone_number = c.Vars.Get("alternative_phone_number")?.ToString();
                contact.owner_of_alternate_mobile = c.Vars.Get("owner_of_alternate_mobile")?.ToString();
                contact.language_preference = c.Vars.Get("language_preference")?.ToString();
                contact.mobile_verified_ = c.Vars.Get("mobile_verified_")?.ToString();
                contact.ni_status = c.Vars.Get("ni_status")?.ToString();
                contact.vaccination_card_ = c.Vars.Get("vaccination_card_")?.ToString();
                contact.ni_number_type = c.Vars.Get("ni_number_type")?.ToString();
                contact.ni_network_name = c.Vars.Get("ni_network_name")?.ToString();
                contact.ni_network_code = c.Vars.Get("ni_network_code")?.ToString();
                contact.ni_country_code = c.Vars.Get("ni_country_code")?.ToString();
                contact.birth_location = c.Vars.Get("birth_location")?.ToString();
                contact.mother_education = c.Vars.Get("mother_education")?.ToString();
                contact.other_reminders_ = c.Vars.Get("other_reminders_")?.ToString();
                contact.income = c.Vars.Get("income")?.ToString();
                contact.children = c.Vars.Get("children")?.ToString();
                contact.vaccination_location = c.Vars.Get("vaccination_location")?.ToString();
                contact.literacy = c.Vars.Get("literacy")?.ToString();
                contact.notes = c.Vars.Get("notes")?.ToString();
                contact.data_format = c.Vars.Get("data_format")?.ToString();
                contact.hospital_name = c.Vars.Get("hospital_name")?.ToString();
                contact.phone_number = c.Vars.Get("phone_number")?.ToString();
                contact.date_uploaded = DateTimeTelerivetDateStringConverter.ToDateTimeNullable(c.Vars.Get("date_uploaded")?.ToString());
                contact.functional_dob = DateTimeTelerivetDateStringConverter.ToDateTimeNullable(c.Vars.Get("functional_dob")?.ToString());
                contact.date_of_sign_up = DateTimeTelerivetDateStringConverter.ToDateTimeNullable(c.Vars.Get("date_of_sign_up")?.ToString());
                contact.date_of_birth = DateTimeTelerivetDateStringConverter.ToDateTimeNullable(c.Vars.Get("date_of_birth")?.ToString());
                contact.ni_time = DateTimeTelerivetDateTimeStringConverter.ToDateTimeNullable(c.Vars.Get("ni_time")?.ToString());
                contact.vaccination_card_dob = DateTimeTelerivetDateStringConverter.ToDateTimeNullable(c.Vars.Get("vaccination_card_dob")?.ToString());
                contact.penta1_date = DateTimeTelerivetDateStringConverter.ToDateTimeNullable(c.Vars.Get("penta1_date")?.ToString());
                contact.penta2_date = DateTimeTelerivetDateStringConverter.ToDateTimeNullable(c.Vars.Get("penta2_date")?.ToString());
                contact.penta3_date = DateTimeTelerivetDateStringConverter.ToDateTimeNullable(c.Vars.Get("penta3_date")?.ToString());
                contact.mmr1_date = DateTimeTelerivetDateStringConverter.ToDateTimeNullable(c.Vars.Get("mmr1_date")?.ToString());
                result.Add(contact);
            }   

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
