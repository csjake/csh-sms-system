using ChoETL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MasterDatabase
{
    [ChoCSVFileHeader]
    [ChoCSVRecordObject]
    public class SCTOPartnerSurvey20190223
    {
        [ChoCSVRecordField(1, FieldName = @"SubmissionDate")]
        public string SubmissionDate { get; set; }

        [ChoCSVRecordField(2, FieldName = @"starttime")]
        public string starttime { get; set; }

        [ChoCSVRecordField(3, FieldName = @"endtime")]
        public string endtime { get; set; }

        [ChoCSVRecordField(4, FieldName = @"deviceid")]
        public string deviceid { get; set; }

        [ChoCSVRecordField(5, FieldName = @"subscriberid")]
        public string subscriberid { get; set; }

        [ChoCSVRecordField(6, FieldName = @"simid")]
        public string simid { get; set; }

        [ChoCSVRecordField(7, FieldName = @"devicephonenum")]
        public string devicephonenum { get; set; }

        [ChoCSVRecordField(8, FieldName = @"complete_text_audits")]
        public string complete_text_audits { get; set; }

        [ChoCSVRecordField(9, FieldName = @"complete_audio_audit")]
        public string complete_audio_audit { get; set; }

        [ChoCSVRecordField(10, FieldName = @"child_age_limit_text")]
        public string child_age_limit_text { get; set; }

        [ChoCSVRecordField(11, FieldName = @"surveyor_identity-member_name")]
        public string member_name { get; set; }

        [ChoCSVRecordField(12, FieldName = @"surveyor_identity-member_organization")]
        public string member_organization { get; set; }

        [ChoCSVRecordField(13, FieldName = @"surveyor_identity-member_organization_name")]
        public string member_organization_name { get; set; }

        [ChoCSVRecordField(14, FieldName = @"surveyor_identity-confirm_surveyor_identity")]
        public string confirm_surveyor_identity { get; set; }

        [ChoCSVRecordField(15, FieldName = @"preliminary_consent")]
        public string preliminary_consent { get; set; }

        [ChoCSVRecordField(16, FieldName = @"preliminary_consent_given-mothers_name")]
        public string mothers_name { get; set; }

        [ChoCSVRecordField(17, FieldName = @"preliminary_consent_given-eligibility_check_pregnant")]
        public string eligibility_check_pregnant { get; set; }

        [ChoCSVRecordField(18, FieldName = @"preliminary_consent_given-eligibility_check_child")]
        public string eligibility_check_child { get; set; }

        [ChoCSVRecordField(19, FieldName = @"preliminary_consent_given-eligibility_check_phone_number")]
        public string eligibility_check_phone_number { get; set; }

        [ChoCSVRecordField(20, FieldName = @"preliminary_consent_given-eligible-consent")]
        public string consent { get; set; }

        [ChoCSVRecordField(21, FieldName = @"preliminary_consent_given-eligible-consent_sign")]
        public string consent_sign { get; set; }

        [ChoCSVRecordField(22, FieldName = @"preliminary_consent_given-eligible-survey_location_post_consent_sign-Latitude")]
        public string Latitude { get; set; }

        [ChoCSVRecordField(23, FieldName = @"preliminary_consent_given-eligible-survey_location_post_consent_sign-Longitude")]
        public string Longitude { get; set; }

        [ChoCSVRecordField(24, FieldName = @"preliminary_consent_given-eligible-survey_location_post_consent_sign-Altitude")]
        public string Altitude { get; set; }

        [ChoCSVRecordField(25, FieldName = @"preliminary_consent_given-eligible-survey_location_post_consent_sign-Accuracy")]
        public string Accuracy { get; set; }

        [ChoCSVRecordField(26, FieldName = @"preliminary_consent_given-eligible-child1s_preliminary_details-child1s_name")]
        public string child1s_name { get; set; }

        [ChoCSVRecordField(27, FieldName = @"preliminary_consent_given-eligible-child1s_preliminary_details-child1s_dob_confidence")]
        public string child1s_dob_confidence { get; set; }

        [ChoCSVRecordField(28, FieldName = @"preliminary_consent_given-eligible-child1s_preliminary_details-child1s_dob")]
        public string child1s_dob { get; set; }

        [ChoCSVRecordField(29, FieldName = @"preliminary_consent_given-eligible-child1s_preliminary_details-child1s_dob_redundant")]
        public string child1s_dob_redundant { get; set; }

        [ChoCSVRecordField(30, FieldName = @"preliminary_consent_given-eligible-respondent_details-respondent_details_starttime")]
        public string respondent_details_starttime { get; set; }

        [ChoCSVRecordField(31, FieldName = @"preliminary_consent_given-eligible-respondent_details-respondent_relationship_to_mother_list")]
        public string respondent_relationship_to_mother_list { get; set; }

        [ChoCSVRecordField(32, FieldName = @"preliminary_consent_given-eligible-alternate_contact_1-alternate_contact_1_sub1-alternate_contact_1_starttime")]
        public string alternate_contact_1_starttime { get; set; }

        [ChoCSVRecordField(33, FieldName = @"preliminary_consent_given-eligible-alternate_contact_1-alternate_contact_1_sub1-alternate_contact_1_name")]
        public string alternate_contact_1_name { get; set; }

        [ChoCSVRecordField(34, FieldName = @"preliminary_consent_given-eligible-alternate_contact_1-alternate_contact_1_sub2-alternate_contact1_smartphone_flag")]
        public string alternate_contact1_smartphone_flag { get; set; }

        [ChoCSVRecordField(35, FieldName = @"preliminary_consent_given-eligible-alternate_contact_1-alternate_contact_1_sub2-alternate_contact1_number")]
        public string alternate_contact1_number { get; set; }

        [ChoCSVRecordField(36, FieldName = @"preliminary_consent_given-eligible-alternate_contact_1-alternate_contact_1_sub2-alternate_contact1_number_redundant")]
        public string alternate_contact1_number_redundant { get; set; }

        [ChoCSVRecordField(37, FieldName = @"preliminary_consent_given-eligible-main_contacts_mother-main_contacts_mother_sub1-main_contacts_mother_starttime")]
        public string main_contacts_mother_starttime { get; set; }

        [ChoCSVRecordField(38, FieldName = @"preliminary_consent_given-eligible-main_contacts_mother-main_contacts_mother_sub2-mothers_contact_smartphone_flag")]
        public string mothers_contact_smartphone_flag { get; set; }

        [ChoCSVRecordField(39, FieldName = @"preliminary_consent_given-eligible-main_contacts_mother-main_contacts_mother_sub2-mothers_contact_number")]
        public string mothers_contact_number { get; set; }

        [ChoCSVRecordField(40, FieldName = @"preliminary_consent_given-eligible-main_contacts_mother-main_contacts_mother_sub2-mothers_contact_number_redundant")]
        public string mothers_contact_number_redundant { get; set; }

        [ChoCSVRecordField(41, FieldName = @"preliminary_consent_given-eligible-main_contacts_father-main_contacts_father_sub1-main_contacts_father_starttime")]
        public string main_contacts_father_starttime { get; set; }

        [ChoCSVRecordField(42, FieldName = @"preliminary_consent_given-eligible-main_contacts_father-main_contacts_father_sub1-fathers_name")]
        public string fathers_name { get; set; }

        [ChoCSVRecordField(43, FieldName = @"preliminary_consent_given-eligible-main_contacts_father-main_contacts_father_sub2-fathers_contact_smartphone_flag")]
        public string fathers_contact_smartphone_flag { get; set; }

        [ChoCSVRecordField(44, FieldName = @"preliminary_consent_given-eligible-main_contacts_father-main_contacts_father_sub2-fathers_contact_number")]
        public string fathers_contact_number { get; set; }

        [ChoCSVRecordField(45, FieldName = @"preliminary_consent_given-eligible-main_contacts_father-main_contacts_father_sub2-fathers_contact_number_redundant")]
        public string fathers_contact_number_redundant { get; set; }

        [ChoCSVRecordField(46, FieldName = @"preliminary_consent_given-eligible-alternate_contact_maternalHome-maternal_home_visit")]
        public string maternal_home_visit { get; set; }

        [ChoCSVRecordField(47, FieldName = @"preliminary_consent_given-eligible-alternate_contact_maternalHome-alternate_contact_maternalHome_sub1-maternalHome_contact_starttime")]
        public string maternalHome_contact_starttime { get; set; }

        [ChoCSVRecordField(48, FieldName = @"preliminary_consent_given-eligible-alternate_contact_maternalHome-alternate_contact_maternalHome_sub1-alternate_contact_maternalHome_name")]
        public string alternate_contact_maternalHome_name { get; set; }

        [ChoCSVRecordField(49, FieldName = @"preliminary_consent_given-eligible-alternate_contact_maternalHome-alternate_contact_maternalHome_sub2-maternalHome_contact_smartphone_flag")]
        public string maternalHome_contact_smartphone_flag { get; set; }

        [ChoCSVRecordField(50, FieldName = @"preliminary_consent_given-eligible-alternate_contact_maternalHome-alternate_contact_maternalHome_sub2-maternalHome_contact_number")]
        public string maternalHome_contact_number { get; set; }

        [ChoCSVRecordField(51, FieldName = @"preliminary_consent_given-eligible-alternate_contact_maternalHome-alternate_contact_maternalHome_sub2-maternalHome_contact_number_redundant")]
        public string maternalHome_contact_number_redundant { get; set; }

        [ChoCSVRecordField(52, FieldName = @"preliminary_consent_given-eligible-alternate_contact_2-alternate_contact_2_sub1-alternate_contact_2_starttime")]
        public string alternate_contact_2_starttime { get; set; }

        [ChoCSVRecordField(53, FieldName = @"preliminary_consent_given-eligible-alternate_contact_2-alternate_contact_2_sub1-alternate_contact_2_name")]
        public string alternate_contact_2_name { get; set; }

        [ChoCSVRecordField(54, FieldName = @"preliminary_consent_given-eligible-alternate_contact_2-alternate_contact_2_sub2-alternate_contact2_smartphone_flag")]
        public string alternate_contact2_smartphone_flag { get; set; }

        [ChoCSVRecordField(55, FieldName = @"preliminary_consent_given-eligible-alternate_contact_2-alternate_contact_2_sub2-alternate_contact2_contact_number")]
        public string alternate_contact2_contact_number { get; set; }

        [ChoCSVRecordField(56, FieldName = @"preliminary_consent_given-eligible-alternate_contact_2-alternate_contact_2_sub2-alternate_contact2_contact_number_redundant")]
        public string alternate_contact2_contact_number_redundant { get; set; }

        [ChoCSVRecordField(57, FieldName = @"preliminary_consent_given-eligible-mothers_preferred_language")]
        public string mothers_preferred_language { get; set; }

        [ChoCSVRecordField(58, FieldName = @"preliminary_consent_given-eligible-main-main_starttime")]
        public string main_main_starttime { get; set; }

        [ChoCSVRecordField(59, FieldName = @"preliminary_consent_given-eligible-main-questions_for_pregnant_mother-mcp_card_available")]
        public string mcp_card_available { get; set; }

        [ChoCSVRecordField(60, FieldName = @"preliminary_consent_given-eligible-main-questions_for_pregnant_mother-mcp_card_not_available_reason")]
        public string mcp_card_not_available_reason { get; set; }

        [ChoCSVRecordField(61, FieldName = @"preliminary_consent_given-eligible-main-questions_for_pregnant_mother-questions_for_pregnant_mother_MCP-pregnancy_MCP_questions_starttime")]
        public string pregnancy_MCP_questions_starttime { get; set; }

        [ChoCSVRecordField(62, FieldName = @"preliminary_consent_given-eligible-main-questions_for_pregnant_mother-questions_for_pregnant_mother_MCP-due_date_mcp_card_present_flag")]
        public string due_date_mcp_card_present_flag { get; set; }

        [ChoCSVRecordField(63, FieldName = @"preliminary_consent_given-eligible-main-questions_for_pregnant_mother-questions_for_pregnant_mother_MCP-due_date_mcp_card")]
        public string due_date_mcp_card { get; set; }

        [ChoCSVRecordField(64, FieldName = @"preliminary_consent_given-eligible-main-questions_for_pregnant_mother-questions_for_pregnant_mother_MCP-due_date_mcp_card_redundant")]
        public string due_date_mcp_card_redundant { get; set; }

        [ChoCSVRecordField(65, FieldName = @"preliminary_consent_given-eligible-main-questions_for_pregnant_mother-questions_for_pregnant_mother_MCP-mcp_card_photo_consent")]
        public string mcp_card_photo_consent { get; set; }

        [ChoCSVRecordField(66, FieldName = @"preliminary_consent_given-eligible-main-questions_for_pregnant_mother-questions_for_pregnant_mother_MCP-mcp_card_photo_due_date")]
        public string mcp_card_photo_due_date { get; set; }

        [ChoCSVRecordField(67, FieldName = @"preliminary_consent_given-eligible-main-questions_for_pregnant_mother-questions_for_pregnant_mother_MCP-last_menstrual_period_date_mcp_card_present_flag")]
        public string last_menstrual_period_date_mcp_card_present_flag { get; set; }

        [ChoCSVRecordField(68, FieldName = @"preliminary_consent_given-eligible-main-questions_for_pregnant_mother-questions_for_pregnant_mother_MCP-last_menstrual_period_mcp_card")]
        public string last_menstrual_period_mcp_card { get; set; }

        [ChoCSVRecordField(69, FieldName = @"preliminary_consent_given-eligible-main-questions_for_pregnant_mother-questions_for_pregnant_mother_MCP-last_menstrual_period_mcp_card_redundant")]
        public string last_menstrual_period_mcp_card_redundant { get; set; }

        [ChoCSVRecordField(70, FieldName = @"preliminary_consent_given-eligible-main-questions_for_pregnant_mother-questions_for_pregnant_mother_MCP-mcp_card_photo_last_menstrual_period")]
        public string mcp_card_photo_last_menstrual_period { get; set; }

        [ChoCSVRecordField(71, FieldName = @"preliminary_consent_given-eligible-main-questions_for_pregnant_mother-questions_for_pregnant_mother_MCP-last_prenatal_visit_date_mcp_card_present_flag")]
        public string last_prenatal_visit_date_mcp_card_present_flag { get; set; }

        [ChoCSVRecordField(72, FieldName = @"preliminary_consent_given-eligible-main-questions_for_pregnant_mother-questions_for_pregnant_mother_MCP-last_prenatal_visit_date_mcp_card")]
        public string last_prenatal_visit_date_mcp_card { get; set; }

        [ChoCSVRecordField(73, FieldName = @"preliminary_consent_given-eligible-main-questions_for_pregnant_mother-questions_for_pregnant_mother_MCP-mcp_card_photo_last_prenatal_visit")]
        public string mcp_card_photo_last_prenatal_visit { get; set; }

        [ChoCSVRecordField(74, FieldName = @"preliminary_consent_given-eligible-main-questions_for_pregnant_mother-questions_for_pregnant_mother_recall-pregnancy_recall_questions_starttime")]
        public string pregnancy_recall_questions_starttime { get; set; }

        [ChoCSVRecordField(75, FieldName = @"preliminary_consent_given-eligible-main-questions_for_pregnant_mother-questions_for_pregnant_mother_recall-due_date_recall_confidence")]
        public string due_date_recall_confidence { get; set; }

        [ChoCSVRecordField(76, FieldName = @"preliminary_consent_given-eligible-main-questions_for_pregnant_mother-questions_for_pregnant_mother_recall-due_date_recall")]
        public string due_date_recall { get; set; }

        [ChoCSVRecordField(77, FieldName = @"preliminary_consent_given-eligible-main-questions_for_pregnant_mother-questions_for_pregnant_mother_recall-last_prenatal_visit_date_recall_confidence")]
        public string last_prenatal_visit_date_recall_confidence { get; set; }

        [ChoCSVRecordField(78, FieldName = @"preliminary_consent_given-eligible-main-questions_for_pregnant_mother-questions_for_pregnant_mother_recall-last_prenatal_visit_date_recall")]
        public string last_prenatal_visit_date_recall { get; set; }

        [ChoCSVRecordField(79, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-child1s_gender")]
        public string child1s_gender { get; set; }

        [ChoCSVRecordField(80, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-child1_first_child")]
        public string child1_first_child { get; set; }

        [ChoCSVRecordField(81, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_eligible_child1-child1_vaccination_card_available")]
        public string child1_vaccination_card_available { get; set; }

        [ChoCSVRecordField(82, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_eligible_child1-child1_vaccination_card_not_available_reason")]
        public string child1_vaccination_card_not_available_reason { get; set; }

        [ChoCSVRecordField(83, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_eligible_child1-child1_vaccination_card_questions-child1s_dob_vacc_card_present_flag")]
        public string child1s_dob_vacc_card_present_flag { get; set; }

        [ChoCSVRecordField(84, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_eligible_child1-child1_vaccination_card_questions-child1s_dob_vacc_card")]
        public string child1s_dob_vacc_card { get; set; }

        [ChoCSVRecordField(85, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_eligible_child1-child1_vaccination_card_questions-child1s_dob_vacc_card_redundant")]
        public string child1s_dob_vacc_card_redundant { get; set; }

        [ChoCSVRecordField(86, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_eligible_child1-child1_vaccination_card_questions-child1s_vacc_card_photo_consent")]
        public string child1s_vacc_card_photo_consent { get; set; }

        [ChoCSVRecordField(87, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_eligible_child1-child1_vaccination_card_questions-child1s_dob_vacc_card_photo")]
        public string child1s_dob_vacc_card_photo { get; set; }

        [ChoCSVRecordField(88, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_eligible_child1-child1_vaccination_card_questions-child1_vacc_dates_vacc_card_visit0-child1_date_vacc_card_OPV0_present_flag")]
        public string child1_date_vacc_card_OPV0_present_flag { get; set; }

        [ChoCSVRecordField(89, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_eligible_child1-child1_vaccination_card_questions-child1_vacc_dates_vacc_card_visit0-child1_date_vacc_card_OPV0")]
        public string child1_date_vacc_card_OPV0 { get; set; }

        [ChoCSVRecordField(90, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_eligible_child1-child1_vaccination_card_questions-child1_vacc_dates_vacc_card_visit1-child1_date_vacc_card_OPV1_present_flag")]
        public string child1_date_vacc_card_OPV1_present_flag { get; set; }

        [ChoCSVRecordField(91, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_eligible_child1-child1_vaccination_card_questions-child1_vacc_dates_vacc_card_visit1-child1_date_vacc_card_OPV1")]
        public string child1_date_vacc_card_OPV1 { get; set; }

        [ChoCSVRecordField(92, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_eligible_child1-child1_vaccination_card_questions-child1_vacc_dates_vacc_card_visit1-child1_date_vacc_card_Penta1_present_flag")]
        public string child1_date_vacc_card_Penta1_present_flag { get; set; }

        [ChoCSVRecordField(93, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_eligible_child1-child1_vaccination_card_questions-child1_vacc_dates_vacc_card_visit1-child1_date_vacc_card_Penta1")]
        public string child1_date_vacc_card_Penta1 { get; set; }

        [ChoCSVRecordField(94, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_eligible_child1-child1_vaccination_card_questions-child1_vacc_dates_vacc_card_visit2-child1_date_vacc_card_OPV2_present_flag")]
        public string child1_date_vacc_card_OPV2_present_flag { get; set; }

        [ChoCSVRecordField(95, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_eligible_child1-child1_vaccination_card_questions-child1_vacc_dates_vacc_card_visit2-child1_date_vacc_card_OPV2")]
        public string child1_date_vacc_card_OPV2 { get; set; }

        [ChoCSVRecordField(96, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_eligible_child1-child1_vaccination_card_questions-child1_vacc_dates_vacc_card_visit2-child1_date_vacc_card_Penta2_present_flag")]
        public string child1_date_vacc_card_Penta2_present_flag { get; set; }

        [ChoCSVRecordField(97, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_eligible_child1-child1_vaccination_card_questions-child1_vacc_dates_vacc_card_visit2-child1_date_vacc_card_Penta2")]
        public string child1_date_vacc_card_Penta2 { get; set; }

        [ChoCSVRecordField(98, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_eligible_child1-child1_vaccination_card_questions-child1_vacc_dates_vacc_card_visit3-child1_date_vacc_card_OPV3_present_flag")]
        public string child1_date_vacc_card_OPV3_present_flag { get; set; }

        [ChoCSVRecordField(99, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_eligible_child1-child1_vaccination_card_questions-child1_vacc_dates_vacc_card_visit3-child1_date_vacc_card_OPV3")]
        public string child1_date_vacc_card_OPV3 { get; set; }

        [ChoCSVRecordField(100, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_eligible_child1-child1_vaccination_card_questions-child1_vacc_dates_vacc_card_visit3-child1_date_vacc_card_Penta3_present_flag")]
        public string child1_date_vacc_card_Penta3_present_flag { get; set; }

        [ChoCSVRecordField(101, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_eligible_child1-child1_vaccination_card_questions-child1_vacc_dates_vacc_card_visit3-child1_date_vacc_card_Penta3")]
        public string child1_date_vacc_card_Penta3 { get; set; }

        [ChoCSVRecordField(102, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_eligible_child1-child1_vaccination_card_questions-child1_vacc_dates_vacc_card_visit4-child1_date_vacc_card_MR1_present_flag")]
        public string child1_date_vacc_card_MR1_present_flag { get; set; }

        [ChoCSVRecordField(103, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_eligible_child1-child1_vaccination_card_questions-child1_vacc_dates_vacc_card_visit4-child1_date_vacc_card_MR1")]
        public string child1_date_vacc_card_MR1 { get; set; }

        [ChoCSVRecordField(104, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_eligible_child1-child1_vaccination_card_questions-child1_vacc_dates_vacc_card_visit5-child1_date_vacc_card_MR2_present_flag")]
        public string child1_date_vacc_card_MR2_present_flag { get; set; }

        [ChoCSVRecordField(105, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_eligible_child1-child1_vaccination_card_questions-child1_vacc_dates_vacc_card_visit5-child1_date_vacc_card_MR2")]
        public string child1_date_vacc_card_MR2 { get; set; }

        [ChoCSVRecordField(106, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_eligible_child1-child1_vaccination_card_questions-child1_vacc_dates_vacc_card_visit5-child1_date_vacc_card_OPVBooster_present_flag")]
        public string child1_date_vacc_card_OPVBooster_present_flag { get; set; }

        [ChoCSVRecordField(107, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_eligible_child1-child1_vaccination_card_questions-child1_vacc_dates_vacc_card_visit5-child1_date_vacc_card_OPVBooster")]
        public string child1_date_vacc_card_OPVBooster { get; set; }

        [ChoCSVRecordField(108, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_eligible_child1-child1_vaccination_card_questions-child1_vacc_card_photo")]
        public string child1_vacc_card_photo { get; set; }

        [ChoCSVRecordField(109, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_eligible_child1-child1_vacc_receipt_flag")]
        public string child1_vacc_receipt_flag { get; set; }

        [ChoCSVRecordField(110, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_eligible_child1-child1_vaccination_receipt_not_available_reason")]
        public string child1_vaccination_receipt_not_available_reason { get; set; }

        [ChoCSVRecordField(111, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_eligible_child1-child1_vacc_receipt-child1_last_vacc")]
        public string child1_last_vacc { get; set; }

        [ChoCSVRecordField(112, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_eligible_child1-child1_vacc_receipt-child1_last_vacc_DUPLICATE")]
        public string child1_last_vacc_DUPLICATE { get; set; }

        [ChoCSVRecordField(113, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_eligible_child1-child1_vacc_receipt-child1_date_last_vacc_present_flag")]
        public string child1_date_last_vacc_present_flag { get; set; }

        [ChoCSVRecordField(114, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_eligible_child1-child1_vacc_receipt-child1_date_last_vacc")]
        public string child1_date_last_vacc { get; set; }

        [ChoCSVRecordField(115, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_eligible_child1-child1_vacc_receipt-child1_vacc_receipt_photo_consent")]
        public string child1_vacc_receipt_photo_consent { get; set; }

        [ChoCSVRecordField(116, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_eligible_child1-child1_vacc_receipt-child1_date_last_vacc_photo")]
        public string child1_date_last_vacc_photo { get; set; }

        [ChoCSVRecordField(117, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_eligible_child1-child1_vacc_dates_pure_recall-child1_number_of_vacc_visits")]
        public string child1_number_of_vacc_visits { get; set; }

        [ChoCSVRecordField(118, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_eligible_child1-child1_vacc_dates_pure_recall-child1_last_vacc_date_recall_confidence")]
        public string child1_last_vacc_date_recall_confidence { get; set; }

        [ChoCSVRecordField(119, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_eligible_child1-child1_vacc_dates_pure_recall-child1_date_recall_last_vacc_visit")]
        public string child1_date_recall_last_vacc_visit { get; set; }

        [ChoCSVRecordField(120, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-second_child_flag")]
        public string second_child_flag { get; set; }

        [ChoCSVRecordField(121, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_child2-child2s_name")]
        public string child2s_name { get; set; }

        [ChoCSVRecordField(122, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_child2-child2s_gender")]
        public string child2s_gender { get; set; }

        [ChoCSVRecordField(123, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_child2-child2_first_child")]
        public string child2_first_child { get; set; }

        [ChoCSVRecordField(124, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_child2-child2s_dob_confidence")]
        public string child2s_dob_confidence { get; set; }

        [ChoCSVRecordField(125, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_child2-child2s_dob")]
        public string child2s_dob { get; set; }

        [ChoCSVRecordField(126, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_child2-child2s_dob_redundant")]
        public string child2s_dob_redundant { get; set; }

        [ChoCSVRecordField(127, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_child2-questions_about_eligible_child2-child2_vaccination_card_available")]
        public string child2_vaccination_card_available { get; set; }

        [ChoCSVRecordField(128, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_child2-questions_about_eligible_child2-child2_vaccination_card_not_available_reason")]
        public string child2_vaccination_card_not_available_reason { get; set; }

        [ChoCSVRecordField(129, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_child2-questions_about_eligible_child2-child2_vaccination_card_questions-child2s_dob_vacc_card_present_flag")]
        public string child2s_dob_vacc_card_present_flag { get; set; }

        [ChoCSVRecordField(130, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_child2-questions_about_eligible_child2-child2_vaccination_card_questions-child2s_dob_vacc_card")]
        public string child2s_dob_vacc_card { get; set; }

        [ChoCSVRecordField(131, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_child2-questions_about_eligible_child2-child2_vaccination_card_questions-child2s_dob_vacc_card_redundant")]
        public string child2s_dob_vacc_card_redundant { get; set; }

        [ChoCSVRecordField(132, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_child2-questions_about_eligible_child2-child2_vaccination_card_questions-child2s_vacc_card_photo_consent")]
        public string child2s_vacc_card_photo_consent { get; set; }

        [ChoCSVRecordField(133, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_child2-questions_about_eligible_child2-child2_vaccination_card_questions-child2s_dob_vacc_card_photo")]
        public string child2s_dob_vacc_card_photo { get; set; }

        [ChoCSVRecordField(134, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_child2-questions_about_eligible_child2-child2_vaccination_card_questions-child2_vacc_dates_vacc_card_visit0-child2_date_vacc_card_OPV0_present_flag")]
        public string child2_date_vacc_card_OPV0_present_flag { get; set; }

        [ChoCSVRecordField(135, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_child2-questions_about_eligible_child2-child2_vaccination_card_questions-child2_vacc_dates_vacc_card_visit0-child2_date_vacc_card_OPV0")]
        public string child2_date_vacc_card_OPV0 { get; set; }

        [ChoCSVRecordField(136, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_child2-questions_about_eligible_child2-child2_vaccination_card_questions-child2_vacc_dates_vacc_card_visit1-child2_date_vacc_card_OPV1_present_flag")]
        public string child2_date_vacc_card_OPV1_present_flag { get; set; }

        [ChoCSVRecordField(137, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_child2-questions_about_eligible_child2-child2_vaccination_card_questions-child2_vacc_dates_vacc_card_visit1-child2_date_vacc_card_OPV1")]
        public string child2_date_vacc_card_OPV1 { get; set; }

        [ChoCSVRecordField(138, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_child2-questions_about_eligible_child2-child2_vaccination_card_questions-child2_vacc_dates_vacc_card_visit1-child2_date_vacc_card_Penta1_present_flag")]
        public string child2_date_vacc_card_Penta1_present_flag { get; set; }

        [ChoCSVRecordField(139, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_child2-questions_about_eligible_child2-child2_vaccination_card_questions-child2_vacc_dates_vacc_card_visit1-child2_date_vacc_card_Penta1")]
        public string child2_date_vacc_card_Penta1 { get; set; }

        [ChoCSVRecordField(140, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_child2-questions_about_eligible_child2-child2_vaccination_card_questions-child2_vacc_dates_vacc_card_visit2-child2_date_vacc_card_OPV2_present_flag")]
        public string child2_date_vacc_card_OPV2_present_flag { get; set; }

        [ChoCSVRecordField(141, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_child2-questions_about_eligible_child2-child2_vaccination_card_questions-child2_vacc_dates_vacc_card_visit2-child2_date_vacc_card_OPV2")]
        public string child2_date_vacc_card_OPV2 { get; set; }

        [ChoCSVRecordField(142, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_child2-questions_about_eligible_child2-child2_vaccination_card_questions-child2_vacc_dates_vacc_card_visit2-child2_date_vacc_card_Penta2_present_flag")]
        public string child2_date_vacc_card_Penta2_present_flag { get; set; }

        [ChoCSVRecordField(143, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_child2-questions_about_eligible_child2-child2_vaccination_card_questions-child2_vacc_dates_vacc_card_visit2-child2_date_vacc_card_Penta2")]
        public string child2_date_vacc_card_Penta2 { get; set; }

        [ChoCSVRecordField(144, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_child2-questions_about_eligible_child2-child2_vaccination_card_questions-child2_vacc_dates_vacc_card_visit3-child2_date_vacc_card_OPV3_present_flag")]
        public string child2_date_vacc_card_OPV3_present_flag { get; set; }

        [ChoCSVRecordField(145, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_child2-questions_about_eligible_child2-child2_vaccination_card_questions-child2_vacc_dates_vacc_card_visit3-child2_date_vacc_card_OPV3")]
        public string child2_date_vacc_card_OPV3 { get; set; }

        [ChoCSVRecordField(146, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_child2-questions_about_eligible_child2-child2_vaccination_card_questions-child2_vacc_dates_vacc_card_visit3-child2_date_vacc_card_Penta3_present_flag")]
        public string child2_date_vacc_card_Penta3_present_flag { get; set; }

        [ChoCSVRecordField(147, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_child2-questions_about_eligible_child2-child2_vaccination_card_questions-child2_vacc_dates_vacc_card_visit3-child2_date_vacc_card_Penta3")]
        public string child2_date_vacc_card_Penta3 { get; set; }

        [ChoCSVRecordField(148, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_child2-questions_about_eligible_child2-child2_vaccination_card_questions-child2_vacc_dates_vacc_card_visit4-child2_date_vacc_card_MR1_present_flag")]
        public string child2_date_vacc_card_MR1_present_flag { get; set; }

        [ChoCSVRecordField(149, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_child2-questions_about_eligible_child2-child2_vaccination_card_questions-child2_vacc_dates_vacc_card_visit4-child2_date_vacc_card_MR1")]
        public string child2_date_vacc_card_MR1 { get; set; }

        [ChoCSVRecordField(150, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_child2-questions_about_eligible_child2-child2_vaccination_card_questions-child2_vacc_dates_vacc_card_visit5-child2_date_vacc_card_MR2_present_flag")]
        public string child2_date_vacc_card_MR2_present_flag { get; set; }

        [ChoCSVRecordField(151, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_child2-questions_about_eligible_child2-child2_vaccination_card_questions-child2_vacc_dates_vacc_card_visit5-child2_date_vacc_card_MR2")]
        public string child2_date_vacc_card_MR2 { get; set; }

        [ChoCSVRecordField(152, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_child2-questions_about_eligible_child2-child2_vaccination_card_questions-child2_vacc_dates_vacc_card_visit5-child2_date_vacc_card_OPVBooster_present_flag")]
        public string child2_date_vacc_card_OPVBooster_present_flag { get; set; }

        [ChoCSVRecordField(153, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_child2-questions_about_eligible_child2-child2_vaccination_card_questions-child2_vacc_dates_vacc_card_visit5-child2_date_vacc_card_OPVBooster")]
        public string child2_date_vacc_card_OPVBooster { get; set; }

        [ChoCSVRecordField(154, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_child2-questions_about_eligible_child2-child2_vaccination_card_questions-child2_vacc_card_photo")]
        public string child2_vacc_card_photo { get; set; }

        [ChoCSVRecordField(155, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_child2-questions_about_eligible_child2-child2_vacc_receipt_flag")]
        public string child2_vacc_receipt_flag { get; set; }

        [ChoCSVRecordField(156, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_child2-questions_about_eligible_child2-child2_vaccination_receipt_not_available_reason")]
        public string child2_vaccination_receipt_not_available_reason { get; set; }

        [ChoCSVRecordField(157, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_child2-questions_about_eligible_child2-child2_vacc_receipt-child2_last_vacc")]
        public string child2_last_vacc { get; set; }

        [ChoCSVRecordField(158, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_child2-questions_about_eligible_child2-child2_vacc_receipt-child2_last_vacc_DUPLICATE")]
        public string child2_last_vacc_DUPLICATE { get; set; }

        [ChoCSVRecordField(159, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_child2-questions_about_eligible_child2-child2_vacc_receipt-child2_date_last_vacc_present_flag")]
        public string child2_date_last_vacc_present_flag { get; set; }

        [ChoCSVRecordField(160, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_child2-questions_about_eligible_child2-child2_vacc_receipt-child2_date_last_vacc")]
        public string child2_date_last_vacc { get; set; }

        [ChoCSVRecordField(161, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_child2-questions_about_eligible_child2-child2_vacc_receipt-child2_vacc_receipt_photo_consent")]
        public string child2_vacc_receipt_photo_consent { get; set; }

        [ChoCSVRecordField(162, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_child2-questions_about_eligible_child2-child2_vacc_receipt-child2_date_last_vacc_photo")]
        public string child2_date_last_vacc_photo { get; set; }

        [ChoCSVRecordField(163, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_child2-questions_about_eligible_child2-child2_vacc_dates_pure_recall-child2_number_of_vacc_visits")]
        public string child2_number_of_vacc_visits { get; set; }

        [ChoCSVRecordField(164, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_child2-questions_about_eligible_child2-child2_vacc_dates_pure_recall-child2_last_vacc_date_recall_confidence")]
        public string child2_last_vacc_date_recall_confidence { get; set; }

        [ChoCSVRecordField(165, FieldName = @"preliminary_consent_given-eligible-main-questions_about_child1-questions_about_child2-questions_about_eligible_child2-child2_vacc_dates_pure_recall-child2_date_recall_last_vacc_visit")]
        public string child2_date_recall_last_vacc_visit { get; set; }

        [ChoCSVRecordField(166, FieldName = @"preliminary_consent_given-eligible-main-after_children_endtime")]
        public string after_children_endtime { get; set; }

        [ChoCSVRecordField(167, FieldName = @"preliminary_consent_given-eligible-main-random_p")]
        public string random_p { get; set; }

        [ChoCSVRecordField(168, FieldName = @"preliminary_consent_given-eligible-main-past_sms_vaccination_reminders")]
        public string past_sms_vaccination_reminders { get; set; }

        [ChoCSVRecordField(169, FieldName = @"preliminary_consent_given-eligible-main-past_voice_vaccination_reminders-past_voice_vaccination_reminders_flag")]
        public string past_voice_vaccination_reminders_flag { get; set; }

        [ChoCSVRecordField(170, FieldName = @"preliminary_consent_given-eligible-main-past_voice_vaccination_reminders-past_voice_message_provider")]
        public string past_voice_message_provider { get; set; }

        [ChoCSVRecordField(171, FieldName = @"preliminary_consent_given-eligible-main-past_voice_vaccination_reminders-past_voice_message_provider_other")]
        public string past_voice_message_provider_other { get; set; }

        [ChoCSVRecordField(172, FieldName = @"preliminary_consent_given-eligible-main-respondent_literacy_level")]
        public string respondent_literacy_level { get; set; }

        [ChoCSVRecordField(173, FieldName = @"preliminary_consent_given-eligible-main-message_for_eligible_child1-child1_advice_message_read")]
        public string child1_advice_message_read { get; set; }

        [ChoCSVRecordField(174, FieldName = @"preliminary_consent_given-eligible-main-message_for_eligible_child2-child2_advice_message_read")]
        public string child2_advice_message_read { get; set; }

        [ChoCSVRecordField(175, FieldName = @"preliminary_consent_given-eligible-main-message_for_pregnant_mother-days_remaining_for_next_prenatal_visit")]
        public string days_remaining_for_next_prenatal_visit { get; set; }

        [ChoCSVRecordField(176, FieldName = @"preliminary_consent_given-eligible-main-message_for_pregnant_mother-pregnant_mother_advice_message_read")]
        public string pregnant_mother_advice_message_read { get; set; }

        [ChoCSVRecordField(177, FieldName = @"survey_penultimate_time")]
        public string survey_penultimate_time { get; set; }

        [ChoCSVRecordField(178, FieldName = @"survey_location_last-Latitude")]
        public string survey_location_last_Latitude { get; set; }

        [ChoCSVRecordField(179, FieldName = @"survey_location_last-Longitude")]
        public string survey_location_last_Longitude { get; set; }

        [ChoCSVRecordField(180, FieldName = @"survey_location_last-Altitude")]
        public string survey_location_last_Altitude { get; set; }

        [ChoCSVRecordField(181, FieldName = @"survey_location_last-Accuracy")]
        public string survey_location_last_Accuracy { get; set; }

        [ChoCSVRecordField(182, FieldName = @"survey_last_time")]
        public string survey_last_time { get; set; }

        [ChoCSVRecordField(183, FieldName = @"meta-instanceID")]
        public string instanceID { get; set; }

        [ChoCSVRecordField(184, FieldName = @"formdef_version")]
        public string formdef_version { get; set; }

        [ChoCSVRecordField(185, FieldName = @"review_quality")]
        public string review_quality { get; set; }

        [ChoCSVRecordField(186, FieldName = @"KEY")]
        public string KEY { get; set; }

        public Child GetChild(ChildSelect select)
        {
            switch (select)
            {
                case ChildSelect.child1:
                    return new Child
                    {
                        Name = child1s_name,
                        ChildDob = GetMax(new string[] { child1s_dob, child1s_dob_vacc_card }),
                        MmrBaseDate = GetMax(new string[] { child1_date_vacc_card_MR1, child1_date_vacc_card_MR2 }),
                        PentaBaseDate = GetMax(new string[] { child1_date_vacc_card_Penta1, child1_date_vacc_card_Penta2, child1_date_vacc_card_Penta3 }),
                        PrenatalBaseDate = GetMax(new string[] { child1s_dob, child1s_dob_vacc_card }),                        
                    };
                case ChildSelect.child2:
                    return new Child
                    {
                        Name = child1s_name,
                        ChildDob = GetMax(new string[] { child2s_dob, child2s_dob_vacc_card }),
                        MmrBaseDate = GetMax(new string[] { child2_date_vacc_card_MR1, child2_date_vacc_card_MR2 }),
                        PentaBaseDate = GetMax(new string[] { child2_date_vacc_card_Penta1, child2_date_vacc_card_Penta2, child2_date_vacc_card_Penta3 }),
                        PrenatalBaseDate = GetMax(new string[] { child2s_dob, child2s_dob_vacc_card }),
                    };
                default:
                    throw new Exception("invalid select");
            }           
        }

        public Recipient GetRecipient(RecipientSelect select, ChildSelect child)
        {
            switch (select)
            {
                case RecipientSelect.Mother:
                    return new Recipient
                    {
                        Name = mothers_name,
                        MotherName = mothers_name,
                        PhoneNumber = mothers_contact_number,
                        SourceType = "PartnerSurvey20190223-" + select.ToString() + "-" + child.ToString(),
                        SourceKey = KEY + "-" + select.ToString() + "-" + child.ToString(),
                        SourceDate = Utils.DateTimeSurveyCTOStringConverter.ConvertSurveyCTODateTimeToDateTime(SubmissionDate),
                        GroupNames = GetGroupNames(mothers_preferred_language, select)
                    };
                case RecipientSelect.Father:
                    return new Recipient
                    {
                        Name = fathers_name,
                        MotherName = mothers_name,
                        PhoneNumber = fathers_contact_number,
                        SourceType = "PartnerSurvey20190223-" + select.ToString() + "-" + child.ToString(),
                        SourceKey = KEY + "-" + select.ToString() + "-" + child.ToString(),
                        SourceDate = Utils.DateTimeSurveyCTOStringConverter.ConvertSurveyCTODateTimeToDateTime(SubmissionDate),
                        GroupNames = GetGroupNames(mothers_preferred_language, select)
                    };
                case RecipientSelect.Alternative1:
                    return new Recipient
                    {
                        Name = alternate_contact_1_name,
                        MotherName = mothers_name,
                        PhoneNumber = alternate_contact1_number,
                        SourceType = "PartnerSurvey20190223-" + select.ToString() + "-" + child.ToString(),
                        SourceKey = KEY + "-" + select.ToString() + "-" + child.ToString(),
                        SourceDate = Utils.DateTimeSurveyCTOStringConverter.ConvertSurveyCTODateTimeToDateTime(SubmissionDate),
                        GroupNames = GetGroupNames(mothers_preferred_language, select)
                    };
                case RecipientSelect.Alternative2:
                    return new Recipient
                    {
                        Name = alternate_contact_2_name,
                        MotherName = mothers_name,
                        PhoneNumber = alternate_contact2_contact_number,
                        SourceType = "PartnerSurvey20190223-" + select.ToString() + "-" + child.ToString(),
                        SourceKey = KEY + "-" + select.ToString() + "-" + child.ToString(),
                        SourceDate = Utils.DateTimeSurveyCTOStringConverter.ConvertSurveyCTODateTimeToDateTime(SubmissionDate),
                        GroupNames = GetGroupNames(mothers_preferred_language, select)
                    };
                default:
                    throw new Exception("invalid select");
            }
        }

        public string GetGroupNames(string language, RecipientSelect recipient)
        {
            return string.Concat(language, "-", recipient.ToString(), ",", language, "-all");
        }

        public DateTime GetMax(IEnumerable<string> surveyCTOdates)
        {
            return (from val in surveyCTOdates select Utils.DateTimeSurveyCTOStringConverter.ConvertToDateTimeNullable(val)).Max(v=> v.GetValueOrDefault());
        }

        public IEnumerable<DateTime?> ConvertSurveyCTODates(IEnumerable<string> surveyCTOdates)
        {
            return (from val in surveyCTOdates select Utils.DateTimeSurveyCTOStringConverter.ConvertToDateTimeNullable(val));
        }
        
    }

    public class Recipient
    {
        public string Name { get; set; }
        public string MotherName { get; set; }
        public string SourceType { get; set; }
        public string SourceKey { get; set; }        
        public DateTime SourceDate { get; set; }
        public string PhoneNumber { get; set; }
        public string GroupNames { get; set; }
    }

    public class Child
    {       
        public string Name { get; set; }
        public DateTime ChildDob { get; set; }
        public DateTime MmrBaseDate { get; set; }   
        public DateTime PentaBaseDate { get; set; }
        public DateTime PrenatalBaseDate { get; set; }

    }


    public enum ChildSelect
    {
        child1,
        child2
    }

    public enum RecipientSelect
    {
        Mother,
        Father,
        Alternative1,
        Alternative2
    }
}
