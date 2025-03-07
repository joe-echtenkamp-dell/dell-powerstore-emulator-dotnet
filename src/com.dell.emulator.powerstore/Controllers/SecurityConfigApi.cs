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
    public class SecurityConfigApiController : ControllerBase
    { 
        /// <summary>
        /// Collection Query
        /// </summary>
        /// <remarks>Query system security configurations.  This resource type collection query does not support filtering, sorting or pagination.</remarks>
        /// <response code="200">Success</response>
        /// <response code="206">Partial content of security config instance objects</response>
        [HttpGet]
        [Route("/api/rest/security_config")]
        [ValidateModelState]
        [SwaggerOperation("SecurityConfigGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<SecurityConfigInstance>), description: "Success")]
        [SwaggerResponse(statusCode: 206, type: typeof(List<SecurityConfigInstance>), description: "Partial content of security config instance objects")]
        public virtual IActionResult SecurityConfigGet()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<SecurityConfigInstance>));

            //TODO: Uncomment the next line to return response 206 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(206, default(List<SecurityConfigInstance>));

            string exampleJson = null;
            exampleJson = "{}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<SecurityConfigInstance>>(exampleJson)
            : default(List<SecurityConfigInstance>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Instance Query
        /// </summary>
        /// <remarks>Query a specific system security configuration.</remarks>
        /// <param name="id">Unique identifier of the instance.</param>
        /// <response code="200">Success</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("/api/rest/security_config/{id}")]
        [ValidateModelState]
        [SwaggerOperation("SecurityConfigIdGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(SecurityConfigInstance), description: "Success")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Not Found")]
        public virtual IActionResult SecurityConfigIdGet([FromRoute][Required]string id)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(SecurityConfigInstance));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(ErrorResponse));

            string exampleJson = null;
            exampleJson = "{\"empty\": false}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<SecurityConfigInstance>(exampleJson)
            : default(SecurityConfigInstance);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Modify
        /// </summary>
        /// <remarks>Modify the security configuration for the cluster. Was added in version 2.0.0.0.</remarks>
        /// <param name="id">Unique identifier of the instance.</param>
        /// <param name="body"></param>
        /// <response code="204">Success</response>
        /// <response code="400">Invalid request</response>
        /// <response code="404">Not Found</response>
        /// <response code="422">Operation Failed</response>
        [HttpPatch]
        [Route("/api/rest/security_config/{id}")]
        [ValidateModelState]
        [SwaggerOperation("SecurityConfigIdPatch")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Invalid request")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Not Found")]
        [SwaggerResponse(statusCode: 422, type: typeof(ErrorResponse), description: "Operation Failed")]
        public virtual IActionResult SecurityConfigIdPatch([FromRoute][Required]string id, [FromBody]SecurityConfigModify body)
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
