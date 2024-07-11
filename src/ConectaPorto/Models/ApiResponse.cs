using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Options;
using RestSharp;

namespace ConectaPorto.Models
{
    public class ApiResponse<T>
    {
        public ApiResponse() {
            Errors = new Dictionary<string, string>();
        }
        public T Data { get; set; }
        public Dictionary<string, string> Errors { get; set; }
        //public ValidationProblemDetails ValidationProblemDetails { get; private set; }
        public bool HasErrors => Errors.Any();

        public static ApiResponse<T> Create(RestResponse response)
        {
            var apiResponse = new ApiResponse<T>();

            if (response.IsSuccessStatusCode)
            {
                if (!string.IsNullOrEmpty(response.Content))
                {
                    var options = new JsonSerializerOptions
                    {
                        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                        PropertyNameCaseInsensitive = true
                    };
                    apiResponse.Data = JsonSerializer.Deserialize<T>(response.Content!, options);
                }
            }
            else if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                //apiResponse.ValidationProblemDetails = JsonSerializer.Deserialize<ValidationProblemDetails>(response.Content!);
            }
            else
            {
                throw new HttpRequestException($"Erro ao fazer a requisição. Status: {response.StatusCode}");
            }
            return apiResponse;
        }


        /*public void CopyErrorsTo(ModelStateDictionary modelState)
        {
            if (ValidationProblemDetails.Errors != null && ValidationProblemDetails.Errors.Any())
            {
                foreach (var error in ValidationProblemDetails.Errors)
                {
                    modelState.AddModelError(error.Key, error.Value.FirstOrDefault());
                }
            }
        }*/

    }
}
