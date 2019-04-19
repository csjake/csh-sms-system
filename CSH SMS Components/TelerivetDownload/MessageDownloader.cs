using System;
using System.Collections.Generic;
using System.Text;
using Telerivet.Client;
using MasterDatabase;

namespace TelerivetDownload
{
    public class MessageDownloader
    {
        public void DownloadMessagesV1(TelerivetApiConfig conf)
        {
            var tr = new TelerivetAPI(conf.TelerivetAPIKey);
            var project = tr.InitProjectById("PJa76127e2eb4dcc83");

            var trMessages = project.QueryMessages().AllAsync().Result;
            foreach(var m in trMessages)
            {
                var message = new TelerivetMessageV1();
                message.Content = m.Content;
                message.ErrorMessage = m.ErrorMessage;
                message.ExternalId = m.ExternalId;
                message.Price = m.Price;
                message.PriceCurrency = m.PriceCurrency;
                message.Duration = m.Duration;
                message.RingTime = m.RingTime;
                message.AudioUrl = m.AudioUrl;
                message.TtsLang = m.TtsLang;
                message.TtsVoice = m.TtsVoice;
                message.ServiceId = m.ServiceId;
                message.PhoneId = m.PhoneId;
                message.ContactId = m.ContactId;
                message.RouteId = m.RouteId;
                message.BroadcastId = m.BroadcastId;
                message.Simulated = m.Simulated;
                message.Starred = m.Starred;
                message.ProjectId = m.ProjectId;
                message.ToNumber = m.ToNumber;
                message.FromNumber = m.FromNumber;
                message.TimeSent = m.TimeSent;
                message.TimeCreated = m.TimeCreated;
                message.Source = m.Source;
                message.MessageType = m.MessageType;
                message.Status = m.Status;
                message.Direction = m.Direction;
                message.Id = m.Id;
                message.UserId = m.UserId;
            }
        }
    }
}
