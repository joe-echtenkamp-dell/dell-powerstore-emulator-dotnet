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
    public class FileUserQuotaApiController : ControllerBase
    { 
        /// <summary>
        /// Collection Query
        /// </summary>
        /// <remarks>List user quota instances.</remarks>
        /// <response code="200">Success</response>
        /// <response code="206">Partial content of file user quota instance objects</response>
        [HttpGet]
        [Route("/api/rest/file_user_quota")]
        [ValidateModelState]
        [SwaggerOperation("FileUserQuotaGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<FileUserQuotaInstance>), description: "Success")]
        [SwaggerResponse(statusCode: 206, type: typeof(List<FileUserQuotaInstance>), description: "Partial content of file user quota instance objects")]
        public virtual IActionResult FileUserQuotaGet()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<FileUserQuotaInstance>));

            //TODO: Uncomment the next line to return response 206 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(206, default(List<FileUserQuotaInstance>));

            string exampleJson = null;
            exampleJson = "{}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<FileUserQuotaInstance>>(exampleJson)
            : default(List<FileUserQuotaInstance>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Instance Query
        /// </summary>
        /// <remarks>Query a user quota instance.</remarks>
        /// <param name="id">Unique identifier of the file user quota.</param>
        /// <response code="200">Success</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("/api/rest/file_user_quota/{id}")]
        [ValidateModelState]
        [SwaggerOperation("FileUserQuotaIdGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(FileUserQuotaInstance), description: "Success")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Not Found")]
        public virtual IActionResult FileUserQuotaIdGet([FromRoute][Required]string id)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(FileUserQuotaInstance));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(ErrorResponse));

            string exampleJson = null;
            exampleJson = "{\"empty\": false}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<FileUserQuotaInstance>(exampleJson)
            : default(FileUserQuotaInstance);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Modify
        /// </summary>
        /// <remarks>Modify a user quota instance.</remarks>
        /// <param name="id">Unique identifier of the file user quota.</param>
        /// <param name="body"></param>
        /// <response code="204">Success</response>
        /// <response code="400">Invalid Request</response>
        /// <response code="404">Not Found</response>
        /// <response code="422">Operation Failed</response>
        [HttpPatch]
        [Route("/api/rest/file_user_quota/{id}")]
        [ValidateModelState]
        [SwaggerOperation("FileUserQuotaIdPatch")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Invalid Request")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Not Found")]
        [SwaggerResponse(statusCode: 422, type: typeof(ErrorResponse), description: "Operation Failed")]
        public virtual IActionResult FileUserQuotaIdPatch([FromRoute][Required]string id, [FromBody]FileUserQuotaModify body)
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
        /// Refresh
        /// </summary>
        /// <remarks>Refresh the cache with the actual value of the user quota.</remarks>
        /// <param name="id">Unique identifier of the file user quota.</param>
        /// <response code="204">Success</response>
        /// <response code="400">Invalid request</response>
        /// <response code="404">Not Found</response>
        /// <response code="422">Operation Failed</response>
        [HttpPost]
        [Route("/api/rest/file_user_quota/{id}/refresh")]
        [ValidateModelState]
        [SwaggerOperation("FileUserQuotaIdRefreshPost")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Invalid request")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Not Found")]
        [SwaggerResponse(statusCode: 422, type: typeof(ErrorResponse), description: "Operation Failed")]
        public virtual IActionResult FileUserQuotaIdRefreshPost([FromRoute][Required]string id)
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
        /// <remarks>Create a user quota instance.</remarks>
        /// <param name="body"></param>
        /// <response code="201">Created</response>
        /// <response code="400">Invalid Request</response>
        /// <response code="422">Operation Failed</response>
        [HttpPost]
        [Route("/api/rest/file_user_quota")]
        [ValidateModelState]
        [SwaggerOperation("FileUserQuotaPost")]
        [SwaggerResponse(statusCode: 201, type: typeof(CreateResponse), description: "Created")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Invalid Request")]
        [SwaggerResponse(statusCode: 422, type: typeof(ErrorResponse), description: "Operation Failed")]
        public virtual IActionResult FileUserQuotaPost([FromBody]FileUserQuotaCreate body)
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
