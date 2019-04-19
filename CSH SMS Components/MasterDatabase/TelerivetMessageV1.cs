using System;
using System.Collections.Generic;
using System.Text;

namespace MasterDatabase
{
    public class TelerivetMessageV1
    {
        public string Content { get; set; }
        public string ErrorMessage { get; set; }
        public string ExternalId { get; set; }
        public double? Price { get; set; }
        public string PriceCurrency { get; set; }
        public double? Duration { get; set; }
        public double? RingTime { get; set; }
        public string AudioUrl { get; set; }
        public string TtsLang { get; set; }
        public string TtsVoice { get; set; }
        public string ServiceId { get; set; }
        public string PhoneId { get; set; }
        public string ContactId { get; set; }
        public string RouteId { get; set; }
        public string BroadcastId { get; set; }
        public bool Simulated { get; set; }
        public bool Starred { get; set; }
        public string ProjectId { get; set; }
        public string ToNumber { get; set; }
        public string FromNumber { get; set; }
        public long? TimeSent { get; set; }
        public long TimeCreated { get; set; }
        public string Source { get; set; }
        public string MessageType { get; set; }
        public string Status { get; set; }
        public string Direction { get; set; }
        public string Id { get; set; }
        public string UserId { get; set; }
    }
}
