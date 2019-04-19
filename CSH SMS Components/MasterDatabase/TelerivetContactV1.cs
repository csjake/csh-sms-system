using System;
using System.Collections.Generic;
using System.Text;

namespace MasterDatabase
{
    public class TelerivetContactV1
    {
        public string Id { get; set; }
        public bool SendBlocked { get; set; }
        public DateTime TimeCreated { get; set; }       
        public DateTime? LastContacted { get; set; }
        public DateTime? LastHeardFrom { get; set; }
        public int OutgoingMessageCount { get; set; }
        public int IncomingMessageCount { get; set; }
        public string PhoneNumber { get; set; }
        public string Name { get; set; }
        public string ProjectId { get; set; }
        public string GroupIds { get; set; }

        public string org_sign_up { get; set; }
        public string method_of_sign_up { get; set; }
        public DateTime? date_uploaded { get; set; }
        public long? delay_in_days { get; set; }
        public DateTime? functional_dob { get; set; }
        public string hospital_registration_no_ { get; set; }
        public string pregnant_ { get; set; }
        public string eligible_child_ { get; set; }
        public DateTime? date_of_sign_up { get; set; }
        public string name_of_surveyor { get; set; }
        public string name_of_supervisor { get; set; }
        public string division { get; set; }
        public string district { get; set; }
        public string standard_10_weeks { get; set; }
        public string standard_14_weeks { get; set; }
        public string standard_16_months { get; set; }
        public string standard_5_years { get; set; }
        public string standard_6_weeks { get; set; }
        public string standard_9_months { get; set; }
        public string state { get; set; }
        public string location { get; set; }
        public string city { get; set; }
        public string enrol_ { get; set; }
        public DateTime? date_of_birth { get; set; }
        public long? age_in_weeks { get; set; }
        public string caregiver_s_name { get; set; }
        public string caregiver_s_relationship { get; set; }
        public string mother_s_first { get; set; }
        public string owner_of_primary_mobile { get; set; }
        public string alternative_phone_number { get; set; }
        public string owner_of_alternate_mobile { get; set; }
        public string language_preference { get; set; }
        public string mobile_verified_ { get; set; }
        public string ni_status { get; set; }
        public string vaccination_card_ { get; set; }
        public DateTime? ni_time { get; set; }
        public DateTime? vaccination_card_dob { get; set; }
        public string ni_number_type { get; set; }
        public DateTime? penta1_date { get; set; }
        public string ni_network_name { get; set; }
        public DateTime? penta2_date { get; set; }
        public string ni_network_code { get; set; }
        public DateTime? penta3_date { get; set; }
        public string ni_country_code { get; set; }
        public DateTime? mmr1_date { get; set; }
        public string birth_location { get; set; }
        public string mother_education { get; set; }
        public string other_reminders_ { get; set; }
        public string income { get; set; }
        public string children { get; set; }
        public string vaccination_location { get; set; }
        public string literacy { get; set; }
        public string notes { get; set; }
        public string data_format { get; set; }
        public string hospital_name { get; set; }
        public string phone_number { get; set; }
    }
}
