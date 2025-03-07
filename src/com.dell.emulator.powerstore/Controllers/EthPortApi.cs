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
    public class EthPortApiController : ControllerBase
    { 
        /// <summary>
        /// Collection Query
        /// </summary>
        /// <remarks>Get Ethernet front-end port configuration for all cluster nodes.</remarks>
        /// <response code="200">Success</response>
        /// <response code="206">Partial content of eth port instance objects</response>
        [HttpGet]
        [Route("/api/rest/eth_port")]
        [ValidateModelState]
        [SwaggerOperation("EthPortGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<EthPortInstance>), description: "Success")]
        [SwaggerResponse(statusCode: 206, type: typeof(List<EthPortInstance>), description: "Partial content of eth port instance objects")]
        public virtual IActionResult EthPortGet()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<EthPortInstance>));

            //TODO: Uncomment the next line to return response 206 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(206, default(List<EthPortInstance>));

            string exampleJson = null;
            exampleJson = "{}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<EthPortInstance>>(exampleJson)
            : default(List<EthPortInstance>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Instance Query
        /// </summary>
        /// <remarks>Get Ethernet front-end port configuration by instance identifier.</remarks>
        /// <param name="id">Ethernet front-end port instance identifier. name:{name} can be used instead of {id}.</param>
        /// <response code="200">Success</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("/api/rest/eth_port/{id}")]
        [ValidateModelState]
        [SwaggerOperation("EthPortIdGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(EthPortInstance), description: "Success")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Not Found")]
        public virtual IActionResult EthPortIdGet([FromRoute][Required]string id)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(EthPortInstance));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(ErrorResponse));

            string exampleJson = null;
            exampleJson = "{}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<EthPortInstance>(exampleJson)
            : default(EthPortInstance);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Modify
        /// </summary>
        /// <remarks>Change the properties of the front-end port. Note that setting the port&#39;s requested speed may not cause the port speed to change immediately. In cases where the SFP is not inserted or the port is down the requested speed will be set but the current_speed will still show the old value until the SFP is able to change speed. By default, the partner port speed on the other node in the appliance is set to the same requested speed. If the requested speed is not supported by the partner port it is left unchanged.</remarks>
        /// <param name="id">Unique identifier of the port. name:{name} can be used instead of {id}.</param>
        /// <param name="body"></param>
        /// <response code="204">Success</response>
        /// <response code="400">Invalid Request</response>
        /// <response code="404">Not Found</response>
        /// <response code="422">Operation Failed</response>
        [HttpPatch]
        [Route("/api/rest/eth_port/{id}")]
        [ValidateModelState]
        [SwaggerOperation("EthPortIdPatch")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Invalid Request")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Not Found")]
        [SwaggerResponse(statusCode: 422, type: typeof(ErrorResponse), description: "Operation Failed")]
        public virtual IActionResult EthPortIdPatch([FromRoute][Required]string id, [FromBody]EthPortModify body)
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
