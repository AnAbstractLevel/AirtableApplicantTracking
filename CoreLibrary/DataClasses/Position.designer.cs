using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using AirtableApplicantTracking.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace AirtableApplicantTracking.Lib.DataClasses
{                            
    public partial class Position
    {
        private void InitPoco()
        {
            
            
                this.Applyingfor_Applicants = new BindingList<Applicant>();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PositionId")]
        public String PositionId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "RequiredExperience")]
        public String RequiredExperience { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "createdTime")]
        public Nullable<DateTime> createdTime { get; set; }
    

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Applyingfor_Applicants")]
        public BindingList<Applicant> Applyingfor_Applicants { get; set; }
            
        /// <summary>
        /// Check to see if there are any related Applicants, and load them if requested
        /// </summary>
        public static void CheckExpandApplicants(SqlDataManager sdm, IEnumerable<Position> positions, string expandString)
        {
            expandString = expandString.SafeToString();

            if (String.Equals(expandString, "all", StringComparison.OrdinalIgnoreCase) || expandString.IndexOf("applicants", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                var positionsWhere = CreatePositionWhere(positions, "Applyingfor");
                var childApplicants = sdm.GetAllApplicants<Applicant>(positionsWhere)
                .OrderBy(orderBy => orderBy.Name)
            ;

                positions.ToList()
                        .ForEach(fePosition => fePosition.LoadApplyingfor_Applicants(childApplicants));
            }

        }


        

        
        /// <summary>
        /// Find the related Applicants (from the list provided) and attach them locally to the Applicants list.
        /// </summary>
        public void LoadApplyingfor_Applicants(IEnumerable<Applicant> applicants)
        {
            applicants.Where(whereApplicant => whereApplicant.Applyingfor == this.PositionId)
                    .ToList()
                    .ForEach(feApplicant => this.Applyingfor_Applicants.Add(feApplicant));
        }
        

        
        
        private static string CreatePositionWhere(IEnumerable<Position> positions, String forignKeyFieldName = "PositionId")
        {
            if (!positions.Any()) return "1=1";
            else 
            {
                var idList = positions.Select(selectPosition => String.Format("'{0}'", selectPosition.PositionId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Position> positions, string expandString)
        {
            
            
            
            CheckExpandApplicants(sdm, positions, expandString);
        }
        
    }
}
