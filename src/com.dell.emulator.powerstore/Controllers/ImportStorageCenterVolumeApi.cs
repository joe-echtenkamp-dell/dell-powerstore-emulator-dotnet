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
    public class ImportStorageCenterVolumeApiController : ControllerBase
    { 
        /// <summary>
        /// Collection Query
        /// </summary>
        /// <remarks>Query SC volumes.</remarks>
        /// <response code="200">Success</response>
        /// <response code="206">Partial content of import storage center volume instance objects</response>
        [HttpGet]
        [Route("/api/rest/import_storage_center_volume")]
        [ValidateModelState]
        [SwaggerOperation("ImportStorageCenterVolumeGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<ImportStorageCenterVolumeInstance>), description: "Success")]
        [SwaggerResponse(statusCode: 206, type: typeof(List<ImportStorageCenterVolumeInstance>), description: "Partial content of import storage center volume instance objects")]
        public virtual IActionResult ImportStorageCenterVolumeGet()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<ImportStorageCenterVolumeInstance>));

            //TODO: Uncomment the next line to return response 206 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(206, default(List<ImportStorageCenterVolumeInstance>));

            string exampleJson = null;
            exampleJson = "{}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<ImportStorageCenterVolumeInstance>>(exampleJson)
            : default(List<ImportStorageCenterVolumeInstance>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Instance Query
        /// </summary>
        /// <remarks>Query a specific SC volume.</remarks>
        /// <param name="id">Unique identifier of the SC volume. name:{name} can be used instead of {id}.</param>
        /// <response code="200">Success</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("/api/rest/import_storage_center_volume/{id}")]
        [ValidateModelState]
        [SwaggerOperation("ImportStorageCenterVolumeIdGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(ImportStorageCenterVolumeInstance), description: "Success")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Not Found")]
        public virtual IActionResult ImportStorageCenterVolumeIdGet([FromRoute][Required]string id)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ImportStorageCenterVolumeInstance));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(ErrorResponse));

            string exampleJson = null;
            exampleJson = "{\"empty\": false}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ImportStorageCenterVolumeInstance>(exampleJson)
            : default(ImportStorageCenterVolumeInstance);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Return snapshot profiles
        /// </summary>
        /// <remarks>Return the snapshot profiles of an SC volume.</remarks>
        /// <param name="id">Unique identifier of the SC volume. name:{name} can be used instead of {id}.</param>
        /// <response code="200">Success</response>
        /// <response code="204">Success</response>
        /// <response code="400">Invalid request</response>
        /// <response code="404">Not Found</response>
        /// <response code="422">Operation Failed.</response>
        [HttpPost]
        [Route("/api/rest/import_storage_center_volume/{id}/import_snapshot_profiles")]
        [ValidateModelState]
        [SwaggerOperation("ImportStorageCenterVolumeIdImportSnapshotProfilesPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(ImportStorageCenterVolumeImportSnapshotProfilesResponse), description: "Success")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Invalid request")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Not Found")]
        [SwaggerResponse(statusCode: 422, type: typeof(ErrorResponse), description: "Operation Failed.")]
        public virtual IActionResult ImportStorageCenterVolumeIdImportSnapshotProfilesPost([FromRoute][Required]string id)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ImportStorageCenterVolumeImportSnapshotProfilesResponse));

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
            ? JsonConvert.DeserializeObject<ImportStorageCenterVolumeImportSnapshotProfilesResponse>(exampleJson)
            : default(ImportStorageCenterVolumeImportSnapshotProfilesResponse);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
