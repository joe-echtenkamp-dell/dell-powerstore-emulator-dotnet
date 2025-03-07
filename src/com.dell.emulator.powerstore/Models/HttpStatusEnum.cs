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
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Com.Dell.Emulator.Powerstore.Models
{ 
        /// <summary>
        /// Possible HTTP status values of completed or failed jobs * 200 - Successful completion, with a response body. A collection GET with no instances returns 200 and a body of \"[]\". * 201 - Successful completion of a create request, with a minimal instance response body (id only). * 202 - The request has completed by initiating a background or async activity. A job instance response body is being returned instead of a normal response. * 204 - Successful completion with no response body. Typical for deletes, modifies, and any other actions with no outputs. If all the outputs from an action are optional, that action can return 204 if none of the outputs are returned, or 200 if any are. * 206 - Successful completion with partial GET response. * 207 - Completion of bulk or composite request. Not used by individual commands. * 400 - Invalid request - some kind of validation failure. Syntactic issue with request, duplicate name when unique is required, values out of range, invalid characters in a string, etc. * 401 - Not allowed - not authenticated. * 403 - Not allowed - authorization failure. * 404 - The request is for an action on an resource that doesn't exist. This could be an invalid id in an instance URL, or an entirely invalid URL path. * 405 - The HTTP method is not supported on that URL. * 406 - Not acceptable - the server cannot satisfy the Accept: header in the request. Only application/json is supported. * 415 - Invalid request Content-Type. * 416 - Range Not Satisfiable. The client requested a starting offset (using the ?offset URL parameter, or the first value in Range header) that was larger than the number of instances in the queried result set. * 422 - Request syntax is correct, but server was not able to process it * 500 - Internal error. * 503 - Wait and try again. System is busy.  Was added in version 2.0.0.0.
        /// </summary>
        /// <value>Possible HTTP status values of completed or failed jobs * 200 - Successful completion, with a response body. A collection GET with no instances returns 200 and a body of \"[]\". * 201 - Successful completion of a create request, with a minimal instance response body (id only). * 202 - The request has completed by initiating a background or async activity. A job instance response body is being returned instead of a normal response. * 204 - Successful completion with no response body. Typical for deletes, modifies, and any other actions with no outputs. If all the outputs from an action are optional, that action can return 204 if none of the outputs are returned, or 200 if any are. * 206 - Successful completion with partial GET response. * 207 - Completion of bulk or composite request. Not used by individual commands. * 400 - Invalid request - some kind of validation failure. Syntactic issue with request, duplicate name when unique is required, values out of range, invalid characters in a string, etc. * 401 - Not allowed - not authenticated. * 403 - Not allowed - authorization failure. * 404 - The request is for an action on an resource that doesn't exist. This could be an invalid id in an instance URL, or an entirely invalid URL path. * 405 - The HTTP method is not supported on that URL. * 406 - Not acceptable - the server cannot satisfy the Accept: header in the request. Only application/json is supported. * 415 - Invalid request Content-Type. * 416 - Range Not Satisfiable. The client requested a starting offset (using the ?offset URL parameter, or the first value in Range header) that was larger than the number of instances in the queried result set. * 422 - Request syntax is correct, but server was not able to process it * 500 - Internal error. * 503 - Wait and try again. System is busy.  Was added in version 2.0.0.0.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum HttpStatusEnum
        {
            
            /// <summary>
            /// Enum _200Enum for 200
            /// </summary>
            [EnumMember(Value = "200")]
            _200Enum = 1,
            
            /// <summary>
            /// Enum _201Enum for 201
            /// </summary>
            [EnumMember(Value = "201")]
            _201Enum = 2,
            
            /// <summary>
            /// Enum _202Enum for 202
            /// </summary>
            [EnumMember(Value = "202")]
            _202Enum = 3,
            
            /// <summary>
            /// Enum _204Enum for 204
            /// </summary>
            [EnumMember(Value = "204")]
            _204Enum = 4,
            
            /// <summary>
            /// Enum _206Enum for 206
            /// </summary>
            [EnumMember(Value = "206")]
            _206Enum = 5,
            
            /// <summary>
            /// Enum _207Enum for 207
            /// </summary>
            [EnumMember(Value = "207")]
            _207Enum = 6,
            
            /// <summary>
            /// Enum _400Enum for 400
            /// </summary>
            [EnumMember(Value = "400")]
            _400Enum = 7,
            
            /// <summary>
            /// Enum _401Enum for 401
            /// </summary>
            [EnumMember(Value = "401")]
            _401Enum = 8,
            
            /// <summary>
            /// Enum _403Enum for 403
            /// </summary>
            [EnumMember(Value = "403")]
            _403Enum = 9,
            
            /// <summary>
            /// Enum _404Enum for 404
            /// </summary>
            [EnumMember(Value = "404")]
            _404Enum = 10,
            
            /// <summary>
            /// Enum _405Enum for 405
            /// </summary>
            [EnumMember(Value = "405")]
            _405Enum = 11,
            
            /// <summary>
            /// Enum _406Enum for 406
            /// </summary>
            [EnumMember(Value = "406")]
            _406Enum = 12,
            
            /// <summary>
            /// Enum _415Enum for 415
            /// </summary>
            [EnumMember(Value = "415")]
            _415Enum = 13,
            
            /// <summary>
            /// Enum _416Enum for 416
            /// </summary>
            [EnumMember(Value = "416")]
            _416Enum = 14,
            
            /// <summary>
            /// Enum _422Enum for 422
            /// </summary>
            [EnumMember(Value = "422")]
            _422Enum = 15,
            
            /// <summary>
            /// Enum _500Enum for 500
            /// </summary>
            [EnumMember(Value = "500")]
            _500Enum = 16,
            
            /// <summary>
            /// Enum _503Enum for 503
            /// </summary>
            [EnumMember(Value = "503")]
            _503Enum = 17
        }
}
