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
    public class SnapshotRuleApiController : ControllerBase
    { 
        /// <summary>
        /// Collection Query
        /// </summary>
        /// <remarks>Query all snapshot rules.</remarks>
        /// <response code="200">Success</response>
        /// <response code="206">Partial content of snapshot rule instance objects</response>
        [HttpGet]
        [Route("/api/rest/snapshot_rule")]
        [ValidateModelState]
        [SwaggerOperation("SnapshotRuleGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<SnapshotRuleInstance>), description: "Success")]
        [SwaggerResponse(statusCode: 206, type: typeof(List<SnapshotRuleInstance>), description: "Partial content of snapshot rule instance objects")]
        public virtual IActionResult SnapshotRuleGet()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<SnapshotRuleInstance>));

            //TODO: Uncomment the next line to return response 206 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(206, default(List<SnapshotRuleInstance>));

            string exampleJson = null;
            exampleJson = "{}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<SnapshotRuleInstance>>(exampleJson)
            : default(List<SnapshotRuleInstance>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Clone
        /// </summary>
        /// <remarks>Clone a snapshot rule, which creates an identical copy of this snapshot rule. The resulting snapshot rule will be read-write and managed by the user.  Was added in version 3.0.0.0.</remarks>
        /// <param name="id">Unique identifier of the snapshot rule to be cloned. name:{name} can be used instead of {id}.</param>
        /// <param name="body"></param>
        /// <response code="200">Success</response>
        /// <response code="204">Success</response>
        /// <response code="400">Invalid Request</response>
        /// <response code="404">Not Found</response>
        /// <response code="422">Operation Failed</response>
        [HttpPost]
        [Route("/api/rest/snapshot_rule/{id}/clone")]
        [ValidateModelState]
        [SwaggerOperation("SnapshotRuleIdClonePost")]
        [SwaggerResponse(statusCode: 200, type: typeof(SnapshotRuleCloneResponse), description: "Success")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Invalid Request")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Not Found")]
        [SwaggerResponse(statusCode: 422, type: typeof(ErrorResponse), description: "Operation Failed")]
        public virtual IActionResult SnapshotRuleIdClonePost([FromRoute][Required]string id, [FromBody]SnapshotRuleClone body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(SnapshotRuleCloneResponse));

            //TODO: Uncomment the next line to return response 204 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(204);

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(ErrorResponse));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(ErrorResponse));

            //TODO: Uncomment the next line to return response 422 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(422, default(ErrorResponse));

            string exampleJson = null;
            exampleJson = "{\"empty\": false}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<SnapshotRuleCloneResponse>(exampleJson)
            : default(SnapshotRuleCloneResponse);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>Delete a snapshot rule. </remarks>
        /// <param name="id">Unique identifier of the snapshot rule. name:{name} can be used instead of {id}.</param>
        /// <param name="body"></param>
        /// <response code="204">Success</response>
        /// <response code="400">Invalid request</response>
        /// <response code="404">Not Found</response>
        /// <response code="422">Operation Failed</response>
        [HttpDelete]
        [Route("/api/rest/snapshot_rule/{id}")]
        [ValidateModelState]
        [SwaggerOperation("SnapshotRuleIdDelete")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Invalid request")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Not Found")]
        [SwaggerResponse(statusCode: 422, type: typeof(ErrorResponse), description: "Operation Failed")]
        public virtual IActionResult SnapshotRuleIdDelete([FromRoute][Required]string id, [FromBody]SnapshotRuleDelete body)
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
        /// <remarks>Query a specific snapshot rule.</remarks>
        /// <param name="id">Unique identifier of the snapshot rule. name:{name} can be used instead of {id}.</param>
        /// <response code="200">Success</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("/api/rest/snapshot_rule/{id}")]
        [ValidateModelState]
        [SwaggerOperation("SnapshotRuleIdGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(SnapshotRuleInstance), description: "Success")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Not Found")]
        public virtual IActionResult SnapshotRuleIdGet([FromRoute][Required]string id)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(SnapshotRuleInstance));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(ErrorResponse));

            string exampleJson = null;
            exampleJson = "{\"empty\": false}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<SnapshotRuleInstance>(exampleJson)
            : default(SnapshotRuleInstance);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Modify
        /// </summary>
        /// <remarks>Modify a snapshot rule. If the snapshot rule is associated with a policy that is currently applied to a storage resource, the modified rule is immediately applied to the associated storage resource. </remarks>
        /// <param name="id">Unique identifier of the snapshot rule. name:{name} can be used instead of {id}.</param>
        /// <param name="body"></param>
        /// <response code="204">Success</response>
        /// <response code="400">Invalid request</response>
        /// <response code="404">Not Found</response>
        /// <response code="422">Operation Failed</response>
        [HttpPatch]
        [Route("/api/rest/snapshot_rule/{id}")]
        [ValidateModelState]
        [SwaggerOperation("SnapshotRuleIdPatch")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Invalid request")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Not Found")]
        [SwaggerResponse(statusCode: 422, type: typeof(ErrorResponse), description: "Operation Failed")]
        public virtual IActionResult SnapshotRuleIdPatch([FromRoute][Required]string id, [FromBody]SnapshotRuleModify body)
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
        /// Create
        /// </summary>
        /// <remarks>Create a new snapshot rule. </remarks>
        /// <param name="body"></param>
        /// <response code="201">Success</response>
        /// <response code="400">Invalid request</response>
        /// <response code="422">Operation Failed</response>
        [HttpPost]
        [Route("/api/rest/snapshot_rule")]
        [ValidateModelState]
        [SwaggerOperation("SnapshotRulePost")]
        [SwaggerResponse(statusCode: 201, type: typeof(CreateResponse), description: "Success")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Invalid request")]
        [SwaggerResponse(statusCode: 422, type: typeof(ErrorResponse), description: "Operation Failed")]
        public virtual IActionResult SnapshotRulePost([FromBody]SnapshotRuleCreate body)
        { 
            //TODO: Uncomment the next line to return response 201 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(201, default(CreateResponse));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(ErrorResponse));

            //TODO: Uncomment the next line to return response 422 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(422, default(ErrorResponse));

            string exampleJson = null;
            exampleJson = "{\"empty\": false}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<CreateResponse>(exampleJson)
            : default(CreateResponse);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
