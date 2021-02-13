using System;

namespace NetCoreAPI.Models
{
    public class ServiceResponse<T>
    {
        public T Data { get; set; }
        public bool IsSuccess { get; set; } = true;
        public string Message { get; set; } = null;

        public DateTime ServerDateTime { get; set; } = DateTime.Now;
    }

    public static class ResponseResult
    {
        public static ServiceResponse<T> Success<T>(T data, string message = "")
        {
            return new ServiceResponse<T>
            {
                Data = data,
                Message = message
            };
        }

        public static ServiceResponse<T> Success<T>(T data)
        {
            return new ServiceResponse<T>
            {
                Data = data
            };
        }

        public static ServiceResponse<T> Failure<T>(string message) where T : class
        {
            return new ServiceResponse<T>
            {
                Data = null,
                IsSuccess = false,
                Message = message
            };
        }
    }
}