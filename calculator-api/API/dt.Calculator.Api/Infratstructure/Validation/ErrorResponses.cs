using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace dt.Calculator.Api.Infratstructure.Validation
{
    public class ValidationError
    {
        [JsonProperty("errorStatus")]
        public string ErrorStatus { get; set; }
        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }
        [JsonProperty("propertyName")]
        public string PropertyName { get; set; }
        [JsonProperty("attemptedValue", NullValueHandling = NullValueHandling.Ignore)]
        public object AttemptedValue { get; set; }
    }

    public class ValidationErrorResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("isError")]
        public bool IsError { get; set; }
        [JsonProperty("errorTypeCode")]
        public int ErrorTypeCode { get; set; }
        [JsonProperty("errorIdentifier")]
        public object ErrorIdentifier { get; set; }
        [JsonProperty("errors")]
        public List<ValidationError> Errors { get; set; }
    }

    /* { "error": "no response from server" } */
    public class NoResponseError
    {
        [JsonProperty("error")]
        public string Error { get; set; }
    }
}
