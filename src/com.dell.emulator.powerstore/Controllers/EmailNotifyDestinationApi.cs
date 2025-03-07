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
    public class EmailNotifyDestinationApiController : ControllerBase
    { 
        /// <summary>
        /// Collection Query
        /// </summary>
        /// <remarks>Query all email notification destinations.</remarks>
        /// <response code="200">Success</response>
        /// <response code="206">Partial content of email notify destination instance objects</response>
        [HttpGet]
        [Route("/api/rest/email_notify_destination")]
        [ValidateModelState]
        [SwaggerOperation("EmailNotifyDestinationGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<EmailNotifyDestinationInstance>), description: "Success")]
        [SwaggerResponse(statusCode: 206, type: typeof(List<EmailNotifyDestinationInstance>), description: "Partial content of email notify destination instance objects")]
        public virtual IActionResult EmailNotifyDestinationGet()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<EmailNotifyDestinationInstance>));

            //TODO: Uncomment the next line to return response 206 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(206, default(List<EmailNotifyDestinationInstance>));

            string exampleJson = null;
            exampleJson = "{}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<EmailNotifyDestinationInstance>>(exampleJson)
            : default(List<EmailNotifyDestinationInstance>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>Delete an email notification destination.</remarks>
        /// <param name="id">Unique identifier of the email notification destination.</param>
        /// <response code="204">Success</response>
        /// <response code="400">Invalid request</response>
        /// <response code="404">Not Found</response>
        /// <response code="422">Operation Failed</response>
        [HttpDelete]
        [Route("/api/rest/email_notify_destination/{id}")]
        [ValidateModelState]
        [SwaggerOperation("EmailNotifyDestinationIdDelete")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Invalid request")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Not Found")]
        [SwaggerResponse(statusCode: 422, type: typeof(ErrorResponse), description: "Operation Failed")]
        public virtual IActionResult EmailNotifyDestinationIdDelete([FromRoute][Required]string id)
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
        /// <remarks>Query a specific email notification destination.</remarks>
        /// <param name="id">Unique identifier of the email notification destination.</param>
        /// <response code="200">Success</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("/api/rest/email_notify_destination/{id}")]
        [ValidateModelState]
        [SwaggerOperation("EmailNotifyDestinationIdGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(EmailNotifyDestinationInstance), description: "Success")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Not Found")]
        public virtual IActionResult EmailNotifyDestinationIdGet([FromRoute][Required]string id)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(EmailNotifyDestinationInstance));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(ErrorResponse));

            string exampleJson = null;
            exampleJson = "{\"empty\": false}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<EmailNotifyDestinationInstance>(exampleJson)
            : default(EmailNotifyDestinationInstance);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Modify
        /// </summary>
        /// <remarks>Modify an email notification destination.</remarks>
        /// <param name="id">Unique identifier of the email notification destination.</param>
        /// <param name="body">Email address to receive notifications.</param>
        /// <response code="204">Success</response>
        /// <response code="400">Invalid Request</response>
        /// <response code="404">Not Found</response>
        /// <response code="422">Operation Failed</response>
        [HttpPatch]
        [Route("/api/rest/email_notify_destination/{id}")]
        [ValidateModelState]
        [SwaggerOperation("EmailNotifyDestinationIdPatch")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Invalid Request")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Not Found")]
        [SwaggerResponse(statusCode: 422, type: typeof(ErrorResponse), description: "Operation Failed")]
        public virtual IActionResult EmailNotifyDestinationIdPatch([FromRoute][Required]string id, [FromBody]EmailNotifyDestinationModify body)
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
        /// Test
        /// </summary>
        /// <remarks>Send a test email to an email address.</remarks>
        /// <param name="id">Unique identifier of the email notification destination.</param>
        /// <response code="204">Success</response>
        /// <response code="400">Invalid request</response>
        /// <response code="404">Not Found</response>
        /// <response code="422">Operation Failed</response>
        [HttpPost]
        [Route("/api/rest/email_notify_destination/{id}/test")]
        [ValidateModelState]
        [SwaggerOperation("EmailNotifyDestinationIdTestPost")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Invalid request")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Not Found")]
        [SwaggerResponse(statusCode: 422, type: typeof(ErrorResponse), description: "Operation Failed")]
        public virtual IActionResult EmailNotifyDestinationIdTestPost([FromRoute][Required]string id)
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
        /// <remarks>Add an email address to receive notifications.</remarks>
        /// <param name="body">Email address to receive notifications.</param>
        /// <response code="201">Created</response>
        /// <response code="400">Invalid Request</response>
        /// <response code="422">Operation Failed</response>
        [HttpPost]
        [Route("/api/rest/email_notify_destination")]
        [ValidateModelState]
        [SwaggerOperation("EmailNotifyDestinationPost")]
        [SwaggerResponse(statusCode: 201, type: typeof(CreateResponse), description: "Created")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Invalid Request")]
        [SwaggerResponse(statusCode: 422, type: typeof(ErrorResponse), description: "Operation Failed")]
        public virtual IActionResult EmailNotifyDestinationPost([FromBody]EmailNotifyDestinationCreate body)
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
