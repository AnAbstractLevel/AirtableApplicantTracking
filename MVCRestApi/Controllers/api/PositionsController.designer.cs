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
    public partial class PositionsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Position> Positions);
        partial void OnAfterGetById(Position Positions, String positionId);
        partial void OnBeforePost(Position position);
        partial void OnAfterPost(Position position);
        partial void OnBeforePut(Position position);
        partial void OnAfterPut(Position position);
        partial void OnBeforeDelete(Position position);
        partial void OnAfterDelete(Position position);
        

        public PositionsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }

        /// <summary>
        /// GET api/Position - Gets a list of Positions
        /// </summary>
        /// <returns>List of Positions</returns>
        public IEnumerable<Position> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllPositions<Position>()
                            .OrderBy(orderBy => orderBy.Name);
            dc.Position.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        /// <summary>
        /// Gets a specific Position based on it's ID
        /// </summary>
        /// <returns>Position</returns>
        public Position Get(String positionId)
        {
            var PositionsWhere = String.Format("PositionId = '{0}'", positionId);
            var result = this.SDM.GetAllPositions<Position>(PositionsWhere).FirstOrDefault();
            dc.Position.CheckExpand(this.SDM, new Position[] { result }, HttpContext.Current.Request["expand"]);
            this.OnAfterGetById(result, positionId);
            return result;
        }

        /// <summary>
        /// Inserts a new Position
        /// </summary>
        /// <returns>The inserted Position, including the ID assigned</returns>
        public Position Post([FromBody]Position position)
        {// text
            
            if (String.IsNullOrEmpty(position.PositionId)) position.PositionId = Guid.NewGuid().ToString();
            this.OnBeforePost(position);
            this.SDM.Upsert(position);
            this.OnAfterPost(position);
            return position;
        }

        /// <summary>
        /// Updates a specific Position based on it's ID
        /// </summary>
        /// <returns>Position</returns>
        public Position Put([FromBody]Position position)
        {
            
            if (String.IsNullOrEmpty(position.PositionId)) position.PositionId = Guid.NewGuid().ToString();
            this.OnBeforePut(position);
            this.SDM.Upsert(position);
            this.OnAfterPut(position);
            return position;
        }

        /// <summary>
        /// Deletes a specific Position based on it's ID
        /// </summary>
        /// <returns>Position</returns>
        public void Delete(Guid PositionId)
        {
            var positionWhere = String.Format("PositionId = '{0}'", PositionId);
            var position = this.SDM.GetAllPositions<Position>(positionWhere).FirstOrDefault();
            this.OnBeforeDelete(position);
            this.SDM.Delete(position);
            this.OnAfterDelete(position);
        }
    }
}
