/*
 * PowerStore REST API
 *
 * Storage cluster REST API definition. ( For \"Try It Out\", use the cluster management IP address to load this swaggerui interface. )
 *
 * OpenAPI spec version: 4.0.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using Com.Dell.Emulator.Powerstore.Attributes;

using Microsoft.AspNetCore.Authorization;
using Com.Dell.Emulator.Powerstore.Models;

namespace Com.Dell.Emulator.Powerstore.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class ReplicationGroupApiController : ControllerBase
    { 
        /// <summary>
        /// Collection Query
        /// </summary>
        /// <remarks>Query existing replication groups. Was added in version 3.0.0.0.</remarks>
        /// <response code="200">Success</response>
        /// <response code="206">Partial content of replication group instance objects</response>
        [HttpGet]
        [Route("/api/rest/replication_group")]
        [ValidateModelState]
        [SwaggerOperation("ReplicationGroupGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<ReplicationGroupInstance>), description: "Success")]
        [SwaggerResponse(statusCode: 206, type: typeof(List<ReplicationGroupInstance>), description: "Partial content of replication group instance objects")]
        public virtual IActionResult ReplicationGroupGet()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<ReplicationGroupInstance>));

            //TODO: Uncomment the next line to return response 206 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(206, default(List<ReplicationGroupInstance>));

            string exampleJson = null;
            exampleJson = "{}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<ReplicationGroupInstance>>(exampleJson)
            : default(List<ReplicationGroupInstance>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>Delete a replication group. This method is only for cleanup after unrecoverable disaster of peer site or vCenter. Normally replication group membership and replication status should be manipulated from vSphere side. By default this operation permitted only on primary replication groups without sessions. Replication groups are normally deleted automatically and asynchronously.  Was added in version 3.0.0.0.</remarks>
        /// <param name="id">Unique identifier of the replication group to be deleted. name:{name} can be used instead of {id}.</param>
        /// <param name="body">Parameters of the replication group delete operation.</param>
        /// <response code="204">Success</response>
        /// <response code="400">Invalid request</response>
        /// <response code="404">Not Found</response>
        /// <response code="422">Operation Failed</response>
        [HttpDelete]
        [Route("/api/rest/replication_group/{id}")]
        [ValidateModelState]
        [SwaggerOperation("ReplicationGroupIdDelete")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Invalid request")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Not Found")]
        [SwaggerResponse(statusCode: 422, type: typeof(ErrorResponse), description: "Operation Failed")]
        public virtual IActionResult ReplicationGroupIdDelete([FromRoute][Required]string id, [FromBody]ReplicationGroupDelete body)
        { 
            //TODO: Uncomment the next line to return response 204 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(204);

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(ErrorResponse));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(ErrorResponse));

            //TODO: Uncomment the next line to return response 422 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(422, default(ErrorResponse));


            throw new NotImplementedException();
        }

        /// <summary>
        /// Instance Query
        /// </summary>
        /// <remarks>Get a specific replication group. Was added in version 3.0.0.0.</remarks>
        /// <param name="id">Id of the repilcation group. name:{name} can be used instead of {id}.</param>
        /// <response code="200">Success</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("/api/rest/replication_group/{id}")]
        [ValidateModelState]
        [SwaggerOperation("ReplicationGroupIdGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(ReplicationGroupInstance), description: "Success")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Not Found")]
        public virtual IActionResult ReplicationGroupIdGet([FromRoute][Required]string id)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ReplicationGroupInstance));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(ErrorResponse));

            string exampleJson = null;
            exampleJson = "{}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ReplicationGroupInstance>(exampleJson)
            : default(ReplicationGroupInstance);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Modify
        /// </summary>
        /// <remarks>Modify the properties of a replication group. Was added in version 3.0.0.0.</remarks>
        /// <param name="id">Unique identifier of the replication group to modify. name:{name} can be used instead of {id}.</param>
        /// <param name="body">Parameters of the replication group modify operation.</param>
        /// <response code="204">Success</response>
        /// <response code="400">Invalid Request</response>
        /// <response code="404">Not Found</response>
        /// <response code="422">Operation Failed</response>
        [HttpPatch]
        [Route("/api/rest/replication_group/{id}")]
        [ValidateModelState]
        [SwaggerOperation("ReplicationGroupIdPatch")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Invalid Request")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Not Found")]
        [SwaggerResponse(statusCode: 422, type: typeof(ErrorResponse), description: "Operation Failed")]
        public virtual IActionResult ReplicationGroupIdPatch([FromRoute][Required]string id, [FromBody]ReplicationGroupModify body)
        { 
            //TODO: Uncomment the next line to return response 204 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(204);

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(ErrorResponse));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(ErrorResponse));

            //TODO: Uncomment the next line to return response 422 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(422, default(ErrorResponse));


            throw new NotImplementedException();
        }
    }
}
