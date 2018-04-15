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
    public partial class InterviewersController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Interviewer> Interviewers);
        partial void OnAfterGetById(Interviewer Interviewers, String interviewerId);
        partial void OnBeforePost(Interviewer interviewer);
        partial void OnAfterPost(Interviewer interviewer);
        partial void OnBeforePut(Interviewer interviewer);
        partial void OnAfterPut(Interviewer interviewer);
        partial void OnBeforeDelete(Interviewer interviewer);
        partial void OnAfterDelete(Interviewer interviewer);
        

        public InterviewersController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }

        /// <summary>
        /// GET api/Interviewer - Gets a list of Interviewers
        /// </summary>
        /// <returns>List of Interviewers</returns>
        public IEnumerable<Interviewer> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllInterviewers<Interviewer>()
                            .OrderBy(orderBy => orderBy.Name);
            dc.Interviewer.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        /// <summary>
        /// Gets a specific Interviewer based on it's ID
        /// </summary>
        /// <returns>Interviewer</returns>
        public Interviewer Get(String interviewerId)
        {
            var InterviewersWhere = String.Format("InterviewerId = '{0}'", interviewerId);
            var result = this.SDM.GetAllInterviewers<Interviewer>(InterviewersWhere).FirstOrDefault();
            dc.Interviewer.CheckExpand(this.SDM, new Interviewer[] { result }, HttpContext.Current.Request["expand"]);
            this.OnAfterGetById(result, interviewerId);
            return result;
        }

        /// <summary>
        /// Inserts a new Interviewer
        /// </summary>
        /// <returns>The inserted Interviewer, including the ID assigned</returns>
        public Interviewer Post([FromBody]Interviewer interviewer)
        {// text
            
            if (String.IsNullOrEmpty(interviewer.InterviewerId)) interviewer.InterviewerId = Guid.NewGuid().ToString();
            this.OnBeforePost(interviewer);
            this.SDM.Upsert(interviewer);
            this.OnAfterPost(interviewer);
            return interviewer;
        }

        /// <summary>
        /// Updates a specific Interviewer based on it's ID
        /// </summary>
        /// <returns>Interviewer</returns>
        public Interviewer Put([FromBody]Interviewer interviewer)
        {
            
            if (String.IsNullOrEmpty(interviewer.InterviewerId)) interviewer.InterviewerId = Guid.NewGuid().ToString();
            this.OnBeforePut(interviewer);
            this.SDM.Upsert(interviewer);
            this.OnAfterPut(interviewer);
            return interviewer;
        }

        /// <summary>
        /// Deletes a specific Interviewer based on it's ID
        /// </summary>
        /// <returns>Interviewer</returns>
        public void Delete(Guid InterviewerId)
        {
            var interviewerWhere = String.Format("InterviewerId = '{0}'", InterviewerId);
            var interviewer = this.SDM.GetAllInterviewers<Interviewer>(interviewerWhere).FirstOrDefault();
            this.OnBeforeDelete(interviewer);
            this.SDM.Delete(interviewer);
            this.OnAfterDelete(interviewer);
        }
    }
}
