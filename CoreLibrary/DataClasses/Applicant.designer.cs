using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using AirtableApplicantTracking.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace AirtableApplicantTracking.Lib.DataClasses
{                            
    public partial class Applicant
    {
        private void InitPoco()
        {
            
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ApplicantId")]
        public String ApplicantId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "OnsiteInterviewer")]
        public String OnsiteInterviewer { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "OnsiteInterviewScore")]
        public String OnsiteInterviewScore { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PhoneScreenInterviewer")]
        public String PhoneScreenInterviewer { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PhoneScreenNotes")]
        public String PhoneScreenNotes { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Applyingfor")]
        public String Applyingfor { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "EmailAddress")]
        public String EmailAddress { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PhoneScreenScore")]
        public String PhoneScreenScore { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "OnsiteInterviewDate")]
        public Nullable<DateTime> OnsiteInterviewDate { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Stage")]
        public String Stage { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "OnsiteInterviewNotes")]
        public String OnsiteInterviewNotes { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Phone")]
        public String Phone { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PhoneScreenDate")]
        public Nullable<DateTime> PhoneScreenDate { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "createdTime")]
        public Nullable<DateTime> createdTime { get; set; }
    

        

        
        
        private static string CreateApplicantWhere(IEnumerable<Applicant> applicants, String forignKeyFieldName = "ApplicantId")
        {
            if (!applicants.Any()) return "1=1";
            else 
            {
                var idList = applicants.Select(selectApplicant => String.Format("'{0}'", selectApplicant.ApplicantId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Applicant> applicants, string expandString)
        {
            
        }
        
    }
}
