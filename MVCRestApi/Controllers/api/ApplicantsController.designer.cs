using AirtableApplicantTracking.Lib.SqlDataManagement;
using AirtableApplicantTracking.Lib.DataClasses;
using dc=AirtableApplicantTracking.Lib.DataClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web;

namespace WebApplication1.Areas.RESTApi.Controllers
{
    public partial class ApplicantsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Applicant> Applicants);
        partial void OnAfterGetById(Applicant Applicants, String applicantId);
        partial void OnBeforePost(Applicant applicant);
        partial void OnAfterPost(Applicant applicant);
        partial void OnBeforePut(Applicant applicant);
        partial void OnAfterPut(Applicant applicant);
        partial void OnBeforeDelete(Applicant applicant);
        partial void OnAfterDelete(Applicant applicant);
        

        public ApplicantsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }

        /// <summary>
        /// GET api/Applicant - Gets a list of Applicants
        /// </summary>
        /// <returns>List of Applicants</returns>
        public IEnumerable<Applicant> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllApplicants<Applicant>()
                            .OrderBy(orderBy => orderBy.Name);
            dc.Applicant.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        /// <summary>
        /// Gets a specific Applicant based on it's ID
        /// </summary>
        /// <returns>Applicant</returns>
        public Applicant Get(String applicantId)
        {
            var ApplicantsWhere = String.Format("ApplicantId = '{0}'", applicantId);
            var result = this.SDM.GetAllApplicants<Applicant>(ApplicantsWhere).FirstOrDefault();
            dc.Applicant.CheckExpand(this.SDM, new Applicant[] { result }, HttpContext.Current.Request["expand"]);
            this.OnAfterGetById(result, applicantId);
            return result;
        }

        /// <summary>
        /// Inserts a new Applicant
        /// </summary>
        /// <returns>The inserted Applicant, including the ID assigned</returns>
        public Applicant Post([FromBody]Applicant applicant)
        {// text
            
            if (String.IsNullOrEmpty(applicant.ApplicantId)) applicant.ApplicantId = Guid.NewGuid().ToString();
            this.OnBeforePost(applicant);
            this.SDM.Upsert(applicant);
            this.OnAfterPost(applicant);
            return applicant;
        }

        /// <summary>
        /// Updates a specific Applicant based on it's ID
        /// </summary>
        /// <returns>Applicant</returns>
        public Applicant Put([FromBody]Applicant applicant)
        {
            
            if (String.IsNullOrEmpty(applicant.ApplicantId)) applicant.ApplicantId = Guid.NewGuid().ToString();
            this.OnBeforePut(applicant);
            this.SDM.Upsert(applicant);
            this.OnAfterPut(applicant);
            return applicant;
        }

        /// <summary>
        /// Deletes a specific Applicant based on it's ID
        /// </summary>
        /// <returns>Applicant</returns>
        public void Delete(Guid ApplicantId)
        {
            var applicantWhere = String.Format("ApplicantId = '{0}'", ApplicantId);
            var applicant = this.SDM.GetAllApplicants<Applicant>(applicantWhere).FirstOrDefault();
            this.OnBeforeDelete(applicant);
            this.SDM.Delete(applicant);
            this.OnAfterDelete(applicant);
        }
    }
}
