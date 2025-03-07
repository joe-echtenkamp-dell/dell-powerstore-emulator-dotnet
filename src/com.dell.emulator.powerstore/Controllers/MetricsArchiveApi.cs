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
    public class MetricsArchiveApiController : ControllerBase
    { 
        /// <summary>
        /// Generate
        /// </summary>
        /// <remarks>Generate a new metrics archive from the collected metrics and config data.  Only one metrics archive generation operation may be running at a time. Was added in version 3.0.0.0.</remarks>
        /// <param name="body"></param>
        /// <response code="200">Success</response>
        /// <response code="204">Success</response>
        /// <response code="400">Invalid Request</response>
        /// <response code="422">Operation Failed</response>
        [HttpPost]
        [Route("/api/rest/metrics_archive/generate")]
        [ValidateModelState]
        [SwaggerOperation("MetricsArchiveGeneratePost")]
        [SwaggerResponse(statusCode: 200, type: typeof(MetricsArchiveGenerateResponse), description: "Success")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Invalid Request")]
        [SwaggerResponse(statusCode: 422, type: typeof(ErrorResponse), description: "Operation Failed")]
        public virtual IActionResult MetricsArchiveGeneratePost([FromBody]MetricsArchiveGenerate body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(MetricsArchiveGenerateResponse));

            //TODO: Uncomment the next line to return response 204 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(204);

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(ErrorResponse));

            //TODO: Uncomment the next line to return response 422 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(422, default(ErrorResponse));

            string exampleJson = null;
            exampleJson = "{\"empty\": false}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<MetricsArchiveGenerateResponse>(exampleJson)
            : default(MetricsArchiveGenerateResponse);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Collection Query
        /// </summary>
        /// <remarks>Query metrics archives. Was added in version 3.0.0.0.</remarks>
        /// <response code="200">Success</response>
        /// <response code="206">Partial content of metrics archive instance objects</response>
        [HttpGet]
        [Route("/api/rest/metrics_archive")]
        [ValidateModelState]
        [SwaggerOperation("MetricsArchiveGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<MetricsArchiveInstance>), description: "Success")]
        [SwaggerResponse(statusCode: 206, type: typeof(List<MetricsArchiveInstance>), description: "Partial content of metrics archive instance objects")]
        public virtual IActionResult MetricsArchiveGet()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<MetricsArchiveInstance>));

            //TODO: Uncomment the next line to return response 206 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(206, default(List<MetricsArchiveInstance>));

            string exampleJson = null;
            exampleJson = "{}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<MetricsArchiveInstance>>(exampleJson)
            : default(List<MetricsArchiveInstance>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Download Query
        /// </summary>
        /// <remarks>Download a specific metrics archive instance. Was added in version 3.0.0.0.</remarks>
        /// <param name="id">Unique identifier of the metrics archive. name:{name} can be used instead of {id}. Was added in version 3.0.0.0.</param>
        /// <response code="200">Success</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/api/rest/metrics_archive/{id}/download")]
        [ValidateModelState]
        [SwaggerOperation("MetricsArchiveIdDownloadGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(MetricsArchiveFile), description: "Success")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Not found")]
        public virtual IActionResult MetricsArchiveIdDownloadGet([FromRoute][Required]string id)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(MetricsArchiveFile));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(ErrorResponse));

            string exampleJson = null;
            exampleJson = "";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<MetricsArchiveFile>(exampleJson)
            : default(MetricsArchiveFile);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Instance Query
        /// </summary>
        /// <remarks>Query a specific metrics archive instance. Was added in version 3.0.0.0.</remarks>
        /// <param name="id">Unique identifier of the metrics archive. name:{name} can be used instead of {id}. Was added in version 3.0.0.0.</param>
        /// <response code="200">Success</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("/api/rest/metrics_archive/{id}")]
        [ValidateModelState]
        [SwaggerOperation("MetricsArchiveIdGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(MetricsArchiveInstance), description: "Success")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Not Found")]
        public virtual IActionResult MetricsArchiveIdGet([FromRoute][Required]string id)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(MetricsArchiveInstance));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(ErrorResponse));

            string exampleJson = null;
            exampleJson = "{\"empty\": false}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<MetricsArchiveInstance>(exampleJson)
            : default(MetricsArchiveInstance);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
