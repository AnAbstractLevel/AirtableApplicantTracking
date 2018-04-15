using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using AirtableApplicantTracking.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace AirtableApplicantTracking.Lib.DataClasses
{                            
    public partial class Interviewer
    {
        private void InitPoco()
        {
            
            
                this.OnsiteInterviewer_Applicants = new BindingList<Applicant>();
            
                this.PhoneScreenInterviewer_Applicants = new BindingList<Applicant>();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "InterviewerId")]
        public String InterviewerId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "createdTime")]
        public Nullable<DateTime> createdTime { get; set; }
    

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "OnsiteInterviewer_Applicants")]
        public BindingList<Applicant> OnsiteInterviewer_Applicants { get; set; }
            
        /// <summary>
        /// Check to see if there are any related Applicants, and load them if requested
        /// </summary>
        public static void CheckExpandApplicants(SqlDataManager sdm, IEnumerable<Interviewer> interviewers, string expandString)
        {
            expandString = expandString.SafeToString();

            if (String.Equals(expandString, "all", StringComparison.OrdinalIgnoreCase) || expandString.IndexOf("applicants", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                var interviewersWhere = CreateInterviewerWhere(interviewers, "OnsiteInterviewer");
                var childApplicants = sdm.GetAllApplicants<Applicant>(interviewersWhere)
                .OrderBy(orderBy => orderBy.Name)
            ;

                interviewers.ToList()
                        .ForEach(feInterviewer => feInterviewer.LoadOnsiteInterviewer_Applicants(childApplicants));
            }

        }


        

        
        /// <summary>
        /// Find the related Applicants (from the list provided) and attach them locally to the Applicants list.
        /// </summary>
        public void LoadOnsiteInterviewer_Applicants(IEnumerable<Applicant> applicants)
        {
            applicants.Where(whereApplicant => whereApplicant.OnsiteInterviewer == this.InterviewerId)
                    .ToList()
                    .ForEach(feApplicant => this.OnsiteInterviewer_Applicants.Add(feApplicant));
        }
        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PhoneScreenInterviewer_Applicants")]
        public BindingList<Applicant> PhoneScreenInterviewer_Applicants { get; set; }
            
   
        
        /// <summary>
        /// Find the related Applicants (from the list provided) and attach them locally to the Applicants list.
        /// </summary>
        public void LoadPhoneScreenInterviewer_Applicants(IEnumerable<Applicant> applicants)
        {
            applicants.Where(whereApplicant => whereApplicant.PhoneScreenInterviewer == this.InterviewerId)
                    .ToList()
                    .ForEach(feApplicant => this.PhoneScreenInterviewer_Applicants.Add(feApplicant));
        }
        

        
        
        private static string CreateInterviewerWhere(IEnumerable<Interviewer> interviewers, String forignKeyFieldName = "InterviewerId")
        {
            if (!interviewers.Any()) return "1=1";
            else 
            {
                var idList = interviewers.Select(selectInterviewer => String.Format("'{0}'", selectInterviewer.InterviewerId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Interviewer> interviewers, string expandString)
        {
            
            
            
            CheckExpandApplicants(sdm, interviewers, expandString);
            
            
            CheckExpandApplicants(sdm, interviewers, expandString);
        }
        
    }
}
