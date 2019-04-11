using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using ChoETL;
using MasterDatabase;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace SurveyCTODownload
{
    public class FormDataDownloader
    {               
        public static List<SCTOPartnerSurvey20190223> DownloadPartnerSurvey20190223(SurveyCTODownloadConfig conf)
        {
            //https://csh.surveycto.com/api/v1/forms/files/csv/​enrollment_survey_d2d_partners_20190223
            //https://csh.surveycto.com/api/v1/forms/data/csv/enrollment_survey_d2d_partners_20190223
            var credentials = new NetworkCredential(conf.SurveyCtoUserName, conf.SurveyCtoPassword);

            var request = WebRequest.Create(@"https://csh.surveycto.com/api/v1/forms/data/csv/enrollment_survey_d2d_partners_20190223");
            request.Credentials = credentials;
            var response = request.GetResponse();
            string responseText;
            using (var reader = new System.IO.StreamReader(response.GetResponseStream(), Encoding.ASCII))
            {
                responseText = reader.ReadToEnd();
            }

            var input = new System.Text.StringBuilder(responseText);
            var result = new List<SCTOPartnerSurvey20190223>();
            result.AddRange(new ChoCSVReader<SCTOPartnerSurvey20190223>(input).WithFirstLineHeader());
                       
            return result;
        }

        public static void SavePartnerSurvey(List<SCTOPartnerSurvey20190223> items)
        {
            var db = MasterDatabaseContext.CreateDevDB();
            db.Database.ExecuteSqlCommand("Delete From PartnerSurveys20190223");
            db.PartnerSurveys20190223.AddRange(items);
            db.SaveChanges();
        }

        public static List<Contact> TransformPartnerSurvey20190223(List<SCTOPartnerSurvey20190223> partnerSurveys)
        {
            var result = new List<Contact>();
            //outer join from partner survey to all possible combinations
            //filter after the fact on contact name/child name
            ChildSelect[] children = { ChildSelect.child1, ChildSelect.child2 };
            RecipientSelect[] recipients = { RecipientSelect.Alternative1, RecipientSelect.Alternative2, RecipientSelect.Father, RecipientSelect.Mother };
            var collection = (from s in partnerSurveys
                              from child in children
                              from recipient in recipients
                              select new { s, child = s.GetChild(child), recipient = s.GetRecipient(recipient, child) });

            var transformed = (from c in collection
                               select new Contact
                               {
                                   Name = c.recipient.Name,
                                   PhoneNumber = c.recipient.PhoneNumber,
                                   MotherName = c.recipient.MotherName,
                                   ChildName = c.child.Name,
                                   ChildDOB = c.child.ChildDob,
                                   MmrBaseDate = c.child.MmrBaseDate,
                                   PentaBaseDate = c.child.PentaBaseDate,
                                   PrenatalBaseDate = c.child.PrenatalBaseDate,
                                   SourceGroupNames = c.recipient.GroupNames,
                                   SourceDate = c.recipient.SourceDate,
                                   SourceType = c.recipient.SourceType,
                                   SourceKey = c.recipient.SourceKey,
                               });

            return result;
        }                
    }
}
