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
    public class ImportPsgroupVolumeApiController : ControllerBase
    { 
        /// <summary>
        /// Collection Query
        /// </summary>
        /// <remarks>Query PS Group volumes.</remarks>
        /// <response code="200">Success</response>
        /// <response code="206">Partial content of import psgroup volume instance objects</response>
        [HttpGet]
        [Route("/api/rest/import_psgroup_volume")]
        [ValidateModelState]
        [SwaggerOperation("ImportPsgroupVolumeGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<ImportPsgroupVolumeInstance>), description: "Success")]
        [SwaggerResponse(statusCode: 206, type: typeof(List<ImportPsgroupVolumeInstance>), description: "Partial content of import psgroup volume instance objects")]
        public virtual IActionResult ImportPsgroupVolumeGet()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<ImportPsgroupVolumeInstance>));

            //TODO: Uncomment the next line to return response 206 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(206, default(List<ImportPsgroupVolumeInstance>));

            string exampleJson = null;
            exampleJson = "{}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<ImportPsgroupVolumeInstance>>(exampleJson)
            : default(List<ImportPsgroupVolumeInstance>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Instance Query
        /// </summary>
        /// <remarks>Query a specific PS Group volume.</remarks>
        /// <param name="id">Unique identifier of the PS Group volume. name:{name} can be used instead of {id}.</param>
        /// <response code="200">Success</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("/api/rest/import_psgroup_volume/{id}")]
        [ValidateModelState]
        [SwaggerOperation("ImportPsgroupVolumeIdGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(ImportPsgroupVolumeInstance), description: "Success")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Not Found")]
        public virtual IActionResult ImportPsgroupVolumeIdGet([FromRoute][Required]string id)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ImportPsgroupVolumeInstance));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(ErrorResponse));

            string exampleJson = null;
            exampleJson = "{\"empty\": false}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ImportPsgroupVolumeInstance>(exampleJson)
            : default(ImportPsgroupVolumeInstance);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Return snapshot schedules
        /// </summary>
        /// <remarks>Return the snapshot schedules for a PS Group volume.</remarks>
        /// <param name="id">Unique identifier of the PS Group volume. name:{name} can be used instead of {id}.</param>
        /// <response code="200">Success</response>
        /// <response code="204">Success</response>
        /// <response code="400">Invalid request</response>
        /// <response code="404">Not Found</response>
        /// <response code="422">Operation Failed</response>
        [HttpPost]
        [Route("/api/rest/import_psgroup_volume/{id}/import_snapshot_schedules")]
        [ValidateModelState]
        [SwaggerOperation("ImportPsgroupVolumeIdImportSnapshotSchedulesPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(ImportPsgroupVolumeImportSnapshotSchedulesResponse), description: "Success")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Invalid request")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Not Found")]
        [SwaggerResponse(statusCode: 422, type: typeof(ErrorResponse), description: "Operation Failed")]
        public virtual IActionResult ImportPsgroupVolumeIdImportSnapshotSchedulesPost([FromRoute][Required]string id)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ImportPsgroupVolumeImportSnapshotSchedulesResponse));

            //TODO: Uncomment the next line to return response 204 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(204);

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(ErrorResponse));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(ErrorResponse));

            //TODO: Uncomment the next line to return response 422 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(422, default(ErrorResponse));

            string exampleJson = null;
            exampleJson = "{\n  \"bytes\": [],\n  \"empty\": true\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ImportPsgroupVolumeImportSnapshotSchedulesResponse>(exampleJson)
            : default(ImportPsgroupVolumeImportSnapshotSchedulesResponse);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
